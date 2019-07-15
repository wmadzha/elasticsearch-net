using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using FluentAssertions;
using Nest;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Core.Xunit;

namespace Tests.Document.Multiple.BulkAll
{
	public class BulkAllExplicitIndexNamesApiTests : BulkAllApiTestsBase
	{
		public BulkAllExplicitIndexNamesApiTests(IntrusiveOperationCluster cluster) : base(cluster) { }

		[I] [SkipOnTeamCity]
		public void BulkAllWithExplicitIndexNamesDoesNotThrowArgumentException()
		{
			var index = CreateIndexName();
			var size = 10;
			var pages = 1;
			var seenPages = 0;
			var numberOfDocuments = size * pages;
			var documents = CreateLazyStreamOfDocuments(numberOfDocuments);

			((ConnectionSettings)Client.ConnectionSettings).DefaultIndex(null);

			var droppedDocuments = new ConcurrentBag<Tuple<BulkResponseItemBase, SmallObject>>();

			// no default index defined, instead each operation defines and explicit index name
			var observableBulk = Client.BulkAll(documents, f => f
				.MaxDegreeOfParallelism(8)
				.BackOffTime(TimeSpan.FromSeconds(10))
				.BackOffRetries(2)
				.Size(size)
				.RefreshOnCompleted()
				.RefreshIndices(index)
				.DroppedDocumentCallback((b, i) => droppedDocuments.Add(Tuple.Create(b, i)))
				.Index(null)
				.BufferToBulk((b, smallObjects) =>
				{
					foreach (var smallObject in smallObjects)
					{
						b.Index<SmallObject>(bi => bi
							.Document(smallObject)
							.Index(index)
						);
					}
				})
			);

			Func<BulkAllObserver> bulkObserverAction = () => observableBulk.Wait(TimeSpan.FromMinutes(5), b =>
			{
				Interlocked.Increment(ref seenPages);
				foreach (var item in b.Items)
				{
					item.IsValid.Should().BeTrue();
					item.Id.Should().NotBeNullOrEmpty();
				}
			});

			var bulkObserver = bulkObserverAction.Should().NotThrow().Subject;
			droppedDocuments.Take(10).Should().BeEmpty();
			bulkObserver.TotalNumberOfFailedBuffers.Should().Be(0, "All buffers are expected to be indexed");
			seenPages.Should().Be(pages, "BulkAll() did not run to completion");
			var count = Client.Count<SmallObject>(f => f.Index(index));
			count.Count.Should().Be(numberOfDocuments, "Target index should have the same document count as source index");
		}
	}
}

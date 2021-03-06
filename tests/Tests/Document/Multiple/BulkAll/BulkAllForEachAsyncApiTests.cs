﻿using System;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using FluentAssertions;
using Tests.Core.ManagedElasticsearch.Clusters;

namespace Tests.Document.Multiple.BulkAll
{
	public class BulkAllForEachAsyncApiTests : BulkAllApiTestsBase
	{
		public BulkAllForEachAsyncApiTests(IntrusiveOperationCluster cluster) : base(cluster) { }

		[I] public async Task AwaitBulkAll()
		{
			var index = CreateIndexName();

			var size = 1000;
			var pages = 10;
			var seenPages = 0;
			var numberOfDocuments = size * pages;
			var documents = CreateLazyStreamOfDocuments(numberOfDocuments);

			var tokenSource = new CancellationTokenSource();
			var observableBulk = Client.BulkAll(documents, f => f
					.MaxDegreeOfParallelism(8)
					.BackOffTime(TimeSpan.FromSeconds(10))
					.BackOffRetries(2)
					.Size(size)
					.RefreshOnCompleted()
					.Index(index)
					.BufferToBulk((r, buffer) => r.IndexMany(buffer))
				, tokenSource.Token);


			await observableBulk
				.ForEachAsync(x => Interlocked.Increment(ref seenPages), tokenSource.Token);

			seenPages.Should().Be(pages);
			var count = Client.Count<SmallObject>(f => f.Index(index));
			count.Count.Should().Be(numberOfDocuments);
		}
	}
}

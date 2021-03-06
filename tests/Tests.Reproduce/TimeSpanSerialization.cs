using System;
using System.Text;
using Elastic.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;

namespace Tests.Reproduce
{
	public class TimeSpanSerialization
	{
		[U]
		public void SerializeTimeSpansAsTicksAndStrings()
		{
			var timeSpans = new TimeSpans(TimeSpan.FromSeconds(902312));
			var client = new ElasticClient();

			var json = client.RequestResponseSerializer.SerializeToString(timeSpans);

			json.Should()
				.Be("{\"default\":9023120000000,\"defaultNullable\":9023120000000,\"string\":\"10.10:38:32\",\"stringNullable\":\"10.10:38:32\"}");

			TimeSpans deserialized;
			using (var stream = client.ConnectionSettings.MemoryStreamFactory.Create(Encoding.UTF8.GetBytes(json)))
				deserialized = client.RequestResponseSerializer.Deserialize<TimeSpans>(stream);

			timeSpans.Default.Should().Be(deserialized.Default);
			timeSpans.DefaultNullable.Should().Be(deserialized.DefaultNullable);
			timeSpans.String.Should().Be(deserialized.String);
			timeSpans.StringNullable.Should().Be(deserialized.StringNullable);
		}

		private class TimeSpans
		{
			public TimeSpans(TimeSpan timeSpan)
			{
				Default = timeSpan;
				DefaultNullable = timeSpan;
				String = timeSpan;
				StringNullable = timeSpan;
			}

			public TimeSpans()
			{
			}

			public TimeSpan Default { get; set; }

			public TimeSpan DefaultNullable { get; set; }

			[StringTimeSpan]
			public TimeSpan String { get; set; }

			[StringTimeSpan]
			public TimeSpan? StringNullable { get; set; }
		}
	}
}

using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Ml.AnomalyDetection.Apis
{
	public class DeleteExpiredDataPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line36()
		{
			// tag::f2f09bc4723805c7aaabdc83c55100fa[]
			var response0 = new SearchResponse<object>();
			// end::f2f09bc4723805c7aaabdc83c55100fa[]

			response0.MatchesExample(@"DELETE _ml/_delete_expired_data");
		}
	}
}
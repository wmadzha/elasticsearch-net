using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Indices
{
	public class AddAliasPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line12()
		{
			// tag::394aabe7029e4d0741ae6965c6fae5ac[]
			var response0 = new SearchResponse<object>();
			// end::394aabe7029e4d0741ae6965c6fae5ac[]

			response0.MatchesExample(@"PUT /twitter/_alias/alias1");
		}

		[U(Skip = "Example not implemented")]
		public void Line71()
		{
			// tag::7fe8339ce3911382a7c473f6f0c03f89[]
			var response0 = new SearchResponse<object>();
			// end::7fe8339ce3911382a7c473f6f0c03f89[]

			response0.MatchesExample(@"PUT /logs_20302801/_alias/2030");
		}

		[U(Skip = "Example not implemented")]
		public void Line83()
		{
			// tag::890f659cfc10ff8171420809bdcf7c67[]
			var response0 = new SearchResponse<object>();
			// end::890f659cfc10ff8171420809bdcf7c67[]

			response0.MatchesExample(@"PUT /users
			{
			    ""mappings"" : {
			        ""properties"" : {
			            ""user_id"" : {""type"" : ""integer""}
			        }
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line97()
		{
			// tag::83b2785e63357ab3ade51d8ec0c11917[]
			var response0 = new SearchResponse<object>();
			// end::83b2785e63357ab3ade51d8ec0c11917[]

			response0.MatchesExample(@"PUT /users/_alias/user_12
			{
			    ""routing"" : ""12"",
			    ""filter"" : {
			        ""term"" : {
			            ""user_id"" : 12
			        }
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line117()
		{
			// tag::3e1e00a08a6fbfdc3d55d69880373cd6[]
			var response0 = new SearchResponse<object>();
			// end::3e1e00a08a6fbfdc3d55d69880373cd6[]

			response0.MatchesExample(@"PUT /logs_20302801
			{
			    ""mappings"" : {
			        ""properties"" : {
			            ""year"" : {""type"" : ""integer""}
			        }
			    },
			    ""aliases"" : {
			        ""current_day"" : {},
			        ""2030"" : {
			            ""filter"" : {
			                ""term"" : {""year"" : 2030 }
			            }
			        }
			    }
			}");
		}
	}
}
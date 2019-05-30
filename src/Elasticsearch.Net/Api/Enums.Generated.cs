// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;

namespace Elasticsearch.Net
{
	[Flags, StringEnum]
	public enum ClusterStateMetric
	{
		[EnumMember(Value = "blocks")]
		Blocks = 1 << 0,
		[EnumMember(Value = "metadata")]
		Metadata = 1 << 1,
		[EnumMember(Value = "nodes")]
		Nodes = 1 << 2,
		[EnumMember(Value = "routing_table")]
		RoutingTable = 1 << 3,
		[EnumMember(Value = "routing_nodes")]
		RoutingNodes = 1 << 4,
		[EnumMember(Value = "master_node")]
		MasterNode = 1 << 5,
		[EnumMember(Value = "version")]
		Version = 1 << 6,
		[EnumMember(Value = "_all")]
		All = 1 << 7
	}

	[Flags, StringEnum]
	public enum IndicesStatsMetric
	{
		[EnumMember(Value = "completion")]
		Completion = 1 << 0,
		[EnumMember(Value = "docs")]
		Docs = 1 << 1,
		[EnumMember(Value = "fielddata")]
		Fielddata = 1 << 2,
		[EnumMember(Value = "query_cache")]
		QueryCache = 1 << 3,
		[EnumMember(Value = "flush")]
		Flush = 1 << 4,
		[EnumMember(Value = "get")]
		Get = 1 << 5,
		[EnumMember(Value = "indexing")]
		Indexing = 1 << 6,
		[EnumMember(Value = "merge")]
		Merge = 1 << 7,
		[EnumMember(Value = "request_cache")]
		RequestCache = 1 << 8,
		[EnumMember(Value = "refresh")]
		Refresh = 1 << 9,
		[EnumMember(Value = "search")]
		Search = 1 << 10,
		[EnumMember(Value = "segments")]
		Segments = 1 << 11,
		[EnumMember(Value = "store")]
		Store = 1 << 12,
		[EnumMember(Value = "warmer")]
		Warmer = 1 << 13,
		[Obsolete("Suggest stats have folded under the search stats, this alias will be removed")]
		[EnumMember(Value = "suggest")]
		Suggest = 1 << 14,
		[EnumMember(Value = "_all")]
		All = 1 << 15
	}

	[Flags, StringEnum]
	public enum NodesInfoMetric
	{
		[EnumMember(Value = "settings")]
		Settings = 1 << 0,
		[EnumMember(Value = "os")]
		Os = 1 << 1,
		[EnumMember(Value = "process")]
		Process = 1 << 2,
		[EnumMember(Value = "jvm")]
		Jvm = 1 << 3,
		[EnumMember(Value = "thread_pool")]
		ThreadPool = 1 << 4,
		[EnumMember(Value = "transport")]
		Transport = 1 << 5,
		[EnumMember(Value = "http")]
		Http = 1 << 6,
		[EnumMember(Value = "plugins")]
		Plugins = 1 << 7,
		[EnumMember(Value = "ingest")]
		Ingest = 1 << 8
	}

	[Flags, StringEnum]
	public enum NodesStatsMetric
	{
		[EnumMember(Value = "breaker")]
		Breaker = 1 << 0,
		[EnumMember(Value = "fs")]
		Fs = 1 << 1,
		[EnumMember(Value = "http")]
		Http = 1 << 2,
		[EnumMember(Value = "indices")]
		Indices = 1 << 3,
		[EnumMember(Value = "jvm")]
		Jvm = 1 << 4,
		[EnumMember(Value = "os")]
		Os = 1 << 5,
		[EnumMember(Value = "process")]
		Process = 1 << 6,
		[EnumMember(Value = "thread_pool")]
		ThreadPool = 1 << 7,
		[EnumMember(Value = "transport")]
		Transport = 1 << 8,
		[EnumMember(Value = "discovery")]
		Discovery = 1 << 9,
		[EnumMember(Value = "_all")]
		All = 1 << 10
	}

	[Flags, StringEnum]
	public enum NodesStatsIndexMetric
	{
		[EnumMember(Value = "completion")]
		Completion = 1 << 0,
		[EnumMember(Value = "docs")]
		Docs = 1 << 1,
		[EnumMember(Value = "fielddata")]
		Fielddata = 1 << 2,
		[EnumMember(Value = "query_cache")]
		QueryCache = 1 << 3,
		[EnumMember(Value = "flush")]
		Flush = 1 << 4,
		[EnumMember(Value = "get")]
		Get = 1 << 5,
		[EnumMember(Value = "indexing")]
		Indexing = 1 << 6,
		[EnumMember(Value = "merge")]
		Merge = 1 << 7,
		[EnumMember(Value = "request_cache")]
		RequestCache = 1 << 8,
		[EnumMember(Value = "refresh")]
		Refresh = 1 << 9,
		[EnumMember(Value = "search")]
		Search = 1 << 10,
		[EnumMember(Value = "segments")]
		Segments = 1 << 11,
		[EnumMember(Value = "store")]
		Store = 1 << 12,
		[EnumMember(Value = "warmer")]
		Warmer = 1 << 13,
		[Obsolete("As of 5.0 this option always returned an empty object in the response")]
		[EnumMember(Value = "suggest")]
		Suggest = 1 << 14,
		[EnumMember(Value = "_all")]
		All = 1 << 15
	}

	[Flags, StringEnum]
	public enum NodesUsageMetric
	{
		[EnumMember(Value = "rest_actions")]
		RestActions = 1 << 0,
		[EnumMember(Value = "_all")]
		All = 1 << 1
	}

	[Flags, StringEnum]
	public enum WatcherStatsMetric
	{
		[EnumMember(Value = "queued_watches")]
		QueuedWatches = 1 << 0,
		[EnumMember(Value = "current_watches")]
		CurrentWatches = 1 << 1,
		[EnumMember(Value = "pending_watches")]
		PendingWatches = 1 << 2,
		[EnumMember(Value = "_all")]
		All = 1 << 3
	}

	[StringEnum]
	public enum Refresh
	{
		[EnumMember(Value = "true")]
		True,
		[EnumMember(Value = "false")]
		False,
		[EnumMember(Value = "wait_for")]
		WaitFor
	}

	[StringEnum]
	public enum Bytes
	{
		[EnumMember(Value = "b")]
		B,
		[EnumMember(Value = "k")]
		K,
		[EnumMember(Value = "kb")]
		Kb,
		[EnumMember(Value = "m")]
		M,
		[EnumMember(Value = "mb")]
		Mb,
		[EnumMember(Value = "g")]
		G,
		[EnumMember(Value = "gb")]
		Gb,
		[EnumMember(Value = "t")]
		T,
		[EnumMember(Value = "tb")]
		Tb,
		[EnumMember(Value = "p")]
		P,
		[EnumMember(Value = "pb")]
		Pb
	}

	[StringEnum]
	public enum Health
	{
		[EnumMember(Value = "green")]
		Green,
		[EnumMember(Value = "yellow")]
		Yellow,
		[EnumMember(Value = "red")]
		Red
	}

	[StringEnum]
	public enum Size
	{
		[EnumMember(Value = "")]
		Raw,
		[EnumMember(Value = "k")]
		K,
		[EnumMember(Value = "m")]
		M,
		[EnumMember(Value = "g")]
		G,
		[EnumMember(Value = "t")]
		T,
		[EnumMember(Value = "p")]
		P
	}

	[StringEnum]
	public enum Level
	{
		[EnumMember(Value = "cluster")]
		Cluster,
		[EnumMember(Value = "indices")]
		Indices,
		[EnumMember(Value = "shards")]
		Shards
	}

	[StringEnum]
	public enum WaitForEvents
	{
		[EnumMember(Value = "immediate")]
		Immediate,
		[EnumMember(Value = "urgent")]
		Urgent,
		[EnumMember(Value = "high")]
		High,
		[EnumMember(Value = "normal")]
		Normal,
		[EnumMember(Value = "low")]
		Low,
		[EnumMember(Value = "languid")]
		Languid
	}

	[StringEnum]
	public enum WaitForStatus
	{
		[EnumMember(Value = "green")]
		Green,
		[EnumMember(Value = "yellow")]
		Yellow,
		[EnumMember(Value = "red")]
		Red
	}

	[Flags, StringEnum]
	public enum ClusterRerouteMetric
	{
		[EnumMember(Value = "blocks")]
		Blocks = 1 << 0,
		[EnumMember(Value = "metadata")]
		Metadata = 1 << 1,
		[EnumMember(Value = "nodes")]
		Nodes = 1 << 2,
		[EnumMember(Value = "routing_table")]
		RoutingTable = 1 << 3,
		[EnumMember(Value = "master_node")]
		MasterNode = 1 << 4,
		[EnumMember(Value = "version")]
		Version = 1 << 5,
		[EnumMember(Value = "_all")]
		All = 1 << 6
	}

	[StringEnum]
	public enum ExpandWildcards
	{
		[EnumMember(Value = "open")]
		Open,
		[EnumMember(Value = "closed")]
		Closed,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "all")]
		All
	}

	[StringEnum]
	public enum DefaultOperator
	{
		[EnumMember(Value = "AND")]
		And,
		[EnumMember(Value = "OR")]
		Or
	}

	[StringEnum]
	public enum VersionType
	{
		[EnumMember(Value = "internal")]
		Internal,
		[EnumMember(Value = "external")]
		External,
		[EnumMember(Value = "external_gte")]
		ExternalGte,
		[EnumMember(Value = "force")]
		Force
	}

	[StringEnum]
	public enum Conflicts
	{
		[EnumMember(Value = "abort")]
		Abort,
		[EnumMember(Value = "proceed")]
		Proceed
	}

	[StringEnum]
	public enum SearchType
	{
		[EnumMember(Value = "query_then_fetch")]
		QueryThenFetch,
		[EnumMember(Value = "dfs_query_then_fetch")]
		DfsQueryThenFetch
	}

	[StringEnum]
	public enum OpType
	{
		[EnumMember(Value = "index")]
		Index,
		[EnumMember(Value = "create")]
		Create
	}

	[StringEnum]
	public enum IndicesShardStoresStatus
	{
		[EnumMember(Value = "green")]
		Green,
		[EnumMember(Value = "yellow")]
		Yellow,
		[EnumMember(Value = "red")]
		Red,
		[EnumMember(Value = "all")]
		All
	}

	[StringEnum]
	public enum ThreadType
	{
		[EnumMember(Value = "cpu")]
		Cpu,
		[EnumMember(Value = "wait")]
		Wait,
		[EnumMember(Value = "block")]
		Block
	}

	[StringEnum]
	public enum SuggestMode
	{
		[EnumMember(Value = "missing")]
		Missing,
		[EnumMember(Value = "popular")]
		Popular,
		[EnumMember(Value = "always")]
		Always
	}

	[StringEnum]
	public enum GroupBy
	{
		[EnumMember(Value = "nodes")]
		Nodes,
		[EnumMember(Value = "parents")]
		Parents,
		[EnumMember(Value = "none")]
		None
	}

	public static class KnownEnums
	{
		private static readonly ConcurrentDictionary<Type, Func<Enum, string>> EnumStringResolvers = new ConcurrentDictionary<Type, Func<Enum, string>>();
		static KnownEnums()
		{
			EnumStringResolvers.TryAdd(typeof(ClusterStateMetric), (e) => GetStringValue((ClusterStateMetric)e));
			EnumStringResolvers.TryAdd(typeof(IndicesStatsMetric), (e) => GetStringValue((IndicesStatsMetric)e));
			EnumStringResolvers.TryAdd(typeof(NodesInfoMetric), (e) => GetStringValue((NodesInfoMetric)e));
			EnumStringResolvers.TryAdd(typeof(NodesStatsMetric), (e) => GetStringValue((NodesStatsMetric)e));
			EnumStringResolvers.TryAdd(typeof(NodesStatsIndexMetric), (e) => GetStringValue((NodesStatsIndexMetric)e));
			EnumStringResolvers.TryAdd(typeof(NodesUsageMetric), (e) => GetStringValue((NodesUsageMetric)e));
			EnumStringResolvers.TryAdd(typeof(WatcherStatsMetric), (e) => GetStringValue((WatcherStatsMetric)e));
			EnumStringResolvers.TryAdd(typeof(Refresh), (e) => GetStringValue((Refresh)e));
			EnumStringResolvers.TryAdd(typeof(Bytes), (e) => GetStringValue((Bytes)e));
			EnumStringResolvers.TryAdd(typeof(Health), (e) => GetStringValue((Health)e));
			EnumStringResolvers.TryAdd(typeof(Size), (e) => GetStringValue((Size)e));
			EnumStringResolvers.TryAdd(typeof(Level), (e) => GetStringValue((Level)e));
			EnumStringResolvers.TryAdd(typeof(WaitForEvents), (e) => GetStringValue((WaitForEvents)e));
			EnumStringResolvers.TryAdd(typeof(WaitForStatus), (e) => GetStringValue((WaitForStatus)e));
			EnumStringResolvers.TryAdd(typeof(ClusterRerouteMetric), (e) => GetStringValue((ClusterRerouteMetric)e));
			EnumStringResolvers.TryAdd(typeof(ExpandWildcards), (e) => GetStringValue((ExpandWildcards)e));
			EnumStringResolvers.TryAdd(typeof(DefaultOperator), (e) => GetStringValue((DefaultOperator)e));
			EnumStringResolvers.TryAdd(typeof(VersionType), (e) => GetStringValue((VersionType)e));
			EnumStringResolvers.TryAdd(typeof(Conflicts), (e) => GetStringValue((Conflicts)e));
			EnumStringResolvers.TryAdd(typeof(SearchType), (e) => GetStringValue((SearchType)e));
			EnumStringResolvers.TryAdd(typeof(OpType), (e) => GetStringValue((OpType)e));
			EnumStringResolvers.TryAdd(typeof(IndicesShardStoresStatus), (e) => GetStringValue((IndicesShardStoresStatus)e));
			EnumStringResolvers.TryAdd(typeof(ThreadType), (e) => GetStringValue((ThreadType)e));
			EnumStringResolvers.TryAdd(typeof(SuggestMode), (e) => GetStringValue((SuggestMode)e));
			EnumStringResolvers.TryAdd(typeof(GroupBy), (e) => GetStringValue((GroupBy)e));
		}

		private class EnumDictionary : Dictionary<Enum, string>
		{
			public EnumDictionary(int capacity): base(capacity)
			{
			}

			public Func<Enum, string> Resolver
			{
				get;
				set;
			}
		}

		public static string GetStringValue(this ClusterStateMetric enumValue)
		{
			if ((enumValue & ClusterStateMetric.All) != 0)
				return "_all";
			var list = new List<string>();
			if ((enumValue & ClusterStateMetric.Blocks) != 0)
				list.Add("blocks");
			if ((enumValue & ClusterStateMetric.Metadata) != 0)
				list.Add("metadata");
			if ((enumValue & ClusterStateMetric.Nodes) != 0)
				list.Add("nodes");
			if ((enumValue & ClusterStateMetric.RoutingTable) != 0)
				list.Add("routing_table");
			if ((enumValue & ClusterStateMetric.RoutingNodes) != 0)
				list.Add("routing_nodes");
			if ((enumValue & ClusterStateMetric.MasterNode) != 0)
				list.Add("master_node");
			if ((enumValue & ClusterStateMetric.Version) != 0)
				list.Add("version");
			return string.Join(",", list);
		}

		public static string GetStringValue(this IndicesStatsMetric enumValue)
		{
			if ((enumValue & IndicesStatsMetric.All) != 0)
				return "_all";
			var list = new List<string>();
			if ((enumValue & IndicesStatsMetric.Completion) != 0)
				list.Add("completion");
			if ((enumValue & IndicesStatsMetric.Docs) != 0)
				list.Add("docs");
			if ((enumValue & IndicesStatsMetric.Fielddata) != 0)
				list.Add("fielddata");
			if ((enumValue & IndicesStatsMetric.QueryCache) != 0)
				list.Add("query_cache");
			if ((enumValue & IndicesStatsMetric.Flush) != 0)
				list.Add("flush");
			if ((enumValue & IndicesStatsMetric.Get) != 0)
				list.Add("get");
			if ((enumValue & IndicesStatsMetric.Indexing) != 0)
				list.Add("indexing");
			if ((enumValue & IndicesStatsMetric.Merge) != 0)
				list.Add("merge");
			if ((enumValue & IndicesStatsMetric.RequestCache) != 0)
				list.Add("request_cache");
			if ((enumValue & IndicesStatsMetric.Refresh) != 0)
				list.Add("refresh");
			if ((enumValue & IndicesStatsMetric.Search) != 0)
				list.Add("search");
			if ((enumValue & IndicesStatsMetric.Segments) != 0)
				list.Add("segments");
			if ((enumValue & IndicesStatsMetric.Store) != 0)
				list.Add("store");
			if ((enumValue & IndicesStatsMetric.Warmer) != 0)
				list.Add("warmer");
#pragma warning disable 618
			if ((enumValue & IndicesStatsMetric.Suggest) != 0)
				list.Add("suggest");
#pragma warning restore 618
			return string.Join(",", list);
		}

		public static string GetStringValue(this NodesInfoMetric enumValue)
		{
			var list = new List<string>();
			if ((enumValue & NodesInfoMetric.Settings) != 0)
				list.Add("settings");
			if ((enumValue & NodesInfoMetric.Os) != 0)
				list.Add("os");
			if ((enumValue & NodesInfoMetric.Process) != 0)
				list.Add("process");
			if ((enumValue & NodesInfoMetric.Jvm) != 0)
				list.Add("jvm");
			if ((enumValue & NodesInfoMetric.ThreadPool) != 0)
				list.Add("thread_pool");
			if ((enumValue & NodesInfoMetric.Transport) != 0)
				list.Add("transport");
			if ((enumValue & NodesInfoMetric.Http) != 0)
				list.Add("http");
			if ((enumValue & NodesInfoMetric.Plugins) != 0)
				list.Add("plugins");
			if ((enumValue & NodesInfoMetric.Ingest) != 0)
				list.Add("ingest");
			return string.Join(",", list);
		}

		public static string GetStringValue(this NodesStatsMetric enumValue)
		{
			if ((enumValue & NodesStatsMetric.All) != 0)
				return "_all";
			var list = new List<string>();
			if ((enumValue & NodesStatsMetric.Breaker) != 0)
				list.Add("breaker");
			if ((enumValue & NodesStatsMetric.Fs) != 0)
				list.Add("fs");
			if ((enumValue & NodesStatsMetric.Http) != 0)
				list.Add("http");
			if ((enumValue & NodesStatsMetric.Indices) != 0)
				list.Add("indices");
			if ((enumValue & NodesStatsMetric.Jvm) != 0)
				list.Add("jvm");
			if ((enumValue & NodesStatsMetric.Os) != 0)
				list.Add("os");
			if ((enumValue & NodesStatsMetric.Process) != 0)
				list.Add("process");
			if ((enumValue & NodesStatsMetric.ThreadPool) != 0)
				list.Add("thread_pool");
			if ((enumValue & NodesStatsMetric.Transport) != 0)
				list.Add("transport");
			if ((enumValue & NodesStatsMetric.Discovery) != 0)
				list.Add("discovery");
			return string.Join(",", list);
		}

		public static string GetStringValue(this NodesStatsIndexMetric enumValue)
		{
			if ((enumValue & NodesStatsIndexMetric.All) != 0)
				return "_all";
			var list = new List<string>();
			if ((enumValue & NodesStatsIndexMetric.Completion) != 0)
				list.Add("completion");
			if ((enumValue & NodesStatsIndexMetric.Docs) != 0)
				list.Add("docs");
			if ((enumValue & NodesStatsIndexMetric.Fielddata) != 0)
				list.Add("fielddata");
			if ((enumValue & NodesStatsIndexMetric.QueryCache) != 0)
				list.Add("query_cache");
			if ((enumValue & NodesStatsIndexMetric.Flush) != 0)
				list.Add("flush");
			if ((enumValue & NodesStatsIndexMetric.Get) != 0)
				list.Add("get");
			if ((enumValue & NodesStatsIndexMetric.Indexing) != 0)
				list.Add("indexing");
			if ((enumValue & NodesStatsIndexMetric.Merge) != 0)
				list.Add("merge");
			if ((enumValue & NodesStatsIndexMetric.RequestCache) != 0)
				list.Add("request_cache");
			if ((enumValue & NodesStatsIndexMetric.Refresh) != 0)
				list.Add("refresh");
			if ((enumValue & NodesStatsIndexMetric.Search) != 0)
				list.Add("search");
			if ((enumValue & NodesStatsIndexMetric.Segments) != 0)
				list.Add("segments");
			if ((enumValue & NodesStatsIndexMetric.Store) != 0)
				list.Add("store");
			if ((enumValue & NodesStatsIndexMetric.Warmer) != 0)
				list.Add("warmer");
#pragma warning disable 618
			if ((enumValue & NodesStatsIndexMetric.Suggest) != 0)
				list.Add("suggest");
#pragma warning restore 618
			return string.Join(",", list);
		}

		public static string GetStringValue(this NodesUsageMetric enumValue)
		{
			if ((enumValue & NodesUsageMetric.All) != 0)
				return "_all";
			var list = new List<string>();
			if ((enumValue & NodesUsageMetric.RestActions) != 0)
				list.Add("rest_actions");
			return string.Join(",", list);
		}

		public static string GetStringValue(this WatcherStatsMetric enumValue)
		{
			if ((enumValue & WatcherStatsMetric.All) != 0)
				return "_all";
			var list = new List<string>();
			if ((enumValue & WatcherStatsMetric.QueuedWatches) != 0)
				list.Add("queued_watches");
			if ((enumValue & WatcherStatsMetric.CurrentWatches) != 0)
				list.Add("current_watches");
			if ((enumValue & WatcherStatsMetric.PendingWatches) != 0)
				list.Add("pending_watches");
			return string.Join(",", list);
		}

		public static string GetStringValue(this Refresh enumValue)
		{
			switch (enumValue)
			{
				case Refresh.True:
					return "true";
				case Refresh.False:
					return "false";
				case Refresh.WaitFor:
					return "wait_for";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'Refresh'");
		}

		public static string GetStringValue(this Bytes enumValue)
		{
			switch (enumValue)
			{
				case Bytes.B:
					return "b";
				case Bytes.K:
					return "k";
				case Bytes.Kb:
					return "kb";
				case Bytes.M:
					return "m";
				case Bytes.Mb:
					return "mb";
				case Bytes.G:
					return "g";
				case Bytes.Gb:
					return "gb";
				case Bytes.T:
					return "t";
				case Bytes.Tb:
					return "tb";
				case Bytes.P:
					return "p";
				case Bytes.Pb:
					return "pb";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'Bytes'");
		}

		public static string GetStringValue(this Health enumValue)
		{
			switch (enumValue)
			{
				case Health.Green:
					return "green";
				case Health.Yellow:
					return "yellow";
				case Health.Red:
					return "red";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'Health'");
		}

		public static string GetStringValue(this Size enumValue)
		{
			switch (enumValue)
			{
				case Size.Raw:
					return "";
				case Size.K:
					return "k";
				case Size.M:
					return "m";
				case Size.G:
					return "g";
				case Size.T:
					return "t";
				case Size.P:
					return "p";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'Size'");
		}

		public static string GetStringValue(this Level enumValue)
		{
			switch (enumValue)
			{
				case Level.Cluster:
					return "cluster";
				case Level.Indices:
					return "indices";
				case Level.Shards:
					return "shards";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'Level'");
		}

		public static string GetStringValue(this WaitForEvents enumValue)
		{
			switch (enumValue)
			{
				case WaitForEvents.Immediate:
					return "immediate";
				case WaitForEvents.Urgent:
					return "urgent";
				case WaitForEvents.High:
					return "high";
				case WaitForEvents.Normal:
					return "normal";
				case WaitForEvents.Low:
					return "low";
				case WaitForEvents.Languid:
					return "languid";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'WaitForEvents'");
		}

		public static string GetStringValue(this WaitForStatus enumValue)
		{
			switch (enumValue)
			{
				case WaitForStatus.Green:
					return "green";
				case WaitForStatus.Yellow:
					return "yellow";
				case WaitForStatus.Red:
					return "red";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'WaitForStatus'");
		}

		public static string GetStringValue(this ClusterRerouteMetric enumValue)
		{
			if ((enumValue & ClusterRerouteMetric.All) != 0)
				return "_all";
			var list = new List<string>();
			if ((enumValue & ClusterRerouteMetric.Blocks) != 0)
				list.Add("blocks");
			if ((enumValue & ClusterRerouteMetric.Metadata) != 0)
				list.Add("metadata");
			if ((enumValue & ClusterRerouteMetric.Nodes) != 0)
				list.Add("nodes");
			if ((enumValue & ClusterRerouteMetric.RoutingTable) != 0)
				list.Add("routing_table");
			if ((enumValue & ClusterRerouteMetric.MasterNode) != 0)
				list.Add("master_node");
			if ((enumValue & ClusterRerouteMetric.Version) != 0)
				list.Add("version");
			return string.Join(",", list);
		}

		public static string GetStringValue(this ExpandWildcards enumValue)
		{
			switch (enumValue)
			{
				case ExpandWildcards.Open:
					return "open";
				case ExpandWildcards.Closed:
					return "closed";
				case ExpandWildcards.None:
					return "none";
				case ExpandWildcards.All:
					return "all";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'ExpandWildcards'");
		}

		public static string GetStringValue(this DefaultOperator enumValue)
		{
			switch (enumValue)
			{
				case DefaultOperator.And:
					return "AND";
				case DefaultOperator.Or:
					return "OR";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'DefaultOperator'");
		}

		public static string GetStringValue(this VersionType enumValue)
		{
			switch (enumValue)
			{
				case VersionType.Internal:
					return "internal";
				case VersionType.External:
					return "external";
				case VersionType.ExternalGte:
					return "external_gte";
				case VersionType.Force:
					return "force";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'VersionType'");
		}

		public static string GetStringValue(this Conflicts enumValue)
		{
			switch (enumValue)
			{
				case Conflicts.Abort:
					return "abort";
				case Conflicts.Proceed:
					return "proceed";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'Conflicts'");
		}

		public static string GetStringValue(this SearchType enumValue)
		{
			switch (enumValue)
			{
				case SearchType.QueryThenFetch:
					return "query_then_fetch";
				case SearchType.DfsQueryThenFetch:
					return "dfs_query_then_fetch";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'SearchType'");
		}

		public static string GetStringValue(this OpType enumValue)
		{
			switch (enumValue)
			{
				case OpType.Index:
					return "index";
				case OpType.Create:
					return "create";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'OpType'");
		}

		public static string GetStringValue(this IndicesShardStoresStatus enumValue)
		{
			switch (enumValue)
			{
				case IndicesShardStoresStatus.Green:
					return "green";
				case IndicesShardStoresStatus.Yellow:
					return "yellow";
				case IndicesShardStoresStatus.Red:
					return "red";
				case IndicesShardStoresStatus.All:
					return "all";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'IndicesShardStoresStatus'");
		}

		public static string GetStringValue(this ThreadType enumValue)
		{
			switch (enumValue)
			{
				case ThreadType.Cpu:
					return "cpu";
				case ThreadType.Wait:
					return "wait";
				case ThreadType.Block:
					return "block";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'ThreadType'");
		}

		public static string GetStringValue(this SuggestMode enumValue)
		{
			switch (enumValue)
			{
				case SuggestMode.Missing:
					return "missing";
				case SuggestMode.Popular:
					return "popular";
				case SuggestMode.Always:
					return "always";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'SuggestMode'");
		}

		public static string GetStringValue(this GroupBy enumValue)
		{
			switch (enumValue)
			{
				case GroupBy.Nodes:
					return "nodes";
				case GroupBy.Parents:
					return "parents";
				case GroupBy.None:
					return "none";
			}

			throw new ArgumentException($"'{enumValue.ToString()}' is not a valid value for enum 'GroupBy'");
		}

		public static string GetStringValue(this Enum e)
		{
			var type = e.GetType();
			var resolver = EnumStringResolvers.GetOrAdd(type, GetEnumStringResolver);
			return resolver(e);
		}

		private static Func<Enum, string> GetEnumStringResolver(Type type)
		{
			var values = Enum.GetValues(type);
			var dictionary = new EnumDictionary(values.Length);
			for (int index = 0; index < values.Length; index++)
			{
				var value = values.GetValue(index);
				var info = type.GetField(value.ToString());
				var da = (EnumMemberAttribute[])info.GetCustomAttributes(typeof(EnumMemberAttribute), false);
				var stringValue = da.Length > 0 ? da[0].Value : Enum.GetName(type, value);
				dictionary.Add((Enum)value, stringValue);
			}

			var isFlag = type.GetCustomAttributes(typeof(FlagsAttribute), false).Length > 0;
			return (e) =>
			{
				if (isFlag)
				{
					var list = new List<string>();
					foreach (var kv in dictionary)
					{
						if (e.HasFlag(kv.Key))
							list.Add(kv.Value);
					}

					return string.Join(",", list);
				}
				else
				{
					return dictionary[e];
				}
			}

			;
		}
	}
}
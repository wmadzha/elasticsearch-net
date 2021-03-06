﻿using System.Runtime.Serialization;

namespace Nest
{
	/// <summary>
	/// A snapshot repository
	/// </summary>
	public interface ISnapshotRepository
	{
		[DataMember(Name ="type")]
		string Type { get; }
	}

	/// <summary>
	/// A snapshot repository with settings
	/// </summary>
	public interface IRepositoryWithSettings: ISnapshotRepository
	{
		/// <summary>
		/// The repository settings
		/// </summary>
		[IgnoreDataMember]
		object DelegateSettings { get; }
	}

	/// <summary>
	/// A snapshot repository with typed settings
	/// </summary>
	public interface IRepository<TSettings> : IRepositoryWithSettings
		where TSettings : class, IRepositorySettings
	{
		/// <summary>
		/// The repository settings
		/// </summary>
		[DataMember(Name ="settings")]
		TSettings Settings { get; set; }
	}

	/// <summary>
	/// Snapshot repository settings
	/// </summary>
	public interface IRepositorySettings { }
}

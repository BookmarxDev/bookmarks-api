﻿namespace Bookmarx.Data.v1.Interfaces;

public interface IFirebaseEntity
{
	/// <summary>
	/// An Id is autogenerated but for some control we are going to set
	/// these ourselves. Then we can check against the values.
	/// For standardization this should always be a Guid with no dashes.
	/// </summary>
	public string Id { get; set; }
}
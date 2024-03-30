using Bookmarx.Data.v1.Interfaces;
using Google.Cloud.Firestore;

namespace Bookmarx.Shared.v1.Bookmarks.Entities;

[FirestoreData]
public class BookmarkCollection : IFirebaseEntity
{
	public BookmarkCollection()
	{
		// Needed for firebase
	}

	// Not going to be used anymore on the server
	//[FirestoreProperty]
	//public List<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();

	// A giant blob of JSON that contains all the bookmarks in the collection.
	[FirestoreProperty]
	public string BookmarksEncryptedJSON { get; set; } = string.Empty;

	[FirestoreProperty]
	public bool ChildCollectionsCollapsed { get; set; }

	[FirestoreProperty]
	public DateTime DateTimeAddedUTC { get; set; }

	[FirestoreProperty]
	public int Depth { get; set; }

	[FirestoreProperty]
	public bool HasChildren { get; set; }

	/// <summary>
	/// Defaults to the html character code for a file folder.
	/// </summary>
	[FirestoreProperty]
	public string Icon { get; set; } = "&#x1F4C1;";

	[FirestoreProperty]
	public string Id { get; set; }

	[FirestoreProperty]
	public int Index { get; set; }

	[FirestoreProperty]
	public bool IsCollapsed { get; set; }

	[FirestoreProperty]
	public bool IsLastChild { get; set; }

	[FirestoreProperty]
	public bool IsSoftDeleted { get; set; } = false;

	/// <summary>
	/// The parent collection Id of the bookmark collection.
	/// If this is null, then it's a root collection.
	/// </summary>
	[FirestoreProperty]
	public string? ParentId { get; set; }

	[FirestoreProperty]
	public string Title { get; set; }

	[FirestoreProperty]
	public int TotalBookmarks { get; set; }
}
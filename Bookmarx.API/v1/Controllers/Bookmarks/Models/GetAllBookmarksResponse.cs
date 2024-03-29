using Bookmarx.Shared.v1.Bookmarks.Entities;

namespace Bookmarx.API.v1.Controllers.Bookmarks.Models;

public class GetAllBookmarksResponse
{
	public List<BookmarkCollection> BookmarkCollections { get; set; }

	public string EncryptedPrivateKey { get; set; }
}
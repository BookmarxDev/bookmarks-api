using Bookmarx.API.v1.Controllers.Bookmarks.Models;
using Bookmarx.Shared.v1.Bookmarks.Entities;

namespace Bookmarx.API.v1.Controllers.Bookmarks;

[ApiController]
[Route("v{version:apiVersion}/bookmarks")]
[Authorize(Policy = ApiAuthPolicy.ActiveSessionAuthorization)]
public class BookmarksController : ControllerBase
{
	private readonly IBookmarkService _bookmarkService;

	private readonly ICurrentMemberService _currentMemberService;

	public BookmarksController(
		IBookmarkService bookmarkService,
		ICurrentMemberService currentMemberService)
	{
		this._bookmarkService = bookmarkService ?? throw new ArgumentNullException(nameof(bookmarkService));
		this._currentMemberService = currentMemberService ?? throw new ArgumentNullException(nameof(currentMemberService));
	}

	[HttpGet]
	[Route("get-all")]
	public async Task<IActionResult> GetAll()
	{
		var getAllBookmarksResponse = new GetAllBookmarksResponse();
		var currentMember = await this._currentMemberService.GetFreshMember();
		try
		{
			var bookmarkCollections = await this._bookmarkService.GetBookmarks();
			getAllBookmarksResponse.BookmarkCollections = bookmarkCollections;
			getAllBookmarksResponse.EncryptedPrivateKey = currentMember.PasswordProtectedPrivateKey;
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}

		return Ok(getAllBookmarksResponse);
	}

	[HttpPost]
	[Route("sync-bookmarks")]
	[Consumes("application/json")]
	public async Task<IActionResult> SyncBookmarks([FromBody] List<BookmarkCollection> bookmarkCollection)
	{
		try
		{
			await this._bookmarkService.ImportBookmarks(bookmarkCollection);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}

		return Ok(bookmarkCollection);
	}

	//[HttpPost]
	//[Route("save-deleted")]
	//[Consumes("application/json")]
	//public async Task<IActionResult> SaveDeleted([FromBody] List<BookmarkCollection> bookmarkCollection)
	//{
	//	try
	//	{
	//		await this._bookmarkService.SaveDeleted(bookmarkCollection);
	//	}
	//	catch (Exception ex)
	//	{
	//		return BadRequest(ex.Message);
	//	}

	//	return Ok(bookmarkCollection);
	//}
}
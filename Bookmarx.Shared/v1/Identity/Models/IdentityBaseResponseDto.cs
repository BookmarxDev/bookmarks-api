namespace Bookmarx.Shared.v1.Identity.Models;

public class IdentityBaseResponseDto
{
    /// <summary>
    /// Any errors that may be present in the given API call.
    /// </summary>
    public List<string> Errors { get; set; } = new List<string>();

    /// <summary>
    /// On Log In, Sign Up and once per day we check that the subscription is valid.
    /// </summary>
    public bool IsSubscriptionValid { get; set; } = false;

    public string MemberAccountID { get; set; } = string.Empty;
}
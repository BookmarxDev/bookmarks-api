namespace Bookmarx.Shared.v1.Membership.Models;

public class MemberAccountDto
{
	public string AuthProviderUID { get; set; }

	public string EmailAddress { get; set; }

	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public string PasswordProtectedPrivateKey { get; set; }

	public string PublicKey { get; set; }

	public int SaltCostFactor { get; set; }

	public string UserSalt { get; set; }
}
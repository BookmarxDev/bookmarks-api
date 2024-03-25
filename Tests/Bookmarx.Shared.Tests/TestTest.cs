using Xunit;

namespace Bookmarx.Shared.Tests;

public class TestTest : IDisposable
{
	public TestTest()
	{
		// Do some setup
	}

	public void Dispose()
	{
		// Do some teardown
	}

	[Fact]
	public void Succeed()
	{
		// Test method implementation
		Assert.True(1 == 1);
	}

	[Fact]
	public void Fail()
	{
		// Test method implementation
		Assert.True(1 == 2);
	}
}
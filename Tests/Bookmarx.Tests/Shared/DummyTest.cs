using Xunit;

namespace Bookmarx.Tests.Shared;

public class DummyTest : IDisposable
{
	public DummyTest()
	{
		// Do some setup
	}

	public void Dispose()
	{
		// Do some teardown
	}

	[Fact]
	public void Fail()
	{
		// Test method implementation
		// Should now succed
		Assert.True(1 == 1);
	}

	[Fact]
	public void Succeed()
	{
		// Test method implementation
		Assert.True(1 == 1);
	}
}
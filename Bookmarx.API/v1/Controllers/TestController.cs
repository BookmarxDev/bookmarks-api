﻿namespace Bookmarx.API.v1.Controllers;

[ApiController]
[Route("v{version:apiVersion}/test")]
public class TestController : ControllerBase
{
	public TestController()
	{
	}

	[HttpGet]
	[Route("hello")]
	public IActionResult Get()
	{
		SentrySdk.CaptureMessage("Hello Sentry");
		return Ok("Hello world!");
	}
}
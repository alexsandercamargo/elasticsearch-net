﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Cat.CatHelp
{
	public class CatHelpUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			await GET("/_cat")
				.Fluent(c => c.CatHelp())
				.Request(c => c.CatHelp(new CatHelpRequest()))
				.FluentAsync(c => c.CatHelpAsync())
				.RequestAsync(c => c.CatHelpAsync(new CatHelpRequest()))
				;

		}
	}
}

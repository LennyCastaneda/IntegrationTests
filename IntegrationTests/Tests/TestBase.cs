using ReloadedFramework.Model;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace ReloadedFramework
{
	[Binding]
	public class TestBase : Browser
	{
		[BeforeFeature("Chrome")]
		public static void SetupChrome()
		{
			Init("Chrome");
		}

		[BeforeFeature("Edge")]
		public static void SetupEdge()
		{
			Init("Edge");
		}

		[AfterTestRun]
		public static void After()
		{
			Page.Quit();
		}
	}
}

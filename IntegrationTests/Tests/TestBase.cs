using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace ReloadedFramework.Tests
{
	[Binding]
	public class TestBase : Browser
	{
		[BeforeFeature("Chrome")]
		public static void SetupChrome()
		{
			Init("Chrome");
		}

		[BeforeFeature("Firefox")]
		public static void SetupFireFox()
		{
			Init("Firefox");
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

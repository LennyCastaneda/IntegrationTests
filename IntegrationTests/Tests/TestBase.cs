using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace ReloadedFramework.Tests
{
	[Binding]
	public class TestBase : Browser
	{
		[BeforeScenario("Chrome")]
		public static void SetupChrome()
		{
			Init("Chrome");
		}

		[BeforeScenario("Firefox")]
		public static void SetupFireFox()
		{
			Init("Firefox");
		}

		[BeforeScenario("Edge")]
		public static void SetupEdge()
		{
			Init("Edge");
		}

		[AfterScenario]
		public static void After()
		{
			Page.Quit();
		}
	}
}

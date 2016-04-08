using NUnit.Framework;
using ReloadedFramework.Model;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ViewSteps : TestBase
	{
		[StepDefinition(@"the Background colour is '(.*)'")]
		public static void App_BackgroundColour(string colour)
		{
			Assert.That(Colour.RBGAToColourName(App.BackgroundColour) == colour);
		}

		[Then(@"the View should be loading")]
		public static void View_Loading()
		{
			Assert.That(App.View.Loading);
		}

		[Then(@"the active view should be a GridView")]
		public static void View_ActiveType_GridView()
		{
			Assert.That(App.View.GridView.IsVisible);
		}

		[Then(@"the active view should be an ItemView")]
		public static void View_ActiveType_ItemView()
		{
			Assert.That(App.View.ItemView.IsVisible);
		}
	}
}
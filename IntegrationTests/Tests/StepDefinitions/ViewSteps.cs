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
		public static void CheckBackgroundColour(string colour)
		{
			Assert.That(Colour.RBGAToColourName(App.BackgroundColour) == colour);
			// Returns rgba not rgb.
			// Ideally need to return the string representation e.g. 'Red'
		}
	}
}
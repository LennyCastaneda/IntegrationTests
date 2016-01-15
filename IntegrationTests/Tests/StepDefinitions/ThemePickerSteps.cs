using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ThemePickerSteps : TestBase
	{
		[Then(@"the ThemePicker should be visible")]
		public static void ThemePickerIsVisible()
		{
			Assert.That(App.ThemePicker.IsVisible);
		}


		[Then(@"the ThemePicker should not be visible")]
		public static void ThemePickerIsNotVisible()
		{
			Assert.That(!App.ThemePicker.IsVisible);
		}

		[StepDefinition(@"the ThemePicker colour '(.*)' is clicked")]
		public static void ThemePicker_Colour(string colour)
		{
			Assert.DoesNotThrow(() =>
			{
				App.ThemePicker.ClickColour(colour);
			});
		}

		//[StepDefinition(@"the ThemePicker colour '(.*)' is double-clicked")]
		//public static void ColourDoubleClicked(string colour)
		//{
		//	Assert.DoesNotThrow(() => {
		//		//ThemePicker.ClickColour(colour);
		//		//ThemePicker.ClickColour(colour);
		//	});
		//}

		[When(@"the ThemePicker Apply button is clicked")]
		public static void ThemePicker_Apply()
		{
			App.ThemePicker.ClickApply();
		}

		[When(@"the ThemePicker Cancel button is clicked")]
		public static void ThemePicker_Cancel()
		{
			App.ThemePicker.Cancel();
		}
	}
}

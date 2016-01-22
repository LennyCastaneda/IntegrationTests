using NUnit.Framework;
using ReloadedFramework.Model;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ThemePickerSteps : TestBase
	{
		[When(@"the ThemePicker colour '(.*)' is clicked")]
		public static void ThemePicker_Colour(string colour)
		{
			Assert.DoesNotThrow(() =>
			{
				App.ThemePicker.Colour(colour);
			});
		}

		[When(@"the ThemePicker 'Apply to View' button is clicked")]
		public static void ThemePicker_ApplyToView()
		{
			App.ThemePicker.ApplyToView();
		}

		[When(@"the ThemePicker 'Apply to Configuration' button is clicked")]
		public static void ThemePicker_ApplyToConfiguration()
		{
			App.ThemePicker.ApplyToConfiguration();
		}

		[When(@"the ThemePicker 'Cancel' button is clicked")]
		public static void ThemePicker_Cancel()
		{
			App.ThemePicker.Cancel();
		}

		[Then(@"the ThemePicker should be visible")]
		public static void ThemePicker_IsVisible()
		{
			Assert.That(App.ThemePicker.IsVisible);
		}

		[Then(@"the ThemePicker should not be visible")]
		public static void ThemePicker_IsNotVisible()
		{
			Assert.That(!App.ThemePicker.IsVisible);
		}
	}
}

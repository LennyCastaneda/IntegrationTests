using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ThemePickerSteps : TestBase
	{
		[StepDefinition(@"the ThemePicker should be open")]
		public static void ThemePickerIsOpen()
		{
			Assert.That(ThemePicker.IsOpen());
		}

		[StepDefinition(@"the ThemePicker should not be open")]
		public static void ThemePickerIsNotOpen()
		{
			Assert.That(!ThemePicker.IsOpen());
		}

		[StepDefinition(@"the ThemePicker Add New is clicked")]
		public static void AddNewClicked()
		{
			Assert.DoesNotThrow(()=> {
				ThemePicker.ClickAddNew();
			});
		}

		[StepDefinition(@"the ThemePicker colour '(.*)' is clicked")]
		public static void ColourClicked(string colour)
		{
			Assert.DoesNotThrow(() => {
				ThemePicker.ClickColour(colour);
			});
		}

		[StepDefinition(@"the ThemePicker colour '(.*)' is double-clicked")]
		public static void ColourDoubleClicked(string colour)
		{
			Assert.DoesNotThrow(() => {
				ThemePicker.ClickColour(colour);
				ThemePicker.ClickColour(colour);
			});
		}

		[StepDefinition(@"the ThemePicker Apply button is clicked")]
		public static void ApplyClicked()
		{
			Assert.DoesNotThrow(() => {
				ThemePicker.ClickApply();
			});
		}

		[StepDefinition(@"the ThemePicker Cancel button is clicked")]
		public static void ThemePicker_Close()
		{
			ThemePicker.Close();
		}
	}
}

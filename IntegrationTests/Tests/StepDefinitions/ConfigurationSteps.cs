using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ConfigurationSteps : TestBase
	{
		[When(@"I change the Configuration theme to '(.*)'")]
		public static void ConfigMenu_ThemePicker(string colour)
		{
			ConfigurationSteps.ConfigMenu_Icon_Clicked();
			ConfigurationSteps.ConfigMenu_ChooseTheme();
			ThemePickerSteps.ThemePicker_Colour(colour);
			ThemePickerSteps.ThemePicker_ApplyToConfiguration();
		}

		[When(@"I save the current Configuration")]
		public static void ConfigMenu_SaveCurrent()
		{
			ConfigurationSteps.ConfigMenu_Icon_Clicked();
			ConfigurationSteps.ConfigMenu_Save();
		}

		[When(@"I save the current Configuration as '(.*)'")]
		public static void ConfigMenu_SaveCurrentAs(string name)
		{
			ConfigurationSteps.ConfigMenu_Icon_Clicked();
			ConfigurationSteps.ConfigMenu_SaveAs();
			SaveAsSteps.SaveAs_EnterName(name);
			SaveAsSteps.SaveAs_Save();
		}

		[When(@"I open the Configuration '(.*)'")]
		public static void ConfigMenu_Open(string name)
		{
			ConfigurationSteps.ConfigMenu_Icon_Clicked();
			ConfigurationSteps.ConfigMenu_Config_Name(name);
		}

		[When(@"I open the Configuration Menu")]
		[When(@"the ConfigurationMenu icon is clicked")]
		public static void ConfigMenu_Icon_Clicked()
		{
			App.ConfigMenu.Open();
		}

		[When(@"the ConfigurationMenu Choose Theme is clicked")]
		public static void ConfigMenu_ChooseTheme()
		{
			App.ConfigMenu.ChooseTheme();
		}

		[When(@"the ConfigurationMenu Save is clicked")]
		public static void ConfigMenu_Save()
		{
			App.ConfigMenu.Save();
		}

		[When(@"the ConfigurationMenu Save As is clicked")]
		public static void ConfigMenu_SaveAs()
		{
			App.ConfigMenu.SaveAs();
		}

		[When(@"the Configuration '(.*)' is clicked")]
		public static void ConfigMenu_Config_Name(string name)
		{
			App.ConfigMenu.SelectConfiguration(name);
		}

		[Then(@"the Configuration '(.*)' is active")]
		[Then(@"the Configuration '(.*)' should be active")]
		public static void ConfigMenu_Config_Active(string name)
		{
			Assert.That(App.ConfigMenu.ConfigurationIsActive(name));
		}

		[Then(@"the ConfigurationMenu should be visible")]
		public static void ConfigMenu_IsVisible()
		{
			Assert.That(App.ConfigMenu.IsVisible);
		}

		[Then(@"the Configuration '(.*)' should exist")]
		public static void ConfigMenu_Config_IsVisible(string name)
		{
			Assert.That(App.ConfigMenu.ConfigExists(name));
		}
	}
}

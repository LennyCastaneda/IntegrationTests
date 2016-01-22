using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ConfigurationSteps : TestBase
	{
		[When(@"the ConfigurationMenu icon is clicked")]
		public void ConfigurationMenu_Icon_Clicked()
		{
			App.ConfigMenu.Open();
		}

		[When(@"the ConfigurationMenu Choose Theme is clicked")]
		public void ConfigurationMenu_ChooseTheme()
		{
			App.ConfigMenu.ChooseTheme();
		}

		[When(@"the ConfigurationMenu Save is clicked")]
		public void ConfigurationMenu_Save()
		{
			App.ConfigMenu.Save();
		}

		[When(@"the ConfigurationMenu Save As is clicked")]
		public void ConfigurationMenu_SaveAs()
		{
			App.ConfigMenu.SaveAs();
		}

		[When(@"the Configuration '(.*)' is clicked")]
		public void ConfigurationMenu_Config_Clicked(string name)
		{
			App.ConfigMenu.SelectConfiguration(name);
		}

		[Then(@"the Configuration '(.*)' is active")]
		public void ConfigurationMenu_Config_Active(string name)
		{
			Assert.That(App.ConfigMenu.ConfigurationIsActive(name));
		}

		[Then(@"the ConfigurationMenu should be visible")]
		public void ConfigurationMenu_IsVisible()
		{
			Assert.That(App.ConfigMenu.IsVisible);
		}
	}
}

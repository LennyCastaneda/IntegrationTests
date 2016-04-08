using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class GroupPickerSteps : TestBase
	{
		[Given(@"I open the GroupPicker")]
		[Given(@"the GroupPicker is open")]
		public static void ColumnPicker_Open()
		{
			ToolBarSteps.Cog_Click();
			ToolBarSteps.Cog_DropDownItem_Click("Grouping");
		}

		[When(@"I close the GroupPicker")]
		public static void GroupPicker_Close()
		{
			App.GroupPicker.Close();
		}

		[When(@"I click 'Apply' in the GroupPicker")]
		public static void GroupPicker_Apply()
		{
			App.GroupPicker.Apply();
		}

		[When(@"I click 'Cancel' in the GroupPicker")]
		public static void GroupPicker_Cancel()
		{
			App.GroupPicker.Cancel();
		}

		[When(@"I click the DropDown in the GroupPicker")]
		public static void GroupPicker_DropDown()
		{
			App.GroupPicker.DropDown();
		}

		[When(@"I click the DropDown option '(.*)' in the GroupPicker")]
		public static void GroupPicker_DropDown_Option(string name)
		{
			App.GroupPicker.DropDownOption(name);
		}

		[When(@"I group the dates by '(.*)' in the GroupPicker")]
		public static void GroupPicker_RadioButton(string name)
		{
			App.GroupPicker.GroupDatesBy(name);
		}

		[When(@"I group by '(.*)' in the GroupPicker")]
		public static void GroupPicker_GroupBy(string name)
		{
			GroupPickerSteps.GroupPicker_DropDown();
			GroupPickerSteps.GroupPicker_DropDown_Option(name);
		}

		[Then(@"the GroupPicker should be visible")]
		public static void GroupPicker_IsVisible()
		{
			Assert.That(App.GroupPicker.IsVisible);
		}

		[Then(@"the GroupPicker should not be visible")]
		public static void GroupPicker_IsNotVisible()
		{
			Assert.That(!App.GroupPicker.IsVisible);
		}
	}
}


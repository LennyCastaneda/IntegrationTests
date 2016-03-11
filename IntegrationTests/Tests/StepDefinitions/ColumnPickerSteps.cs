using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ColumnPickerSteps : TestBase
	{
		[Given(@"I open the ColumnPicker")]
		[Given(@"the ColumnPicker is open")]
		public static void ColumnPicker_Open()
		{
			ToolBarSteps.Cog_Click();
			ToolBarSteps.WhenTheToolBarDropdownItemIsClicked("Columns");
		}
		[When(@"I add the column '(.*)' in the ColumnSortPicker")]
		[When(@"I add the Column '(.*)' from the ColumnPicker")]
		[When(@"the Column '(.*)' is added")]
		public static void ColumnPicker_Column_Add(string name)
		{
			ColumnPickerSteps.ColumnPicker_DropDown();
			ColumnPickerSteps.ColumnPicker_DropDownItem(name);
			ColumnPickerSteps.ColumnPicker_Apply();
		}

		[When(@"I remove the Column '(.*)' from the ColumnPicker")]
		[When(@"the Column '(.*)' is removed")]
		public static void ColumnPicker_Column_Remove(string name)
		{
			ColumnPickerSteps.ColumnPicker_ColumnRemoved(name);
			ColumnPickerSteps.ColumnPicker_Apply();
		}

		[When(@"I click Apply in the ColumnSortPicker")]
		[When(@"the ColumnPicker 'Apply' button is clicked")]
		public static void ColumnPicker_Apply()
		{
			App.ColumnPicker.Apply();
		}

		[When(@"the ColumnPicker 'Close' button is clicked")]
		public static void ColumnPicker_Close()
		{
			App.ColumnPicker.Close();
		}

		[When(@"I click Cancel in the ColumnSortPicker")]
		[When(@"the ColumnPicker 'Cancel' button is clicked")]
		public static void ColumnPicker_Cancel()
		{
			App.ColumnPicker.Cancel();
		}

		[When(@"I click the DropDown in the ColumnSortPicker")]
		[When(@"the ColumnPicker DropDown is clicked")]
		public static void ColumnPicker_DropDown()
		{
			App.ColumnPicker.DropDown();
		}

		[When(@"the ColumnSortPicker DropDown item '(.*)' is clicked")]
		[When(@"the ColumnPicker DropDown item '(.*)' is clicked")]
		public static void ColumnPicker_DropDownItem(string name)
		{
			App.ColumnPicker.DropDownOption(name);
		}

		[When(@"I remove the column '(.*)' in the ColumnSortPicker")]
		[When(@"the ColumnPicker Column '(.*)' is removed")]
		public static void ColumnPicker_ColumnRemoved(string name)
		{
			App.ColumnPicker.RemoveColumn(name);
		}

		[When(@"I drag column at position '(.*)' to position '(.*)' in the ColumnSortPicker")]
		[When(@"I drag Column at position '(.*)' to position '(.*)' in the ColumnPicker")]
		[When(@"the ColumnPicker Column at position '(.*)' is moved to position '(.*)'")]
		public static void ColumnPicker_ColumnMoved(int start, int finish)
		{
			App.ColumnPicker.DragAndDropColumn(start, finish);
		}

		[Then(@"the ColumnSortPicker should be visible")]
		[Then(@"the ColumnPicker should be visible")]
		public static void ColumnPicker_IsVisible()
		{
			Assert.That(App.ColumnPicker.IsVisible);
		}

		[Then(@"the ColumnSortPicker should not be visible")]
		[Then(@"the ColumnPicker should not be visible")]
		public static void ColumnPicker_NotVisible()
		{
			Assert.That(!App.ColumnPicker.IsVisible);
		}

		[Then(@"the ColumnPicker Column '(.*)' should be visible")]
		public static void ColumnPicker_Column_IsVisible(string name)
		{
			Assert.That(App.ColumnPicker.IsColumnVisible(name));
		}

		[Then(@"the ColumnPicker Column '(.*)' should not be visible")]
		public static void ColumnPicker_Column_NotVisible(string name)
		{
			Assert.That(!App.ColumnPicker.IsColumnVisible(name));
		}

		[Then(@"the ColumnPicker Column '(.*)' should be at position '(.*)'")]
		public static void ColumnPicker_Column_AtPosition(string name, int position)
		{
			Assert.That(App.ColumnPicker.IsColumnAtPosition(name, position));
		}
	}
}

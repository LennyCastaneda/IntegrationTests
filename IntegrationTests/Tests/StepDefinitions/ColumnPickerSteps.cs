using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ColumnPickerSteps : TestBase
	{
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

		[When(@"the ColumnPicker 'Cancel' button is clicked")]
		public static void ColumnPicker_Cancel()
		{
			App.ColumnPicker.Cancel();
		}

		[When(@"the ColumnPicker DropDown is clicked")]
		public static void ColumnPicker_DropDown()
		{
			App.ColumnPicker.DropDown();
		}

		[When(@"the ColumnPicker DropDown item '(.*)' is clicked")]
		public static void ColumnPicker_DropDownItem(string name)
		{
			App.ColumnPicker.DropDownOption(name);
		}

		[When(@"the ColumnPicker Column '(.*)' is removed")]
		public static void ColumnPicker_ColumnRemoved(string name)
		{
			App.ColumnPicker.RemoveColumn(name);
		}

		[When(@"the ColumnPicker Column at position '(.*)' is moved to position '(.*)'")]
		public static void ColumnPicker_ColumnMoved(int start, int finish)
		{
			App.ColumnPicker.DragAndDropColumn(start, finish);
		}

		[Then(@"the ColumnPicker should be visible")]
		public static void ColumnPicker_IsVisible()
		{
			Assert.That(App.ColumnPicker.IsVisible);
		}

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

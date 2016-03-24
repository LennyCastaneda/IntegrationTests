using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class FilterPickerSteps : TestBase
	{
		[Given("I open the Filter Picker")]
		private static void FilterPicker_Open()
		{
			ToolBarSteps.Cog_Click();
			ToolBarSteps.Cog_DropDownItem_Click("Filter");
		}

		[When(@"I click 'Apply' in the Filter Picker")]
		public static void FilterPicker_Apply()
		{
			App.FilterPicker.Apply();
		}

		[When(@"I click 'Cancel' in the Filter Picker")]
		public static void FilterPicker_Cancel()
		{
			App.FilterPicker.Cancel();
		}

		[When(@"I click 'Add New Group' in the Filter Picker")]
		public static void FilterPicker_AddNewGroup()
		{
			App.FilterPicker.AddNew();
		}
		
		[When(@"in Filter Picker group number '(.*)' filter number '(.*)' I select the Field '(.*)'")]
		public static void FilterPicker_SelectField(string groupnum, string filternum, string fieldname)
		{
			App.FilterPicker.FilterGroup(groupnum).Filter(filternum).Field().SelectField(fieldname);
		}

		[When(@"in Filter Picker group number '(.*)' filter number '(.*)' I click the filter")]
		public static void FilterPicker_ClickFilter(string groupnum, string filternum)
		{
			App.FilterPicker.FilterGroup(groupnum).Filter(filternum).Filter();
		}

		[When(@"in Filter Picker group '(.*)' filter number '(.*)' in the CheckedList I search for '(.*)'")]
		public static void FilterPicker_CheckedList_Search(string groupnum, string filternum, string name)
		{
			App.FilterPicker.FilterGroup(groupnum).Filter(filternum).CheckedListFilter.SearchFor(name);
			Page.Wait();
		}

		[When(@"the Filter Picker group '(.*)' filter number '(.*)' checkbox item '(.*)' is clicked")]
		public static void FilterPickerGroup_FilterNumber_CheckedList_Option(string groupnum, string filternum, string name)
		{
			App.FilterPicker.FilterGroup(groupnum).Filter(filternum).CheckedListFilter.SelectByName(name);
		}

		[Then(@"the Filter Picker should be visible")]
		public static void FilterPicker_IsVisible()
		{
			Assert.That(App.FilterPicker.IsVisible);
		}

		[Then(@"the Filter Picker should not be visible")]
		public static void FilterPicker_IsNotVisible()
		{
			Assert.That(!App.FilterPicker.IsVisible);
		}
	}
}


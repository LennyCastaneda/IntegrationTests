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
			ToolBarSteps.WhenTheToolBarDropdownItemIsClicked("Filter");
		}

		[When(@"I click 'Apply' in the Filter Picker")]
		public void FilterPicker_Apply()
		{
			App.FilterPicker.Apply();
		}

		[When(@"I click 'Cancel' in the Filter Picker")]
		public void FilterPicker_Cancel()
		{
			App.FilterPicker.Cancel();
		}

		[When(@"I click 'Add New Group' in the Filter Picker")]
		public void FilterPicker_AddNewGroup()
		{
			App.FilterPicker.AddNew();
		}
		
		[When(@"in Filter Picker group number '(.*)' filter number '(.*)' I select the Field '(.*)'")]
		public void FilterPicker_SelectField(string groupnum, string filternum, string fieldname)
		{
			App.FilterPicker.FilterGroup(groupnum).Filter(filternum).Field().SelectField(fieldname);
		}

		[When(@"in Filter Picker group number '(.*)' filter number '(.*)' I click the filter")]
		public void FilterPicker_ClickFilter(string groupnum, string filternum)
		{
			App.FilterPicker.FilterGroup(groupnum).Filter(filternum).Filter();
		}

		[When(@"in Filter Picker group '(.*)' filter number '(.*)' in the ListFilter I search for '(.*)'")]
		public void FilterPicker_ListFilter_Search(string groupnum, string filternum, string name)
		{
			App.FilterPicker.FilterGroup(groupnum).Filter(filternum).ListSelectFilter.SearchFor(name);
			Page.Wait();
		}

		[When(@"the Filter Picker group '(.*)' filter number '(.*)' StringFilter '(.*)' is checked")]
		[When(@"in Filter Picker group '(.*)' filter number '(.*)' in the StringFilter I check '(.*)'")]
		public void WhenTheFilterPickerGroupFilterNumberStringFilterIsChecked(string groupnum, string filternum, string name)
		{
			App.FilterPicker.FilterGroup(groupnum).Filter(filternum).ListSelectFilter.SelectByName(name);
		}

		[Then(@"the Filter Picker should be visible")]
		public void FilterPicker_IsVisible()
		{
			Assert.That(App.FilterPicker.IsVisible);
		}

		[Then(@"the Filter Picker should not be visible")]
		public void FilterPicker_IsNotVisible()
		{
			Assert.That(!App.FilterPicker.IsVisible);
		}




	}
}


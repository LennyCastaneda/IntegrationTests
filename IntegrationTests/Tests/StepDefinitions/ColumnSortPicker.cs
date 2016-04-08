using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ColumnSortPicker : TestBase
	{
		[Given(@"I open the ColumnSortPicker")]
		[Given(@"I have opened the ColumnSortPicker")]
		public static void ColumnSortPicker_Open()
		{
			ToolBarSteps.Cog_Click();
			ToolBarSteps.Cog_DropDownItem_Click("Sort");
		}

		[When("I click the arrow on column '(.*)' in the ColumnSortPicker")]
		public static void ColumnSortPicker_Arrow(string name)
		{
			App.ColumnPicker.SortColumn(name);
		}
	}
}
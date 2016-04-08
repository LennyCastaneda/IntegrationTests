using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class DateSelectFilterSteps : TestBase
	{
		[When(@"I check the 'Between' radio button in the DateSelectFilter")]
		public static void DateSelectFilter_BetweenRadio()
		{
			App.DateSelectFilter.Between();
		}

		[When(@"I check the 'In range' radio button in the DateSelectFilter")]
		public static void DateSelectFilter_InRangeRadio()
		{
			App.DateSelectFilter.InRange();
		}

		[When(@"I enter the start date '(.*)' into the DateSelectFilter")]
		public static void DateSelectFilter_BetweenStart(string input)
		{
			App.DateSelectFilter.BetweenStartDate(input);
		}

		[When(@"I enter the end date '(.*)' into the DateSelectFilter")]
		public static void DateSelectFilter_BetweenEnd(string input)
		{
			App.DateSelectFilter.BetweenEndDate(input);
		}

		[When(@"I enter the start timespan '(.*)' into the DateSelectFilter")]
		public static void DateSelectFilter_InRangeStart(string input)
		{
			App.DateSelectFilter.InRangeStartSpan(input);
		}

		[When(@"I enter the end timespan '(.*)' into the DateSelectFilter")]
		public static void DateSelectFilter_InRangeEnd(string input)
		{
			App.DateSelectFilter.InRangeEndSpan(input);
		}

		[When(@"I click the 'Start' field in the DateSelectFilter")]
		public static void DateSelectFilter_BetweenFrom_Click()
		{
			App.DateSelectFilter.BetweenStartDate("");
		}

		[When(@"I click the 'End' field in the DateSelectFilter")]
		public static void DateSelectFilter_BetweenTo_Click()
		{
			App.DateSelectFilter.BetweenEndDate("");
		}

		[When(@"I click 'Next' month in the DatePicker")]
		public static void DatePicker_Next()
		{
			App.DateSelectFilter.DatePicker.NextMonth();
		}

		[When(@"I click 'Previous' month in the DatePicker")]
		public static void DatePicker_Previous()
		{
			App.DateSelectFilter.DatePicker.PreviousMonth();
		}

		[When(@"I select the date '(.*)' in the DatePicker")]
		public static void DatePicker_Date(int date)
		{
			App.DateSelectFilter.DatePicker.SelectDate(date);
		}
	}
}

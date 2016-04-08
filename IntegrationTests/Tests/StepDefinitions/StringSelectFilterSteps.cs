using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class StringSelectFilterSteps : TestBase
	{ 
		[When("I enter '(.*)' into 'Starts With' in the StringSelectFilter")]
		public static void StringSelectFilter_StartsWith(string input)
		{
			App.StringSelectFilter.StartsWith(input);
		}

		[When("I enter '(.*)' into 'Ends With' in the StringSelectFilter")]
		public static void StringSelectFilter_EndsWith(string input)
		{
			App.StringSelectFilter.EndsWith(input);
		}

		[When("I enter '(.*)' into 'Contains' in the StringSelectFilter")]
		public static void StringSelectFilter_Contains(string input)
		{
			App.StringSelectFilter.Contains(input);
		}

		[When("I enter '(.*)' into 'Equals' in the StringSelectFilter")]
		public static void StringSelectFilter_Equals(string input)
		{
			App.StringSelectFilter.Equals(input);
		}
	}
}

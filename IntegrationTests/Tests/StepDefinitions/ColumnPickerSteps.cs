using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ColumnPickerSteps : TestBase
	{
		[Then(@"the ColumnPicker should be open")]
		public static void ColumnPickerIsOpen()
		{
			//ColumnPicker Model does not exist.
		}
	}
}

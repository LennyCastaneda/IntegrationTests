using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class HelpSteps : TestBase
	{
		[StepDefinition(@"the Help window is open")]
		public static void HelpIsOpen()
		{
			Assert.That(Manual.IsOpen());
		}

		[StepDefinition(@"the Help window is not open")]
		public static void HelpIsNotOpen()
		{
			Assert.That(!Manual.IsOpen());
		}

		[StepDefinition(@"the Help window Close button is clicked")]
		public static void ClickClose()
		{
			Manual.Close();
			HelpSteps.HelpIsNotOpen();
        }

		[StepDefinition(@"the Help window Back button is clicked")]
		public static void ClickBack()
		{
			Manual.Back();
		}
	}
}

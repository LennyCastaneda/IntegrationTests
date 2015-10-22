using NUnit.Framework;
using ReloadedFramework;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class MenuSteps : TestBase
	{
		[StepDefinition(@"I click the Menu Icon")]
		public static void OpenMenu()
		{
			Assert.IsNotNull(Menu);
			Menu.OpenMenu();
		}

		[StepDefinition(@"the Menu opens")]
		public static void MenuIsOpen()
		{
			Assert.IsNotNull(Menu);
			Assert.That(Menu.IsOpen);
		}
	}
}

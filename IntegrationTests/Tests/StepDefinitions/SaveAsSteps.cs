using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class SaveAsSteps : TestBase
	{
		[When(@"I click 'Save' in the SaveAs modal")]
		public static void SaveAs_Save()
		{
			App.SaveAs.Save();
		}

		[When(@"I click 'Cancel' in the SaveAs modal")]
		public static void SaveAs_Cancel()
		{
			App.SaveAs.Cancel();
		}

		[When(@"I Close the SaveAs modal")]
		public static void SaveAs_Close()
		{
			App.SaveAs.Close();
		}

		[When(@"I enter the name '(.*)' into the SaveAs modal")]
		public static void SaveAs_EnterName(string name)
		{
			App.SaveAs.EnterName(name);
		}

		[Then(@"the SaveAs Modal header should be '(.*)'")]
		public static void SaveAs_Header(string input)
		{
			Assert.That(App.SaveAs.HeaderText == input);
		}
	}
}

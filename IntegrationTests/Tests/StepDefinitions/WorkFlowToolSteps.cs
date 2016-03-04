using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	class WorkFlowToolSteps : TestBase
	{
		[Then(@"I should see a list of WorkItems")]
		public void ThenIShouldSeeAListOfWorkItems()
		{
			Assert.That(App.View.GridView.RowCount > 0);
		}
	}
}

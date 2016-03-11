using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class GridViewSteps : TestBase
	{
		[When(@"the GridView Column '(.*)' is dragged right")]
		public void GridView_Column_IsDragged_Right(string name)
		{
			App.SharedInfo.Add(name + "Width", App.View.GridView.ColumnSize(name).Width);
			App.View.GridView.ResizeColumn(name, 100);
		}

		[When(@"the GridView Column '(.*)' is dragged left")]
		public void GridView_Column_IsDragged_Left(string name)
		{
			App.SharedInfo.Add(name + "Width", App.View.GridView.ColumnSize(name).Width);
			App.View.GridView.ResizeColumn(name, -100);
		}

		[Then(@"the GridView Column '(.*)' width should have increased")]
		public void GridView_ColumnWidth_Increased(string name)
		{
			Assert.That((int)App.SharedInfo[name + "Width"] < App.View.GridView.ColumnSize(name).Width);
			App.SharedInfo.Remove(name + "Width");
		}

		[Then(@"the GridView Column '(.*)' width should have decreased")]
		public void GridView_ColumnWidth_Decreased(string name)
		{
			Assert.That((int)App.SharedInfo[name + "Width"] > App.View.GridView.ColumnSize(name).Width);
			App.SharedInfo.Remove(name + "Width");
		}

		[Then(@"the Column '(.*)' should be visible in the GridView")]
		[Then(@"the GridView Column '(.*)' should be visible")]
		public void GridView_Column_IsVisible(string name)
		{
			Assert.That(App.View.GridView.IsColumnVisible(name));
		}

		[Then(@"the Column '(.*)' should not be visible in the GridView")]
		[Then(@"the GridView Column '(.*)' should not be visible")]
		public void GridView_Column_IsNotVisible(string name)
		{
			Assert.That(!App.View.GridView.IsColumnVisible(name));
		}

		[Then(@"the GridView should have a subheader that starts with '(.*)'")]
		public static void GridView_SubHeader(string name)
		{
			Assert.That(App.View.GridView.SubHeaderStartsWith(name));
		}
	}
}

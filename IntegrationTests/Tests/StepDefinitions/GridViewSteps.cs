using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class GridViewSteps : TestBase
	{
		[When(@"the GridView Column '(.*)' is dragged right")]
		public static void GridView_Column_IsDragged_Right(string name)
		{
			App.SharedInfo.Add(name + "Width", App.View.GridView.ColumnSize(name).Width);
			App.View.GridView.ResizeColumn(name, 100);
		}

		[When(@"the GridView Column '(.*)' is dragged left")]
		public static void GridView_Column_IsDragged_Left(string name)
		{
			App.SharedInfo.Add(name + "Width", App.View.GridView.ColumnSize(name).Width);
			App.View.GridView.ResizeColumn(name, -100);
		}

		[When(@"the GridView row '(.*)' is double-clicked")]
		[When(@"I double-click row '(.*)' in the GridView")]
		public static void GridView_Row_Click(int row)
		{
			App.View.GridView.DoubleClickRow(row);
		}

		[Then(@"the GridView Column '(.*)' width should have increased")]
		public static void GridView_ColumnWidth_Increased(string name)
		{
			Assert.That((int)App.SharedInfo[name + "Width"] < App.View.GridView.ColumnSize(name).Width);
			App.SharedInfo.Remove(name + "Width");
		}

		[Then(@"the GridView Column '(.*)' width should have decreased")]
		public static void GridView_ColumnWidth_Decreased(string name)
		{
			Assert.That((int)App.SharedInfo[name + "Width"] > App.View.GridView.ColumnSize(name).Width);
			App.SharedInfo.Remove(name + "Width");
		}

		[Then(@"the Column '(.*)' should be visible in the GridView")]
		[Then(@"the GridView Column '(.*)' should be visible")]
		public static void GridView_Column_IsVisible(string name)
		{
			Assert.That(App.View.GridView.IsColumnVisible(name));
		}

		[Then(@"the Column '(.*)' should not be visible in the GridView")]
		[Then(@"the GridView Column '(.*)' should not be visible")]
		public static void GridView_Column_IsNotVisible(string name)
		{
			Assert.That(!App.View.GridView.IsColumnVisible(name));
		}

		[Then(@"the GridView should have a subheader that starts with '(.*)'")]
		public static void GridView_SubHeader(string name)
		{
			Assert.That(App.View.GridView.SubHeaderStartsWith(name));
		}

		[Then(@"the GridView Header at position '(.*)' shoud be '(.*)'")]
		public static void GridView_Header_Name(int position, string columnname)
		{
			Assert.That(App.View.GridView.ColumnPosition(columnname) == position);
		}

		[Then(@"the GridView Table first row column '(.*)' text should be '(.*)'")]
		public static void GridView_Row1_Column(string columnname, string text)
		{
			Assert.That(App.View.GridView.GetCellValue(1, columnname) == text);
		}

		[Then(@"the GridView cell at row '(.*)' column '(.*)' should equal '(.*)'")]
		public static void GridView_Row_Column(int row, string columnname, string text)
		{
			Assert.That(App.View.GridView.GetCellValue(row, columnname) == text);
		}

		[Then(@"the GridView cell at row '(.*)' column '(.*)' should start with '(.*)'")]
		public static void GridView_Row_Column_StartsWith(int row, string columnname, string text)
		{
			Assert.That(App.View.GridView.GetCellValue(row, columnname).StartsWith(text));
		}

		[Then(@"the GridView should show '(.*)' rows")]
		public static void GridView_Row_Count(int count)
		{
			Assert.That(App.View.GridView.RowCount == count);
		}
	}
}

using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;
using System.Drawing;

namespace ReloadedFramework.Model.ViewObjects.ViewTypes
{
	public class GridViewPartial : Driver
	{
		FindBy ThisBy = new FindBy(ByMethod.CssSelector, ".persistant_tab[style*='block'] div[ng-controller^='gridviewController']");
		FindBy TableBy = new FindBy(ByMethod.CssSelector, "table");
		FindBy ColumnsBy = new FindBy(ByMethod.CssSelector, "thead tr.header");
		FindBy ColumnHandleBy = new FindBy(ByMethod.CssSelector, ".ui-resizable-handle");
		FindBy ColumnSortBy = new FindBy(ByMethod.CssSelector, "sup");
		FindBy RowsBy = new FindBy(ByMethod.CssSelector, "tr:not(.subheader):not(.header)");
		FindBy SubHeadersBy = new FindBy(ByMethod.CssSelector, "");

		public GridViewPartial(WebDriver driver) : base(driver) { }

		/// <summary>
		/// Returns true if the GridView is open and the table is visible.
		/// </summary>
		public bool IsVisible
		{
			get
			{
				return _driver.FindElement(ThisBy).IsVisible && _driver.FindElement(ThisBy).FindElement(TableBy).IsVisible;
			}
		}

		/// <summary>
		/// Returns a WebElement representing the Column Header (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		private WebElement FindColumnByName(string name)
		{
			return _driver.FindElement(ThisBy)
				.FindElement(TableBy)
				.FindElements(ColumnsBy)[0]
				.FindElements(ByMethod.CssSelector, "th")
				.Find(x => StringCompare(x.Text, name));
		}

		/// <summary>
		///  Returns the top left System.Drawing.Point of the Column Header (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Point ColumnLocation(string name)
		{
			return FindColumnByName(name).Location;
		}

		/// <summary>
		/// Returns the Size of column (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Size ColumnSize(string name)
		{
			return FindColumnByName(name).Size;
		}

		/// <summary>
		/// Returns true if Column Header (name) is rendered to the page. Doesn't check for visibility.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool IsColumnActive(string name)
		{
			return FindColumnByName(name) != null;
		}

		/// <summary>
		/// Returns true if Column Header (name) is visible.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool IsColumnVisible(string name)
		{
			return IsColumnActive(name) && FindColumnByName(name).IsVisible;
		}

		/// <summary>
		/// Clicks the Sort arrow on the Column Header (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public GridViewPartial SortColumn(string name)
		{
			FindColumnByName(name)
				.FindElement(ColumnSortBy)
				.Click();
			return this;
		}

		/// <summary>
		/// Resizes Column Header (name) by offSetX.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="offSetX"></param>
		/// <returns></returns>
		public GridViewPartial ResizeColumn(string name, int offSetX)
		{
			FindColumnByName(name)
				.FindElement(ColumnHandleBy)
				.DragAndDropTo(_driver, offSetX, 0);
			return this;
		}

		/// <summary>
		/// Returns the Column Header (name) position from the left. Returns null if not found.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public int ColumnPosition(string columnname)
		{
			var elements = _driver.FindElement(ThisBy)
							.FindElement(TableBy)
							.FindElements(ColumnsBy);
			int index = elements[0]
						.FindElements(ByMethod.CssSelector, "th")
						.FindIndex(x => StringCompare(x.GetNodeText, columnname));
			return index + 1;
		}

		/// <summary>
		/// Returns the total number of data Rows in the GridView. 
		/// <para>Ignores Grouping</para>
		/// </summary>
		/// <returns></returns>
		public int RowCount
		{
			get
			{
				return _driver.FindElement(ThisBy)
					.FindElement(TableBy)
					.FindElements(RowsBy).Count;
			}
		}

		/// <summary>
		/// Returns the row at position 'index'
		/// </summary>
		/// <param name="rownum"></param>
		/// <returns></returns>
		private WebElement GetRow(int index)
		{
			return _driver.FindElement(ThisBy)
				.FindElement(TableBy)
				.FindElements(RowsBy)[index];
		}

		/// <summary>
		/// Get the value of the cell in row 'row' and the column 'columnname'.
		/// </summary>
		/// <param name="row"></param>
		/// <param name="columnname"></param>
		/// <returns></returns>
		public string GetCellValue(int row, string columnname)
		{
			var elements = _driver.FindElement(ThisBy)
						.FindElement(TableBy)
						.FindElements(ColumnsBy);
			int index = elements[0]
						.FindElements(ByMethod.CssSelector, "th")
						.FindIndex(x => StringCompare(x.GetNodeText, columnname));

			var result = GetRow(row - 1).FindElements(ByMethod.CssSelector, "td")[index].Text;
			return result;
		}

		/// <summary>
		/// Returns true if the first subheader on the page starts with the specified string.
		/// </summary>
		/// <param name="substring"></param>
		/// <returns></returns>
		public bool SubHeaderStartsWith(string substring)
		{
			return _driver.FindElement(ThisBy)
				.FindElement(TableBy)
				.FindElements(ByMethod.CssSelector, "thead .subheader th")
				.Find(x => x.Text.Trim().ToLower().StartsWith(substring.ToLower())) != null;
		}

		public ItemViewPartial DoubleClickRow(int num)
		{
			GetRow(num).DoubleClick(_driver);
			return new ItemViewPartial(_driver);
		}
	}
}

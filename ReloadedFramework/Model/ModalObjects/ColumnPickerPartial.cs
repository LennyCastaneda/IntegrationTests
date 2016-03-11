using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class ColumnPickerPartial : Modal
	{
		FindBy DropDownBy = new FindBy(ByMethod.CssSelector, ".addnewcol");
		FindBy ListItemsBy = new FindBy(ByMethod.CssSelector, "ul[ui-sortable=sortableOptions] li");
		FindBy TrashIconBy = new FindBy(ByMethod.CssSelector, ".mdi-delete");
		FindBy ArrowIconBy = new FindBy(ByMethod.CssSelector, ".mdi-arrow-down");

		public ColumnPickerPartial(WebDriver driver) : base(driver) { }

		/// <summary>
		/// Clicks the 'Apply' button.
		/// </summary>
		/// <returns></returns>
		public ColumnPickerPartial Apply()
		{
			FindButton("apply").Click();
			return this;
		}

		/// <summary>
		/// Clicks the 'Cancel' button.
		/// </summary>
		/// <returns></returns>
		public ColumnPickerPartial Cancel()
		{
			FindButton("cancel").Click();
			return this;
		}

		/// <summary>
		/// Clicks the 'X' in the top right corner of the modal.
		/// </summary>
		/// <returns></returns>
		public ColumnPickerPartial Close()
		{
			Header.FindElement(ByMethod.CssSelector, "button").Click();
			return this;
		}

		/// <summary>
		/// Clicks the dropdown menu.
		/// </summary>
		/// <returns></returns>
		public ColumnPickerPartial DropDown()
		{
			Body.FindElement(DropDownBy).Click();
			return this;
		}

		/// <summary>
		/// Clicks the dropdown item (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ColumnPickerPartial DropDownOption(string name)
		{
			Body.FindElement(DropDownBy)
				.FindElement(ByMethod.CssSelector, "option[label='" + name + "']").Click();
			return this;
		}

		/// <summary>
		/// Clicks the trash icon of the column (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ColumnPickerPartial RemoveColumn(string name)
		{
			GetListItem(name).FindElement(TrashIconBy).Click();
			return this;
		}

		/// <summary>
		/// Clicks the arrow icon of the column (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ColumnPickerPartial SortColumn(string name)
		{
			GetListItem(name).FindElement(ArrowIconBy).Click();
			return this;
		}

		/// <summary>
		/// Returns true if column (name) is visible.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool IsColumnVisible(string name)
		{
			var element = GetListItem(name);
			if (element != null && element.IsVisible)
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// Returns the column element (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		private WebElement GetListItem(string name)
		{
			return Body.FindElements(ListItemsBy)
				.Find(x => x.FindElement(ByMethod.CssSelector, "p").Text == name);
		}

		/// <summary>
		/// Drag and drop the column at (sourcePosition) and move it to (targetPosition).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ColumnPickerPartial DragAndDropColumn(int sourcePosition, int targetPosition)
		{
			WebElement source = _driver.FindElement(ByMethod.CssSelector, 
				".modal-body ul[ui-sortable=sortableOptions] li:nth-child(" + sourcePosition + ") .mdi-drag-vertical");

			WebElement target = _driver.FindElement(ByMethod.CssSelector,
				".modal-body ul[ui-sortable=sortableOptions] li:nth-child(" + targetPosition + ") .mdi-drag-vertical");

			int offsetY = target.Location.Y - source.Location.Y;
			source.DragAndDropTo(_driver, 0, offsetY + 10);
			return this;
		}

		/// <summary>
		/// Drag and drop the column (source) and move it to (target).
		/// <para>No offset so may not be useful for reordering elements in a list.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ColumnPickerPartial DragAndDropColumn(string source, string target)
		{
			GetListItem(source).DragAndDrop(_driver, GetListItem(target));
			return this;
		}

		/// <summary>
		/// Returns true if column (name) is at (position) in the Column List.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="position"></param>
		/// <returns></returns>
		public bool IsColumnAtPosition(string name, int position)
		{
			return _driver.FindElement(ThisBy)
				.FindElements(ListItemsBy)[position - 1]
				.FindElement(ByMethod.CssSelector, "p").Text == name;
		}
	}
}

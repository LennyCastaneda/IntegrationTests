using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class ColumnPickerPartial : Driver
	{
		FindBy IsOpenBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-content");
		FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-dialog[ng-controller^='ColumnPickerController'] .modal-content");
		FindBy ApplyBy = new FindBy(ByMethod.CssSelector, ".modal-footer button[ng-click='applyColumns()']");
		FindBy CancelBy = new FindBy(ByMethod.CssSelector, ".modal-footer button:not([ng-click])");
		FindBy CloseBy = new FindBy(ByMethod.CssSelector, ".modal-header button");
		FindBy DropDownBy = new FindBy(ByMethod.CssSelector, ".modal-body .addnewcol");
		FindBy ListItemsBy = new FindBy(ByMethod.CssSelector, ".modal-body ul[ui-sortable=sortableOptions] li");

		public ColumnPickerPartial(WebDriver driver) : base(driver) { }

		/// <summary>
		/// Returns true if the Partial is visible to the user.
		/// </summary>
		public bool IsVisible
		{
			get
			{
				var result = _driver.FindElement(ThisBy);
				if (result != null && _driver.FindElement(IsOpenBy) != null)
				{
					return result.IsVisible;
				}
				return false;
			}
		}

		/// <summary>
		/// Clicks the 'Apply' button.
		/// </summary>
		/// <returns></returns>
		public ColumnPickerPartial Apply()
		{
			_driver.FindElement(ThisBy)
				.FindElement(ApplyBy).Click();
			return this;
		}

		/// <summary>
		/// Clicks the 'Cancel' button.
		/// </summary>
		/// <returns></returns>
		public ColumnPickerPartial Cancel()
		{
			_driver.FindElement(ThisBy)
				.FindElement(CancelBy).Click();
			return this;
		}

		/// <summary>
		/// Clicks the 'X' in the top right corner of the modal.
		/// </summary>
		/// <returns></returns>
		public ColumnPickerPartial Close()
		{
			_driver.FindElement(ThisBy)
				.FindElement(CloseBy).Click();
			return this;
		}

		/// <summary>
		/// Clicks the dropdown menu.
		/// </summary>
		/// <returns></returns>
		public ColumnPickerPartial DropDown()
		{
			_driver.FindElement(ThisBy)
				.FindElement(DropDownBy).Click();
			return this;
		}

		/// <summary>
		/// Clicks the dropdown item (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ColumnPickerPartial DropDownOption(string name)
		{
			_driver.FindElement(ThisBy)
				.FindElement(DropDownBy)
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
			GetListItem(name).FindElement(ByMethod.CssSelector, ".mdi-delete").Click();
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
			return _driver.FindElements(ListItemsBy)
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

using ReloadedFramework.Model.AbstractClasses;
using ReloadedFramework.Model.ViewObjects.ToolBarObjects;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	public class FilterPartial : Driver
	{
		private FindBy ThisBy;
		private FindBy DropDownBy = new FindBy(".field-body");
		private FindBy FieldItemsBy = new FindBy(".field .multi-dropdown-option-menu span.option-line label.ng-binding");
		private FindBy FilterBy = new FindBy(".field-body .output");
		private FindBy OptionsBy = new FindBy(".toolbar-buttons .mdi-dots-vertical");

		public FilterPartial(WebDriver driver, FindBy findBy) : base(driver)
		{
			ThisBy = findBy;
		}

		/// <summary>
		/// Clicks the DropDownMenu.
		/// </summary>
		/// <returns></returns>
		public FilterPartial Field()
		{
			_driver.FindElement(ThisBy)
				.FindElement(DropDownBy)
				.Click();
			return this;
		}

		/// <summary>
		/// Selects the Field 'name' from the DropDownMenu.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public FilterPartial SelectField(string name)
		{
			_driver.FindElement(ThisBy)
				.FindElements(FieldItemsBy)
				.Find(x => StringCompare(x.Text, name))
				.Click();
			return this;
		}

		/// <summary>
		/// Click the Filter element.
		/// </summary>
		/// <returns></returns>
		public FilterPartial Filter()
		{
			_driver.FindElement(ThisBy).FindElement(FilterBy).Click();
			return this;
		}

		/// <summary>
		/// Control used when the Filter is a StringSelect.
		/// </summary>
		public StringSelectPartial StringSelectFilter
		{
			get
			{
				return new StringSelectPartial(_driver);
			}
		}

		/// <summary>
		/// Control used when the Filter is a ListSelect.
		/// </summary>
		public CheckedListPartial CheckedListFilter
		{
			get
			{
				return new CheckedListPartial(_driver, new FindBy(ThisBy.Selector + " " + FilterBy.Selector));
			}
		}

		/// <summary>
		/// Control used when the Filter is a DateSelect.
		/// </summary>
		public DateSelectPartial DateSelectFilter
		{
			get
			{
				return new DateSelectPartial(_driver);
			}
		}

		/// <summary>
		/// Control used for the Options menu of this Filter.
		/// </summary>
		public ToolBarButtonPartial Options
		{
			get
			{
				var newFindBy = new FindBy(ThisBy.Selector + OptionsBy.Selector);
				return new ToolBarButtonPartial(_driver, newFindBy);
			}
		}
	}
}

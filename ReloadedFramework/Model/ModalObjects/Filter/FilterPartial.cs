using ReloadedFramework.Model.AbstractClasses;
using ReloadedFramework.Model.ViewObjects.ToolBarObjects;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	public class FilterPartial : Driver
	{
		private FindBy ThisBy;
		private FindBy FieldBy = new FindBy(ByMethod.CssSelector, ".field-body .field select");
		private FindBy FilterBy = new FindBy(ByMethod.CssSelector, ".field-body .output");
		private FindBy OptionsBy = new FindBy(ByMethod.CssSelector, ".toolbar-buttons .mdi-dots-vertical");

		public FilterPartial(WebDriver driver, FindBy findBy) : base(driver)
		{
			ThisBy = findBy;
		}

		public FilterPartial Field()
		{
			_driver.FindElement(ThisBy)
				.FindElement(FieldBy)
				.Click();
			return this;
		}

		public FilterPartial SelectField(string name)
		{
			_driver.FindElement(ThisBy)
				.FindElement(FieldBy)
				.FindElement(ByMethod.CssSelector, "option[label='" + name + "']")
				.Click();
			return this;
		}

		public FilterPartial Filter()
		{
			_driver.FindElement(ThisBy).FindElement(FilterBy).Click();
			return this;
		}

		public StringSelectPartial StringSelectFilter
		{
			get
			{
				return new StringSelectPartial(_driver, FilterBy);
			}
		}

		public ListSelectPartial ListSelectFilter
		{
			get
			{
				return new ListSelectPartial(_driver, FilterBy);
			}
		}

		public DateSelectPartial DateSelectFilter
		{
			get
			{
				return new DateSelectPartial(_driver, FilterBy);
			}
		}

		public ToolBarButtonPartial Options
		{
			get
			{
				return new ToolBarButtonPartial(_driver, new FindBy(OptionsBy.Method, ThisBy.Selector + OptionsBy.Selector));
			}
		}
	}
}

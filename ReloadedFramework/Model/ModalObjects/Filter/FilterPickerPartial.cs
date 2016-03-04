using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	public class FilterPickerPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-content");
		private FindBy ButtonsBy = new FindBy(ByMethod.CssSelector, ".modal-footer button");
		private FindBy TabsBy = new FindBy(ByMethod.CssSelector, ".modal-tabs a");
		private FindBy ActionsBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-content .action-group");

		public FilterPickerPartial(WebDriver driver) : base(driver) { }

		private WebElement This
		{
			get
			{
				return _driver.FindElement(ThisBy);
			}
		}

		private WebElement FindButton(string name)
		{
			return This.FindElements(ButtonsBy).Find(x => x.Text.ToLower() == name.ToLower());
		}

		public FilterPickerPartial AddNew()
		{
			FindButton("add new group").Click();
			return this;
		}

		public FilterPickerPartial Apply()
		{
			FindButton("apply").Click();
			return this;
		}

		public FilterPickerPartial Cancel()
		{
			FindButton("cancel").Click();
			return this;
		}

		private WebElement FindTab(string name)
		{
			return This.FindElements(TabsBy).Find(x => x.Text.ToLower() == name.ToLower());
		}

		public FilterPickerPartial Simple()
		{
			FindTab("simple").Click();
			return this;
		}

		public FilterPickerPartial Advanced()
		{
			FindTab("advanced").Click();
			return this;
		}

		/// <summary>
		/// Select Filter Group by number.
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		private FilterGroupPartial FilterGroup(string number)
		{
			return new FilterGroupPartial(_driver, new FindBy(ByMethod.CssSelector, ActionsBy + ":nth-child(" + number + ")"));
		}

		public FilterPickerPartial SelectColumn(string name)
		{
			return this;
		}
	}
}

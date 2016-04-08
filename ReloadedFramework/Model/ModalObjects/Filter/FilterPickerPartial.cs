using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	public class FilterPickerPartial : Modal
	{
		private FindBy ButtonsBy = new FindBy(".modal-footer button");
		private FindBy TabsBy = new FindBy(".modal-tab-holder a");

		public FilterPickerPartial(WebDriver driver) : base(driver) { }

		public FilterPickerPartial AddNew()
		{
			FindButton("Add new group").Click();
			return this;
		}

		public FilterPickerPartial Apply()
		{
			// first click the header on the modal to ensure no dropdowns are open.
			Header.Click();
			FindButton("Apply").Click();
			return this;
		}

		public FilterPickerPartial Cancel()
		{
			FindButton("Cancel").Click();
			return this;
		}

		private WebElement FindTab(string name)
		{
			return ModalContainer.FindElements(TabsBy).Find(x => StringCompare(x.Text, name));
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
		public FilterGroupPartial FilterGroup(string number)
		{
			return new FilterGroupPartial(_driver, new FindBy("#myModal .modal-content .action-group:nth-child(" + number + ")"));
		}
	}
}
using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	public class FilterGroupPartial : Driver
	{
		private FindBy ThisBy;
		private FindBy FiltersBy = new FindBy(ByMethod.CssSelector, ".filter-item-field");

		public FilterGroupPartial(WebDriver driver, FindBy findBy) : base(driver)
		{
			ThisBy = findBy;
		}

		public FilterPartial Filter(string number)
		{
			return new FilterPartial(_driver, new FindBy(ByMethod.CssSelector, FiltersBy.Selector + ":nth-child(" + number + ")"));
		}
	}
}

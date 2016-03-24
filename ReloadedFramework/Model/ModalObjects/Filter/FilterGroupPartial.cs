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
			var newfindBy = new FindBy(ThisBy.Selector + " " + FiltersBy.Selector + ":nth-child(" + number + ")");
			return new FilterPartial(_driver, newfindBy);
		}
	}
}

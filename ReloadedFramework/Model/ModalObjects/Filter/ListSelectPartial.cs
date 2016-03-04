using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	public class ListSelectPartial : Driver
	{
		private FindBy ThisBy;
		private FindBy ListItemsBy = new FindBy(ByMethod.CssSelector, "input[type='checkbox']");
		private FindBy SearchBoxBy = new FindBy(ByMethod.CssSelector, "input[type='search']");

		public ListSelectPartial(WebDriver driver, FindBy thisBy) : base(driver)
		{
			ThisBy = thisBy;
		}

		/// <summary>
		/// Checks the item in the list with [name].
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ListSelectPartial SelectByName(string name)
		{
			_driver.FindElement(ThisBy)
				.FindElements(ListItemsBy)
				.Find(x => x.GetAttribute("value").Equals(name))
				.Click();
			return this;
		}

		/// <summary>
		/// Inserts the [name] into the search box.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ListSelectPartial SearchFor(string name)
		{
			var element = _driver.FindElement(ThisBy).FindElement(SearchBoxBy);
			element.Clear();
			element.SendKeys(name);
			return this;
		}
	}
}

using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	/// <summary>
	/// Provides a search field and a list with checkboxes.
	/// </summary>
	/// <param name="driver"></param>
	/// <param name="thisBy"></param>
	public class CheckedListPartial : Driver
	{
		private FindBy ThisBy;
		private FindBy ListItemsBy = new FindBy(ByMethod.CssSelector, "input[type='checkbox']");
		private FindBy SearchBoxBy = new FindBy(ByMethod.CssSelector, "input[type='search']");

		public CheckedListPartial(WebDriver driver, FindBy thisBy) : base(driver)
		{
			ThisBy = thisBy;
		}

		/// <summary>
		/// Checks the item in the list with [name].
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public CheckedListPartial SelectByName(string name)
		{
			_driver.FindElement(ThisBy)
				.FindElements(ListItemsBy)
				.Find(x => x.GetAttribute("value").Trim().Equals(name))
				.Click();
			return this;
		}

		/// <summary>
		/// Inserts the [name] into the search box.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public CheckedListPartial SearchFor(string name)
		{
			var element = _driver.FindElement(ThisBy).FindElement(SearchBoxBy);
			if (element.IsVisible)
			{
				element.Clear();
				element.SendKeys(name);
			}
			return this;
		}
	}
}

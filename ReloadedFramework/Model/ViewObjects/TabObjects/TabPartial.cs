using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;
using System.Linq;

namespace ReloadedFramework.Model.ViewObjects
{
	public class TabPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "durell-tabs");
		private FindBy TabsBy = new FindBy(ByMethod.CssSelector, "[ng-model=openTabs] a");

		public TabPartial(WebDriver driver) : base(driver) { }

		private WebElement FindTabByName(string name)
		{
			return _driver.FindElement(ThisBy)
				.FindElements(TabsBy)
				.Find(x => x.Text == name.ToUpper());
		}

		public TabPartial ClickTab(string name)
		{
			var result = FindTabByName(name);
			if (result != null)
			{
				result.Click();
			}
			return this;
		}

		/// <summary>
		/// Right click the Tab (name).
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public TabPartial RightClickTab(string name)
		{
			var result = FindTabByName(name);
			if (result != null)
			{
				result.RightClick(_driver);
			}
			return this;
		}

		/// <summary>
		/// Performs a right mouse click on the currently active tab.
		/// </summary>
		/// <returns></returns>
		public TabPartial RightClickActiveTab()
		{
			_driver.FindElement(ThisBy)
						.FindElements(TabsBy)
						.Find(x => x.GetAttribute("class").Contains("active"))
						.RightClick(_driver);
			return this;
		}

		/// <summary>
		/// Returns true if the Tab with 'name' is open.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool TabExists(string name)
		{
			var result = FindTabByName(name);
			if (result != null)
			{
				return result.IsVisible;
			}
			return false;
		}

		public bool TabIsActive(string name)
		{
			var result = FindTabByName(name);
			if (result != null)
			{
				return FindTabByName(name).GetAttribute("class").Contains("active");
			}
			return false;
		}

		public int Count()
		{
			 return _driver.FindElement(ThisBy).FindElements(TabsBy).Count();
		}

		public TabContextMenuPartial ContextMenu
		{
			get
			{
				return new TabContextMenuPartial(_driver);
			}
		}
	}
}

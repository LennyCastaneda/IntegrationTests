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
				return FindTabByName(name).GetAttribute("ng-class").Contains("active");
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

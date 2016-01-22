using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects
{
	public class TabContextMenuPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#ngContextMenu");
		private FindBy ReloadBy = new FindBy(ByMethod.CssSelector, ".mdi-refresh");
		private FindBy DuplicateBy = new FindBy(ByMethod.CssSelector, ".mdi-content-copy");
		private FindBy CloseTabBy = new FindBy(ByMethod.CssSelector, ".mdi-close-circle");
		private FindBy CloseTabsToRightBy= new FindBy(ByMethod.CssSelector, ".mdi-exit-to-app");

		public TabContextMenuPartial(WebDriver driver) : base(driver) { }

		public bool IsVisible
		{
			get
			{
				var result = _driver.FindElement(ThisBy);
				if (result != null)
				{
					return result.IsVisible;
				}
				return false;
			}
		}

		private WebElement FindElementBy(FindBy findBy)
		{
			return  _driver.FindElement(ThisBy)
				.FindElement(findBy);
		}

		public TabContextMenuPartial Reload()
		{
			FindElementBy(ReloadBy).Click();
			return this;
		}

		public TabContextMenuPartial Duplicate()
		{
			FindElementBy(DuplicateBy).Click();
			return this;
		}

		public TabContextMenuPartial CloseTab()
		{
			FindElementBy(CloseTabBy).Click();
			return this;
		}

		public TabContextMenuPartial CloseTabsToRight()
		{
			FindElementBy(CloseTabsToRightBy).Click();
			return this;
		}
	}
}

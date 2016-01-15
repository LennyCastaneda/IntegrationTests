using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadedFramework.Model.ViewObjects.ToolBarObjects
{
	public class ToolBarPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#tab_holder > div.toolbar.col-xs-12.ng-scope");
		private FindBy SettingsBy = new FindBy(ByMethod.CssSelector, "div.toolbar-buttons.navbar-right > div > a > i.mdi-settings");
		private FindBy BackBy = new FindBy(ByMethod.CssSelector, "div.toolbar-buttons.navbar-left > div > a > i.mdi-keyboard-backspace");

		public ToolBarPartial(WebDriver driver) : base(driver) { }

		public bool IsVisible
		{
			get
			{
				return _driver.FindElement(ThisBy).IsVisible;
			}
		}

		public ToolBarButton Cog
		{
			get
			{
				return new ToolBarButton(_driver, SettingsBy);
			}
		}

		public ToolBarButton Back
		{
			get
			{
				return new ToolBarButton(_driver, BackBy);
			}
		}
	}

	public class ToolBarButton : Driver
	{
		private FindBy ThisBy;

		public ToolBarButton(WebDriver driver, FindBy findBy) : base(driver)
		{
			_driver = driver;
			ThisBy = findBy;
		}

		public ToolBarButton Click()
		{
			_driver.FindElement(ThisBy).Click();
			return this;
		}

		public bool IsVisible
		{
			get
			{
				return _driver.FindElement(ThisBy).IsVisible;
			}
		}

		public bool DropDownIsVisible
		{
			get
			{
				return _driver.FindElement(ThisBy).FindElement(ByMethod.XPath, "../..").GetAttribute("class").Contains("open");
			}
		}

		public ToolBarButton ClickItem(string name)
		{
			var result = _driver.FindElement(ThisBy)
				.FindElement(ByMethod.XPath, "../..")
				.FindElements(ByMethod.CssSelector, "ul li")
				.FindAll(x => x.FindElements(ByMethod.CssSelector, "a").Count() > 0)
				.Find(x => x.Text.StartsWith(name, StringComparison.OrdinalIgnoreCase));

			if (result != null && result.IsVisible)
			{
				result.Click();
			}
			return this;
		}
	}
}
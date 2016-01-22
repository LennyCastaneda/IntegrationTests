using System;
using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class MenuPartial : Driver
	{
		private FindBy MenuBy = new FindBy(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.sidebar");
		private FindBy OpenBy = new FindBy(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar > div.container-fluid > div > a.reloaded-icon-button.btn.btn-flat");
		private FindBy CloseBy = new FindBy(ByMethod.ClassName, "mdi-keyboard-backspace");
		private FindBy MenuItemsBy = new FindBy(ByMethod.CssSelector, ".sidebar ul li");

		public MenuPartial(WebDriver driver) : base(driver) {}

		/// <summary>
		/// Opens the Menu by simulating a click on the burger icon.
		/// </summary>
		public MenuPartial Open()
		{
			_driver.FindElement(OpenBy).Click();
			return this;
		}

		/// <summary>
		/// Closes the Menu by simulating a click on the back arrow.
		/// </summary>
		public MenuPartial Close()
		{
			_driver.FindElement(MenuBy).FindElement(CloseBy).Click();
			return this;
		}

		public MenuPartial CloseByClickingOffMenuBar()
		{
			_driver.FindElement(ByMethod.Id, "tab_holder").Click();
			return this;
		}

		/// <summary>
		/// Returns true if the Menu is currently open.
		/// </summary>
		public bool IsVisible
		{
			get
			{
				return _driver.FindElement(MenuBy).GetAttribute("class") == "sidebar visible";
			}
		}

		/// <summary>
		/// Returns true if the Item exists and is Visible. Otherwise returns false.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool ItemIsVisible(string name)
		{
			var result = _driver.FindElements(MenuItemsBy)
				.FindAll(x => x.FindElements(ByMethod.CssSelector, "a").Count > 0)
				.Find(x => x.FindElement(ByMethod.CssSelector, "a").Text == name);
			if (result != null)
			{
				return result.IsVisible;
			}
			return false;
		}

		public bool ItemIsExpanded(string name)
		{
			var result = _driver.FindElements(MenuItemsBy)
				.FindAll(x => x.FindElements(ByMethod.CssSelector, "a").Count > 0)
				.Find(x => x.FindElement(ByMethod.CssSelector, "a").Text == name);
			
			if (result != null)
			{
				return result.FindElement(ByMethod.XPath, "..").GetAttribute("class").Contains("expanded");
			}
			return false;
		}

		public MenuPartial ClickItem(string name)
		{
			_driver.FindElements(MenuItemsBy)
				.FindAll(x => x.FindElements(ByMethod.CssSelector, "a").Count > 0)
				.Find(x => x.FindElement(ByMethod.CssSelector, "a").Text == name).Click(2000);
			return this;
		}

		public MenuPartial ClickSubItem(string name)
		{
			_driver.FindElements(ByMethod.CssSelector, MenuItemsBy.Selector + " ul li")
				.Find(x => x.FindElement(ByMethod.CssSelector, "a").Text == name)
				.Click(2000);
			return this;
		}
	}
}

using ReloadedInterface.Interfaces;
using System.Collections.Generic;
using System;

namespace ReloadedFramework.Model
{
	public class Menu : SubController<MenuItem>
	{
		private FindBy MenuBy = new FindBy(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.sidebar");
		private FindBy OpenBy = new FindBy(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar > div.container-fluid > div > a.reloaded-icon-button.btn.btn-flat");
		private FindBy CloseBy = new FindBy(ByMethod.ClassName, "mdi-keyboard-backspace");
		private FindBy SubItemsBy = new FindBy(ByMethod.XPath, "ul/li");

		public Menu(ref WebDriver driver) : base(ref driver) {
			if (_driver.Title == "Reloaded")
			{
				if (_driver.FindElements(MenuBy.Method, MenuBy.Selector + ".visible").Count > 0)
				{
					_element = _driver.FindElement(MenuBy.Method, MenuBy.Selector + ".visible");
				}
				else if (_driver.FindElements(MenuBy).Count > 0)
				{
					_element = _driver.FindElement(MenuBy);
				}
			}
		}

		/// <summary>
		/// Opens the Menu by simulating a click on the burger icon.
		/// </summary>
		public void Open()
		{
			var button = _driver.FindElement(OpenBy.Method, OpenBy.Selector);
			button.Click();
		}

		/// <summary>
		/// Closes the Menu by simulating a click on the back arrow.
		/// </summary>
		public void Close()
		{
			_element.FindElement(CloseBy.Method, CloseBy.Selector).Click();
		}

		/// <summary>
		/// Returns true if the Menu is currently open.
		/// </summary>
		public bool IsOpen
		{
			get
			{
				if (_element != null)
				{
					return _element.GetAttribute("class") == "sidebar visible";
				}
				else
				{
					return false;
				}
			}
		}

		/// <summary>
		/// Retrieves and stores all MenuItems in the _subItem dictionary. 
		/// </summary>
		public override void GetSubItems()
		{
			_subItems = new Dictionary<string, MenuItem>();
			var items = _element.FindElements(SubItemsBy);
			foreach(var item in items.FindAll(x => !string.IsNullOrEmpty(x.Text)))
			{
				_subItems.Add(item.FindElement(ByMethod.XPath, "a").Text, new MenuItem(_driver, item));
			}
		}
	}
}

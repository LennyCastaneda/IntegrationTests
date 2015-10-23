using ReloadedInterface.Interfaces;
using System.Collections.Generic;

namespace ReloadedFramework.Model
{
	public class Menu
	{
		private WebDriver _driver;
		private WebElement _menu;
		private static Dictionary<string, MenuItem> _menuItems;
		public MenuItem SelectedItem { get; private set; }

		public Menu(ref WebDriver driver)
		{
			_driver = driver;
		}

		public MenuItem Item(string name)
		{
			SelectedItem = _menuItems[name];
            return SelectedItem ?? null;
		}

		public void OpenMenu()
		{
			var button = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar > div.container-fluid > div > a.reloaded-icon-button.btn.btn-flat");
			button.Click();
			GetMenu();
		}

		public void CloseMenu()
		{
			_menu.FindElement(ByMethod.ClassName, "mdi-keyboard-backspace").Click();
		}

		private void GetMenu()
		{
			_menu = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.sidebar.visible");
		}

		public bool IsOpen
		{
			get
			{
				if (_menu != null)
				{
					return _menu.GetAttribute("class") == "sidebar visible";
				}
				else
				{
					GetMenu();
					return false;
				}
			}
		}

		public void GetMenuItems()
		{
			var items = _menu.FindElements(ByMethod.XPath, @"//*[@id='ngBody']/div[1]/nav[2]/ul/li");
			var result = new Dictionary<string, MenuItem>();
			items.ForEach((s) => {
				var element = s.FindElement(ByMethod.CssSelector, "a");
				if (element != null)
				{
					result.Add(element.Text, new MenuItem(s));
				}
			});
			_menuItems = result;
        }
	}
}

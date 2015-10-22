using ReloadedInterface.Interfaces;
using SeleniumInterface.Interfaces;
using System.Collections.Generic;

namespace ReloadedFramework.Model
{
	public class Menu
	{
		private WebDriver _driver;
		private WebElement _menu;

		public Menu(ref WebDriver driver)
		{
			_driver = driver;
		}

		public void OpenMenu()
		{
			_driver.FindElement(ByMethod.XPath, "//div[class='navbar-left']/a[1]").Click();
			_driver.OpenMenu();
			_menu = _driver.FindElement(ByMethod.CssSelector, "sidebar visible");
		}

		public void CloseMenu()
		{
			_menu.FindElement(ByMethod.ClassName, "mdi-keyboard-backspace").Click();
		}

		public bool IsOpen
		{
			get
			{
				return _menu.GetCssValue("class") == "sidebar visible";
			}
		}

		public List<WebElement> MenuItems()
		{
			var items = _menu.FindElements(ByMethod.XPath, @"//*[@id='ngBody']/div[1]/nav[2]/ul/li");
			return items;
        }
	}
}

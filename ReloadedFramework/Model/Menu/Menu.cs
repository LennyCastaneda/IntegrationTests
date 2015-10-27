using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;

namespace ReloadedFramework.Model
{
	public class Menu : SubController<MenuItem>
	{
		public Menu(ref WebDriver driver) : base(ref driver) { }

		public void OpenMenu()
		{
			var button = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar > div.container-fluid > div > a.reloaded-icon-button.btn.btn-flat");
			button.Click();
			SelectControl();
		}

		/// <summary>
		/// Finds the WebElement on the page and assigns it to _element.
		/// </summary>
		private void SelectControl()
		{
			_element = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.sidebar.visible");
		}

		public void CloseMenu()
		{
			_element.FindElement(ByMethod.ClassName, "mdi-keyboard-backspace").Click();
		}

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
					SelectControl();
					return false;
				}
			}
		}

		public override void GetSubItems()
		{
			var items = _element.FindElements(ByMethod.XPath, @"//*[@id='ngBody']/div[1]/nav[2]/ul/li");
			var result = new Dictionary<string, MenuItem>();
			items.ForEach((s) => {
				var element = s.FindElement(ByMethod.CssSelector, "a");
				if (element != null)
				{
					result.Add(element.Text, new MenuItem(_driver, s));
				}
			});
			_subItems = result;
		}
	}
}

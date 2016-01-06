using System.Collections.Generic;
using ReloadedInterface.Interfaces;
using ReloadedFramework.Model.AbstractClasses;

namespace ReloadedFramework.Model.ViewObjects.ToolBarObjects
{
	public class ToolBar : SubController<Button>
	{
		public ToolBar(WebDriver driver, string name, WebElement element) : base(driver, name)
		{
			_element = element;
			_subItems = new Dictionary<string, Button>();
		}

		public override void GetSubItems()
		{
			try
			{
				_subItems.Add("Settings", new Button(_driver, "Settings", _element.FindElement(ByMethod.CssSelector, "div.toolbar-buttons.navbar-right > div > a > i.mdi-settings").FindElement(ByMethod.XPath, "../..")));
			}
			catch { }
			try
			{
				_subItems.Add("Back", new Button(_driver, "Back", _element.FindElement(ByMethod.CssSelector, "div.toolbar-buttons.navbar-left > div > a > i.mdi-keyboard-backspace").FindElement(ByMethod.XPath, "../..")));
			}
			catch { }
		}
	}
}

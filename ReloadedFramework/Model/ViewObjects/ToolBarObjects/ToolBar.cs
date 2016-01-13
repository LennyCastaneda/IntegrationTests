using System.Collections.Generic;
using ReloadedInterface.Interfaces;
using ReloadedFramework.Model.AbstractClasses;

namespace ReloadedFramework.Model.ViewObjects.ToolBarObjects
{
	public class ToolBar : SubController<Button>
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#tab_holder > div.toolbar.col-xs-12.ng-scope");
		private FindBy SettingsBy = new FindBy(ByMethod.CssSelector, "div.toolbar-buttons.navbar-right > div > a > i.mdi-settings");
		private FindBy BackBy = new FindBy(ByMethod.CssSelector, "div.toolbar-buttons.navbar-left > div > a > i.mdi-keyboard-backspace");

		public ToolBar(WebDriver driver, string name) : base(driver, name)
		{
			_subItems = new Dictionary<string, Button>();
		}

		private void SelectElement()
		{
			_element = _driver.FindElement(ThisBy);
		}

		public override void GetSubItems()
		{
			SelectElement();
			_subItems.Clear();
			try
			{
				_subItems.Add("Settings", new Button(_driver, "Settings", _element.FindElement(SettingsBy).FindElement(ByMethod.XPath, "../..")));
			}
			catch { }
			try
			{
				_subItems.Add("Back", new Button(_driver, "Back", _element.FindElement(BackBy).FindElement(ByMethod.XPath, "../..")));
			}
			catch { }
		}
	}
}

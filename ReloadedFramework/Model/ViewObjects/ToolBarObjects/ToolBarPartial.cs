using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

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

		public ToolBarButtonPartial Cog
		{
			get
			{
				return new ToolBarButtonPartial(_driver, SettingsBy);
			}
		}

		public ToolBarButtonPartial Back
		{
			get
			{
				return new ToolBarButtonPartial(_driver, BackBy);
			}
		}
	}
}
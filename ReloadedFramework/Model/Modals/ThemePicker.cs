using System;
using ReloadedInterface.Interfaces;
using ReloadedFramework.Model.Tabs.ToolBar;

namespace ReloadedFramework.Model
{
	public class ThemePicker : Modal
	{
		FindBy IsOpenBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div.themes-holder");
		FindBy CloseBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-footer > button[ng-click='revertTheme()']");
		FindBy ApplyBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-footer > button[ng-click='applySelectedTheme()']");
		FindBy ColoursBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div > div > p");
		FindBy AddNewBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div > a > p");

		public ThemePicker(WebDriver driver, string name) : base(driver, name) { }

		public override bool IsOpen()
		{
			return _driver.ElementExists(() => {
				var result = _driver.FindElement(ByMethod.CssSelector, "#myModal");

				if (result == null  || _driver.FindElement(IsOpenBy) == null)
				{
					throw new Exception("Element not found");
				}

				if (result.GetAttribute("style").Contains("display: none;"))
				{
					throw new Exception("Element not visible");
				}
			});
        }

		public override void Close()
		{
			_driver.ElementExists(() =>
			{
				 _driver.FindElement(CloseBy).Click();
			});
		}

		public void ClickApply()
		{
			_driver.ElementExists(() =>
			{
				_driver.FindElement(ApplyBy).Click();
			});
		}

		public void ClickColour(string colour)
		{
			_driver.ElementExists(() =>
			{
				_driver.FindElements(ColoursBy).Find(x => x.Text == colour).Click();
			});
		}

		public void ClickAddNew()
		{
			_driver.ElementExists(() =>
			{
				_driver.FindElement(AddNewBy).Click();
			});
		}
	}
}

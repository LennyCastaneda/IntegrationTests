using System;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class ThemePicker : Modal
	{
		FindBy IsOpenBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div.themes-holder");
		FindBy CloseBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-footer > button[ng-click='revertTheme()']");
		FindBy ApplyBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-footer > button[ng-click='applySelectedTheme(\\'view\\')']");
		FindBy ColoursBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div > div > p");
		FindBy AddNewBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div > a > p");

		public ThemePicker(WebDriver driver, string name) : base(driver, name) { }

		public override bool IsOpen()
		{
			var result = _driver.FindElement(ByMethod.CssSelector, "#myModal");

			if (result == null || _driver.FindElement(IsOpenBy) == null)
			{
				return false;
			}
			if (result.GetAttribute("style").Contains("display: none;"))
			{
				return false;
			}
			return true;
		}

		public override void Close()
		{
			_driver.FindElement(CloseBy).Click();
		}

		public void ClickApply()
		{
			_driver.FindElement(ApplyBy).Click(500);
		}

		public void ClickColour(string colour)
		{
			_driver.FindElements(ColoursBy).Find(x => x.Text == colour).Click();
		}

		public void ClickAddNew()
		{
			_driver.FindElement(AddNewBy).Click();
		}
	}
}

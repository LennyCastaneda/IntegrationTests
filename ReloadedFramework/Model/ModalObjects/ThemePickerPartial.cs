using ReloadedInterface.Interfaces;
using ReloadedFramework.Model.AbstractClasses;

namespace ReloadedFramework.Model.ModalObjects
{
	public class ThemePickerPartial : Driver
	{
		FindBy ThisBy = new FindBy(ByMethod.CssSelector, ".themes-holder");
		FindBy IsOpenBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div.themes-holder");
		FindBy CloseBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-footer > button[ng-click='revertTheme()']");
		FindBy ApplyBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-footer > button[ng-click='applySelectedTheme(\\'view\\')']");
		FindBy ColoursBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div > div > p");
		FindBy AddNewBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div > a > p");

		public ThemePickerPartial(WebDriver driver) : base(driver) { }

		public bool IsVisible
		{
			get
			{
				var result = _driver.FindElement(ThisBy);
				if (result != null && !result.GetAttribute("style").Contains("display: none"))
				{
					return result.IsVisible;
				}
				return false;
			}
		}

		public ThemePickerPartial Cancel()
		{
			_driver.FindElement(CloseBy).Click();
			return this;
		}

		public ThemePickerPartial ClickApply()
		{
			_driver.FindElement(ApplyBy).Click(500);
			return this;
		}

		public ThemePickerPartial ClickColour(string colour)
		{
			_driver.FindElements(ColoursBy).Find(x => x.Text == colour).Click();
			return this;
		}

		public ThemePickerPartial ClickAddNew()
		{
			_driver.FindElement(AddNewBy).Click();
			return this;
		}
	}
}

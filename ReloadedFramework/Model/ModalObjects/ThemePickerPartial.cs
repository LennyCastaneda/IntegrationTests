using ReloadedInterface.Interfaces;
using ReloadedFramework.Model.AbstractClasses;

namespace ReloadedFramework.Model.ModalObjects
{
	public class ThemePickerPartial : Driver
	{
		FindBy ThisBy = new FindBy(ByMethod.CssSelector, ".themes-holder");
		FindBy IsOpenBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div.themes-holder");
		FindBy CloseBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-footer > button[ng-click='revertTheme()']");
		FindBy ApplyToViewBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-footer > button[ng-click='applySelectedTheme(\\'view\\')']");
		FindBy ApplyToConfigBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-footer > button[ng-click='applySelectedTheme(\\'configuration\\')']");
		FindBy ColoursBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div > div > p");
		//FindBy AddNewBy = new FindBy(ByMethod.CssSelector, "#myModal > div.modal-dialog.ng-scope > div > div.modal-body > div > a > p");

		public ThemePickerPartial(WebDriver driver) : base(driver) { }

		/// <summary>
		/// Returns true if the Partial is visible to the user.
		/// </summary>
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

		/// <summary>
		/// Clicks 'Cancel'.
		/// </summary>
		/// <returns></returns>
		public ThemePickerPartial Cancel()
		{
			_driver.FindElement(CloseBy).Click();
			return this;
		}

		/// <summary>
		/// Clicks 'Apply to View'.
		/// </summary>
		/// <returns></returns>
		public ThemePickerPartial ApplyToView()
		{
			_driver.FindElement(ApplyToViewBy).Click(500);
			return this;
		}

		/// <summary>
		/// Clicks 'Apply to Configuration'.
		/// </summary>
		/// <returns></returns>
		public ThemePickerPartial ApplyToConfiguration()
		{
			_driver.FindElement(ApplyToConfigBy).Click(500);
			return this;
		}

		/// <summary>
		/// Clicks the colour specified.
		/// </summary>
		/// <param name="colour"></param>
		/// <returns></returns>
		public ThemePickerPartial Colour(string colour)
		{
			_driver.FindElements(ColoursBy).Find(x => x.Text == colour).Click();
			return this;
		}

		/// <summary>
		/// Clicks the 'Add New' colour option.
		/// </summary>
		/// <returns></returns>
		//public ThemePickerPartial AddNew()
		//{
		//	_driver.FindElement(AddNewBy).Click();
		//	return this;
		//}
	}
}

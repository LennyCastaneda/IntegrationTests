using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class LoginPagePartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-content");
		private FindBy UsernameBy = new FindBy(ByMethod.CssSelector, ".modal-body input");
		private FindBy PasswordBy = new FindBy(ByMethod.CssSelector, "");
		private FindBy AcceptBy = new FindBy(ByMethod.CssSelector, ".modal-footer button[ng-click*='onReturnPrompt']");

		public LoginPagePartial(WebDriver driver) : base(driver) { }

		public LoginPagePartial EnterUsername(string username)
		{
			_driver.FindElement(ThisBy)
				.FindElement(UsernameBy)
				.Clear();
			_driver.FindElement(ThisBy)
				.FindElement(UsernameBy)
				.SendKeys(username);
			return this;
		}

		public LoginPagePartial EnterPassword(string password)
		{
			_driver.FindElement(ThisBy)
				.FindElement(PasswordBy)
				.SendKeys(password);
			return this;
		}

		public App Submit()
		{
			_driver.FindElement(ThisBy)
				.FindElement(AcceptBy)
				.Click();
			return new App(_driver, true);
		}
	}
}


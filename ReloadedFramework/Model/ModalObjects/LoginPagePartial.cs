using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class LoginPagePartial : Modal
	{
		private FindBy UsernameBy = new FindBy(ByMethod.CssSelector, ".modal-body input");
		private FindBy PasswordBy = new FindBy(ByMethod.CssSelector, "");

		public LoginPagePartial(WebDriver driver) : base(driver) { }

		public LoginPagePartial EnterUsername(string username)
		{
			var element = Body.FindElement(UsernameBy);
			element.Clear();
			element.SendKeys(username);
			return this;
		}

		public LoginPagePartial EnterPassword(string password)
		{
			var element = Body.FindElement(PasswordBy);
			element.Clear();
			element.SendKeys(password);
			return this;
		}

		public App Submit()
		{
			FindButton("login").Click();
			return new App(_driver, true);
		}

		public void Cancel()
		{
			FindButton("cancel");
		}
	}
}


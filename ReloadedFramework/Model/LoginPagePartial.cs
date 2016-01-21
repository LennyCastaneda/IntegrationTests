using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class LoginPagePartial : Driver
	{
		public LoginPagePartial(WebDriver driver) : base(driver) { }

		public LoginPagePartial EnterUsername(string username)
		{
			// enter username
			return this;
		}

		public LoginPagePartial EnterPassword(string password)
		{
			// enter password
			return this;
		}

		public App Submit()
		{
			// Hit enter
			return new App(_driver, true);
		}
	}
}

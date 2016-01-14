using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class LoginPage : Driver
	{
		public LoginPage(WebDriver driver) : base(driver) { }

		public LoginPage EnterUsername(string username)
		{
			// enter username
			return this;
		}

		public LoginPage EnterPassword(string password)
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

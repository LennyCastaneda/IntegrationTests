using ReloadedFramework.Model.AbstractClasses;
using ReloadedFramework.Model.ViewObjects;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	/// <summary>
	/// Controls all application level navigation and properties.
	/// </summary>
	public class App : Driver
	{
		bool LoggedIn;

		public App(WebDriver driver, bool loggedIn) : base(driver) {
			LoggedIn = loggedIn;
		}

		public LoginPage Login
		{
			get
			{
				return new LoginPage(_driver);
			}
		}

		public MenuPartial Menu
		{
			get
			{
				return new MenuPartial(_driver);
			}
		}

		public ViewPartial View
		{
			get
			{
				return new ViewPartial(_driver);
			}
		}

		public TabPartial Tabs
		{
			get
			{
				return new TabPartial(_driver);
			}
		}
	}
}

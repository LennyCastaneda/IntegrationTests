using ReloadedFramework.Model.PageObjects;
using ReloadedInterface.Generators;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class Browser
	{
		/// <summary>
		/// Core of the AutomatedTests. Root of everything.
		/// </summary>
		public static WebDriver _driver;
		public static Page Page { get; private set; }
		public static App App { get; set; }

		public static void Init(string driverName)
		{
			_driver = WebDriverFactory.CreateDriver(driverName);
			Page = new Page(_driver);
			App = new App(_driver, false);
		}
	}
}
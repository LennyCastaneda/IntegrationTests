using ReloadedInterface.Generators;
using ReloadedInterface.Interfaces;
using System;

namespace ReloadedFramework.Model
{
	public class Browser
	{
		private static WebDriver _driver;
		public static Page Page { get; private set; }
		public static Menu Menu { get; private set; }
		public static View View { get; private set; }
		public static Manual Manual { get; private set; }
		public static ThemePicker ThemePicker { get; private set; }
		public static string Type { get; private set; }

		public static void Init(string driverName)
		{
			_driver = WebDriverFactory.CreateDriver(driverName);
			_driver.Tick += new WebDriver.TickHandler(Refresh);
			Page = new Page(_driver);
			Type = driverName;
			Manual = new Manual(_driver, "Manual");
			ThemePicker = new ThemePicker(_driver, "ThemePicker");
		}

		private static void Refresh(WebDriver driver, EventArgs e)
		{
			Refresh();
		}

		private static void Refresh()
		{
			Menu = new Menu(_driver, "Menu");
			View = new View(_driver, "View");
		}
	}
}

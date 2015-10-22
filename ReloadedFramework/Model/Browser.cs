using ReloadedInterface.Generators;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class Browser
	{
		private static WebDriver _driver;
		public static Page Page { get; private set; }
		public static Menu Menu { get; private set; }
		public static string Type { get; private set; }

		public static void Init(string driverName)
		{
			_driver = WebDriverFactory.CreateDriver(driverName);
			Page = new Page(ref _driver);
			Menu = new Menu(ref _driver);
			Type = driverName;
		}
	}
}

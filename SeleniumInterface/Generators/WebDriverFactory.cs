using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using ReloadedInterface.Interfaces;
using System;

namespace ReloadedInterface.Generators
{
	/// <summary>
	/// Enum that lists supported browsers.
	/// </summary>
	public enum WebDriverType
	{
		Chrome,
		Firefox,
		IE32,
		IE64,
		Edge
	}

	/// <summary>
	/// Contains static methods that return an IWebDriver for the specified browser. Contains any browser specific implementations required.
	/// /// </summary>
	public static class WebDriverFactory
	{
		public static WebDriver CreateDriver(string driverName)
		{
			WebDriverType type;
			if (Enum.TryParse<WebDriverType>(driverName, out type))
			{
				return CreateDriver(type);
			}
			throw new ArgumentException("driverName is not valid.");
		}

		public static WebDriver CreateDriver(WebDriverType browser)
		{
			switch (browser)
			{
				case WebDriverType.Firefox:
					return new WebDriver(FireFox());
				case WebDriverType.Chrome:
					return new WebDriver(Chrome());
				case WebDriverType.IE32:
					return new WebDriver(IE32Bit());
				case WebDriverType.IE64:
					return new WebDriver(IE64Bit());
				case WebDriverType.Edge:
					return new WebDriver(Edge());
				default:
					throw new ArgumentException("Unknown BrowserType");
			}
		}
		
		private static IWebDriver FireFox()
		{
			return new FirefoxDriver();
		}

		private static IWebDriver Chrome()
		{
			return new ChromeDriver(@"\WebDrivers\chromedriver_win32\");
		}

		private static IWebDriver IE32Bit()
		{
			return new InternetExplorerDriver(@"\WebDrivers\IEDriverServer_Win32_2.47.0");
		}

		private static IWebDriver IE64Bit()
		{
			return new InternetExplorerDriver(@"\WebDrivers\IEDriverServer_x64_2.47.0");
		}

		private static IWebDriver Edge()
		{
			return new EdgeDriver(@"\WebDrivers\Microsoft Web Driver");
		}
	}
}

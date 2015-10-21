using OpenQA.Selenium;

namespace ReloadedInterface.Interfaces
{
	public class WebDriver
	{
		private IWebDriver webDriver;

		public WebDriver(IWebDriver driver)
		{
			webDriver = driver;
		}

		public string CurrentWindowHandle
		{
			get
			{
				return webDriver.CurrentWindowHandle;
			}
		}

		public string PageSource
		{
			get
			{
				return webDriver.PageSource;
			}
		}

		public string Title
		{
			get
			{
				return webDriver.Title;
			}
		}

		public string Url
		{
			get
			{
				return webDriver.Url;
			}

			set
			{
				webDriver.Url = value;
			}
		}

		public void Close()
		{
			webDriver.Close();
		}

		public void Dispose()
		{
			webDriver.Dispose();
		}

		public WebElement FindElement(By by)
		{
			return webDriver.FindElement(by) as WebElement;
		}

		public void Navigate(string url)
		{
			webDriver.Navigate().GoToUrl(url);
		}

		public void Quit()
		{
			webDriver.Quit();
		}
	}
}

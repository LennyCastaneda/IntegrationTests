using OpenQA.Selenium;
using SeleniumInterface.Interfaces;
using System.Collections.Generic;

namespace ReloadedInterface.Interfaces
{
	public class WebDriver
	{
		private IWebDriver _driver;

		public WebDriver(IWebDriver driver)
		{
			_driver = driver;
		}

		public string CurrentWindowHandle
		{
			get
			{
				return _driver.CurrentWindowHandle;
			}
		}

		public string PageSource
		{
			get
			{
				return _driver.PageSource;
			}
		}

		public string Title
		{
			get
			{
				return _driver.Title;
			}
		}

		public string Url
		{
			get
			{
				return _driver.Url;
			}

			set
			{
				_driver.Url = value;
			}
		}

		public void Close()
		{
			_driver.Close();
		}

		public void Dispose()
		{
			_driver.Dispose();
		}

		public List<WebElement> FindElements(ByMethod method, string selector)
		{
			return Common.FindElements(_driver, method, selector);
        }

		public WebElement FindElement(ByMethod method, string selector)
		{
			return Common.FindElement(_driver, method, selector);
		}

		public void Navigate(string url)
		{
			_driver.Navigate().GoToUrl(url);
		}

		public void Quit()
		{
			_driver.Quit();
		}

		public void OpenMenu()
		{
			var button = _driver.FindElement(By.XPath("//div[class='navbar-left']/a[1]"));
			button.Click();
		}
	}
}

using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace ReloadedInterface.Interfaces
{
	public class WebDriver : Common
	{
		private IWebDriver _driver;

		public WebDriver(IWebDriver driver)
		{
			_driver = driver;
			Maximize();
			//_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
			//_driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
			//_driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(5));
		}

		public string CurrentWindowHandle
		{
			get
			{
				return _driver.CurrentWindowHandle;
			}
		}

		private void Maximize()
		{
			if (!(_driver is EdgeDriver))
			{
				_driver.Manage().Window.Maximize();
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

		public void Navigate(string url)
		{
			_driver.Navigate().GoToUrl(url);		
			System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
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

		public WebElement FindElement(ByMethod method, string selector)
		{
			WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
			WebElement result = wait.Until<WebElement>((_driver) => {
				//wait.Until(ExpectedConditions.ElementIsVisible(GetBy(method, selector)));
				//wait.Until(ExpectedConditions.ElementToBeClickable(GetBy(method, selector)));
				//wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(GetBy(method, selector)));
				return new WebElement(wait.Until(ExpectedConditions.ElementToBeClickable(GetBy(method, selector))));
			});

			return result;
		}

		public List<WebElement> FindElements(ByMethod method, string selector)
		{
			var result = new List<WebElement>();
			foreach (IWebElement element in _driver.FindElements(GetBy(method, selector)))
			{
				result.Add(new WebElement(element));
			}
			return result;
		}
	}
}

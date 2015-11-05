using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;

namespace ReloadedInterface.Interfaces
{
	public class WebDriver : Common
	{
		public event TickHandler Tick;
		public EventArgs e = null;
		public delegate void TickHandler(WebDriver m, EventArgs e);
		private static IWebDriver _driver;

		public WebDriver(IWebDriver driver)
		{
			_driver = driver;
			Maximize();
			SetImplicitWait(TimeSpan.FromMilliseconds(3000));
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
			Tick(this, e);
		}

		public void Quit()
		{
			_driver.Quit();
		}

		public static void SetImplicitWait(TimeSpan span)
		{
			_driver.Manage().Timeouts().ImplicitlyWait(span);
			//_driver.Manage().Timeouts().SetPageLoadTimeout(span);
			//_driver.Manage().Timeouts().SetScriptTimeout(span);
		}

		public WebElement FindElement(ByMethod method, string selector)
		{
			if (_driver.FindElements(GetBy(method, selector)).Count > 0)
			{
				WebElement result = default(WebElement);
				result = new WebElement(_driver.FindElement(GetBy(method, selector)));
				return result;
			}
			return null;
		}

		public WebElement FindElement(FindBy findby)
		{
			return FindElement(findby.Method, findby.Selector);
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

		public List<WebElement> FindElements(FindBy findby)
		{
			return FindElements(findby.Method, findby.Selector);
		}
	}
}

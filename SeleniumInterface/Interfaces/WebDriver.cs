﻿using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;

namespace ReloadedInterface.Interfaces
{
	public class WebDriver : Common
	{
		private static IWebDriver _driver;

		public WebDriver(IWebDriver driver)
		{
			_driver = driver;
			Maximize();
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
		}

		public void Quit()
		{
			_driver.Quit();
		}

		/// <summary>
		/// Send a sequence of keystrokes to the browser.
		/// </summary>
		/// <param name="keys"></param>
		public void SendKeys(string keys)
		{
			string translated = typeof(Keys).GetField(keys).GetValue(null) as string;
			new Actions(_driver).SendKeys(translated).Perform();
			Wait();
		}

		public void RemoveAnimationDelay()
		{
			IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
			js.ExecuteScript(@"var style = document.createElement('style'); style.type = 'text/css'; style.innerHTML = '* {transition-property: none !important; -o-transition-property: none !important; -moz-transition-property: none !important; -ms-transition-property: none !important;-webkit-transition-property: none !important; transform: none !important; -o-transform: none !important; -moz-transform: none !important; -ms-transform: none !important; -webkit-transform: none !important; animation: none !important; -o-animation: none !important; -moz-animation: none !important; -ms-animation: none !important; -webkit-animation: none !important; }'; document.body.appendChild(style);");
			js.ExecuteScript(@"$.fx.off = true;");
		}

		public WebElement FindElement(ByMethod method, string selector)
		{
			WebElement result = null;
			if (_driver.FindElements(GetBy(method, selector)).Count > 0)
			{
				result = new WebElement(_driver.FindElement(GetBy(method, selector)));
			}
			return result;
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

		/// <summary>
		/// Drag and Drop element to target.
		/// </summary>
		/// <param name="elementBy"></param>
		/// <param name="targetBy"></param>
		public void DragAndDrop(FindBy sourceBy, FindBy targetBy)
		{
			IWebElement element = _driver.FindElement(GetBy(sourceBy.Method, sourceBy.Selector));
			IWebElement target = _driver.FindElement(GetBy(targetBy.Method, targetBy.Selector));
			(new Actions(_driver)).DragAndDrop(element, target).Perform();
		}

		/// <summary>
		/// Drag and Drop element by offsetX and offsetY.
		/// </summary>
		/// <param name="sourceBy"></param>
		/// <param name="offsetX"></param>
		/// <param name="offsetY"></param>
		public void DragAndDropToOffset(FindBy sourceBy, int offsetX, int offsetY)
		{
			IWebElement source = _driver.FindElement(GetBy(sourceBy.Method, sourceBy.Selector));
			(new Actions(_driver)).DragAndDropToOffset(source, offsetX, offsetY).Perform();
		}
	}
}

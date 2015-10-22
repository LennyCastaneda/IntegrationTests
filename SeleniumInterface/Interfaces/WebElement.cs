using OpenQA.Selenium;
using SeleniumInterface.Interfaces;
using System.Collections.Generic;
using System.Drawing;

namespace ReloadedInterface.Interfaces
{
	public class WebElement
	{
		private IWebElement _element;

		public WebElement(IWebElement element)
		{
			_element = element;
		}

		public bool Displayed
		{
			get
			{
				return _element.Displayed;
			}
		}

		public bool Enabled
		{
			get
			{
				return _element.Enabled;
			}
		}

		public Point Location
		{
			get
			{
				return _element.Location;
			}
		}

		public bool Selected
		{
			get
			{
				return _element.Selected;
			}
		}

		public Size Size
		{
			get
			{
				return _element.Size;
			}
		}

		public string TagName
		{
			get
			{
				return _element.TagName;
			}
		}

		public string Text
		{
			get
			{
				return _element.Text;
			}
		}

		public void Clear()
		{
			_element.Clear();
		}

		public void Click()
		{
			_element.Click();
		}

		public List<WebElement> FindElements(ByMethod method, string selector)
		{
			return Common.FindElements(_element, method, selector);
		}

		public WebElement FindElement(ByMethod method, string selector)
		{
			return Common.FindElement(_element, method, selector);
		}

		public string GetAttribute(string attributeName)
		{
			return _element.GetAttribute(attributeName);
		}

		public string GetCssValue(string propertyName)
		{
			return _element.GetCssValue(propertyName);
		}

		public void SendKeys(string text)
		{
			_element.SendKeys(text);
		}

		public void Submit()
		{
			_element.Submit();
		}
	}
}

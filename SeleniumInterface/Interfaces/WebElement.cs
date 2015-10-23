using OpenQA.Selenium;
using System.Collections.Generic;
using System.Drawing;

namespace ReloadedInterface.Interfaces
{
	public class WebElement : Common
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
			Wait(() => { _element.Click(); });
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

		public WebElement FindElement(ByMethod method, string selector)
		{
			if(_element.FindElements(GetBy(method, selector)).Count > 0)
			{
				return new WebElement(_element.FindElement(GetBy(method, selector)));
			}
			return null;
		}

		public List<WebElement> FindElements(ByMethod method, string selector)
		{
			var result = new List<WebElement>();
			foreach (IWebElement element in _element.FindElements(GetBy(method, selector)))
			{
				result.Add(new WebElement(element));
			}
			return result;
		}
	}
}

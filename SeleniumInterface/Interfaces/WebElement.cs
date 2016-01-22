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

		public bool IsVisible
		{
			get
			{
				return _element.Displayed && _element.Enabled;
			}
		}

		public Point Location
		{
			get
			{
				return _element.Location;
			}
		}

		public bool IsSelected
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
			ExplicitWait(() =>
			{
				_element.Clear();
			});
		}

		public void Click()
		{
			ExplicitWait(() =>
			{
				_element.Click();
			});
			Wait(500);
		}

		/// <summary>
		/// Clicks element then waits for the designated amount of milliseconds before continiuing.
		/// </summary>
		/// <param name="milliseconds"></param>
		public void Click(double milliseconds)
		{
			ExplicitWait(() =>
			{
				_element.Click();
			});
			Wait(milliseconds);
		}

		public string GetAttribute(string attributeName)
		{
			string result = null;
			ExplicitWait(() => {
				do
				{
					result = _element.GetAttribute(attributeName);
				} while (result == null);
			}, 3000);
			return result;
		}

		public string GetCssValue(string propertyName)
		{
			string result = "";
			ExplicitWait(() => {
				result = _element.GetCssValue(propertyName);
			});
			return result;
		}

		public void SendKeys(string text)
		{
			ExplicitWait(() =>
			{
				_element.SendKeys(text);
			});
		}

		public void Submit()
		{
			ExplicitWait(() =>
			{
				_element.Submit();
			});
		}

		public WebElement FindElement(ByMethod method, string selector)
		{
			WebElement result = null;
			if (_element.FindElements(GetBy(method, selector)).Count > 0)
			{
				result = new WebElement(_element.FindElement(GetBy(method, selector)));
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
			foreach (IWebElement element in _element.FindElements(GetBy(method, selector)))
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

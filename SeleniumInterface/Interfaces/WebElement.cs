using OpenQA.Selenium;
using System;
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

		public void DoubleClick(WebDriver _driver)
		{
			_driver.DoubleClick(_element);
		}

		public void RightClick(WebDriver driver)
		{
			ExplicitWait(() =>
			{
				driver.RightClick(_element);
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

		/// <summary>
		/// Drag and Drop this element to target.
		/// </summary>
		/// <param name="driver"></param>
		/// <param name="target"></param>
		public void DragAndDrop(WebDriver driver, WebElement target)
		{
			target.DragDropEnd(driver, _element);
		}

		/// <summary>
		/// Takes IWebElement from source.DragDropStart() and performs action in target.DragDropEnd().
		/// </summary>
		/// <param name="driver"></param>
		/// <param name="source"></param>
		private void DragDropEnd(WebDriver driver, IWebElement source)
		{
			driver.Drag(source, _element);
		}

		/// <summary>
		/// Drag and Drop element by offsetX and offsetY.
		/// </summary>
		/// <param name="sourceBy"></param>
		/// <param name="offsetX"></param>
		/// <param name="offsetY"></param>
		public void DragAndDropTo(WebDriver driver, int offsetX, int offsetY)
		{
			driver.DragAndDropTo(_element, offsetX, offsetY);
		}

		/// <summary>
		/// Returns the text of the current element, with all child node text removed.
		/// </summary>
		/// <returns></returns>
		public string GetNodeText
		{
			get
			{
				var result = this.Text;
				foreach (WebElement element in this.FindElements(ByMethod.CssSelector, "*"))
				{
					// Must only remove first instance of each substring.
					int index = result.IndexOf(element.Text);
					if (index != -1)
					{
						result = result.Remove(index, element.Text.Length);
					}
				}
				return result;
			}
		}

		public void MoveToElement(WebDriver driver)
		{
			driver.MoveToElement(_element);
		}
	}
}

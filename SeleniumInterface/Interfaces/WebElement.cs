using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Drawing;

namespace ReloadedInterface.Interfaces
{
	public class WebElement
	{
		private IWebElement webElement;

		public WebElement(IWebElement element)
		{
			webElement = element;
		}

		public bool Displayed
		{
			get
			{
				return webElement.Displayed;
			}
		}

		public bool Enabled
		{
			get
			{
				return webElement.Enabled;
			}
		}

		public Point Location
		{
			get
			{
				return webElement.Location;
			}
		}

		public bool Selected
		{
			get
			{
				return webElement.Selected;
			}
		}

		public Size Size
		{
			get
			{
				return webElement.Size;
			}
		}

		public string TagName
		{
			get
			{
				return webElement.TagName;
			}
		}

		public string Text
		{
			get
			{
				return webElement.Text;
			}
		}

		public void Clear()
		{
			webElement.Clear();
		}

		public void Click()
		{
			webElement.Click();
		}

		public WebElement FindElement(By by)
		{
			return new WebElement(webElement.FindElement(by));
		}

		// Need to edit to return a collection of WebElement not IWebElement. (if we ever want to use it).
		public ReadOnlyCollection<IWebElement> FindElements(By by)
		{
			return webElement.FindElements(by);
		}

		public string GetAttribute(string attributeName)
		{
			return webElement.GetAttribute(attributeName);
		}

		public string GetCssValue(string propertyName)
		{
			return webElement.GetCssValue(propertyName);
		}

		public void SendKeys(string text)
		{
			webElement.SendKeys(text);
		}

		public void Submit()
		{
			webElement.Submit();
		}
	}
}

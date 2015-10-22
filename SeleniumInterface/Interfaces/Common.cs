using OpenQA.Selenium;
using ReloadedInterface.Interfaces;
using System.Collections.Generic;

namespace SeleniumInterface.Interfaces
{
	public enum ByMethod
	{
		Id,
		ClassName,
		CssSelector,
		XPath
	}

	public static class Common
	{
		public static WebElement FindElement(ISearchContext context, ByMethod method, string selector)
		{
			return context.FindElement(GetBy(method, selector)) as WebElement;
		}

		public static List<WebElement> FindElements(this ISearchContext context, ByMethod method, string selector)
		{
			var result = new List<WebElement>();
			foreach (IWebElement element in context.FindElements(GetBy(method, selector)))
			{
				result.Add(element as WebElement);
			}
			return result;
		}

		public static OpenQA.Selenium.By GetBy(ByMethod method, string selector)
		{
			switch (method)
			{
				case ByMethod.Id:
					return By.Id(selector);
				case ByMethod.ClassName:
					return By.ClassName(selector);
				case ByMethod.CssSelector:
					return By.CssSelector(selector);
				case ByMethod.XPath:
					return By.XPath(selector);
				default:
					return null;
			}
		}
	}
}

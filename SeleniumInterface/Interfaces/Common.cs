using OpenQA.Selenium;
using System;
using System.Threading;

namespace ReloadedInterface.Interfaces
{
	/// <summary>
	/// List of Selenium By methods implemented.
	/// </summary>
	public enum ByMethod
	{
		Id,
		ClassName,
		CssSelector,
		XPath
	}

	/// <summary>
	/// Holds two variables: the method of an element search, and the selector used. Designed to keep all search strings in one place per class.
	/// </summary>
	public struct FindBy
	{
		public ByMethod Method { get; private set; }
		public string Selector { get; private set; }

		public FindBy(ByMethod method, string selector)
		{
			Method = method;
			Selector = selector;
		}
	}

	public class Common
	{
		private static TimeSpan Sleep = TimeSpan.FromMilliseconds(500);

		/// <summary>
		/// Calls Thread.Sleep() for a set amount of time, set in the Common parent class.
		/// </summary>
		public static void Wait()
		{
			Thread.Sleep(Sleep);
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

		public bool ElementExists(Action action)
		{
			WebDriver.SetImplicitWait(TimeSpan.FromSeconds(0));
			try
			{
				action();
				return true;
            }
			catch
			{
				return false;
			}
			finally
			{
				WebDriver.SetImplicitWait(TimeSpan.FromSeconds(5));
			}
		}
	}
}

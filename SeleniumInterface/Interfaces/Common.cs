using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Diagnostics;

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
		public static TimeSpan Sleep = TimeSpan.FromMilliseconds(2000);

		/// <summary>
		/// Calls Thread.Sleep() for a set amount of time, set in the Common parent class.
		/// </summary>
		public static void Wait()
		{
			Thread.Sleep(Sleep);
		}

		public static void Wait(TimeSpan span)
		{
			Thread.Sleep(span);
		}

		public static void Wait(double milliseconds)
		{
			Thread.Sleep(TimeSpan.FromMilliseconds(milliseconds));
		}

		public static bool ExplicitWait(Action action)
		{
			return ExplicitWait(action, Sleep);
		}

		public static bool ExplicitWait(Action action, double milliseconds)
		{
			return ExplicitWait(action, TimeSpan.FromMilliseconds(milliseconds));
		}

		public static bool ExplicitWait(Action action, TimeSpan timespan)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();

			while (sw.ElapsedMilliseconds < timespan.TotalMilliseconds)
			{
				try
				{
					action();
					return true;
				}
				catch (Exception ex)
				{
					if (sw.ElapsedMilliseconds > timespan.TotalMilliseconds)
					{
						throw ex;
					}
				}
			}
			return false;
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

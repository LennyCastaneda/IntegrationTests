using OpenQA.Selenium;
using System;

namespace ReloadedInterface.Interfaces
{
	public enum ByMethod
	{
		Id,
		ClassName,
		CssSelector,
		XPath
	}

	public class Common
	{
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

		/// <summary>
		/// Returns true if the method was completed without firing an Exception. Iterations defines how many times the method should attempt to suceed. Seconds denotes the amount of time to wait between attempts.
		/// </summary>
		/// <param name="method"></param>
		/// <param name="seconds"></param>
		/// <returns></returns>
		public static bool Wait(Action method, int iterations = 0, int seconds = 0)
		{
			int counter = 0;
			do
			{
				try
				{
					method();
					return true;
				}
				catch
				{
					System.Threading.Thread.Sleep(TimeSpan.FromSeconds(seconds));
				}
				counter++;
			} while (counter < iterations);
            return true;
		}
	}
}

using ReloadedInterface.Interfaces;
using System;

namespace ReloadedFramework.Model.AbstractClasses
{
	/// <summary>
	/// Derived class contains a reference to a WebDriver passed by the constructor.
	/// </summary>
	public abstract class Driver
	{
		protected WebDriver _driver;

		public Driver(WebDriver driver)
		{
			_driver = driver;
		}

		/// <summary>
		/// A case-insensitive comparison that trims any leading or trailing spaces.
		/// </summary>
		/// <param name="one"></param>
		/// <param name="two"></param>
		/// <returns></returns>
		public bool StringCompare(string one, string two)
		{
			return one.Trim().ToLower() == two.Trim().ToLower();
		}
	}
}
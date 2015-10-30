﻿using ReloadedInterface.Generators;
using ReloadedInterface.Interfaces;
using System;

namespace ReloadedFramework.Model
{
	public class Browser
	{
		private static WebDriver _driver;
		public static Page Page { get; private set; }
		public static Menu Menu { get; private set; }
		public static View View { get; private set; }
		public static Modal Modal { get; private set; }
		public static string Type { get; private set; }

		public static void Init(string driverName)
		{
			_driver = WebDriverFactory.CreateDriver(driverName);
			_driver.Tick += new WebDriver.TickHandler(Refresh);
			Page = new Page(ref _driver);
			Type = driverName;
		}

		private static void Refresh(WebDriver driver, EventArgs e)
		{
			Refresh();
		}

		private static void Refresh()
		{
			Menu = new Menu(ref _driver, "Menu");
			View = new View(ref _driver, "View");
			Modal = new Modal(ref _driver, "Modal");
		}
	}
}

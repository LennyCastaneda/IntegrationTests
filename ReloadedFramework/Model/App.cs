using ReloadedFramework.Model.AbstractClasses;
using ReloadedFramework.Model.ModalObjects;
using ReloadedFramework.Model.ViewObjects;
using ReloadedInterface.Interfaces;
using System.Collections.Generic;

namespace ReloadedFramework.Model
{
	/// <summary>
	/// Controls all application level navigation and properties.
	/// </summary>
	public class App : Driver
	{
		bool LoggedIn;

		/// <summary>
		/// Store variables to share between steps.
		/// </summary>
		public Dictionary<string, object> SharedInfo { get; set; }

		public App(WebDriver driver, bool loggedIn) : base(driver)
		{
			LoggedIn = loggedIn;
			SharedInfo = new Dictionary<string, object>();
		}

		public LoginPagePartial Login
		{
			get
			{
				return new LoginPagePartial(_driver);
			}
		}

		public MenuPartial Menu
		{
			get
			{
				return new MenuPartial(_driver);
			}
		}

		public ViewPartial View
		{
			get
			{
				return new ViewPartial(_driver);
			}
		}

		public TabPartial Tabs
		{
			get
			{
				return new TabPartial(_driver);
			}
		}

		public ThemePickerPartial ThemePicker
		{
			get
			{
				return new ThemePickerPartial(_driver);
			}
		}

		public ColumnPickerPartial ColumnPicker
		{
			get
			{
				return new ColumnPickerPartial(_driver);
			}
		}

		public string BackgroundColour
		{
			get
			{
				var colour = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar").GetCssValue("background-color");
				return colour;
			}
		}
	}
}
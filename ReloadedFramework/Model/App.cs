using ReloadedFramework.Model.AbstractClasses;
using ReloadedFramework.Model.ModalObjects;
using ReloadedFramework.Model.ViewObjects;
using ReloadedFramework.Model.PageObjects;

using ReloadedInterface.Interfaces;
using System.Collections.Generic;
using ReloadedFramework.Model.ModalObjects.Filter;

namespace ReloadedFramework.Model
{
	/// <summary>
	/// Controls all application level navigation and properties.
	/// </summary>
	public class App : Driver
	{
		bool LoggedIn;

		private FindBy BackgroundColourBy = new FindBy(ByMethod.CssSelector, "#ngBody .reloaded-nav-bar");

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

		public GroupPickerPartial GroupPicker
		{
			get
			{
				return new GroupPickerPartial(_driver);
			}
		}

		public FilterPickerPartial FilterPicker
		{
			get
			{
				return new FilterPickerPartial(_driver);
			}
		}

		public ConfigurationMenuPartial ConfigMenu
		{
			get
			{
				return new ConfigurationMenuPartial(_driver);
			}
		}

		public SaveAsPartial SaveAs
		{
			get
			{
				return new SaveAsPartial(_driver);
			}
		}

		public string BackgroundColour
		{
			get
			{
				return _driver.FindElement(BackgroundColourBy).GetCssValue("background-color");
			}
		}
	}
}
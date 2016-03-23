using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class ConfigurationMenuPartial : Driver
	{
		FindBy IconBy = new FindBy(ByMethod.CssSelector, ".mdi-view-quilt");
		FindBy ThisBy = new FindBy(ByMethod.CssSelector, ".configuration-menu");
		FindBy ChooseThemeBy = new FindBy(ByMethod.CssSelector, "ul li .mdi-invert-colors");
		FindBy SaveBy = new FindBy(ByMethod.CssSelector, "ul li .mdi-content-save");
		FindBy SaveAsBy = new FindBy(ByMethod.CssSelector, "ul li .mdi-content-save-all");
		FindBy ConfigsBy = new FindBy(ByMethod.CssSelector, "ul li a[ng-click='openConfiguration(config)']");

		public ConfigurationMenuPartial(WebDriver driver) : base(driver) { }

		public bool IsVisible
		{
			get
			{
				return _driver.FindElement(ThisBy).IsVisible;
			}
		}

		/// <summary>
		/// Clicks the ConfigurationMenu Icon in the top right corner.
		/// </summary>
		/// <returns></returns>
		public ConfigurationMenuPartial Open()
		{
			_driver.FindElement(IconBy).Click();
			return this;
		}

		/// <summary>
		/// Clicks the configuration with 'name'.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ConfigurationMenuPartial SelectConfiguration(string name)
		{
			FindConfigByName(name).Click();
			return this;
		}

		/// <summary>
		/// Returns true if the configuration with 'name' exists in the ConfigurationMenu.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool ConfigExists(string name)
		{
			return FindConfigByName(name) != null;
		}

		/// <summary>
		/// Finds the configuration with 'name'.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		private WebElement FindConfigByName(string name)
		{
			return _driver.FindElement(ThisBy)
					.FindElements(ConfigsBy)
					.Find(x => StringCompare(x.Text, name));
		}

		public bool ConfigurationIsActive(string name)
		{
			return FindConfigByName(name).FindElement(ByMethod.CssSelector, ".mdi-check") != null;
		}

		public ConfigurationMenuPartial ChooseTheme()
		{
			_driver.FindElement(ThisBy)
				.FindElement(ChooseThemeBy)
				.Click();
			return this;
		}

		public ConfigurationMenuPartial Save()
		{
			_driver.FindElement(ThisBy)
				   .FindElement(SaveBy)
				   .Click();
			return this;
		}

		public ConfigurationMenuPartial SaveAs()
		{
			_driver.FindElement(ThisBy)
				   .FindElement(SaveAsBy)
				   .Click();
			return this;
		}
	}

}
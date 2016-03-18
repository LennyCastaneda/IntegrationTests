using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class ConfigurationMenuPartial : Driver
	{
		FindBy IconBy = new FindBy(ByMethod.CssSelector, "mdi-view-quilt");
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

		public ConfigurationMenuPartial Open()
		{
			_driver.FindElement(IconBy).Click();
			return this;
		}

		public ConfigurationMenuPartial SelectConfiguration(string name)
		{
			_driver.FindElement(ThisBy)
				.FindElements(ConfigsBy)
				.Find(x => x.Text == name)
				.Click();
			return this;
		}

		public bool ConfigurationIsActive(string name)
		{
			return _driver.FindElement(ThisBy)
				.FindElements(ConfigsBy)
				.Find(x => x.Text == name)
				.FindElement(ByMethod.CssSelector, ".mdi-check") != null;
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
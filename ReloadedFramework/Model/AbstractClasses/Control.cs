using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.AbstractClasses
{
	/// <summary>
	/// Derived class contains an uninstantiated WebElement and a Click() method.
	/// </summary>
	public abstract class Control : Driver
	{
		protected WebElement _element;
		private WebDriver driver;

		public string Name { get; set; }

		public Control(WebDriver driver, string name) : base(driver)
		{
			Name = name;
		}
		public Control(WebDriver driver, string name, WebElement element) : base(driver)
		{
			Name = name;
			_element = element;
		}
	}
}
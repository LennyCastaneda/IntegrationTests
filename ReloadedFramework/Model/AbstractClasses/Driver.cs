using ReloadedInterface.Interfaces;

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
	}
}
using ReloadedInterface.Interfaces;
using System.Collections.Generic;

namespace ReloadedFramework.Model
{
	/// <summary>
	/// Derived class contains a reference to a WebDriver passed by the constructor.
	/// </summary>
	public abstract class Driver
	{
		protected WebDriver _driver;

		public Driver(ref WebDriver driver)
		{
			_driver = driver;
		}
    }

	/// <summary>
	/// Derived class contains an uninstantiated WebElement and a Click() method.
	/// </summary>
	public abstract class Control : Driver
	{
		protected WebElement _element;

		public Control(ref WebDriver driver) : base(ref driver) { }

		public void Click()
		{
			_element.Click();
		}
	}

	/// <summary>
	/// Derived class contains a Dictionary of type T sub-objects and controls to access them.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class SubController<T> : Control
	{
		protected static Dictionary<string, T> _subItems;
		public T SelectedItem { get; set; }

		public SubController(ref WebDriver driver) : base(ref driver) { }

		public abstract void GetSubItems();

		public T SubItem(string name)
		{
			SelectedItem = _subItems[name];
			return SelectedItem;
		}
	}
}

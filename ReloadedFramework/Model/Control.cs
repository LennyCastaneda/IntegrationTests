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
		public string Name { get; set; }

		public Control(ref WebDriver driver, string name) : base(ref driver) {
			Name = name;
		}
	}

	public abstract class ClickableControl : Control
	{
		public ClickableControl(ref WebDriver driver, string name) : base(ref driver, name) { }

		public abstract void Click();
	}

	/// <summary>
	/// Derived class contains a Dictionary of type T sub-objects and controls to access them.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class SubController<T> : Control where T : Control
	{
		protected Dictionary<string, T> _subItems;
		public T SelectedItem { get; set; }

		public SubController(ref WebDriver driver, string name) : base(ref driver, name) { }
		
		/// <summary>
		/// All derived classes must define a method to store every relevant Control within the _subItems Dictionary.
		/// </summary>
		public abstract void GetSubItems();

		/// <summary>
		/// Returns the number of SubItems.
		/// </summary>
		public int SubItemCount
		{
			get
			{
				if (_subItems == null)
				{
					return 0;
				}
				return _subItems.Count;
			}
		}

		/// <summary>
		/// Checks the SubItem[key] exists.
		/// </summary>
		public bool SubItemExists(string name)
		{
			if(SelectedItem.Name == name)
			{
				return true;
			}
			return (Any() ? _subItems.ContainsKey(name) : false);
		}

		/// <summary>
		/// Returns SubItem[key] value.
		/// </summary>
		public T SubItem(string key)
		{
			if (SelectedItem.Name == key)
			{
				return SelectedItem;
			}

			if (Any())
			{
				if (!_subItems.ContainsKey(key))
				{
					GetSubItems();
				}
				SelectedItem = _subItems[key];
				return (T)SelectedItem;
			}
			return null;
		}

		/// <summary>
		/// Returns false if there are no SubItems.
		/// </summary>
		private bool Any()
		{
			if (SubItemCount == 0)
			{
				GetSubItems();
			}
			return SubItemCount > 0;
		}
	}
}

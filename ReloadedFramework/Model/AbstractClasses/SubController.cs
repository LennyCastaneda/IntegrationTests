using ReloadedInterface.Interfaces;
using System.Collections.Generic;

namespace ReloadedFramework.Model.AbstractClasses
{
	/// <summary>
	/// Derived class contains a Dictionary of type T sub-objects and controls to access them.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class SubController<T> : Control where T : Control
	{
		protected Dictionary<string, T> _subItems;
		public T SelectedItem { get; set; }

		public SubController(WebDriver driver, string name) : base(driver, name) { }

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
			if (SelectedItem != null && SelectedItem.Name == name)
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
			if (SelectedItem != null && SelectedItem.Name == key)
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

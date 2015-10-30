using ReloadedInterface.Interfaces;
using System.Collections.Generic;
using System;

namespace ReloadedFramework.Model
{
	public class MenuItem : SubController<MenuItem>
	{
		private FindBy SubItemsBy = new FindBy(ByMethod.XPath, "ul/li");
		private FindBy LinkBy = new FindBy(ByMethod.XPath, "a");

		public MenuItem(WebDriver driver, WebElement element) : base(ref driver)
		{
			_element = element;
        }

		/// <summary>
		/// Returns true if this MenuItem is expandable.
		/// </summary>
		public bool IsExpandable
		{
			get
			{
				return _element.GetAttribute("class").Contains("expandable");
			}
		}

		/// <summary>
		/// Returns true if the current MenuItem is expanded.
		/// </summary>
		public bool Expanded
		{
			get
			{
				return (IsExpandable ? (_element.GetAttribute("class") == "expandable expanded") : false);
			}
		}

		public override void GetSubItems()
		{
			_subItems = new Dictionary<string, MenuItem>();
			var items = _element.FindElements(SubItemsBy);
			foreach (var item in items.FindAll(x => !string.IsNullOrEmpty(x.Text)))
			{
				_subItems.Add(item.FindElement(ByMethod.XPath, "a").Text, new MenuItem(_driver, item));
			}
		}

		public void Click()
		{
			_element.FindElement(LinkBy).Click();
		}
	}
}

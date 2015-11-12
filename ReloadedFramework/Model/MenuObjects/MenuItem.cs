using ReloadedInterface.Interfaces;
using ReloadedFramework.Model.AbstractClasses;
using System.Collections.Generic;

namespace ReloadedFramework.Model.MenuObjects
{
	public class MenuItem : SubController<MenuItem>
	{
		private FindBy SubItemsBy = new FindBy(ByMethod.XPath, "ul/li");
		private FindBy LinkBy = new FindBy(ByMethod.XPath, "a");

		public MenuItem(WebDriver driver, string name, WebElement element) : base(driver, name)
		{
			_element = element;
			GetSubItems();
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
				return (IsExpandable ? (_element.GetAttribute("class").Contains("expanded")) : false);
			}
		}

		public override void GetSubItems()
		{
			_subItems = new Dictionary<string, MenuItem>();
			foreach (var item in _element.FindElements(SubItemsBy).FindAll(x => !string.IsNullOrEmpty(x.Text)))
			{
				var name = item.FindElement(ByMethod.XPath, "a").Text;
				_subItems.Add(name, new MenuItem(_driver, name, item));
			}
		}

		public void Click()
		{
			_element.FindElement(LinkBy).Click();
		}
	}
}

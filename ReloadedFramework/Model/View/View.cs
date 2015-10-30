using System;
using ReloadedFramework.Model;
using ReloadedInterface.Interfaces;
using System.Collections.Generic;

namespace ReloadedFramework.Model
{
	public class View : SubController<Tab>
	{
		// Potentially change to be the "Tabs" object; inherit SubController<Tab>
		// Therefore the _subItems are the different tabs,
		// call to View.SubItem("Home") would set "Home" to active tab, update the current viewBody and ToolBar. 
		// CurrentTab is set on TabClick,
		// another element would control the Tab Settings.
		private FindBy TabsBy = new FindBy(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar > div.container.z1 > div > div");
		private FindBy SubItemsBy = new FindBy(ByMethod.CssSelector, "a");

		public static WebElement ActiveTab { get; private set; }
		public static WebElement ToolBar { get; private set; }

		public View(ref WebDriver driver, string name) : base(ref driver, name)
		{
			if (_driver.Title == "Reloaded")
			{
				SelectElement();
				//GetSubItems();
			}
		}

		private void SelectElement()
		{
			_element = _driver.FindElement(TabsBy);
		}

		public override void GetSubItems()
		{
			var items = _element.FindElements(SubItemsBy);
			var result = new Dictionary<string, Tab>();
			items.ForEach((element) => {
				if (element != null)
				{
					result.Add(element.Text, new Tab(ref _driver, element.Text));
				}
			});
			_subItems = result;
		}
	}
}

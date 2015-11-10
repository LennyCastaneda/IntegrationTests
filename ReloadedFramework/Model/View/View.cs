using System;
using ReloadedFramework.Model;
using ReloadedInterface.Interfaces;
using System.Collections.Generic;
using ReloadedFramework.Model.Tabs.ToolBar;

namespace ReloadedFramework.Model
{
	public class View : Control
	{
		// SubItems are the Tab list.
		// Always find active tabs by their tabs (not the body).
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar > div.container.z1 > div > div");
		private FindBy SubItemsBy = new FindBy(ByMethod.CssSelector, "a");
		private FindBy ActiveViewBy = new FindBy(ByMethod.CssSelector, "#tab_holder > div[style*='display: block']");
		private FindBy ToolBarBy = new FindBy(ByMethod.CssSelector, "#tab_holder > div.toolbar.col-xs-12.ng-scope > div");

		Dictionary<string, Tab> Tabs;
		public static WebElement ActiveView { get; private set; }
		public static Tab ActiveTab { get; private set; }
		public static ToolBar ToolBar { get; private set; }

		public View(WebDriver driver, string name) : base(driver, name)
		{
			if (_driver.Title == "Reloaded")
			{
				SelectElement();
				GetTabs();
				InitiateToolBar();
            }
		}

		private void InitiateToolBar()
		{
			_driver.ElementExists(() =>
			{
				var temp = _driver.FindElement(ToolBarBy);
				if (temp != null)
				{
					ToolBar = new ToolBar(_driver, "ToolBar", temp);
				}
			});
		}

		public void SetActiveTab(Tab tab)
		{
			ActiveTab = tab;
			ActiveView = _element.FindElement(ActiveViewBy);
			ToolBar = null;
			InitiateToolBar();
        }

		private void SelectElement()
		{
			_element = _driver.FindElement(ThisBy);
		}

		// Will have to call this from the Toolbar on Close and the Menu on opening a new tab.
		public void GetTabs()
		{
			List<WebElement> items = new List<WebElement>();
            if (_element.ElementExists(() => { items = _element.FindElements(SubItemsBy); }))
			{
				var result = new Dictionary<string, Tab>();
				items.ForEach((element) =>
				{
					if (element != null)
					{
						result.Add(element.Text.ToLower(), new Tab(_driver, element, element.Text, this));
					}
				});
				Tabs = result;
			}
		}

		public Tab Tab(string key)
		{
			key = key.ToLower();
			if (!Tabs.ContainsKey(key))
			{
				GetTabs();
			}
			ActiveTab = Tabs[key];
			return ActiveTab;
		}

		public int TabCount
		{
			get
			{
				GetTabs();
				return Tabs.Count;
			}
		}

		public string BackgroundColour()
		{
			var orig = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar").GetAttribute("style");
			var sub = orig.Substring(orig.LastIndexOf("background-color: rgb(") + 22);
            return sub.Remove(sub.IndexOf(")"));
		}
	}
}

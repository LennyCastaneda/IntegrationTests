using ReloadedFramework.Model.AbstractClasses;
using ReloadedFramework.Model.ViewObjects.ToolBarObjects;
using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;

namespace ReloadedFramework.Model.ViewObjects
{
	public class View : Control
	{
		// SubItems are the Tab list.
		// Always find active tabs by their tabs (not the body).
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar > durell-tabs > div > div > div");
		private FindBy SubItemsBy = new FindBy(ByMethod.CssSelector, "a");
		private FindBy ActiveViewBy = new FindBy(ByMethod.CssSelector, "#tab_holder > div[style*='display: block']");

		Dictionary<string, Tab> Tabs;

		public WebElement ActiveView
		{
			get
			{
				return _element.FindElement(ActiveViewBy);
			}
		}

		public Tab ActiveTab { get; private set; }

		public ToolBar ToolBar { get; private set; }

		public View(WebDriver driver, string name) : base(driver, name)
		{
			if (_driver.Title == "Reloaded")
			{
				Initiate();
				ToolBar = new ToolBar(_driver, "ToolBar");
			}
		}

		public bool Loading()
		{
			var loaded = _driver.FindElement(new FindBy(ByMethod.CssSelector, "#md-loading-bar")).GetCssValue("display") == "none";
			return !loaded;
		}

		private void Initiate()
		{
			SelectElement();
			GetTabs();
		}

		public void SetActiveTab(Tab tab)
		{
			ActiveTab = tab;
        }

		private void SelectElement()
		{
			_element = _driver.FindElement(ThisBy);
		}

		public void GetTabs()
		{
			if (_element == null)
			{
				SelectElement();
			}

			var items = new List<WebElement>();
            items = _element.FindElements(SubItemsBy);

			if(items.Count > 0)
			{
				var result = new Dictionary<string, Tab>();
				items.ForEach((element) =>
				{
					if (element != null && !String.IsNullOrEmpty(element.Text.ToLower()))
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

			if (ActiveTab != null && ActiveTab.Name == key)
			{
				return ActiveTab;
			}

			if (TabCount > 0)
			{
				if (!Tabs.ContainsKey(key))
				{
					GetTabs();
				}
				ActiveTab = Tabs[key];
				return ActiveTab;
			}
			return null;
		}

		public int TabCount
		{
			get
			{
				if (Tabs == null || Tabs.Count == 0)
				{
					GetTabs();
				}
				if(Tabs == null)
				{
					return 0;
				}
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

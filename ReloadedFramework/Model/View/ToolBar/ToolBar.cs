﻿using System;
using System.Collections.Generic;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.Tabs.ToolBar
{
	public class ToolBar : SubController<Button>
	{
		public ToolBar(WebDriver driver, string name, WebElement element) : base(driver, name)
		{
			_element = element;
			_subItems = new Dictionary<string, Button>();
		}

		public override void GetSubItems()
		{
			_element.ElementExists(() => {
				_subItems.Add("Help", new Button(_driver, "Help", _element.FindElement(ByMethod.CssSelector, "a i.mdi-help-circle").FindElement(ByMethod.XPath, "..")));
			});
			_element.ElementExists(() => {
				_subItems.Add("Search", new Button(_driver, "Search", _element.FindElement(ByMethod.CssSelector, "a i.mdi-magnify").FindElement(ByMethod.XPath, "..")));
			});
			_element.ElementExists(() => {
				_subItems.Add("Setup", new Button(_driver, "Setup", _element.FindElement(ByMethod.CssSelector, "a i.mdi-settings").FindElement(ByMethod.XPath, "../..")));
			});
			_element.ElementExists(() => {
				_subItems.Add("Overflow", new Button(_driver, "Overflow", _element.FindElement(ByMethod.CssSelector, "a i.mdi-dots-vertical").FindElement(ByMethod.XPath, "../..")));
			});
		}
	}
}

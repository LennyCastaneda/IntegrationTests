using ReloadedFramework.Model.Modals;
using ReloadedFramework.Model.Tabs.ToolBar;
using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadedFramework.Model.Tabs.ToolBar
{
	public class ToolBar : Control
	{
		View _view;
		public Help Help { get; private set; }
		public Search Search { get; private set; }
		public Setup Setup { get; private set; }
		public Overflow Overflow { get; private set; }

		FindBy HelpBy = new FindBy(ByMethod.CssSelector, "a i.mdi-help-circle");
		FindBy SearchBy = new FindBy(ByMethod.CssSelector, "a i.mdi-magnify");
		FindBy SetupBy = new FindBy(ByMethod.CssSelector, "a i.mdi-settings");
		FindBy OverflowBy = new FindBy(ByMethod.CssSelector, "a i.mdi-share-variant");
		
		public ToolBar(WebDriver driver, string name, WebElement element, View view) : base(driver, name)
		{
			_view = view;
			_element = element;

			_element.ElementExists(() => {
				Help = new Help(_driver, _element.FindElement(HelpBy).FindElement(ByMethod.XPath, ".."), "Help");
			});
			_element.ElementExists(() => { 
				Search = new Search(_driver, _element.FindElement(SearchBy).FindElement(ByMethod.XPath, ".."), "Search");
			});
			_element.ElementExists(() => {
				Setup = new Setup(_driver, _element.FindElement(SetupBy).FindElement(ByMethod.XPath, "../.."), "Setup");
			});
			_element.ElementExists(() => {
				Overflow = new Overflow(_driver, _element.FindElement(OverflowBy).FindElement(ByMethod.XPath, "../.."), "Overflow");
			});
		}

		public ClickableControl SubItem(string name)
		{
			switch(name)
			{
				case "Help":
					return Help;
				case "Setup":
					return Setup;
				case "Search":
					return Search;
				case "Overflow":
					return Overflow;
			}
			return null;
		}
	}
}

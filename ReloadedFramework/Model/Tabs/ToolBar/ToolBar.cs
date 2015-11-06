using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.Tabs.ToolBar
{
	public class ToolBar : Control
	{
		View _view;
		public Button Help { get; private set; }
		public Button Search { get; private set; }
		public Button Setup { get; private set; }
		public Button Overflow { get; private set; }
		
		public ToolBar(WebDriver driver, string name, WebElement element, View view) : base(driver, name)
		{
			_view = view;
			_element = element;
			_element.ElementExists(() => {
				Help = new Button(_driver, "Help", _element.FindElement(ByMethod.CssSelector, "a i.mdi-help-circle").FindElement(ByMethod.XPath, ".."));
			});
			_element.ElementExists(() => { 
				Search = new Button(_driver, "Search", _element.FindElement(ByMethod.CssSelector, "a i.mdi-magnify").FindElement(ByMethod.XPath, ".."));
			});
			_element.ElementExists(() => {
				Setup = new Button(_driver, "Setup", _element.FindElement(ByMethod.CssSelector, "a i.mdi-settings").FindElement(ByMethod.XPath, "../.."));
			});
			_element.ElementExists(() => {
				Overflow = new Button(_driver, "Overflow", _element.FindElement(ByMethod.CssSelector, "a i.mdi-dots-vertical").FindElement(ByMethod.XPath, "../.."));
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

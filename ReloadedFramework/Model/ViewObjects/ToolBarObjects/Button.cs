using System;
using ReloadedInterface.Interfaces;
using ReloadedFramework.Model.AbstractClasses;

namespace ReloadedFramework.Model.ViewObjects.ToolBarObjects
{
	public class Button : ClickableControl
	{
		public bool IsMenu { get; private set; }
		public ButtonGroup DropDown { get; private set; }

		public Button(WebDriver driver, string name, WebElement element) : base(driver, element, name)
		{
			if (_element.GetAttribute("class").Contains("btn-group")
				&& (_element.FindElements(ByMethod.XPath, "ul/li").Count > 0))
			{
				DropDown = new ButtonGroup(_driver, Name, _element);
			}
		}

		public bool IsOpen
		{
			get
			{
				return _element.GetAttribute("class").Contains("open");
			}
		}

		public override void Click()
		{
			_element.Click();
		}
	}
}

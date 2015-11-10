using System;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.Tabs.ToolBar
{
	public class Button : ClickableControl
	{
		public bool IsMenu { get; private set; }
		public ButtonGroup DropDown { get; private set; }

		public Button(WebDriver driver, string name, WebElement element) : base(driver, element, name)
		{
			IsMenu = _element.ElementExists(() =>
			{
				if (!_element.GetAttribute("class").Contains("btn-group"))
				{
					throw new Exception("Not a Menu");
				}

				if (_element.FindElements(ByMethod.XPath, "ul/li").Count == 0)
				{
					throw new Exception("No subitems");
				}
			});

			if (IsMenu)
			{
				DropDown = new ButtonGroup(_driver, Name, _element);
			}
		}

		public bool IsOpen
		{
			get
			{
				return _element.ElementExists(() =>
				{
					if (!_element.GetAttribute("class").Contains("btn-group open"))
					{
						throw new Exception("Not open");
					}
				});
			}
		}

		public override void Click()
		{
			_element.Click();
		}
	}
}

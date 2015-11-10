using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;

namespace ReloadedFramework.Model.Tabs.ToolBar
{
	public class ButtonGroup : SubController<Button>
	{
		private FindBy SubItemsBy = new FindBy(ByMethod.XPath, "ul/li");

		public ButtonGroup(WebDriver driver, string name, WebElement element) : base(driver, name)
		{
			_element = element;
		}

		public override void GetSubItems()
		{
			_element.ElementExists(() =>
			{
				_subItems = new Dictionary<string, Button>();
				foreach (var item in _element.FindElements(SubItemsBy).FindAll(x => !string.IsNullOrEmpty(x.Text)))
				{
					var name = item.FindElement(ByMethod.XPath, "a").Text;
					name = name.Split(new [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)[0];
					_subItems.Add(name, new Button(_driver, name, item));
				}
			});
		}
	}
}

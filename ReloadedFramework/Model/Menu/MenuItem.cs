using ReloadedInterface.Interfaces;
using System.Collections.Generic;
using System;

namespace ReloadedFramework.Model
{
	public class MenuItem : SubController<MenuItem>
	{
		public MenuItem(WebDriver driver, WebElement element) : base(ref driver)
		{
			_element = element;
        }

		public bool Expanded
		{
			get
			{
				return _element.GetAttribute("class") == "expandable expanded";
            }
		}

		public override void GetSubItems()
		{
			var items = _element.FindElements(ByMethod.XPath, @"//*[@id='ngBody']/div[1]/nav[2]/ul/li");
			var result = new Dictionary<string, MenuItem>();
			items.ForEach((s) => {
				var element = s.FindElement(ByMethod.CssSelector, "a");
				if (element != null)
				{
					result.Add(element.Text, new MenuItem(_driver, s));
				}
			});
			_subItems = result;
		}
	}
}

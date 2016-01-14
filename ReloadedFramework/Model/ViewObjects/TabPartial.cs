using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadedFramework.Model.ViewObjects
{
	public class TabPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "durell-tabs");

		public TabPartial(WebDriver driver) : base(driver) { }

		public bool TabExists(string name)
		{
			var result = _driver.FindElement(ThisBy).FindElements(ByMethod.CssSelector, "[ng-model=openTabs]").Find(x => x.FindElement(ByMethod.CssSelector, "a").Text == name);
			if (result != null)
			{
				return result.IsVisible;
			}
			return false;
		}

		public bool TabIsActive(string name)
		{
			var elements = _driver.FindElement(ThisBy).FindElements(ByMethod.CssSelector, "[ng-model=openTabs] a");
			var result = elements.Find(x => x.Text == name.ToUpper());
			return result.GetAttribute("ng-class").Contains("active");
		}
	}
}

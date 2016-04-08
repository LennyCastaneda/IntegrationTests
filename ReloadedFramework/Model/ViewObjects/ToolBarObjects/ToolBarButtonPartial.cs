using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;
using System;
using System.Linq;

namespace ReloadedFramework.Model.ViewObjects.ToolBarObjects
{
	/// <summary>
	/// Object representing a basic DropDown menu.
	/// </summary>
	public class ToolBarButtonPartial : Driver
	{
		private FindBy ThisBy;

		public ToolBarButtonPartial(WebDriver driver, FindBy findBy) : base(driver)
		{
			ThisBy = findBy;
		}

		public ToolBarButtonPartial Click()
		{
			_driver.FindElement(ThisBy).Click();
			return this;
		}

		public bool IsVisible
		{
			get
			{
				return _driver.FindElement(ThisBy).IsVisible;
			}
		}

		public bool DropDownIsVisible
		{
			get
			{
				return _driver.FindElement(ThisBy).FindElement(ByMethod.XPath, "../..").GetAttribute("class").Contains("open");
			}
		}

		public ToolBarButtonPartial ClickItem(string name)
		{
			var result = _driver.FindElement(ThisBy)
				.FindElement(ByMethod.XPath, "../..")
				.FindElements(ByMethod.CssSelector, "ul li")
				.FindAll(x => x.FindElements(ByMethod.CssSelector, "a").Count() > 0)
				.Find(x => x.Text.StartsWith(name, StringComparison.OrdinalIgnoreCase));

			if (result != null && result.IsVisible)
			{
				result.Click();
			}
			return this;
		}
	}
}

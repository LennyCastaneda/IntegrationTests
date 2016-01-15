using ReloadedFramework.Model.AbstractClasses;
using ReloadedFramework.Model.ViewObjects.ToolBarObjects;
using ReloadedFramework.Model.ViewObjects.ViewTypes;
using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadedFramework.Model.ViewObjects
{
	public class ViewPartial : Driver
	{
		private FindBy ViewBy = new FindBy(ByMethod.CssSelector, "#tab_holder");

		public ViewPartial(WebDriver driver) : base(driver) { }

		public ToolBarPartial ToolBar
		{
			get
			{
				return new ToolBarPartial(_driver);
			}
		}

		public TabPartial Tabs
		{
			get
			{
				return new TabPartial(_driver);
			}
		}

		public HomePartial Home
		{
			get
			{
				return new HomePartial(_driver);
			}
		}

		public bool Loading()
		{
			var loaded = _driver.FindElement(new FindBy(ByMethod.CssSelector, "#md-loading-bar")).GetCssValue("display") == "none";
			return !loaded;
		}
	}
}

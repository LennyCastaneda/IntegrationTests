﻿using ReloadedFramework.Model.AbstractClasses;
using ReloadedFramework.Model.ViewObjects.ToolBarObjects;
using ReloadedFramework.Model.ViewObjects.ViewTypes;
using ReloadedFramework.Model.ViewObjects.ViewTypes.Home;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects
{
	public class ViewPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#tab_holder");
		private FindBy ActiveViewBy = new FindBy(ByMethod.CssSelector, "#tab_holder .persistant_tab[style*='block']");

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

		public GridViewPartial GridView
		{
			get
			{
				return new GridViewPartial(_driver);
			}
		}

		public ItemViewPartial ItemView
		{
			get
			{
				return new ItemViewPartial(_driver);
			}
		}

		public bool Loading
		{
			get
			{
				return !(_driver.FindElement(new FindBy(ByMethod.CssSelector, "#md-loading-bar")).GetCssValue("display") == "none");
			}
		}

		public PaginationPartial Paginator
		{
			get
			{
				return new PaginationPartial(_driver, ActiveViewBy);
			}
		}
	}
}

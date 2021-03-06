﻿using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects
{
	public class PaginationPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, ".pagination-controls");
		private FindBy DropDownBy = new FindBy(ByMethod.CssSelector, "#durell-paginator-itemselect");

		public PaginationPartial(WebDriver driver) : base(driver) { }

		/// <summary>
		/// For use where there is more than one paginator on the page at the same time.
		/// </summary>
		/// <param name="driver"></param>
		/// <param name="parentBy"></param>
		public PaginationPartial(WebDriver driver, FindBy parentBy) : base(driver)
		{
			ThisBy = new FindBy(ThisBy.Method, parentBy.Selector + " " + ThisBy.Selector);
		}

		public PaginationPartial SelectItemsPerPage(string value)
		{
			var dropDown = _driver.FindElement(ThisBy).FindElement(DropDownBy);
			dropDown.MoveToElement(_driver);
			dropDown.Click();
			dropDown.FindElement(ByMethod.CssSelector, "option[label='" + value + "']").Click();
			return this;
		}

		public PaginationPartial NextPage()
		{
			_driver.FindElement(ThisBy).FindElement(ByMethod.CssSelector, ".next-page").Click();
			return this;
		}

		public PaginationPartial PreviousPage()
		{
			_driver.FindElement(ThisBy).FindElement(ByMethod.CssSelector, ".previous-page").Click();
			return this;
		}

		public string PageStatus
		{
			get
			{
				return _driver.FindElement(ThisBy).FindElement(ByMethod.CssSelector, ".status").Text;
			}
		}
	}
}

using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects
{
	public static class Paginator
	{
		private static FindBy PaginatorBy = new FindBy(ByMethod.CssSelector, "durell-paginator");
		private static WebElement GetPaginator(WebDriver _driver)
		{
			return _driver.FindElement(PaginatorBy);
		}

		public static void SelectItemsPerPage(WebDriver _driver, string value)
		{
			GetPaginator(_driver).FindElement(ByMethod.CssSelector, "#durell-paginator-itemselect").Click();
			GetPaginator(_driver).FindElement(ByMethod.CssSelector, "#durell-paginator-itemselect option[label='" + value + "']").Click();
		}

		public static void SelectNextPage(WebDriver _driver)
		{
			GetPaginator(_driver).FindElement(ByMethod.CssSelector, ".next-page").Click();
		}

		public static void SelectPreviousPage(WebDriver _driver)
		{
			GetPaginator(_driver).FindElement(ByMethod.CssSelector, ".previous-page").Click();
		}

		public static string GetPageStatus(WebDriver _driver)
		{
			return GetPaginator(_driver).FindElement(ByMethod.CssSelector, ".status").Text;
		}
	}
}

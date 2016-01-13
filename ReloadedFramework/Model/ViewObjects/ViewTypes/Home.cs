using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadedFramework.Model.ViewObjects.ViewTypes
{
	public static class Home
	{
		private static FindBy SystemMessagesBy = new FindBy(ByMethod.CssSelector, "[id^='tabController'] > div:nth-child(1)");

		public static WebElement SystemMessages(WebDriver _driver)
		{
			return _driver.FindElement(SystemMessagesBy);
		}

		private static FindBy NewsFeedBy = new FindBy(ByMethod.CssSelector, "[id^='tabController'] > div:nth-child(2)");

		public static WebElement NewsFeed(WebDriver _driver)
		{
			return _driver.FindElement(NewsFeedBy);
		}
	}

	public static class Feed
	{
		public static void ClickMessage(WebElement feed, int index)
		{
			feed.FindElements(ByMethod.CssSelector, ".list-group > div:not(.list-group-separator)")[index].Click();
		}

		public static bool MessageExpanded(WebElement feed, int index)
		{
			var item = feed.FindElements(ByMethod.CssSelector, ".list-group > div:not(.list-group-separator)")[index];
			return item.GetAttribute("class").Contains("expanded-view");
		}

		public static void ClickOptions(WebElement feed)
		{
			feed.FindElement(ByMethod.CssSelector, ".toolbar-buttons > .btn-group").Click();
		}

		public static void SelectOption(WebElement feed, string option)
		{
			var menuOptions = feed.FindElements(ByMethod.CssSelector, ".toolbar-buttons > .btn-group ul li");
			menuOptions.ForEach(x => {
				x.FindElement(ByMethod.CssSelector, "a");
				if(x.Text == option)
				{
					x.Click();
				}
			});
		}
	}
}

using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects.ViewTypes
{
	public class HomePartial : Driver
	{
		public HomePartial(WebDriver driver) : base(driver) { }

		public NewsFeedPartial NewsFeed
		{
			get
			{
				return new NewsFeedPartial(_driver);
			}
		}

		public SystemMessagesPartial SystemMessages
		{
			get
			{
				return new SystemMessagesPartial(_driver);
			}
		}
	}

	public class SystemMessagesPartial : Driver
	{
		protected FindBy ThisBy;

		public SystemMessagesPartial(WebDriver driver) : base(driver) {
			ThisBy = new FindBy(ByMethod.CssSelector, "[id^='tabController'] > div:nth-child(1)");
		}

		public bool IsVisible
		{
			get
			{
				return _driver.FindElement(ThisBy).IsVisible;
			}
		}

		public SystemMessagesPartial ClickMessage(int index)
		{
			_driver.FindElement(ThisBy).FindElements(ByMethod.CssSelector, ".list-group > div:not(.list-group-separator)")[index].Click();
			return this;
		}

		public bool MessageExpanded(int index)
		{
			var item = _driver.FindElement(ThisBy).FindElements(ByMethod.CssSelector, ".list-group > div:not(.list-group-separator)")[index];
			return item.GetAttribute("class").Contains("expanded-view");
		}
	}

	public class NewsFeedPartial : SystemMessagesPartial
	{
		public NewsFeedPartial(WebDriver driver) : base(driver) {
			ThisBy = new FindBy(ByMethod.CssSelector, "[id^='tabController'] > div:nth-child(2)");
		}

		public NewsFeedPartial ClickOptions()
		{
			_driver.FindElement(ThisBy).FindElement(ByMethod.CssSelector, ".toolbar-buttons > .btn-group").Click();
			return this;
		}

		public NewsFeedPartial SelectOption(string option)
		{
			var menuOptions = _driver.FindElement(ThisBy).FindElements(ByMethod.CssSelector, ".toolbar-buttons > .btn-group ul li");
			menuOptions.Find(x => x.FindElement(ByMethod.CssSelector, "a").Text == option).Click();
			return this;
		}
	}
}

using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects.ViewTypes.Home
{
	public class NewsFeedPartial : SystemMessagesPartial
	{
		public NewsFeedPartial(WebDriver driver) : base(driver)
		{
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

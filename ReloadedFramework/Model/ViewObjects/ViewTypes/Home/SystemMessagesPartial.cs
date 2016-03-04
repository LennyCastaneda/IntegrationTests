using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects.ViewTypes.Home
{
	public class SystemMessagesPartial : Driver
	{
		protected FindBy ThisBy;

		public SystemMessagesPartial(WebDriver driver) : base(driver)
		{
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
}

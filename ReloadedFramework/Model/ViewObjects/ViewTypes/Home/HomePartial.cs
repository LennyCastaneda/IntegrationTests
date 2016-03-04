using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects.ViewTypes.Home
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
}

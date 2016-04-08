using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.PageObjects
{
	public class Alert : Driver
	{
		public Alert(WebDriver driver) : base(driver) { }

		public bool IsVisible
		{
			get
			{
				return _driver.AlertIsVisible;
			}
		}

		public Alert SendKeys(string text)
		{
			_driver.AlertSendKeys(text);
			return this;
		}

		public Alert Accept()
		{
			_driver.AlertAccept();
			return this;
		}

		public Alert Dismiss()
		{
			_driver.AlertDismiss();
			return this;
		}
	}
}

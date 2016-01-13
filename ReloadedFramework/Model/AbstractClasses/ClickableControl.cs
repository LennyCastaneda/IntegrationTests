using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.AbstractClasses
{
	public abstract class ClickableControl : Control
	{
		public ClickableControl(WebDriver driver, WebElement element, string name) : base(driver, name)
		{
			_element = element;
		}

		public abstract void Click();
	}
}
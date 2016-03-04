using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.AbstractClasses
{
	public abstract class Partial : Driver
	{
		protected FindBy ThisBy;

		public Partial(WebDriver driver) : base(driver) { }

		public WebElement This
		{
			get
			{
				return _driver.FindElement(ThisBy);
			}
		}
	}
}

using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.AbstractClasses
{
	public abstract class Partial : Driver
	{
		protected FindBy ThisBy;

		public Partial(WebDriver driver, FindBy thisby) : base(driver)
		{
			ThisBy = thisby;
		}

		public WebElement ThisPartial
		{
			get
			{
				return _driver.FindElement(ThisBy);
			}
		}

		/// <summary>
		/// Returns true if the Partial is visible to the user.
		/// </summary>
		public bool IsVisible
		{
			get
			{
				if (ThisPartial != null)
				{
					return ThisPartial.IsVisible;
				}
				return false;
			}
		}
	}
}

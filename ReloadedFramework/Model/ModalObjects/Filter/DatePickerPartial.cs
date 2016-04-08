using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	public class DatePickerPartial : Driver
	{
		private FindBy ThisBy = new FindBy(".ui-datepicker");
		private FindBy IsVisibleBy = new FindBy(".ui-datepicker[style*='display: block;']");
		private FindBy HeaderBy = new FindBy(".ui-datepicker-header");
		private FindBy BodyBy = new FindBy(".ui-datepicker-calendar");
		private FindBy NextBy = new FindBy(".ui-datepicker-next");
		private FindBy PreviousBy = new FindBy(".ui-datepicker-previous");
		private FindBy DatesBy = new FindBy(".ui-state-default");

		/// <summary>
		/// Exposes methods to control the JQuery datepicker.
		/// <remarks>Assumes there is only one on the page.</remarks>
		/// </summary>
		public DatePickerPartial(WebDriver driver) : base(driver){ }

		/// <summary>
		/// Returns true if the Partial is visible to the user.
		/// </summary>
		public bool IsVisible
		{
			get
			{
				var result = _driver.FindElement(IsVisibleBy);
				if (result != null)
				{
					return result.IsVisible;
				}
				return false;
			}
		}

		private WebElement Header
		{
			get
			{
				return _driver.FindElement(ThisBy)
					.FindElement(HeaderBy);
			}
		}

		private WebElement Body
		{
			get
			{
				return _driver.FindElement(ThisBy)
					.FindElement(BodyBy);
			}
		}

		public DatePickerPartial NextMonth()
		{
			Header.FindElement(NextBy).Click();
			return this;
		}

		public DatePickerPartial PreviousMonth()
		{
			Header.FindElement(PreviousBy).Click();
			return this;
		}

		public DatePickerPartial SelectDate(int date)
		{
			Body.FindElements(DatesBy)
				.Find(x => StringCompare(x.Text, date.ToString()))
				.Click();
			return this;
		}
	}
}

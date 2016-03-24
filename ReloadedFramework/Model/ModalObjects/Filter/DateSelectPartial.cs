using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	/// <summary>
	/// Provides a date range selector. Choose from Between DateTimes, or in a range between Timespans.
	/// </summary>
	public class DateSelectPartial : Driver
	{
		private FindBy ThisBy = new FindBy("multi-dropdown-option-menu.date-options.visible");
		private FindBy BetweenBy = new FindBy(".date-option-between");
		private FindBy BetweenRadioBy = new FindBy("input[value='between']");
		private FindBy RangeBy = new FindBy(".date-option-range");
		private FindBy RangeRadioBy = new FindBy("input[value='range']");
		private FindBy SelectorsBy = new FindBy("input[type='text']");

		public DateSelectPartial(WebDriver driver) : base(driver){}

		/// <summary>
		/// Click the 'Between' radio button.
		/// </summary>
		/// <returns></returns>
		public DateSelectPartial Between()
		{
			_driver.FindElement(ThisBy)
				.FindElement(BetweenRadioBy)
				.Click();
			return this;
		}

		/// <summary>
		/// Click the 'In range' radio button.
		/// </summary>
		/// <returns></returns>
		public DateSelectPartial InRange()
		{
			_driver.FindElement(ThisBy)
				.FindElement(RangeRadioBy)
				.Click();
			return this;
		}

		private DateSelectPartial SendKeysToField(FindBy typeBy, int index, string input)
		{
			var element = _driver.FindElement(ThisBy)
								.FindElement(typeBy)
								.FindElements(SelectorsBy)[index];
			element.Click();
			element.Clear();
			element.SendKeys(input);
			return this;
		}

		public DateSelectPartial BetweenStartDate(string startdate)
		{
			return SendKeysToField(BetweenBy, 0, startdate);
		}

		public DateSelectPartial BetweenEndDate(string enddate)
		{
			return SendKeysToField(BetweenBy, 1, enddate);
		}

		public DateSelectPartial InRangeStartSpan(string startspan)
		{
			return SendKeysToField(RangeBy, 1, startspan);
		}

		public DateSelectPartial InRangeEndSpan(string endspan)
		{
			return SendKeysToField(RangeBy, 1, endspan);
		}
	}
}
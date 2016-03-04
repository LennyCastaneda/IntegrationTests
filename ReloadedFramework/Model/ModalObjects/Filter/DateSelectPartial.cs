using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	public class DateSelectPartial : Driver
	{
		private FindBy ThisBy;

		public DateSelectPartial(WebDriver driver, FindBy thisBy) : base(driver)
		{
			ThisBy = thisBy;
		}

		public DateSelectPartial Between()
		{
			return this;
		}

		public DateSelectPartial InRange()
		{
			return this;
		}

		public DateSelectPartial BetweenStartDate(string startdate)
		{
			return this;
		}

		public DateSelectPartial BetweenEndDate(string enddate)
		{
			return this;
		}

		public DateSelectPartial InRangeStartSpan(string startspan)
		{
			return this;
		}

		public DateSelectPartial InRangeEndSpan(string endspan)
		{
			return this;
		}
	}
}
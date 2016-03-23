using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class ThemePickerPartial : Modal
	{
		FindBy ColoursBy = new FindBy(ByMethod.CssSelector, ".theme .name");

		public ThemePickerPartial(WebDriver driver) : base(driver) { }

		/// <summary>
		/// Clicks 'Cancel'.
		/// </summary>
		/// <returns></returns>
		public ThemePickerPartial Cancel()
		{
			FindButton("Cancel").Click();
			return this;
		}

		/// <summary>
		/// Clicks 'Apply to View'.
		/// </summary>
		/// <returns></returns>
		public ThemePickerPartial ApplyToView()
		{
			FindButton("Apply to View").Click(500);
			return this;
		}

		/// <summary>
		/// Clicks 'Apply to Configuration'.
		/// </summary>
		/// <returns></returns>
		public ThemePickerPartial ApplyToConfiguration()
		{
			FindButton("Apply to Configuration").Click(500);
			return this;
		}

		/// <summary>
		/// Clicks the colour specified.
		/// </summary>
		/// <param name="colour"></param>
		/// <returns></returns>
		public ThemePickerPartial Colour(string colour)
		{
			Body.FindElements(ColoursBy).Find(x => StringCompare(x.Text, colour)).Click();
			return this;
		}
	}
}

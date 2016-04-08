using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class GroupPickerPartial : Modal
	{
		FindBy DropDownBy = new FindBy(ByMethod.CssSelector, ".input-holder");
		FindBy DatesBy = new FindBy(ByMethod.CssSelector, "date-options .radio label");

		public GroupPickerPartial(WebDriver driver) : base(driver) { }

		/// <summary>
		/// Clicks the 'Apply' button.
		/// </summary>
		/// <returns></returns>
		public GroupPickerPartial Apply()
		{
			FindButton("apply").Click();
			return this;
		}

		/// <summary>
		/// Clicks the 'Cancel' button.
		/// </summary>
		/// <returns></returns>
		public GroupPickerPartial Cancel()
		{
			FindButton("cancel").Click();
			return this;
		}

		/// <summary>
		/// Clicks the named date radio button.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public GroupPickerPartial GroupDatesBy(string name)
		{
			Body.FindElements(DatesBy)
				.Find(x => StringCompare(x.Text, name))
				.Click();
			return this;
		}

		/// <summary>
		/// Clicks the dropdown control.
		/// </summary>
		/// <returns></returns>
		public GroupPickerPartial DropDown()
		{
			Body.FindElement(DropDownBy).Click();
			return this;
		}

		/// <summary>
		/// Clicks one of the dropdown options.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public GroupPickerPartial DropDownOption(string name)
		{
			var element = Body.FindElement(DropDownBy)
				.FindElements(ByMethod.CssSelector, "span")
				.Find(x => StringCompare(x.FindElement(ByMethod.CssSelector, "label").GetNodeText, name));
			if (element != null)
			{
				element.Click();
			}
			else
			{
				Header.Click();
			}
			return this;
		}
	}
}

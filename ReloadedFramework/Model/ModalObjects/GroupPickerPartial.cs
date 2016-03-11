using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class GroupPickerPartial : Driver
	{
		FindBy IsOpenBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-content");
		FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-dialog[ng-controller^='GridGroupsController'] .modal-content");
		FindBy DropDownBy = new FindBy(ByMethod.CssSelector, ".modal-body select");
		FindBy ButtonsBy = new FindBy(ByMethod.CssSelector, ".modal-footer button");
		FindBy DatesBy = new FindBy(ByMethod.CssSelector, ".modal-body .radio");
		FindBy CloseBy = new FindBy(ByMethod.CssSelector, ".modal-header button.close");

		public GroupPickerPartial(WebDriver driver) : base(driver) { }

		/// <summary>
		/// Returns true if the Partial is visible to the user.
		/// </summary>
		public bool IsVisible
		{
			get
			{
				var result = _driver.FindElement(ThisBy);
				if (result != null && _driver.FindElement(IsOpenBy) != null)
				{
					return result.IsVisible;
				}
				return false;
			}
		}

		/// <summary>
		/// Clicks the 'Apply' button.
		/// </summary>
		/// <returns></returns>
		public GroupPickerPartial Apply()
		{
			_driver.FindElement(ThisBy)
				.FindElements(ButtonsBy)
				.Find(x => x.Text.Trim().ToLower() == "apply").Click();
			return this;
		}

		/// <summary>
		/// Clicks the 'Cancel' button.
		/// </summary>
		/// <returns></returns>
		public GroupPickerPartial Cancel()
		{
			_driver.FindElement(ThisBy)
				.FindElements(ButtonsBy)
				.Find(x => x.Text == "Cancel").Click();
			return this;
		}

		/// <summary>
		/// Clicks the 'X' button to close.
		/// </summary>
		/// <returns></returns>
		public GroupPickerPartial Close()
		{
			_driver.FindElement(ThisBy)
				.FindElement(CloseBy)
				.Click();
			return this;
		}

		public GroupPickerPartial GroupDatesBy(string name)
		{
			_driver.FindElement(ThisBy)
				.FindElements(DatesBy)
				.Find(x => x.FindElement(ByMethod.CssSelector, ".radio label").Text.Trim().ToLower() == name.ToLower())
				.Click();
			return this;
		}

		/// <summary>
		/// Clicks the dropdown control.
		/// </summary>
		/// <returns></returns>
		public GroupPickerPartial DropDown()
		{
			_driver.FindElement(ThisBy)
				.FindElement(DropDownBy)
				.Click();
			return this;
		}

		/// <summary>
		/// Clicks one of the dropdown options.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public GroupPickerPartial DropDownOption(string name)
		{
			_driver.FindElement(ThisBy)
				.FindElement(DropDownBy)
				.FindElement(ByMethod.CssSelector, "option[label = '" + name + "']")
				.Click();
			return this;
		}
	}
}

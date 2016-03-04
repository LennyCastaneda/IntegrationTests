using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class GroupPickerPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-content");

		public GroupPickerPartial(WebDriver driver) : base(driver) { }
	}
}

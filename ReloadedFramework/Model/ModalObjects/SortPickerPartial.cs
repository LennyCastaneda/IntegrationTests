using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class SortPickerPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-content");

		public SortPickerPartial(WebDriver driver) : base(driver) { }
	}
}

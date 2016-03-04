using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class SaveAsPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-content");

		public SaveAsPartial(WebDriver driver) : base(driver) { }
	}
}

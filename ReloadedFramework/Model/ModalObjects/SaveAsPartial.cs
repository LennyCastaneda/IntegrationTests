using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class SaveAsPartial : Modal
	{
		FindBy NameAs = new FindBy(ByMethod.CssSelector, "div input");

		public SaveAsPartial(WebDriver driver) : base(driver) { }

		public SaveAsPartial EnterName(string name)
		{
			Body.FindElement(NameAs).Clear();
			Body.FindElement(NameAs).SendKeys(name);
			return this;
		}
	}
}

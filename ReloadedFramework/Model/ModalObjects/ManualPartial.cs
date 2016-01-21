using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects
{
	public class ManualPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#ngBody > div.manual-container.ui-draggable");
		private FindBy ThisBy1 = new FindBy(ByMethod.CssSelector, "#ngBody > div.manual-container.ui-draggable.expanded");

		public ManualPartial(WebDriver driver) : base(driver) { }

		public bool IsOpen()
		{
			if(_driver.FindElement(ThisBy).GetAttribute("style").Contains("display: none;") && _driver.FindElement(ThisBy).IsVisible)
			{
				return false;
			}
			return true;
		}

		public ManualPartial Back()
		{
			_driver.FindElement(ThisBy).FindElement(ByMethod.CssSelector, "div > a.back").Click();
			return this;
		}

		public ManualPartial Close()
		{
			_driver.FindElement(ThisBy).FindElement(ByMethod.CssSelector, "div > a.close-manual").Click();
			return this;
		}
	}
}

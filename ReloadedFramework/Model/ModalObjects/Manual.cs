using ReloadedInterface.Interfaces;
using System;

namespace ReloadedFramework.Model.ModalObjects
{
	public class Manual : Modal
	{
		public Manual(WebDriver driver, string name) : base(driver, name) { }

		private bool GetElement()
		{
			_element = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div.manual-container.ui-draggable");

			if (_element == null)
			{
				_element = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div.manual-container.ui-draggable.expanded");
			}

			return _element != null;
		}

		public override bool IsOpen()
		{
			if (_element == null && !GetElement())
			{
				return false;
			}
			if (_element.GetAttribute("style").Contains("display: none;"))
			{
				return false;
			}
			return true;
		}

		public void Back()
		{
			if (_element == null) { GetElement(); }
			if (IsOpen())
			{
				_element.FindElement(ByMethod.CssSelector, "div > a.back").Click();
			}
		}

		public override void Close()
		{
			if (_element == null) { GetElement(); }
			if (IsOpen())
			{
				_element.FindElement(ByMethod.CssSelector, "div > a.close-manual").Click();
			}
		}
	}
}

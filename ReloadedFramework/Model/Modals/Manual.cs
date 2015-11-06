using ReloadedInterface.Interfaces;
using System;

namespace ReloadedFramework.Model
{
	public class Manual : Modal
	{
		public Manual(WebDriver driver, string name) : base(driver, name) { }

		private bool GetElement()
		{
			bool exists = _driver.ElementExists(() =>
			{
				_element = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div.manual-container.ui-draggable.expanded");
			});

			if (!exists)
			{
				exists = _driver.ElementExists(() =>
				{
					_element = _driver.FindElement(ByMethod.CssSelector, "#ngBody > div.manual-container.ui-draggable");
				});
			}
			return exists;
		}

		public override bool IsOpen()
		{
			return _driver.ElementExists(() =>
			{
				if (_element == null && !GetElement())
				{
					throw new Exception("Not Found");
				}
				if(_element.GetAttribute("style").Contains("display: none;"))
				{
					throw new Exception("Element not visible");
				}
            });
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

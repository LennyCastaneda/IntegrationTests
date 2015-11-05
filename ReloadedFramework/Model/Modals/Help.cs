using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadedFramework.Model.Modals
{
	public class Help : ClickableControl
	{
		public Help(WebDriver driver, WebElement element, string name) : base(driver, element, name) {
			_element = element;
		}

		public override void Click()
		{
			_element.Click();
		}
	}
}

using System;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.Modals
{
	public class Modal : Control
	{
		public Modal(WebDriver driver, string name) : base(driver, name) { }
	}
}
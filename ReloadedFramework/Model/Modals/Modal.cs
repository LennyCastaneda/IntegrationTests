using System;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public abstract class Modal : Control
	{
		public Modal(WebDriver driver, string name) : base(driver, name) { }

		public abstract bool IsOpen();

		public abstract void Close();
	}
}
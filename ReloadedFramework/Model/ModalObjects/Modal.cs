using System;
using ReloadedInterface.Interfaces;
using ReloadedFramework.Model.AbstractClasses;

namespace ReloadedFramework.Model.ModalObjects
{
	public abstract class Modal : Control
	{
		public Modal(WebDriver driver, string name) : base(driver, name) { }

		public abstract bool IsOpen();

		public abstract void Close();
	}
}
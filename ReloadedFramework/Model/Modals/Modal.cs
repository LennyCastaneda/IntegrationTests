using System;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class Modal : Control
	{
		public Modal(ref WebDriver driver, string name) : base(ref driver, name) { }
	}
}
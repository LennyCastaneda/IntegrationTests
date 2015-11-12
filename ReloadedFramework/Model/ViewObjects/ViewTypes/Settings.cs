using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadedFramework.Model.ViewObjects.ViewTypes
{
	public class Settings : Control
	{
		public Settings(WebDriver driver, string name) : base(driver, name)
		{

		}

		public bool IsActive()
		{
			return true;
		}

	}
}

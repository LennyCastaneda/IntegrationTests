using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadedFramework.Model.ViewObjects.ViewTypes
{
	public class Home : Control
	{
		public Home(WebDriver driver, string name) : base(driver, name)
		{

		}

		public bool IsActive()
		{

			return true;
		}

	}
}

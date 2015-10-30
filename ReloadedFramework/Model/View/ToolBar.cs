using ReloadedInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadedFramework.Model
{
	class ToolBar : Control
	{
		public ToolBar(ref WebDriver driver, string name) : base(ref driver, name) { }
	}
}

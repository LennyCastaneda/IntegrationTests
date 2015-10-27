using System;
using ReloadedInterface.Interfaces;
using System.Collections.Generic;

namespace ReloadedFramework.Model
{
	public class Tabs : SubController<Tab>
	{
		public Tabs(ref WebDriver driver) : base(ref driver) { }

		public override void GetSubItems()
		{
			throw new NotImplementedException();
		}
	}

	public class Tab : Control
	{
		public Tab(ref WebDriver driver) : base(ref driver) { }
	}
}

using ReloadedFramework.Model;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class View : Control
	{
		public Tabs Tabs { get; private set; }

		public View(ref WebDriver driver) : base(ref driver) { }
	}
}

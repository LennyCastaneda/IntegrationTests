using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class Tab : ClickableControl
	{
		public Tab(ref WebDriver driver, string name) : base(ref driver, name) { }

		public bool Active
		{
			get
			{
				return _element.GetAttribute("class").Contains("active");
			}
		}

		public override void Click()
		{
			_element.Click();
		}
	}
}

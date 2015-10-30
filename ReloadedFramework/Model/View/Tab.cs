using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class Tab : ClickableControl
	{
		public Tab(ref WebDriver driver) : base(ref driver) { }

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

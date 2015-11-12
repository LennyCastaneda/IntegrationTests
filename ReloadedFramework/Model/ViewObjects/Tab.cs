using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects
{
	public class Tab : ClickableControl
	{
		View _view;

		public Tab(WebDriver driver, WebElement element, string name, View view) : base(driver, element, name)
		{
			_view = view;
		}

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
			_view.SetActiveTab(this);
		}
    }
}

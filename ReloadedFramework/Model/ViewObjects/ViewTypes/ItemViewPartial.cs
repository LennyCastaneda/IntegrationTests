using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ViewObjects.ViewTypes
{
	public class ItemViewPartial : Driver
	{
		FindBy ThisBy = new FindBy(ByMethod.CssSelector, ".persistant_tab[style*='block'] div[ng-controller^='itemviewController']");

		public ItemViewPartial(WebDriver driver) : base(driver) { }

		/// <summary>
		/// Returns true if the ItemView is the active Tab.
		/// </summary>
		public bool IsVisible
		{
			get
			{
				return _driver.FindElement(ThisBy).IsVisible;
			}
		}
	}
}

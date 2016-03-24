using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	/// <summary>
	/// Provides four options: StartWith, EndsWith, Equals and Contains.
	/// </summary>
	/// <param name="driver"></param>
	/// <param name="findBy"></param>
	public class StringSelectPartial : Driver
	{
		private FindBy ThisBy = new FindBy(ByMethod.CssSelector, ".multi-dropdown-option-menu.date-options.visible");
		private FindBy StartsWithBy = new FindBy(ByMethod.CssSelector, ".text-option-sw");
		private FindBy EndsWithBy = new FindBy(ByMethod.CssSelector, ".text-option-ew");
		private FindBy ContainsBy = new FindBy(ByMethod.CssSelector, ".text-option-co");
		private FindBy EqualsBy = new FindBy(ByMethod.CssSelector, ".text-option-eq");
		private FindBy RadioBy = new FindBy(ByMethod.CssSelector, "input[type='radio']");
		private FindBy InputBy = new FindBy(ByMethod.CssSelector, "input[type='text']");

		public StringSelectPartial(WebDriver driver) : base(driver){}

		private void SelectInput(FindBy findBy, string input)
		{
			var element = _driver.FindElement(ThisBy).FindElement(findBy);
			element.FindElement(RadioBy).FindElement(ByMethod.XPath, "..").Click();
			element.FindElement(InputBy).Clear();
			element.FindElement(InputBy).SendKeys(input);
		}

		public StringSelectPartial StartsWith(string input)
		{
			SelectInput(StartsWithBy, input);
			return this;
		}

		public StringSelectPartial EndsWith(string input)
		{
			SelectInput(EndsWithBy, input);
			return this;
		}

		public StringSelectPartial Contains(string input)
		{
			SelectInput(ContainsBy, input);
			return this;
		}

		public StringSelectPartial Equals(string input)
		{
			SelectInput(EqualsBy, input);
			return this;
		}
	}
}

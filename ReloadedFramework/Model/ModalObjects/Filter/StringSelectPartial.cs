using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.ModalObjects.Filter
{
	public class StringSelectPartial : Driver
	{
		private FindBy ThisBy;
		private FindBy StartsWithBy = new FindBy(ByMethod.CssSelector, ".text-option-sw");
		private FindBy EndsWithBy = new FindBy(ByMethod.CssSelector, ".text-option-ew");
		private FindBy ContainsBy = new FindBy(ByMethod.CssSelector, ".text-option-co");
		private FindBy EqualsBy = new FindBy(ByMethod.CssSelector, ".text-option-eq");
		private FindBy RadioBy = new FindBy(ByMethod.CssSelector, "input[type='radio']");
		private FindBy InputBy = new FindBy(ByMethod.CssSelector, "input[type='text']");

		public StringSelectPartial(WebDriver driver, FindBy findBy) : base(driver)
		{
			ThisBy = findBy;
		}

		private void SelectInput(FindBy findBy, string input)
		{
			var element = _driver.FindElement(ThisBy).FindElement(findBy);
			element.FindElement(RadioBy).Click();
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

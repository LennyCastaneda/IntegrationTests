using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model.AbstractClasses
{
	public abstract class Modal : Driver
	{
		protected FindBy ThisBy = new FindBy(ByMethod.CssSelector, "#myModal .modal-content");
		protected FindBy HeaderBy = new FindBy(ByMethod.CssSelector, ".modal-header");
		protected FindBy BodyBy = new FindBy(ByMethod.CssSelector, ".modal-body");
		protected FindBy FooterBy = new FindBy(ByMethod.CssSelector, ".modal-footer");
		protected FindBy CloseBy = new FindBy(ByMethod.CssSelector, ".close");
		protected FindBy HeaderTextBy = new FindBy(ByMethod.CssSelector, "#myModalLabel");

		public Modal(WebDriver driver) : base(driver) { }

		/// <summary>
		/// Returns true if the Partial is visible to the user.
		/// </summary>
		public bool IsVisible
		{
			get
			{
				var result = _driver.FindElement(ThisBy);
				if (result != null)
				{
					return result.IsVisible;
				}
				return false;
			}
		}

		/// <summary>
		/// Returns the string shown as the header of the modal form.
		/// </summary>
		/// <returns></returns>
		public string HeaderText
		{
			get
			{
				return Header.FindElement(HeaderTextBy).Text.Trim() ?? "";
			}
		}

		/// <summary>
		/// Returns the first button in the Modal footer with the text 'name'.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		protected WebElement FindButton(string name)
		{
			return Footer.FindElements(ByMethod.CssSelector, "button")
				.Find(x => StringCompare(x.Text, name));
		}

		/// <summary>
		/// Returns the containing div of the Modal dialog.
		/// </summary>
		protected WebElement ModalContainer
		{
			get
			{
				return _driver.FindElement(ThisBy);
			}
		}

		/// <summary>
		/// Returns the Modal header.
		/// </summary>
		protected WebElement Header
		{
			get
			{
				return ModalContainer.FindElement(HeaderBy);
			}
		}

		/// <summary>
		/// Returns the Modal body.
		/// </summary>
		protected WebElement Body
		{
			get
			{
				return ModalContainer.FindElement(BodyBy);
			}
		}

		/// <summary>
		/// Returns the Modal footer.
		/// </summary>
		protected WebElement Footer
		{
			get
			{
				return ModalContainer.FindElement(FooterBy);
			}
		}

		/// <summary>
		/// Closes the Modal using the 'x' button in the top right corner.
		/// </summary>
		public void Close()
		{
			Header.FindElement(CloseBy).Click();
		}
	}
}

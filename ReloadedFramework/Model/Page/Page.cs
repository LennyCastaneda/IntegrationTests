using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class Page : Driver
	{
		public Page(ref WebDriver driver) : base(ref driver) { }

		public string Title
		{
			get
			{
				return _driver.Title;
			}
		}

		public string Url
		{
			get
			{
				return _driver.Url;
			}
		}

		public string PageSource
		{
			get
			{
				return _driver.PageSource;
			}
		}

		public void GoTo(string url)
		{
			_driver.Navigate(url);
		}

		public void ClosePage()
		{
			_driver.Close();
		}

		public void Quit()
		{
			_driver.Quit();
		}
	}
}

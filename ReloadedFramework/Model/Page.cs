using ReloadedInterface.Interfaces;

namespace ReloadedFramework.Model
{
	public class Page
	{
		private WebDriver _driver;

		public Page(ref WebDriver driver)
		{
			_driver = driver;
		}

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

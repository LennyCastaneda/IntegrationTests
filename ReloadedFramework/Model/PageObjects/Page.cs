using ReloadedFramework.Model.AbstractClasses;
using ReloadedInterface.Interfaces;
using System.Threading;

namespace ReloadedFramework.Model.PageObjects
{
	public class Page : Driver
	{
		public Page(WebDriver driver) : base(driver) { }

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

			if (url == "http://durell.co.uk:1024/#/config/1" || url == "http://localhost:52755/index.html#/config/1")
			{
				Common.ExplicitWait(() =>
				{
					_driver.FindElement(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar > div.container-fluid > div > a.reloaded-icon-button.btn.btn-flat");
					if(!_driver.FindElement(ByMethod.CssSelector, "#ngBody > div:nth-child(1) > nav.navbar-fixed-top.reloaded-nav-bar > durell-tabs > div > div > div > a.tab.ng-binding.ng-scope.locked.active").Displayed)
					{
						throw new System.Exception();
					}
				}, 5000);
			}
		}

		public void ClosePage()
		{
			_driver.Close();
		}

		public void Quit()
		{
			_driver.Quit();
		}

		/// <summary>
		/// Send a sequence of keystrokes to the browser.
		/// </summary>
		/// <param name="keys"></param>
		public void SendKeys(string keys)
		{
			_driver.SendKeys(keys);
		}

		public void Wait()
		{
			WebDriver.Wait();
        }

		public void RemoveDelay()
		{
			if (Title == "Reloaded")
			{
				_driver.RemoveAnimationDelay();
			}
		}
	}
}
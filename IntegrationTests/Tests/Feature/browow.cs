using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.Feature
{
	[Binding]
	class browow: Steps
	{
		[Given(@"Multiple browsers")]
		public void bowowos()
		{
			Table table = new Table("browser");
			table.AddRow(new string[] { "Chrome" });
			table.AddRow(new string[] { "Edge" });
			table.AddRow(new string[] { "Firefox" });
			Given(@"a specific browser '<browser>'");
        }
    }
}

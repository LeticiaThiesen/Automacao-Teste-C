
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProjetoTestesC.Suport
{
    [Binding]
    public class Hook
    {
        public static ChromeDriver _driver;

        [Before]
        public void startBrowser()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.AddArgument("--remote-allow-origins=*");

            _driver = new ChromeDriver(chromeOptions);
        }

        [After]
        public void Dispose()
        {
            if (_driver != null)
            {
                _driver.Dispose();
                _driver = null;
            }
        }
    }
}



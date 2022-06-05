using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium.Safari;
using System.Collections.Generic;
using System.Web;

namespace projektub
{
    public class Ob
    {

        private static ChromeOptions GetChromeOptions()
        {

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;


            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            return options;



        }
    }
}







using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFrameWork.Base
{
    public class Browser
    {
        private readonly DriverContext driverContext;

        public Browser(DriverContext driver)
        {
            driverContext = driver;
        }

        public BrowserType Type { get; set; }

    }

    public enum BrowserType
    {
        InternetExplorer,
        FireFox,
        Chrome
    }
}


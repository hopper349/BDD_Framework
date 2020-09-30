using AutoFrameWork.COnfig;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;

namespace AutoFrameWork.Base
{
    public class TestInitializationHook : Steps
    {

        private readonly ParallelConfig _parallelConfig;

        public TestInitializationHook(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }


        public void InitializeSettings()
        {
            //Set all the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Set Log
            // LogHelper.CreateLogFile();

            //Open Browser
           OpenBrowser(GetBrowserOption(Setting.BrowserType));

           // LogHelper.Write("Initialized framework");

        }

        private void OpenBrowser(DriverOptions driverOptions)
        {
            switch (driverOptions)
            {
                case InternetExplorerOptions internetExplorerOptions:
                    //ToDo: Set the Desired capabilities
                    driverOptions = new InternetExplorerOptions();
                    break;
                case FirefoxOptions firefoxOptions:
                    FirefoxOptions firefoxOption = new FirefoxOptions();
                    firefoxOption.AddAdditionalCapability(firefoxOption.BrowserName, "Firefox");
                   /* firefoxOptions.AddAdditionalCapability(CapabilityType.BrowserName, Setting.BrowserType);
                    firefoxOptions.AddAdditionalCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
                    firefoxOptions.BrowserExecutableLocation = @"C:\Program Files (x86)\firefoxDriver\geckodriver.exe";*/
                    break;
                case ChromeOptions chromeOptions:
                    ChromeOptions chromeOption = new ChromeOptions();
                    chromeOption.AddAdditionalCapability(driverOptions.BrowserName,"Chrome");
                    chromeOptions.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);
                    break;
            }

           _parallelConfig.Driver = new RemoteWebDriver(new Uri(Setting.AUT), driverOptions.ToCapabilities());

          

        }

        public virtual void NavigateSite()
        {
            //DriverContext.Browser.GoToUrl(Setting.AUT);
          //  LogHelper.Write("Opened the browser !!!");
        }


        public DriverOptions GetBrowserOption(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    return new InternetExplorerOptions();
                case BrowserType.FireFox:
                    return new FirefoxOptions();
                case BrowserType.Chrome:
                    return new ChromeOptions();
                default:
                    return new FirefoxOptions();
            }
        }
    }
}


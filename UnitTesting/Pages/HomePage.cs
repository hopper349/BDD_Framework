 using AutoFrameWork.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Pages
{/*
    class HomePage: BasePage
    {
        IWebDriver webDriver = null;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Manage Home')]/parent::button")]
        public IWebElement ManageAssociation { get; set; }


       [FindsBy(How = How.XPath, Using = "//div[contains(@id,'collapse3')]//div//ul//li")]
        public IList<IWebElement> MngeHmopt { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[contains(@mattooltip,'Add Service Request')]")]
        public IWebElement AddService { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Add Title')]")]
        public IWebElement AddTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='mat-select-trigger']//span[text()='Select Category']")]
        public IWebElement SlctCat { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'cdk-overlay-pane')]//div//span")]
        public IList<IWebElement> SlctCatopt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='mat-select-trigger']//span[text()='Select Sub Category']")]
        public IWebElement SubSlctCat { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='mat-select-trigger']//span[text()='Urgency Level']")]
        public IWebElement UrgLvl { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[contains(@class,'mat-input-element')]")]
        public IWebElement Desc { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@type,'submit')]")]
        public IWebElement Submit { get; set; }







        public void ClkManageAssociation() {
            ManageAssociation.Click();
         }

        public void Chooseoptions()
        {
            foreach (IWebElement tag in MngeHmopt)
            {
                System.Diagnostics.Debug.WriteLine("MngeHmopt value is : " + tag.Text);

                if (tag.Text.Equals("My Service Requests"))
                {

                    tag.Click();
                }
            }


        }

            public void AddTitle1()
            {
            AddTitle.SendKeys("Testing Application");
            }

       
        public void SlctCatopt1()
        {
            SlctCat.Click();
            foreach (IWebElement tag in SlctCatopt)
            {
                System.Diagnostics.Debug.WriteLine("SlctCatopt value is : " + tag.Text);
                System.Threading.Thread.Sleep(5000);
                if (tag.Text.Equals("Documents"))
                {
                    WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                    wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                    tag.Click();
                    break;
                }
            }
        }
        public void SubSlctCat1()
        {
            SubSlctCat.Click();

            foreach (IWebElement tag in SlctCatopt)
            {
                // System.Diagnostics.Debug.WriteLine("SlctCatopt value is : " + tag.Text);

                if (tag.Text.Equals("Meeting Minutes"))
                {

                    tag.Click();
                    break;
                }
            }

        }

        public void UrgLvl1()
        {
            UrgLvl.Click();


            foreach (IWebElement tag in MngeHmopt)
            {
                System.Diagnostics.Debug.WriteLine("SlctCatopt value is : " + tag.Text);

                if (tag.Text.Equals("Medium"))
                {

                    tag.Click();
                    break;
                }
            }
        }
        public void Desc1()
        {
            Desc.SendKeys("Everything is working Fine");
        }
        public void Submit1()
        {
            Submit.Click();
        }
      




























    }*/
}

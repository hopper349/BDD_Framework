using System;
using System.Collections.Generic;
using AutoFrameWork.Base;
using AutoFrameWork.Extensions;
using OpenQA.Selenium;


namespace UnitTesting.Pages
{
    class LoginPage : BasePage
    {

        public LoginPage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        public IWebElement lnklogin => _parallelConfig.Driver.FindByXpath("//button[contains(text(),' Login')]");

        public IWebElement txtUsername => _parallelConfig.Driver.FindByXpath("//input[contains(@placeholder,'Email')]");
        public IWebElement txtPassword => _parallelConfig.Driver.FindByXpath("//input[contains(@placeholder,'Password')]");
        public IWebElement btnlogin => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Login')]");

        public IWebElement ManageAssociation => _parallelConfig.Driver.FindByXpath("//span[contains(text(),'Manage Home')]/parent::button");
        public IList<IWebElement> MngeHmopt => _parallelConfig.Driver.FindElementsByXPath("//div[contains(@id,'collapse3')]//div//ul//li");
        public IWebElement AddService => _parallelConfig.Driver.FindByXpath("//button[contains(@mattooltip,'Add Service Request')]");
        public IWebElement AddTitle => _parallelConfig.Driver.FindByXpath("//input[contains(@placeholder,'Add Title')]");
        public IWebElement SlctCat => _parallelConfig.Driver.FindByXpath("//div[@class='mat-select-trigger']//span[text()='Select Category']");
        public IList<IWebElement> SlctCatopt => _parallelConfig.Driver.FindElementsByXPath("//div[contains(@class,'cdk-overlay-pane')]//div//span");
        public IWebElement SubSlctCat => _parallelConfig.Driver.FindByXpath("//div[@class='mat-select-trigger']//span[text()='Select Sub Category']");
        public IWebElement UrgLvl => _parallelConfig.Driver.FindByXpath("//div[@class='mat-select-trigger']//span[text()='Urgency Level']");
        public IWebElement Desc => _parallelConfig.Driver.FindByXpath("//textarea[contains(@class,'mat-input-element')]");
        public IWebElement BtnSubmit => _parallelConfig.Driver.FindByXpath("//button[contains(@type,'submit')]");
        public IWebElement BtnCancel => _parallelConfig.Driver.FindByXpath("//span[contains(text(),' Cancel')]");


        public void ClickLnkLoginexist() => lnklogin.AssertElementPresent();
        public void ClickLnkLogin() => lnklogin.Click();

        /*public LoginPage ClickLnkLogin(){
            
            lnklogin.Click();
            return GetInstance<LoginPage>();
        }*/
        public void LoginCred(String Username, String Password)
        {

            txtUsername.SendKeys(Username);
            txtPassword.SendKeys(Password);

        }

        public void ClkLoginbtn() => btnlogin.Submit();
        //***********************************
     
        public void ClkManageAssociation()
        {
            ManageAssociation.Submit();
            foreach (IWebElement tag in MngeHmopt)
            {
                System.Diagnostics.Debug.WriteLine("MngeHmopt value is : " + tag.Text);

                if (tag.Text.Equals("My Service Requests"))
                {

                    tag.Click();
                }
            }


        }

        public void AddTitle1() => AddTitle.SendKeys("Testing Application");



        public void SlctCatopt1()
        {
            SlctCat.Click();
            foreach (IWebElement tag in SlctCatopt)
            {
                System.Diagnostics.Debug.WriteLine("SlctCatopt value is : " + tag.Text);
                System.Threading.Thread.Sleep(5000);
                if (tag.Text.Equals("Documents"))
                {
                    // WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                    //wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

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
        public void Desc1() => Desc.SendKeys("Everything is working Fine");

        public void Submit1() => BtnSubmit.Click();


        public void Add1() => AddService.Click();

 }
    }






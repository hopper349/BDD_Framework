using AutoFrameWork.Base;
using TechTalk.SpecFlow;
using UnitTesting.Pages;
using TechTalk.SpecFlow.Assist;
using AutoFrameWork.COnfig;

namespace UnitTesting.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        //Context injection
        private new readonly ParallelConfig _parallelConfig;
        
        public LoginSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }
        public void NavigateSite()
        {
            _parallelConfig.Driver.Navigate().GoToUrl(Setting.AUT);
            //LogHelpers.Write("Opened the browser !!!");
        }

        [Given(@"I have navigate to the application")]
        public void GivenIHaveNavigateToTheApplication()
        {
            
            NavigateSite();
           _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
        }
     
        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            _parallelConfig.CurrentPage.As<LoginPage>().ClickLnkLoginexist();
        } 
      
        [Then(@"I click on login link")]
        public void ThenIClickOnLoginLink()
        {
            _parallelConfig.CurrentPage.As<LoginPage>().ClickLnkLogin();
        }
       

        [When(@"I entered Username and Password")]
        public void WhenIEnteredUsernameAndPassword(Table table)
        {

            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<LoginPage>().LoginCred(data.Username,data.Password);
        }

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            _parallelConfig.CurrentPage.As<LoginPage>().ClkLoginbtn();
           
            /*System.Threading.Thread.Sleep(8000);
            CurrentPage.As<LoginPage>().ClkManageAssociation();
            System.Threading.Thread.Sleep(8000);
            CurrentPage.As<LoginPage>().Add1();
            CurrentPage.As<LoginPage>().AddTitle1();
            CurrentPage.As<LoginPage>().SlctCatopt1();
            CurrentPage.As<LoginPage>().SubSlctCat1();
            CurrentPage.As<LoginPage>().UrgLvl1();
            System.Threading.Thread.Sleep(8000);
            CurrentPage.As<LoginPage>().Desc1();
            CurrentPage.As<LoginPage>().Submit1();
           */




            /*
             if(CurrentPage.As<LoginPage>().ClickLnkLogin().contains(""))
            */
        }

    }
}

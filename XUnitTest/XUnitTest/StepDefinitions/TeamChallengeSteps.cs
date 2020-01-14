using System;
using TechTalk.SpecFlow;
using TeamChallenge.PageObjects;

namespace TeamChallenge.StepDefinitions
{
    [Binding]
    public class TeamChallengeSteps
    {
        ChallengePage challengePg = new ChallengePage();
        LoginPage loginPg = new LoginPage();
        [Given(@"I am a Super user and I log into the motion portal")]
        public void GivenIAmASuperUserAndILogIntoTheMotionPortal()
        {
            loginPg.logintoPortal("", "");
        }

        [Then(@"I see Challenges on the left tool bar with View Challenges and Create Challenge Tabs")]
        public void ThenISeeChallengesOnTheLeftToolBarWithViewChallengesAndCreateChallengeTabs()
        {
            challengePg.VerifyIfChallengeMenuPresent();
        }

        [When(@"I click on View Challenges")]
        public void WhenIClickOnViewChallenges()
        {
            challengePg.ClickViewChallange();
        }

        [Then(@"a new Tab is openned and I see View Challanges Page on the New Tab")]
        public void ThenANewTabIsOpennedAndISeeViewChallangesPageOnTheNewTab()
        {
            challengePg.VeirfyViewChallengePageOpenOnNewTab();
        }


        [When(@"I click on the first tab for the old portal I see the original page I started on\.")]
        public void WhenIClickOnTheFirstTabForTheOldPortalISeeTheOriginalPageIStartedOn_()
        {
            challengePg.gotoOldPortalPage();
        }
        
       
        
        [Then(@"I am taken to the new challenges portal ""(.*)"" page")]
        public void ThenIAmTakenToTheNewChallengesPortalPage(string p0)
        {
           
        }
        
        [Then(@"I see that there is a second tab for the new portal")]
        public void ThenISeeThatThereIsASecondTabForTheNewPortal()
        {
          
        }
        
        [Then(@"I see that there is a tab for the new portal\.")]
        public void ThenISeeThatThereIsATabForTheNewPortal_()
        {
            
        }
        
        [Then(@"I click on ""(.*)""")]
        public void ThenIClickOn(string p0)
        {
            challengePg.ClickCreateChallenge();
        }
        
        [Then(@"I see the ""(.*)"" page of the new portal")]
        public void ThenISeeThePageOfTheNewPortal(string p0)
        {
            challengePg.VeirfyCreateChallengePageOpenOnNewTab();
        }
        
        [Then(@"I see multiple tab's for the old and new portal\.")]
        public void ThenISeeMultipleTabSForTheOldAndNewPortal_()
        {
            
        }


        [Given(@"I am a CSAdmin and I log into the motion portal")]
        public void GivenIAmACSAdminAndILogIntoTheMotionPortal()
        {
            loginPg.logintoPortal("", "");
        }

        [Given(@"I am a ClientAdmin and I log into the motion portal")]
        public void GivenIAmAClientAdminAndILogIntoTheMotionPortal()
        {
            loginPg.logintoPortal("", "");
        }


    }
}

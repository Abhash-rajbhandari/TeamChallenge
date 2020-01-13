using System;
using TeamChallenge.PageObjects;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTest
{
    [Binding]
    public class TestStepDefinitionFile
    {
        HomePage hp = new HomePage();

        [Given(@"I enter a number")]
        public void GivenIEnterANumber()
        {
            hp.ClickDocumentationPage();
           
        }
        
        [Then(@"I add the numbers")]
        public void ThenIAddTheNumbers()
        {
            
        }

        
    }
}

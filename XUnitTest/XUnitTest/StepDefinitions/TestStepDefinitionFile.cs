using System;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTest
{
    [Binding]
    public class TestStepDefinitionFile
    {
        [Given(@"I enter a number")]
        public void GivenIEnterANumber()
        {
           
        }
        
        [Then(@"I add the numbers")]
        public void ThenIAddTheNumbers()
        {
            Console.WriteLine("Hello");
            Assert.Equal(2,2);
        }

        
    }
}

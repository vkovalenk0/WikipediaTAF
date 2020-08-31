using Core;
using NUnit.Framework;
using Page;
using TechTalk.SpecFlow;

namespace Feature.Steps
{
    [Binding]
    public class AbilityToSeeWikipediaHomePageSteps
    {
        private const string HOME_PAGE_URL = "https://en.wikipedia.org/wiki/Main_Page";
        private HomePage HomePage = new HomePage();

        [When("Users opens home page")]
        public void WhenUsersOpensHomePage()
        {
            // TODO read from properties
            DriverManager.OpenPage(HOME_PAGE_URL);
        }

        [Then("Home page link contains text '(.*)'")]
        public void ThenHomePageLinkContainsText(string text)
        {
            Assert.AreEqual(text, HomePage.HomeLink.Text);
        }
    }
}

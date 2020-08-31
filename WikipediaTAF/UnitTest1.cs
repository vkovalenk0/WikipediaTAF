using Core;
using NUnit.Framework;
using Page;

namespace WikipediaTAF
{
    public class Tests
    {
        private const string HOME_PAGE_URL = "https://en.wikipedia.org/wiki/Main_Page";
        HomePage HomePage = new HomePage();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // TODO read from properties
            DriverManager.OpenPage(HOME_PAGE_URL);

            Assert.AreEqual("Wikipedia", HomePage.HomeLink.Text);
        }

        [TearDown]
        public void TearDown()
        {
            DriverManager.CloseBrowser();
        }
    }
}
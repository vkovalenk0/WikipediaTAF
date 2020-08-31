using OpenQA.Selenium;

namespace Page
{
    public class HomePage : BasePage
    {

        public IWebElement HomeLink { get { return this.webDriver.FindElement(By.CssSelector("#mp-welcome a")); } }

    }

}

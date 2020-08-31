using Core;
using OpenQA.Selenium;

namespace Page
{
    public class BasePage
    {
        protected IWebDriver webDriver = DriverManager.GetDriverInstance();
    }
}

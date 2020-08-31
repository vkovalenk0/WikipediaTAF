using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Core
{
    public class DriverManager
    {
        private static readonly ThreadLocal<IWebDriver> WebDriver = new ThreadLocal<IWebDriver>();

        public static IWebDriver GetDriverInstance()
        {
            if (!WebDriver.IsValueCreated)
            {
                WebDriver.Value = new ChromeDriver();
            }
            return WebDriver.Value;
        }

        public static void OpenPage(string url)
        {
            GetDriverInstance().Navigate().GoToUrl(url);
        }
        public static void CloseBrowser()
        {
            GetDriverInstance().Close();
            WebDriver.Value = null;
        }
    }
}

using Core;
using TechTalk.SpecFlow;

namespace Feature.Hooks
{
    [Binding]
    class CloseDriverHook
    {
        [AfterScenario]
        public void closeDriver()
        {
            DriverManager.CloseBrowser();
        }
    }
}

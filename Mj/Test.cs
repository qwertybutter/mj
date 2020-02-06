using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Mj
{
    public class Test
    {
        [Test]
        public void TestRun()
        {
            ChromeDriver chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("https://metanit.com");
            chrome.Quit();
        }
    }
}

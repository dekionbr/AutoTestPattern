using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ.AutoTestPattern.WebTest.Pages
{
    public class CounterPage : BasePage
    {
        const string BTNINCREMENTNAME = "btnIncrement";

        public CounterPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public bool TestClickCount()
        {
            var btnIncrement = wait.Until<IWebElement>(x => x.FindElement(By.Name(BTNINCREMENTNAME)));
            var countTag = wait.Until<IWebElement>(x => x.FindElement(By.TagName("strong")));

            int countOld = Convert.ToInt16(countTag.Text);

            btnIncrement.Click();

            int countNow = Convert.ToInt16(countTag.Text);

            return countNow > countOld &&
                countNow == ++countOld;
        }
    }
}

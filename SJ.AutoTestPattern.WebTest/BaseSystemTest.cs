using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ.AutoTestPattern.WebTest
{
    public abstract class BaseSystemTest
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected BasePage Page;

        public BaseSystemTest()
        {
            string driveDirectory = ConfigurationManager.AppSettings["DRIVEDIRECTORY"];
            driver = new ChromeDriver(driveDirectory);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System.Linq;

namespace SJ.AutoTestPattern.WebTest
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        public string urlBase = ConfigurationManager.AppSettings["HOST"];
        
        public T Navegar<T>(string page) where T : BasePage
        {
            if (!string.IsNullOrEmpty(page))
                urlBase += page.First().Equals('/') ? page.Remove(0, 1) : page;

            driver.Navigate().GoToUrl(urlBase);

            return (T)this;
        }
    }
}
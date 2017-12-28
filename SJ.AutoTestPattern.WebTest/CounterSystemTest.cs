using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SJ.AutoTestPattern.WebTest.Pages;

namespace SJ.AutoTestPattern.WebTest
{
    [TestClass]
    public class CounterSystemTest : BaseSystemTest
    {
        public CounterSystemTest()
        {
            Page = new CounterPage(driver, wait);
        }

        [TestMethod]
        public void TestPageCounter()
        {
            bool test = Page
                .Navegar<CounterPage>("counter")
                .TestClickCount();

            Assert.IsTrue(test);

            driver.Close();
        }
    }
}

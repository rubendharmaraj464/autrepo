using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestAutomation
{
    class WindowHandels : Login
    {
        public void HandleWindow(IWebDriver driver)
        {
            driver.Url = "https://demoqa.com/browser-windows";

            driver.FindElement(By.Id("windowButton")).Click();
        }
    }
}

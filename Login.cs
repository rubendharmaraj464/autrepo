using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestAutomation
{
    
    public class Login
    {
        public IWebDriver driver;
        [SetUp]
        public void setbrowser()
        {
           driver = new ChromeDriver("D:\\SeleniumC#\\Software\\chromedriver_win32");
        }


        [Test]
        public void LaunchApp()
        {
            driver.Url = "http://uitestpractice.com/Students/Contact";
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Sync()
        {
             LaunchApp();
            Waits obj = new Waits();
            obj.ExplicittWait(driver);
        }

            /* try
             {
                 driver = new ChromeDriver("D:\\SeleniumC#\\Software\\chromedriver_win32");
                 driver.Url = "https://scgi.half.ebay.com/ws/eBayISAPI.dll?RegisterEnterInfo&usage=2943&ru=";
            // driver.FindElement(By.LinkText("Sign in")).Click();
                Thread.Sleep(10000);
                driver.FindElement(By.Name("firstname")).SendKeys("Jhon");
                driver.FindElement(By.Name("lastname")).SendKeys("David");

                driver.FindElement(By.Name("address")).SendKeys("SR NAGAR");

                driver.FindElement(By.Name("address2")).SendKeys("Telangana");

                 driver.FindElement(By.Name("city")).SendKeys("HYDERABAD");

             }
             catch (Exception e)
             {
                 Console.WriteLine(e);
             }
             finally
             {
                 driver.Close();
             }*/
            //code






            //driver.FindElement(By.PartialLinkText("Want to register")).Click();

            // driver.FindElement(By.XPath("//*[@id='userid']")).SendKeys("tom");

            /// driver.FindElement(By.PartialLinkText("How to pick")).Click();
            /// 
            // IWebElement selectobj =  driver.FindElement(By.Id("SECRET_QUESTION"));

            //  var select =  new SelectElement(selectobj);
            // select.SelectByIndex(2);
            //  select.SelectByText("What is the name of your first school?");
            /*   IWebElement selectobj = driver.FindElement(By.Id("birthdate1"));
               var select = new SelectElement(selectobj);
               select.SelectByValue("2");*/
            // select.SelectByIndex(2);
            //select.SelectByValue("What is the name of your first school?");



            /*  driver.FindElement(By.Id("useremail")).SendKeys("rubendharmaraj@gmail.com");

              driver.FindElement(By.ClassName("input-group-text")).Click();

              Thread.Sleep(10000);

              driver.FindElement(By.Name("name")).SendKeys("RubenDharmaraj");

             // driver.FindElement(By.Id("userpassword")).SendKeys("Best@1234");

              driver.FindElement(By.XPath("//*[@id='userpassword']")).SendKeys("Best@1234");



              driver.FindElement(By.Name("phone")).SendKeys("+91-8925301543");

              driver.FindElement(By.ClassName("customcheckbox")).Click();

              // driver.FindElement(By.ClassName("btn btn-dark submit-btn")).Click();

              driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/form/div[6]/button")).Click();*/

            //*[@id="app"]/div/div/div[2]/div/form/div[6]/button

            /* IWebElement emailobj =  driver.FindElement(By.Id("useremail"));
             emailobj.Clear();
             emailobj.SendKeys("rubendharmaraj111@gmail.com");
             emailobj.Clear();*/


       
        [Test]
        public void Alerts_Handle()
        {
        
      
            Alerts obj = new Alerts();
            obj.HandleAlerts(driver);

        }
        [Test]
        public void GetExcelData()
        {
            

             ExcelHandle xl = new ExcelHandle();
             xl.ExcelOperations();

        }

        [Test]
        public void Windows()
        {
            WindowHandels obj = new WindowHandels();
            obj.HandleWindow(driver);
            String Parentwindow =driver.CurrentWindowHandle;
            Console.WriteLine("Parentwindow name is :"+ Parentwindow);
            List<String> listobjb = driver.WindowHandles.ToList();
            Console.WriteLine(listobjb.Count);
            foreach(var handles in listobjb)
            {
                driver.SwitchTo().Window(handles);
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            }
            //driver.SwitchTo().Window("");
        }

        [Test]
        public void Navigation()
        {
  /*          driver.Navigate().Back();
            Thread.Sleep(5000);
            driver.Navigate().Forward();
            Thread.Sleep(5000);
            driver.Navigate().Refresh();*/
        }
        [Test]
        public void HandpleWebTable()
        {
          
            /*driver.Url = "http://secure.smartbearsoftware.com/samples/testcomplete11/WebOrders/login.aspx";
            Thread.Sleep(10000);
            driver.FindElement(By.Name("ctl00$MainContent$username")).SendKeys("Tester");
    
            driver.FindElement(By.Id("ctl00_MainContent_password")).SendKeys("test");
            driver.FindElement(By.Name("ctl00$MainContent$login_button")).Click();

               IWebElement TableObj = driver.FindElement(By.Id("ctl00_MainContent_orderGrid"));

                        List<IWebElement> listelements = new List<IWebElement> (TableObj.FindElements(By.TagName("TR")));

                        Console.WriteLine(listelements.Count);

            for(int i = 2; i <= listelements.Count;i++)
            {
                String cellvalue = driver.FindElement(By.XPath("//*[@id='ctl00_MainContent_orderGrid']/tbody/tr["+i+"]/td[2]")).Text;
                Console.WriteLine("cellvalue is: " + cellvalue);
            }
            */
         












        }

        [TearDown]
        public void CloseBrowser()
        {
           // driver.Close();
        }

    }
}

using System;
using System.Threading;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TechExpozedWeb
{
    public class UnitTest1
    {
        IWebDriver driver;
        Actions action;
        /******************************************/
        /******* digital markerting page **********/
        /******************************************/

        [Fact]
        public void TestNavigateToDigitalMarketingPage()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed page
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            //maximize window size
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing menu
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            // go to digital marketing page
            IWebElement digitalMarketing = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[1]/a/span"));
            digitalMarketing.Click();
            Thread.Sleep(3000);

            driver.Quit();
        }

        
        
        [Fact]
        public void TestFormButton()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed page
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            //maximize window size
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing menu
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            // go to digital marketing page
            IWebElement digitalMarketing = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[1]/a/span"));
            digitalMarketing.Click();
            Thread.Sleep(10000);

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,990);");
            Thread.Sleep(3000);
            //driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/div/div/div[1]/div/div[2]/div/a")).Click();
            //Click on get started button (Flexi starter)
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div/div/div[1]/div/div/div/div[3]/a")).Click();
            Thread.Sleep(3000);
            //CLOSE BUTTON
            driver.FindElement(By.XPath("//*[@id='pricingModal']/div/div/div[3]/button")).Click();
            Thread.Sleep(2000);

            //get started button (promote me)
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div/div/div[2]/div/div/div/div[3]/a")).Click();
            Thread.Sleep(2000);
            //CLOSE BUTTON
            driver.FindElement(By.XPath("//*[@id='pricingModal']/div/div/div[3]/button")).Click();
            Thread.Sleep(2000);
            

            // get started button (executive business)
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div/div/div[3]/div/div[2]/div/div[3]/a")).Click();
            Thread.Sleep(2000);
            driver.Quit();
            //CLOSE BUTTON
            driver.FindElement(By.XPath("//*[@id='pricingModal']/div/div/div[3]/button")).Click();
            Thread.Sleep(3000);

            driver.Quit();
        }

        [Fact]
        public void TestPricingPlanForm()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed page
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            //maximize window size
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing menu
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            // go to digital marketing page
            IWebElement digitalMarketing = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[1]/a/span"));
            digitalMarketing.Click();
            Thread.Sleep(3000);

            //SCROLL DOWN
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,990);");
            Thread.Sleep(3000);

            //Click on get started button 
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div/div/div[1]/div/div/div/div[3]/a")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("first_name")).SendKeys("Tom");
            driver.FindElement(By.Id("last_name")).SendKeys("Miller");
            driver.FindElement(By.Id("email")).SendKeys("fsdvsdjv");
            driver.FindElement(By.Id("subject")).SendKeys("vdsanvlk;");
            driver.FindElement(By.Id("message")).SendKeys("DSVNJKASK");
            driver.FindElement(By.XPath("//*[@id='pricing_form']/div/div[4]/button")).Submit();
            Thread.Sleep(4000);
            driver.Quit();
        }

        [Fact]
        public void TestSeoSection1()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed page
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            //maximize window size
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing menu
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            // go to digital marketing page
            IWebElement digitalMarketing = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[1]/a/span"));
            digitalMarketing.Click();
            Thread.Sleep(3000);

            //Definition
            driver.FindElement(By.Id("nav-tab1")).Click();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            driver.Navigate().Forward();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [Fact]
        public void TestSeoSection2_1()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed page
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            //maximize window size
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing menu
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            // go to digital marketing page
            IWebElement digitalMarketing = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[1]/a/span"));
            digitalMarketing.Click();
            Thread.Sleep(3000);

            //techique
            //driver.FindElement(By.Id("nav-tab2")).Click();
            driver.FindElement(By.XPath("//*[@id='nav-tab2']")).Click();
            Thread.Sleep(3000);

            //on-page 
            driver.FindElement(By.XPath("//*[@id='tab_list_07']/div/div/div[1]/div/div/ul/li[1]/a")).Click();
            Thread.Sleep(3000);
            //dropdown bar 1
            driver.FindElement(By.XPath("//*[@id='headingTen']/h5/button")).Click();
            Thread.Sleep(3000);
            //dropdown bar 2
            driver.FindElement(By.XPath("//*[@id='headingTwo']/h5/button")).Click();
            Thread.Sleep(3000);
            //dropdown bar 3 
            driver.FindElement(By.XPath("//*[@id='headingThree']/h5/button")).Click();
            Thread.Sleep(3000);
            //dropdown bar 4 
            driver.FindElement(By.XPath("//*[@id='headingFour']/h5/button")).Click();
            Thread.Sleep(3000);
            //dropdown bar 5 
            driver.FindElement(By.XPath("//*[@id='headingFive']/h5/button")).Click();
            Thread.Sleep(3000);
            //dropdown bar 6 
            driver.FindElement(By.XPath("//*[@id='headingSix']/h5/button")).Click();
            Thread.Sleep(3000);
            //dropdown bar 7 
            driver.FindElement(By.XPath("//*[@id='headingSeven']/h5/button")).Click();
            Thread.Sleep(3000);
            //dropdown bar 8 
            driver.FindElement(By.XPath("//*[@id='headingEight']/h5/button")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [Fact]
        public void TestSeoSection2_2()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed page
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            //maximize window size
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing menu
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            // go to digital marketing page
            IWebElement digitalMarketing = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[1]/a/span"));
            digitalMarketing.Click();
            Thread.Sleep(3000);

            //techique
            //driver.FindElement(By.Id("nav-tab2")).Click();
            driver.FindElement(By.XPath("//*[@id='nav-tab2']")).Click();
            Thread.Sleep(3000);
            //OFF PAGE under technique 
            driver.FindElement(By.XPath("//*[@id='tab_list_07']/div/div/div[1]/div/div/ul/li[2]/a")).Click();
            Thread.Sleep(3000);
            // Dropdown bar 1 
            driver.FindElement(By.XPath("//*[@id='headingEleven']/h5/button")).Click();
            Thread.Sleep(3000);
            // Dropdown bar 2 
            driver.FindElement(By.XPath("//*[@id='headingTwoo']/h5/button")).Click();
            Thread.Sleep(3000);
            // Dropdown bar 3 
            driver.FindElement(By.XPath("//*[@id='headingTwelve']/h5/button")).Click();
            Thread.Sleep(3000);
            // Dropdown bar 4 
            driver.FindElement(By.XPath("//*[@id='headingThirteen']/h5/button")).Click();
            Thread.Sleep(3000);
            // Dropdown bar 5 
            driver.FindElement(By.XPath("//*[@id='headingFourteen']/h5/button")).Click();
            Thread.Sleep(3000);

            driver.Quit();

        }

        [Fact]
        public void TestSeoSection3()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed page
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            //maximize window size
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing menu
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            // go to digital marketing page
            IWebElement digitalMarketing = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[1]/a/span"));
            digitalMarketing.Click();
            Thread.Sleep(6000);

            //keywords 
            driver.FindElement(By.Id("nav-tab3")).Click();
            //driver.FindElement(By.XPath("//*[@id='nav-tab3']")).Click();
            Thread.Sleep(4000);
            //dropdown bar 1
            driver.FindElement(By.XPath("//*[@id='headingTwelvee']/h5/button")).Click();
            Thread.Sleep(3000);
            //dropdaown bar 2
            driver.FindElement(By.XPath("//*[@id='headingThirteenn']/h5/button")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [Fact]
        public void TestSeoSection4()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed page
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            //maximize window size
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing menu
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            // go to digital marketing page
            IWebElement digitalMarketing = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[1]/a/span"));
            digitalMarketing.Click();
            Thread.Sleep(3000);

            //our mission
            driver.FindElement(By.Id("nav-tab5")).Click();
            Thread.Sleep(3000);
            driver.Quit();

        }
        /*****************************************/
        /******* website package page ************/
        /*****************************************/
        [Fact]
        public void TestNavigateToWebsitePackagePage()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            // maximize window
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            //  navigate to web package page
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[2]/a")).Click();
            Thread.Sleep(3000);

            driver.Quit();

        }

        [Fact]
        public void TestWebPackagePricingPlanFormGetStartedButton()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            // maximize window
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            //  navigate to web package page
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[2]/a")).Click();
            Thread.Sleep(3000);


            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,990);");
            Thread.Sleep(3000);

            //click on sign up button intro 
            //driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/div/div/div[1]/div/div[2]/div/a")).Click();
            //driver.FindElement(By.XPath("//*[@id='month-tab']/div/div[1]/div/div[2]/div/a")).Click();
            //Thread.Sleep(6000);

            //click on sign up button BASIC 
            driver.FindElement(By.XPath("//*[@id='month-tab']/div/div[2]/div/div[3]/div/a")).Click();
            Thread.Sleep(6000);
            driver.Quit();
        }

        [Fact]
        public void TestWebPackagePricingPlanForm()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            // maximize window
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            //  navigate to web package page
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[2]/a")).Click();
            Thread.Sleep(3000);

            //click on sign up button intro
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/div/div/div[1]/div/div[2]/div/a")).Click();
            Thread.Sleep(6000);

            driver.FindElement(By.Id("first_name")).SendKeys("Jane");
            driver.FindElement(By.Id("last_name")).SendKeys("Lee");
            driver.FindElement(By.Id("email")).SendKeys("1234");
            driver.FindElement(By.Id("mobile")).SendKeys("abcd");
            driver.FindElement(By.Id("subject")).SendKeys(" ");
            driver.FindElement(By.Id("message")).SendKeys("This is a test");
            driver.FindElement(By.XPath("//*[@id='pricingModal']/div/div/div[3]/button")).Click();
            driver.Quit();
        }

        [Fact]
        public void TestContactUsSection()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            // navigate to techexpozed
            driver.Navigate().GoToUrl("https://techexpozed.co.nz");
            Thread.Sleep(3000);
            // maximize window
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // hover on pricing
            IWebElement pricing = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/a/span"));
            action.MoveToElement(pricing).Perform();
            Thread.Sleep(2000);
            //  navigate to web package page
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[3]/ul/li[2]/a")).Click();
            Thread.Sleep(3000);


            //click on contact us button
            driver.FindElement(By.XPath("/html/body/div[4]/div[5]/div/div/div[2]/div/div[2]/a")).Click();
            Thread.Sleep(4000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            driver.Quit();
        }

    }
}

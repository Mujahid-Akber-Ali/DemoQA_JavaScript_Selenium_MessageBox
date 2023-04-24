using System;
using System.Threading;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;

namespace DemoQA_JavaScript_Selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Practice_form()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Url = "https://demoqa.com/";
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            js.ExecuteScript("document.getElementById('firstName').value='Mujahid'");
            js.ExecuteScript("document.getElementById('lastName').value='Akber Ali'");
            js.ExecuteScript("document.getElementById('userEmail').value='mujahidakberali@gmail.com'");
            js.ExecuteScript("document.querySelector('#genterWrapper > div.col-md-9.col-sm-12 > div:nth-child(1) > label').click()");
            js.ExecuteScript("document.getElementById('userNumber').value='12345678'");


            js.ExecuteScript("document.getElementById('dateOfBirthInput').value='03 July 1998'");
            driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(OpenQA.Selenium.Keys.Enter);
            driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(OpenQA.Selenium.Keys.Tab);


            driver.FindElement(By.Id("subjectsInput")).SendKeys("math");
            driver.FindElement(By.Id("subjectsInput")).SendKeys(OpenQA.Selenium.Keys.Enter);
            driver.FindElement(By.Id("subjectsInput")).SendKeys(OpenQA.Selenium.Keys.Tab);

            js.ExecuteScript("document.querySelector('#hobbiesWrapper > div.col-md-9.col-sm-12 > div:nth-child(1) > label').click()");
            driver.FindElement(By.Id("uploadPicture")).SendKeys(@"C:\Users\AliiiTai\Desktop\username.png");
            js.ExecuteScript("document.getElementById('currentAddress').value='Scheme-33'");




            driver.FindElement(By.Id("react-select-3-input")).SendKeys("NCR");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(OpenQA.Selenium.Keys.Enter);

            driver.FindElement(By.Id("react-select-4-input")).SendKeys("Delhi");
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(OpenQA.Selenium.Keys.Enter);
            //js.ExecuteScript("document.getElementById('react-select-4-input').value='Delhi'");
            //js.ExecuteScript("document.getElementById('submit').click()");
        }
        [TestMethod]
        public void Practiceform_JQuery()
        {

            //LOad with JQuery//
            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Url = "https://demoqa.com/automation-practice-form";
            js.ExecuteScript("$('#firstName').val('Mujahid')");
            js.ExecuteScript("$('#lastName').val('Akber Ali')");
            js.ExecuteScript("$('#userEmail').val('mujahidakberali@gmail.com')");
            js.ExecuteScript("$('#gender-radio-1').click();");
            js.ExecuteScript("$('#userNumber').val('87976876876')");

            js.ExecuteScript("$('#dateOfBirthInput').val('03 July 1998')");


            driver.FindElement(By.Id("subjectsInput")).SendKeys("math");
            driver.FindElement(By.Id("subjectsInput")).SendKeys(OpenQA.Selenium.Keys.Enter);
            driver.FindElement(By.Id("subjectsInput")).SendKeys(OpenQA.Selenium.Keys.Tab);
            //checkbox

            js.ExecuteScript("$('#hobbies-checkbox-1').click();");

            // Select the subjects
            driver.FindElement(By.Id("uploadPicture")).SendKeys(@"C:\Users\AliiiTai\Desktop\username.png");


            // Select the hobbies
            js.ExecuteScript("$('#hobbies-checkbox-1').prop('checked', true);");
            //js.ExecuteScript("$('#hobbies-checkbox-3').prop('checked', true);");

            // Enter the current address
            js.ExecuteScript("$('#currentAddress').val('123 Main St');");

            // Select the state

            driver.FindElement(By.Id("react-select-3-input")).SendKeys("NCR");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(OpenQA.Selenium.Keys.Enter);

            // Select the city
            driver.FindElement(By.Id("react-select-4-input")).SendKeys("Delhi");
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(OpenQA.Selenium.Keys.Enter);

            // Click the submit button
            js.ExecuteScript("$('#submit').click();");
        }


        [TestMethod]
        public void TextBox()
        {
            // For text box

            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://demoqa.com/text-box";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("document.getElementById('userName').value='Mujahid'");
            js.ExecuteScript("document.getElementById('userEmail').value='mujahidakberali@gmail.com'");
            js.ExecuteScript("document.getElementById('currentAddress').value='Karachi, Pakistan'");
            js.ExecuteScript("document.getElementById('permanentAddress').value='Karachi, Pakistan'");
            js.ExecuteScript("document.getElementById('submit').click()");


            var element2 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[1]/div[2]/input"));

            string element2State = element2.GetAttribute("Disabled");

            if (element2State == null)
            {
                element2State = "enabled";

                MessageBox.Show("Enabled");
            }
            else if (element2State == "true")
            {
                element2State = "disabled";

                MessageBox.Show("Disabled");
            }



        }

        [TestMethod]
        // For Check box
        public void CheckBox()
        {


            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://demoqa.com/checkbox";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("document.querySelector('#tree-node > ol > li > span > label > span.rct-checkbox').click()");


            var element2 = driver.FindElement(By.CssSelector("#tree-node > ol > li > span > label > span.rct-checkbox"));

            string element2State = element2.GetAttribute("Disabled");

            if (element2State == null)
            {
                element2State = "enabled";

                MessageBox.Show("Enabled");
            }
            else if (element2State == "true")
            {
                element2State = "disabled";

                MessageBox.Show("Disabled");
            }




        }

        [TestMethod]
        public void RadioButtton()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://demoqa.com/radio-button";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            var element2 = driver.FindElement(By.Id("yesRadio"));

            string element2State = element2.GetAttribute("Disabled");

            if (element2State == null)
            {
                element2State = "enabled";

                MessageBox.Show("Enabled");
            }
            else if (element2State == "true")
            {
                element2State = "disabled";

                MessageBox.Show("Disabled");
            }


            // Checking status of radio button

            js.ExecuteScript("document.getElementById('yesRadio').click()");

            var element3 = driver.FindElement(By.Id("noRadio"));

            string element3State = element2.GetAttribute("Disabled");

            if (element3State == "true")
            {
                element3State = "enabled";

                MessageBox.Show("Enabled");
            }
            else if (element3State == null)
            {
                element3State = "disabled";

                MessageBox.Show("Disabled");
            }



        }

        [TestMethod]
        public void WebTables()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://demoqa.com/webtables";
            driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("document.getElementById('addNewRecordButton').click()");
            js.ExecuteScript("document.getElementById('firstName').value='Mujahid'");
            js.ExecuteScript("document.getElementById('lastName').value='Akber Ali'");
            js.ExecuteScript("document.getElementById('userEmail').value='mujahidakberali@gmail.com'");
            js.ExecuteScript("document.getElementById('age').value='23'");
            js.ExecuteScript("document.getElementById('salary').value='23000'");
            js.ExecuteScript("document.getElementById('department').value='Human Resource'");


            var element3 = driver.FindElement(By.Id("salary"));

            string element3State = element3.GetAttribute("Disabled");

            if (element3State == null)
            {
                element3State = "enabled";

                MessageBox.Show("Enabled");
            }
            else if (element3State == "true")
            {
                element3State = "disabled";

                MessageBox.Show("Disabled");
            }




        }

        [TestMethod]
        // For Button
        public void Button()
        {

            // Double Click is performed

            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://demoqa.com/buttons";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            var element = driver.FindElement(By.Id("doubleClickBtn"));
            //Actions
            Actions action = new Actions(driver);
            action.DoubleClick(element).Perform();

            MessageBox.Show("Double Click is Performed");


            // Right Click is performed

            var element1 = driver.FindElement(By.Id("rightClickBtn"));
            //Actions
            Actions action1 = new Actions(driver);

            action.ContextClick(element1).Perform();

            MessageBox.Show("Right Click is Performed");


            var element2 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/button"));
            //Actions
            Actions action2 = new Actions(driver);

            action.Click(element2).Perform();

            MessageBox.Show("Dynamic Click is Performed");




        }

    }
}

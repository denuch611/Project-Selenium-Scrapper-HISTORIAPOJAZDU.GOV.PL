using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

using System.Reflection;
using System.Threading;
using OpenQA.Selenium.Safari;
using System.Collections.Generic;
using System.Web;

namespace projektub

{

    class Program
    {

        public static void Main(string[] args)
        {

           

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;



            IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://historiapojazdu.gov.pl/");

                    var NRREJESTR = driver.FindElement(By.Id("_historiapojazduportlet_WAR_historiapojazduportlet_:rej"));
                    var VIN = driver.FindElement(By.Id("_historiapojazduportlet_WAR_historiapojazduportlet_:vin"));
                    var data = driver.FindElement(By.Id("_historiapojazduportlet_WAR_historiapojazduportlet_:data"));
                    var loginButton = driver.FindElement(By.XPath("//input[@value='Sprawdź pojazd »']"));

                    NRREJESTR.SendKeys("random register number");
              //      VIN.SendKeys("random vin number");
                    data.Click();
                    data.SendKeys("random dd.mm.yyyy");

                    loginButton.Click();


                    var titles = driver.FindElements(By.ClassName("oc"));



                    foreach (var title in titles)


                        Console.WriteLine(title.Text);

                    var oc = driver.FindElement(By.ClassName("oc")).GetAttribute("innerText");
                    Console.WriteLine(oc);
                    var badanieTech = driver.FindElement(By.ClassName("tech")).GetAttribute("innerText");
                    Console.WriteLine(badanieTech);

                    var osczasu = driver.FindElement(By.Id("raport-content-template-timeline-button"));

                    osczasu.Click();

                    var test1 = driver.FindElement(By.ClassName("summary-box")).GetAttribute("innerText");
                    Console.WriteLine(test1);


                    var test2 = driver.FindElement(By.XPath("//p[contains(text(), 'Polisa OC: ')]/span")).GetAttribute("innerText");
                    Console.WriteLine(test2);
                    //div[text()='Ingredients:']/following-sibling::div/span[contains(@class,'cancel-icon')]

                    //div[@class='ingredients-container-header-close']/span[@class='material-icons cancel-icon ']
                    //("//div[@class='item-inner']/span[@class='title']"));
                    Console.ReadKey();
                    //*[@id="timeline-summary-box"]/div[2]/p[6]




                    Thread.Sleep(3000);
                    driver.Quit();
                
            
        }
    }
















}


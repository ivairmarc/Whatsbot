using System;
using System.IO;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebWhats
{
    public class whats
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;

        public static void LoginInit()
        {
            driver = new FirefoxDriver();

            String link_url = "https://web.whatsapp.com/";

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            driver.Url = (link_url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            wait.Until(e => e.FindElement(By.ClassName("landing-window")));
            Thread.Sleep(3000);
            //suportesprodutosbmg@bancobmg.com.br
        }

        // recursive function
        public static void LerAquivo(string tell)
        {

            using (StreamReader arquivo = File.OpenText(tell))
            {
                string linha;

                while ((linha = arquivo.ReadLine()) != null)
                {
                    if (linha == "fim")
                    {
                        break;
                    }
                    Console.WriteLine(linha);
                    Console.WriteLine("------");
                    string texto = "Oi, tudo bem cliente BMG Card?";

                    wait.Until(e => e.FindElement(By.ClassName("g5RCg")));

                    //https://web.whatsapp.com/send?phone=5567992958262 &text= teste

                    driver.Url = ("https://web.whatsapp.com/send?phone=" + linha);
                    Console.WriteLine("https://web.whatsapp.com/send?phone=" + linha);
                    wait.Until(e => e.FindElement(By.CssSelector("._2x4bz > div:nth-child(2)")));
                    IWebElement inputwhats = driver.FindElement(By.CssSelector("._2x4bz > div:nth-child(2)"));

                    foreach (var i in texto)
                    {
                        inputwhats.SendKeys(Convert.ToString(i));
                        Thread.Sleep(100);
                    }




                    Thread.Sleep(40000);



                }
            }
        }
    }
}

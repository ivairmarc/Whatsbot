using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ReadWritesvFile;
using WriteCsvR;
using System.Configuration;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using LumenWorks.Framework.IO.Csv;
using System.Data;

namespace WhatsSite
{
    public class WebScrap
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;
        private static Random _random = new Random();
        // input msg


        public static void Escuta()
        {

            int cont = 0;
            
            var msg = "";
            var result = "";
            string nameContato = "";
            var resp = "";
            int c = 0;
            string otherName = "";
            string[] msgNotresp = new string[100];
            String hourMinute = DateTime.Now.ToString("HH:mm");
            DateTime dateTime = DateTime.UtcNow.Date;

            try
            {
                // Vamos setar todos as mensagens nao lidas.
                IWebElement messageList = driver.FindElement(By.Id("pane-side"));
                // msg not read
                IList<IWebElement> details = messageList.FindElements(By.ClassName("_23LrM"));
                // input de mensagem                                        ""


                foreach (var i in details)
                {
                    driver.FindElement(By.ClassName("_23LrM")).Click();
                    // campo da msg
                    wait.Until(e => e.FindElement(By.ClassName("_33LGR")));
                    // all text in msg
                    IList<IWebElement> cnv_list = driver.FindElements(By.ClassName("_2wUmf"));
                    foreach (var lst in cnv_list)
                    {
                        cont++;
                        msg = lst.Text.Replace("\r\n", "$");
                    }
                    result = msg.Substring(0, msg.IndexOf('$'));
                    //MessageBox.Show("Your data has been saved." + result);
                    IWebElement name = driver.FindElement(By.ClassName("_21nHd"));
                    nameContato = name.Text.Replace("+", "").Replace(" ", "").Replace("-", "");
                    int lengt = nameContato.Length;
                    if (lengt < 12)
                    {
                        otherName = nameContato.Substring(0, 5) + "9" + nameContato.Substring(5, 7);
                    }
                    else
                    {
                        otherName = nameContato;
                    }
                    
                    //MessageBox.Show(otherName);
                    var filepath = ConfigurationManager.AppSettings["caminho_text"] + "resposta.txt";
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        string resposta;
                        while ((resposta = reader.ReadLine()) != null)
                        {
                            // salvar a mensagem do cliente
                            // comparar com msg resposta
                            resp = resposta;

                        }
                    }
                    //
                    var notresp = ConfigurationManager.AppSettings["caminho_text"] + "naoResponder.txt";
                    using (StreamReader frase = File.OpenText(notresp))
                    {
                        string row;
                        while ((row = frase.ReadLine()) != null)
                        {
                            msgNotresp[c] = row;
                            c++;
                        }
                        //Console.WriteLine(c);


                    }

                    if (resp == result)
                    {

                        // enviar resposta
                        var filerespCli = ConfigurationManager.AppSettings["caminho_text"] + "respostaPaCli.txt";
                        using (StreamReader reader1 = new StreamReader(filerespCli))
                        {
                            string respostaForCli;

                            IWebElement inputwhats = driver.FindElement(By.CssSelector("._1LbR4 > div:nth-child(2)"));
                            wait.Until(e => e.FindElement(By.CssSelector("._1LbR4")));


                            while ((respostaForCli = reader1.ReadLine()) != null)
                            {
                                foreach (var e in respostaForCli)
                                {
                                    inputwhats.SendKeys(Convert.ToString(e));
                                    Thread.Sleep(80);
                                }

                            }
                            driver.FindElement(By.ClassName("_4sWnG")).Click();
                        }
                        var filemsg = ConfigurationManager.AppSettings["caminho_text"] + "Clientesinteressados.csv";
                        using (StreamWriter file = new StreamWriter(filemsg, true))
                        {
                            //MessageBox.Show("Your data has been saved." + result);

                            file.WriteLine(otherName + "," + dateTime.ToString("dd/MM/yyyy") + "," + hourMinute);
                        }

                        var numValid = ConfigurationManager.AppSettings["caminho_text"] + "ClientesComNumValido.csv";
                        string[] values = File.ReadAllLines(numValid);

                        for (int a = 0; a < values.Length; a++)
                        {
                            if (values[a].Contains(otherName))
                            {
                                var CliIntere = ConfigurationManager.AppSettings["caminho_text"] + "ClientesIntere.csv";
                                using (StreamWriter file = new StreamWriter(CliIntere))
                                {
                                    //MessageBox.Show("Your data has been saved." + result);

                                    file.WriteLine(values[a] );
                                    
                                }
                            }


                        }

                    }

                    else if (result == "2")
                    {

                        string tworesp = "Tudo bem, Não te enviaremos mais informações.";
                        foreach (var ch in tworesp)
                        {
                            IWebElement inputwhats = driver.FindElement(By.CssSelector("._1LbR4 > div:nth-child(2)"));
                            inputwhats.SendKeys(ch.ToString());
                        }
                        // save cli not interesting
                        var rsp2 = ConfigurationManager.AppSettings["caminho_text"] + "ClientesNaoInteressados.csv";
                        using (StreamWriter notInter = new StreamWriter(rsp2, true))
                        {
                            notInter.WriteLine(name.Text + "," + hourMinute);
                        }

                        driver.FindElement(By.ClassName("_4sWnG")).Click();
                    }

                    else if (result != resp)
                    {
                        Frases.Resposta = "No";
                        for (int it = 0; it <= c; it++)
                        {
                            if (msgNotresp[it].ToUpper().Contains(result.ToUpper()))
                            {
                                if (Convert.ToInt32(hourMinute) <= Convert.ToInt32(12))
                                {
                                    string frase = "Olá :-). Vimos que você não possui interesse, por isso, estamos finalizando seu atendimento. Tenha " +
                                        "um Bom dia";
                                    foreach (var ch in frase)
                                    {
                                        IWebElement inputwhats = driver.FindElement(By.CssSelector("._1LbR4 > div:nth-child(2)"));
                                        inputwhats.SendKeys(ch.ToString());
                                    }
                                    driver.FindElement(By.ClassName("_4sWnG")).Click();

                                    Frases.Resposta = "Yes";
                                }
                                else if (Convert.ToInt32(hourMinute) >= 12)
                                {

                                    string frase = "Olá :-). Vimos que você não possui interesse, por isso, estamos finalizando seu atendimento. Tenha " +
                                        "uma Boa tarde";
                                    foreach (var ch in frase)
                                    {
                                        IWebElement inputwhats = driver.FindElement(By.CssSelector("._1LbR4 > div:nth-child(2)"));
                                        inputwhats.SendKeys(ch.ToString());
                                    }
                                    driver.FindElement(By.ClassName("_4sWnG")).Click();

                                    Frases.Resposta = "Yes";
                                }

                            }
                        }

                        if (Frases.Resposta == "No") 
                        {
                            var filerespDiverg = ConfigurationManager.AppSettings["caminho_text"] + "msgDivergente.txt";
                            using (StreamReader reader1 = new StreamReader(filerespDiverg))
                            {
                                string respostaForCli;
                                // grade de msg
                                wait.Until(e => e.FindElement(By.CssSelector("._1LbR4")));

                                while ((respostaForCli = reader1.ReadLine()) != null)
                                {
                                    if (respostaForCli == "")
                                    {
                                        try
                                        {
                                            //send mensage btn
                                            driver.FindElement(By.ClassName("_4sWnG")).Click();
                                        }
                                        catch
                                        {
                                            continue;
                                        }
                                    }
                                    foreach (var e in respostaForCli)
                                    {
                                        IWebElement inputwhats = driver.FindElement(By.CssSelector("._1LbR4 > div:nth-child(2)"));
                                        inputwhats.SendKeys(Convert.ToString(e));
                                        Thread.Sleep(80);
                                    }

                                }
                                driver.FindElement(By.ClassName("_4sWnG")).Click();
                            }
                        }

                        

                    }

                    
                    

                }
            }
            catch
            {

            }
        }
        /////
        ///
        //update new table with numbers correct
        public static void NewFileComNumber(string cpf, string vlrSaqueMax, string vlrSaqueMin, string celular, string nome, string nomeCompleto)
        {
            String hourMinute = DateTime.Now.ToString("HH:mm");
            DateTime dateTime = DateTime.UtcNow.Date;
            var tableCsv = ConfigurationManager.AppSettings["caminho_text"] + "ClientesComNumValido.csv";
            using (StreamWriter file = new StreamWriter(tableCsv, true))
            {
                //MessageBox.Show("Your data has been saved." + result);

                file.WriteLine(cpf + "," + vlrSaqueMax + "," + vlrSaqueMin + "," + "55" + celular + "," + nome + "," + nomeCompleto + "," + dateTime.ToString("dd/MM/yyyy") + "," + hourMinute);
            }
        }
        // erase lines from csv
        public static void UpdateCSV(string Pstring)
        {
            var tableCpfLib = ConfigurationManager.AppSettings["caminho_text"] + "Cpfs_liberados.csv";
            string[] values = File.ReadAllLines(tableCpfLib);
            StreamWriter Writer = new StreamWriter(tableCpfLib);
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Contains(Pstring))
                    continue;
                Writer.WriteLine(values[i]);
            }

            Writer.Close();
        }

        public static void Erase_line(string celNumber)
        {
            string line = null;
            string line_to_delete = celNumber;

            var filTel = ConfigurationManager.AppSettings["caminho_text"] + "telefones.txt";
            using (StreamReader reader = new StreamReader(filTel))
            {
                using (StreamWriter writer = new StreamWriter(filTel))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, line_to_delete) == 0)
                            continue;

                        writer.WriteLine(line);
                    }
                }
            }
        }
        public static void Enviar_midia(string midia)
        {
            driver.FindElement(By.CssSelector("span[data-icon='clip']")).Click();
            IWebElement attach = driver.FindElement(By.CssSelector("input[type='file']"));

            attach.SendKeys(midia);
            Thread.Sleep(400);
            IWebElement send = driver.FindElement(By.CssSelector("._165_h"));
            send.Click();
            // driver.FindElement(By.CssSelector("._2x4bz > div:nth-child(2)")).Click();

            Thread.Sleep(6000);
        }
        public static void LoginInit()
        {
            var rlg = "";
            // FirefoxDriver();
            driver = new ChromeDriver();

            String link_url = "https://web.whatsapp.com/";

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Url = (link_url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            //.Until(e => e.FindElement(By.ClassName("side")));
            while (rlg == "")
            {
                IList<IWebElement> lg = driver.FindElements(By.Id("side"));
                foreach (var e in lg)
                {
                    rlg = e.Text;
                }

            }
        }
        // Generates a random number within a range.      
        public static int RandomNumber(int min, int max)
        {
            Frases.Nu1 = _random.Next(max);
            return _random.Next(min, max);
        }
        // recursive function
        public static void LerAquivo()
        {
            Frases.Es = 0;
            Frases.Ln = 0;
            Frases.LnBody = 0;
            //Frases.Delay = 0;
            string[] lines = new string[50];

            string[] lineBody = new string[500];

            

            var csvTable = new DataTable();
            var tableCpfLib = ConfigurationManager.AppSettings["caminho_text"] + "Cpfs_liberados.csv";
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(tableCpfLib)), true))
            {
                csvTable.Load(csvReader);
            }

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                ////// ---------- Init
                ///
                string fileConf = ConfigurationManager.AppSettings["caminho_opt"] + "config.txt";
                using (StreamReader opt = new StreamReader(fileConf, true))
                {
                    string num;
                    // read lines
                    while ((num = opt.ReadLine()) != null)
                    {
                        Frases.Nu1 = Convert.ToInt32(num);
                    }
                }

                
                ////////-----
                Frases.Cpf = csvTable.Rows[i][0].ToString();
                Frases.VlrSaqueMax = csvTable.Rows[i][1].ToString();
                Frases.VlrSaqueMin = csvTable.Rows[i][2].ToString();
                Frases.Celular = csvTable.Rows[i][3].ToString();
                Frases.Nome = csvTable.Rows[i][4].ToString();
                Frases.NomeCompleto = csvTable.Rows[i][5].ToString();

                Escuta();
                //Frases.Delay++;
                try
                {

                    driver.Url = ("https://web.whatsapp.com/send?phone=55" + Frases.Celular);
                    //driver.FindElement(By.CssSelector("#side > div.uwk68 > div > label > div > div._13NKt.copyable-text.selectable-text"));
                    try
                    {
                        var alert = driver.SwitchTo().Alert();
                        alert.Accept();
                       
                    }
                    catch (NoAlertPresentException)
                    {
                        
                    }
                    IWebElement inputwhats = driver.FindElement(By.CssSelector("._1LbR4 > div:nth-child(2)"));
                    
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    //wait.Until(e => e.FindElement(By.CssSelector("._1LbR4")));
                    //Thread.Sleep(200);
                    // input de mensagem                                        ""
                    RandomNumber(0, Frases.Nu1);
                    var filehead = ConfigurationManager.AppSettings["caminho_msg"] + "frHead" + Frases.Nu1 + ".txt";
                    using (StreamReader frase = File.OpenText(filehead))
                    {
                        string row;
                        while ((row = frase.ReadLine()) != null)
                        {
                            if (row == "")
                            {
                                driver.FindElement(By.ClassName("_4sWnG")).Click();
                            }
                            else if (row == "\r\n")
                            {
                                driver.FindElement(By.ClassName("_4sWnG")).Click();
                            }
                            foreach (char f in row.Replace("NOME", Frases.Nome))
                            {
                                inputwhats.SendKeys(Convert.ToString(f));
                                Thread.Sleep(80);

                            }

                            // send mensage
                            driver.FindElement(By.ClassName("_4sWnG")).Click();

                            //lines[Frases.Es] = row;
                            //Frases.Es++;
                        }
                    }

                                       
                    
                    inputwhats.Clear();

                    if (Frases.ContMidia[0] != null)
                    {
                        
                        for (int m = 0; m <= Frases.Midia; m++)
                        {
                            try
                            {
                                Enviar_midia(Frases.ContMidia[m]);
                                
                            }
                            catch
                            {
                                MessageBox.Show("Nao foi possivel enviar midia");
                            }
                        }
                    }
                    UpdateCSV(Frases.Cpf);
                    //Save file with valid numbers
                    NewFileComNumber(Frases.Cpf, Frases.VlrSaqueMax, Frases.VlrSaqueMin, Frases.Celular, Frases.Nome, Frases.NomeCompleto);
                    driver.Url = ("https://web.whatsapp.com/");
                    Thread.Sleep(Frases.Delay + 000);
                }
                catch
                {   // numero incorreto
                    UpdateCSV(Frases.Cpf);
                    driver.Url = ("https://web.whatsapp.com/");
                    String hourMinute = DateTime.Now.ToString("HH:mm");
                    var fileivalid = ConfigurationManager.AppSettings["caminho_text"] + "ClientesInvalidos.csv";
                    using (StreamWriter fileIn = new StreamWriter(fileivalid, true))
                    {
                        //MessageBox.Show("Your data has been saved." + result);

                        fileIn.WriteLine(Frases.Cpf + "," + Frases.VlrSaqueMax + "," + Frases.VlrSaqueMin + "," + Frases.Celular + "," + Frases.Nome + "," + hourMinute);
                    }

                }

                //if (Frases.Delay >= 1000)
                //{
                //    driver.Close();
                //    break;

                //}
            }
            /// LerArquivo
        }   
    }
}

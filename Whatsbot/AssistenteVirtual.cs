using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using ReadWritesvFile;
using WriteCsvR;
using System.Configuration;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using LumenWorks.Framework.IO.Csv;
using System.Data;

namespace Assistente
{
    public class Virtual
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;

        public static void FrasionaMsg(string valor)
        {
            IWebElement inputwhats = driver.FindElement(By.CssSelector("._1LbR4 > div:nth-child(2)"));
            
            foreach (var vl in valor)
            {
                inputwhats.SendKeys(Convert.ToString(vl));
                Thread.Sleep(80);
            }
            IWebElement sendBtn = driver.FindElement(By.ClassName("_4sWnG"));
            sendBtn.Click();
        }
        
        public static void Escuta(string cpf, string nomeCompleto, string vlrSaqueMax, string vlrsaqueMin)
        {
            

            int cont = 0;
            //string[] pst;
            var msg = "";
            var result = "";
            var nameContato = "";
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
                    result = msg.Substring(0, msg.IndexOf('$')).ToUpper();
                    //MessageBox.Show("Your data has been saved." + result);
                    //get the name of contate
                    IWebElement name = driver.FindElement(By.ClassName("_21nHd"));
                    nameContato = name.Text.Replace("+", "").Replace(" ", "").Replace("-", "");
                    var filepath = ConfigurationManager.AppSettings["caminho_Assist"] + "respostaAssist.txt";
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        string resposta;
                        while ((resposta = reader.ReadLine()) != null)
                        {
                            // salvar a mensagem do cliente
                            // comparar com msg resposta
                            
                            if (resposta.Contains(result))
                            {

                                // enviar resposta
                                var filerespCli = ConfigurationManager.AppSettings["caminho_Assist"] + "respostaPaCliAssist.txt";
                                using (StreamReader reader1 = new StreamReader(filerespCli))
                                {
                                    string respostaForCli;
                                    wait.Until(e => e.FindElement(By.CssSelector("._1LbR4")));


                                    while ((respostaForCli = reader1.ReadLine()) != null)
                                    {
                                        if (respostaForCli == "")
                                        {


                                            driver.FindElement(By.ClassName("_4sWnG")).Click();
                                        }
                                        FrasionaMsg(respostaForCli);
                                        
                                    }
                                    
                                }
                                //update clientes com interesse
                                var tableCsv = ConfigurationManager.AppSettings["caminho_Assist"] + "ClientesComNumValidoAssist.csv";
                                string[] values = File.ReadAllLines(tableCsv);

                                for (int a = 0; a < values.Length; a++)
                                {
                                    if (values[a].Contains(nameContato))
                                    {
                                        var filemsg = ConfigurationManager.AppSettings["caminho_Assist"] + "Clientesinteressados.csv";
                                        using (StreamWriter file = new StreamWriter(filemsg, true))
                                        {
                                            //MessageBox.Show("Your data has been saved." + result);

                                            file.WriteLine(values[a]);
                                        }
                                    }
                                    else { break; }

                                }


                            }
                            
                        }
                    }
                    //// second question
                    ///
                    if (result == nomeCompleto)
                    {

                        string tworesp = "Agora digite seu CPF (somente os números):";
                        FrasionaMsg(tworesp);
                        // save cli not interesting
                        var rsp2 = ConfigurationManager.AppSettings["caminho_Assist"] + "ClientesNaoInteressadosAssist.csv";
                        using (StreamWriter notInter = new StreamWriter(rsp2, true))
                        {
                            notInter.WriteLine(name.Text);
                        }
                                                
                    }
                    else if (result == cpf)
                    {
                        var filerespDiverg = ConfigurationManager.AppSettings["caminho_Assist"] + "msgDivergenteAssist.txt";
                        using (StreamReader reader1 = new StreamReader(filerespDiverg))
                        {
                            string respostaForCli = "Um momento, estou consultando. Em breve te informarei o valor disponível.";
                            // grade de msg
                            wait.Until(e => e.FindElement(By.CssSelector("._1LbR4")));

                            FrasionaMsg(respostaForCli);
                            
                            Thread.Sleep(3000);
                            string vlSaqMax = "O valor para saque disponível é de R$***, e o valor minimo é R$000";
                            string vl2 = vlSaqMax.Replace("***", vlrSaqueMax).Replace("000", vlrsaqueMin);
                            FrasionaMsg(vl2);
                            
                            string conf = "Vamos confirmar seu saque?";
                            FrasionaMsg(conf);
                            string dg1 = "Digite *1* para garantir o valor total agora!";
                            FrasionaMsg(dg1);
                            string dg2 = "Digite *2* para saque mínimo";
                            FrasionaMsg(dg2);
                            string dg3 = "Digite *3* para cancelar a operação";
                            FrasionaMsg(dg3);
                        }
                    }
                    else if(result == "1")
                    {
                        string qtSaq = "Excelente! Agora para formalizar o seu saque junto ao banco envie uma foto sua segurando seu documento de identidade ou CNH e foto *FRENTE* e *VERSO*.";
                        FrasionaMsg(qtSaq);
                    }
                    else if(result == "2")
                    {
                        string qtSaq = "Excelente! Agora para formalizar o seu saque junto ao banco envie uma foto sua segurando seu documento de identidade ou CNH e foto *FRENTE* e *VERSO*.";
                        FrasionaMsg(qtSaq);
                    }
                    else if(result == "3")
                    {
                        string qtSaq = "Operação cancelada com sucesso.";
                        FrasionaMsg(qtSaq);
                    }
                    else if(result == "")
                    {
                        try
                        {
                            driver.FindElement(By.ClassName("_1WrWf"));
                            string fin1 = "Perfeito! Sua documentação está em análise.";
                            string fin2 = "Em até 24 horas o valor estará disponível no seu cartão BMG Card.";
                            FrasionaMsg(fin1);
                            FrasionaMsg(fin2);
                        }
                        catch { MessageBox.Show("Não foi possivel finalizar"); }
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
            var tableCsv = ConfigurationManager.AppSettings["caminho_Assist"] + "ClientesComNumValidoAssist.csv";
            using (StreamWriter file = new StreamWriter(tableCsv, true))
            {
                //MessageBox.Show("Your data has been saved." + result);

                file.WriteLine(cpf + "," + vlrSaqueMax + "," + vlrSaqueMin + "," + "55" + celular + "," + nome + "," + nomeCompleto);
            }
        }
        // erase lines from csv
        public static void UpdateCSV(string Pstring)
        {
            var tableCpfLib = ConfigurationManager.AppSettings["caminho_Assist"] + "Clientesinteressados.csv";

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
            
            var filTel = ConfigurationManager.AppSettings["caminho_Assist"] + "telefonesAssist.txt";
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
            IWebElement send = driver.FindElement(By.CssSelector(".SncVf"));
            send.Click();
            driver.FindElement(By.CssSelector("._2x4bz > div:nth-child(2)")).Click();

            Thread.Sleep(6000);
        }
        public static void LoginInit()
        {
            var rlg = "";
            driver = new FirefoxDriver();

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

        // recursive function
        public static void LerAquivo()
        {
            
            Frases.Es = 0;
            Frases.Ln = 0;
            Frases.LnBody = 0;
            int Delay = Frases.Delay;
            string[] lines = new string[70];

            string[] lineBody = new string[500];

            var filehead = ConfigurationManager.AppSettings["caminho_Assist"] + "frHeadAssist.txt";
            using (StreamReader frase = File.OpenText(filehead))
            {
                string row;
                while ((row = frase.ReadLine()) != null)
                {

                    lines[Frases.Es] = row;
                    Frases.Es++;
                }
            }
            
            var tableCpfLib = ConfigurationManager.AppSettings["caminho_Assist"] + "Clientesinteressados.csv";
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(tableCpfLib)), true))
            {
                csvTable.Load(csvReader);
            }

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                Frases.Cpf = csvTable.Rows[i][0].ToString();
                Frases.VlrSaqueMax = csvTable.Rows[i][1].ToString();
                Frases.VlrSaqueMin = csvTable.Rows[i][2].ToString();
                Frases.Celular = csvTable.Rows[i][3].ToString();
                Frases.Nome = csvTable.Rows[i][4].ToString();
                Frases.NomeCompleto = csvTable.Rows[i][5].ToString();

                Escuta(Frases.Cpf, Frases.NomeCompleto, Frases.VlrSaqueMax, Frases.VlrSaqueMin);
                try
                {
                    driver.Url = ("https://web.whatsapp.com/send?phone=" + Frases.Celular);

                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    //wait.Until(e => e.FindElement(By.CssSelector("._1LbR4")));
                    //Thread.Sleep(200);
                    // input de mensagem                                        ""


                    // send mensage
                    if (Frases.Ln >= Frases.Es)
                    {
                        Frases.Ln = 0;
                    }
                    //string frinicial = "Olá *NOME*, sou a Paula, a atendente virtual da Prime Promotora, correspondente bancário do Banco BMG.";
                    IWebElement inputwhats = driver.FindElement(By.CssSelector("._1LbR4 > div:nth-child(2)"));
                    
                    foreach (var f in lines[Frases.Ln].Replace("NOME", Frases.Nome))
                    {
                        inputwhats.SendKeys(Convert.ToString(f));
                        Thread.Sleep(80);

                    }
                    
                    // send mensage
                    driver.FindElement(By.ClassName("_4sWnG")).Click();

                    Frases.Ln++;
                    // body of mensages
                    var filebody = ConfigurationManager.AppSettings["caminho_Assist"] + "frBodyAssist.txt";
                    using (StreamReader fr = File.OpenText(filebody))
                    {
                        string row;
                        while ((row = fr.ReadLine()) != null)
                        {
                            /* envia uma row por vez */

                            if (row == "")
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

                            foreach (var e in row)
                            {
                                inputwhats.SendKeys(Convert.ToString(e));
                                Thread.Sleep(80);
                            }
                            //lineBody[Frases.lnBody] = row;
                            //Frases.lnBody ++;
                        }
                        //send mensage btn
                        driver.FindElement(By.ClassName("_4sWnG")).Click();

                    }
                    inputwhats.Clear();

                    //if (Frases.ContMidia[0] != null)
                    //{
                    //    for (int m = 0; m <= Frases.Midia; m++)
                    //    {
                    //        try
                    //        {
                    //            Enviar_midia(Frases.ContMidia[m]);
                    //        }
                    //        catch
                    //        {
                    //            MessageBox.Show("Nao foi possivel enviar midia");
                    //        }
                    //    }
                    //}

                    NewFileComNumber(Frases.Cpf, Frases.VlrSaqueMax, Frases.VlrSaqueMin, Frases.Celular, Frases.Nome, Frases.NomeCompleto);
                    UpdateCSV(Frases.Cpf);
                    driver.Url = ("https://web.whatsapp.com/");
                    //Thread.Sleep(Delay + 000);
                }
                catch
                {   // numero incorreto
                    UpdateCSV(Frases.Cpf);
                    driver.Url = ("https://web.whatsapp.com/");
                    var fileivalid = ConfigurationManager.AppSettings["caminho_Assist"] + "ClientesInvalidosAssist.csv";
                    using (StreamWriter fileIn = new StreamWriter(fileivalid, true))
                    {
                        //MessageBox.Show("Your data has been saved." + result);

                        fileIn.WriteLine(Frases.Cpf + "," + Frases.VlrSaqueMax + "," + Frases.VlrSaqueMin + "," + Frases.Celular + "," + Frases.Nome + "," + Frases.NomeCompleto);
                    }

                }
            }

            // LerArquivo
        }

    }
}

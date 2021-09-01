using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using WhatsSite;
using ReadWritesvFile;
using System.Configuration;


namespace Whatsbot
{
    public partial class FrmChatFunction : Form
    {
        private OpenFileDialog ofd;
        public static string docFileName;
       
        private readonly string fileBody = ConfigurationManager.AppSettings["caminho_text"] + "frBody.txt";
        private readonly string fileTel = ConfigurationManager.AppSettings["caminho_text"] + "telefones.txt";
        private readonly string fileConf = ConfigurationManager.AppSettings["caminho_opt"] + "config.txt";
        string filehead = ConfigurationManager.AppSettings["caminho_msg"] + "frHead.txt";
        public FrmChatFunction()
        {
            InitializeComponent();
        }

        
        private void BtSvHead_Click(object sender, EventArgs e)
        {
            // open file conf num
            
            
            using (StreamReader opt = new StreamReader(fileConf, true))
            {
                string num;
                // read lines
                while ((num = opt.ReadLine()) != null)
                {
                    // open file of msgs
                    string filehea = ConfigurationManager.AppSettings["caminho_msg"] + "frHead"+ num +".txt";
                    using (StreamWriter file = new StreamWriter(filehea, true))
                    {
                        string msghead = txtIniHead.Text;
                        // save msg head
                        file.WriteLine(msghead);
                        //MessageBox.Show("Your data has been saved.");
                        txtIniHead.Clear();
                        // add +1 ao nu
                        Frases.Nu = Convert.ToInt32(num);
                        Frases.Nu++;   
                    }

                }
            }
            // delete file
            File.Delete(fileConf);
            // create new file if num
            using (StreamWriter flOp = new StreamWriter(fileConf, true))
            {
                flOp.WriteLine(Frases.Nu);
            }

        }
        //private void BtSavesgInit_Click(object sender, EventArgs e)
        //{
        //    using (StreamWriter file = new StreamWriter(fileBody, true))
        //    {
        //        string msginit = txtMsgInit.Text;
        //        file.WriteLine(msginit);
        //        //MessageBox.Show("Your data has been saved.");
        //        txtMsgInit.Clear();
        //    }
        //}

       

        private void FrmChatFunction_Load(object sender, EventArgs e)
        {
            richTextBox.Enabled = false;
            //CheckForIllegalCrossThreadCalls = false;
           
        }

        

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Enabled = true;
            ofd = new OpenFileDialog();
            //ofd.Filter = "Text files (.txt)|*.tx";
            ofd.Title = "Open File";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Clear();
                this.richTextBox.Text = File.ReadAllText(ofd.FileName);
                this.Text = ofd.FileName;
                docFileName = ofd.FileName;
                //StreamReader sr = new StreamReader(ofd.FileName);
                //{
                //    richTextBox.Text = sr.ReadToEnd();
                //    sr.Close();
                //}
            }
        }
        private void SalvarArquivo(String arquivo)
        {
            try
            {
                if (arquivo != "")
                {
                    StreamWriter buffer = new StreamWriter(arquivo);
                    buffer.Write(richTextBox.Text);
                    buffer.Close();
                    richTextBox.Clear();
                    richTextBox.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Endereço de Arquivo não Validado", "salvarArquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ofd = null;
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo(docFileName);
           
        }

        private void BtRomove_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            richTextBox.Enabled = false;
        }

        private void BtConfigMsg_Click(object sender, EventArgs e)
        {
            FrmOptResp f = new FrmOptResp();
            f.ShowDialog();
            f.Dispose();
        }
        private void OpenDifFiles(string arq)
        {
            richTextBox.Clear();
            richTextBox.Enabled = true;
            this.richTextBox.Text = File.ReadAllText(arq);
            this.Text = arq;
            docFileName = arq;
        }

        private void MensagemDeApresentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDifFiles(filehead);
        }

        private void MensagemDeConteudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDifFiles(fileBody);
        }

        private void ListaDeTelefonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDifFiles(fileTel);
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            //var fileTel = ConfigurationManager.AppSettings["caminho_text"] + "telefones.txt";

            Frases.Delay = SelDelay.SelectedIndex;
            // MessageBox.Show("Aqui po " + Frases.Delay);
            WebScrap.LoginInit();
            WebScrap.LerAquivo();
        }
    }
}

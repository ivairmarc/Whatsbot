using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Assistente;
namespace Whatsbot
{
    public partial class FrmAssistenteConfig : Form
    {
        private OpenFileDialog ofd;
        public static string docFileName;
        private readonly string filehead = ConfigurationManager.AppSettings["caminho_Assist"] + "frHeadAssist.txt";
        private readonly string fileBody = ConfigurationManager.AppSettings["caminho_Assist"] + "frBodyAssist.txt";
        public FrmAssistenteConfig()
        {
            InitializeComponent();
        }

        private void BtSvHead_Click(object sender, EventArgs e)
        {


            using (StreamWriter file = new StreamWriter(filehead, true))
            {
                string msghead = txtIniHead.Text;
                file.WriteLine(msghead);
                //MessageBox.Show("Your data has been saved.");
                txtIniHead.Clear();

            }
        }

        private void BtSavesgInit_Click(object sender, EventArgs e)
        {

            using (StreamWriter file = new StreamWriter(fileBody, true))
            {
                string msginit = txtMsgInit.Text;
                file.WriteLine(msginit);
                //MessageBox.Show("Your data has been saved.");
                txtMsgInit.Clear();
            }
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            //Frases.Delay = SelDelay.SelectedIndex;
            // MessageBox.Show("Aqui po " + Frases.Delay);
            Virtual.LoginInit();
            Virtual.LerAquivo();
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

        private void BtConfigMsg_Click(object sender, EventArgs e)
        {
            FrmAssistResposta f = new FrmAssistResposta();
            f.ShowDialog();
            f.Dispose();
        }

        private void BtRomove_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            richTextBox.Enabled = false;
        }
    }
}
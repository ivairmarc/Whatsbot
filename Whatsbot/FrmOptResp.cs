using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadWritesvFile;
using WriteCsvR;

namespace Whatsbot
{
    public partial class FrmOptResp : Form
    {
        public static int qt = 0;
        public FrmOptResp()
        {
            InitializeComponent();
        }

        private void BtSvResPrCl_Click(object sender, EventArgs e)
        {
            var filepath = ConfigurationManager.AppSettings["caminho_text"] + "resposta.txt";
            using (StreamWriter file = new StreamWriter(filepath, true))
            {
                string resp = txtprCli.Text;
                file.WriteLine(resp);
                //MessageBox.Show("Your data has been saved.");
                txtMsgResp.Clear();

            }
        }

        private void BtSaveResp_Click(object sender, EventArgs e)
        {
            var filepath = ConfigurationManager.AppSettings["caminho_text"] + "respostaPaCli.txt";
            using (StreamWriter file = new StreamWriter(@filepath, true))
            {
                string resp = txtMsgResp.Text;
                file.WriteLine(resp);
                //MessageBox.Show("Your data has been saved.");
                txtMsgResp.Clear();
            }
        }

        private void BtAddFiles_Click(object sender, EventArgs e)
        {
            
             
            var anexo = new OpenFileDialog();
            anexo.Title = "Anexar arquivos";
            if (anexo.ShowDialog() == DialogResult.OK)
            {
                lblCamiFiles.Text = anexo.FileName;
                Frases.Midia = qt;
                Frases.ContMidia[qt] = lblCamiFiles.Text;
                qt++;
                
            }

            //string caminhoArquivo = ConfigurationManager.AppSettings["caminho_arquivos"];

            //string origem = anexo.FileName;
            //string destino = string.Concat(caminhoArquivo, Path.GetFileName(origem));

            //File.Copy(origem, destino);
            ////Directory.GetFiles(caminhoArquivo);
        }
    }
}

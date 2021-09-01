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
    public partial class FrmAssistResposta : Form
    {
        public FrmAssistResposta()
        {
            InitializeComponent();
        }

        private void BtSvResPrCl_Click(object sender, EventArgs e)
        {
            var filepath = ConfigurationManager.AppSettings["caminho_Assist"] + "respostaAssist.txt";
            using (StreamWriter file = new StreamWriter(filepath, true))
            {
                string resp = txtprCli.Text;
                file.WriteLine(resp);
                //MessageBox.Show("Your data has been saved.");
                txtMsgResp.Clear();
            }
        }

        private void btSaveResp_Click(object sender, EventArgs e)
        {
            var filepath = ConfigurationManager.AppSettings["caminho_Assist"] + "respostaPaCliAssist.txt";
            using (StreamWriter file = new StreamWriter(@filepath, true))
            {
                string resp = txtMsgResp.Text;
                file.WriteLine(resp);
                //MessageBox.Show("Your data has been saved.");
                txtMsgResp.Clear();
            }
        }
    }
}

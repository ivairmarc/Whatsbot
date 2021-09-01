using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadWritesvFile;
using System.Configuration;

namespace Whatsbot
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void BtAdcionar_Click(object sender, EventArgs e)
        {
            var fileTel = ConfigurationManager.AppSettings["caminho_text"] + "telefones.txt";
           
            using (StreamWriter file = new StreamWriter(@fileTel, true))
            {
                string resp = listTel.Text;
                file.WriteLine(resp);
                //MessageBox.Show("Your data has been saved.");
                listTel.Clear();
            }
        }

        private void BtImport_Click(object sender, EventArgs e)
        {
            //richTextBox.Enabled = true;
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Text files (.txt)|*.tx";
            ofd.Title = "Open File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listTel.Clear();
                StreamReader sr = new StreamReader(ofd.FileName);
                {
                    listTel.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }
    }
}

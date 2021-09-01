using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Whatsbot
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            var filemsg = ConfigurationManager.AppSettings["caminho_Assist"] + "Clientesinteressados.csv";
            StreamReader csv = new StreamReader(filemsg);
            string linha;
            string[] campo;

            while ((linha = csv.ReadLine()) != null)
            {

                campo = linha.Split(',');
                dataGridView1.Rows.Add(campo);

            }
        }

        private void Btsave_Click(object sender, EventArgs e)
        {

        }
    }
}

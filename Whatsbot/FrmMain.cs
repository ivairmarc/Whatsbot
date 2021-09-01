using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using FontAwesome.Sharp;

namespace Whatsbot
{
    public partial class FrmMain : Form
    {
        private IconButton currentButton;
        private Form activeForm;
        private string datevalid = "05/09/2021";

        public FrmMain()
        {
            InitializeComponent();

            // form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(95, 77, 221);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Transparent;
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void ValidaDate() { 
        }
        private void Pnmenutop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;

        }

        private void BtChat_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now.Date;
            DateTime outraData = Convert.ToDateTime(datevalid);
            if (data >= outraData)
            {
                MessageBox.Show("Sua Licença expirou.");
            }
            else
            {
                ActivateButton(sender, RGBColors.color2);
                OpenChildForm(new FrmChatFunction(), sender);
            }
            
        }

        private void PtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PtMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtmenuTop_Click(object sender, EventArgs e)
        {
            if (pnLeft.Width == 119)
            {
                pnLeft.Width = 35;
            }
            else
            {
                pnLeft.Width = 119;
            }
        }

        private void Btlist_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now.Date;
            DateTime outraData = Convert.ToDateTime(datevalid);
            if (data >= outraData)
            {
                MessageBox.Show("Sua Licença expirou.");
            }
            else 
            {
                ActivateButton(sender, RGBColors.color3);
                OpenChildForm(new FrmConfig(), sender);
            }
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var pathFiles = ConfigurationManager.AppSettings["caminho_arquivos"];
            if (System.IO.Directory.Exists(pathFiles))
            {
                string[] files = System.IO.Directory.GetFiles(pathFiles);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    if (System.IO.File.Exists(s))
                    {
                        // Use a try block to catch IOExceptions, to
                        // handle the case of the file already being
                        // opened by another process.
                        try
                        {
                            System.IO.File.Delete(pathFiles + files);
                        }
                        catch (System.IO.IOException er)
                        {
                            Console.WriteLine(er.Message);
                            return;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
        }

        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmList(), sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now.Date;
            DateTime outraData = Convert.ToDateTime(datevalid);
            if (data >= outraData)
            {
                MessageBox.Show("Sua Licença expirou.");
            }
            else
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new FrmAssistenteConfig(), sender);
            }
            

        }
    }
}

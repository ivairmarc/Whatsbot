
namespace Whatsbot
{
    partial class FrmConfigMensagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnmenutop = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnmenutop
            // 
            this.pnmenutop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.pnmenutop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnmenutop.Location = new System.Drawing.Point(115, 0);
            this.pnmenutop.Name = "pnmenutop";
            this.pnmenutop.Size = new System.Drawing.Size(880, 30);
            this.pnmenutop.TabIndex = 4;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(995, 533);
            this.pnMain.TabIndex = 3;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(115, 533);
            this.pnLeft.TabIndex = 2;
            // 
            // FrmConfigMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 533);
            this.Controls.Add(this.pnmenutop);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnMain);
            this.Name = "FrmConfigMensagem";
            this.Text = "FrmConfigMensagem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnmenutop;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnLeft;
    }
}
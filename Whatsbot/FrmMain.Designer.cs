
namespace Whatsbot
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnmenutop = new System.Windows.Forms.Panel();
            this.btmenuTop = new FontAwesome.Sharp.IconButton();
            this.ptMin = new System.Windows.Forms.PictureBox();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btlist = new FontAwesome.Sharp.IconButton();
            this.btChat = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnmenutop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnmenutop
            // 
            this.pnmenutop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.pnmenutop.Controls.Add(this.btmenuTop);
            this.pnmenutop.Controls.Add(this.ptMin);
            this.pnmenutop.Controls.Add(this.ptClose);
            this.pnmenutop.Controls.Add(this.lbTitle);
            this.pnmenutop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnmenutop.Location = new System.Drawing.Point(0, 0);
            this.pnmenutop.Name = "pnmenutop";
            this.pnmenutop.Size = new System.Drawing.Size(800, 30);
            this.pnmenutop.TabIndex = 1;
            this.pnmenutop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnmenutop_MouseDown);
            // 
            // btmenuTop
            // 
            this.btmenuTop.BackgroundImage = global::Whatsbot.Properties.Resources.menu;
            this.btmenuTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmenuTop.FlatAppearance.BorderSize = 0;
            this.btmenuTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmenuTop.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btmenuTop.IconColor = System.Drawing.Color.Black;
            this.btmenuTop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btmenuTop.Location = new System.Drawing.Point(12, 6);
            this.btmenuTop.Name = "btmenuTop";
            this.btmenuTop.Size = new System.Drawing.Size(20, 18);
            this.btmenuTop.TabIndex = 0;
            this.btmenuTop.UseVisualStyleBackColor = true;
            this.btmenuTop.Click += new System.EventHandler(this.BtmenuTop_Click);
            // 
            // ptMin
            // 
            this.ptMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptMin.Image = global::Whatsbot.Properties.Resources.min;
            this.ptMin.Location = new System.Drawing.Point(750, 9);
            this.ptMin.Name = "ptMin";
            this.ptMin.Size = new System.Drawing.Size(16, 15);
            this.ptMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptMin.TabIndex = 2;
            this.ptMin.TabStop = false;
            this.ptMin.Click += new System.EventHandler(this.PtMin_Click);
            // 
            // ptClose
            // 
            this.ptClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptClose.Image = global::Whatsbot.Properties.Resources.close;
            this.ptClose.Location = new System.Drawing.Point(772, 9);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(15, 15);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 1;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.PtClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(43, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(201, 15);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Home";
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnLeft.Controls.Add(this.iconButton3);
            this.pnLeft.Controls.Add(this.iconButton2);
            this.pnLeft.Controls.Add(this.iconButton1);
            this.pnLeft.Controls.Add(this.btlist);
            this.pnLeft.Controls.Add(this.btChat);
            this.pnLeft.Controls.Add(this.panel1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 30);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(115, 420);
            this.pnLeft.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Diagnoses;
            this.iconButton3.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 236);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton3.Size = new System.Drawing.Size(115, 30);
            this.iconButton3.TabIndex = 7;
            this.iconButton3.Text = "Relatório";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Android;
            this.iconButton2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 206);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton2.Size = new System.Drawing.Size(115, 30);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Text = "Assistente";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 173);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton1.Size = new System.Drawing.Size(115, 33);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Config";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btlist
            // 
            this.btlist.BackColor = System.Drawing.Color.Transparent;
            this.btlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btlist.FlatAppearance.BorderSize = 0;
            this.btlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlist.ForeColor = System.Drawing.Color.Transparent;
            this.btlist.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btlist.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btlist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btlist.IconSize = 30;
            this.btlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlist.Location = new System.Drawing.Point(0, 140);
            this.btlist.Name = "btlist";
            this.btlist.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btlist.Size = new System.Drawing.Size(115, 33);
            this.btlist.TabIndex = 3;
            this.btlist.Text = "Lista";
            this.btlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btlist.UseVisualStyleBackColor = false;
            this.btlist.Click += new System.EventHandler(this.Btlist_Click);
            // 
            // btChat
            // 
            this.btChat.BackColor = System.Drawing.Color.Transparent;
            this.btChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btChat.FlatAppearance.BorderSize = 0;
            this.btChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChat.ForeColor = System.Drawing.Color.Transparent;
            this.btChat.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.btChat.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btChat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btChat.IconSize = 30;
            this.btChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChat.Location = new System.Drawing.Point(0, 110);
            this.btChat.Name = "btChat";
            this.btChat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btChat.Size = new System.Drawing.Size(115, 30);
            this.btChat.TabIndex = 4;
            this.btChat.Text = "Chat";
            this.btChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btChat.UseVisualStyleBackColor = false;
            this.btChat.Click += new System.EventHandler(this.BtChat_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Whatsbot.Properties.Resources.Prancheta_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 110);
            this.panel1.TabIndex = 2;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BackgroundImage = global::Whatsbot.Properties.Resources.WhatsApp_Image_2021_07_28_at_17_57_16;
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(800, 450);
            this.pnMain.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnmenutop);
            this.Controls.Add(this.pnMain);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmMain";
            this.Opacity = 0.97D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnmenutop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnmenutop;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btChat;
        private FontAwesome.Sharp.IconButton btlist;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox ptClose;
        private System.Windows.Forms.PictureBox ptMin;
        private FontAwesome.Sharp.IconButton btmenuTop;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}


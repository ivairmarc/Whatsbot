
namespace Whatsbot
{
    partial class FrmAssistenteConfig
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
            this.components = new System.ComponentModel.Container();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemDeApresentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemDeConteudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTelefonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelDelay = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSvHead = new System.Windows.Forms.Button();
            this.txtIniHead = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.txtMsgInit = new System.Windows.Forms.TextBox();
            this.BtSavesgInit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtIniciar = new System.Windows.Forms.Button();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnMain = new System.Windows.Forms.Panel();
            this.BtRomove = new FontAwesome.Sharp.IconButton();
            this.BtConfigMsg = new FontAwesome.Sharp.IconButton();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmChatFunctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmChatFunctionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.mensagemDeApresentaçãoToolStripMenuItem,
            this.mensagemDeConteudoToolStripMenuItem,
            this.listaDeTelefonesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // mensagemDeApresentaçãoToolStripMenuItem
            // 
            this.mensagemDeApresentaçãoToolStripMenuItem.Name = "mensagemDeApresentaçãoToolStripMenuItem";
            this.mensagemDeApresentaçãoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.mensagemDeApresentaçãoToolStripMenuItem.Text = "Mensagem de apresentação";
            this.mensagemDeApresentaçãoToolStripMenuItem.Click += new System.EventHandler(this.MensagemDeApresentaçãoToolStripMenuItem_Click);
            // 
            // mensagemDeConteudoToolStripMenuItem
            // 
            this.mensagemDeConteudoToolStripMenuItem.Name = "mensagemDeConteudoToolStripMenuItem";
            this.mensagemDeConteudoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.mensagemDeConteudoToolStripMenuItem.Text = "Mensagem de Conteúdo";
            this.mensagemDeConteudoToolStripMenuItem.Click += new System.EventHandler(this.MensagemDeConteudoToolStripMenuItem_Click);
            // 
            // listaDeTelefonesToolStripMenuItem
            // 
            this.listaDeTelefonesToolStripMenuItem.Name = "listaDeTelefonesToolStripMenuItem";
            this.listaDeTelefonesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.listaDeTelefonesToolStripMenuItem.Text = "Lista de telefones";
            // 
            // SelDelay
            // 
            this.SelDelay.Items.Add("10");
            this.SelDelay.Items.Add("20");
            this.SelDelay.Items.Add("30");
            this.SelDelay.Items.Add("40");
            this.SelDelay.Items.Add("50");
            this.SelDelay.Items.Add("60");
            this.SelDelay.Items.Add("80");
            this.SelDelay.Items.Add("90");
            this.SelDelay.Location = new System.Drawing.Point(385, 55);
            this.SelDelay.Name = "SelDelay";
            this.SelDelay.Size = new System.Drawing.Size(32, 20);
            this.SelDelay.TabIndex = 29;
            this.SelDelay.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Delay entre Numeros:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Header";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Body";
            // 
            // btSvHead
            // 
            this.btSvHead.BackColor = System.Drawing.Color.SlateGray;
            this.btSvHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSvHead.Location = new System.Drawing.Point(340, 350);
            this.btSvHead.Name = "btSvHead";
            this.btSvHead.Size = new System.Drawing.Size(75, 25);
            this.btSvHead.TabIndex = 25;
            this.btSvHead.Text = "Salvar";
            this.btSvHead.UseVisualStyleBackColor = false;
            this.btSvHead.Click += new System.EventHandler(this.BtSvHead_Click);
            // 
            // txtIniHead
            // 
            this.txtIniHead.Location = new System.Drawing.Point(152, 316);
            this.txtIniHead.Multiline = true;
            this.txtIniHead.Name = "txtIniHead";
            this.txtIniHead.Size = new System.Drawing.Size(263, 28);
            this.txtIniHead.TabIndex = 24;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(148, 81);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(549, 167);
            this.richTextBox.TabIndex = 20;
            this.richTextBox.Text = "";
            // 
            // txtMsgInit
            // 
            this.txtMsgInit.Location = new System.Drawing.Point(421, 316);
            this.txtMsgInit.Multiline = true;
            this.txtMsgInit.Name = "txtMsgInit";
            this.txtMsgInit.Size = new System.Drawing.Size(263, 62);
            this.txtMsgInit.TabIndex = 18;
            // 
            // BtSavesgInit
            // 
            this.BtSavesgInit.BackColor = System.Drawing.Color.SlateGray;
            this.BtSavesgInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSavesgInit.Location = new System.Drawing.Point(607, 381);
            this.BtSavesgInit.Name = "BtSavesgInit";
            this.BtSavesgInit.Size = new System.Drawing.Size(75, 23);
            this.BtSavesgInit.TabIndex = 14;
            this.BtSavesgInit.Text = "Salvar";
            this.BtSavesgInit.UseVisualStyleBackColor = false;
            this.BtSavesgInit.Click += new System.EventHandler(this.BtSavesgInit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mensagem Inicial";
            // 
            // BtIniciar
            // 
            this.BtIniciar.BackColor = System.Drawing.Color.SlateGray;
            this.BtIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIniciar.Location = new System.Drawing.Point(622, 254);
            this.BtIniciar.Name = "BtIniciar";
            this.BtIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtIniciar.TabIndex = 6;
            this.BtIniciar.Text = "Iniciar";
            this.BtIniciar.UseVisualStyleBackColor = false;
            this.BtIniciar.Click += new System.EventHandler(this.BtIniciar_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.OpenToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(148, 54);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(84, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.DimGray;
            this.pnMain.Controls.Add(this.SelDelay);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.label5);
            this.pnMain.Controls.Add(this.label4);
            this.pnMain.Controls.Add(this.btSvHead);
            this.pnMain.Controls.Add(this.txtIniHead);
            this.pnMain.Controls.Add(this.richTextBox);
            this.pnMain.Controls.Add(this.txtMsgInit);
            this.pnMain.Controls.Add(this.BtSavesgInit);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.BtIniciar);
            this.pnMain.Controls.Add(this.BtRomove);
            this.pnMain.Controls.Add(this.BtConfigMsg);
            this.pnMain.Controls.Add(this.menuStrip1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(800, 450);
            this.pnMain.TabIndex = 1;
            // 
            // BtRomove
            // 
            this.BtRomove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtRomove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRomove.ForeColor = System.Drawing.Color.White;
            this.BtRomove.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtRomove.IconColor = System.Drawing.Color.Black;
            this.BtRomove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtRomove.Location = new System.Drawing.Point(629, 48);
            this.BtRomove.Name = "BtRomove";
            this.BtRomove.Size = new System.Drawing.Size(67, 27);
            this.BtRomove.TabIndex = 5;
            this.BtRomove.Text = "Remover";
            this.BtRomove.UseVisualStyleBackColor = false;
            this.BtRomove.Click += new System.EventHandler(this.BtRomove_Click);
            // 
            // BtConfigMsg
            // 
            this.BtConfigMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtConfigMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConfigMsg.ForeColor = System.Drawing.Color.White;
            this.BtConfigMsg.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtConfigMsg.IconColor = System.Drawing.Color.Black;
            this.BtConfigMsg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtConfigMsg.Location = new System.Drawing.Point(435, 48);
            this.BtConfigMsg.Name = "BtConfigMsg";
            this.BtConfigMsg.Size = new System.Drawing.Size(174, 27);
            this.BtConfigMsg.TabIndex = 1;
            this.BtConfigMsg.Text = "Configurar Mensagem do Menu";
            this.BtConfigMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConfigMsg.UseVisualStyleBackColor = false;
            this.BtConfigMsg.Click += new System.EventHandler(this.BtConfigMsg_Click);
            // 
            // FrmAssistenteConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMain);
            this.Name = "FrmAssistenteConfig";
            this.Text = "FrmAssistenteConfig";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmChatFunctionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagemDeApresentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagemDeConteudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeTelefonesToolStripMenuItem;
        private System.Windows.Forms.DomainUpDown SelDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSvHead;
        private System.Windows.Forms.TextBox txtIniHead;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox txtMsgInit;
        private System.Windows.Forms.Button BtSavesgInit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtIniciar;
        private System.Windows.Forms.BindingSource programBindingSource;
        private FontAwesome.Sharp.IconButton BtRomove;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private FontAwesome.Sharp.IconButton BtConfigMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource frmChatFunctionBindingSource;
        private System.Windows.Forms.Panel pnMain;
    }
}
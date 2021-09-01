
namespace Whatsbot
{
    partial class FrmChatFunction
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.SelDelay = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSvHead = new System.Windows.Forms.Button();
            this.txtIniHead = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtIniciar = new System.Windows.Forms.Button();
            this.btRomove = new FontAwesome.Sharp.IconButton();
            this.btConfigMsg = new FontAwesome.Sharp.IconButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemDeApresentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemDeConteudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTelefonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmChatFunctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmChatFunctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.DimGray;
            this.pnMain.Controls.Add(this.SelDelay);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.label5);
            this.pnMain.Controls.Add(this.btSvHead);
            this.pnMain.Controls.Add(this.txtIniHead);
            this.pnMain.Controls.Add(this.richTextBox);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.BtIniciar);
            this.pnMain.Controls.Add(this.btRomove);
            this.pnMain.Controls.Add(this.btConfigMsg);
            this.pnMain.Controls.Add(this.menuStrip1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(800, 450);
            this.pnMain.TabIndex = 0;
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
            this.label5.Location = new System.Drawing.Point(149, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Header";
            // 
            // btSvHead
            // 
            this.btSvHead.BackColor = System.Drawing.Color.SlateGray;
            this.btSvHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSvHead.Location = new System.Drawing.Point(629, 413);
            this.btSvHead.Name = "btSvHead";
            this.btSvHead.Size = new System.Drawing.Size(75, 25);
            this.btSvHead.TabIndex = 25;
            this.btSvHead.Text = "Salvar +";
            this.btSvHead.UseVisualStyleBackColor = false;
            this.btSvHead.Click += new System.EventHandler(this.BtSvHead_Click);
            // 
            // txtIniHead
            // 
            this.txtIniHead.Location = new System.Drawing.Point(152, 293);
            this.txtIniHead.Multiline = true;
            this.txtIniHead.Name = "txtIniHead";
            this.txtIniHead.Size = new System.Drawing.Size(471, 145);
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 259);
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
            // btRomove
            // 
            this.btRomove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btRomove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRomove.ForeColor = System.Drawing.Color.White;
            this.btRomove.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btRomove.IconColor = System.Drawing.Color.Black;
            this.btRomove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRomove.Location = new System.Drawing.Point(629, 48);
            this.btRomove.Name = "btRomove";
            this.btRomove.Size = new System.Drawing.Size(67, 27);
            this.btRomove.TabIndex = 5;
            this.btRomove.Text = "Remover";
            this.btRomove.UseVisualStyleBackColor = false;
            this.btRomove.Click += new System.EventHandler(this.BtRomove_Click);
            // 
            // btConfigMsg
            // 
            this.btConfigMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btConfigMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfigMsg.ForeColor = System.Drawing.Color.White;
            this.btConfigMsg.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btConfigMsg.IconColor = System.Drawing.Color.Black;
            this.btConfigMsg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btConfigMsg.Location = new System.Drawing.Point(435, 48);
            this.btConfigMsg.Name = "btConfigMsg";
            this.btConfigMsg.Size = new System.Drawing.Size(174, 27);
            this.btConfigMsg.TabIndex = 1;
            this.btConfigMsg.Text = "Configurar Resposta e anexo";
            this.btConfigMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfigMsg.UseVisualStyleBackColor = false;
            this.btConfigMsg.Click += new System.EventHandler(this.BtConfigMsg_Click);
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
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.OpenToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
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
            this.listaDeTelefonesToolStripMenuItem.Click += new System.EventHandler(this.ListaDeTelefonesToolStripMenuItem_Click);
            // 
            // FrmChatFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMain);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmChatFunction";
            this.Opacity = 0.8D;
            this.Text = "Chat settings";
            this.Load += new System.EventHandler(this.FrmChatFunction_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmChatFunctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private FontAwesome.Sharp.IconButton btRomove;
        private FontAwesome.Sharp.IconButton btConfigMsg;
        private System.Windows.Forms.Button BtIniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource frmChatFunctionBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.TextBox txtIniHead;
        private System.Windows.Forms.Button btSvHead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown SelDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mensagemDeApresentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagemDeConteudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeTelefonesToolStripMenuItem;
    }
}
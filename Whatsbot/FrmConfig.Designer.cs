
namespace Whatsbot
{
    partial class FrmConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btedit = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.btimport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.frase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(101, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 414);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btedit);
            this.panel2.Controls.Add(this.btsave);
            this.panel2.Controls.Add(this.btimport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 85);
            this.panel2.TabIndex = 3;
            // 
            // btedit
            // 
            this.btedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.Location = new System.Drawing.Point(433, 47);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(124, 26);
            this.btedit.TabIndex = 2;
            this.btedit.Text = "Editar";
            this.btedit.UseVisualStyleBackColor = true;
            // 
            // btsave
            // 
            this.btsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.Location = new System.Drawing.Point(303, 47);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(124, 26);
            this.btsave.TabIndex = 0;
            this.btsave.Text = "Salvar";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.Btsave_Click);
            // 
            // btimport
            // 
            this.btimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimport.Location = new System.Drawing.Point(563, 47);
            this.btimport.Name = "btimport";
            this.btimport.Size = new System.Drawing.Size(124, 26);
            this.btimport.TabIndex = 1;
            this.btimport.Text = "Importar";
            this.btimport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.frase,
            this.resposta,
            this.submenu,
            this.arquivos,
            this.contem,
            this.tag});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(699, 414);
            this.dataGridView1.TabIndex = 2;
            // 
            // frase
            // 
            this.frase.HeaderText = "";
            this.frase.Name = "frase";
            this.frase.ReadOnly = true;
            // 
            // resposta
            // 
            this.resposta.HeaderText = "";
            this.resposta.Name = "resposta";
            this.resposta.ReadOnly = true;
            // 
            // submenu
            // 
            this.submenu.HeaderText = "";
            this.submenu.Name = "submenu";
            this.submenu.ReadOnly = true;
            // 
            // arquivos
            // 
            this.arquivos.HeaderText = "";
            this.arquivos.Name = "arquivos";
            this.arquivos.ReadOnly = true;
            // 
            // contem
            // 
            this.contem.HeaderText = "";
            this.contem.Name = "contem";
            this.contem.ReadOnly = true;
            // 
            // tag
            // 
            this.tag.HeaderText = "";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmConfig";
            this.Text = "FrmConfig";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btimport;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn frase;
        private System.Windows.Forms.DataGridViewTextBoxColumn resposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn submenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn arquivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn contem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
    }
}

namespace Whatsbot
{
    partial class FrmList
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
            this.listTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdcionar = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTel
            // 
            this.listTel.Location = new System.Drawing.Point(180, 58);
            this.listTel.Multiline = true;
            this.listTel.Name = "listTel";
            this.listTel.Size = new System.Drawing.Size(155, 318);
            this.listTel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Telefones";
            // 
            // btAdcionar
            // 
            this.btAdcionar.Location = new System.Drawing.Point(341, 346);
            this.btAdcionar.Name = "btAdcionar";
            this.btAdcionar.Size = new System.Drawing.Size(59, 30);
            this.btAdcionar.TabIndex = 2;
            this.btAdcionar.Text = "Adcionar";
            this.btAdcionar.UseVisualStyleBackColor = true;
            this.btAdcionar.Click += new System.EventHandler(this.BtAdcionar_Click);
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(406, 346);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(59, 30);
            this.btImport.TabIndex = 12;
            this.btImport.Text = "Importar";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.BtImport_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(591, 388);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btAdcionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTel);
            this.Name = "FrmList";
            this.Opacity = 0.95D;
            this.Text = "FrmList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdcionar;
        private System.Windows.Forms.Button btImport;
    }
}

namespace Whatsbot
{
    partial class FrmOptResp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtprCli = new System.Windows.Forms.TextBox();
            this.txtMsgResp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btSvResPrCl = new System.Windows.Forms.Button();
            this.btSaveResp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddFiles = new System.Windows.Forms.Button();
            this.btRemoveFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCamiFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase:";
            // 
            // txtprCli
            // 
            this.txtprCli.Location = new System.Drawing.Point(28, 77);
            this.txtprCli.Multiline = true;
            this.txtprCli.Name = "txtprCli";
            this.txtprCli.Size = new System.Drawing.Size(291, 81);
            this.txtprCli.TabIndex = 1;
            // 
            // txtMsgResp
            // 
            this.txtMsgResp.Location = new System.Drawing.Point(28, 231);
            this.txtMsgResp.Multiline = true;
            this.txtMsgResp.Name = "txtMsgResp";
            this.txtMsgResp.Size = new System.Drawing.Size(480, 149);
            this.txtMsgResp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resposta para o cliente:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(334, 78);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Idêntico";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(334, 101);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(174, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Contém na mensagem recebida";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(334, 124);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(144, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Contém a frase da opção";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btSvResPrCl
            // 
            this.btSvResPrCl.BackColor = System.Drawing.Color.SlateGray;
            this.btSvResPrCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSvResPrCl.Location = new System.Drawing.Point(244, 177);
            this.btSvResPrCl.Name = "btSvResPrCl";
            this.btSvResPrCl.Size = new System.Drawing.Size(75, 23);
            this.btSvResPrCl.TabIndex = 32;
            this.btSvResPrCl.Text = "Salvar";
            this.btSvResPrCl.UseVisualStyleBackColor = false;
            this.btSvResPrCl.Click += new System.EventHandler(this.BtSvResPrCl_Click);
            // 
            // btSaveResp
            // 
            this.btSaveResp.BackColor = System.Drawing.Color.SlateGray;
            this.btSaveResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveResp.Location = new System.Drawing.Point(433, 399);
            this.btSaveResp.Name = "btSaveResp";
            this.btSaveResp.Size = new System.Drawing.Size(75, 23);
            this.btSaveResp.TabIndex = 31;
            this.btSaveResp.Text = "Salvar";
            this.btSaveResp.UseVisualStyleBackColor = false;
            this.btSaveResp.Click += new System.EventHandler(this.BtSaveResp_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Resposta do cliente";
            // 
            // btAddFiles
            // 
            this.btAddFiles.BackColor = System.Drawing.Color.SlateGray;
            this.btAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddFiles.Location = new System.Drawing.Point(364, 438);
            this.btAddFiles.Name = "btAddFiles";
            this.btAddFiles.Size = new System.Drawing.Size(75, 23);
            this.btAddFiles.TabIndex = 34;
            this.btAddFiles.Text = "Adicionar";
            this.btAddFiles.UseVisualStyleBackColor = false;
            this.btAddFiles.Click += new System.EventHandler(this.BtAddFiles_Click);
            // 
            // btRemoveFile
            // 
            this.btRemoveFile.BackColor = System.Drawing.Color.SlateGray;
            this.btRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveFile.Location = new System.Drawing.Point(445, 438);
            this.btRemoveFile.Name = "btRemoveFile";
            this.btRemoveFile.Size = new System.Drawing.Size(75, 23);
            this.btRemoveFile.TabIndex = 35;
            this.btRemoveFile.Text = "Remover";
            this.btRemoveFile.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblCamiFiles
            // 
            this.lblCamiFiles.Location = new System.Drawing.Point(25, 438);
            this.lblCamiFiles.Name = "lblCamiFiles";
            this.lblCamiFiles.Size = new System.Drawing.Size(333, 23);
            this.lblCamiFiles.TabIndex = 36;
            this.lblCamiFiles.Text = "Anexar Arquivos";
            // 
            // FrmOptResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(549, 545);
            this.Controls.Add(this.lblCamiFiles);
            this.Controls.Add(this.btRemoveFile);
            this.Controls.Add(this.btAddFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSvResPrCl);
            this.Controls.Add(this.btSaveResp);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtMsgResp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprCli);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmOptResp";
            this.Opacity = 0.95D;
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprCli;
        private System.Windows.Forms.TextBox txtMsgResp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btSvResPrCl;
        private System.Windows.Forms.Button btSaveResp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddFiles;
        private System.Windows.Forms.Button btRemoveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCamiFiles;
    }
}
namespace Modulo_Nai_Cadastro
{
    partial class Frm_Documentos
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
            this.blbNome = new System.Windows.Forms.Label();
            this.lblNomeAdole = new System.Windows.Forms.Label();
            this.pictureBoxAdoleDoc = new System.Windows.Forms.PictureBox();
            this.panelFoto = new System.Windows.Forms.Panel();
            this.lblDocumentos = new System.Windows.Forms.Label();
            this.panelDelimiter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdoleDoc)).BeginInit();
            this.panelFoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // blbNome
            // 
            this.blbNome.AutoSize = true;
            this.blbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbNome.Location = new System.Drawing.Point(158, 23);
            this.blbNome.Name = "blbNome";
            this.blbNome.Size = new System.Drawing.Size(49, 15);
            this.blbNome.TabIndex = 0;
            this.blbNome.Text = "Nome:";
            // 
            // lblNomeAdole
            // 
            this.lblNomeAdole.AutoSize = true;
            this.lblNomeAdole.Location = new System.Drawing.Point(213, 25);
            this.lblNomeAdole.Name = "lblNomeAdole";
            this.lblNomeAdole.Size = new System.Drawing.Size(121, 13);
            this.lblNomeAdole.TabIndex = 1;
            this.lblNomeAdole.Text = "NOME ADOLESCENTE";
            // 
            // pictureBoxAdoleDoc
            // 
            this.pictureBoxAdoleDoc.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxAdoleDoc.Name = "pictureBoxAdoleDoc";
            this.pictureBoxAdoleDoc.Size = new System.Drawing.Size(115, 139);
            this.pictureBoxAdoleDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdoleDoc.TabIndex = 2;
            this.pictureBoxAdoleDoc.TabStop = false;
            // 
            // panelFoto
            // 
            this.panelFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFoto.Controls.Add(this.pictureBoxAdoleDoc);
            this.panelFoto.Location = new System.Drawing.Point(17, 24);
            this.panelFoto.Name = "panelFoto";
            this.panelFoto.Size = new System.Drawing.Size(121, 145);
            this.panelFoto.TabIndex = 3;
            // 
            // lblDocumentos
            // 
            this.lblDocumentos.AutoSize = true;
            this.lblDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentos.Location = new System.Drawing.Point(479, 57);
            this.lblDocumentos.Name = "lblDocumentos";
            this.lblDocumentos.Size = new System.Drawing.Size(104, 15);
            this.lblDocumentos.TabIndex = 45;
            this.lblDocumentos.Text = "DOCUMENTOS";
            // 
            // panelDelimiter
            // 
            this.panelDelimiter.BackColor = System.Drawing.Color.ForestGreen;
            this.panelDelimiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDelimiter.Location = new System.Drawing.Point(155, 44);
            this.panelDelimiter.Name = "panelDelimiter";
            this.panelDelimiter.Size = new System.Drawing.Size(818, 10);
            this.panelDelimiter.TabIndex = 63;
            // 
            // Frm_Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1015, 546);
            this.Controls.Add(this.panelDelimiter);
            this.Controls.Add(this.lblDocumentos);
            this.Controls.Add(this.panelFoto);
            this.Controls.Add(this.lblNomeAdole);
            this.Controls.Add(this.blbNome);
            this.Name = "Frm_Documentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Documentos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdoleDoc)).EndInit();
            this.panelFoto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blbNome;
        private System.Windows.Forms.Label lblNomeAdole;
        private System.Windows.Forms.PictureBox pictureBoxAdoleDoc;
        private System.Windows.Forms.Panel panelFoto;
        private System.Windows.Forms.Label lblDocumentos;
        private System.Windows.Forms.Panel panelDelimiter;
    }
}
namespace Modulo_Nai_Cadastro
{
    partial class FrmFoto_excluir
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
            this.panelPicAdole = new System.Windows.Forms.Panel();
            this.pictureBoxAdolescente = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.lbl_FlagranMba = new System.Windows.Forms.Label();
            this.lblSipia = new System.Windows.Forms.Label();
            this.lblNQuarto = new System.Windows.Forms.Label();
            this.btnSaiQuarto = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblId_Adolescente = new System.Windows.Forms.Label();
            this.lblPlantaoAdolescente = new System.Windows.Forms.Label();
            this.lbl_N_Sipia = new System.Windows.Forms.Label();
            this.lblIdUsu = new System.Windows.Forms.Label();
            this.lblPlantaoSys = new System.Windows.Forms.Label();
            this.panelPicAdole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdolescente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPicAdole
            // 
            this.panelPicAdole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicAdole.Controls.Add(this.pictureBoxAdolescente);
            this.panelPicAdole.Location = new System.Drawing.Point(31, 24);
            this.panelPicAdole.Name = "panelPicAdole";
            this.panelPicAdole.Size = new System.Drawing.Size(206, 228);
            this.panelPicAdole.TabIndex = 0;
            // 
            // pictureBoxAdolescente
            // 
            this.pictureBoxAdolescente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAdolescente.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxAdolescente.Name = "pictureBoxAdolescente";
            this.pictureBoxAdolescente.Size = new System.Drawing.Size(198, 222);
            this.pictureBoxAdolescente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdolescente.TabIndex = 0;
            this.pictureBoxAdolescente.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(32, 264);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome ";
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarto.Location = new System.Drawing.Point(270, 24);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(50, 15);
            this.lblQuarto.TabIndex = 2;
            this.lblQuarto.Text = "Quarto";
            // 
            // lbl_FlagranMba
            // 
            this.lbl_FlagranMba.AutoSize = true;
            this.lbl_FlagranMba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FlagranMba.ForeColor = System.Drawing.Color.Red;
            this.lbl_FlagranMba.Location = new System.Drawing.Point(270, 86);
            this.lbl_FlagranMba.Name = "lbl_FlagranMba";
            this.lbl_FlagranMba.Size = new System.Drawing.Size(92, 15);
            this.lbl_FlagranMba.TabIndex = 3;
            this.lbl_FlagranMba.Text = "flagranteMba";
            this.lbl_FlagranMba.Visible = false;
            // 
            // lblSipia
            // 
            this.lblSipia.AutoSize = true;
            this.lblSipia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSipia.Location = new System.Drawing.Point(270, 51);
            this.lblSipia.Name = "lblSipia";
            this.lblSipia.Size = new System.Drawing.Size(49, 15);
            this.lblSipia.TabIndex = 4;
            this.lblSipia.Text = "SIPIA: ";
            // 
            // lblNQuarto
            // 
            this.lblNQuarto.AutoSize = true;
            this.lblNQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNQuarto.Location = new System.Drawing.Point(335, 24);
            this.lblNQuarto.Name = "lblNQuarto";
            this.lblNQuarto.Size = new System.Drawing.Size(80, 15);
            this.lblNQuarto.TabIndex = 5;
            this.lblNQuarto.Text = "numero Ala";
            // 
            // btnSaiQuarto
            // 
            this.btnSaiQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaiQuarto.Location = new System.Drawing.Point(273, 130);
            this.btnSaiQuarto.Name = "btnSaiQuarto";
            this.btnSaiQuarto.Size = new System.Drawing.Size(133, 27);
            this.btnSaiQuarto.TabIndex = 6;
            this.btnSaiQuarto.Text = "Saída do quarto";
            this.btnSaiQuarto.UseVisualStyleBackColor = true;
            this.btnSaiQuarto.Click += new System.EventHandler(this.btnSaiQuarto_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(391, 258);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(95, 27);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblId_Adolescente
            // 
            this.lblId_Adolescente.AutoSize = true;
            this.lblId_Adolescente.Location = new System.Drawing.Point(273, 205);
            this.lblId_Adolescente.Name = "lblId_Adolescente";
            this.lblId_Adolescente.Size = new System.Drawing.Size(15, 13);
            this.lblId_Adolescente.TabIndex = 8;
            this.lblId_Adolescente.Text = "id";
            this.lblId_Adolescente.Visible = false;
            // 
            // lblPlantaoAdolescente
            // 
            this.lblPlantaoAdolescente.AutoSize = true;
            this.lblPlantaoAdolescente.Location = new System.Drawing.Point(270, 227);
            this.lblPlantaoAdolescente.Name = "lblPlantaoAdolescente";
            this.lblPlantaoAdolescente.Size = new System.Drawing.Size(42, 13);
            this.lblPlantaoAdolescente.TabIndex = 9;
            this.lblPlantaoAdolescente.Text = "plantao";
            this.lblPlantaoAdolescente.Visible = false;
            // 
            // lbl_N_Sipia
            // 
            this.lbl_N_Sipia.AutoSize = true;
            this.lbl_N_Sipia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_N_Sipia.Location = new System.Drawing.Point(315, 51);
            this.lbl_N_Sipia.Name = "lbl_N_Sipia";
            this.lbl_N_Sipia.Size = new System.Drawing.Size(50, 15);
            this.lbl_N_Sipia.TabIndex = 10;
            this.lbl_N_Sipia.Text = "numero";
            // 
            // lblIdUsu
            // 
            this.lblIdUsu.AutoSize = true;
            this.lblIdUsu.Location = new System.Drawing.Point(270, 258);
            this.lblIdUsu.Name = "lblIdUsu";
            this.lblIdUsu.Size = new System.Drawing.Size(34, 13);
            this.lblIdUsu.TabIndex = 11;
            this.lblIdUsu.Text = "idUsu";
            this.lblIdUsu.Visible = false;
            // 
            // lblPlantaoSys
            // 
            this.lblPlantaoSys.AutoSize = true;
            this.lblPlantaoSys.Location = new System.Drawing.Point(273, 174);
            this.lblPlantaoSys.Name = "lblPlantaoSys";
            this.lblPlantaoSys.Size = new System.Drawing.Size(59, 13);
            this.lblPlantaoSys.TabIndex = 12;
            this.lblPlantaoSys.Text = "plantaoSys";
            // 
            // FrmFoto_excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(510, 302);
            this.Controls.Add(this.lblPlantaoSys);
            this.Controls.Add(this.lblIdUsu);
            this.Controls.Add(this.lbl_N_Sipia);
            this.Controls.Add(this.lblPlantaoAdolescente);
            this.Controls.Add(this.lblId_Adolescente);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSaiQuarto);
            this.Controls.Add(this.lblNQuarto);
            this.Controls.Add(this.lblSipia);
            this.Controls.Add(this.lbl_FlagranMba);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panelPicAdole);
            this.Name = "FrmFoto_excluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adolescente ";
            this.panelPicAdole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdolescente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPicAdole;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.Label lbl_FlagranMba;
        private System.Windows.Forms.Label lblSipia;
        private System.Windows.Forms.Label lblNQuarto;
        private System.Windows.Forms.Button btnSaiQuarto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBoxAdolescente;
        private System.Windows.Forms.Label lblId_Adolescente;
        private System.Windows.Forms.Label lblPlantaoAdolescente;
        private System.Windows.Forms.Label lbl_N_Sipia;
        private System.Windows.Forms.Label lblIdUsu;
        private System.Windows.Forms.Label lblPlantaoSys;
    }
}
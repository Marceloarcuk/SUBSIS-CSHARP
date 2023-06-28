namespace Modulo_Nai_Cadastro
{
    partial class FrmAlteraSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlteraSenha));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.labelIdUsu = new System.Windows.Forms.Label();
            this.usuName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaN = new System.Windows.Forms.TextBox();
            this.labelNovaD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Snow;
            this.btnCancelar.Location = new System.Drawing.Point(184, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 27);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Snow;
            this.btnAlterar.Location = new System.Drawing.Point(283, 212);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 27);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // labelIdUsu
            // 
            this.labelIdUsu.AutoSize = true;
            this.labelIdUsu.Location = new System.Drawing.Point(52, 13);
            this.labelIdUsu.Name = "labelIdUsu";
            this.labelIdUsu.Size = new System.Drawing.Size(34, 13);
            this.labelIdUsu.TabIndex = 2;
            this.labelIdUsu.Text = "idUsu";
            this.labelIdUsu.Visible = false;
            // 
            // usuName
            // 
            this.usuName.AutoSize = true;
            this.usuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuName.Location = new System.Drawing.Point(38, 46);
            this.usuName.Name = "usuName";
            this.usuName.Size = new System.Drawing.Size(84, 16);
            this.usuName.TabIndex = 3;
            this.usuName.Text = "labelName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nova Senha";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(41, 96);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(138, 20);
            this.txtNovaSenha.TabIndex = 5;
            // 
            // txtSenhaN
            // 
            this.txtSenhaN.Location = new System.Drawing.Point(41, 146);
            this.txtSenhaN.Name = "txtSenhaN";
            this.txtSenhaN.PasswordChar = '*';
            this.txtSenhaN.Size = new System.Drawing.Size(138, 20);
            this.txtSenhaN.TabIndex = 7;
            // 
            // labelNovaD
            // 
            this.labelNovaD.AutoSize = true;
            this.labelNovaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovaD.Location = new System.Drawing.Point(38, 125);
            this.labelNovaD.Name = "labelNovaD";
            this.labelNovaD.Size = new System.Drawing.Size(174, 15);
            this.labelNovaD.TabIndex = 6;
            this.labelNovaD.Text = "Digite a senha novamente";
            // 
            // FrmAlteraSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.txtSenhaN);
            this.Controls.Add(this.labelNovaD);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuName);
            this.Controls.Add(this.labelIdUsu);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlteraSenha";
            this.Text = "Alterar senha de usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label labelIdUsu;
        private System.Windows.Forms.Label usuName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtSenhaN;
        private System.Windows.Forms.Label labelNovaD;
    }
}
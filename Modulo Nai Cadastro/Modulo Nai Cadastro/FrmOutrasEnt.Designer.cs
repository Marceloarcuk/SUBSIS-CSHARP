namespace Modulo_Nai_Cadastro
{
    partial class FrmOutrasEnt
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
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelNomeAdo = new System.Windows.Forms.Label();
            this.labelIdAdo = new System.Windows.Forms.Label();
            this.labelIdUsu = new System.Windows.Forms.Label();
            this.labelIDPlantao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outras descrições sobre a entrada do adolescente.";
            // 
            // txtOutros
            // 
            this.txtOutros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutros.Location = new System.Drawing.Point(26, 60);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(330, 22);
            this.txtOutros.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Snow;
            this.btnSalvar.Location = new System.Drawing.Point(264, 102);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 27);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Snow;
            this.btnCancelar.Location = new System.Drawing.Point(165, 102);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 27);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelNomeAdo
            // 
            this.labelNomeAdo.AutoSize = true;
            this.labelNomeAdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAdo.Location = new System.Drawing.Point(26, 4);
            this.labelNomeAdo.Name = "labelNomeAdo";
            this.labelNomeAdo.Size = new System.Drawing.Size(77, 15);
            this.labelNomeAdo.TabIndex = 4;
            this.labelNomeAdo.Text = "labelNome";
            // 
            // labelIdAdo
            // 
            this.labelIdAdo.AutoSize = true;
            this.labelIdAdo.Location = new System.Drawing.Point(26, 89);
            this.labelIdAdo.Name = "labelIdAdo";
            this.labelIdAdo.Size = new System.Drawing.Size(34, 13);
            this.labelIdAdo.TabIndex = 5;
            this.labelIdAdo.Text = "idAdo";
            this.labelIdAdo.Visible = false;
            // 
            // labelIdUsu
            // 
            this.labelIdUsu.AutoSize = true;
            this.labelIdUsu.Location = new System.Drawing.Point(40, 118);
            this.labelIdUsu.Name = "labelIdUsu";
            this.labelIdUsu.Size = new System.Drawing.Size(34, 13);
            this.labelIdUsu.TabIndex = 6;
            this.labelIdUsu.Text = "idUsu";
            this.labelIdUsu.Visible = false;
            // 
            // labelIDPlantao
            // 
            this.labelIDPlantao.AutoSize = true;
            this.labelIDPlantao.Location = new System.Drawing.Point(178, 9);
            this.labelIDPlantao.Name = "labelIDPlantao";
            this.labelIDPlantao.Size = new System.Drawing.Size(51, 13);
            this.labelIDPlantao.TabIndex = 7;
            this.labelIDPlantao.Text = "idPlantao";
            this.labelIDPlantao.Visible = false;
            // 
            // FrmOutrasEnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 153);
            this.Controls.Add(this.labelIDPlantao);
            this.Controls.Add(this.labelIdUsu);
            this.Controls.Add(this.labelIdAdo);
            this.Controls.Add(this.labelNomeAdo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtOutros);
            this.Controls.Add(this.label1);
            this.Name = "FrmOutrasEnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelNomeAdo;
        private System.Windows.Forms.Label labelIdAdo;
        private System.Windows.Forms.Label labelIdUsu;
        private System.Windows.Forms.Label labelIDPlantao;
    }
}
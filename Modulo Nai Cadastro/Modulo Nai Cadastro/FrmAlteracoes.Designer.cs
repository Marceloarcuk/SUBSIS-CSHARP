namespace Modulo_Nai_Cadastro
{
    partial class FrmAlteracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlteracoes));
            this.dataGridViewAlter = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdolescente = new System.Windows.Forms.Label();
            this.lblNomeAdolescente = new System.Windows.Forms.Label();
            this.lblInsercao = new System.Windows.Forms.Label();
            this.lblNomeServ = new System.Windows.Forms.Label();
            this.lblDataInsert = new System.Windows.Forms.Label();
            this.lblDataUpdateD = new System.Windows.Forms.Label();
            this.lblIdServ = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lblDescCargo = new System.Windows.Forms.Label();
            this.lblIdInterno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlter
            // 
            this.dataGridViewAlter.AllowUserToAddRows = false;
            this.dataGridViewAlter.AllowUserToDeleteRows = false;
            this.dataGridViewAlter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.update,
            this.dataUpdate,
            this.cargoUpdate});
            this.dataGridViewAlter.Location = new System.Drawing.Point(35, 61);
            this.dataGridViewAlter.Name = "dataGridViewAlter";
            this.dataGridViewAlter.ReadOnly = true;
            this.dataGridViewAlter.Size = new System.Drawing.Size(642, 331);
            this.dataGridViewAlter.TabIndex = 0;
            // 
            // update
            // 
            this.update.HeaderText = "Nome do servidor";
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Width = 250;
            // 
            // dataUpdate
            // 
            this.dataUpdate.HeaderText = "Data de atualização";
            this.dataUpdate.Name = "dataUpdate";
            this.dataUpdate.ReadOnly = true;
            this.dataUpdate.Width = 150;
            // 
            // cargoUpdate
            // 
            this.cargoUpdate.HeaderText = "Cargo do servidor";
            this.cargoUpdate.Name = "cargoUpdate";
            this.cargoUpdate.ReadOnly = true;
            this.cargoUpdate.Width = 200;
            // 
            // lblAdolescente
            // 
            this.lblAdolescente.AutoSize = true;
            this.lblAdolescente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdolescente.Location = new System.Drawing.Point(17, 9);
            this.lblAdolescente.Name = "lblAdolescente";
            this.lblAdolescente.Size = new System.Drawing.Size(89, 15);
            this.lblAdolescente.TabIndex = 1;
            this.lblAdolescente.Text = "Adolescente:";
            // 
            // lblNomeAdolescente
            // 
            this.lblNomeAdolescente.AutoSize = true;
            this.lblNomeAdolescente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAdolescente.Location = new System.Drawing.Point(112, 9);
            this.lblNomeAdolescente.Name = "lblNomeAdolescente";
            this.lblNomeAdolescente.Size = new System.Drawing.Size(106, 15);
            this.lblNomeAdolescente.TabIndex = 2;
            this.lblNomeAdolescente.Text = "nomeAdolescente";
            // 
            // lblInsercao
            // 
            this.lblInsercao.AutoSize = true;
            this.lblInsercao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsercao.Location = new System.Drawing.Point(17, 32);
            this.lblInsercao.Name = "lblInsercao";
            this.lblInsercao.Size = new System.Drawing.Size(66, 15);
            this.lblInsercao.TabIndex = 3;
            this.lblInsercao.Text = "Inserção:";
            // 
            // lblNomeServ
            // 
            this.lblNomeServ.AutoSize = true;
            this.lblNomeServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeServ.Location = new System.Drawing.Point(90, 32);
            this.lblNomeServ.Name = "lblNomeServ";
            this.lblNomeServ.Size = new System.Drawing.Size(84, 15);
            this.lblNomeServ.TabIndex = 4;
            this.lblNomeServ.Text = "nomeServidor";
            // 
            // lblDataInsert
            // 
            this.lblDataInsert.AutoSize = true;
            this.lblDataInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInsert.Location = new System.Drawing.Point(375, 9);
            this.lblDataInsert.Name = "lblDataInsert";
            this.lblDataInsert.Size = new System.Drawing.Size(120, 15);
            this.lblDataInsert.TabIndex = 5;
            this.lblDataInsert.Text = "Data de inserção:";
            // 
            // lblDataUpdateD
            // 
            this.lblDataUpdateD.AutoSize = true;
            this.lblDataUpdateD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataUpdateD.Location = new System.Drawing.Point(498, 9);
            this.lblDataUpdateD.Name = "lblDataUpdateD";
            this.lblDataUpdateD.Size = new System.Drawing.Size(71, 15);
            this.lblDataUpdateD.TabIndex = 6;
            this.lblDataUpdateD.Text = "dataUpdate";
            // 
            // lblIdServ
            // 
            this.lblIdServ.AutoSize = true;
            this.lblIdServ.Location = new System.Drawing.Point(634, -2);
            this.lblIdServ.Name = "lblIdServ";
            this.lblIdServ.Size = new System.Drawing.Size(37, 13);
            this.lblIdServ.TabIndex = 7;
            this.lblIdServ.Text = "idServ";
            this.lblIdServ.Visible = false;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(375, 32);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(49, 15);
            this.lbl_cargo.TabIndex = 8;
            this.lbl_cargo.Text = "Cargo:";
            // 
            // lblDescCargo
            // 
            this.lblDescCargo.AutoSize = true;
            this.lblDescCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCargo.Location = new System.Drawing.Point(427, 32);
            this.lblDescCargo.Name = "lblDescCargo";
            this.lblDescCargo.Size = new System.Drawing.Size(66, 15);
            this.lblDescCargo.TabIndex = 9;
            this.lblDescCargo.Text = "descCargo";
            // 
            // lblIdInterno
            // 
            this.lblIdInterno.AutoSize = true;
            this.lblIdInterno.Location = new System.Drawing.Point(77, 395);
            this.lblIdInterno.Name = "lblIdInterno";
            this.lblIdInterno.Size = new System.Drawing.Size(48, 13);
            this.lblIdInterno.TabIndex = 10;
            this.lblIdInterno.Text = "idInterno";
            this.lblIdInterno.Visible = false;
            // 
            // FrmAlteracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 415);
            this.Controls.Add(this.lblIdInterno);
            this.Controls.Add(this.lblDescCargo);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lblIdServ);
            this.Controls.Add(this.lblDataUpdateD);
            this.Controls.Add(this.lblDataInsert);
            this.Controls.Add(this.lblNomeServ);
            this.Controls.Add(this.lblInsercao);
            this.Controls.Add(this.lblNomeAdolescente);
            this.Controls.Add(this.lblAdolescente);
            this.Controls.Add(this.dataGridViewAlter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlteracoes";
            this.Text = "Alterações - Módulo NAI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlter;
        private System.Windows.Forms.Label lblAdolescente;
        private System.Windows.Forms.Label lblNomeAdolescente;
        private System.Windows.Forms.Label lblInsercao;
        private System.Windows.Forms.Label lblNomeServ;
        private System.Windows.Forms.Label lblDataInsert;
        private System.Windows.Forms.Label lblDataUpdateD;
        private System.Windows.Forms.Label lblIdServ;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lblDescCargo;
        private System.Windows.Forms.Label lblIdInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn update;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoUpdate;
    }
}
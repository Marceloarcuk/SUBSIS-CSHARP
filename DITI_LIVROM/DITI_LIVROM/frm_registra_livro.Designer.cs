namespace DITI_LIVROM
{
    partial class frm_registra_livro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registra_livro));
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRetorno = new System.Windows.Forms.Panel();
            this.lbRetorno1 = new System.Windows.Forms.Label();
            this.eRetorno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eServidores = new System.Windows.Forms.ListView();
            this.SERV_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SERV_COD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.eJovens = new System.Windows.Forms.ListView();
            this.JOVEM_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JOVEM_COD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.eDTRegistro = new System.Windows.Forms.DateTimePicker();
            this.eLOCAL_DT = new System.Windows.Forms.Label();
            this.eAcao = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.eFrase = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.lbRetorno.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(381, 476);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(170, 41);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.TabStop = false;
            this.btn_salvar.Text = "Registrar no Livro";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(556, 476);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(117, 41);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbRetorno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.eServidores);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.eJovens);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.eDTRegistro);
            this.panel1.Controls.Add(this.eLOCAL_DT);
            this.panel1.Controls.Add(this.eAcao);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.eFrase);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 455);
            this.panel1.TabIndex = 27;
            // 
            // lbRetorno
            // 
            this.lbRetorno.BackColor = System.Drawing.Color.Navy;
            this.lbRetorno.Controls.Add(this.lbRetorno1);
            this.lbRetorno.Controls.Add(this.eRetorno);
            this.lbRetorno.Location = new System.Drawing.Point(167, -1);
            this.lbRetorno.Name = "lbRetorno";
            this.lbRetorno.Size = new System.Drawing.Size(487, 37);
            this.lbRetorno.TabIndex = 35;
            // 
            // lbRetorno1
            // 
            this.lbRetorno1.AutoSize = true;
            this.lbRetorno1.BackColor = System.Drawing.Color.Navy;
            this.lbRetorno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetorno1.ForeColor = System.Drawing.Color.White;
            this.lbRetorno1.Location = new System.Drawing.Point(3, 3);
            this.lbRetorno1.Name = "lbRetorno1";
            this.lbRetorno1.Size = new System.Drawing.Size(122, 29);
            this.lbRetorno1.TabIndex = 34;
            this.lbRetorno1.Text = "Retorno -";
            // 
            // eRetorno
            // 
            this.eRetorno.AutoSize = true;
            this.eRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eRetorno.ForeColor = System.Drawing.Color.White;
            this.eRetorno.Location = new System.Drawing.Point(121, 6);
            this.eRetorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eRetorno.Name = "eRetorno";
            this.eRetorno.Size = new System.Drawing.Size(96, 24);
            this.eRetorno.TabIndex = 33;
            this.eRetorno.Text = "eRetorno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Servidores";
            // 
            // eServidores
            // 
            this.eServidores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SERV_NOME,
            this.SERV_COD});
            this.eServidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eServidores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eServidores.Location = new System.Drawing.Point(340, 243);
            this.eServidores.Margin = new System.Windows.Forms.Padding(2);
            this.eServidores.Name = "eServidores";
            this.eServidores.Size = new System.Drawing.Size(314, 199);
            this.eServidores.TabIndex = 31;
            this.eServidores.UseCompatibleStateImageBehavior = false;
            this.eServidores.View = System.Windows.Forms.View.Details;
            // 
            // SERV_NOME
            // 
            this.SERV_NOME.Text = "";
            this.SERV_NOME.Width = 355;
            // 
            // SERV_COD
            // 
            this.SERV_COD.Text = "";
            this.SERV_COD.Width = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Jovens";
            // 
            // eJovens
            // 
            this.eJovens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JOVEM_NOME,
            this.JOVEM_COD});
            this.eJovens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eJovens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eJovens.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eJovens.Location = new System.Drawing.Point(12, 243);
            this.eJovens.Margin = new System.Windows.Forms.Padding(2);
            this.eJovens.MultiSelect = false;
            this.eJovens.Name = "eJovens";
            this.eJovens.Size = new System.Drawing.Size(314, 199);
            this.eJovens.TabIndex = 29;
            this.eJovens.UseCompatibleStateImageBehavior = false;
            this.eJovens.View = System.Windows.Forms.View.Details;
            // 
            // JOVEM_NOME
            // 
            this.JOVEM_NOME.Text = "";
            this.JOVEM_NOME.Width = 356;
            // 
            // JOVEM_COD
            // 
            this.JOVEM_COD.Text = "";
            this.JOVEM_COD.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Data da Ocorrência:";
            // 
            // eDTRegistro
            // 
            this.eDTRegistro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTRegistro.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.eDTRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eDTRegistro.Location = new System.Drawing.Point(182, 181);
            this.eDTRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.eDTRegistro.Name = "eDTRegistro";
            this.eDTRegistro.Size = new System.Drawing.Size(186, 24);
            this.eDTRegistro.TabIndex = 27;
            // 
            // eLOCAL_DT
            // 
            this.eLOCAL_DT.AutoSize = true;
            this.eLOCAL_DT.Location = new System.Drawing.Point(514, 182);
            this.eLOCAL_DT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eLOCAL_DT.Name = "eLOCAL_DT";
            this.eLOCAL_DT.Size = new System.Drawing.Size(68, 13);
            this.eLOCAL_DT.TabIndex = 26;
            this.eLOCAL_DT.Text = "eLOCAL_DT";
            this.eLOCAL_DT.Visible = false;
            // 
            // eAcao
            // 
            this.eAcao.AutoSize = true;
            this.eAcao.Location = new System.Drawing.Point(467, 181);
            this.eAcao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eAcao.Name = "eAcao";
            this.eAcao.Size = new System.Drawing.Size(38, 13);
            this.eAcao.TabIndex = 25;
            this.eAcao.Text = "eAcao";
            this.eAcao.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 11);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 18);
            this.label15.TabIndex = 21;
            this.label15.Text = "Registro no Livro";
            // 
            // eFrase
            // 
            this.eFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFrase.Location = new System.Drawing.Point(12, 37);
            this.eFrase.Margin = new System.Windows.Forms.Padding(2);
            this.eFrase.Name = "eFrase";
            this.eFrase.Size = new System.Drawing.Size(642, 132);
            this.eFrase.TabIndex = 20;
            this.eFrase.Text = "";
            // 
            // frm_registra_livro
            // 
            this.AcceptButton = this.btn_salvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(680, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_registra_livro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar no Livro";
            this.Load += new System.EventHandler(this.frm_registra_livro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.lbRetorno.ResumeLayout(false);
            this.lbRetorno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_salvar;
        internal System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView eServidores;
        public System.Windows.Forms.ColumnHeader SERV_NOME;
        public System.Windows.Forms.ColumnHeader SERV_COD;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView eJovens;
        public System.Windows.Forms.ColumnHeader JOVEM_NOME;
        public System.Windows.Forms.ColumnHeader JOVEM_COD;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker eDTRegistro;
        public System.Windows.Forms.Label eLOCAL_DT;
        public System.Windows.Forms.Label eAcao;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.RichTextBox eFrase;
        public System.Windows.Forms.Label eRetorno;
        public System.Windows.Forms.Panel lbRetorno;
        public System.Windows.Forms.Label lbRetorno1;
    }
}
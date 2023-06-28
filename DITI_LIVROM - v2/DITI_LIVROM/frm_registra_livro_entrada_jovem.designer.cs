namespace DITI_LIVROM
{
    partial class frm_registra_livro_entrada_jovem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registra_livro_entrada_jovem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.eServidores = new System.Windows.Forms.ListView();
            this.SERV_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SERV_COD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbAla = new System.Windows.Forms.Label();
            this.eAla = new System.Windows.Forms.ComboBox();
            this.eQuarto = new System.Windows.Forms.NumericUpDown();
            this.lbQuarto = new System.Windows.Forms.Label();
            this.eRetorno = new System.Windows.Forms.Label();
            this.lbJovens = new System.Windows.Forms.Label();
            this.eJovens = new System.Windows.Forms.ListView();
            this.JOVEM_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JOVEM_ALA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JOVEM_QUARTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JOVEM_COD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.eDTRegistro = new System.Windows.Forms.DateTimePicker();
            this.eLOCAL_DT = new System.Windows.Forms.Label();
            this.eAcao = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.eFrase = new System.Windows.Forms.RichTextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.eServidores);
            this.panel1.Controls.Add(this.lbAla);
            this.panel1.Controls.Add(this.eAla);
            this.panel1.Controls.Add(this.eQuarto);
            this.panel1.Controls.Add(this.lbQuarto);
            this.panel1.Controls.Add(this.eRetorno);
            this.panel1.Controls.Add(this.lbJovens);
            this.panel1.Controls.Add(this.eJovens);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.eDTRegistro);
            this.panel1.Controls.Add(this.eLOCAL_DT);
            this.panel1.Controls.Add(this.eAcao);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.eFrase);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 559);
            this.panel1.TabIndex = 27;
            // 
            // eServidores
            // 
            this.eServidores.BackColor = System.Drawing.Color.White;
            this.eServidores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SERV_NOME,
            this.SERV_COD});
            this.eServidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eServidores.FullRowSelect = true;
            this.eServidores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eServidores.HideSelection = false;
            this.eServidores.Location = new System.Drawing.Point(626, 38);
            this.eServidores.MultiSelect = false;
            this.eServidores.Name = "eServidores";
            this.eServidores.Size = new System.Drawing.Size(248, 144);
            this.eServidores.TabIndex = 31;
            this.eServidores.UseCompatibleStateImageBehavior = false;
            this.eServidores.View = System.Windows.Forms.View.Details;
            this.eServidores.Visible = false;
            // 
            // SERV_NOME
            // 
            this.SERV_NOME.Text = "Nome";
            this.SERV_NOME.Width = 500;
            // 
            // SERV_COD
            // 
            this.SERV_COD.Text = "";
            this.SERV_COD.Width = 0;
            // 
            // lbAla
            // 
            this.lbAla.AutoSize = true;
            this.lbAla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAla.Location = new System.Drawing.Point(349, 520);
            this.lbAla.Name = "lbAla";
            this.lbAla.Size = new System.Drawing.Size(46, 24);
            this.lbAla.TabIndex = 60;
            this.lbAla.Text = "Ala:";
            // 
            // eAla
            // 
            this.eAla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eAla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.eAla.FormattingEnabled = true;
            this.eAla.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L"});
            this.eAla.Location = new System.Drawing.Point(410, 518);
            this.eAla.Name = "eAla";
            this.eAla.Size = new System.Drawing.Size(134, 30);
            this.eAla.TabIndex = 59;
            this.eAla.SelectedValueChanged += new System.EventHandler(this.eQuarto_ValueChanged);
            // 
            // eQuarto
            // 
            this.eQuarto.Enabled = false;
            this.eQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eQuarto.Location = new System.Drawing.Point(796, 518);
            this.eQuarto.Name = "eQuarto";
            this.eQuarto.Size = new System.Drawing.Size(75, 28);
            this.eQuarto.TabIndex = 58;
            this.eQuarto.ValueChanged += new System.EventHandler(this.eQuarto_ValueChanged);
            // 
            // lbQuarto
            // 
            this.lbQuarto.AutoSize = true;
            this.lbQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuarto.Location = new System.Drawing.Point(586, 518);
            this.lbQuarto.Name = "lbQuarto";
            this.lbQuarto.Size = new System.Drawing.Size(190, 24);
            this.lbQuarto.TabIndex = 57;
            this.lbQuarto.Text = "Número do Quarto:";
            // 
            // eRetorno
            // 
            this.eRetorno.AutoSize = true;
            this.eRetorno.Location = new System.Drawing.Point(536, 233);
            this.eRetorno.Name = "eRetorno";
            this.eRetorno.Size = new System.Drawing.Size(67, 17);
            this.eRetorno.TabIndex = 33;
            this.eRetorno.Text = "eRetorno";
            this.eRetorno.Visible = false;
            // 
            // lbJovens
            // 
            this.lbJovens.AutoSize = true;
            this.lbJovens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJovens.Location = new System.Drawing.Point(13, 262);
            this.lbJovens.Name = "lbJovens";
            this.lbJovens.Size = new System.Drawing.Size(76, 24);
            this.lbJovens.TabIndex = 30;
            this.lbJovens.Text = "Jovens";
            // 
            // eJovens
            // 
            this.eJovens.BackColor = System.Drawing.Color.White;
            this.eJovens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JOVEM_NOME,
            this.JOVEM_ALA,
            this.JOVEM_QUARTO,
            this.JOVEM_COD});
            this.eJovens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eJovens.FullRowSelect = true;
            this.eJovens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eJovens.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eJovens.Location = new System.Drawing.Point(17, 292);
            this.eJovens.MultiSelect = false;
            this.eJovens.Name = "eJovens";
            this.eJovens.Size = new System.Drawing.Size(854, 220);
            this.eJovens.TabIndex = 29;
            this.eJovens.UseCompatibleStateImageBehavior = false;
            this.eJovens.View = System.Windows.Forms.View.Details;
            this.eJovens.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.eJovens_ItemSelectionChanged);
            // 
            // JOVEM_NOME
            // 
            this.JOVEM_NOME.Text = "Nome";
            this.JOVEM_NOME.Width = 450;
            // 
            // JOVEM_ALA
            // 
            this.JOVEM_ALA.DisplayIndex = 2;
            this.JOVEM_ALA.Text = "Ala";
            this.JOVEM_ALA.Width = 81;
            // 
            // JOVEM_QUARTO
            // 
            this.JOVEM_QUARTO.DisplayIndex = 3;
            this.JOVEM_QUARTO.Text = "Quarto";
            this.JOVEM_QUARTO.Width = 104;
            // 
            // JOVEM_COD
            // 
            this.JOVEM_COD.DisplayIndex = 1;
            this.JOVEM_COD.Text = "";
            this.JOVEM_COD.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Data da Ocorrência:";
            // 
            // eDTRegistro
            // 
            this.eDTRegistro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTRegistro.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.eDTRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eDTRegistro.Location = new System.Drawing.Point(243, 223);
            this.eDTRegistro.Name = "eDTRegistro";
            this.eDTRegistro.Size = new System.Drawing.Size(247, 28);
            this.eDTRegistro.TabIndex = 27;
            // 
            // eLOCAL_DT
            // 
            this.eLOCAL_DT.AutoSize = true;
            this.eLOCAL_DT.Location = new System.Drawing.Point(685, 224);
            this.eLOCAL_DT.Name = "eLOCAL_DT";
            this.eLOCAL_DT.Size = new System.Drawing.Size(88, 17);
            this.eLOCAL_DT.TabIndex = 26;
            this.eLOCAL_DT.Text = "eLOCAL_DT";
            this.eLOCAL_DT.Visible = false;
            // 
            // eAcao
            // 
            this.eAcao.AutoSize = true;
            this.eAcao.Location = new System.Drawing.Point(623, 223);
            this.eAcao.Name = "eAcao";
            this.eAcao.Size = new System.Drawing.Size(48, 17);
            this.eAcao.TabIndex = 25;
            this.eAcao.Text = "eAcao";
            this.eAcao.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 24);
            this.label15.TabIndex = 21;
            this.label15.Text = "Registro no Livro";
            // 
            // eFrase
            // 
            this.eFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFrase.Location = new System.Drawing.Point(17, 38);
            this.eFrase.Name = "eFrase";
            this.eFrase.Size = new System.Drawing.Size(854, 179);
            this.eFrase.TabIndex = 20;
            this.eFrase.Text = "";
            // 
            // btn_salvar
            // 
            this.btn_salvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(508, 586);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(227, 51);
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
            this.btn_cancelar.Location = new System.Drawing.Point(741, 586);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(156, 51);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_registra_livro_entrada_jovem
            // 
            this.AcceptButton = this.btn_salvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(907, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_registra_livro_entrada_jovem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ocorrência no Livro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eQuarto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_salvar;
        internal System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbJovens;
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
        private System.Windows.Forms.ColumnHeader JOVEM_ALA;
        private System.Windows.Forms.ColumnHeader JOVEM_QUARTO;
        public System.Windows.Forms.NumericUpDown eQuarto;
        public System.Windows.Forms.Label lbQuarto;
        public System.Windows.Forms.Label lbAla;
        public System.Windows.Forms.ComboBox eAla;
        public System.Windows.Forms.ListView eServidores;
        public System.Windows.Forms.ColumnHeader SERV_NOME;
        public System.Windows.Forms.ColumnHeader SERV_COD;
    }
}
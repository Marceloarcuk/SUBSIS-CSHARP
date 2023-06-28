namespace DITI_LIVROM
{
    partial class frm_registra_livro_ocorrencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registra_livro_ocorrencia));
            this.tcOco = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.e_EDIT_ADD = new System.Windows.Forms.Label();
            this.btn_del_servidor = new System.Windows.Forms.Button();
            this.btn_add_servidor = new System.Windows.Forms.Button();
            this.btn_del_jovem = new System.Windows.Forms.Button();
            this.btn_add_jovem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.eTPOcorrencia = new System.Windows.Forms.ComboBox();
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
            this.eDTOcorrencia = new System.Windows.Forms.DateTimePicker();
            this.eLOCAL_DT = new System.Windows.Forms.Label();
            this.eAcao = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.eFrase = new System.Windows.Forms.RichTextBox();
            this.tbar = new System.Windows.Forms.ToolStrip();
            this.tbar_negrito = new System.Windows.Forms.ToolStripButton();
            this.tbar_italico = new System.Windows.Forms.ToolStripButton();
            this.tbar_sobrescrito = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbar_fonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbar_color = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbar_picture = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbar_cortar = new System.Windows.Forms.ToolStripButton();
            this.tbar_copiar = new System.Windows.Forms.ToolStripButton();
            this.tbar_colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbar_aling_esquerda = new System.Windows.Forms.ToolStripButton();
            this.tbar_aling_centro = new System.Windows.Forms.ToolStripButton();
            this.tbar_aling_direita = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbar_bullet = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.eDTMD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eJovensMD_dia = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.eJovensMD_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eJovensMD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgEditor = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tcOco.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tbar.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eJovensMD_dia)).BeginInit();
            this.SuspendLayout();
            // 
            // tcOco
            // 
            this.tcOco.Controls.Add(this.tabPage1);
            this.tcOco.Controls.Add(this.tabPage2);
            this.tcOco.Controls.Add(this.tabPage3);
            this.tcOco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcOco.Location = new System.Drawing.Point(9, 10);
            this.tcOco.Margin = new System.Windows.Forms.Padding(2);
            this.tcOco.Name = "tcOco";
            this.tcOco.SelectedIndex = 0;
            this.tcOco.Size = new System.Drawing.Size(674, 439);
            this.tcOco.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.e_EDIT_ADD);
            this.tabPage1.Controls.Add(this.btn_del_servidor);
            this.tabPage1.Controls.Add(this.btn_add_servidor);
            this.tabPage1.Controls.Add(this.btn_del_jovem);
            this.tabPage1.Controls.Add(this.btn_add_jovem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.eTPOcorrencia);
            this.tabPage1.Controls.Add(this.eRetorno);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.eServidores);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.eJovens);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.eDTOcorrencia);
            this.tabPage1.Controls.Add(this.eLOCAL_DT);
            this.tabPage1.Controls.Add(this.eAcao);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(666, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados da Ocorrência";
            // 
            // e_EDIT_ADD
            // 
            this.e_EDIT_ADD.AutoSize = true;
            this.e_EDIT_ADD.Location = new System.Drawing.Point(482, 86);
            this.e_EDIT_ADD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_EDIT_ADD.Name = "e_EDIT_ADD";
            this.e_EDIT_ADD.Size = new System.Drawing.Size(47, 20);
            this.e_EDIT_ADD.TabIndex = 62;
            this.e_EDIT_ADD.Text = "ADD";
            this.e_EDIT_ADD.Visible = false;
            // 
            // btn_del_servidor
            // 
            this.btn_del_servidor.FlatAppearance.BorderSize = 0;
            this.btn_del_servidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_servidor.Image = global::DITI_LIVROM.Properties.Resources.bt_delete;
            this.btn_del_servidor.Location = new System.Drawing.Point(632, 98);
            this.btn_del_servidor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del_servidor.Name = "btn_del_servidor";
            this.btn_del_servidor.Size = new System.Drawing.Size(22, 23);
            this.btn_del_servidor.TabIndex = 61;
            this.btn_del_servidor.UseVisualStyleBackColor = true;
            this.btn_del_servidor.Click += new System.EventHandler(this.btn_del_servidor_Click);
            // 
            // btn_add_servidor
            // 
            this.btn_add_servidor.FlatAppearance.BorderSize = 0;
            this.btn_add_servidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_servidor.Image = global::DITI_LIVROM.Properties.Resources.bt_add;
            this.btn_add_servidor.Location = new System.Drawing.Point(604, 98);
            this.btn_add_servidor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_servidor.Name = "btn_add_servidor";
            this.btn_add_servidor.Size = new System.Drawing.Size(22, 23);
            this.btn_add_servidor.TabIndex = 60;
            this.btn_add_servidor.UseVisualStyleBackColor = true;
            this.btn_add_servidor.Click += new System.EventHandler(this.btn_add_servidor_Click);
            // 
            // btn_del_jovem
            // 
            this.btn_del_jovem.FlatAppearance.BorderSize = 0;
            this.btn_del_jovem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_jovem.Image = global::DITI_LIVROM.Properties.Resources.bt_delete;
            this.btn_del_jovem.Location = new System.Drawing.Point(304, 98);
            this.btn_del_jovem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del_jovem.Name = "btn_del_jovem";
            this.btn_del_jovem.Size = new System.Drawing.Size(22, 23);
            this.btn_del_jovem.TabIndex = 59;
            this.btn_del_jovem.UseVisualStyleBackColor = true;
            this.btn_del_jovem.Click += new System.EventHandler(this.btn_del_jovem_Click);
            // 
            // btn_add_jovem
            // 
            this.btn_add_jovem.FlatAppearance.BorderSize = 0;
            this.btn_add_jovem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_jovem.Image = global::DITI_LIVROM.Properties.Resources.bt_add;
            this.btn_add_jovem.Location = new System.Drawing.Point(278, 98);
            this.btn_add_jovem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_jovem.Name = "btn_add_jovem";
            this.btn_add_jovem.Size = new System.Drawing.Size(22, 23);
            this.btn_add_jovem.TabIndex = 58;
            this.btn_add_jovem.UseVisualStyleBackColor = true;
            this.btn_add_jovem.Click += new System.EventHandler(this.btn_add_jovem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tipo de Ocorrência:";
            // 
            // eTPOcorrencia
            // 
            this.eTPOcorrencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eTPOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.eTPOcorrencia.FormattingEnabled = true;
            this.eTPOcorrencia.Location = new System.Drawing.Point(184, 11);
            this.eTPOcorrencia.Margin = new System.Windows.Forms.Padding(2);
            this.eTPOcorrencia.Name = "eTPOcorrencia";
            this.eTPOcorrencia.Size = new System.Drawing.Size(471, 25);
            this.eTPOcorrencia.TabIndex = 56;
            // 
            // eRetorno
            // 
            this.eRetorno.AutoSize = true;
            this.eRetorno.Location = new System.Drawing.Point(580, 54);
            this.eRetorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eRetorno.Name = "eRetorno";
            this.eRetorno.Size = new System.Drawing.Size(84, 20);
            this.eRetorno.TabIndex = 55;
            this.eRetorno.Text = "eRetorno";
            this.eRetorno.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Servidores";
            // 
            // eServidores
            // 
            this.eServidores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SERV_NOME,
            this.SERV_COD});
            this.eServidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eServidores.FullRowSelect = true;
            this.eServidores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eServidores.Location = new System.Drawing.Point(342, 126);
            this.eServidores.Margin = new System.Windows.Forms.Padding(2);
            this.eServidores.Name = "eServidores";
            this.eServidores.Size = new System.Drawing.Size(314, 268);
            this.eServidores.TabIndex = 53;
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
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Jovens";
            // 
            // eJovens
            // 
            this.eJovens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JOVEM_NOME,
            this.JOVEM_COD});
            this.eJovens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eJovens.FullRowSelect = true;
            this.eJovens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eJovens.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eJovens.Location = new System.Drawing.Point(14, 126);
            this.eJovens.Margin = new System.Windows.Forms.Padding(2);
            this.eJovens.MultiSelect = false;
            this.eJovens.Name = "eJovens";
            this.eJovens.Size = new System.Drawing.Size(314, 268);
            this.eJovens.TabIndex = 51;
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
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Data da Ocorrência:";
            // 
            // eDTOcorrencia
            // 
            this.eDTOcorrencia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTOcorrencia.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.eDTOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTOcorrencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eDTOcorrencia.Location = new System.Drawing.Point(184, 50);
            this.eDTOcorrencia.Margin = new System.Windows.Forms.Padding(2);
            this.eDTOcorrencia.Name = "eDTOcorrencia";
            this.eDTOcorrencia.Size = new System.Drawing.Size(186, 24);
            this.eDTOcorrencia.TabIndex = 49;
            this.eDTOcorrencia.ValueChanged += new System.EventHandler(this.eDTOcorrencia_ValueChanged);
            // 
            // eLOCAL_DT
            // 
            this.eLOCAL_DT.AutoSize = true;
            this.eLOCAL_DT.Location = new System.Drawing.Point(473, 52);
            this.eLOCAL_DT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eLOCAL_DT.Name = "eLOCAL_DT";
            this.eLOCAL_DT.Size = new System.Drawing.Size(109, 20);
            this.eLOCAL_DT.TabIndex = 48;
            this.eLOCAL_DT.Text = "eLOCAL_DT";
            this.eLOCAL_DT.Visible = false;
            // 
            // eAcao
            // 
            this.eAcao.AutoSize = true;
            this.eAcao.Location = new System.Drawing.Point(398, 50);
            this.eAcao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eAcao.Name = "eAcao";
            this.eAcao.Size = new System.Drawing.Size(60, 20);
            this.eAcao.TabIndex = 47;
            this.eAcao.Text = "eAcao";
            this.eAcao.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.eFrase);
            this.tabPage2.Controls.Add(this.tbar);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(666, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ocorrência";
            // 
            // eFrase
            // 
            this.eFrase.AcceptsTab = true;
            this.eFrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eFrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFrase.Location = new System.Drawing.Point(2, 29);
            this.eFrase.Margin = new System.Windows.Forms.Padding(2);
            this.eFrase.Name = "eFrase";
            this.eFrase.Size = new System.Drawing.Size(662, 378);
            this.eFrase.TabIndex = 22;
            this.eFrase.Text = "";
            this.eFrase.SelectionChanged += new System.EventHandler(this.eFrase_SelectionChanged);
            // 
            // tbar
            // 
            this.tbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbar_negrito,
            this.tbar_italico,
            this.tbar_sobrescrito,
            this.toolStripSeparator1,
            this.tbar_fonte,
            this.toolStripSeparator2,
            this.tbar_color,
            this.toolStripSeparator3,
            this.tbar_picture,
            this.toolStripSeparator5,
            this.tbar_cortar,
            this.tbar_copiar,
            this.tbar_colar,
            this.toolStripSeparator4,
            this.tbar_aling_esquerda,
            this.tbar_aling_centro,
            this.tbar_aling_direita,
            this.toolStripSeparator6,
            this.tbar_bullet});
            this.tbar.Location = new System.Drawing.Point(2, 2);
            this.tbar.Name = "tbar";
            this.tbar.Size = new System.Drawing.Size(662, 27);
            this.tbar.TabIndex = 23;
            this.tbar.Text = "toolStrip1";
            // 
            // tbar_negrito
            // 
            this.tbar_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_negrito.Image = global::DITI_LIVROM.Properties.Resources.tbar1;
            this.tbar_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_negrito.Name = "tbar_negrito";
            this.tbar_negrito.Size = new System.Drawing.Size(24, 24);
            this.tbar_negrito.Text = "Negrito";
            this.tbar_negrito.Click += new System.EventHandler(this.tbar_negrito_Click);
            // 
            // tbar_italico
            // 
            this.tbar_italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_italico.Image = global::DITI_LIVROM.Properties.Resources.tbar2;
            this.tbar_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_italico.Name = "tbar_italico";
            this.tbar_italico.Size = new System.Drawing.Size(24, 24);
            this.tbar_italico.Text = "Itálico";
            this.tbar_italico.Click += new System.EventHandler(this.tbar_italico_Click);
            // 
            // tbar_sobrescrito
            // 
            this.tbar_sobrescrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_sobrescrito.Image = global::DITI_LIVROM.Properties.Resources.tbar3;
            this.tbar_sobrescrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_sobrescrito.Name = "tbar_sobrescrito";
            this.tbar_sobrescrito.Size = new System.Drawing.Size(24, 24);
            this.tbar_sobrescrito.Text = "Sobrescrito";
            this.tbar_sobrescrito.Click += new System.EventHandler(this.tbar_sobrescrito_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbar_fonte
            // 
            this.tbar_fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_fonte.Image = global::DITI_LIVROM.Properties.Resources.tbar4;
            this.tbar_fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_fonte.Name = "tbar_fonte";
            this.tbar_fonte.Size = new System.Drawing.Size(24, 24);
            this.tbar_fonte.Text = "Formatar fonte";
            this.tbar_fonte.Click += new System.EventHandler(this.tbar_fonte_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbar_color
            // 
            this.tbar_color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_color.Image = global::DITI_LIVROM.Properties.Resources.tbar5;
            this.tbar_color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_color.Name = "tbar_color";
            this.tbar_color.Size = new System.Drawing.Size(24, 24);
            this.tbar_color.Text = "Formatar cor da fonte";
            this.tbar_color.Click += new System.EventHandler(this.tbar_color_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tbar_picture
            // 
            this.tbar_picture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_picture.Image = global::DITI_LIVROM.Properties.Resources.tbar13;
            this.tbar_picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_picture.Name = "tbar_picture";
            this.tbar_picture.Size = new System.Drawing.Size(24, 24);
            this.tbar_picture.Text = "Inserir uma imagem";
            this.tbar_picture.Click += new System.EventHandler(this.tbar_picture_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tbar_cortar
            // 
            this.tbar_cortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_cortar.Image = global::DITI_LIVROM.Properties.Resources.tbar6;
            this.tbar_cortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_cortar.Name = "tbar_cortar";
            this.tbar_cortar.Size = new System.Drawing.Size(24, 24);
            this.tbar_cortar.Text = "Recortar";
            this.tbar_cortar.Click += new System.EventHandler(this.tbar_cortar_Click);
            // 
            // tbar_copiar
            // 
            this.tbar_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_copiar.Image = global::DITI_LIVROM.Properties.Resources.tbar7;
            this.tbar_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_copiar.Name = "tbar_copiar";
            this.tbar_copiar.Size = new System.Drawing.Size(24, 24);
            this.tbar_copiar.Text = "Copiar";
            this.tbar_copiar.Click += new System.EventHandler(this.tbar_copiar_Click);
            // 
            // tbar_colar
            // 
            this.tbar_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_colar.Image = global::DITI_LIVROM.Properties.Resources.tbar8;
            this.tbar_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_colar.Name = "tbar_colar";
            this.tbar_colar.Size = new System.Drawing.Size(24, 24);
            this.tbar_colar.Text = "Colar";
            this.tbar_colar.Click += new System.EventHandler(this.tbar_colar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tbar_aling_esquerda
            // 
            this.tbar_aling_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_aling_esquerda.Image = global::DITI_LIVROM.Properties.Resources.tbar10;
            this.tbar_aling_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_aling_esquerda.Name = "tbar_aling_esquerda";
            this.tbar_aling_esquerda.Size = new System.Drawing.Size(24, 24);
            this.tbar_aling_esquerda.Text = "Alinhamento a esquerda";
            this.tbar_aling_esquerda.Click += new System.EventHandler(this.tbar_aling_esquerda_Click);
            // 
            // tbar_aling_centro
            // 
            this.tbar_aling_centro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_aling_centro.Image = global::DITI_LIVROM.Properties.Resources.tbar11;
            this.tbar_aling_centro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_aling_centro.Name = "tbar_aling_centro";
            this.tbar_aling_centro.Size = new System.Drawing.Size(24, 24);
            this.tbar_aling_centro.Text = "Alinhamento centralizado";
            this.tbar_aling_centro.Click += new System.EventHandler(this.tbar_aling_centro_Click);
            // 
            // tbar_aling_direita
            // 
            this.tbar_aling_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_aling_direita.Image = global::DITI_LIVROM.Properties.Resources.tbar12;
            this.tbar_aling_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_aling_direita.Name = "tbar_aling_direita";
            this.tbar_aling_direita.Size = new System.Drawing.Size(24, 24);
            this.tbar_aling_direita.Text = "Alinhamento a direita";
            this.tbar_aling_direita.Click += new System.EventHandler(this.tbar_aling_direita_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tbar_bullet
            // 
            this.tbar_bullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_bullet.Image = global::DITI_LIVROM.Properties.Resources.tbar14;
            this.tbar_bullet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_bullet.Name = "tbar_bullet";
            this.tbar_bullet.Size = new System.Drawing.Size(24, 24);
            this.tbar_bullet.Text = "Inserir marcador";
            this.tbar_bullet.Click += new System.EventHandler(this.tbar_bullet_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.eDTMD);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.eJovensMD_dia);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.eJovensMD_txt);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.eJovensMD);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(666, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Medida Disciplinar";
            // 
            // eDTMD
            // 
            this.eDTMD.AutoSize = true;
            this.eDTMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTMD.Location = new System.Drawing.Point(507, 371);
            this.eDTMD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eDTMD.Name = "eDTMD";
            this.eDTMD.Size = new System.Drawing.Size(124, 18);
            this.eDTMD.TabIndex = 58;
            this.eDTMD.Text = "00/00/00 00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 371);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 57;
            this.label7.Text = "Data de inicio:";
            // 
            // eJovensMD_dia
            // 
            this.eJovensMD_dia.Enabled = false;
            this.eJovensMD_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eJovensMD_dia.Location = new System.Drawing.Point(304, 370);
            this.eJovensMD_dia.Margin = new System.Windows.Forms.Padding(2);
            this.eJovensMD_dia.Name = "eJovensMD_dia";
            this.eJovensMD_dia.Size = new System.Drawing.Size(56, 24);
            this.eJovensMD_dia.TabIndex = 56;
            this.eJovensMD_dia.ValueChanged += new System.EventHandler(this.eJovensMD_dia_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Número de dias da Medida Disciplinar:";
            // 
            // eJovensMD_txt
            // 
            this.eJovensMD_txt.Enabled = false;
            this.eJovensMD_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eJovensMD_txt.Location = new System.Drawing.Point(166, 335);
            this.eJovensMD_txt.Margin = new System.Windows.Forms.Padding(2);
            this.eJovensMD_txt.MaxLength = 250;
            this.eJovensMD_txt.Name = "eJovensMD_txt";
            this.eJovensMD_txt.Size = new System.Drawing.Size(491, 24);
            this.eJovensMD_txt.TabIndex = 54;
            this.eJovensMD_txt.TextChanged += new System.EventHandler(this.eJovensMD_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 337);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Medida Disciplinar:";
            // 
            // eJovensMD
            // 
            this.eJovensMD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader2});
            this.eJovensMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eJovensMD.FullRowSelect = true;
            this.eJovensMD.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eJovensMD.HideSelection = false;
            this.eJovensMD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eJovensMD.LabelWrap = false;
            this.eJovensMD.Location = new System.Drawing.Point(11, 14);
            this.eJovensMD.Margin = new System.Windows.Forms.Padding(2);
            this.eJovensMD.MultiSelect = false;
            this.eJovensMD.Name = "eJovensMD";
            this.eJovensMD.Size = new System.Drawing.Size(646, 310);
            this.eJovensMD.TabIndex = 52;
            this.eJovensMD.UseCompatibleStateImageBehavior = false;
            this.eJovensMD.View = System.Windows.Forms.View.Details;
            this.eJovensMD.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.eJovensMD_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Jovem";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Medida Disciplinar";
            this.columnHeader3.Width = 270;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Dias";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 0;
            // 
            // imgEditor
            // 
            this.imgEditor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEditor.ImageStream")));
            this.imgEditor.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEditor.Images.SetKeyName(0, "text_bold.png");
            this.imgEditor.Images.SetKeyName(1, "text_italic.png");
            this.imgEditor.Images.SetKeyName(2, "text_underline.png");
            this.imgEditor.Images.SetKeyName(3, "font.png");
            this.imgEditor.Images.SetKeyName(4, "color_wheel.png");
            this.imgEditor.Images.SetKeyName(5, "picture.png");
            this.imgEditor.Images.SetKeyName(6, "color_swatch.png");
            this.imgEditor.Images.SetKeyName(7, "cut.png");
            this.imgEditor.Images.SetKeyName(8, "page_copy.png");
            this.imgEditor.Images.SetKeyName(9, "page_paste.png");
            this.imgEditor.Images.SetKeyName(10, "text_align_justify.png");
            this.imgEditor.Images.SetKeyName(11, "text_align_left.png");
            this.imgEditor.Images.SetKeyName(12, "text_align_center.png");
            this.imgEditor.Images.SetKeyName(13, "text_align_right.png");
            this.imgEditor.Images.SetKeyName(14, "accept.png");
            this.imgEditor.Images.SetKeyName(15, "add.png");
            this.imgEditor.Images.SetKeyName(16, "delete.png");
            this.imgEditor.Images.SetKeyName(17, "page_word.png");
            this.imgEditor.Images.SetKeyName(18, "bullet_disk.png");
            this.imgEditor.Images.SetKeyName(19, "magnifier.png");
            this.imgEditor.Images.SetKeyName(20, "date.png");
            this.imgEditor.Images.SetKeyName(21, "help.png");
            this.imgEditor.Images.SetKeyName(22, "images.png");
            this.imgEditor.Images.SetKeyName(23, "printer.png");
            this.imgEditor.Images.SetKeyName(24, "style.png");
            this.imgEditor.Images.SetKeyName(25, "text_bold.png");
            this.imgEditor.Images.SetKeyName(26, "text_dropcaps.png");
            this.imgEditor.Images.SetKeyName(27, "text_list_bullets.png");
            this.imgEditor.Images.SetKeyName(28, "tf_blue_save.gif");
            this.imgEditor.Images.SetKeyName(29, "tick.png");
            this.imgEditor.Images.SetKeyName(30, "zoom.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 37;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(563, 453);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(117, 41);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(388, 453);
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
            // frm_registra_livro_ocorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(688, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcOco);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_registra_livro_ocorrencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ocorrência no Livro";
            this.Load += new System.EventHandler(this.frm_registra_livro_ocorrencia_Load);
            this.tcOco.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tbar.ResumeLayout(false);
            this.tbar.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eJovensMD_dia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_salvar;
        internal System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.TabControl tcOco;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox eTPOcorrencia;
        public System.Windows.Forms.Label eRetorno;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView eServidores;
        public System.Windows.Forms.ColumnHeader SERV_NOME;
        public System.Windows.Forms.ColumnHeader SERV_COD;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView eJovens;
        public System.Windows.Forms.ColumnHeader JOVEM_NOME;
        public System.Windows.Forms.ColumnHeader JOVEM_COD;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker eDTOcorrencia;
        public System.Windows.Forms.Label eLOCAL_DT;
        public System.Windows.Forms.Label eAcao;
        public System.Windows.Forms.RichTextBox eFrase;
        private System.Windows.Forms.ToolStrip tbar;
        private System.Windows.Forms.ToolStripButton tbar_negrito;
        private System.Windows.Forms.ToolStripButton tbar_italico;
        private System.Windows.Forms.ToolStripButton tbar_sobrescrito;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbar_fonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbar_color;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbar_cortar;
        private System.Windows.Forms.ToolStripButton tbar_copiar;
        private System.Windows.Forms.ToolStripButton tbar_colar;
        private System.Windows.Forms.ToolStripButton tbar_picture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbar_aling_esquerda;
        private System.Windows.Forms.ToolStripButton tbar_aling_centro;
        private System.Windows.Forms.ToolStripButton tbar_aling_direita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tbar_bullet;
        public System.Windows.Forms.NumericUpDown eJovensMD_dia;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox eJovensMD_txt;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListView eJovensMD;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.Label eDTMD;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_del_jovem;
        private System.Windows.Forms.Button btn_add_jovem;
        private System.Windows.Forms.ImageList imgEditor;
        private System.Windows.Forms.Button btn_del_servidor;
        private System.Windows.Forms.Button btn_add_servidor;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label e_EDIT_ADD;
    }
}
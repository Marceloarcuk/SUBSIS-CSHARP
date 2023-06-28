namespace DITI_LIVROM
{
    partial class frm_registra_livro_alerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registra_livro_alerta));
            this.e_EDIT_ADD = new System.Windows.Forms.Label();
            this.btn_del_jovem = new System.Windows.Forms.Button();
            this.btn_add_jovem = new System.Windows.Forms.Button();
            this.eRetorno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eDTAlerta = new System.Windows.Forms.DateTimePicker();
            this.eLOCAL_DT = new System.Windows.Forms.Label();
            this.eAcao = new System.Windows.Forms.Label();
            this.eDTMD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eJovensMD_dia = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.eJovens_txt = new System.Windows.Forms.TextBox();
            this.eJovens = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgEditor = new System.Windows.Forms.ImageList(this.components);
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eTipo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eJovensMD_dia)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // e_EDIT_ADD
            // 
            this.e_EDIT_ADD.AutoSize = true;
            this.e_EDIT_ADD.Location = new System.Drawing.Point(509, 73);
            this.e_EDIT_ADD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_EDIT_ADD.Name = "e_EDIT_ADD";
            this.e_EDIT_ADD.Size = new System.Drawing.Size(30, 13);
            this.e_EDIT_ADD.TabIndex = 62;
            this.e_EDIT_ADD.Text = "ADD";
            // 
            // btn_del_jovem
            // 
            this.btn_del_jovem.FlatAppearance.BorderSize = 0;
            this.btn_del_jovem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_jovem.Image = global::DITI_LIVROM.Properties.Resources.bt_delete;
            this.btn_del_jovem.Location = new System.Drawing.Point(637, 75);
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
            this.btn_add_jovem.Location = new System.Drawing.Point(611, 75);
            this.btn_add_jovem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_jovem.Name = "btn_add_jovem";
            this.btn_add_jovem.Size = new System.Drawing.Size(22, 23);
            this.btn_add_jovem.TabIndex = 58;
            this.btn_add_jovem.UseVisualStyleBackColor = true;
            this.btn_add_jovem.Click += new System.EventHandler(this.btn_add_jovem_Click);
            // 
            // eRetorno
            // 
            this.eRetorno.AutoSize = true;
            this.eRetorno.Location = new System.Drawing.Point(608, 44);
            this.eRetorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eRetorno.Name = "eRetorno";
            this.eRetorno.Size = new System.Drawing.Size(51, 13);
            this.eRetorno.TabIndex = 55;
            this.eRetorno.Text = "eRetorno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Jovens";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Data da Ocorrência:";
            // 
            // eDTAlerta
            // 
            this.eDTAlerta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTAlerta.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.eDTAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTAlerta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eDTAlerta.Location = new System.Drawing.Point(183, 40);
            this.eDTAlerta.Margin = new System.Windows.Forms.Padding(2);
            this.eDTAlerta.Name = "eDTAlerta";
            this.eDTAlerta.Size = new System.Drawing.Size(186, 24);
            this.eDTAlerta.TabIndex = 49;
            this.eDTAlerta.ValueChanged += new System.EventHandler(this.eDTOcorrencia_ValueChanged);
            // 
            // eLOCAL_DT
            // 
            this.eLOCAL_DT.AutoSize = true;
            this.eLOCAL_DT.Location = new System.Drawing.Point(509, 44);
            this.eLOCAL_DT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eLOCAL_DT.Name = "eLOCAL_DT";
            this.eLOCAL_DT.Size = new System.Drawing.Size(68, 13);
            this.eLOCAL_DT.TabIndex = 48;
            this.eLOCAL_DT.Text = "eLOCAL_DT";
            // 
            // eAcao
            // 
            this.eAcao.AutoSize = true;
            this.eAcao.Location = new System.Drawing.Point(444, 44);
            this.eAcao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eAcao.Name = "eAcao";
            this.eAcao.Size = new System.Drawing.Size(38, 13);
            this.eAcao.TabIndex = 47;
            this.eAcao.Text = "eAcao";
            // 
            // eDTMD
            // 
            this.eDTMD.AutoSize = true;
            this.eDTMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDTMD.Location = new System.Drawing.Point(509, 380);
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
            this.label7.Location = new System.Drawing.Point(389, 380);
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
            this.eJovensMD_dia.Location = new System.Drawing.Point(226, 378);
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
            this.label6.Location = new System.Drawing.Point(10, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Número de dias de Alerta:";
            // 
            // eJovens_txt
            // 
            this.eJovens_txt.Enabled = false;
            this.eJovens_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eJovens_txt.Location = new System.Drawing.Point(499, 10);
            this.eJovens_txt.Margin = new System.Windows.Forms.Padding(2);
            this.eJovens_txt.MaxLength = 250;
            this.eJovens_txt.Name = "eJovens_txt";
            this.eJovens_txt.Size = new System.Drawing.Size(160, 24);
            this.eJovens_txt.TabIndex = 54;
            // 
            // eJovens
            // 
            this.eJovens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2});
            this.eJovens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eJovens.FullRowSelect = true;
            this.eJovens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eJovens.HideSelection = false;
            this.eJovens.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eJovens.LabelWrap = false;
            this.eJovens.Location = new System.Drawing.Point(13, 101);
            this.eJovens.Margin = new System.Windows.Forms.Padding(2);
            this.eJovens.MultiSelect = false;
            this.eJovens.Name = "eJovens";
            this.eJovens.Size = new System.Drawing.Size(646, 262);
            this.eJovens.TabIndex = 52;
            this.eJovens.UseCompatibleStateImageBehavior = false;
            this.eJovens.View = System.Windows.Forms.View.Details;
            this.eJovens.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.eJovensMD_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Jovem";
            this.columnHeader1.Width = 540;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dias";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader2
            // 
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
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(573, 440);
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
            this.btn_salvar.Location = new System.Drawing.Point(399, 440);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.eTipo);
            this.panel2.Controls.Add(this.btn_del_jovem);
            this.panel2.Controls.Add(this.eDTMD);
            this.panel2.Controls.Add(this.e_EDIT_ADD);
            this.panel2.Controls.Add(this.btn_add_jovem);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.eJovens);
            this.panel2.Controls.Add(this.eJovensMD_dia);
            this.panel2.Controls.Add(this.eDTAlerta);
            this.panel2.Controls.Add(this.eJovens_txt);
            this.panel2.Controls.Add(this.eRetorno);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.eAcao);
            this.panel2.Controls.Add(this.eLOCAL_DT);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 414);
            this.panel2.TabIndex = 63;
            // 
            // eTipo
            // 
            this.eTipo.AutoSize = true;
            this.eTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eTipo.ForeColor = System.Drawing.Color.Gold;
            this.eTipo.Location = new System.Drawing.Point(108, 10);
            this.eTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eTipo.Name = "eTipo";
            this.eTipo.Size = new System.Drawing.Size(62, 18);
            this.eTipo.TabIndex = 65;
            this.eTipo.Text = "Jovens";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 18);
            this.label15.TabIndex = 21;
            this.label15.Text = "Alerta";
            // 
            // frm_registra_livro_alerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(700, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_registra_livro_alerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Alerta";
            this.Load += new System.EventHandler(this.frm_registra_livro_alerta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eJovensMD_dia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_salvar;
        internal System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.Label eRetorno;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker eDTAlerta;
        public System.Windows.Forms.Label eLOCAL_DT;
        public System.Windows.Forms.Label eAcao;
        public System.Windows.Forms.NumericUpDown eJovensMD_dia;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox eJovens_txt;
        public System.Windows.Forms.ListView eJovens;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.Label eDTMD;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_del_jovem;
        private System.Windows.Forms.Button btn_add_jovem;
        private System.Windows.Forms.ImageList imgEditor;
        public System.Windows.Forms.Label e_EDIT_ADD;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label eTipo;
    }
}
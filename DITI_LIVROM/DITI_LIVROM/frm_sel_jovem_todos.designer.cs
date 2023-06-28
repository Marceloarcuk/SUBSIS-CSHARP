namespace DITI_LIVROM
{
    public partial class frm_sel_jovem_todos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Unidade", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Módulo 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Módulo 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Módulo 3", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Módulo 4", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Módulo 5", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Módulo 6", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Módulo 7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Módulo 8", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Módulo 9", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Módulo 10", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Módulo 11", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Módulo 12", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Módulo 13", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Módulo 14", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Módulo 15", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("aaaa");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sel_jovem_todos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAcao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eJovens = new System.Windows.Forms.ListView();
            this.JOVEM_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JOVEM_COD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.pnlAcao_bar = new System.Windows.Forms.Panel();
            this.lbCharA = new System.Windows.Forms.Label();
            this.lbChar = new System.Windows.Forms.Label();
            this.buscar_servidor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlAcao_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbAcao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.eJovens);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 455);
            this.panel1.TabIndex = 28;
            // 
            // lbAcao
            // 
            this.lbAcao.AutoSize = true;
            this.lbAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcao.Location = new System.Drawing.Point(296, 11);
            this.lbAcao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAcao.Name = "lbAcao";
            this.lbAcao.Size = new System.Drawing.Size(17, 18);
            this.lbAcao.TabIndex = 65;
            this.lbAcao.Text = "0";
            this.lbAcao.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Jovens";
            // 
            // eJovens
            // 
            this.eJovens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JOVEM_NOME,
            this.JOVEM_COD});
            this.eJovens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eJovens.FullRowSelect = true;
            listViewGroup1.Header = "Unidade";
            listViewGroup1.Name = "m0";
            listViewGroup2.Header = "Módulo 1";
            listViewGroup2.Name = "m1";
            listViewGroup3.Header = "Módulo 2";
            listViewGroup3.Name = "m2";
            listViewGroup4.Header = "Módulo 3";
            listViewGroup4.Name = "m3";
            listViewGroup5.Header = "Módulo 4";
            listViewGroup5.Name = "m4";
            listViewGroup6.Header = "Módulo 5";
            listViewGroup6.Name = "m5";
            listViewGroup7.Header = "Módulo 6";
            listViewGroup7.Name = "m6";
            listViewGroup8.Header = "Módulo 7";
            listViewGroup8.Name = "m7";
            listViewGroup9.Header = "Módulo 8";
            listViewGroup9.Name = "m8";
            listViewGroup10.Header = "Módulo 9";
            listViewGroup10.Name = "m9";
            listViewGroup11.Header = "Módulo 10";
            listViewGroup11.Name = "m10";
            listViewGroup12.Header = "Módulo 11";
            listViewGroup12.Name = "m11";
            listViewGroup13.Header = "Módulo 12";
            listViewGroup13.Name = "m12";
            listViewGroup14.Header = "Módulo 13";
            listViewGroup14.Name = "m13";
            listViewGroup15.Header = "Módulo 14";
            listViewGroup15.Name = "m14";
            listViewGroup16.Header = "Módulo 15";
            listViewGroup16.Name = "m15";
            this.eJovens.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16});
            this.eJovens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eJovens.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            listViewItem1.Group = listViewGroup2;
            this.eJovens.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.eJovens.Location = new System.Drawing.Point(12, 41);
            this.eJovens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eJovens.Name = "eJovens";
            this.eJovens.Size = new System.Drawing.Size(640, 400);
            this.eJovens.TabIndex = 53;
            this.eJovens.UseCompatibleStateImageBehavior = false;
            this.eJovens.View = System.Windows.Forms.View.Details;
            // 
            // JOVEM_NOME
            // 
            this.JOVEM_NOME.Text = "";
            this.JOVEM_NOME.Width = 560;
            // 
            // JOVEM_COD
            // 
            this.JOVEM_COD.Text = "";
            this.JOVEM_COD.Width = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(569, 478);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 41);
            this.btn_cancelar.TabIndex = 30;
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
            this.btn_salvar.Location = new System.Drawing.Point(422, 478);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(143, 41);
            this.btn_salvar.TabIndex = 29;
            this.btn_salvar.TabStop = false;
            this.btn_salvar.Text = "Inserir Jovem";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // pnlAcao_bar
            // 
            this.pnlAcao_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlAcao_bar.Controls.Add(this.lbCharA);
            this.pnlAcao_bar.Controls.Add(this.lbChar);
            this.pnlAcao_bar.Controls.Add(this.buscar_servidor);
            this.pnlAcao_bar.Controls.Add(this.label5);
            this.pnlAcao_bar.Location = new System.Drawing.Point(3, 471);
            this.pnlAcao_bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAcao_bar.Name = "pnlAcao_bar";
            this.pnlAcao_bar.Size = new System.Drawing.Size(397, 56);
            this.pnlAcao_bar.TabIndex = 61;
            // 
            // lbCharA
            // 
            this.lbCharA.AutoSize = true;
            this.lbCharA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharA.Location = new System.Drawing.Point(336, -3);
            this.lbCharA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCharA.Name = "lbCharA";
            this.lbCharA.Size = new System.Drawing.Size(17, 18);
            this.lbCharA.TabIndex = 65;
            this.lbCharA.Text = "0";
            this.lbCharA.Visible = false;
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChar.Location = new System.Drawing.Point(381, 0);
            this.lbChar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(17, 18);
            this.lbChar.TabIndex = 64;
            this.lbChar.Text = "0";
            this.lbChar.Visible = false;
            this.lbChar.TextChanged += new System.EventHandler(this.lbChar_TextChanged);
            // 
            // buscar_servidor
            // 
            this.buscar_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_servidor.Location = new System.Drawing.Point(116, 19);
            this.buscar_servidor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buscar_servidor.MaxLength = 250;
            this.buscar_servidor.Name = "buscar_servidor";
            this.buscar_servidor.Size = new System.Drawing.Size(258, 23);
            this.buscar_servidor.TabIndex = 61;
            this.buscar_servidor.TextChanged += new System.EventHandler(this.buscar_servidor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Procurar jovem:";
            // 
            // frm_sel_jovem_todos
            // 
            this.AcceptButton = this.btn_salvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(685, 531);
            this.Controls.Add(this.pnlAcao_bar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_sel_jovem_todos";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Jovens da Unidade";
            this.Load += new System.EventHandler(this.frm_sobre_jovem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAcao_bar.ResumeLayout(false);
            this.pnlAcao_bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView eJovens;
        public System.Windows.Forms.ColumnHeader JOVEM_NOME;
        public System.Windows.Forms.ColumnHeader JOVEM_COD;
        internal System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel pnlAcao_bar;
        public System.Windows.Forms.Label lbChar;
        public System.Windows.Forms.TextBox buscar_servidor;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbAcao;
        public System.Windows.Forms.Label lbCharA;
    }
}

namespace DITI_CV
{
    partial class frm_jovem_sel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_jovem_sel));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("NAI", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Todos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("jose");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("marcio");
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.ed_localizar = new System.Windows.Forms.TextBox();
            this.ListViewJovens = new System.Windows.Forms.ListView();
            this.c_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_cod_secria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_sipia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_ident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_plantao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.id_processo = new System.Windows.Forms.Label();
            this.DOC_TIPO = new System.Windows.Forms.Label();
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Pesquisar);
            this.panel1.Controls.Add(this.ed_localizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 30);
            this.panel1.TabIndex = 31;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Image")));
            this.btn_Pesquisar.Location = new System.Drawing.Point(676, 2);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(31, 23);
            this.btn_Pesquisar.TabIndex = 16;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // ed_localizar
            // 
            this.ed_localizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ed_localizar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ed_localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_localizar.Location = new System.Drawing.Point(3, 3);
            this.ed_localizar.Name = "ed_localizar";
            this.ed_localizar.Size = new System.Drawing.Size(671, 20);
            this.ed_localizar.TabIndex = 15;
            // 
            // ListViewJovens
            // 
            this.ListViewJovens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_nome,
            this.c_cod_secria,
            this.c_sipia,
            this.c_cpf,
            this.c_ident,
            this.c_plantao});
            this.ListViewJovens.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "NAI";
            listViewGroup1.Name = "gNAI";
            listViewGroup2.Header = "Todos";
            listViewGroup2.Name = "gTOT";
            this.ListViewJovens.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            this.ListViewJovens.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.ListViewJovens.Location = new System.Drawing.Point(0, 30);
            this.ListViewJovens.MultiSelect = false;
            this.ListViewJovens.Name = "ListViewJovens";
            this.ListViewJovens.Size = new System.Drawing.Size(712, 466);
            this.ListViewJovens.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListViewJovens.TabIndex = 32;
            this.ListViewJovens.UseCompatibleStateImageBehavior = false;
            this.ListViewJovens.View = System.Windows.Forms.View.Details;
            // 
            // c_nome
            // 
            this.c_nome.Text = "Nome";
            this.c_nome.Width = 219;
            // 
            // c_cod_secria
            // 
            this.c_cod_secria.Text = "Código SECRIA";
            this.c_cod_secria.Width = 131;
            // 
            // c_sipia
            // 
            this.c_sipia.Text = "SIPIA";
            this.c_sipia.Width = 64;
            // 
            // c_cpf
            // 
            this.c_cpf.Text = "CPF";
            this.c_cpf.Width = 90;
            // 
            // c_ident
            // 
            this.c_ident.Text = "Doc. Identidade";
            this.c_ident.Width = 108;
            // 
            // c_plantao
            // 
            this.c_plantao.Text = "Plantão";
            this.c_plantao.Width = 71;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.id_processo);
            this.panel2.Controls.Add(this.DOC_TIPO);
            this.panel2.Controls.Add(this.btn_can);
            this.panel2.Controls.Add(this.btn_ok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 45);
            this.panel2.TabIndex = 33;
            // 
            // id_processo
            // 
            this.id_processo.AutoSize = true;
            this.id_processo.BackColor = System.Drawing.Color.Yellow;
            this.id_processo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_processo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.id_processo.Location = new System.Drawing.Point(155, 17);
            this.id_processo.Name = "id_processo";
            this.id_processo.Size = new System.Drawing.Size(18, 13);
            this.id_processo.TabIndex = 49;
            this.id_processo.Text = "-1";
            // 
            // DOC_TIPO
            // 
            this.DOC_TIPO.AutoSize = true;
            this.DOC_TIPO.BackColor = System.Drawing.Color.Yellow;
            this.DOC_TIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOC_TIPO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DOC_TIPO.Location = new System.Drawing.Point(11, 17);
            this.DOC_TIPO.Name = "DOC_TIPO";
            this.DOC_TIPO.Size = new System.Drawing.Size(18, 13);
            this.DOC_TIPO.TabIndex = 43;
            this.DOC_TIPO.Text = "-1";
            // 
            // btn_can
            // 
            this.btn_can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_can.Location = new System.Drawing.Point(390, 7);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(87, 33);
            this.btn_can.TabIndex = 33;
            this.btn_can.Text = "Cancelar";
            this.btn_can.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(297, 7);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(87, 33);
            this.btn_ok.TabIndex = 32;
            this.btn_ok.Text = "Selecionar";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // frm_jovem_sel
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_can;
            this.ClientSize = new System.Drawing.Size(712, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ListViewJovens);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_jovem_sel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecionar Adolescente";
            this.Load += new System.EventHandler(this.frm_jovem_sel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_Pesquisar;
        public System.Windows.Forms.TextBox ed_localizar;
        public System.Windows.Forms.ListView ListViewJovens;
        public System.Windows.Forms.ColumnHeader c_nome;
        public System.Windows.Forms.ColumnHeader c_cod_secria;
        public System.Windows.Forms.ColumnHeader c_sipia;
        public System.Windows.Forms.ColumnHeader c_cpf;
        public System.Windows.Forms.ColumnHeader c_ident;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ColumnHeader c_plantao;
        public System.Windows.Forms.Label DOC_TIPO;
        public System.Windows.Forms.Label id_processo;
    }
}
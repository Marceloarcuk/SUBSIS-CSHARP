namespace DITI_LIVROM
{
    partial class frm_sel_servidor_todos
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("aaaa");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sel_servidor_todos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAcao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eServidores = new System.Windows.Forms.ListView();
            this.SERV_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SERV_COD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.pnlAcao_bar = new System.Windows.Forms.Panel();
            this.lbCharA = new System.Windows.Forms.Label();
            this.lbChar = new System.Windows.Forms.Label();
            this.buscar_unidades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.eServidores);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 546);
            this.panel1.TabIndex = 28;
            // 
            // lbAcao
            // 
            this.lbAcao.AutoSize = true;
            this.lbAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcao.Location = new System.Drawing.Point(448, 14);
            this.lbAcao.Name = "lbAcao";
            this.lbAcao.Size = new System.Drawing.Size(21, 24);
            this.lbAcao.TabIndex = 66;
            this.lbAcao.Text = "0";
            this.lbAcao.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Servidores";
            // 
            // eServidores
            // 
            this.eServidores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SERV_NOME,
            this.SERV_COD});
            this.eServidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eServidores.FullRowSelect = true;
            this.eServidores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eServidores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eServidores.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.eServidores.Location = new System.Drawing.Point(16, 51);
            this.eServidores.Name = "eServidores";
            this.eServidores.Size = new System.Drawing.Size(852, 481);
            this.eServidores.TabIndex = 53;
            this.eServidores.UseCompatibleStateImageBehavior = false;
            this.eServidores.View = System.Windows.Forms.View.Details;
            // 
            // SERV_NOME
            // 
            this.SERV_NOME.Text = "";
            this.SERV_NOME.Width = 560;
            // 
            // SERV_COD
            // 
            this.SERV_COD.Text = "";
            this.SERV_COD.Width = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(760, 588);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 51);
            this.btn_cancelar.TabIndex = 32;
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
            this.btn_salvar.Location = new System.Drawing.Point(551, 588);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(203, 51);
            this.btn_salvar.TabIndex = 31;
            this.btn_salvar.TabStop = false;
            this.btn_salvar.Text = "Inserir Servidor";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // pnlAcao_bar
            // 
            this.pnlAcao_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlAcao_bar.Controls.Add(this.lbCharA);
            this.pnlAcao_bar.Controls.Add(this.lbChar);
            this.pnlAcao_bar.Controls.Add(this.buscar_unidades);
            this.pnlAcao_bar.Controls.Add(this.label1);
            this.pnlAcao_bar.Controls.Add(this.buscar_servidor);
            this.pnlAcao_bar.Controls.Add(this.label5);
            this.pnlAcao_bar.Location = new System.Drawing.Point(2, 566);
            this.pnlAcao_bar.Name = "pnlAcao_bar";
            this.pnlAcao_bar.Size = new System.Drawing.Size(529, 85);
            this.pnlAcao_bar.TabIndex = 60;
            // 
            // lbCharA
            // 
            this.lbCharA.AutoSize = true;
            this.lbCharA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharA.Location = new System.Drawing.Point(439, 48);
            this.lbCharA.Name = "lbCharA";
            this.lbCharA.Size = new System.Drawing.Size(21, 24);
            this.lbCharA.TabIndex = 66;
            this.lbCharA.Text = "0";
            this.lbCharA.Visible = false;
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChar.Location = new System.Drawing.Point(394, 48);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(21, 24);
            this.lbChar.TabIndex = 64;
            this.lbChar.Text = "0";
            this.lbChar.Visible = false;
            this.lbChar.TextChanged += new System.EventHandler(this.buscar_servidores);
            // 
            // buscar_unidades
            // 
            this.buscar_unidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buscar_unidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_unidades.FormattingEnabled = true;
            this.buscar_unidades.Items.AddRange(new object[] {
            "Atual",
            "Todas"});
            this.buscar_unidades.Location = new System.Drawing.Point(110, 47);
            this.buscar_unidades.Name = "buscar_unidades";
            this.buscar_unidades.Size = new System.Drawing.Size(168, 28);
            this.buscar_unidades.TabIndex = 63;
            this.buscar_unidades.SelectedIndexChanged += new System.EventHandler(this.buscar_servidores);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Unidades:";
            // 
            // buscar_servidor
            // 
            this.buscar_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_servidor.Location = new System.Drawing.Point(167, 9);
            this.buscar_servidor.MaxLength = 250;
            this.buscar_servidor.Name = "buscar_servidor";
            this.buscar_servidor.Size = new System.Drawing.Size(327, 27);
            this.buscar_servidor.TabIndex = 61;
            this.buscar_servidor.TextChanged += new System.EventHandler(this.buscar_servidor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Procurar servidor:";
            // 
            // frm_sel_servidor_todos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(913, 653);
            this.Controls.Add(this.pnlAcao_bar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_sel_servidor_todos";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Servidores da Unidade";
            this.Load += new System.EventHandler(this.frm_sobre_jovem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAcao_bar.ResumeLayout(false);
            this.pnlAcao_bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView eServidores;
        public System.Windows.Forms.ColumnHeader SERV_NOME;
        public System.Windows.Forms.ColumnHeader SERV_COD;
        internal System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel pnlAcao_bar;
        public System.Windows.Forms.Label lbChar;
        public System.Windows.Forms.TextBox buscar_servidor;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox buscar_unidades;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbCharA;
        public System.Windows.Forms.Label lbAcao;
    }
}

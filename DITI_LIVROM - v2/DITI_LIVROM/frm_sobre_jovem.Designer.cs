namespace DITI_LIVROM
{
    partial class frm_sobre_jovem
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "02/10/2016",
            "Briga com o interno José"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sobre_jovem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.LsvOcorrencia = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diasMedida_Label = new System.Windows.Forms.Label();
            this.diasMedida = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quarto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ala = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LsvHistorico = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LsvOcorrencia);
            this.panel1.Controls.Add(this.diasMedida_Label);
            this.panel1.Controls.Add(this.diasMedida);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.quarto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ala);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LsvHistorico);
            this.panel1.Controls.Add(this.nome);
            this.panel1.Controls.Add(this.codigo);
            this.panel1.Controls.Add(this.Foto);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 559);
            this.panel1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(421, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "Ocorrência Disciplinar";
            // 
            // LsvOcorrencia
            // 
            this.LsvOcorrencia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.LsvOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvOcorrencia.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LsvOcorrencia.Location = new System.Drawing.Point(425, 191);
            this.LsvOcorrencia.Name = "LsvOcorrencia";
            this.LsvOcorrencia.Size = new System.Drawing.Size(445, 325);
            this.LsvOcorrencia.TabIndex = 41;
            this.LsvOcorrencia.UseCompatibleStateImageBehavior = false;
            this.LsvOcorrencia.View = System.Windows.Forms.View.Details;
            this.LsvOcorrencia.DoubleClick += new System.EventHandler(this.LsvOcorrencia_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ocorrência";
            this.columnHeader4.Width = 187;
            // 
            // diasMedida_Label
            // 
            this.diasMedida_Label.AutoSize = true;
            this.diasMedida_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasMedida_Label.ForeColor = System.Drawing.Color.Maroon;
            this.diasMedida_Label.Location = new System.Drawing.Point(421, 519);
            this.diasMedida_Label.Name = "diasMedida_Label";
            this.diasMedida_Label.Size = new System.Drawing.Size(262, 24);
            this.diasMedida_Label.TabIndex = 40;
            this.diasMedida_Label.Text = "Dias de medida disciplinar:";
            // 
            // diasMedida
            // 
            this.diasMedida.AutoSize = true;
            this.diasMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasMedida.ForeColor = System.Drawing.Color.Maroon;
            this.diasMedida.Location = new System.Drawing.Point(699, 519);
            this.diasMedida.Name = "diasMedida";
            this.diasMedida.Size = new System.Drawing.Size(30, 24);
            this.diasMedida.TabIndex = 39;
            this.diasMedida.Text = "04";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Quarto:";
            // 
            // quarto
            // 
            this.quarto.AutoSize = true;
            this.quarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarto.Location = new System.Drawing.Point(267, 118);
            this.quarto.Name = "quarto";
            this.quarto.Size = new System.Drawing.Size(30, 24);
            this.quarto.TabIndex = 37;
            this.quarto.Text = "04";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ala/corredor:";
            // 
            // ala
            // 
            this.ala.AutoSize = true;
            this.ala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ala.Location = new System.Drawing.Point(322, 85);
            this.ala.Name = "ala";
            this.ala.Size = new System.Drawing.Size(55, 24);
            this.ala.TabIndex = 35;
            this.ala.Text = "Ala A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Histórico Diário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome do Jovem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Código do Jovem:";
            // 
            // LsvHistorico
            // 
            this.LsvHistorico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LsvHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvHistorico.Location = new System.Drawing.Point(17, 191);
            this.LsvHistorico.Name = "LsvHistorico";
            this.LsvHistorico.Size = new System.Drawing.Size(392, 352);
            this.LsvHistorico.TabIndex = 31;
            this.LsvHistorico.UseCompatibleStateImageBehavior = false;
            this.LsvHistorico.View = System.Windows.Forms.View.Details;
            this.LsvHistorico.DoubleClick += new System.EventHandler(this.LsvHistorico_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hora";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Histórico";
            this.columnHeader2.Width = 187;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(359, 50);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(60, 24);
            this.nome.TabIndex = 30;
            this.nome.Text = "label2";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(369, 16);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(60, 24);
            this.codigo.TabIndex = 29;
            this.codigo.Text = "label1";
            // 
            // Foto
            // 
            this.Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Foto.Image = ((System.Drawing.Image)(resources.GetObject("Foto.Image")));
            this.Foto.Location = new System.Drawing.Point(17, 16);
            this.Foto.Margin = new System.Windows.Forms.Padding(4);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(135, 135);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto.TabIndex = 28;
            this.Foto.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(780, 588);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 51);
            this.btn_cancelar.TabIndex = 29;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Text = "Fechar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_sobre_jovem
            // 
            this.AcceptButton = this.btn_cancelar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(913, 653);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_sobre_jovem";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'";
            this.Load += new System.EventHandler(this.frm_sobre_jovem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView LsvOcorrencia;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.Label diasMedida_Label;
        private System.Windows.Forms.Label diasMedida;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label quarto;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ala;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LsvHistorico;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label nome;
        public System.Windows.Forms.Label codigo;
        private System.Windows.Forms.PictureBox Foto;
        internal System.Windows.Forms.Button btn_cancelar;
    }
}

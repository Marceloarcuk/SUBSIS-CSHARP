namespace DITI_LIVROM
{
    partial class frm_livro_visualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_livro_visualizar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.eLivro = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbIDOcorrencia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPlantao = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.eLivro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 480);
            this.panel1.TabIndex = 28;
            // 
            // eLivro
            // 
            this.eLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eLivro.BackColor = System.Drawing.Color.White;
            this.eLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLivro.Location = new System.Drawing.Point(0, 37);
            this.eLivro.Margin = new System.Windows.Forms.Padding(2);
            this.eLivro.Name = "eLivro";
            this.eLivro.Size = new System.Drawing.Size(744, 441);
            this.eLivro.TabIndex = 43;
            this.eLivro.Text = resources.GetString("eLivro.Text");
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbIDOcorrencia);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lbPlantao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 37);
            this.panel2.TabIndex = 47;
            // 
            // lbIDOcorrencia
            // 
            this.lbIDOcorrencia.AutoSize = true;
            this.lbIDOcorrencia.BackColor = System.Drawing.Color.Yellow;
            this.lbIDOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDOcorrencia.Location = new System.Drawing.Point(511, 10);
            this.lbIDOcorrencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDOcorrencia.Name = "lbIDOcorrencia";
            this.lbIDOcorrencia.Size = new System.Drawing.Size(24, 18);
            this.lbIDOcorrencia.TabIndex = 44;
            this.lbIDOcorrencia.Text = "04";
            this.lbIDOcorrencia.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 46;
            this.label11.Text = "Plantão:";
            // 
            // lbPlantao
            // 
            this.lbPlantao.AutoSize = true;
            this.lbPlantao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlantao.Location = new System.Drawing.Point(97, 10);
            this.lbPlantao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlantao.Name = "lbPlantao";
            this.lbPlantao.Size = new System.Drawing.Size(41, 18);
            this.lbPlantao.TabIndex = 45;
            this.lbPlantao.Text = "Ala A";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::DITI_LIVROM.Properties.Resources.btn_cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(666, 10);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 41);
            this.btn_cancelar.TabIndex = 30;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Text = "Fechar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_cancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(9, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 53);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(19, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(746, 10);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(9, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 490);
            this.panel5.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(765, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 490);
            this.panel6.TabIndex = 34;
            // 
            // frm_livro_visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.MinimizeBox = false;
            this.Name = "frm_livro_visualizar";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Livro";
            this.Load += new System.EventHandler(this.frm_sobre_jovem_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RichTextBox eLivro;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbIDOcorrencia;
        public System.Windows.Forms.Label lbPlantao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

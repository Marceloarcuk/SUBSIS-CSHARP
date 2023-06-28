namespace DITI_CV
{
    partial class frm_processo
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.proc_num = new System.Windows.Forms.MaskedTextBox();
            this.proc_tipo = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.proc_id = new System.Windows.Forms.Label();
            this.proc_tipo_index = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.proc_num);
            this.groupBox5.Controls.Add(this.proc_tipo);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(584, 60);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Processo";
            // 
            // proc_num
            // 
            this.proc_num.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.proc_num.Location = new System.Drawing.Point(120, 27);
            this.proc_num.Mask = "9999.9999-9999";
            this.proc_num.Name = "proc_num";
            this.proc_num.Size = new System.Drawing.Size(135, 22);
            this.proc_num.TabIndex = 0;
            this.proc_num.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // proc_tipo
            // 
            this.proc_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proc_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_tipo.FormattingEnabled = true;
            this.proc_tipo.Location = new System.Drawing.Point(395, 27);
            this.proc_tipo.Name = "proc_tipo";
            this.proc_tipo.Size = new System.Drawing.Size(173, 21);
            this.proc_tipo.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(279, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Tipo de Processo:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label31.Location = new System.Drawing.Point(15, 31);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(99, 13);
            this.label31.TabIndex = 7;
            this.label31.Text = "Nº do Processo:";
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(416, 90);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(87, 33);
            this.btn_ok.TabIndex = 25;
            this.btn_ok.Text = "Salvar";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_can
            // 
            this.btn_can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_can.Location = new System.Drawing.Point(509, 90);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(87, 33);
            this.btn_can.TabIndex = 26;
            this.btn_can.Text = "Cancelar";
            this.btn_can.UseVisualStyleBackColor = true;
            // 
            // proc_id
            // 
            this.proc_id.AutoSize = true;
            this.proc_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.proc_id.Location = new System.Drawing.Point(16, 75);
            this.proc_id.Name = "proc_id";
            this.proc_id.Size = new System.Drawing.Size(18, 13);
            this.proc_id.TabIndex = 32;
            this.proc_id.Text = "-1";
            this.proc_id.Visible = false;
            // 
            // proc_tipo_index
            // 
            this.proc_tipo_index.AutoSize = true;
            this.proc_tipo_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_tipo_index.ForeColor = System.Drawing.SystemColors.ControlText;
            this.proc_tipo_index.Location = new System.Drawing.Point(16, 100);
            this.proc_tipo_index.Name = "proc_tipo_index";
            this.proc_tipo_index.Size = new System.Drawing.Size(14, 13);
            this.proc_tipo_index.TabIndex = 33;
            this.proc_tipo_index.Text = "0";
            this.proc_tipo_index.Visible = false;
            // 
            // frm_processo
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_can;
            this.ClientSize = new System.Drawing.Size(607, 142);
            this.Controls.Add(this.proc_tipo_index);
            this.Controls.Add(this.proc_id);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_processo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Processo";
            this.Load += new System.EventHandler(this.frm_processo_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_can;
        public System.Windows.Forms.Label proc_id;
        public System.Windows.Forms.MaskedTextBox proc_num;
        public System.Windows.Forms.ComboBox proc_tipo;
        public System.Windows.Forms.Label proc_tipo_index;
    }
}
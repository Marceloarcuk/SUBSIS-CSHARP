namespace DITI_CV
{
    partial class frm_audiencia
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
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.aud_resultado = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.aud_tipo = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.aud_data = new System.Windows.Forms.DateTimePicker();
            this.aud_realizado = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.aud_hora = new System.Windows.Forms.DateTimePicker();
            this.aud_obs = new System.Windows.Forms.TextBox();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_can
            // 
            this.btn_can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_can.Location = new System.Drawing.Point(641, 139);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(87, 33);
            this.btn_can.TabIndex = 28;
            this.btn_can.Text = "Cancelar";
            this.btn_can.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(548, 139);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(87, 33);
            this.btn_ok.TabIndex = 27;
            this.btn_ok.Text = "Salvar";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.aud_resultado);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.aud_tipo);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.aud_data);
            this.groupBox6.Controls.Add(this.aud_realizado);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.aud_hora);
            this.groupBox6.Controls.Add(this.aud_obs);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Navy;
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(716, 115);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Audiência";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label30.Location = new System.Drawing.Point(15, 84);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 13);
            this.label30.TabIndex = 16;
            this.label30.Text = "Resultado:";
            // 
            // aud_resultado
            // 
            this.aud_resultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.aud_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aud_resultado.Location = new System.Drawing.Point(96, 81);
            this.aud_resultado.Name = "aud_resultado";
            this.aud_resultado.Size = new System.Drawing.Size(606, 20);
            this.aud_resultado.TabIndex = 5;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(15, 58);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(79, 13);
            this.label29.TabIndex = 14;
            this.label29.Text = "Observação:";
            // 
            // aud_tipo
            // 
            this.aud_tipo.DisplayMember = "0";
            this.aud_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aud_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aud_tipo.FormattingEnabled = true;
            this.aud_tipo.Items.AddRange(new object[] {
            "Apresentação",
            "Continuação",
            "Leitura",
            "Internação-Sanção"});
            this.aud_tipo.Location = new System.Drawing.Point(584, 27);
            this.aud_tipo.Name = "aud_tipo";
            this.aud_tipo.Size = new System.Drawing.Size(118, 21);
            this.aud_tipo.TabIndex = 3;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(464, 30);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(114, 13);
            this.label28.TabIndex = 12;
            this.label28.Text = "Tipo de Audiência:";
            // 
            // aud_data
            // 
            this.aud_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aud_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aud_data.Location = new System.Drawing.Point(59, 28);
            this.aud_data.Name = "aud_data";
            this.aud_data.Size = new System.Drawing.Size(106, 20);
            this.aud_data.TabIndex = 0;
            // 
            // aud_realizado
            // 
            this.aud_realizado.DisplayMember = "0";
            this.aud_realizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aud_realizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aud_realizado.FormattingEnabled = true;
            this.aud_realizado.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.aud_realizado.Location = new System.Drawing.Point(393, 28);
            this.aud_realizado.Name = "aud_realizado";
            this.aud_realizado.Size = new System.Drawing.Size(56, 21);
            this.aud_realizado.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(320, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 13);
            this.label25.TabIndex = 9;
            this.label25.Text = "Realizada:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label26.Location = new System.Drawing.Point(182, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Hora:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(15, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 13);
            this.label27.TabIndex = 7;
            this.label27.Text = "Data:";
            // 
            // aud_hora
            // 
            this.aud_hora.CustomFormat = "time";
            this.aud_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aud_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.aud_hora.Location = new System.Drawing.Point(226, 27);
            this.aud_hora.Name = "aud_hora";
            this.aud_hora.ShowUpDown = true;
            this.aud_hora.Size = new System.Drawing.Size(76, 20);
            this.aud_hora.TabIndex = 1;
            // 
            // aud_obs
            // 
            this.aud_obs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.aud_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aud_obs.Location = new System.Drawing.Point(105, 55);
            this.aud_obs.Name = "aud_obs";
            this.aud_obs.Size = new System.Drawing.Size(597, 20);
            this.aud_obs.TabIndex = 4;
            // 
            // frm_audiencia
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_can;
            this.ClientSize = new System.Drawing.Size(743, 183);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_audiencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Audiência";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        public System.Windows.Forms.DateTimePicker aud_data;
        public System.Windows.Forms.DateTimePicker aud_hora;
        public System.Windows.Forms.ComboBox aud_realizado;
        public System.Windows.Forms.ComboBox aud_tipo;
        public System.Windows.Forms.TextBox aud_obs;
        public System.Windows.Forms.TextBox aud_resultado;

    }
}
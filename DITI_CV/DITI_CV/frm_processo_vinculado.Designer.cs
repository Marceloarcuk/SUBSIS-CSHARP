namespace DITI_CV
{
    partial class frm_processo_vinculado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_processo_vinculado));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1111.2222-2007", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("1111.2222-2007", 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("1234.1234-1324", 0);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.ed_localizar = new System.Windows.Forms.TextBox();
            this.ListViewProc = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.proc_id = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Controls.Add(this.ListViewProc);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(584, 317);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Processo Vinculado";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Pesquisar);
            this.panel1.Controls.Add(this.ed_localizar);
            this.panel1.Location = new System.Drawing.Point(18, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 30);
            this.panel1.TabIndex = 31;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Image")));
            this.btn_Pesquisar.Location = new System.Drawing.Point(513, 2);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(31, 23);
            this.btn_Pesquisar.TabIndex = 16;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.frm_processo_vinculado_Load);
            // 
            // ed_localizar
            // 
            this.ed_localizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ed_localizar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ed_localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_localizar.Location = new System.Drawing.Point(3, 3);
            this.ed_localizar.Name = "ed_localizar";
            this.ed_localizar.Size = new System.Drawing.Size(508, 20);
            this.ed_localizar.TabIndex = 15;
            // 
            // ListViewProc
            // 
            this.ListViewProc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewProc.FullRowSelect = true;
            this.ListViewProc.GridLines = true;
            this.ListViewProc.HideSelection = false;
            this.ListViewProc.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.ListViewProc.LargeImageList = this.imageList1;
            this.ListViewProc.Location = new System.Drawing.Point(18, 87);
            this.ListViewProc.Name = "ListViewProc";
            this.ListViewProc.Size = new System.Drawing.Size(549, 213);
            this.ListViewProc.SmallImageList = this.imageList1;
            this.ListViewProc.StateImageList = this.imageList1;
            this.ListViewProc.TabIndex = 32;
            this.ListViewProc.UseCompatibleStateImageBehavior = false;
            this.ListViewProc.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Blank-icon1.png");
            this.imageList1.Images.SetKeyName(1, "Blue-Blank-icon.png");
            this.imageList1.Images.SetKeyName(2, "date.png");
            this.imageList1.Images.SetKeyName(3, "date_next.png");
            this.imageList1.Images.SetKeyName(4, "page.png");
            this.imageList1.Images.SetKeyName(5, "page_green.png");
            this.imageList1.Images.SetKeyName(6, "page_red.png");
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label31.Location = new System.Drawing.Point(15, 31);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(253, 13);
            this.label31.TabIndex = 7;
            this.label31.Text = "Selecione o Processo que deseja vincular: ";
            // 
            // btn_can
            // 
            this.btn_can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_can.Location = new System.Drawing.Point(509, 336);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(87, 33);
            this.btn_can.TabIndex = 28;
            this.btn_can.Text = "Cancelar";
            this.btn_can.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(416, 336);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(87, 33);
            this.btn_ok.TabIndex = 27;
            this.btn_ok.Text = "Salvar";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // proc_id
            // 
            this.proc_id.AutoSize = true;
            this.proc_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.proc_id.Location = new System.Drawing.Point(27, 342);
            this.proc_id.Name = "proc_id";
            this.proc_id.Size = new System.Drawing.Size(18, 13);
            this.proc_id.TabIndex = 33;
            this.proc_id.Text = "-1";
            this.proc_id.Visible = false;
            // 
            // frm_processo_vinculado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 381);
            this.Controls.Add(this.proc_id);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_processo_vinculado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vincular Processo";
            this.Load += new System.EventHandler(this.frm_processo_vinculado_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox ed_localizar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.ListView ListViewProc;
        public System.Windows.Forms.Label proc_id;
    }
}
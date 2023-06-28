namespace DITI_LIVROM
{
    public partial class frm_main
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1", -2, -2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node5", -2, -2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("aa", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("bb", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("cc", 1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("dd", 2);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("ee", 3);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("zzzz", 4);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("zzzzzz", 5);
            this.pnl_Cont = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlAcao_cont = new System.Windows.Forms.Panel();
            this.LsvAcoes = new System.Windows.Forms.TreeView();
            this.ImgListAcoes = new System.Windows.Forms.ImageList(this.components);
            this.pnlAcao_bar = new System.Windows.Forms.Panel();
            this.btn_plantao_visualizar = new System.Windows.Forms.Button();
            this.btn_plantao_transf = new System.Windows.Forms.Button();
            this.btn_plantao_contagem = new System.Windows.Forms.Button();
            this.lb_plantao = new System.Windows.Forms.Label();
            this.lb_total_jovens = new System.Windows.Forms.Label();
            this.pnlServidor_Cont = new System.Windows.Forms.Panel();
            this.LsvServidor = new System.Windows.Forms.ListView();
            this.Lsv_col_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lsv_col_Cargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lsv_col_Matricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lsv_col_CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImgList24 = new System.Windows.Forms.ImageList(this.components);
            this.ImgList16 = new System.Windows.Forms.ImageList(this.components);
            this.pnlServidor_bar = new System.Windows.Forms.Panel();
            this.lbCharA = new System.Windows.Forms.Label();
            this.lbChar = new System.Windows.Forms.Label();
            this.buscar_servidor = new System.Windows.Forms.TextBox();
            this.lb_servidores = new System.Windows.Forms.Label();
            this.btn_view_servidor = new System.Windows.Forms.Button();
            this.pnlExecutar_Cont = new System.Windows.Forms.Panel();
            this.btnRegistraAcao = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlJovens = new System.Windows.Forms.Panel();
            this.btn_check_jovens = new System.Windows.Forms.Button();
            this.btn_view_jovens = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bMenu = new System.Windows.Forms.MenuStrip();
            this.bMenu_arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_arquivo_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_Jovens = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_Jovens_ordenar_Nome = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_Jovens_ordenar_Quarto = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_Jovens_View = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_Servidor = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_Servidor_View = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_plantao = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_plantao_transf = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_plantao_contagem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.bMenu_plantao_visualizar_livro = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_configuracao = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_configuracao_layout = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_configuracao_layout_maior = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_configuracao_layout_menor = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_Jovens_Check_Todos = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.stSpace1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stDT = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.pnl_Cont.SuspendLayout();
            this.pnlAcao_cont.SuspendLayout();
            this.pnlAcao_bar.SuspendLayout();
            this.pnlServidor_Cont.SuspendLayout();
            this.pnlServidor_bar.SuspendLayout();
            this.pnlExecutar_Cont.SuspendLayout();
            this.pnlJovens.SuspendLayout();
            this.bMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Cont
            // 
            this.pnl_Cont.Controls.Add(this.splitter1);
            this.pnl_Cont.Controls.Add(this.pnlAcao_cont);
            this.pnl_Cont.Controls.Add(this.pnlServidor_Cont);
            this.pnl_Cont.Controls.Add(this.pnlExecutar_Cont);
            this.pnl_Cont.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Cont.Location = new System.Drawing.Point(864, 24);
            this.pnl_Cont.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Cont.Name = "pnl_Cont";
            this.pnl_Cont.Size = new System.Drawing.Size(379, 654);
            this.pnl_Cont.TabIndex = 58;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 249);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(379, 4);
            this.splitter1.TabIndex = 62;
            this.splitter1.TabStop = false;
            // 
            // pnlAcao_cont
            // 
            this.pnlAcao_cont.Controls.Add(this.LsvAcoes);
            this.pnlAcao_cont.Controls.Add(this.pnlAcao_bar);
            this.pnlAcao_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcao_cont.Location = new System.Drawing.Point(0, 0);
            this.pnlAcao_cont.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAcao_cont.Name = "pnlAcao_cont";
            this.pnlAcao_cont.Size = new System.Drawing.Size(379, 253);
            this.pnlAcao_cont.TabIndex = 59;
            // 
            // LsvAcoes
            // 
            this.LsvAcoes.BackColor = System.Drawing.Color.White;
            this.LsvAcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvAcoes.FullRowSelect = true;
            this.LsvAcoes.HideSelection = false;
            this.LsvAcoes.ImageIndex = 0;
            this.LsvAcoes.ImageList = this.ImgListAcoes;
            this.LsvAcoes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LsvAcoes.Location = new System.Drawing.Point(0, 58);
            this.LsvAcoes.Margin = new System.Windows.Forms.Padding(2);
            this.LsvAcoes.Name = "LsvAcoes";
            treeNode1.ImageIndex = -2;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = -2;
            treeNode1.Text = "Node1";
            treeNode2.ImageIndex = -2;
            treeNode2.Name = "Node5";
            treeNode2.SelectedImageIndex = -2;
            treeNode2.Text = "Node5";
            treeNode3.ImageIndex = 7;
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            this.LsvAcoes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.LsvAcoes.SelectedImageIndex = 0;
            this.LsvAcoes.ShowLines = false;
            this.LsvAcoes.ShowRootLines = false;
            this.LsvAcoes.Size = new System.Drawing.Size(379, 195);
            this.LsvAcoes.TabIndex = 18;
            this.LsvAcoes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LsvAcoes_AfterSelect);
            this.LsvAcoes.DoubleClick += new System.EventHandler(this.LsvAcoes_DoubleClick);
            // 
            // ImgListAcoes
            // 
            this.ImgListAcoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListAcoes.ImageStream")));
            this.ImgListAcoes.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListAcoes.Images.SetKeyName(0, "mod16.png");
            this.ImgListAcoes.Images.SetKeyName(1, "1a.png");
            this.ImgListAcoes.Images.SetKeyName(2, "2a.png");
            this.ImgListAcoes.Images.SetKeyName(3, "3a.png");
            this.ImgListAcoes.Images.SetKeyName(4, "4a.png");
            this.ImgListAcoes.Images.SetKeyName(5, "5a.png");
            this.ImgListAcoes.Images.SetKeyName(6, "6a.png");
            this.ImgListAcoes.Images.SetKeyName(7, "7a.png");
            this.ImgListAcoes.Images.SetKeyName(8, "8a.png");
            this.ImgListAcoes.Images.SetKeyName(9, "9a.png");
            this.ImgListAcoes.Images.SetKeyName(10, "10.png");
            this.ImgListAcoes.Images.SetKeyName(11, "11ba.png");
            this.ImgListAcoes.Images.SetKeyName(12, "12.png");
            this.ImgListAcoes.Images.SetKeyName(13, "13a.png");
            this.ImgListAcoes.Images.SetKeyName(14, "14a.png");
            this.ImgListAcoes.Images.SetKeyName(15, "15a.png");
            this.ImgListAcoes.Images.SetKeyName(16, "16a.png");
            this.ImgListAcoes.Images.SetKeyName(17, "17a.png");
            this.ImgListAcoes.Images.SetKeyName(18, "18a.png");
            this.ImgListAcoes.Images.SetKeyName(19, "19a.png");
            this.ImgListAcoes.Images.SetKeyName(20, "20.png");
            this.ImgListAcoes.Images.SetKeyName(21, "21.png");
            this.ImgListAcoes.Images.SetKeyName(22, "22a.png");
            this.ImgListAcoes.Images.SetKeyName(23, "Refresh.png");
            this.ImgListAcoes.Images.SetKeyName(24, "24a.png");
            this.ImgListAcoes.Images.SetKeyName(25, "25a.png");
            this.ImgListAcoes.Images.SetKeyName(26, "18a.png");
            this.ImgListAcoes.Images.SetKeyName(27, "19a.png");
            this.ImgListAcoes.Images.SetKeyName(28, "28a.png");
            this.ImgListAcoes.Images.SetKeyName(29, "28a.png");
            this.ImgListAcoes.Images.SetKeyName(30, "30a.png");
            this.ImgListAcoes.Images.SetKeyName(31, "28b.png");
            this.ImgListAcoes.Images.SetKeyName(32, "document--pencil.png");
            this.ImgListAcoes.Images.SetKeyName(33, "document--pencil.png");
            this.ImgListAcoes.Images.SetKeyName(34, "document--pencil.png");
            this.ImgListAcoes.Images.SetKeyName(35, "28a.png");
            this.ImgListAcoes.Images.SetKeyName(36, "Color.png");
            this.ImgListAcoes.Images.SetKeyName(37, "37.png");
            this.ImgListAcoes.Images.SetKeyName(38, "38.png");
            this.ImgListAcoes.Images.SetKeyName(39, "39.png");
            this.ImgListAcoes.Images.SetKeyName(40, "0 vazio - Copia (40).png");
            this.ImgListAcoes.Images.SetKeyName(41, "0 vazio - Copia (41).png");
            this.ImgListAcoes.Images.SetKeyName(42, "0 vazio - Copia (42).png");
            this.ImgListAcoes.Images.SetKeyName(43, "0 vazio - Copia (43).png");
            this.ImgListAcoes.Images.SetKeyName(44, "0 vazio - Copia (44).png");
            this.ImgListAcoes.Images.SetKeyName(45, "0 vazio - Copia (45).png");
            this.ImgListAcoes.Images.SetKeyName(46, "0 vazio - Copia (46).png");
            this.ImgListAcoes.Images.SetKeyName(47, "0 vazio - Copia (47).png");
            this.ImgListAcoes.Images.SetKeyName(48, "0 vazio - Copia (48).png");
            this.ImgListAcoes.Images.SetKeyName(49, "0 vazio - Copia (49).png");
            this.ImgListAcoes.Images.SetKeyName(50, "50a.png");
            this.ImgListAcoes.Images.SetKeyName(51, "51c.png");
            this.ImgListAcoes.Images.SetKeyName(52, "52c.png");
            this.ImgListAcoes.Images.SetKeyName(53, "53.png");
            this.ImgListAcoes.Images.SetKeyName(54, "OCORRENCIA.png");
            this.ImgListAcoes.Images.SetKeyName(55, "55.png");
            this.ImgListAcoes.Images.SetKeyName(56, "56.png");
            this.ImgListAcoes.Images.SetKeyName(57, "57.png");
            this.ImgListAcoes.Images.SetKeyName(58, "58.png");
            this.ImgListAcoes.Images.SetKeyName(59, "59.png");
            this.ImgListAcoes.Images.SetKeyName(60, "mod16.png");
            this.ImgListAcoes.Images.SetKeyName(61, "60.png");
            this.ImgListAcoes.Images.SetKeyName(62, "0 vazio.png");
            this.ImgListAcoes.Images.SetKeyName(63, "0 vazio.png");
            this.ImgListAcoes.Images.SetKeyName(64, "_.png");
            this.ImgListAcoes.Images.SetKeyName(65, "52d.png");
            this.ImgListAcoes.Images.SetKeyName(66, "21a.png");
            // 
            // pnlAcao_bar
            // 
            this.pnlAcao_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlAcao_bar.Controls.Add(this.btn_plantao_visualizar);
            this.pnlAcao_bar.Controls.Add(this.btn_plantao_transf);
            this.pnlAcao_bar.Controls.Add(this.btn_plantao_contagem);
            this.pnlAcao_bar.Controls.Add(this.lb_plantao);
            this.pnlAcao_bar.Controls.Add(this.lb_total_jovens);
            this.pnlAcao_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcao_bar.Location = new System.Drawing.Point(0, 0);
            this.pnlAcao_bar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAcao_bar.Name = "pnlAcao_bar";
            this.pnlAcao_bar.Size = new System.Drawing.Size(379, 58);
            this.pnlAcao_bar.TabIndex = 17;
            // 
            // btn_plantao_visualizar
            // 
            this.btn_plantao_visualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_plantao_visualizar.FlatAppearance.BorderSize = 0;
            this.btn_plantao_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plantao_visualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_plantao_visualizar.Image")));
            this.btn_plantao_visualizar.Location = new System.Drawing.Point(348, 34);
            this.btn_plantao_visualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_plantao_visualizar.Name = "btn_plantao_visualizar";
            this.btn_plantao_visualizar.Size = new System.Drawing.Size(20, 20);
            this.btn_plantao_visualizar.TabIndex = 41;
            this.btn_plantao_visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_plantao_visualizar.UseVisualStyleBackColor = true;
            this.btn_plantao_visualizar.Click += new System.EventHandler(this.bMenu_plantao_visualizar_livro_Click);
            // 
            // btn_plantao_transf
            // 
            this.btn_plantao_transf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_plantao_transf.FlatAppearance.BorderSize = 0;
            this.btn_plantao_transf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plantao_transf.Image = ((System.Drawing.Image)(resources.GetObject("btn_plantao_transf.Image")));
            this.btn_plantao_transf.Location = new System.Drawing.Point(281, 34);
            this.btn_plantao_transf.Margin = new System.Windows.Forms.Padding(2);
            this.btn_plantao_transf.Name = "btn_plantao_transf";
            this.btn_plantao_transf.Size = new System.Drawing.Size(20, 20);
            this.btn_plantao_transf.TabIndex = 40;
            this.btn_plantao_transf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_plantao_transf.UseVisualStyleBackColor = true;
            this.btn_plantao_transf.Visible = false;
            this.btn_plantao_transf.Click += new System.EventHandler(this.bMenu_plantao_transf_Click);
            // 
            // btn_plantao_contagem
            // 
            this.btn_plantao_contagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_plantao_contagem.FlatAppearance.BorderSize = 0;
            this.btn_plantao_contagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plantao_contagem.Image = ((System.Drawing.Image)(resources.GetObject("btn_plantao_contagem.Image")));
            this.btn_plantao_contagem.Location = new System.Drawing.Point(316, 34);
            this.btn_plantao_contagem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_plantao_contagem.Name = "btn_plantao_contagem";
            this.btn_plantao_contagem.Size = new System.Drawing.Size(20, 20);
            this.btn_plantao_contagem.TabIndex = 39;
            this.btn_plantao_contagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_plantao_contagem.UseVisualStyleBackColor = true;
            this.btn_plantao_contagem.Click += new System.EventHandler(this.bMenu_plantao_contagem_Click);
            // 
            // lb_plantao
            // 
            this.lb_plantao.AutoSize = true;
            this.lb_plantao.BackColor = System.Drawing.Color.Transparent;
            this.lb_plantao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_plantao.ForeColor = System.Drawing.Color.White;
            this.lb_plantao.Location = new System.Drawing.Point(7, 7);
            this.lb_plantao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_plantao.Name = "lb_plantao";
            this.lb_plantao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_plantao.Size = new System.Drawing.Size(175, 20);
            this.lb_plantao.TabIndex = 37;
            this.lb_plantao.Text = "Total de Jovens: 000";
            this.lb_plantao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_total_jovens
            // 
            this.lb_total_jovens.AutoSize = true;
            this.lb_total_jovens.BackColor = System.Drawing.Color.Transparent;
            this.lb_total_jovens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_jovens.ForeColor = System.Drawing.Color.White;
            this.lb_total_jovens.Location = new System.Drawing.Point(7, 28);
            this.lb_total_jovens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total_jovens.Name = "lb_total_jovens";
            this.lb_total_jovens.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_total_jovens.Size = new System.Drawing.Size(175, 20);
            this.lb_total_jovens.TabIndex = 28;
            this.lb_total_jovens.Text = "Total de Jovens: 000";
            this.lb_total_jovens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlServidor_Cont
            // 
            this.pnlServidor_Cont.Controls.Add(this.LsvServidor);
            this.pnlServidor_Cont.Controls.Add(this.pnlServidor_bar);
            this.pnlServidor_Cont.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlServidor_Cont.Location = new System.Drawing.Point(0, 253);
            this.pnlServidor_Cont.Margin = new System.Windows.Forms.Padding(2);
            this.pnlServidor_Cont.Name = "pnlServidor_Cont";
            this.pnlServidor_Cont.Size = new System.Drawing.Size(379, 349);
            this.pnlServidor_Cont.TabIndex = 58;
            // 
            // LsvServidor
            // 
            this.LsvServidor.BackColor = System.Drawing.Color.White;
            this.LsvServidor.CheckBoxes = true;
            this.LsvServidor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lsv_col_Nome,
            this.Lsv_col_Cargo,
            this.Lsv_col_Matricula,
            this.Lsv_col_CPF});
            this.LsvServidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvServidor.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            this.LsvServidor.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.LsvServidor.LargeImageList = this.ImgList24;
            this.LsvServidor.Location = new System.Drawing.Point(0, 30);
            this.LsvServidor.Margin = new System.Windows.Forms.Padding(2);
            this.LsvServidor.MultiSelect = false;
            this.LsvServidor.Name = "LsvServidor";
            this.LsvServidor.Size = new System.Drawing.Size(379, 319);
            this.LsvServidor.SmallImageList = this.ImgList16;
            this.LsvServidor.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LsvServidor.TabIndex = 18;
            this.LsvServidor.UseCompatibleStateImageBehavior = false;
            this.LsvServidor.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LsvServidor_ColumnClick);
            this.LsvServidor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LsvServidor_MouseClick);
            // 
            // Lsv_col_Nome
            // 
            this.Lsv_col_Nome.Text = "Nome";
            this.Lsv_col_Nome.Width = 220;
            // 
            // Lsv_col_Cargo
            // 
            this.Lsv_col_Cargo.Text = "Cargo";
            this.Lsv_col_Cargo.Width = 160;
            // 
            // Lsv_col_Matricula
            // 
            this.Lsv_col_Matricula.Text = "Matricula";
            this.Lsv_col_Matricula.Width = 90;
            // 
            // Lsv_col_CPF
            // 
            this.Lsv_col_CPF.Width = 0;
            // 
            // ImgList24
            // 
            this.ImgList24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList24.ImageStream")));
            this.ImgList24.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList24.Images.SetKeyName(0, "53 - 24.png");
            this.ImgList24.Images.SetKeyName(1, "53Fora - 24.png");
            this.ImgList24.Images.SetKeyName(2, "53Modulo - 24.png");
            this.ImgList24.Images.SetKeyName(3, "53Unidade - 24.png");
            this.ImgList24.Images.SetKeyName(4, "17.png");
            this.ImgList24.Images.SetKeyName(5, "15.png");
            this.ImgList24.Images.SetKeyName(6, "z17.png");
            this.ImgList24.Images.SetKeyName(7, "z15.png");
            this.ImgList24.Images.SetKeyName(8, "zz17.png");
            this.ImgList24.Images.SetKeyName(9, "zz15.png");
            // 
            // ImgList16
            // 
            this.ImgList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList16.ImageStream")));
            this.ImgList16.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList16.Images.SetKeyName(0, "53.png");
            this.ImgList16.Images.SetKeyName(1, "53Fora.png");
            this.ImgList16.Images.SetKeyName(2, "53Modulo.png");
            this.ImgList16.Images.SetKeyName(3, "53Unidade.png");
            this.ImgList16.Images.SetKeyName(4, "user-female.png");
            this.ImgList16.Images.SetKeyName(5, "user-juiz.png");
            this.ImgList16.Images.SetKeyName(6, "zuser-female.png");
            this.ImgList16.Images.SetKeyName(7, "zuser-juiz.png");
            this.ImgList16.Images.SetKeyName(8, "zzuser-female.png");
            this.ImgList16.Images.SetKeyName(9, "zzuser-juiz.png");
            // 
            // pnlServidor_bar
            // 
            this.pnlServidor_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlServidor_bar.Controls.Add(this.lbCharA);
            this.pnlServidor_bar.Controls.Add(this.lbChar);
            this.pnlServidor_bar.Controls.Add(this.buscar_servidor);
            this.pnlServidor_bar.Controls.Add(this.lb_servidores);
            this.pnlServidor_bar.Controls.Add(this.btn_view_servidor);
            this.pnlServidor_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlServidor_bar.Location = new System.Drawing.Point(0, 0);
            this.pnlServidor_bar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlServidor_bar.Name = "pnlServidor_bar";
            this.pnlServidor_bar.Size = new System.Drawing.Size(379, 30);
            this.pnlServidor_bar.TabIndex = 17;
            // 
            // lbCharA
            // 
            this.lbCharA.AutoSize = true;
            this.lbCharA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharA.Location = new System.Drawing.Point(239, 2);
            this.lbCharA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCharA.Name = "lbCharA";
            this.lbCharA.Size = new System.Drawing.Size(17, 18);
            this.lbCharA.TabIndex = 67;
            this.lbCharA.Text = "0";
            this.lbCharA.Visible = false;
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChar.Location = new System.Drawing.Point(284, 6);
            this.lbChar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(17, 18);
            this.lbChar.TabIndex = 66;
            this.lbChar.Text = "0";
            this.lbChar.Visible = false;
            this.lbChar.TextChanged += new System.EventHandler(this.lbChar_TextChanged);
            // 
            // buscar_servidor
            // 
            this.buscar_servidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscar_servidor.Location = new System.Drawing.Point(112, 2);
            this.buscar_servidor.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_servidor.Name = "buscar_servidor";
            this.buscar_servidor.Size = new System.Drawing.Size(224, 20);
            this.buscar_servidor.TabIndex = 28;
            this.buscar_servidor.TextChanged += new System.EventHandler(this.buscar_servidor_TextChanged);
            // 
            // lb_servidores
            // 
            this.lb_servidores.AutoSize = true;
            this.lb_servidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_servidores.ForeColor = System.Drawing.Color.White;
            this.lb_servidores.Location = new System.Drawing.Point(14, 4);
            this.lb_servidores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_servidores.Name = "lb_servidores";
            this.lb_servidores.Size = new System.Drawing.Size(84, 20);
            this.lb_servidores.TabIndex = 27;
            this.lb_servidores.Text = "Servidores";
            this.lb_servidores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_view_servidor
            // 
            this.btn_view_servidor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_view_servidor.FlatAppearance.BorderSize = 0;
            this.btn_view_servidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_servidor.Image = global::DITI_LIVROM.Properties.Resources.app_view;
            this.btn_view_servidor.Location = new System.Drawing.Point(351, 0);
            this.btn_view_servidor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_view_servidor.Name = "btn_view_servidor";
            this.btn_view_servidor.Size = new System.Drawing.Size(28, 30);
            this.btn_view_servidor.TabIndex = 0;
            this.btn_view_servidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_view_servidor.UseVisualStyleBackColor = true;
            this.btn_view_servidor.Click += new System.EventHandler(this.bMenu_Servidor_View_Click);
            // 
            // pnlExecutar_Cont
            // 
            this.pnlExecutar_Cont.Controls.Add(this.btnRegistraAcao);
            this.pnlExecutar_Cont.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExecutar_Cont.Location = new System.Drawing.Point(0, 602);
            this.pnlExecutar_Cont.Margin = new System.Windows.Forms.Padding(2);
            this.pnlExecutar_Cont.Name = "pnlExecutar_Cont";
            this.pnlExecutar_Cont.Size = new System.Drawing.Size(379, 52);
            this.pnlExecutar_Cont.TabIndex = 57;
            // 
            // btnRegistraAcao
            // 
            this.btnRegistraAcao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistraAcao.BackColor = System.Drawing.Color.Black;
            this.btnRegistraAcao.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegistraAcao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistraAcao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRegistraAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraAcao.ForeColor = System.Drawing.Color.White;
            this.btnRegistraAcao.Location = new System.Drawing.Point(7, 7);
            this.btnRegistraAcao.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistraAcao.Name = "btnRegistraAcao";
            this.btnRegistraAcao.Size = new System.Drawing.Size(368, 37);
            this.btnRegistraAcao.TabIndex = 51;
            this.btnRegistraAcao.Text = "&Registrar Ação no Livro";
            this.btnRegistraAcao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistraAcao.UseVisualStyleBackColor = false;
            this.btnRegistraAcao.Click += new System.EventHandler(this.btnRegistraAcao_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0 vazio.png");
            this.imageList1.Images.SetKeyName(1, "_.png");
            this.imageList1.Images.SetKeyName(2, "_.png");
            this.imageList1.Images.SetKeyName(3, "_.png");
            this.imageList1.Images.SetKeyName(4, "_.png");
            this.imageList1.Images.SetKeyName(5, "_.png");
            this.imageList1.Images.SetKeyName(6, "_.png");
            this.imageList1.Images.SetKeyName(7, "7a.png");
            this.imageList1.Images.SetKeyName(8, "8a.png");
            this.imageList1.Images.SetKeyName(9, "9a.png");
            this.imageList1.Images.SetKeyName(10, "Shoes_Icon_16.png");
            this.imageList1.Images.SetKeyName(11, "11a.png");
            this.imageList1.Images.SetKeyName(12, "12.png");
            this.imageList1.Images.SetKeyName(13, "13a.png");
            this.imageList1.Images.SetKeyName(14, "14a.png");
            this.imageList1.Images.SetKeyName(15, "15a.png");
            this.imageList1.Images.SetKeyName(16, "16a.png");
            this.imageList1.Images.SetKeyName(17, "17a.png");
            this.imageList1.Images.SetKeyName(18, "18a.png");
            this.imageList1.Images.SetKeyName(19, "19a.png");
            this.imageList1.Images.SetKeyName(20, "20.png");
            this.imageList1.Images.SetKeyName(21, "21.png");
            this.imageList1.Images.SetKeyName(22, "22.png");
            this.imageList1.Images.SetKeyName(23, "23.png");
            this.imageList1.Images.SetKeyName(24, "24.png");
            this.imageList1.Images.SetKeyName(25, "25a.png");
            this.imageList1.Images.SetKeyName(26, "26.png");
            this.imageList1.Images.SetKeyName(27, "27.png");
            this.imageList1.Images.SetKeyName(28, "28.png");
            this.imageList1.Images.SetKeyName(29, "29.png");
            this.imageList1.Images.SetKeyName(30, "30.png");
            this.imageList1.Images.SetKeyName(31, "0 vazio - Copia (31).png");
            this.imageList1.Images.SetKeyName(32, "0 vazio - Copia (32).png");
            this.imageList1.Images.SetKeyName(33, "0 vazio - Copia (33).png");
            this.imageList1.Images.SetKeyName(34, "0 vazio - Copia (34).png");
            this.imageList1.Images.SetKeyName(35, "0 vazio - Copia (35).png");
            this.imageList1.Images.SetKeyName(36, "0 vazio - Copia (36).png");
            this.imageList1.Images.SetKeyName(37, "0 vazio - Copia (37).png");
            this.imageList1.Images.SetKeyName(38, "0 vazio - Copia (38).png");
            this.imageList1.Images.SetKeyName(39, "0 vazio - Copia (39).png");
            this.imageList1.Images.SetKeyName(40, "0 vazio - Copia (40).png");
            this.imageList1.Images.SetKeyName(41, "0 vazio - Copia (41).png");
            this.imageList1.Images.SetKeyName(42, "0 vazio - Copia (42).png");
            this.imageList1.Images.SetKeyName(43, "0 vazio - Copia (43).png");
            this.imageList1.Images.SetKeyName(44, "0 vazio - Copia (44).png");
            this.imageList1.Images.SetKeyName(45, "0 vazio - Copia (45).png");
            this.imageList1.Images.SetKeyName(46, "0 vazio - Copia (46).png");
            this.imageList1.Images.SetKeyName(47, "0 vazio - Copia (47).png");
            this.imageList1.Images.SetKeyName(48, "0 vazio - Copia (48).png");
            this.imageList1.Images.SetKeyName(49, "0 vazio - Copia (49).png");
            this.imageList1.Images.SetKeyName(50, "50a.png");
            this.imageList1.Images.SetKeyName(51, "Cake_ChocolateCake.png");
            this.imageList1.Images.SetKeyName(52, "50.png");
            this.imageList1.Images.SetKeyName(53, "51.png");
            this.imageList1.Images.SetKeyName(54, "52.png");
            this.imageList1.Images.SetKeyName(55, "53.png");
            this.imageList1.Images.SetKeyName(56, "54.png");
            this.imageList1.Images.SetKeyName(57, "55.png");
            this.imageList1.Images.SetKeyName(58, "56.png");
            this.imageList1.Images.SetKeyName(59, "57.png");
            this.imageList1.Images.SetKeyName(60, "58.png");
            this.imageList1.Images.SetKeyName(61, "59.png");
            this.imageList1.Images.SetKeyName(62, "60.png");
            this.imageList1.Images.SetKeyName(63, "User_32x32.png");
            this.imageList1.Images.SetKeyName(64, "Breakfast.png");
            this.imageList1.Images.SetKeyName(65, "0 vazio.png");
            this.imageList1.Images.SetKeyName(66, "0 vazio.png");
            // 
            // pnlJovens
            // 
            this.pnlJovens.BackColor = System.Drawing.Color.White;
            this.pnlJovens.Controls.Add(this.panel1);
            this.pnlJovens.Controls.Add(this.btn_check_jovens);
            this.pnlJovens.Controls.Add(this.btn_view_jovens);
            this.pnlJovens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJovens.Location = new System.Drawing.Point(0, 24);
            this.pnlJovens.Margin = new System.Windows.Forms.Padding(2);
            this.pnlJovens.Name = "pnlJovens";
            this.pnlJovens.Size = new System.Drawing.Size(860, 632);
            this.pnlJovens.TabIndex = 60;
            this.pnlJovens.Resize += new System.EventHandler(this.pnlJovens_Resize);
            // 
            // btn_check_jovens
            // 
            this.btn_check_jovens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_jovens.FlatAppearance.BorderSize = 0;
            this.btn_check_jovens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check_jovens.Image = ((System.Drawing.Image)(resources.GetObject("btn_check_jovens.Image")));
            this.btn_check_jovens.Location = new System.Drawing.Point(817, 2);
            this.btn_check_jovens.Margin = new System.Windows.Forms.Padding(2);
            this.btn_check_jovens.Name = "btn_check_jovens";
            this.btn_check_jovens.Size = new System.Drawing.Size(17, 15);
            this.btn_check_jovens.TabIndex = 2;
            this.btn_check_jovens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_check_jovens.UseVisualStyleBackColor = true;
            this.btn_check_jovens.Click += new System.EventHandler(this.bMenu_Jovens_Check_Todos_Click);
            // 
            // btn_view_jovens
            // 
            this.btn_view_jovens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view_jovens.FlatAppearance.BorderSize = 0;
            this.btn_view_jovens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_jovens.Image = global::DITI_LIVROM.Properties.Resources.app_view;
            this.btn_view_jovens.Location = new System.Drawing.Point(838, 2);
            this.btn_view_jovens.Margin = new System.Windows.Forms.Padding(2);
            this.btn_view_jovens.Name = "btn_view_jovens";
            this.btn_view_jovens.Size = new System.Drawing.Size(17, 15);
            this.btn_view_jovens.TabIndex = 1;
            this.btn_view_jovens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_view_jovens.UseVisualStyleBackColor = true;
            this.btn_view_jovens.Click += new System.EventHandler(this.bMenu_Jovens_View_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bMenu
            // 
            this.bMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_arquivo,
            this.bMenu_Jovens,
            this.bMenu_Servidor,
            this.bMenu_plantao,
            this.bMenu_configuracao,
            this.editarToolStripMenuItem});
            this.bMenu.Location = new System.Drawing.Point(0, 0);
            this.bMenu.Name = "bMenu";
            this.bMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.bMenu.Size = new System.Drawing.Size(1243, 24);
            this.bMenu.TabIndex = 64;
            this.bMenu.Text = "menuStrip1";
            // 
            // bMenu_arquivo
            // 
            this.bMenu_arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_arquivo_sair});
            this.bMenu_arquivo.Name = "bMenu_arquivo";
            this.bMenu_arquivo.Size = new System.Drawing.Size(61, 20);
            this.bMenu_arquivo.Text = "&Arquivo";
            // 
            // bMenu_arquivo_sair
            // 
            this.bMenu_arquivo_sair.Name = "bMenu_arquivo_sair";
            this.bMenu_arquivo_sair.Size = new System.Drawing.Size(93, 22);
            this.bMenu_arquivo_sair.Text = "&Sair";
            this.bMenu_arquivo_sair.Click += new System.EventHandler(this.bMenu_arquivo_sair_Click);
            // 
            // bMenu_Jovens
            // 
            this.bMenu_Jovens.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarPorToolStripMenuItem,
            this.bMenu_Jovens_View});
            this.bMenu_Jovens.Name = "bMenu_Jovens";
            this.bMenu_Jovens.Size = new System.Drawing.Size(54, 20);
            this.bMenu_Jovens.Text = "&Jovens";
            // 
            // ordenarPorToolStripMenuItem
            // 
            this.ordenarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_Jovens_ordenar_Nome,
            this.bMenu_Jovens_ordenar_Quarto});
            this.ordenarPorToolStripMenuItem.Name = "ordenarPorToolStripMenuItem";
            this.ordenarPorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ordenarPorToolStripMenuItem.Text = "Ordenar por";
            // 
            // bMenu_Jovens_ordenar_Nome
            // 
            this.bMenu_Jovens_ordenar_Nome.Name = "bMenu_Jovens_ordenar_Nome";
            this.bMenu_Jovens_ordenar_Nome.Size = new System.Drawing.Size(111, 22);
            this.bMenu_Jovens_ordenar_Nome.Text = "Nome";
            this.bMenu_Jovens_ordenar_Nome.Click += new System.EventHandler(this.bMenu_Jovens_ordenar_Nome_Click);
            // 
            // bMenu_Jovens_ordenar_Quarto
            // 
            this.bMenu_Jovens_ordenar_Quarto.Name = "bMenu_Jovens_ordenar_Quarto";
            this.bMenu_Jovens_ordenar_Quarto.Size = new System.Drawing.Size(111, 22);
            this.bMenu_Jovens_ordenar_Quarto.Text = "Quarto";
            this.bMenu_Jovens_ordenar_Quarto.Click += new System.EventHandler(this.bMenu_Jovens_ordenar_Quarto_Click);
            // 
            // bMenu_Jovens_View
            // 
            this.bMenu_Jovens_View.Image = global::DITI_LIVROM.Properties.Resources.app_view;
            this.bMenu_Jovens_View.Name = "bMenu_Jovens_View";
            this.bMenu_Jovens_View.Size = new System.Drawing.Size(155, 22);
            this.bMenu_Jovens_View.Text = "Visualizar Fotos";
            this.bMenu_Jovens_View.Click += new System.EventHandler(this.bMenu_Jovens_View_Click);
            // 
            // bMenu_Servidor
            // 
            this.bMenu_Servidor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_Servidor_View});
            this.bMenu_Servidor.Name = "bMenu_Servidor";
            this.bMenu_Servidor.Size = new System.Drawing.Size(73, 20);
            this.bMenu_Servidor.Text = "&Servidores";
            // 
            // bMenu_Servidor_View
            // 
            this.bMenu_Servidor_View.Image = global::DITI_LIVROM.Properties.Resources.app_view;
            this.bMenu_Servidor_View.Name = "bMenu_Servidor_View";
            this.bMenu_Servidor_View.Size = new System.Drawing.Size(123, 22);
            this.bMenu_Servidor_View.Text = "&Visualizar";
            this.bMenu_Servidor_View.Click += new System.EventHandler(this.bMenu_Servidor_View_Click);
            // 
            // bMenu_plantao
            // 
            this.bMenu_plantao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_plantao_transf,
            this.bMenu_plantao_contagem,
            this.toolStripMenuItem2,
            this.bMenu_plantao_visualizar_livro});
            this.bMenu_plantao.Name = "bMenu_plantao";
            this.bMenu_plantao.Size = new System.Drawing.Size(59, 20);
            this.bMenu_plantao.Text = "&Plantão";
            // 
            // bMenu_plantao_transf
            // 
            this.bMenu_plantao_transf.Image = ((System.Drawing.Image)(resources.GetObject("bMenu_plantao_transf.Image")));
            this.bMenu_plantao_transf.Name = "bMenu_plantao_transf";
            this.bMenu_plantao_transf.Size = new System.Drawing.Size(203, 22);
            this.bMenu_plantao_transf.Text = "&Transferência de Plantão";
            this.bMenu_plantao_transf.Click += new System.EventHandler(this.bMenu_plantao_transf_Click);
            // 
            // bMenu_plantao_contagem
            // 
            this.bMenu_plantao_contagem.Image = ((System.Drawing.Image)(resources.GetObject("bMenu_plantao_contagem.Image")));
            this.bMenu_plantao_contagem.Name = "bMenu_plantao_contagem";
            this.bMenu_plantao_contagem.Size = new System.Drawing.Size(203, 22);
            this.bMenu_plantao_contagem.Text = "Contagem de efetivos";
            this.bMenu_plantao_contagem.Click += new System.EventHandler(this.bMenu_plantao_contagem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // bMenu_plantao_visualizar_livro
            // 
            this.bMenu_plantao_visualizar_livro.Image = ((System.Drawing.Image)(resources.GetObject("bMenu_plantao_visualizar_livro.Image")));
            this.bMenu_plantao_visualizar_livro.Name = "bMenu_plantao_visualizar_livro";
            this.bMenu_plantao_visualizar_livro.Size = new System.Drawing.Size(203, 22);
            this.bMenu_plantao_visualizar_livro.Text = "Visualizar Livro";
            this.bMenu_plantao_visualizar_livro.Click += new System.EventHandler(this.bMenu_plantao_visualizar_livro_Click);
            // 
            // bMenu_configuracao
            // 
            this.bMenu_configuracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_configuracao_layout});
            this.bMenu_configuracao.Name = "bMenu_configuracao";
            this.bMenu_configuracao.Size = new System.Drawing.Size(91, 20);
            this.bMenu_configuracao.Text = "&Configuração";
            // 
            // bMenu_configuracao_layout
            // 
            this.bMenu_configuracao_layout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_configuracao_layout_maior,
            this.bMenu_configuracao_layout_menor});
            this.bMenu_configuracao_layout.Name = "bMenu_configuracao_layout";
            this.bMenu_configuracao_layout.Size = new System.Drawing.Size(164, 22);
            this.bMenu_configuracao_layout.Text = "Tamanho da Tela";
            // 
            // bMenu_configuracao_layout_maior
            // 
            this.bMenu_configuracao_layout_maior.Name = "bMenu_configuracao_layout_maior";
            this.bMenu_configuracao_layout_maior.Size = new System.Drawing.Size(109, 22);
            this.bMenu_configuracao_layout_maior.Text = "Maior";
            this.bMenu_configuracao_layout_maior.Click += new System.EventHandler(this.bMenu_configuracao_layout_maior_Click);
            // 
            // bMenu_configuracao_layout_menor
            // 
            this.bMenu_configuracao_layout_menor.Name = "bMenu_configuracao_layout_menor";
            this.bMenu_configuracao_layout_menor.Size = new System.Drawing.Size(109, 22);
            this.bMenu_configuracao_layout_menor.Text = "Menor";
            this.bMenu_configuracao_layout_menor.Click += new System.EventHandler(this.bMenu_configuracao_layout_menor_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_Jovens_Check_Todos});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // bMenu_Jovens_Check_Todos
            // 
            this.bMenu_Jovens_Check_Todos.Image = ((System.Drawing.Image)(resources.GetObject("bMenu_Jovens_Check_Todos.Image")));
            this.bMenu_Jovens_Check_Todos.Name = "bMenu_Jovens_Check_Todos";
            this.bMenu_Jovens_Check_Todos.Size = new System.Drawing.Size(196, 22);
            this.bMenu_Jovens_Check_Todos.Text = "&Selicionar todos Jovens";
            this.bMenu_Jovens_Check_Todos.Click += new System.EventHandler(this.bMenu_Jovens_Check_Todos_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stUsu,
            this.stSpace1,
            this.stDT});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 65;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Resize += new System.EventHandler(this.statusStrip1_Resize);
            // 
            // stUsu
            // 
            this.stUsu.BackColor = System.Drawing.SystemColors.Control;
            this.stUsu.Name = "stUsu";
            this.stUsu.Size = new System.Drawing.Size(118, 17);
            this.stUsu.Text = "toolStripStatusLabel1";
            // 
            // stSpace1
            // 
            this.stSpace1.BackColor = System.Drawing.SystemColors.Control;
            this.stSpace1.Name = "stSpace1";
            this.stSpace1.Size = new System.Drawing.Size(10, 17);
            this.stSpace1.Text = " ";
            // 
            // stDT
            // 
            this.stDT.BackColor = System.Drawing.SystemColors.Control;
            this.stDT.Name = "stDT";
            this.stDT.Size = new System.Drawing.Size(122, 17);
            this.stDT.Text = "11/11/11 11:11:111111";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(860, 24);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(4, 632);
            this.splitter2.TabIndex = 68;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.l4);
            this.panel1.Controls.Add(this.l3);
            this.panel1.Controls.Add(this.l2);
            this.panel1.Controls.Add(this.l1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 176);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(290, 34);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(26, 13);
            this.l1.TabIndex = 4;
            this.l1.Text = "jose";
            this.l1.Visible = false;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(294, 66);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(32, 13);
            this.l2.TabIndex = 5;
            this.l2.Text = "maria";
            this.l2.Visible = false;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(296, 98);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(27, 13);
            this.l3.TabIndex = 6;
            this.l3.Text = "joao";
            this.l3.Visible = false;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(306, 135);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(36, 13);
            this.l4.TabIndex = 7;
            this.l4.Text = "tinoco";
            this.l4.Visible = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 678);
            this.Controls.Add(this.pnlJovens);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnl_Cont);
            this.Controls.Add(this.bMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_Cont.ResumeLayout(false);
            this.pnlAcao_cont.ResumeLayout(false);
            this.pnlAcao_bar.ResumeLayout(false);
            this.pnlAcao_bar.PerformLayout();
            this.pnlServidor_Cont.ResumeLayout(false);
            this.pnlServidor_bar.ResumeLayout(false);
            this.pnlServidor_bar.PerformLayout();
            this.pnlExecutar_Cont.ResumeLayout(false);
            this.pnlJovens.ResumeLayout(false);
            this.bMenu.ResumeLayout(false);
            this.bMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Cont;
        private System.Windows.Forms.Panel pnlAcao_cont;
        private System.Windows.Forms.Panel pnlAcao_bar;
        private System.Windows.Forms.Panel pnlServidor_Cont;
        private System.Windows.Forms.ListView LsvServidor;
        private System.Windows.Forms.Panel pnlServidor_bar;
        private System.Windows.Forms.Label lb_servidores;
        private System.Windows.Forms.Button btn_view_servidor;
        private System.Windows.Forms.Panel pnlExecutar_Cont;
        private System.Windows.Forms.Button btnRegistraAcao;
        public System.Windows.Forms.ImageList ImgList16;
        private System.Windows.Forms.ColumnHeader Lsv_col_Nome;
        private System.Windows.Forms.ColumnHeader Lsv_col_Cargo;
        private System.Windows.Forms.ColumnHeader Lsv_col_Matricula;
        public System.Windows.Forms.ImageList ImgList24;
        public System.Windows.Forms.ImageList ImgListAcoes;
        private System.Windows.Forms.TreeView LsvAcoes;
        private System.Windows.Forms.Label lb_total_jovens;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlJovens;
        private System.Windows.Forms.Button btn_view_jovens;
        private System.Windows.Forms.ColumnHeader Lsv_col_CPF;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_plantao;
        public System.Windows.Forms.TextBox buscar_servidor;
        public System.Windows.Forms.Label lbCharA;
        public System.Windows.Forms.Label lbChar;
        private System.Windows.Forms.Button btn_check_jovens;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip bMenu;
        private System.Windows.Forms.ToolStripMenuItem bMenu_arquivo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem bMenu_arquivo_sair;
        private System.Windows.Forms.ToolStripMenuItem bMenu_configuracao;
        private System.Windows.Forms.ToolStripMenuItem bMenu_configuracao_layout;
        private System.Windows.Forms.ToolStripMenuItem bMenu_configuracao_layout_maior;
        private System.Windows.Forms.ToolStripMenuItem bMenu_configuracao_layout_menor;
        private System.Windows.Forms.ToolStripStatusLabel stDT;
        private System.Windows.Forms.ToolStripStatusLabel stSpace1;
        private System.Windows.Forms.ToolStripStatusLabel stUsu;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripMenuItem bMenu_Servidor;
        private System.Windows.Forms.ToolStripMenuItem bMenu_Jovens;
        private System.Windows.Forms.ToolStripMenuItem bMenu_Jovens_View;
        private System.Windows.Forms.ToolStripMenuItem bMenu_Servidor_View;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMenu_Jovens_ordenar_Nome;
        private System.Windows.Forms.ToolStripMenuItem bMenu_Jovens_ordenar_Quarto;
        private System.Windows.Forms.ToolStripMenuItem bMenu_plantao;
        private System.Windows.Forms.ToolStripMenuItem bMenu_plantao_transf;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bMenu_plantao_visualizar_livro;
        private System.Windows.Forms.Button btn_plantao_contagem;
        private System.Windows.Forms.Button btn_plantao_visualizar;
        private System.Windows.Forms.Button btn_plantao_transf;
        private System.Windows.Forms.ToolStripMenuItem bMenu_plantao_contagem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMenu_Jovens_Check_Todos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


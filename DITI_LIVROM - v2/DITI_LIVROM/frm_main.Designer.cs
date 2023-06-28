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
            this.bMenu_configuracao = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_configuracao_layout = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_configuracao_layout_maior = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu_configuracao_layout_menor = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.stSpace1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stDT = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnl_Cont.SuspendLayout();
            this.pnlAcao_cont.SuspendLayout();
            this.pnlAcao_bar.SuspendLayout();
            this.pnlServidor_Cont.SuspendLayout();
            this.pnlServidor_bar.SuspendLayout();
            this.pnlExecutar_Cont.SuspendLayout();
            this.pnlJovens.SuspendLayout();
            this.bMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Cont
            // 
            this.pnl_Cont.Controls.Add(this.splitter1);
            this.pnl_Cont.Controls.Add(this.pnlAcao_cont);
            this.pnl_Cont.Controls.Add(this.pnlServidor_Cont);
            this.pnl_Cont.Controls.Add(this.pnlExecutar_Cont);
            this.pnl_Cont.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Cont.Location = new System.Drawing.Point(1152, 28);
            this.pnl_Cont.Name = "pnl_Cont";
            this.pnl_Cont.Size = new System.Drawing.Size(505, 807);
            this.pnl_Cont.TabIndex = 58;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 313);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(505, 5);
            this.splitter1.TabIndex = 62;
            this.splitter1.TabStop = false;
            // 
            // pnlAcao_cont
            // 
            this.pnlAcao_cont.Controls.Add(this.LsvAcoes);
            this.pnlAcao_cont.Controls.Add(this.pnlAcao_bar);
            this.pnlAcao_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcao_cont.Location = new System.Drawing.Point(0, 0);
            this.pnlAcao_cont.Name = "pnlAcao_cont";
            this.pnlAcao_cont.Size = new System.Drawing.Size(505, 318);
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
            this.LsvAcoes.Location = new System.Drawing.Point(0, 72);
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
            this.LsvAcoes.ShowNodeToolTips = true;
            this.LsvAcoes.ShowPlusMinus = false;
            this.LsvAcoes.ShowRootLines = false;
            this.LsvAcoes.Size = new System.Drawing.Size(505, 246);
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
            this.ImgListAcoes.Images.SetKeyName(36, "0 vazio - Copia (36).png");
            this.ImgListAcoes.Images.SetKeyName(37, "0 vazio - Copia (37).png");
            this.ImgListAcoes.Images.SetKeyName(38, "0 vazio - Copia (38).png");
            this.ImgListAcoes.Images.SetKeyName(39, "0 vazio - Copia (39).png");
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
            this.pnlAcao_bar.Controls.Add(this.lb_plantao);
            this.pnlAcao_bar.Controls.Add(this.lb_total_jovens);
            this.pnlAcao_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcao_bar.Location = new System.Drawing.Point(0, 0);
            this.pnlAcao_bar.Name = "pnlAcao_bar";
            this.pnlAcao_bar.Size = new System.Drawing.Size(505, 72);
            this.pnlAcao_bar.TabIndex = 17;
            // 
            // lb_plantao
            // 
            this.lb_plantao.AutoSize = true;
            this.lb_plantao.BackColor = System.Drawing.Color.Transparent;
            this.lb_plantao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_plantao.ForeColor = System.Drawing.Color.White;
            this.lb_plantao.Location = new System.Drawing.Point(9, 9);
            this.lb_plantao.Name = "lb_plantao";
            this.lb_plantao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_plantao.Size = new System.Drawing.Size(216, 25);
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
            this.lb_total_jovens.Location = new System.Drawing.Point(9, 34);
            this.lb_total_jovens.Name = "lb_total_jovens";
            this.lb_total_jovens.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_total_jovens.Size = new System.Drawing.Size(216, 25);
            this.lb_total_jovens.TabIndex = 28;
            this.lb_total_jovens.Text = "Total de Jovens: 000";
            this.lb_total_jovens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlServidor_Cont
            // 
            this.pnlServidor_Cont.Controls.Add(this.LsvServidor);
            this.pnlServidor_Cont.Controls.Add(this.pnlServidor_bar);
            this.pnlServidor_Cont.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlServidor_Cont.Location = new System.Drawing.Point(0, 318);
            this.pnlServidor_Cont.Name = "pnlServidor_Cont";
            this.pnlServidor_Cont.Size = new System.Drawing.Size(505, 429);
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
            this.LsvServidor.Location = new System.Drawing.Point(0, 37);
            this.LsvServidor.MultiSelect = false;
            this.LsvServidor.Name = "LsvServidor";
            this.LsvServidor.Size = new System.Drawing.Size(505, 392);
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
            this.pnlServidor_bar.Name = "pnlServidor_bar";
            this.pnlServidor_bar.Size = new System.Drawing.Size(505, 37);
            this.pnlServidor_bar.TabIndex = 17;
            // 
            // lbCharA
            // 
            this.lbCharA.AutoSize = true;
            this.lbCharA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharA.Location = new System.Drawing.Point(319, 3);
            this.lbCharA.Name = "lbCharA";
            this.lbCharA.Size = new System.Drawing.Size(21, 24);
            this.lbCharA.TabIndex = 67;
            this.lbCharA.Text = "0";
            this.lbCharA.Visible = false;
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChar.Location = new System.Drawing.Point(379, 7);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(21, 24);
            this.lbChar.TabIndex = 66;
            this.lbChar.Text = "0";
            this.lbChar.Visible = false;
            this.lbChar.TextChanged += new System.EventHandler(this.lbChar_TextChanged);
            // 
            // buscar_servidor
            // 
            this.buscar_servidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscar_servidor.Location = new System.Drawing.Point(150, 3);
            this.buscar_servidor.Name = "buscar_servidor";
            this.buscar_servidor.Size = new System.Drawing.Size(297, 22);
            this.buscar_servidor.TabIndex = 28;
            this.buscar_servidor.TextChanged += new System.EventHandler(this.buscar_servidor_TextChanged);
            // 
            // lb_servidores
            // 
            this.lb_servidores.AutoSize = true;
            this.lb_servidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_servidores.ForeColor = System.Drawing.Color.White;
            this.lb_servidores.Location = new System.Drawing.Point(18, 5);
            this.lb_servidores.Name = "lb_servidores";
            this.lb_servidores.Size = new System.Drawing.Size(106, 25);
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
            this.btn_view_servidor.Location = new System.Drawing.Point(468, 0);
            this.btn_view_servidor.Name = "btn_view_servidor";
            this.btn_view_servidor.Size = new System.Drawing.Size(37, 37);
            this.btn_view_servidor.TabIndex = 0;
            this.btn_view_servidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_view_servidor.UseVisualStyleBackColor = true;
            this.btn_view_servidor.Click += new System.EventHandler(this.btn_view_servidor_Click);
            // 
            // pnlExecutar_Cont
            // 
            this.pnlExecutar_Cont.Controls.Add(this.btnRegistraAcao);
            this.pnlExecutar_Cont.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExecutar_Cont.Location = new System.Drawing.Point(0, 747);
            this.pnlExecutar_Cont.Name = "pnlExecutar_Cont";
            this.pnlExecutar_Cont.Size = new System.Drawing.Size(505, 60);
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
            this.btnRegistraAcao.Location = new System.Drawing.Point(9, 9);
            this.btnRegistraAcao.Name = "btnRegistraAcao";
            this.btnRegistraAcao.Size = new System.Drawing.Size(490, 46);
            this.btnRegistraAcao.TabIndex = 51;
            this.btnRegistraAcao.Text = "Registrar Ação no Livro";
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
            this.pnlJovens.Controls.Add(this.btn_check_jovens);
            this.pnlJovens.Controls.Add(this.btn_view_jovens);
            this.pnlJovens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJovens.Location = new System.Drawing.Point(0, 28);
            this.pnlJovens.Name = "pnlJovens";
            this.pnlJovens.Size = new System.Drawing.Size(1152, 807);
            this.pnlJovens.TabIndex = 60;
            this.pnlJovens.Resize += new System.EventHandler(this.pnlJovens_Resize);
            // 
            // btn_check_jovens
            // 
            this.btn_check_jovens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_jovens.FlatAppearance.BorderSize = 0;
            this.btn_check_jovens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check_jovens.Image = ((System.Drawing.Image)(resources.GetObject("btn_check_jovens.Image")));
            this.btn_check_jovens.Location = new System.Drawing.Point(1094, 3);
            this.btn_check_jovens.Name = "btn_check_jovens";
            this.btn_check_jovens.Size = new System.Drawing.Size(23, 18);
            this.btn_check_jovens.TabIndex = 2;
            this.btn_check_jovens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_check_jovens.UseVisualStyleBackColor = true;
            this.btn_check_jovens.Click += new System.EventHandler(this.btn_check_jovens_Click);
            // 
            // btn_view_jovens
            // 
            this.btn_view_jovens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view_jovens.FlatAppearance.BorderSize = 0;
            this.btn_view_jovens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_jovens.Image = global::DITI_LIVROM.Properties.Resources.app_view;
            this.btn_view_jovens.Location = new System.Drawing.Point(1123, 3);
            this.btn_view_jovens.Name = "btn_view_jovens";
            this.btn_view_jovens.Size = new System.Drawing.Size(23, 18);
            this.btn_view_jovens.TabIndex = 1;
            this.btn_view_jovens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_view_jovens.UseVisualStyleBackColor = true;
            this.btn_view_jovens.Click += new System.EventHandler(this.btn_view_jovens_Click);
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
            this.bMenu_configuracao});
            this.bMenu.Location = new System.Drawing.Point(0, 0);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(1657, 28);
            this.bMenu.TabIndex = 64;
            this.bMenu.Text = "menuStrip1";
            // 
            // bMenu_arquivo
            // 
            this.bMenu_arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_arquivo_sair});
            this.bMenu_arquivo.Name = "bMenu_arquivo";
            this.bMenu_arquivo.Size = new System.Drawing.Size(73, 24);
            this.bMenu_arquivo.Text = "&Arquivo";
            // 
            // bMenu_arquivo_sair
            // 
            this.bMenu_arquivo_sair.Name = "bMenu_arquivo_sair";
            this.bMenu_arquivo_sair.Size = new System.Drawing.Size(181, 26);
            this.bMenu_arquivo_sair.Text = "&Sair";
            this.bMenu_arquivo_sair.Click += new System.EventHandler(this.bMenu_arquivo_sair_Click);
            // 
            // bMenu_configuracao
            // 
            this.bMenu_configuracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_configuracao_layout});
            this.bMenu_configuracao.Name = "bMenu_configuracao";
            this.bMenu_configuracao.Size = new System.Drawing.Size(110, 24);
            this.bMenu_configuracao.Text = "&Configuração";
            // 
            // bMenu_configuracao_layout
            // 
            this.bMenu_configuracao_layout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMenu_configuracao_layout_maior,
            this.bMenu_configuracao_layout_menor});
            this.bMenu_configuracao_layout.Name = "bMenu_configuracao_layout";
            this.bMenu_configuracao_layout.Size = new System.Drawing.Size(196, 26);
            this.bMenu_configuracao_layout.Text = "Tamanho da Tela";
            // 
            // bMenu_configuracao_layout_maior
            // 
            this.bMenu_configuracao_layout_maior.Name = "bMenu_configuracao_layout_maior";
            this.bMenu_configuracao_layout_maior.Size = new System.Drawing.Size(127, 26);
            this.bMenu_configuracao_layout_maior.Text = "Maior";
            this.bMenu_configuracao_layout_maior.Click += new System.EventHandler(this.bMenu_configuracao_layout_maior_Click);
            // 
            // bMenu_configuracao_layout_menor
            // 
            this.bMenu_configuracao_layout_menor.Name = "bMenu_configuracao_layout_menor";
            this.bMenu_configuracao_layout_menor.Size = new System.Drawing.Size(127, 26);
            this.bMenu_configuracao_layout_menor.Text = "Menor";
            this.bMenu_configuracao_layout_menor.Click += new System.EventHandler(this.bMenu_configuracao_layout_menor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stUsu,
            this.stSpace1,
            this.stDT});
            this.statusStrip1.Location = new System.Drawing.Point(0, 810);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1152, 25);
            this.statusStrip1.TabIndex = 65;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Resize += new System.EventHandler(this.statusStrip1_Resize);
            // 
            // stUsu
            // 
            this.stUsu.BackColor = System.Drawing.SystemColors.Control;
            this.stUsu.Name = "stUsu";
            this.stUsu.Size = new System.Drawing.Size(151, 20);
            this.stUsu.Text = "toolStripStatusLabel1";
            // 
            // stSpace1
            // 
            this.stSpace1.BackColor = System.Drawing.SystemColors.Control;
            this.stSpace1.Name = "stSpace1";
            this.stSpace1.Size = new System.Drawing.Size(13, 20);
            this.stSpace1.Text = " ";
            // 
            // stDT
            // 
            this.stDT.BackColor = System.Drawing.SystemColors.Control;
            this.stDT.Name = "stDT";
            this.stDT.Size = new System.Drawing.Size(159, 20);
            this.stDT.Text = "11/11/11 11:11:111111";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(1147, 28);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 782);
            this.splitter2.TabIndex = 66;
            this.splitter2.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 835);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlJovens);
            this.Controls.Add(this.pnl_Cont);
            this.Controls.Add(this.bMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox buscar_servidor;
        public System.Windows.Forms.Label lbCharA;
        public System.Windows.Forms.Label lbChar;
        private System.Windows.Forms.Button btn_check_jovens;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip bMenu;
        private System.Windows.Forms.ToolStripMenuItem bMenu_arquivo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripMenuItem bMenu_arquivo_sair;
        private System.Windows.Forms.ToolStripMenuItem bMenu_configuracao;
        private System.Windows.Forms.ToolStripMenuItem bMenu_configuracao_layout;
        private System.Windows.Forms.ToolStripMenuItem bMenu_configuracao_layout_maior;
        private System.Windows.Forms.ToolStripMenuItem bMenu_configuracao_layout_menor;
        private System.Windows.Forms.ToolStripStatusLabel stDT;
        private System.Windows.Forms.ToolStripStatusLabel stSpace1;
        private System.Windows.Forms.ToolStripStatusLabel stUsu;
    }
}


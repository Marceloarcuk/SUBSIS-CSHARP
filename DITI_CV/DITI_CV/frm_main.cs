using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITI_CV
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            Conexao.Conecta();
            CarregarTreeView();
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            pnl_doc.Dock = DockStyle.Fill;
            pnl_doc.Visible = false;

            pnl_aud.Dock = DockStyle.Fill;
            pnl_aud.Visible = false;

            pnl_proc.Dock = DockStyle.Fill;
            pnl_proc.Visible = false;

            //-------------------------------------
            //PANEL PROCESSOS
            if (TreeView.SelectedNode.ImageIndex < 2)
            {
                pnl_proc.Visible = true;
                CarregarPanelProcesso();
            }
            //-------------------------------------
            //PANEL DOCUMENTOS
            else if (TreeView.SelectedNode.ImageIndex > 3)
            {
                pnl_doc.Visible = true;
                CarregarPanelDocumento(TreeView.SelectedNode.Tag.ToString());
            }
            //-------------------------------------
            //PANEL AUDIENCIA
            else if ((TreeView.SelectedNode.ImageIndex == 2) || (TreeView.SelectedNode.ImageIndex == 3))
            {
                pnl_aud.Visible = true;
                CarregarPanelAudiencia(TreeView.SelectedNode.Tag.ToString());
            }
            //-------------------------------------




            //MessageBox.Show(treeView1.SelectedNode.Text); DockStyle


        }


        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            /*
            //System.Diagnostics.Process.Start(@"C:\teste\teste.pdf");

            InserirBookmark();
            CarregarTreeView();
            IrBookmark();
            */

        }

        //****************************************************************************************
        //*** BOOKMARK ***************************************************************************
        //****************************************************************************************
        #region _BOOKMARK
        //---------------------------------------------------------
        private void InserirBookmark()
        {
            try
            {
                if (TreeView.SelectedNode.Parent == null) Globais.BookMark = TreeView.SelectedNode; 
                else Globais.BookMark = TreeView.SelectedNode.Parent;
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        private void IrBookmark()
        {
            try
            {
                TreeView.SelectedNode = GetNode(Globais.BookMark.Name);
                TreeView.SelectedNode.Expand();
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        public TreeNode GetNode(string name)
        {
            foreach (TreeNode node in TreeView.Nodes)
            {
                if (node.Name.Equals(name)) return node;
                //TreeNode next = GetNode(name);
                //if (next != null) return next;
            }
            return null;
        }
        //---------------------------------------------------------
        #endregion _BOOKMARK
        //****************************************************************************************

        //---------------------------------------------------------
        // CARREGA PROCESSO NA TREEVIEW
        //---------------------------------------------------------
        private void CarregarTreeView()
        {
            try
            {
                TreeView.Nodes.Clear();
                DataSet dtProcesso = ConexaoSQL.processos("", ed_localizar.Text);
                foreach (DataRow pRow in dtProcesso.Tables[0].Rows)
                {
                    //-------------------------------------------------
                    //INSERIR PROCESSO
                    #region _PROCESSO
                    int vid_processo = pRow.Field<int>("id_processo");
                    string vn_processo = pRow.Field<string>("n_processo").Substring(0, 4) + "." +
                                         pRow.Field<string>("n_processo").Substring(4, 4) + "-" +
                                         pRow.Field<string>("n_processo").Substring(8, 4);
                    int vtp_processo = pRow.Field<int>("tp_processo");
                    TreeNode Node_Proc = new TreeNode();
                    Node_Proc.Name = "PROC_" + vid_processo.ToString();
                    Node_Proc.Tag = vid_processo;
                    Node_Proc.Text = vn_processo;
                    Node_Proc.ImageIndex = 0;
                    if (pRow.Field<int>("tp_processo") == 1) Node_Proc.ImageIndex = 1;
                    Node_Proc.SelectedImageIndex = Node_Proc.ImageIndex;
                    #endregion _PROCESSO
                    //-------------------------------------------------
                    //INSERIR AUDIENCIA
                    #region _AUDIENCIA
                    try
                    {
                        DataSet dtAudiencia = ConexaoSQL.audiencias(vid_processo.ToString(), "");
                        foreach (DataRow pRowAud in dtAudiencia.Tables[0].Rows)
                        {
                            int vid_audiencia = pRowAud.Field<int>("id_processo_audiencia");
                            TreeNode Node_Audi = new TreeNode();
                            Node_Audi.Name = "AUDI_" + vid_processo.ToString() + "_" + vid_audiencia.ToString();
                            Node_Audi.Tag = vid_audiencia;
                            DateTime dt_aud = pRowAud.Field<DateTime>("dt_audiencia");
                            Node_Audi.Text = "Audiência: " + pRowAud.Field<DateTime>("dt_audiencia").ToShortDateString();
                            Node_Audi.ImageIndex = 3;
                            if (pRowAud.Field<string>("realizada_audiencia") == "0") Node_Audi.ImageIndex = 2;
                            Node_Audi.SelectedImageIndex = Node_Audi.ImageIndex;
                            Node_Proc.Nodes.Add(Node_Audi);
                        }
                    }
                    catch { };
                    #endregion _AUDIENCIA
                    //-------------------------------------------------
                    //INSERIR DOCUMENTOS
                    #region _DOCUMENTOS
                    try
                    {
                        DataSet dtDocumentos = ConexaoSQL.documentos(vid_processo.ToString(), "");
                        foreach (DataRow pRowDoc in dtDocumentos.Tables[0].Rows)
                        {
                            int vid_documento = pRowDoc.Field<int>("id_processo_documento");
                            TreeNode Node_Docs = new TreeNode();
                            Node_Docs.Name = "DOCS_" + vid_processo.ToString() + "_" + vid_documento.ToString();
                            Node_Docs.Tag = vid_documento;
                            Node_Docs.Text = pRowDoc.Field<string>("desc_processo_documento_tipo");
                            Node_Docs.ImageIndex = 13;
                            if (pRowDoc.Field<int>("id_processo_documento_tipo") == 0) Node_Docs.ImageIndex = 4;
                            else if (pRowDoc.Field<int>("id_processo_documento_tipo") == 1) Node_Docs.ImageIndex = 5;
                            else if (pRowDoc.Field<int>("id_processo_documento_tipo") == 2) Node_Docs.ImageIndex = 6;
                            else if (pRowDoc.Field<int>("id_processo_documento_tipo") == 3) Node_Docs.ImageIndex = 7;
                            else if (pRowDoc.Field<int>("id_processo_documento_tipo") == 4) Node_Docs.ImageIndex = 8;
                            else if (pRowDoc.Field<int>("id_processo_documento_tipo") == 5) Node_Docs.ImageIndex = 9;
                            else if (pRowDoc.Field<int>("id_processo_documento_tipo") == 6) Node_Docs.ImageIndex = 10;
                            else if (pRowDoc.Field<int>("id_processo_documento_tipo") == 7) Node_Docs.ImageIndex = 11;
                            Node_Docs.SelectedImageIndex = Node_Docs.ImageIndex;
                            Node_Proc.Nodes.Add(Node_Docs);
                        }
                    }
                    catch { };
                    #endregion _DOCUMENTOS
                    //-------------------------------------------------
                    //INSERIR PROCESSOS VINCULADOS
                    #region _PROCESSOS_VINC
                    try
                    {
                        DataSet dtProcessosVinculados = ConexaoSQL.processos_vinculados(vid_processo.ToString());
                        foreach (DataRow pRowPV in dtProcessosVinculados.Tables[0].Rows)
                        {
                            int vid_processo_vinculado = pRowPV.Field<int>("id_processo_vinculado");
                            TreeNode Node_ProcVinc = new TreeNode();
                            Node_ProcVinc.Name = "PV_" + vid_processo.ToString() + "_" + vid_processo_vinculado.ToString();
                            Node_ProcVinc.Tag = vid_processo_vinculado;
                            Node_ProcVinc.Text = pRowPV.Field<string>("n_processo").Substring(0, 4) + "." +
                                                 pRowPV.Field<string>("n_processo").Substring(4, 4) + "-" +
                                                 pRowPV.Field<string>("n_processo").Substring(8, 4);
                            Node_ProcVinc.ImageIndex = 0;
                            if (pRowPV.Field<int>("tp_processo") == 1) Node_ProcVinc.ImageIndex = 1;
                            Node_ProcVinc.SelectedImageIndex = Node_ProcVinc.ImageIndex;
                            Node_Proc.Nodes.Add(Node_ProcVinc);
                        }
                    }
                    catch { };
                    #endregion _PROCESSOS_VINC
                    //-------------------------------------------------
                    TreeView.Nodes.Add(Node_Proc);
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //---------------------------------------------------------


        //****************************************************************************************
        //*** PROCESSO ***************************************************************************
        //****************************************************************************************
        #region _PROCESSO
        //---------------------------------------------------------
        // ABRIR FORM PROCESSO
        //---------------------------------------------------------
        private void AbrirProcesso(string N_proc, string id_proc)
        {
            try
            {
                frm_processo frm_processo = new frm_processo();
                int vTipoProcesso = -1;
                string vNumProcesso = N_proc;
                //-------------------------------------
                //CARREGA O FORM PROCESSO
                frm_processo.Text = "Novo Processo";
                if (N_proc != "")
                {
                    //CAPTION DO FORM
                    frm_processo.Text = "Processo Nº " + N_proc.Substring(0, 4) + "." + N_proc.Substring(4, 4) + "." + N_proc.Substring(8, 4);
                    //NÚMERO DO PROCESSO
                    frm_processo.proc_num.Text = N_proc;
                    //ID DO PROCESSO
                    frm_processo.proc_id.Text = id_proc;
                    //TIPO DO PROCESSO
                    DataSet dtProcesso = ConexaoSQL.processos(id_proc, "");
                    foreach (DataRow pRow in dtProcesso.Tables[0].Rows)
                        frm_processo.proc_tipo_index.Text = pRow.Field<int>("tp_processo").ToString();
                }
                //-------------------------------------
                //ABRE E RETORNA O FORM PROCESSO
                if (frm_processo.ShowDialog(this) == DialogResult.OK)
                {
                    vTipoProcesso = frm_processo.proc_tipo.SelectedIndex;
                    if (vTipoProcesso == frm_processo.proc_tipo.Items.Count - 1) vTipoProcesso = 100;
                    //NOVO PROCESSO
                    if (frm_processo.Text.Substring(0, 4) == "Novo")
                    {
                        //NOVO ID_REGISTRO
                        DataSet RecordSet = new DataSet();
                        RecordSet = Consulta.Consultar("SELECT Max(id_processo) + 1 AS newcod FROM tb_cv_processo;");
                        Int64 iNovoRegistro = 1;
                        try { iNovoRegistro = RecordSet.Tables[0].Rows[0].Field<Int64>("newcod"); } catch { iNovoRegistro = 1; }
                        //INSERT NA TABELA tb_cv_processo
                        string vSQL = "INSERT INTO tb_cv_processo (id_processo,n_processo,tp_processo,LOCAL_DT, SERVER_DT, CPF_USER) " +
                                      "VALUES( " + iNovoRegistro.ToString() + ", '" + frm_processo.proc_num.Text + "', " + vTipoProcesso.ToString() +
                                               ", DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), '" + Globais.CPFUSER + "');";
                        int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                        if (iInsertResult > 0)
                        {
                            TreeNode tn = new TreeNode();
                            tn.Name = "PROC_" + iNovoRegistro.ToString();
                            tn.Tag = iNovoRegistro;
                            tn.Text = frm_processo.proc_num.Text.Substring(0, 4) + "." +
                                      frm_processo.proc_num.Text.Substring(4, 4) + "-" +
                                      frm_processo.proc_num.Text.Substring(8, 4);
                            tn.ImageIndex = 0;
                            if (frm_processo.proc_tipo.SelectedIndex == 1) tn.ImageIndex = 1;
                            tn.SelectedImageIndex = tn.ImageIndex;
                            TreeView.Nodes.Add(tn);
                        }
                        else MessageBox.Show("Ocorreu um erro ao Inserir este processo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //EDITAR PROCESSO
                    else
                    {
                        //EDITAR NA TABELA tb_cv_processo
                        string vSQL = "UPDATE tb_cv_processo SET n_processo = '" + frm_processo.proc_num.Text + "'," +
                                                                "tp_processo = " + vTipoProcesso.ToString() + ", " +
                                                                "LOCAL_DT = DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), " +
                                                                "SERVER_DT = DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), " +
                                                                "CPF_USER = '" + Globais.CPFUSER + "' " +
                                      "WHERE id_processo = " + TreeView.SelectedNode.Tag.ToString() + ";";
                        int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                        if (iInsertResult > 0)
                        {
                            TreeView.SelectedNode.Text = frm_processo.proc_num.Text.Substring(0, 4) + "." +
                                                         frm_processo.proc_num.Text.Substring(4, 4) + "-" +
                                                         frm_processo.proc_num.Text.Substring(8, 4);
                            TreeView.SelectedNode.ImageIndex = 0;
                            if (frm_processo.proc_tipo.SelectedIndex == 1) TreeView.SelectedNode.ImageIndex = 1;
                            TreeView.SelectedNode.SelectedImageIndex = TreeView.SelectedNode.ImageIndex;
                        }
                        else MessageBox.Show("Ocorreu um erro ao Editar este processo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    TreeView_AfterSelect(null, null);
                }
                //-------------------------------------
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        // CARREGAR PANEL PROCESSO
        //---------------------------------------------------------
        private void CarregarPanelProcesso()
        {
            try
            {
                //-------------------------------------
                //NÚMERO DO PROCESSO
                string vid_proc = "-1";
                if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                //-------------------------------------
                //CARREGA O FORM AUDIENCIA
                proc_num.Text = TreeView.SelectedNode.Text;
                DataSet dtProcesso = ConexaoSQL.processos(vid_proc.ToString(), "");
                proc_tipo.Text = dtProcesso.Tables[0].Rows[0].Field<string>("desc_tp_processo");
                /*
                foreach (DataRow pRow in dtProcesso.Tables[0].Rows)
                {
                    // DATA        
                    aud_data.Text = pRow.Field<DateTime>("dt_audiencia").ToShortDateString();
                }
                */
                proc_vinc.Items.Clear();
                proc_docs.Items.Clear();
                proc_aud.Items.Clear();
                foreach (TreeNode tn in TreeView.SelectedNode.Nodes)
                {
                    ListViewItem lvi = new ListViewItem(tn.Text);
                    lvi.ImageIndex = tn.ImageIndex;

                    if (tn.ImageIndex < 2) proc_vinc.Items.Add(lvi);
                    else if (tn.ImageIndex > 3) proc_docs.Items.Add(lvi);
                    else if ((tn.ImageIndex == 2) || (tn.ImageIndex == 3)) proc_aud.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        // EXCLUIR PROCESSO
        //---------------------------------------------------------
        private void ExcluirProcesso()
        {
            try
            {
                DialogResult result = MessageBox.Show("Você deseja excluir este Processo?", "Confirmar Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //-------------------------------------
                    //NÚMERO DO PROCESSO
                    string vid_proc = "-1";
                    if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                    else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                    //-------------------------------------
                    //EXCLUIR AUDIENCIA
                    int iDelDocArq = Consulta.Executar("DELETE FROM tb_cv_processo_documento_arq WHERE (id_processo = " + vid_proc + ");", "", null, "", null);
                    int iDelDoc = Consulta.Executar("DELETE FROM tb_cv_processo_documento WHERE (id_processo = " + vid_proc + ");", "", null, "", null);
                    int iDelAud = Consulta.Executar("DELETE FROM tb_cv_processo_audiencia WHERE (id_processo = " + vid_proc + ");", "", null, "", null);
                    int iInsertResult = Consulta.Executar("DELETE FROM tb_cv_processo WHERE (id_processo = " + vid_proc + ");", "", null, "", null);
                    if (iInsertResult > 0)
                    {
                        TreeView.SelectedNode.Remove();
                        MessageBox.Show("Processo excluido com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Ocorreu um erro ao Excluir este Processo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------

        //---------------------------------------------------------
        // VINCULAR PROCESSO
        //---------------------------------------------------------
        private void VincularProcesso()
        {
            frm_processo_vinculado frm_processo_vinculado = new frm_processo_vinculado();
            try
            {
                //-------------------------------------
                //NÚMERO DO PROCESSO
                string vid_proc = "-1";
                string vn_proc = "-";
                if (TreeView.SelectedNode.Parent == null)
                {
                    vid_proc = TreeView.SelectedNode.Tag.ToString();
                    vn_proc = TreeView.SelectedNode.Text;
                }
                else
                {
                    vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                    vn_proc = TreeView.SelectedNode.Parent.Text;
                }
                //-------------------------------------
                //CARREGA O FORM VINCULAR PROCESSO
                frm_processo_vinculado.Text = "Vincular Processo ao Processo nº " + vn_proc;
                frm_processo_vinculado.proc_id.Text = vid_proc;
                //-------------------------------------
                //ABRE E RETORNA O FORM VINCULAR PROCESSO
                if (frm_processo_vinculado.ShowDialog(this) == DialogResult.OK)
                {
                    foreach (ListViewItem item in frm_processo_vinculado.ListViewProc.SelectedItems)
                    {
                        Consulta.Executar("INSERT INTO tb_cv_processo_vinculado (id_processo, id_processo_vinculado,LOCAL_DT, SERVER_DT, CPF_USER) " +
                                          "VALUES( " + vid_proc + "," + item.Tag.ToString() + ", DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), '" + Globais.CPFUSER + "');", "", null, "", null);
                        Consulta.Executar("INSERT INTO tb_cv_processo_vinculado (id_processo, id_processo_vinculado,LOCAL_DT, SERVER_DT, CPF_USER) " +
                                          "VALUES( " + item.Tag.ToString() + "," + vid_proc + ", DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), '" + Globais.CPFUSER + "');", "", null, "", null);
                    }
                    InserirBookmark();
                    CarregarTreeView();
                    IrBookmark();
                }
                //-------------------------------------
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        // EXCLUIR PROCESSO_VINCULADO
        //---------------------------------------------------------
        private void ExcluirProcessoVinculado(string id_PV)
        {
            try
            {
                DialogResult result = MessageBox.Show("Você deseja excluir o vinculo deste Processo ?", "Confirmar Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //-------------------------------------
                    //NÚMERO DO PROCESSO
                    string vid_proc = "-1";
                    if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                    else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                    //-------------------------------------
                    //EXCLUIR PROCESSO_VINCULADO
                    int iInsertResult = Consulta.Executar("DELETE FROM tb_cv_processo_vinculado WHERE (id_processo = " + vid_proc + ") AND (id_processo_vinculado = " + id_PV + ");", "", null, "", null);
                    if (iInsertResult > 0)
                    {
                        Consulta.Executar("DELETE FROM tb_cv_processo_vinculado WHERE (id_processo = " + id_PV + ") AND (id_processo_vinculado = " + vid_proc + ");", "", null, "", null);
                        InserirBookmark();
                        CarregarTreeView();
                        IrBookmark();
                        MessageBox.Show("Vinculo excluido com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Ocorreu um erro ao Excluir este Vinculo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------



        #endregion _PROCESSO
        //****************************************************************************************

        //****************************************************************************************
        //*** AUDIENCIA **************************************************************************
        //****************************************************************************************
        #region _AUDIENCIA
        //---------------------------------------------------------
        // ABRIR FORM AUDIENCIA
        //---------------------------------------------------------
        private void AbrirAudiencia(string id_aud)
        {
            frm_audiencia frm_audiencia = new frm_audiencia();
            try
            {
                //-------------------------------------
                //NÚMERO DO PROCESSO
                string vid_proc = "-1";
                if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                //-------------------------------------
                //CARREGA O FORM AUDIENCIA
                #region _CARREGA_AUDIENCIA
                frm_audiencia.Text = "Nova Audiência";
                if ((id_aud == "") || (id_aud == "-1"))
                {
                    frm_audiencia.aud_realizado.SelectedIndex = 1;
                    frm_audiencia.aud_tipo.SelectedIndex = 0;
                }
                else
                {
                    try
                    {
                        DataSet dtAudiencia = ConexaoSQL.audiencias(vid_proc.ToString(), id_aud);
                        foreach (DataRow pRowAud in dtAudiencia.Tables[0].Rows)
                        {
                            //CAPTION DO FORM
                            frm_audiencia.Text = "Audiência: " + pRowAud.Field<DateTime>("dt_audiencia").ToShortDateString();
                            frm_audiencia.aud_data.Value = pRowAud.Field<DateTime>("dt_audiencia");
                            frm_audiencia.aud_hora.Text = pRowAud.Field<string>("hr_audiencia");
                            // REALIZADA (SIM 0 - NÃO 1)
                            int iindex = 1;
                            Int32.TryParse(pRowAud.Field<string>("realizada_audiencia"), out iindex);
                            frm_audiencia.aud_realizado.SelectedIndex = iindex;
                            // TIPO (Apresentação 0 - Continuação 1 - Leitura 2)
                            iindex = 0;
                            Int32.TryParse(pRowAud.Field<string>("tp_audiencia"), out iindex);
                            frm_audiencia.aud_tipo.SelectedIndex = iindex;
                            frm_audiencia.aud_obs.Text = pRowAud.Field<string>("obs_audiencia");
                            frm_audiencia.aud_resultado.Text = pRowAud.Field<string>("resultado_audiencia");
                        }
                    }
                    catch { };
                }
                #endregion _CARREGA_AUDIENCIA
                //-------------------------------------
                //ABRE E RETORNA O FORM AUDIENCIA
                #region _RETORNA_AUDIENCIA
                if (frm_audiencia.ShowDialog(this) == DialogResult.OK)
                {
                    //NOVA AUDIENCIA
                    if (frm_audiencia.Text.Substring(0, 4) == "Nova")
                    {
                        //NOVO ID_REGISTRO
                        DataSet RecordSet = new DataSet();
                        RecordSet = Consulta.Consultar("SELECT Max(id_processo_audiencia) + 1 AS newcod FROM tb_cv_processo_audiencia WHERE (id_processo = " + vid_proc + ") ;");
                        Int64 iNovoRegistro = 1;
                        try { iNovoRegistro = RecordSet.Tables[0].Rows[0].Field<Int64>("newcod"); } catch { iNovoRegistro = 1; }
                        //INSERT NA TABELA tb_cv_processo
                        string vSQL = "INSERT INTO tb_cv_processo_audiencia (id_processo, id_processo_audiencia, dt_audiencia, hr_audiencia, tp_audiencia, obs_audiencia, resultado_audiencia, realizada_audiencia,LOCAL_DT, SERVER_DT, CPF_USER) " +
                                      "VALUES( " + vid_proc + "," +
                                                   iNovoRegistro.ToString() + ", '" +
                                                   String.Format("{0:yyyy-MM-dd}", frm_audiencia.aud_data.Value) + "', '" +
                                                   frm_audiencia.aud_hora.Text + "', '" +
                                                   frm_audiencia.aud_tipo.SelectedIndex.ToString() + "', '" +
                                                   frm_audiencia.aud_obs.Text + "', '" +
                                                   frm_audiencia.aud_resultado.Text + "', '" +
                                                   frm_audiencia.aud_realizado.SelectedIndex.ToString() + "', " +
                                                   "DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), '" + Globais.CPFUSER + "');";
                        int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                        if (iInsertResult > 0)
                        {
                            TreeNode Node_Audi = new TreeNode();
                            Node_Audi.Name = "AUDI_" + vid_proc + "_" + iNovoRegistro.ToString();
                            Node_Audi.Tag = iNovoRegistro;
                            DateTime dt_aud = frm_audiencia.aud_data.Value;
                            Node_Audi.Text = "Audiência: " + frm_audiencia.aud_data.Value.ToShortDateString();
                            Node_Audi.ImageIndex = 3;
                            if (frm_audiencia.aud_realizado.SelectedIndex == 0) Node_Audi.ImageIndex = 2;
                            Node_Audi.SelectedImageIndex = Node_Audi.ImageIndex;
                            if (TreeView.SelectedNode.Parent == null) TreeView.SelectedNode.Nodes.Add(Node_Audi);
                            else TreeView.SelectedNode.Parent.Nodes.Add(Node_Audi);
                        }
                        else MessageBox.Show("Ocorreu um erro ao Inserir este processo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //EDITAR PROCESSO
                    else
                    {
                        //EDITAR NA TABELA tb_cv_processo
                        string vSQL = "UPDATE tb_cv_processo_audiencia SET dt_audiencia = '" + String.Format("{0:yyyy-MM-dd}", frm_audiencia.aud_data.Value) + "'," +
                                                                          "hr_audiencia = '" + frm_audiencia.aud_hora.Text + "'," +
                                                                          "tp_audiencia = '" + frm_audiencia.aud_tipo.SelectedIndex.ToString() + "'," +
                                                                          "obs_audiencia = '" + frm_audiencia.aud_obs.Text + "'," +
                                                                          "resultado_audiencia = '" + frm_audiencia.aud_resultado.Text + "'," +
                                                                          "realizada_audiencia = '" + frm_audiencia.aud_realizado.SelectedIndex.ToString() + "'," +
                                                                          "LOCAL_DT = DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), " +
                                                                          "SERVER_DT = DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i'), " +
                                                                          "CPF_USER = '" + Globais.CPFUSER + "' " +
                                      "WHERE (id_processo = " + vid_proc + ") AND (id_processo_audiencia = " + id_aud + ");";
                        int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                        if (iInsertResult > 0)
                        {
                            TreeView.SelectedNode.Text = "Audiência: " + frm_audiencia.aud_data.Value.ToShortDateString();
                            TreeView.SelectedNode.ImageIndex = 3;
                            if (frm_audiencia.aud_realizado.SelectedIndex == 0) TreeView.SelectedNode.ImageIndex = 2;
                            TreeView.SelectedNode.SelectedImageIndex = TreeView.SelectedNode.ImageIndex;
                        }
                        else MessageBox.Show("Ocorreu um erro ao Editar esta Audiência.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion _RETORNA_AUDIENCIA
                //-------------------------------------
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        // CARREGAR PANEL AUDIENCIA
        //---------------------------------------------------------
        private void CarregarPanelAudiencia(string id_aud)
        {
            try
            {
                //-------------------------------------
                //NÚMERO DO PROCESSO
                string vid_proc = "-1";
                if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                //-------------------------------------
                //CARREGA O FORM AUDIENCIA
                try
                {
                    DataSet dtAudiencia = ConexaoSQL.audiencias(vid_proc.ToString(), id_aud);
                    foreach (DataRow pRowAud in dtAudiencia.Tables[0].Rows)
                    {
                        // DATA        
                        aud_data.Text = pRowAud.Field<DateTime>("dt_audiencia").ToShortDateString();
                        // HORA        
                        aud_hora.Text = pRowAud.Field<string>("hr_audiencia");
                        // REALIZADA (SIM 0 - NÃO 1)
                        aud_realizado.Text = "NÃO";
                        if (pRowAud.Field<string>("realizada_audiencia") == "0") aud_realizado.Text = "SIM";
                        // TIPO (Apresentação 0 - Continuação 1 - Leitura 2)
                        aud_tipo.Text = "Apresentação";
                        if (pRowAud.Field<string>("tp_audiencia") == "1") aud_tipo.Text = "Continuação";
                        else if (pRowAud.Field<string>("tp_audiencia") == "2") aud_tipo.Text = "Leitura";
                        // OBS         
                        aud_obs.Text = pRowAud.Field<string>("obs_audiencia");
                        // RESULTADO   
                        aud_resultado.Text = pRowAud.Field<string>("resultado_audiencia");
                    }
                }
                catch { };
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        // EXCLUIR AUDIENCIA
        //---------------------------------------------------------
        private void ExcluirAudiencia(string id_aud)
        {
            try
            {
                DialogResult result = MessageBox.Show("Você deseja excluir esta Audiência?", "Confirmar Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //-------------------------------------
                    //NÚMERO DO PROCESSO
                    string vid_proc = "-1";
                    if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                    else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                    //-------------------------------------
                    //EXCLUIR AUDIENCIA
                    string vSQL = "DELETE FROM tb_cv_processo_audiencia WHERE (id_processo = " + vid_proc + ") AND (id_processo_audiencia = " + id_aud + ");";
                    int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                    if (iInsertResult > 0)
                    {
                        TreeView.SelectedNode.Remove();
                        MessageBox.Show("Audiência excluida com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Ocorreu um erro ao Excluir esta Audiência.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        #endregion _AUDIENCIA
        //****************************************************************************************

        //****************************************************************************************
        //*** DOCUMENTO **************************************************************************
        //****************************************************************************************
        #region _DOCUMENTO
        //---------------------------------------------------------
        // ABRIR FORM DOCUMENTO
        //---------------------------------------------------------
        int SelItemComboSubstring(ComboBox cbo, string value)
        {
            for (int i = 0; i < cbo.Items.Count; i++)
                try { if (cbo.Items[i].ToString().Substring(0, 12) == value) return i; } catch { }
            return 0;
        }
        private void Limpar_Documento(frm_documento vForm)
        {
            vForm.DOC_ID_PLANTAO_NAI.Text = "";

            #region _DOC_INI
            vForm.DOC_DESC.Text = "";
            vForm.DOC_ORIGEM.Items.Clear();
            vForm.DOC_ORIGEM.Items.AddRange(ConexaoSQL.Combo_Alimentar("tb_cv_sys_local_doc_origem"));
            vForm.DOC_ORIGEM.SelectedIndex = 0;
            vForm.DOC_DT.Value = DateTime.Now;
            #endregion _DOC_INI

            #region _JOVEM
            vForm.JOV_COD.Text = "Sem Código";
            vForm.JOV_NOME.Text = "";
            vForm.JOV_CPF.Text = "";
            vForm.JOV_SIPIA.Text = "";
            vForm.JOV_IDENT.Text = "";
            vForm.JOV_DTNASC.Text = "";
            vForm.JOV_IDADE.Text = "0";
            vForm.JOV_FOTO.Image = null;
            vForm.JOV_DTNASC.Text = "";
            vForm.JOV_IDADE.Text = "";
            vForm.JOV_PAI.Text = "";
            vForm.JOV_MAE.Text = "";
            vForm.JOV_END.Text = "";
            vForm.JOV_BAIRRO.Text = "";
            vForm.JOV_CIDADE.Text = "";
            #endregion _JOVEM

            #region _NAI
            vForm.NAI_DESC.Text = "";
            vForm.DT_APREENSAO.Text = "";
            vForm.RA_ATO_INFRA.Text = "";
            vForm.ID_RA_ATO_INFRA.Text = "-1";
            vForm.MOT_ENT.Items.Clear();
            vForm.MOT_ENT.Items.AddRange(ConexaoSQL.Combo_Alimentar("tb_nai_motivo_entrada"));
            vForm.MOT_ENT.SelectedIndex = 0;
            #endregion _NAI

            #region _OUTROS
            vForm.PAAI_DESC.Text = "";
            vForm.PAAI_ORIGEM.Items.Clear();
            vForm.PAAI_ORIGEM.Items.AddRange(ConexaoSQL.Combo_Alimentar("tb_cv_sys_local_paai_origem"));
            vForm.PAAI_ORIGEM.SelectedIndex = 0;
            vForm.ATO_INF.Items.Clear();
            vForm.ATO_INF.Items.AddRange(ConexaoSQL.Combo_Alimentar("tb_nai_ato_infracional"));
            vForm.ATO_INF.SelectedIndex = 0;
            #endregion _OUTROS

            #region _DECISAO
            try
            {
                vForm.DEC_A.Items.Clear();
                vForm.DEC_B.Items.Clear();
                vForm.DEC_C.Items.Clear();
                vForm.DEC_A.Items.AddRange(ConexaoSQL.Combo_Decisao("0", "", ""));
                vForm.DEC_A.SelectedIndex = 0;
                vForm.PRAZO.Visible = false;
                vForm.PRAZO_LB.Visible = false;
                vForm.PRAZO.SelectedIndex = -1;
                vForm.DEC_DT.Value = DateTime.Now;
            }
            catch { }
            #endregion _DECISAO

            #region _ORIGEM_DESTINO
            vForm.ORIGEM.Items.Clear();
            vForm.ORIGEM.Items.AddRange(ConexaoSQL.Combo_Unidades(""));
            vForm.ORIGEM.SelectedIndex = 0;

            vForm.DESTINO.Items.Clear();
            vForm.DESTINO.Items.AddRange(ConexaoSQL.Combo_Unidades(""));
            vForm.DESTINO.SelectedIndex = 0;
            vForm.DESTINO.Visible = false;
            vForm.DESTINO_SEM.Visible = false;
            #endregion _ORIGEM_DESTINO

            #region _EXECUCAO
                vForm.DT_EXEC_CUMPRIM.Text = "0 Dias";
            #endregion _EXECUCAO

            #region _EVENTO
            vForm.EVENTO.Text = "";
            vForm.DT_EVENTO.Value = DateTime.Now;
            #endregion _EVENTO

            #region _ARQUIVO
            vForm.LV_ARQUIVO.Items.Clear();
            #endregion _ARQUIVO

        }
        private void Resize_Documento(frm_documento vForm, int iTipo)
        {
            Point pUltimo = new Point(0,0);

            //----------------------
            //GP_JOVEM
            vForm.GP_JOVEM.Location = new Point(vForm.GP_DOC.Location.X,
                                                vForm.GP_DOC.Location.Y + vForm.GP_DOC.Size.Height + 6);

            if (iTipo == 0)
            {
                //----------------------
                #region _JOVEM
                vForm.btn_jovem.Visible = true;
                #endregion _JOVEM
                //----------------------
                #region _NAI
                vForm.GP_NAI.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_JOVEM.Location.Y + vForm.GP_JOVEM.Size.Height + 6);
                vForm.GP_NAI.Visible = true;
                #endregion _NAI
                //----------------------
                #region _OUTROS
                vForm.GP_OUTRO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_NAI.Location.Y + vForm.GP_NAI.Size.Height + 6);
                vForm.GP_OUTRO.Visible = true;
                vForm.PAAI_DESC.Enabled = true;
                vForm.PAAI_ORIGEM.Enabled = true;
                vForm.ATO_INF.Enabled = true;
                #endregion _OUTROS
                //----------------------
                #region _DECISAO
                vForm.GP_DECISAO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_OUTRO.Location.Y + vForm.GP_OUTRO.Size.Height + 6);
                vForm.GP_DECISAO.Visible = true;
                vForm.DEC_A.Enabled = true;
                vForm.DEC_B.Enabled = true;
                vForm.DEC_C.Enabled = true;
                vForm.PRAZO.Enabled = true;
                vForm.PRAZO_LB.Enabled = true;
                vForm.DEC_DT.Enabled = true;
                #endregion _DECISAO
                //----------------------
                #region _ORIGEM_DESTINO
                vForm.GP_ORIGEM.Visible = false;

                vForm.GP_DESTINO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_DECISAO.Location.Y + vForm.GP_DECISAO.Size.Height + 6);
                vForm.GP_DESTINO.Size = vForm.GP_DOC.Size;
                vForm.GP_DESTINO.Visible = true;
                #endregion _ORIGEM_DESTINO
                //----------------------
                #region _EXECUCAO
                vForm.GP_EXECUCAO.Visible = false;
                #endregion _EXECUCAO
                //----------------------
                #region _EVENTO
                vForm.GP_EVENTO.Visible = false;
                #endregion _EVENTO
                //----------------------
                #region _ARQUIVO
                vForm.GP_ARQUIVO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_DESTINO.Location.Y + vForm.GP_DESTINO.Size.Height + 6);
                vForm.GP_ARQUIVO.Visible = true;
                #endregion _ARQUIVO
            }

            else if (iTipo == 1)
            {
                //----------------------
                #region _JOVEM
                vForm.btn_jovem.Visible = false;
                #endregion _JOVEM
                //----------------------
                #region _NAI
                vForm.GP_NAI.Visible = false;
                #endregion _NAI
                //----------------------
                #region _OUTROS
                vForm.GP_OUTRO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_JOVEM.Location.Y + vForm.GP_JOVEM.Size.Height + 6);
                vForm.GP_OUTRO.Visible = true;
                vForm.PAAI_DESC.Enabled = false;
                vForm.PAAI_ORIGEM.Enabled = false;
                vForm.ATO_INF.Enabled = false;
                #endregion _OUTROS
                //----------------------
                #region _DECISAO
                vForm.GP_DECISAO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_OUTRO.Location.Y + vForm.GP_OUTRO.Size.Height + 6);
                vForm.GP_DECISAO.Visible = true;
                #endregion _DECISAO
                //----------------------
                #region _ORIGEM_DESTINO
                vForm.GP_ORIGEM.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_DECISAO.Location.Y + vForm.GP_DECISAO.Size.Height + 6);
                vForm.GP_ORIGEM.Visible = true;
                //----------------------
                vForm.GP_DESTINO.Location = new Point(vForm.GP_DOC.Location.X + (vForm.GP_DOC.Size.Width / 2) + 6, vForm.GP_DECISAO.Location.Y + vForm.GP_DECISAO.Size.Height + 6);
                vForm.GP_DESTINO.Visible = true;
                vForm.DESTINO.Visible = true;
                #endregion _ORIGEM_DESTINO
                //----------------------
                #region _EXECUCAO
                vForm.GP_EXECUCAO.Visible = false;
                #endregion _EXECUCAO
                //----------------------
                #region _EVENTO
                vForm.GP_EVENTO.Visible = false;
                #endregion _EVENTO
                //----------------------
                #region _ARQUIVO
                vForm.GP_ARQUIVO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_DESTINO.Location.Y + vForm.GP_DESTINO.Size.Height + 6);
                vForm.GP_ARQUIVO.Visible = true;
                #endregion _ARQUIVO
            }
            else if ((iTipo == 3) || (iTipo == 4))
            {
                //----------------------
                #region _JOVEM
                vForm.btn_jovem.Visible = false;
                #endregion _JOVEM
                //----------------------
                #region _NAI
                vForm.GP_NAI.Visible = false;
                #endregion _NAI
                //----------------------
                #region _OUTROS
                vForm.GP_OUTRO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_JOVEM.Location.Y + vForm.GP_JOVEM.Size.Height + 6);
                vForm.GP_OUTRO.Visible = true;
                vForm.PAAI_DESC.Enabled = false;
                vForm.PAAI_ORIGEM.Enabled = false;
                vForm.ATO_INF.Enabled = false;
                #endregion _OUTROS
                //----------------------
                #region _DECISAO
                vForm.GP_DECISAO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_OUTRO.Location.Y + vForm.GP_OUTRO.Size.Height + 6);
                vForm.GP_DECISAO.Visible = true;
                vForm.DEC_A.Enabled = false;
                vForm.DEC_B.Enabled = false;
                vForm.DEC_C.Enabled = false;
                vForm.PRAZO.Enabled = false;
                vForm.PRAZO_LB.Enabled = false;
                vForm.DEC_DT.Enabled = false;
                #endregion _DECISAO
                //----------------------
                #region _ORIGEM_DESTINO
                vForm.GP_ORIGEM.Visible = false;
                vForm.GP_DESTINO.Visible = false;
                #endregion _ORIGEM_DESTINO
                //----------------------
                #region _EXECUCAO
                vForm.GP_EXECUCAO.Visible = false;
                #endregion _EXECUCAO
                //----------------------
                #region _EVENTO
                vForm.GP_EVENTO.Visible = false;
                #endregion _EVENTO
                //----------------------
                #region _ARQUIVO
                vForm.GP_ARQUIVO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_DECISAO.Location.Y + vForm.GP_DECISAO.Size.Height + 6);
                vForm.GP_ARQUIVO.Visible = true;
                #endregion _ARQUIVO
            }
            else if (iTipo == 5)
            {
                //----------------------
                #region _JOVEM
                vForm.btn_jovem.Visible = false;
                #endregion _JOVEM
                //----------------------
                #region _NAI
                vForm.GP_NAI.Visible = false;
                #endregion _NAI
                //----------------------
                #region _OUTROS
                vForm.GP_OUTRO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_JOVEM.Location.Y + vForm.GP_JOVEM.Size.Height + 6);
                vForm.GP_OUTRO.Visible = true;
                vForm.PAAI_DESC.Enabled = false;
                vForm.PAAI_ORIGEM.Enabled = false;
                vForm.ATO_INF.Enabled = false;
                #endregion _OUTROS
                //----------------------
                #region _DECISAO
                vForm.GP_DECISAO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_OUTRO.Location.Y + vForm.GP_OUTRO.Size.Height + 6);
                vForm.GP_DECISAO.Visible = true;
                vForm.DEC_A.Enabled = false;
                vForm.DEC_B.Enabled = false;
                vForm.DEC_C.Enabled = false;
                vForm.PRAZO.Enabled = false;
                vForm.PRAZO_LB.Enabled = false;
                vForm.DEC_DT.Enabled = false;
                #endregion _DECISAO
                //----------------------
                #region _ORIGEM_DESTINO
                vForm.GP_ORIGEM.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_DECISAO.Location.Y + vForm.GP_DECISAO.Size.Height + 6);
                vForm.GP_ORIGEM.Visible = true;
                //----------------------
                vForm.GP_DESTINO.Location = new Point(vForm.GP_DOC.Location.X + (vForm.GP_DOC.Size.Width / 2) + 6, vForm.GP_DECISAO.Location.Y + vForm.GP_DECISAO.Size.Height + 6);
                vForm.GP_DESTINO.Visible = true;
                vForm.DESTINO.Visible = true;
                #endregion _ORIGEM_DESTINO
                //----------------------
                #region _EXECUCAO
                vForm.GP_EXECUCAO.Size = vForm.GP_DOC.Size;
                vForm.GP_EXECUCAO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_ORIGEM.Location.Y + vForm.GP_ORIGEM.Size.Height + 6);
                vForm.GP_EXECUCAO.Visible = true;
                #endregion _EXECUCAO
                //----------------------
                #region _EVENTO
                vForm.GP_EVENTO.Text = "Transferência";
                vForm.GP_EVENTO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_EXECUCAO.Location.Y + vForm.GP_EXECUCAO.Size.Height + 6);
                vForm.GP_EVENTO.Visible = true;
                #endregion _EVENTO
                //----------------------
                #region _ARQUIVO
                vForm.GP_ARQUIVO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_EVENTO.Location.Y + vForm.GP_EVENTO.Size.Height + 6);
                vForm.GP_ARQUIVO.Visible = true;
                #endregion _ARQUIVO
            }
            else if ((iTipo == 2) || (iTipo == 6) || (iTipo == 7))
            {
                //----------------------
                #region _JOVEM
                vForm.btn_jovem.Visible = false;
                #endregion _JOVEM
                //----------------------
                #region _NAI
                vForm.GP_NAI.Visible = false;
                #endregion _NAI
                //----------------------
                #region _OUTROS
                vForm.GP_OUTRO.Visible = false;
                #endregion _OUTROS
                //----------------------
                #region _DECISAO
                vForm.GP_DECISAO.Visible = false;
                #endregion _DECISAO
                //----------------------
                #region _ORIGEM_DESTINO
                vForm.GP_ORIGEM.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_JOVEM.Location.Y + vForm.GP_JOVEM.Size.Height + 6);
                vForm.GP_ORIGEM.Visible = true;
                //----------------------
                vForm.GP_DESTINO.Visible = false;
                #endregion _ORIGEM_DESTINO
                //----------------------
                #region _EXECUCAO
                vForm.GP_EXECUCAO.Location = new Point(vForm.GP_DOC.Location.X + (vForm.GP_DOC.Size.Width / 2) + 6, vForm.GP_JOVEM.Location.Y + vForm.GP_JOVEM.Size.Height + 6);
                vForm.GP_EXECUCAO.Visible = true;
                #endregion _EXECUCAO
                //----------------------
                #region _EVENTO
                if (iTipo == 6) vForm.GP_EVENTO.Text = "Evasão";
                if (iTipo == 7) vForm.GP_EVENTO.Text = "Extinção da Medida";
                vForm.GP_EVENTO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_EXECUCAO.Location.Y + vForm.GP_EXECUCAO.Size.Height + 6);

                if (iTipo == 2)
                {
                    vForm.GP_EVENTO.Visible = false;
                    vForm.GP_ARQUIVO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_EXECUCAO.Location.Y + vForm.GP_EXECUCAO.Size.Height + 6);
                }
                else
                {
                    vForm.GP_EVENTO.Visible = true;
                    vForm.GP_ARQUIVO.Location = new Point(vForm.GP_DOC.Location.X, vForm.GP_EVENTO.Location.Y + vForm.GP_EVENTO.Size.Height + 6);
                }
                #endregion _EVENTO
                //----------------------
                #region _ARQUIVO
                vForm.GP_ARQUIVO.Visible = true;
                #endregion _ARQUIVO
            }
            //----------------------
            //FORMULARIO
            pUltimo = new Point(vForm.GP_ARQUIVO.Location.Y + vForm.GP_ARQUIVO.Size.Height + 12, 0);
            vForm.btn_ok.Location = new Point(vForm.btn_ok.Location.X, pUltimo.X);
            vForm.btn_can.Location = new Point(vForm.btn_can.Location.X, pUltimo.X);
            vForm.Size = new Size(vForm.GP_DOC.Size.Width + vForm.GP_DOC.Location.X + 24,
                                  vForm.btn_ok.Location.Y + vForm.btn_ok.Size.Height + 50);
        }
        private void Carregar_Dados_Documento(frm_documento vForm, string sIDProcesso, string sIDDocumento)
        {
            try
            {
                DataSet dtDocumentos = ConexaoSQL.documentos(sIDProcesso, sIDDocumento);
                foreach (DataRow pRowDoc in dtDocumentos.Tables[0].Rows)
                {
                    try { vForm.DOC_ID_PLANTAO_NAI.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("id_plantao_nai"); } catch { };

                    #region _DOC_INI
                    try { vForm.DOC_DESC.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_documento"); } catch { };
                    try { vForm.DOC_ORIGEM.SelectedIndex = vForm.DOC_ORIGEM.Items.IndexOf(dtDocumentos.Tables[0].Rows[0].Field<string>("desc_local_documento")); } catch { };
                    try
                    {
                        DateTime vDOC_DT = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_documento");
                        vForm.DOC_DT.Text = vDOC_DT.ToShortDateString();
                    }
                    catch { }
                    #endregion _DOC_INI

                    #region _JOVEM
                    vForm.JOV_COD.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("id_jovem");
                    vForm.JOV_NOME.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("nome_jovem");
                    vForm.JOV_CPF.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("cpf_jovem");
                    vForm.JOV_SIPIA.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("cod_sipia");
                    vForm.JOV_IDENT.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("ident_jovem");
                    vForm.JOV_DTNASC.Text = "";
                    vForm.JOV_IDADE.Text = "0";
                    try
                    {
                        vForm.JOV_FOTO.Image = null;
                        vForm.JOV_FOTO.Image = Globais.ByteArrayToImage((Byte[])dtDocumentos.Tables[0].Rows[0]["foto"]);
                    }
                    catch { }
                    try
                    {
                        DateTime dt_nasc_jovem = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_nasc_jovem");
                        vForm.JOV_DTNASC.Text = dt_nasc_jovem.ToShortDateString();
                        vForm.JOV_IDADE.Text = Globais.CalcularIdade(dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_nasc_jovem")).ToString();
                    }
                    catch { }
                    vForm.JOV_PAI.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("nome_pai_jovem");
                    vForm.JOV_MAE.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("nome_mae_jovem");
                    vForm.JOV_END.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("end_jovem");
                    vForm.JOV_BAIRRO.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("bairro_jovem");
                    vForm.JOV_CIDADE.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("cidade_jovem");
                    #endregion _JOVEM

                    #region _NAI
                    vForm.NAI_DESC.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_documeto_nai");
                    vForm.RA_ATO_INFRA.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_ra");
                    try { vForm.ID_RA_ATO_INFRA.Text = dtDocumentos.Tables[0].Rows[0].Field<int>("id_ra_ato_inf").ToString(); } catch { };
                    try { vForm.MOT_ENT.SelectedIndex = dtDocumentos.Tables[0].Rows[0].Field<int>("id_tipo_entrada"); } catch { };
                    try
                    {
                        DateTime dt_apreensao = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_apreensao");
                        vForm.DT_APREENSAO.Text = dt_apreensao.ToShortDateString();
                    }
                    catch { }
                    #endregion _NAI

                    #region _OUTROS
                    try { vForm.PAAI_DESC.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_paai"); } catch { };
                    try { vForm.PAAI_ORIGEM.SelectedIndex = vForm.PAAI_ORIGEM.Items.IndexOf(dtDocumentos.Tables[0].Rows[0].Field<string>("desc_local_paai")); } catch { };
                    try { vForm.ATO_INF.SelectedIndex = dtDocumentos.Tables[0].Rows[0].Field<int>("id_ato_inf"); } catch { };
                    #endregion _OUTROS

                    #region _DECISAO
                    vForm.DEC_A.SelectedIndex = vForm.DEC_A.Items.IndexOf(dtDocumentos.Tables[0].Rows[0].Field<string>("desc_decisaoA"));
                    vForm.DEC_B.SelectedIndex = vForm.DEC_B.Items.IndexOf(dtDocumentos.Tables[0].Rows[0].Field<string>("desc_decisaoB"));
                    vForm.DEC_C.SelectedIndex = vForm.DEC_C.Items.IndexOf(dtDocumentos.Tables[0].Rows[0].Field<string>("desc_decisaoC"));
                    try { vForm.PRAZO.SelectedIndex = dtDocumentos.Tables[0].Rows[0].Field<int>("sn_exec_prazo"); } catch { };
                    try
                    {
                        DateTime vdt_decisao = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_decisao");
                        vForm.DEC_DT.Text = vdt_decisao.ToShortDateString();
                    }
                    catch { }
                    #endregion _DECISAO

                    #region _ORIGEM_DESTINO
                    vForm.ORIGEM.SelectedIndex = SelItemComboSubstring(vForm.ORIGEM, dtDocumentos.Tables[0].Rows[0].Field<string>("id_unidade_atual"));
                    vForm.DESTINO.SelectedIndex = SelItemComboSubstring(vForm.DESTINO, dtDocumentos.Tables[0].Rows[0].Field<string>("id_unidade_destino"));
                    #endregion _ORIGEM_DESTINO

                    #region _EXECUCAO
                    try
                    {
                        DateTime dt_apreensao = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_apreensao");
                        vForm.DT_EXEC_INICIO.Text = dt_apreensao.ToShortDateString();
                        DateTime dt_now = DateTime.Now;
                        TimeSpan diff1 = dt_now.Subtract(dt_apreensao);
                        int vdias = (int)diff1.TotalDays;
                        vForm.DT_EXEC_CUMPRIM.Text = vdias.ToString() + " Dias";
                    }
                    catch { }
                    #endregion _EXECUCAO

                    #region _EVENTO
                    vForm.EVENTO1.Items.Clear();
                    if (vForm.DOC_TIPO_DOCUMENTO.Text == "5")
                        vForm.EVENTO1.Items.AddRange(new string[] { "", "Maioridade", "Fim de Internação Sanção", "Benefícios",
                                                                    "Impossibilidade de convivência com outros adolescentes",
                                                                    "Risco em relação à área da Unidade", "Proximidade da residência da familia",
                                                                    "Outros"  });
                    vForm.EVENTO.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_motivo_evento");
                    try
                    {
                        DateTime vdt_decisao = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_evento");
                        vForm.DT_EVENTO.Text = vdt_decisao.ToShortDateString();
                    }
                    catch { }
                    #endregion _EVENTO


                }
            }
            catch { };

        }
        private void AbrirDocumento(string id_doc)
        {
            int vTipo_Documento = -1;

            string gID_Processo = "-1";
            string gID_Jovem = "-1";
            string gID_Documento = "-1";
            DataSet RecordSet = new DataSet();

            frm_documento frm_documento = new frm_documento();
            frm_documento_novo frm_documento_novo = new frm_documento_novo();

            //-------------------------------------
            //NÚMERO DO PROCESSO
            if (TreeView.SelectedNode.Parent == null) gID_Processo = TreeView.SelectedNode.Tag.ToString();
            else gID_Processo = TreeView.SelectedNode.Parent.Tag.ToString();
            frm_documento.DOC_ID_PROCESSO.Text = gID_Processo;
            gID_Documento = id_doc;
            frm_documento.DOC_ID_DOCUMENTO.Text = gID_Documento;

            if ((TreeView.SelectedNode.ImageIndex > 3) && (TreeView.SelectedNode.ImageIndex < 12))
                vTipo_Documento = TreeView.SelectedNode.ImageIndex - 4;
            if (TreeView.SelectedNode.ImageIndex == 13)
                vTipo_Documento = 100;

            frm_documento.DOC_TIPO_DOCUMENTO.Text = vTipo_Documento.ToString();
            //
            //DOC_ID_PLANTAO_NAI

            //-------------------------------------
            //CARREGA O FORM DOCUMENTO
            #region _CARREGA_DOCUMENTO
            try
            {
                //LIMPAR DOCUMENTO
                Limpar_Documento(frm_documento);

                //NOVO DOCUMENTO
                #region _NOVO_DOCUMENTO
                if ((gID_Documento == "") || (gID_Documento == "-1"))
                {
                    //TIPO DE DOCUMENTO
                    if (frm_documento_novo.ShowDialog(this) == DialogResult.OK)
                    {
                        vTipo_Documento = frm_documento_novo.doc_tipo.SelectedIndex;
                        if (vTipo_Documento == frm_documento_novo.doc_tipo.Items.Count - 1) vTipo_Documento = 100;

                        if (vTipo_Documento == 100) frm_documento.Text = "Novo documento";
                        else frm_documento.Text = "Novo documento de " + frm_documento_novo.doc_tipo.Text;

                        frm_documento.DOC_TIPO_DOCUMENTO.Text = vTipo_Documento.ToString();

                    }
                    else return;

                    //CARREGAR DADOS NO FORM
                    if (vTipo_Documento > 0)
                    {
                        try
                        {
                            RecordSet = new DataSet();
                            RecordSet = Consulta.Consultar("SELECT id_processo, id_jovem, Max(id_processo_documento) as id_documentoUlt FROM tb_cv_processo_documento " +
                                                           "GROUP BY id_processo, id_jovem HAVING(id_processo = " + gID_Processo + ");");
                            if (RecordSet.Tables[0].Rows.Count == 1)
                            {
                                gID_Jovem = RecordSet.Tables[0].Rows[0]["id_jovem"].ToString();
                                gID_Documento = RecordSet.Tables[0].Rows[0]["id_documentoUlt"].ToString();
                            }
                        }
                        catch { }
                        Carregar_Dados_Documento(frm_documento, gID_Processo, gID_Documento);
                        frm_documento.DOC_DESC.Text = "";
                        frm_documento.DOC_ORIGEM.SelectedIndex = -1;
                        frm_documento.DOC_DT.Text = DateTime.Now.ToShortDateString();
                        frm_documento.ORIGEM.SelectedIndex = frm_documento.ORIGEM.Items.IndexOf(frm_documento.DESTINO.Text);
                        frm_documento.DESTINO.SelectedIndex = -1;
                        frm_documento.EVENTO.Text = "";
                        frm_documento.EVENTO1.Text = "";
                    }
                }
                #endregion _NOVO_DOCUMENTO

                //EDITAR DOCUMENTO
                #region _EDIT_DOCUMENTO
                else
                {
                    //TIPO DE DOCUMENTO
                    frm_documento.Text = "Editar o documento de " + TreeView.SelectedNode.Text + " (" + TreeView.SelectedNode.Parent.Text + ")";

                    frm_documento.DOC_TIPO_DOCUMENTO.Text = vTipo_Documento.ToString();
                    
                    //CARREGAR DADOS NO FORM
                    Carregar_Dados_Documento(frm_documento, gID_Processo, gID_Documento);
                }
                #endregion _EDIT_DOCUMENTO

                //REDIMENSIONAR CAMPOS NO FORM
                Resize_Documento(frm_documento, vTipo_Documento);
            }
            catch { }
            #endregion _CARREGA_DOCUMENTO

            //-------------------------------------
            //ABRE E RETORNA O FORM DOCUMENTO
            #region _RETORNA_DOCUMENTO

            string vIDJovem = "0";
            string vIDUnid_Atual = "0";
            string vIDUnid_Dest = "0";
            int iNovoRegistro = 1;
            string sNovoRegistro = "1";
            string sDT_APREENSAO = "";
            string vSQL = "";

            if (frm_documento.ShowDialog(this) == DialogResult.OK)
            {
                #region _UNIDADE
                vIDUnid_Atual = frm_documento.ORIGEM.Text;
                if (vIDUnid_Atual.Length > 12) vIDUnid_Atual = vIDUnid_Atual.Substring(0, 12);
                vIDUnid_Dest = frm_documento.DESTINO.Text;
                if (frm_documento.DOC_TIPO_DOCUMENTO.Text == "0") vIDUnid_Atual = "060302080000";
                if (vIDUnid_Dest.Length > 12) vIDUnid_Dest = vIDUnid_Dest.Substring(0, 12);
                else vIDUnid_Dest = vIDUnid_Atual;
                #endregion _UNIDADE
                //NOVO DOCUMENTO
                #region _INSERIR_DOCUMENTO
                if (frm_documento.Text.Substring(0, 4) == "Novo")
                {
                    //-------------------------------------
                    //ATUALIZAR JOVEM
                    #region _INSERIR_ATUALIZAR_JOVEM
                    //VERIFICAR ID_JOVEM, UNIDADE
                    #region _ID_JOVEM
                    vIDJovem = "0";
                    Boolean encontrouJovem = false;
                    DataSet dtJovem = ConexaoSQL.Jovens(frm_documento.JOV_COD_NAI.Text, "");
                    if (dtJovem.Tables[0].Rows.Count == 1)
                    {
                        vIDJovem = frm_documento.JOV_COD_NAI.Text;
                        encontrouJovem = true;
                    }
                    if (vIDJovem == "0")
                    {
                        dtJovem = ConexaoSQL.Jovens(frm_documento.JOV_COD.Text, "");
                        if (dtJovem.Tables[0].Rows.Count == 1)
                        {
                            vIDJovem = frm_documento.JOV_COD.Text;
                            encontrouJovem = true;
                        }
                    }
                    string vIDJovemNAI20 = frm_documento.JOV_COD_NAI.Text;
                    if (vIDJovemNAI20.Length > 20) vIDJovemNAI20 = vIDJovemNAI20.Substring(0, 20);


                    if (!encontrouJovem)
                    {
                        RecordSet = Consulta.Consultar("SELECT max(CONVERT(substring(id_jovem, 8, 14), UNSIGNED INTEGER)) + 1 as newcod FROM tb_jovem;");
                        try { sNovoRegistro = RecordSet.Tables[0].Rows[0]["newcod"].ToString(); } catch { sNovoRegistro = "1"; }

                        vIDJovem = "S-" + DateTime.Now.Year.ToString() + "-";
                        while (vIDJovem.Length < 20 - sNovoRegistro.Length) vIDJovem = vIDJovem + "0";
                        vIDJovem = vIDJovem + sNovoRegistro;
                    }
                    #endregion _ID_JOVEM
                    //INSERT NA TABELA JOVEM
                    #region _TB_JOVEM_TBs_NAI
                    vSQL = "INSERT INTO tb_jovem(id_jovem, nome_jovem, foto, LOCAL_DT, SERVER_DT, cpf_jovem, id_sexo, ident_jovem, dt_nasc_jovem, dt_nasc_est_jovem, cod_sipia, id_cor, " +
                                                 "end_jovem, bairro_jovem, cidade_jovem, cep_jovem, uf_jovem, nome_pai_jovem, cpf_pai_jovem, ident_pai_jovem, nome_mae_jovem, cpf_mae_jovem, ident_mae_jovem, " +
                                                 "nome_resp_jovem, cpf_resp_jovem, ident_resp_jovem, parentesco_resp_jovem, fone1_jovem, fone2_jovem, fone3_jovem, contato_jovem) " +
                                        "SELECT substr(tb_nai_interno.id_interno,1,20), tb_nai_interno.nome_interno, tb_nai_interno.foto, tb_nai_interno.LOCAL_DT, tb_nai_interno.SERVER_DT, tb_nai_interno.cpf_interno, " +
                                                 "tb_nai_interno.id_sexo, tb_nai_interno.ident_interno, tb_nai_interno.dt_nasc_interno, tb_nai_interno.dt_nasc_est_interno, tb_nai_interno.cod_sipia, tb_nai_interno.id_cor, " +
                                                 "tb_nai_interno.end_interno, tb_nai_interno.bairro_interno, tb_nai_interno.cidade_interno, tb_nai_interno.cep_interno, tb_nai_interno.uf_interno, tb_nai_interno.nome_pai_interno, " +
                                                 "tb_nai_interno.cpf_pai_interno, tb_nai_interno.ident_pai_interno, tb_nai_interno.nome_mae_interno, tb_nai_interno.cpf_mae_interno, tb_nai_interno.ident_mae_interno, " +
                                                 "tb_nai_interno.nome_resp_interno, tb_nai_interno.cpf_resp_interno, tb_nai_interno.ident_resp_interno, tb_nai_interno.parentesco_resp_interno, tb_nai_interno.fone1_interno, " +
                                                 "tb_nai_interno.fone2_interno, tb_nai_interno.fone3_interno, tb_nai_interno.contato_interno FROM tb_nai_interno " +
                                        "WHERE(tb_nai_interno.id_interno = '" + frm_documento.JOV_COD_NAI.Text + "') AND (tb_nai_interno.id_plantao = '" + frm_documento.DOC_ID_PLANTAO_NAI.Text + "');";
                    if (Consulta.Executar(vSQL, "", null, "", null) > 0)
                    {
                        if (Consulta.Executar("UPDATE tb_jovem SET id_jovem = '" + vIDJovem + "' WHERE (id_jovem = '" + vIDJovemNAI20 + "');", "", null, "", null) >0 )
                        {
                            Consulta.Executar("UPDATE tb_nai_plantao_interno SET id_interno = '" + vIDJovem + "' WHERE (id_interno = '" + frm_documento.JOV_COD_NAI.Text + "') AND (id_plantao = '" + frm_documento.DOC_ID_PLANTAO_NAI.Text + "');", "", null, "", null);
                            Consulta.Executar("UPDATE tb_nai_interno SET id_interno = '" + vIDJovem + "' WHERE (id_interno = '" + frm_documento.JOV_COD_NAI.Text + "') AND (id_plantao = '" + frm_documento.DOC_ID_PLANTAO_NAI.Text + "');", "", null, "", null);
                            Consulta.Executar("UPDATE tb_nai_cadastro SET id_interno = '" + vIDJovem + "' WHERE (id_interno = '" + frm_documento.JOV_COD_NAI.Text + "') AND (id_plantao = '" + frm_documento.DOC_ID_PLANTAO_NAI.Text + "');", "", null, "", null);
                            Consulta.Executar("UPDATE tb_nai_efetivos SET id_interno = '" + vIDJovem + "' WHERE (id_interno = '" + frm_documento.JOV_COD_NAI.Text + "') AND (id_plantao = '" + frm_documento.DOC_ID_PLANTAO_NAI.Text + "');", "", null, "", null);
                            Consulta.Executar("UPDATE tb_nai_estatistica SET id_interno = '" + vIDJovem + "' WHERE (id_interno = '" + frm_documento.JOV_COD_NAI.Text + "') AND (id_plantao = '" + frm_documento.DOC_ID_PLANTAO_NAI.Text + "');", "", null, "", null);
                            Consulta.Executar("UPDATE tb_nai_flagrante SET id_interno = '" + vIDJovem + "' WHERE (id_interno = '" + frm_documento.JOV_COD_NAI.Text + "') AND (id_plantao = '" + frm_documento.DOC_ID_PLANTAO_NAI.Text + "');", "", null, "", null);
                            Consulta.Executar("UPDATE tb_nai_modulo SET id_interno = '" + vIDJovem + "' WHERE (id_interno = '" + frm_documento.JOV_COD_NAI.Text + "') AND (id_plantao = '" + frm_documento.DOC_ID_PLANTAO_NAI.Text + "');", "", null, "", null);
                            Consulta.Executar("UPDATE tb_nai_visitantes_entrada SET id_interno = '" + vIDJovem + "' WHERE (id_interno = '" + frm_documento.JOV_COD_NAI.Text + "') AND (id_plantao = '" + frm_documento.DOC_ID_PLANTAO_NAI.Text + "');", "", null, "", null);
                        }
                    }
                    #endregion _TB_JOVEM_TBs_NAI  
                    #endregion _INSERIR_ATUALIZAR_JOVEM

                    //NOVO ID_REGISTRO
                    RecordSet = new DataSet();
                    RecordSet = Consulta.Consultar("SELECT Max(id_processo_documento) + 1 AS newcod FROM tb_cv_processo_documento WHERE (id_processo = " + gID_Processo + ") ;");
                    sNovoRegistro = "1";
                    iNovoRegistro = 1;
                    if (RecordSet.Tables[0].Rows.Count > 0)
                    {
                        try { sNovoRegistro = RecordSet.Tables[0].Rows[0]["newcod"].ToString(); } catch { sNovoRegistro = "1"; }
                        try { iNovoRegistro = Int32.Parse(sNovoRegistro); } catch { iNovoRegistro = 1; sNovoRegistro = "1"; }
                    }
                    try
                    {
                        DateTime Date_APREENSAO = DateTime.Parse(frm_documento.DT_APREENSAO.Text);
                        sDT_APREENSAO = String.Format("{0:yyyy-MM-dd}", Date_APREENSAO);
                    }
                    catch { sDT_APREENSAO = ""; }

                    //INSERT NA TABELA tb_cv_processo_documento
                    vSQL = "INSERT INTO tb_cv_processo_documento (id_processo, id_processo_documento, id_processo_documento_tipo, desc_documento, " +
                                      "dt_documento, id_local_documento, desc_documeto_nai, dt_apreensao, id_ato_inf, id_ra_ato_inf, id_jovem, " +
                                      "desc_paai, id_local_paai, id_tipo_entrada, id_decisaoA, id_decisaoB, id_decisaoC, dt_decisao, sn_exec_prazo, " +
                                      "id_unidade_atual, id_unidade_destino, desc_motivo_evento, dt_evento, id_plantao_nai, LOCAL_DT, SERVER_DT, " +
                                      "CPF_USER) " +
                           "VALUES(" + gID_Processo                                                     + " , " +
                                       sNovoRegistro                                                    + " , " +
                                       frm_documento.DOC_TIPO_DOCUMENTO.Text                            + " ,'" +
                                       frm_documento.DOC_DESC.Text                                      + "','" +
                                       String.Format("{0:yyyy-MM-dd}", frm_documento.DOC_DT.Value)      + "', " +
                                       //frm_documento.DOC_ORIGEM.SelectedIndex.ToString()                + " ,'" +
                                       ConexaoSQL.SelItemCombo_Decisao("local", frm_documento.DOC_ORIGEM.Text).ToString() + " ,'" +
                                       frm_documento.NAI_DESC.Text                                      + "','" +
                                       sDT_APREENSAO                                                    + "', " +
                                       frm_documento.ATO_INF.SelectedIndex.ToString()                   + " , " +
                                       frm_documento.ID_RA_ATO_INFRA.Text                               + " ,'" +
                                       vIDJovem                                                         + "','" +
                                       frm_documento.PAAI_DESC.Text                                     + "', " +
                                       //frm_documento.PAAI_ORIGEM.SelectedIndex.ToString()               + " , " +
                                       ConexaoSQL.SelItemCombo_Decisao("local", frm_documento.PAAI_ORIGEM.Text).ToString() + " , " +
                                       frm_documento.MOT_ENT.SelectedIndex.ToString()                   + " , " +
                                       ConexaoSQL.SelItemCombo_Decisao("decisaoa", frm_documento.DEC_A.Text).ToString()                     + " , " +
                                       ConexaoSQL.SelItemCombo_Decisao("decisaob", frm_documento.DEC_B.Text).ToString()                     + " , " +
                                       ConexaoSQL.SelItemCombo_Decisao("decisaoc", frm_documento.DEC_C.Text).ToString()                     + " ,'" +
                                       String.Format("{0:yyyy-MM-dd}", frm_documento.DEC_DT.Value)      + "','" +
                                       frm_documento.PRAZO.SelectedIndex.ToString()                     + "','" +
                                       vIDUnid_Atual                                                    + "','" +
                                       vIDUnid_Dest                                                     + "','" +
                                       frm_documento.EVENTO.Text                                        + "','" +
                                       String.Format("{0:yyyy-MM-dd}", frm_documento.DT_EVENTO.Value)   + "','" +
                                       frm_documento.DOC_ID_PLANTAO_NAI.Text                            + "', " +
                                       "DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i')"                           + " , " +
                                       "DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i')"                           + " ,'" +
                                       Globais.CPFUSER                                                  + "');";
                    int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                    if (iInsertResult > 0)
                    {
                        string sTextoTreeView = "";
                        try
                        {
                            RecordSet = new DataSet();
                            RecordSet = Consulta.Consultar("SELECT desc_processo_documento_tipo FROM tb_cv_processo_documento_tipo where id_processo_documento_tipo = " + frm_documento.DOC_TIPO_DOCUMENTO.Text + ";");
                            if (RecordSet.Tables[0].Rows.Count >0 )
                                sTextoTreeView = RecordSet.Tables[0].Rows[0]["desc_processo_documento_tipo"].ToString();
                        }
                        catch { }

                        int iTPDoc = 100;
                        try
                        {
                            iTPDoc = Int32.Parse(frm_documento.DOC_TIPO_DOCUMENTO.Text);
                            if (iTPDoc == 100) iTPDoc = 13;
                            else iTPDoc = iTPDoc + 4;
                        }
                        catch { }
                        TreeNode Node_Doc = new TreeNode();
                        Node_Doc.Name = "DOC_" + gID_Processo + "_" + sNovoRegistro;
                        Node_Doc.Tag = iNovoRegistro;
                        Node_Doc.Text = sTextoTreeView;
                        Node_Doc.ImageIndex = iTPDoc;
                        Node_Doc.SelectedImageIndex = iTPDoc;
                        if (TreeView.SelectedNode.Parent == null) TreeView.SelectedNode.Nodes.Add(Node_Doc);
                        else TreeView.SelectedNode.Parent.Nodes.Add(Node_Doc);
                    }
                    else MessageBox.Show("Ocorreu um erro ao Inserir este documento.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                #endregion _INSERIR_DOCUMENTO
                //EDITAR DOCUMENTO
                #region _EDITAR_DOCUMENTO
                else
                {
                    vIDJovem = frm_documento.JOV_COD.Text;
                    try
                    {
                        DateTime Date_APREENSAO = DateTime.Parse(frm_documento.DT_APREENSAO.Text);
                        sDT_APREENSAO = String.Format("{0:yyyy-MM-dd}", Date_APREENSAO);
                    }
                    catch { sDT_APREENSAO = ""; }
                    vSQL = "UPDATE tb_cv_processo_documento SET " + 
                                  "id_processo_documento_tipo = " +  frm_documento.DOC_TIPO_DOCUMENTO.Text                                            + " ," +
                                  "desc_documento = '"            +  frm_documento.DOC_DESC.Text                                                      + "'," +
                                  "dt_documento = '"              +  String.Format("{0:yyyy-MM-dd}", frm_documento.DOC_DT.Value)                      + "'," +
                                  //"id_local_documento = "         +  frm_documento.DOC_ORIGEM.SelectedIndex.ToString()                                + " ," +
                                  "id_local_documento = "        + ConexaoSQL.SelItemCombo_Decisao("local", frm_documento.DOC_ORIGEM.Text).ToString() + " ," +
                                  "desc_documeto_nai = '"         +  frm_documento.NAI_DESC.Text                                                      + "'," +
                                  "dt_apreensao = '"              +  sDT_APREENSAO                                                                    + "'," +
                                  "id_ato_inf = "                 +  frm_documento.ATO_INF.SelectedIndex.ToString()                                   + " ," +
                                  "id_ra_ato_inf = "              +  frm_documento.ID_RA_ATO_INFRA.Text                                               + " ," +
                                  "id_jovem = '"                  +  vIDJovem                                                                         + "'," +
                                  "desc_paai = '"                 +  frm_documento.PAAI_DESC.Text                                                     + "'," +
                                  //"id_local_paai = " + frm_documento.PAAI_ORIGEM.SelectedIndex.ToString() + " ," +
                                  "id_local_paai = "             + ConexaoSQL.SelItemCombo_Decisao("local", frm_documento.PAAI_ORIGEM.Text).ToString() + " ," +
                                  "id_tipo_entrada = "            +  frm_documento.MOT_ENT.SelectedIndex.ToString()                                   + " ," +
                                  "id_decisaoA = "                +  ConexaoSQL.SelItemCombo_Decisao("decisaoa", frm_documento.DEC_A.Text).ToString() + " ," +
                                  "id_decisaoB = "                +  ConexaoSQL.SelItemCombo_Decisao("decisaob", frm_documento.DEC_B.Text).ToString() + " ," +
                                  "id_decisaoC = "                +  ConexaoSQL.SelItemCombo_Decisao("decisaoc", frm_documento.DEC_C.Text).ToString() + " ," +
                                  "dt_decisao = '"                +  String.Format("{0:yyyy-MM-dd}", frm_documento.DEC_DT.Value)                      + "'," +
                                  "sn_exec_prazo = '"             +  frm_documento.PRAZO.SelectedIndex.ToString()                                     + "'," +
                                  "id_unidade_atual = '"          +  vIDUnid_Atual                                                                    + "'," +
                                  "id_unidade_destino = '"        +  vIDUnid_Dest                                                                     + "'," +
                                  "desc_motivo_evento = '"        +  frm_documento.EVENTO.Text                                                        + "'," +
                                  "dt_evento = '"                 +  String.Format("{0:yyyy-MM-dd}", frm_documento.DT_EVENTO.Value)                   + "'," +
                                  "id_plantao_nai = '"            +  frm_documento.DOC_ID_PLANTAO_NAI.Text                                            + "'," +
                                  "LOCAL_DT = "                   +  "DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i')"                                           + " ," +
                                  "SERVER_DT = "                  +  "DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i')"                                           + " ," +
                                  "CPF_USER = '"                  +  Globais.CPFUSER                                                                  + "' " +
                           "WHERE (id_processo = " + gID_Processo + ") AND (id_processo_documento = " + frm_documento.DOC_ID_DOCUMENTO.Text + ");";
                    int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                    if (iInsertResult > 0)
                    {
                        int iTPDoc = 100;
                        try
                        {
                            iTPDoc = Int32.Parse(frm_documento.DOC_TIPO_DOCUMENTO.Text);
                            if (iTPDoc == 100) iTPDoc = 13;
                            else iTPDoc = iTPDoc + 4;
                        } catch { }
                        TreeView.SelectedNode.ImageIndex = iTPDoc;
                        TreeView.SelectedNode.SelectedImageIndex = iTPDoc;
                    }
                    else MessageBox.Show("Ocorreu um erro ao Editar este Documento.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion _EDITAR_DOCUMENTO
            }
            #endregion _RETORNA_DOCUMENTO
            //-------------------------------------
        }
        //---------------------------------------------------------
        // CARREGAR PANEL DOCUMENTO
        //---------------------------------------------------------
        private void LimparPanelDocumento()
        {
            try
            {
                //-------------------------------------
                //LIMPAR O FORM DOCUMENTO
                #region _DOC_INI
                DOC_DESC.Text = "";  
                DOC_ORIGEM.Text = "";
                DOC_DT.Text = "__/__/____";
                #endregion _DOC_INI

                #region _JOVEM
                JOV_COD.Text = "";
                JOV_NOME.Text = "";
                JOV_CPF.Text = "___.___.___-__";
                JOV_SIPIA.Text = "";
                JOV_IDENT.Text = "";
                JOV_DTNASC.Text = "__/__/____";
                JOV_IDADE.Text = "0";
                JOV_FOTO.Image = null;
                JOV_PAI.Text = "";
                JOV_MAE.Text = "";
                JOV_END.Text = "";
                JOV_BAIRRO.Text = "";
                JOV_CIDADE.Text = "";
                #endregion _JOVEM

                #region _NAI
                NAI_DESC.Text = "";
                RA_ATO_INFRA.Text = "";
                MOT_ENT.Text = "";
                DT_APREENSAO.Text = "__/__/____";
                #endregion _NAI

                #region _OUTROS
                PAAI_DESC.Text = "";
                PAAI_ORIGEM.Text = "";
                ATO_INF.Text = "";
                #endregion _OUTROS

                #region _DECISAO
                DECISAO.Text = "";
                PRAZO_LB.Visible = false;
                PRAZO.Visible = false;
                PRAZO.Text = "";
                DEC_DT.Text = "__/__/____";
                #endregion _DECISAO

                #region _ORIGEM_DESTINO
                ORIGEM.Text = "";
                DESTINO.Text = "";
                #endregion _ORIGEM_DESTINO

                #region _EXECUCAO
                DT_EXEC_INICIO.Text = "__/__/____";
                DT_EXEC_CUMPRIM.Text = "0 Dias";
                #endregion _EXECUCAO

                #region _EVENTO
                EVENTO.Text = "";
                DT_EVENTO.Text = "__/__/____"; 
                #endregion _EVENTO
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResizePanelDocumento(int iTipo)
        {
            //----------------------
            //GP_JOVEM
            GP_JOVEM.Location = new Point(GP_DOC.Location.X, GP_DOC.Location.Y + GP_DOC.Size.Height + 6);

            if (iTipo == 0)
            {
                //----------------------
                #region _NAI
                GP_NAI.Location = new Point(GP_DOC.Location.X, GP_JOVEM.Location.Y + GP_JOVEM.Size.Height + 6);
                GP_NAI.Visible = true;
                #endregion _NAI
                //----------------------
                #region _OUTROS
                GP_OUTRO.Location = new Point(GP_DOC.Location.X, GP_NAI.Location.Y + GP_NAI.Size.Height + 6);
                GP_OUTRO.Visible = true;
                #endregion _OUTROS
                //----------------------
                #region _DECISAO
                GP_DECISAO.Location = new Point(GP_DOC.Location.X, GP_OUTRO.Location.Y + GP_OUTRO.Size.Height + 6);
                GP_DECISAO.Visible = true;
                #endregion _DECISAO
                //----------------------
                #region _ORIGEM_DESTINO
                GP_ORIGEM.Visible = false;
                GP_DESTINO.Location = new Point(GP_DOC.Location.X, GP_DECISAO.Location.Y + GP_DECISAO.Size.Height + 6);
                GP_DESTINO.Size = GP_DOC.Size;
                GP_DESTINO.Visible = true;
                #endregion _ORIGEM_DESTINO
                //----------------------
                #region _EXECUCAO
                GP_EXECUCAO.Visible = false;
                #endregion _EXECUCAO
                //----------------------
                #region _EVENTO
                GP_EVENTO.Visible = false;
                #endregion _EVENTO
                //----------------------
                #region _ARQUIVO
                GP_ARQUIVO.Location = new Point(GP_DOC.Location.X, GP_DESTINO.Location.Y + GP_DESTINO.Size.Height + 6);
                GP_ARQUIVO.Visible = true;
                #endregion _ARQUIVO
            }
            else if ((iTipo == 1) || (iTipo == 3) || (iTipo == 4))
            {
                //----------------------
                #region _NAI
                GP_NAI.Visible = false;
                #endregion _NAI
                //----------------------
                #region _OUTROS
                GP_OUTRO.Location = new Point(GP_DOC.Location.X, GP_JOVEM.Location.Y + GP_JOVEM.Size.Height + 6);
                GP_OUTRO.Visible = true;
                #endregion _OUTROS
                //----------------------
                #region _DECISAO
                GP_DECISAO.Location = new Point(GP_DOC.Location.X, GP_OUTRO.Location.Y + GP_OUTRO.Size.Height + 6);
                GP_DECISAO.Visible = true;
                #endregion _DECISAO
                //----------------------
                #region _ORIGEM_DESTINO
                GP_ORIGEM.Visible = false;
                GP_DESTINO.Visible = false;
                #endregion _ORIGEM_DESTINO
                //----------------------
                #region _EXECUCAO
                GP_EXECUCAO.Visible = false;
                #endregion _EXECUCAO
                //----------------------
                #region _EVENTO
                GP_EVENTO.Visible = false;
                #endregion _EVENTO
                //----------------------
                #region _ARQUIVO
                GP_ARQUIVO.Location = new Point(GP_DOC.Location.X, GP_DECISAO.Location.Y + GP_DECISAO.Size.Height + 6);
                GP_ARQUIVO.Visible = true;
                #endregion _ARQUIVO
            }
            else if (iTipo == 5)
            {
                //----------------------
                #region _NAI
                GP_NAI.Visible = false;
                #endregion _NAI
                //----------------------
                #region _OUTROS
                GP_OUTRO.Location = new Point(GP_DOC.Location.X, GP_JOVEM.Location.Y + GP_JOVEM.Size.Height + 6);
                GP_OUTRO.Visible = true;
                #endregion _OUTROS
                //----------------------
                #region _DECISAO
                GP_DECISAO.Location = new Point(GP_DOC.Location.X, GP_OUTRO.Location.Y + GP_OUTRO.Size.Height + 6);
                GP_DECISAO.Visible = true;
                #endregion _DECISAO
                //----------------------
                #region _ORIGEM_DESTINO
                GP_ORIGEM.Location = new Point(GP_DOC.Location.X, GP_DECISAO.Location.Y + GP_DECISAO.Size.Height + 6);
                GP_ORIGEM.Visible = true;
                //----------------------
                GP_DESTINO.Location = new Point(GP_DOC.Location.X + (GP_DOC.Size.Width / 2) + 6, GP_DECISAO.Location.Y + GP_DECISAO.Size.Height + 6);
                GP_DESTINO.Visible = true;
                DESTINO.Visible = true;
                GP_DESTINO.Size = GP_ORIGEM.Size;
                #endregion _ORIGEM_DESTINO
                //----------------------
                #region _EXECUCAO
                GP_EXECUCAO.Size = GP_DOC.Size;
                GP_EXECUCAO.Location = new Point(GP_DOC.Location.X, GP_ORIGEM.Location.Y + GP_ORIGEM.Size.Height + 6);
                GP_EXECUCAO.Visible = true;
                #endregion _EXECUCAO
                //----------------------
                #region _EVENTO
                GP_EVENTO.Text = "Transferência";
                GP_EVENTO.Location = new Point(GP_DOC.Location.X, GP_EXECUCAO.Location.Y + GP_EXECUCAO.Size.Height + 6);
                GP_EVENTO.Visible = true;
                #endregion _EVENTO
                //----------------------
                #region _ARQUIVO
                GP_ARQUIVO.Location = new Point(GP_DOC.Location.X, GP_EVENTO.Location.Y + GP_EVENTO.Size.Height + 6);
                GP_ARQUIVO.Visible = true;
                #endregion _ARQUIVO
            }
            else if ((iTipo == 2) || (iTipo == 6) || (iTipo == 7))
            {
                //----------------------
                #region _NAI
                GP_NAI.Visible = false;
                #endregion _NAI
                //----------------------
                #region _OUTROS
                GP_OUTRO.Visible = false;
                #endregion _OUTROS
                //----------------------
                #region _DECISAO
                GP_DECISAO.Visible = false;
                #endregion _DECISAO
                //----------------------
                #region _ORIGEM_DESTINO
                GP_ORIGEM.Location = new Point(GP_DOC.Location.X, GP_JOVEM.Location.Y + GP_JOVEM.Size.Height + 6);
                GP_ORIGEM.Visible = true;
                //----------------------
                GP_DESTINO.Visible = false;
                #endregion _ORIGEM_DESTINO
                //----------------------
                #region _EXECUCAO
                GP_EXECUCAO.Location = new Point(GP_DOC.Location.X + (GP_DOC.Size.Width / 2) + 6, GP_JOVEM.Location.Y + GP_JOVEM.Size.Height + 6);
                GP_EXECUCAO.Visible = true;
                GP_EXECUCAO.Size = GP_ORIGEM.Size;
                #endregion _EXECUCAO
                //----------------------
                #region _EVENTO
                if (iTipo == 6) GP_EVENTO.Text = "Evasão";
                if (iTipo == 7) GP_EVENTO.Text = "Extinção da Medida";
                GP_EVENTO.Location = new Point(GP_DOC.Location.X, GP_EXECUCAO.Location.Y + GP_EXECUCAO.Size.Height + 6);

                if (iTipo == 2)
                {
                    GP_EVENTO.Visible = false;
                    GP_ARQUIVO.Location = new Point(GP_DOC.Location.X, GP_EXECUCAO.Location.Y + GP_EXECUCAO.Size.Height + 6);
                }
                else
                {
                    GP_EVENTO.Visible = true;
                    GP_ARQUIVO.Location = new Point(GP_DOC.Location.X, GP_EVENTO.Location.Y + GP_EVENTO.Size.Height + 6);
                }
                #endregion _EVENTO
                //----------------------
                #region _ARQUIVO
                GP_ARQUIVO.Visible = true;
                #endregion _ARQUIVO
            }
        }
        private void CarregarPanelDocumento(string id_doc)
        {
            try
            {
                try
                {
                    LimparPanelDocumento();
                    ResizePanelDocumento(TreeView.SelectedNode.ImageIndex - 4);
                }
                catch { }

                //-------------------------------------
                //NÚMERO DO PROCESSO
                string vid_proc = "-1";
                if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                //-------------------------------------
                //CARREGA O FORM DOCUMENTO
                try
                {
                    DataSet dtDocumentos = ConexaoSQL.documentos(vid_proc, id_doc);
                    foreach (DataRow pRowDoc in dtDocumentos.Tables[0].Rows)
                    {
                        #region _DOC_INI
                        try { DOC_DESC.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_documento"); } catch { };
                        try { DOC_ORIGEM.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_local_documento"); } catch { };
                        try
                        {
                            DateTime vDOC_DT = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_documento");
                            DOC_DT.Text = vDOC_DT.ToShortDateString();
                        }
                        catch { }
                        #endregion _DOC_INI

                        #region _JOVEM
                        JOV_COD.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("id_jovem");
                        JOV_NOME.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("nome_jovem");
                        JOV_CPF.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("cpf_jovem");
                        JOV_SIPIA.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("cod_sipia");
                        JOV_IDENT.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("ident_jovem");
                        JOV_DTNASC.Text = "";
                        JOV_IDADE.Text = "0";
                        try
                        {
                            JOV_FOTO.Image = null;
                            JOV_FOTO.Image = Globais.ByteArrayToImage((Byte[])dtDocumentos.Tables[0].Rows[0]["foto"]);
                        }
                        catch { }
                        try
                        {
                            DateTime dt_nasc_jovem = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_nasc_jovem");
                            JOV_DTNASC.Text = dt_nasc_jovem.ToShortDateString();
                            JOV_IDADE.Text = Globais.CalcularIdade(dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_nasc_jovem")).ToString();
                        }
                        catch { }
                        JOV_PAI.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("nome_pai_jovem");
                        JOV_MAE.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("nome_mae_jovem");
                        JOV_END.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("end_jovem");
                        JOV_BAIRRO.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("bairro_jovem");
                        JOV_CIDADE.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("cidade_jovem");
                        #endregion _JOVEM

                        #region _NAI
                        NAI_DESC.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_documeto_nai");
                        RA_ATO_INFRA.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_ra");
                        try { MOT_ENT.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_tipo_entrada"); } catch { };
                        try
                        {
                            DateTime dt_apreensao = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_apreensao");
                            DT_APREENSAO.Text = dt_apreensao.ToShortDateString();
                        }
                        catch { }
                        #endregion _NAI

                        #region _OUTROS
                        try { PAAI_DESC.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_paai"); } catch { };
                        try { PAAI_ORIGEM.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_local_paai"); } catch { };
                        try { ATO_INF.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_ato_inf"); } catch { };
                        #endregion _OUTROS

                        #region _DECISAO
                        DECISAO.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_decisaoA");
                        if (dtDocumentos.Tables[0].Rows[0].Field<string>("desc_decisaoB") != "") DECISAO.Text = DECISAO.Text + " - " + dtDocumentos.Tables[0].Rows[0].Field<string>("desc_decisaoB");
                        if (dtDocumentos.Tables[0].Rows[0].Field<string>("desc_decisaoC") != "") DECISAO.Text = DECISAO.Text + " - " + dtDocumentos.Tables[0].Rows[0].Field<string>("desc_decisaoC");
                        PRAZO_LB.Visible = false;
                        PRAZO.Visible = false;
                        PRAZO.Text = "Não";
                        if (dtDocumentos.Tables[0].Rows[0]["id_decisaoA"].ToString() == "7")
                        {
                            PRAZO_LB.Visible = true;
                            PRAZO.Visible = true;
                            if (dtDocumentos.Tables[0].Rows[0]["sn_exec_prazo"].ToString() == "0") PRAZO.Text = "Sim";
                        }
                        else
                            try
                            {
                                DateTime vdt_decisao = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_decisao");
                                DEC_DT.Text = vdt_decisao.ToShortDateString();
                            }
                            catch { }
                        #endregion _DECISAO

                        #region _ORIGEM_DESTINO
                        ORIGEM.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("sigla_unidade_atual");
                        DESTINO.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("sigla_unidade_destino");
                        #endregion _ORIGEM_DESTINO

                        #region _EXECUCAO
                        try
                        {
                            DateTime dt_apreensao = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_apreensao");
                            DT_EXEC_INICIO.Text = dt_apreensao.ToShortDateString();
                            DateTime dt_now = DateTime.Now;
                            TimeSpan diff1 = dt_now.Subtract(dt_apreensao);
                            int vdias = (int)diff1.TotalDays;
                            DT_EXEC_CUMPRIM.Text = vdias.ToString() + " Dias";
                        }
                        catch { }
                        #endregion _EXECUCAO

                        #region _EVENTO
                        EVENTO.Text = dtDocumentos.Tables[0].Rows[0].Field<string>("desc_motivo_evento");
                        try
                        {
                            DateTime vdt_decisao = dtDocumentos.Tables[0].Rows[0].Field<DateTime>("dt_evento");
                            DT_EVENTO.Text = vdt_decisao.ToShortDateString();
                        }
                        catch { }
                        #endregion _EVENTO
                    }
                }
                catch { };
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        // EXCLUIR DOCUMENTO
        //---------------------------------------------------------
        private void ExcluirDocumento(string id_doc)
        {
            try
            {
                DialogResult result = MessageBox.Show("Você deseja excluir esta Documento?", "Confirmar Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //-------------------------------------
                    //NÚMERO DO PROCESSO
                    string vid_proc = "-1";
                    if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                    else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                    //-------------------------------------
                    //EXCLUIR DOCUMENTO
                    string vSQL = "DELETE FROM tb_cv_processo_documento WHERE (id_processo = " + vid_proc + ") AND (id_processo_documento = " + id_doc + ");";
                    int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                    if (iInsertResult > 0)
                    {
                        TreeView.SelectedNode.Remove();
                        MessageBox.Show("Documento excluido com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Ocorreu um erro ao Excluir este Documento.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        #endregion _DOCUMENTO
        //****************************************************************************************

        //****************************************************************************************
        //*** BARRA DE FERRAMENTA ****************************************************************
        //****************************************************************************************
        #region _BARRA_FERRAMENTA
        //---------------------------------------------------------
        // BTN PROCESSO NOVO
        private void btn_Processo_Novo_Click(object sender, EventArgs e)
        {
            AbrirProcesso("", "-1");
        }
        //---------------------------------------------------------
        // BTN DOCUMENTO NOVO
        private void btn_Documento_Novo_Click(object sender, EventArgs e)
        {
            AbrirDocumento("-1");
        }
        //---------------------------------------------------------
        // BTN AUDIENCIA NOVO
        private void btn_Audiencia_Novo_Click(object sender, EventArgs e)
        {
            AbrirAudiencia("-1");
        }
        //---------------------------------------------------------
        // BTN VINCULAR PROCESSO
        private void btn_Vincular_Processo_Click(object sender, EventArgs e)
        {
            VincularProcesso();
        }
        //---------------------------------------------------------
        // BTN EDITAR
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //-------------------------------------
            //EDITAR PROCESSOS
            if (TreeView.SelectedNode.ImageIndex < 2)
            {
                AbrirProcesso(TreeView.SelectedNode.Text.Substring(0, 4) + TreeView.SelectedNode.Text.Substring(5, 4) + "." + TreeView.SelectedNode.Text.Substring(10, 4), 
                              TreeView.SelectedNode.Tag.ToString());
            }
            //-------------------------------------
            //EDITAR DOCUMENTOS
            else if (TreeView.SelectedNode.ImageIndex > 3)
            {
                AbrirDocumento(TreeView.SelectedNode.Tag.ToString());
            }
            //-------------------------------------
            //EDITAR AUDIENCIA
            else if ((TreeView.SelectedNode.ImageIndex == 2) || (TreeView.SelectedNode.ImageIndex == 3))
            {
                AbrirAudiencia(TreeView.SelectedNode.Tag.ToString());
            }
            //-------------------------------------
        }
        //---------------------------------------------------------
        // BTN EXCLUIR
        private void btn_Del_Click(object sender, EventArgs e)
        {
            //-------------------------------------
            //EXCLUIR PROCESSOS
            if (TreeView.SelectedNode.ImageIndex < 2)
            {
                if (TreeView.SelectedNode.Parent == null) ExcluirProcesso();
                else ExcluirProcessoVinculado(TreeView.SelectedNode.Tag.ToString());
            }
            //-------------------------------------
            //EXCLUIR DOCUMENTOS
            else if (TreeView.SelectedNode.ImageIndex > 3) ExcluirDocumento(TreeView.SelectedNode.Tag.ToString());
            //-------------------------------------
            //EXCLUIR AUDIENCIA
            else if ((TreeView.SelectedNode.ImageIndex == 2) || (TreeView.SelectedNode.ImageIndex == 3)) ExcluirAudiencia(TreeView.SelectedNode.Tag.ToString());
            //-------------------------------------
        }
        //---------------------------------------------------------
        // BTNPESQUISAR
        //---------------------------------------------------------
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarTreeView();
        }








        //---------------------------------------------------------
        #endregion _BARRA_FERRAMENTA
        //****************************************************************************************

        //****************************************************************************************
        //*** JOVEM **************************************************************************
        //****************************************************************************************
        #region _JOVEM
        //---------------------------------------------------------
        // ABRIR FORM DOCUMENTO
        //---------------------------------------------------------
        private void AbrirJovem(string id_aud)
        {
            frm_documento frm_documento = new frm_documento();
            frm_documento.ShowDialog();

            /*
            return;
            frm_audiencia frm_audiencia = new frm_audiencia();
            try
            {
                //-------------------------------------
                //NÚMERO DO PROCESSO
                string vid_proc = "-1";
                if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                //-------------------------------------
                //CARREGA O FORM AUDIENCIA
                #region _CARREGA_DOCUMENTO
                frm_audiencia.Text = "Nova Audiência";
                if ((id_aud == "") || (id_aud == "-1"))
                {
                    frm_audiencia.aud_realizado.SelectedIndex = 1;
                    frm_audiencia.aud_tipo.SelectedIndex = 0;
                }
                else
                {
                    try
                    {
                        DataSet dtAudiencia = ConexaoSQL.audiencias(vid_proc.ToString(), id_aud);
                        foreach (DataRow pRowAud in dtAudiencia.Tables[0].Rows)
                        {
                            //CAPTION DO FORM
                            frm_audiencia.Text = "Audiência: " + pRowAud.Field<DateTime>("dt_audiencia").ToShortDateString();
                            frm_audiencia.aud_data.Value = pRowAud.Field<DateTime>("dt_audiencia");
                            frm_audiencia.aud_hora.Text = pRowAud.Field<string>("hr_audiencia");
                            // REALIZADA (SIM 0 - NÃO 1)
                            int iindex = 1;
                            Int32.TryParse(pRowAud.Field<string>("realizada_audiencia"), out iindex);
                            frm_audiencia.aud_realizado.SelectedIndex = iindex;
                            // TIPO (Apresentação 0 - Continuação 1 - Leitura 2)
                            iindex = 0;
                            Int32.TryParse(pRowAud.Field<string>("tp_audiencia"), out iindex);
                            frm_audiencia.aud_tipo.SelectedIndex = iindex;
                            frm_audiencia.aud_obs.Text = pRowAud.Field<string>("obs_audiencia");
                            frm_audiencia.aud_resultado.Text = pRowAud.Field<string>("resultado_audiencia");
                        }
                    }
                    catch { };
                }
                #endregion _CARREGA_DOCUMENTO
                //-------------------------------------
                //ABRE E RETORNA O FORM AUDIENCIA
                #region _RETORNA_DOCUMENTO
                if (frm_audiencia.ShowDialog(this) == DialogResult.OK)
                {
                    //NOVA AUDIENCIA
                    if (frm_audiencia.Text.Substring(0, 4) == "Nova")
                    {
                        //NOVO ID_REGISTRO
                        DataSet RecordSet = new DataSet();
                        RecordSet = Consulta.Consultar("SELECT Max(id_processo_audiencia) + 1 AS newcod FROM tb_cv_processo_audiencia WHERE (id_processo = " + vid_proc + ") ;");
                        Int64 iNovoRegistro = 1;
                        try { iNovoRegistro = RecordSet.Tables[0].Rows[0].Field<Int64>("newcod"); } catch { iNovoRegistro = 1; }
                        //INSERT NA TABELA tb_cv_processo
                        string vSQL = "INSERT INTO tb_cv_processo_audiencia (id_processo, id_processo_audiencia, dt_audiencia, hr_audiencia, tp_audiencia, obs_audiencia, resultado_audiencia, realizada_audiencia) " +
                                      "VALUES( " + vid_proc + "," +
                                                   iNovoRegistro.ToString() + ", '" +
                                                   String.Format("{0:yyyy-MM-dd}", frm_audiencia.aud_data.Value) + "', '" +
                                                   frm_audiencia.aud_hora.Text + "', '" +
                                                   frm_audiencia.aud_tipo.SelectedIndex.ToString() + "', '" +
                                                   frm_audiencia.aud_obs.Text + "', '" +
                                                   frm_audiencia.aud_resultado.Text + "', '" +
                                                   frm_audiencia.aud_realizado.SelectedIndex.ToString() + "');";
                        int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                        if (iInsertResult > 0)
                        {
                            TreeNode Node_Audi = new TreeNode();
                            Node_Audi.Name = "AUDI_" + vid_proc + "_" + iNovoRegistro.ToString();
                            Node_Audi.Tag = iNovoRegistro;
                            DateTime dt_aud = frm_audiencia.aud_data.Value;
                            Node_Audi.Text = "Audiência: " + frm_audiencia.aud_data.Value.ToShortDateString();
                            Node_Audi.ImageIndex = 3;
                            if (frm_audiencia.aud_realizado.SelectedIndex == 0) Node_Audi.ImageIndex = 2;
                            Node_Audi.SelectedImageIndex = Node_Audi.ImageIndex;
                            if (TreeView.SelectedNode.Parent == null) TreeView.SelectedNode.Nodes.Add(Node_Audi);
                            else TreeView.SelectedNode.Parent.Nodes.Add(Node_Audi);
                        }
                        else MessageBox.Show("Ocorreu um erro ao Inserir este processo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //EDITAR PROCESSO
                    else
                    {
                        //EDITAR NA TABELA tb_cv_processo
                        string vSQL = "UPDATE tb_cv_processo_audiencia SET dt_audiencia = '" + String.Format("{0:yyyy-MM-dd}", frm_audiencia.aud_data.Value) + "'," +
                                                                          "hr_audiencia = '" + frm_audiencia.aud_hora.Text + "'," +
                                                                          "tp_audiencia = '" + frm_audiencia.aud_tipo.SelectedIndex.ToString() + "'," +
                                                                          "obs_audiencia = '" + frm_audiencia.aud_obs.Text + "'," +
                                                                          "resultado_audiencia = '" + frm_audiencia.aud_resultado.Text + "'," +
                                                                          "realizada_audiencia = '" + frm_audiencia.aud_realizado.SelectedIndex.ToString() + "' " +
                                      "WHERE (id_processo = " + vid_proc + ") AND (id_processo_audiencia = " + id_aud + ");";
                        int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                        if (iInsertResult > 0)
                        {
                            TreeView.SelectedNode.Text = "Audiência: " + frm_audiencia.aud_data.Value.ToShortDateString();
                            TreeView.SelectedNode.ImageIndex = 3;
                            if (frm_audiencia.aud_realizado.SelectedIndex == 0) TreeView.SelectedNode.ImageIndex = 2;
                            TreeView.SelectedNode.SelectedImageIndex = TreeView.SelectedNode.ImageIndex;
                        }
                        else MessageBox.Show("Ocorreu um erro ao Editar esta Audiência.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion _RETORNA_DOCUMENTO
                //-------------------------------------
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        //---------------------------------------------------------
        // ABRIR FORM DOCUMENTO
        //---------------------------------------------------------
        public void AbrirJovemSel()
        {
            frm_jovem_sel frm_jovem_sel = new frm_jovem_sel();
            try
            {
                //-------------------------------------
                //ABRE E RETORNA O JOVEM SELECIONADO
                #region _RETORNA_DOCUMENTO
                if (frm_jovem_sel.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show(frm_jovem_sel.ListViewJovens.SelectedItems[0].SubItems[1] + " - " + frm_jovem_sel.ListViewJovens.SelectedItems[0].Text);



/*
                        //NOVO ID_REGISTRO
                        DataSet RecordSet = new DataSet();
                        RecordSet = Consulta.Consultar("SELECT Max(id_processo_audiencia) + 1 AS newcod FROM tb_cv_processo_audiencia WHERE (id_processo = " + vid_proc + ") ;");
                        Int64 iNovoRegistro = 1;
                        try { iNovoRegistro = RecordSet.Tables[0].Rows[0].Field<Int64>("newcod"); } catch { iNovoRegistro = 1; }
                        //INSERT NA TABELA tb_cv_processo
                        string vSQL = "INSERT INTO tb_cv_processo_audiencia (id_processo, id_processo_audiencia, dt_audiencia, hr_audiencia, tp_audiencia, obs_audiencia, resultado_audiencia, realizada_audiencia) " +
                                      "VALUES( " + vid_proc + "," +
                                                   iNovoRegistro.ToString() + ", '" +
                                                   String.Format("{0:yyyy-MM-dd}", frm_audiencia.aud_data.Value) + "', '" +
                                                   frm_audiencia.aud_hora.Text + "', '" +
                                                   frm_audiencia.aud_tipo.SelectedIndex.ToString() + "', '" +
                                                   frm_audiencia.aud_obs.Text + "', '" +
                                                   frm_audiencia.aud_resultado.Text + "', '" +
                                                   frm_audiencia.aud_realizado.SelectedIndex.ToString() + "');";
                        int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                        if (iInsertResult > 0)
                        {
                            TreeNode Node_Audi = new TreeNode();
                            Node_Audi.Name = "AUDI_" + vid_proc + "_" + iNovoRegistro.ToString();
                            Node_Audi.Tag = iNovoRegistro;
                            DateTime dt_aud = frm_audiencia.aud_data.Value;
                            Node_Audi.Text = "Audiência: " + frm_audiencia.aud_data.Value.ToShortDateString();
                            Node_Audi.ImageIndex = 3;
                            if (frm_audiencia.aud_realizado.SelectedIndex == 0) Node_Audi.ImageIndex = 2;
                            Node_Audi.SelectedImageIndex = Node_Audi.ImageIndex;
                            if (TreeView.SelectedNode.Parent == null) TreeView.SelectedNode.Nodes.Add(Node_Audi);
                            else TreeView.SelectedNode.Parent.Nodes.Add(Node_Audi);
                        }
                        else MessageBox.Show("Ocorreu um erro ao Inserir este processo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
*/
                }
                #endregion _RETORNA_DOCUMENTO
                //-------------------------------------
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------
        // CARREGAR PANEL DOCMENTO JOVEM
        //---------------------------------------------------------
        private void CarregarPanelDocumentoJovem(string id_aud)
        {
            try
            {
                //-------------------------------------
                //NÚMERO DO PROCESSO
                string vid_proc = "-1";
                if (TreeView.SelectedNode.Parent == null) vid_proc = TreeView.SelectedNode.Tag.ToString();
                else vid_proc = TreeView.SelectedNode.Parent.Tag.ToString();
                //-------------------------------------
                //CARREGA O FORM AUDIENCIA
                try
                {
                    DataSet dtAudiencia = ConexaoSQL.audiencias(vid_proc.ToString(), id_aud);
                    foreach (DataRow pRowAud in dtAudiencia.Tables[0].Rows)
                    {
                        // DATA        
                        aud_data.Text = pRowAud.Field<DateTime>("dt_audiencia").ToShortDateString();
                        // HORA        
                        aud_hora.Text = pRowAud.Field<string>("hr_audiencia");
                        // REALIZADA (SIM 0 - NÃO 1)
                        aud_realizado.Text = "NÃO";
                        if (pRowAud.Field<string>("realizada_audiencia") == "0") aud_realizado.Text = "SIM";
                        // TIPO (Apresentação 0 - Continuação 1 - Leitura 2)
                        aud_tipo.Text = "Apresentação";
                        if (pRowAud.Field<string>("tp_audiencia") == "1") aud_tipo.Text = "Continuação";
                        else if (pRowAud.Field<string>("tp_audiencia") == "2") aud_tipo.Text = "Leitura";
                        // OBS         
                        aud_obs.Text = pRowAud.Field<string>("obs_audiencia");
                        // RESULTADO   
                        aud_resultado.Text = pRowAud.Field<string>("resultado_audiencia");
                    }
                }
                catch { };
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion _JOVEM
        //****************************************************************************************

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

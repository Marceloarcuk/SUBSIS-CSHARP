using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DITI_LIVROM
{
    public partial class cAcoes
    {

        //---------------------------------------------------------
        // CARREGAR LISTVIEW ACOES
        //---------------------------------------------------------
        public static void f_carregar_acoes(TreeView _LsvAcoes)
        {
            try
            {
                _LsvAcoes.Nodes.Clear();

                //CONECTAR BANCO DE DADOS
                DataSet RecordSet = new DataSet();
                RecordSet = Consulta.Consultar("SELECT id_acao, tp_acao, desc_tp_acao, desc_acao, hint_acao, p_serv, p_interno, desc_frase, p_icon, p_ordem, icon_tp_acao " +
                                               "FROM tb_acao WHERE((Not(p_ordem) Is Null)) ORDER BY p_ordem; ");
                //PREENCHER LISTVIEW
                TreeNode rootNode, aNode;
                rootNode = null;
                string vRoot = "";
                string vNode = "";
                int iIcon = 0;
                foreach (DataRow pRow in RecordSet.Tables[0].Rows)
                    if (pRow.Field<string>("desc_tp_acao") != vRoot)
                    {
                        vRoot = pRow.Field<string>("desc_tp_acao");
                        vNode = pRow.Field<string>("desc_acao");
                        rootNode = new TreeNode(vRoot);
                        try
                        {
                            if (pRow.Field<string>("icon_tp_acao") != null)
                                iIcon = pRow.Field<int>("icon_tp_acao");
                            else
                                iIcon = pRow.Field<int>("id_acao");
                        }
                        catch (Exception)
                        {
                            iIcon = pRow.Field<int>("icon_tp_acao");
                        }

                        rootNode.ImageIndex = iIcon;// pRow.Field<int>("id_acao"); 
                        rootNode.SelectedImageIndex = iIcon; // pRow.Field<int>("id_acao");
                        _LsvAcoes.Nodes.Add(rootNode);
                        if (vNode != null)
                        {
                            iIcon = pRow.Field<int>("id_acao");
                            aNode = new TreeNode(pRow.Field<string>("desc_acao"), iIcon, iIcon);
                            aNode.ToolTipText = pRow.Field<string>("hint_acao");
                            rootNode.Nodes.Add(aNode);
                        }
                    }
                    else
                    {
                        iIcon = pRow.Field<int>("id_acao");
                        aNode = new TreeNode(pRow.Field<string>("desc_acao"), iIcon, iIcon);
                        aNode.ToolTipText = pRow.Field<string>("hint_acao");
                        rootNode.Nodes.Add(aNode);
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
        // VERIFICAR ACAO SELECIONADA
        //---------------------------------------------------------
        public static int f_acao_selecionada(TreeView _LsvAcoes)
        {
            int iAcaoSel = -1;
            try
            {
                if (_LsvAcoes.Nodes.Count > 0)
                    foreach (TreeNode AcaoNode in _LsvAcoes.Nodes)
                    {
                        if (AcaoNode.IsSelected)
                        {
                            iAcaoSel = AcaoNode.ImageIndex;
                            break;
                        }

                        foreach (TreeNode oSubNode in AcaoNode.Nodes)
                        {
                            if (oSubNode.IsSelected)
                            {
                                iAcaoSel = oSubNode.ImageIndex;
                                break;
                            }
                        }

                        if (iAcaoSel != -1) break;
                    }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return iAcaoSel;
        }
        //---------------------------------------------------------


    }


    public partial class cServidor
    {

        //---------------------------------------------------------
        // CARREGAR LISTVIEW SERVIDORES
        //---------------------------------------------------------
        public static void f_carregar_servidores(ListView _LsvServidor,int _acao,string _Filtro)
        {
            try
            {
                _LsvServidor.ShowItemToolTips = cHint.Servidores;
                _LsvServidor.Items.Clear();

                string vsql = "SELECT tb_unidade_servidor.esta_modulo, tb_unidade_servidor.id_unidade, tb_unidade_servidor.id_modulo, tb_unidade_servidor.id_unidade_prov, tb_unidade_servidor.id_modulo_prov, corporativo_tb_servidor.id_cpf, corporativo_tb_servidor.nome_serv, corporativo_tb_servidor.matricula_serv, coorporativo_tb_cargo.id_sys, coorporativo_tb_cargo.desc_cargo " +
                               "FROM(coorporativo_tb_cargo INNER JOIN corporativo_tb_servidor ON coorporativo_tb_cargo.id_cargo = corporativo_tb_servidor.id_cargo) INNER JOIN tb_unidade_servidor ON corporativo_tb_servidor.id_cpf = tb_unidade_servidor.ID_CPF ";
                string vsqlWhere = "WHERE (corporativo_tb_servidor.nome_serv Like '%' + '" + _Filtro + "' + '%') AND ";
                if ((_Filtro == null) || (_Filtro == "")) vsqlWhere = "WHERE ";
                if (_acao == 27) // TRANSFERENCIA SAIDA
                    vsqlWhere = vsqlWhere + " ((tb_unidade_servidor.id_unidade = '" + Globais.Unidade + "') AND (tb_unidade_servidor.id_modulo = '" + Globais.Modulo + "'));";
                else //OUTRAS AÇÕES
                    vsqlWhere = vsqlWhere + " (((tb_unidade_servidor.esta_modulo = 's') AND (tb_unidade_servidor.id_unidade = '" + Globais.Unidade + "') AND (tb_unidade_servidor.id_modulo = '" + Globais.Modulo + "')) " +
                               "OR((tb_unidade_servidor.esta_modulo = 's') AND(tb_unidade_servidor.id_unidade_prov = '" + Globais.Unidade + "') AND (tb_unidade_servidor.id_modulo_prov = '" + Globais.Modulo + "')));";

                DataSet vRecordSet = new DataSet();
                vRecordSet = Consulta.Consultar(vsql + vsqlWhere);
                if (vRecordSet.Tables[0].Rows.Count > 0)
                {
                    //PREENCHE LISTVIEW COM OS SERVIDORES
                    ListViewItem item1;
                    foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                    {
                        item1 = new ListViewItem(new[] { pRow.Field<string>("nome_serv"),
                                                     pRow.Field<string>("desc_cargo"),
                                                     pRow.Field<string>("matricula_serv"),pRow.Field<string>("id_cpf") });
                        item1.ImageIndex = 0; //NA UNIDADE
                        if (pRow.Field<int>("id_sys") < 9) item1.ImageIndex = 2; //OUTRA UNIDADE
                        if (pRow.Field<string>("id_unidade") != Globais.Unidade) item1.ImageIndex = 1;
                        _LsvServidor.Items.Add(item1);
                    }
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
        // VERIFICAR SE EXISTE SERVIDOR SELECIONADO NA LISTVIEW 
        //---------------------------------------------------------
        public static string f_servidor_selecionado(ListView _LsvServidor)
        {
            string bServidorSel = "";
            string bServidorSelCod = "";
            try
            {
                if (_LsvServidor.Items.Count > 0)
                {
                    int i;
                    foreach (ListViewItem item in _LsvServidor.Items)
                        if (item.Checked)
                        {
                            bServidorSelCod = bServidorSelCod + item.SubItems[3].Text + ",";
                            bServidorSel = bServidorSel + item.Text + ",";
                        }
                    i = 0;
                    i = bServidorSel.Length;
                    if (i > 1) { bServidorSel = bServidorSel.Substring(0, i - 1); }
                    i = 0;
                    i = bServidorSelCod.Length;
                    if (i > 1) { bServidorSelCod = bServidorSelCod.Substring(0, i - 1); }
                    bServidorSel = bServidorSelCod + "_" + bServidorSel;
                    if (bServidorSel == "_") bServidorSel = "";
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bServidorSel;
        }
        //---------------------------------------------------------


    }
}



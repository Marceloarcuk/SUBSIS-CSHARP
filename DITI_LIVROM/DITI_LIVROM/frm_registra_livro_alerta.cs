using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;





namespace DITI_LIVROM
{
    
    public partial class frm_registra_livro_alerta : Form
    {
        

        public frm_registra_livro_alerta()
        {
            InitializeComponent();
        }

        //------------------------------------------
        //SALVAR OCORRENCIA
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DataSet vRecordSet = new DataSet();
            try
            {
                //-------------------------------------
                //VALIDA SE O FORMULÁRIO ESTA PREENCHIDO
                #region ADD_EDIT_VALIDAENTRADAS

                int iServ = 0;
                int iJov = 0;

                vRecordSet = Consulta.Consultar("SELECT p_serv, p_interno FROM tb_acao WHERE(id_acao = " + eAcao.Text + ");");
                try
                {
                    iServ = vRecordSet.Tables[0].Rows[0].Field<int>("p_serv");
                    iJov = vRecordSet.Tables[0].Rows[0].Field<int>("p_interno");
                } catch { }
                if (eJovens.Items.Count < iJov)
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("É necessario haver um jovem no Alerta.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_add_jovem_Click(sender, e);
                    return;
                }

                DialogResult result = MessageBox.Show("Você deseja confirmar este Alerta?", "Confirmar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.None;
                    return;
                }


                #endregion ADD_EDIT_VALIDAENTRADAS
                //----------------------------------------------------------------
                //ADICIONAR OCORRENCIA - ADD   ou   EDITAR OCORRENCIA - EDIT
                //----------------------------------------------------------------
                //ID_OCORRENCIA
                #region ADD_EDIT_ID_ALERTA
                int iNovoRegistro = 1;
                //-------------------------------------
                //ADICIONAR OCORRENCIA - ADD
                if (e_EDIT_ADD.Text == "ADD")
                {
                    vRecordSet = Consulta.Consultar("SELECT Max(id_alerta) + 1 AS newcod FROM tb_plantao_alerta " +
                                                   "WHERE(id_unidade = '" + Globais.Unidade + "') " +
                                                    " AND(id_modulo = '" + Globais.Modulo + "') " +
                                                    " AND (id_plantao = '" + Globais.Plantao + "');");
                    try { iNovoRegistro = vRecordSet.Tables[0].Rows[0].Field<int>("newcod"); } catch { iNovoRegistro = 1; }
                }
                //-------------------------------------
                //EDITAR OCORRENCIA - EDIT
                else
                {

                }
                #endregion ADD_EDIT_ID_ALERTA

                //-------------------------------------
                //INSERT NA TABELA TB_PLANTAO_OCORRENCIA
                #region ADD_EDIT_TB_PLANTAO_ALERTA
                int iInsertResult = 0;
                string vSQL = "";
                //-------------------------------------
                //ADICIONAR OCORRENCIA - ADD
                if (e_EDIT_ADD.Text == "ADD")
                {
                    vSQL = "INSERT INTO tb_plantao_alerta(id_unidade, id_modulo, id_plantao, id_alerta, id_acao, data_alerta, LOCAL_DT) " +
                           "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                    iNovoRegistro.ToString() + ", " + eAcao.Text + ", " +
                                    "Format('" + eDTAlerta.Text + "', 'yyyy-mm-dd hh:nn:ss'),'" + eLOCAL_DT.Text + "');";
                }
                //-------------------------------------
                //EDITAR OCORRENCIA - EDIT
                else
                {

                }
                iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                #endregion ADD_EDIT_TB_PLANTAO_ALERTA
                
                if (iInsertResult > 0)
                {
                    //-------------------------------------
                    //INSERT NA TABELA TB_PLANTAO_ALERTA_INTERNOS  E  UPDATE NA TABELA TB_UNIDADE_INTERNO
                    #region ADD_EDIT_TB_PLANTAO_ALERTA_INTERNOS
                    try
                    {
                        //-------------------------------------
                        //EDITAR - EDIT
                        if (e_EDIT_ADD.Text == "EDIT")
                        {
                            //DELETA ARQUIVOS
                        }
                        //-------------------------------------
                        //ADD E EDIT
                        string valert_data_interno = "";
                        string valert_dia_interno = "0";
                        foreach (ListViewItem itemRow in eJovens.Items)
                        {
                            valert_dia_interno = "0";
                            valert_data_interno = "";
                            valert_dia_interno = itemRow.SubItems[1].Text;
                            if (valert_dia_interno != "0") valert_data_interno = "Format('" + eDTAlerta.Text + "', 'yyyy-mm-dd hh:nn:ss')";
                            if (valert_data_interno == "") valert_data_interno = "NULL";


                            //INSERT NA TABELA TB_PLANTAO_OCORRENCIA_INTERNOS
                            Consulta.Executar("INSERT INTO tb_plantao_alerta_internos(id_unidade, id_modulo, id_plantao, id_alerta, id_interno, " +
                                                           "alerta_data_interno, alerta_dia_interno, LOCAL_DT) " +
                                              "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " + iNovoRegistro.ToString() + ", '" + itemRow.SubItems[2].Text + "', " +
                                                            valert_data_interno + ", '" + valert_dia_interno + "', '" + eLOCAL_DT.Text + "');", "", null, "", null);
                            //UPDATE NA TABELA TB_UNIDADE_INTERNO
                            Consulta.Executar("UPDATE tb_unidade_interno SET alerta_status_interno = '" + eTipo.Text + "', " +
                                                                            "alerta_data_interno = " + valert_data_interno + ", " +
                                                                            "alerta_dia_interno = '" + valert_dia_interno + "' " +
                                               "WHERE(id_unidade = '" + Globais.Unidade + "') " +
                                               " AND(id_modulo = '" + Globais.Modulo + "') " +
                                               " AND (id_interno = '" + itemRow.SubItems[2].Text + "');", "", null, "", null);
                        }
                    }
                    catch { iInsertResult = 0; }
                    #endregion ADD_EDIT_TB_PLANTAO_ALERTA_INTERNOS
                    //-------------------------------------
                }

                if (iInsertResult == 0)
                {
                    MessageBox.Show("Ocorreu um erro ao Inserir o Alerta.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Consulta.Executar("DELETE FROM tb_plantao_alerta " +
                                      "WHERE (id_unidade = '" + Globais.Unidade          + "') " +
                                       " AND (id_modulo = '"  + Globais.Modulo           + "') " +
                                       " AND (id_plantao = '" + Globais.Plantao          + "') " +
                                       " AND (id_alerta = " + iNovoRegistro.ToString() + ");", "", null, "", null);
                    DialogResult = DialogResult.Cancel;
                }
                
                //-------------------------------------
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel; ;
            }
            Globais.DB_Database.Close();
        }
        //------------------------------------------

        //------------------------------------------
        //CARREGAR FORM
        private void frm_registra_livro_alerta_Load(object sender, EventArgs e)
        {
            DataSet vRecordSet = new DataSet();
            
            try
            {
                eDTMD.Text = eDTAlerta.Text;

                cHint.Exibir(btn_add_jovem, "Adicionar jovem ao Alerta.");
                cHint.Exibir(btn_del_jovem, "Retirar jovem selecionado do Alerta.");
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //------------------------------------------


        //------------------------------------------
        //ALERTA
        #region FORM_Alerta

        private void eJovensMD_dia_ValueChanged(object sender, EventArgs e)
        {
            try { eJovens.SelectedItems[0].SubItems[1].Text = eJovensMD_dia.Value.ToString(); }
            catch (Exception) { }
        }

        private void eDTOcorrencia_ValueChanged(object sender, EventArgs e)
        {
            eDTMD.Text = eDTAlerta.Text;
        }

        private void eJovensMD_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                eJovensMD_dia.Enabled = true;
                int i = 0;
                Int32.TryParse(eJovens.SelectedItems[0].SubItems[1].Text, out i);
                eJovensMD_dia.Value = i;
            }
            catch (Exception) { }
        }

        #endregion FORM_Alerta
        //------------------------------------------

        //------------------------------------------
        //BOTOES DE ADICIONAR E EXCLUIR JOVENS
        #region FORM_ADD_DEL_JOVENS

        //------------------------------------------
        //ADD JOVENS
        private void btn_add_jovem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_sel_jovem_todos frm_sel_jovem_todos = new frm_sel_jovem_todos();
                if (frm_sel_jovem_todos.ShowDialog(this) == DialogResult.OK)
                {
                    Boolean JaExite = false;
                    ListViewItem item1;
                    foreach (ListViewItem itemRow in frm_sel_jovem_todos.eJovens.SelectedItems)
                    {
                        JaExite = false;
                        foreach (ListViewItem itemRow1 in eJovens.Items)
                            if (itemRow.SubItems[0].Text == itemRow1.SubItems[0].Text)
                            {
                                JaExite = true;
                                break;
                            }
                        if (JaExite) continue;

                        item1 = new ListViewItem(new[] { itemRow.SubItems[0].Text, "", itemRow.SubItems[1].Text });
                        item1.ImageIndex = 0;
                        eJovens.Items.Add(item1);
                    }
                }
            }
            catch { }
            eJovens.Columns[0].Text = "Jovens envolvidos: " + eJovens.Items.Count;
        }
        //------------------------------------------
        //DEL JOVENS
        private void btn_del_jovem_Click(object sender, EventArgs e)
        {
            try
            {
                int iDelJovem = -1;
                foreach (ListViewItem itemRow in eJovens.SelectedItems)
                {
                    iDelJovem = itemRow.Index;
                    eJovens.Items.Remove(itemRow);
                    break;
                }
            }
            catch { }
            eJovens.Columns[0].Text = "Jovens envolvidos: " + eJovens.Items.Count;
        }



        #endregion FORM_ADD_DEL_JOVENS
        //------------------------------------------
    }
}

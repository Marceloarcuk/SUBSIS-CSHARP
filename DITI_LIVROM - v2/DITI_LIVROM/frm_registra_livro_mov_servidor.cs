using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITI_LIVROM
{
    public partial class frm_registra_livro_mov_servidor : Form
    {
        public frm_registra_livro_mov_servidor()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Você deseja confirmar este registro no Livro?", "Confirmar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
                DataSet RecordSet = new DataSet();
                Boolean Exite_Serv_Unidade = false;


                if ((eAcao.Text == "28") || (eAcao.Text == "29") || (eAcao.Text == "35"))
                {
                    foreach (ListViewItem itemRow in eServidores.Items)
                    {
                        RecordSet = Consulta.Consultar("SELECT id_cpf FROM tb_unidade_servidor WHERE ((id_unidade = '" + Globais.Unidade + "') " +
                                                                                                " AND (id_modulo = '" + Globais.Modulo + "') " +
                                                                                                " AND (id_cpf = '" + itemRow.SubItems[1].Text + "')) " +
                                                                                              " OR ((id_unidade = '0') " +
                                                                                                " AND (id_unidade_prov = '" + Globais.Unidade + "') " +
                                                                                                " AND (id_modulo_prov = '" + Globais.Modulo + "') " +
                                                                                                " AND (id_cpf = '" + itemRow.SubItems[1].Text + "'));");
                        if (RecordSet.Tables[0].Rows.Count > 0)
                        {
                            Exite_Serv_Unidade = true;
                            break;
                        }
                    }
                    if (Exite_Serv_Unidade)
                    {
                        MessageBox.Show("Servidor já está na unidade.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if (eAcao.Text == "26")
                {
                    foreach (ListViewItem itemRow in eServidores.Items)
                    {
                        RecordSet = Consulta.Consultar("SELECT id_cpf FROM tb_unidade_servidor WHERE ((id_unidade = '" + Globais.Unidade + "') " +
                                                                                                " AND (id_modulo = '" + Globais.Modulo + "') " +
                                                                                                " AND (id_cpf = '" + itemRow.SubItems[1].Text + "'));");
                        if (RecordSet.Tables[0].Rows.Count > 0)
                        {
                            Exite_Serv_Unidade = true;
                            break;
                        }
                    }
                    if (Exite_Serv_Unidade)
                    {
                        MessageBox.Show("Servidor já possui acesso liberado nesta unidade.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }



                //-------------------------------------
                //NOVO ID_REGISTRO
                //-------------------------------------
                RecordSet = Consulta.Consultar("SELECT Max(id_registro) + 1 AS newcod FROM tb_plantao_registro " +
                                               "WHERE(id_unidade = '" + Globais.Unidade + "') " +
                                                " AND(id_modulo = '" + Globais.Modulo + "') " +
                                                " AND (id_plantao = '" + Globais.Plantao + "');");
                int iNovoRegistro = 1;
                try { iNovoRegistro = RecordSet.Tables[0].Rows[0].Field<int>("newcod"); } catch { iNovoRegistro = 1; }
                //-------------------------------------
                //INSERT NA TABELA tb_plantao_registro
                //-------------------------------------
                string vSQL = "INSERT INTO tb_plantao_registro(id_unidade, id_modulo, id_plantao, id_registro, id_acao, txt_registro_livro, txt_retorno, data_registro, LOCAL_DT) " +
                              "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                            iNovoRegistro.ToString() + ", " + eAcao.Text + ", '" + eFrase.Text + "', '" + eRetorno.Text + "', " +
                                            "Format('" + eDTRegistro.Text + "', 'yyyy-mm-dd hh:nn:ss'),'" + eLOCAL_DT.Text + "');";
                int iInsertResult = Consulta.Executar(vSQL);
                if (iInsertResult > 0)
                {
                    //-------------------------------------
                    //INSERT NA TABELA tb_plantao_registro_servidor
                    //-------------------------------------
                    foreach (ListViewItem itemRow in eServidores.Items)
                        Consulta.Executar("INSERT INTO tb_plantao_registro_servidor(id_unidade, id_modulo, id_plantao, id_registro, cpf_servidor, LOCAL_DT) " +
                                          "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                                   iNovoRegistro.ToString() + ", '" + itemRow.SubItems[1].Text + "', '" + eLOCAL_DT.Text + "');");
                    //-------------------------------------
                    //UPDATE NA TABELA tb_unidade_interno
                    //-------------------------------------
                    DataSet RecordSet1 = new DataSet();
                    Exite_Serv_Unidade = false;
                    foreach (ListViewItem itemRow in eServidores.Items)
                    {
                        //-------------------------------------
                        //SAIR DO MÓDULO
                        if ((eAcao.Text == "30") || (eAcao.Text == "31"))
                        {
                            RecordSet1 = Consulta.Consultar("SELECT id_cpf FROM tb_unidade_servidor WHERE (id_unidade = '0') " +
                                                                                                    " AND (id_unidade_prov = '" + Globais.Unidade + "') " +
                                                                                                    " AND (id_modulo_prov = '" + Globais.Modulo + "') " +
                                                                                                    " AND (id_cpf = '" + itemRow.SubItems[1].Text + "');");
                            //outra unidade
                            if (RecordSet1.Tables[0].Rows.Count > 0) Exite_Serv_Unidade = true;
                            if (Exite_Serv_Unidade)
                                Consulta.Executar("DELETE FROM tb_unidade_servidor WHERE (id_unidade = '0') " +
                                                                                   " AND (id_unidade_prov = '" + Globais.Unidade + "') " +
                                                                                   " AND (id_modulo_prov = '" + Globais.Modulo + "') " +
                                                                                   " AND (id_cpf = '" + itemRow.SubItems[1].Text + "');");

                            //unidade ATUAL
                            else
                                Consulta.Executar("UPDATE tb_unidade_servidor SET id_unidade_prov = '', " +
                                                        "id_modulo_prov = '', " +
                                                        "n_dias_prov = '', " +
                                                        "esta_modulo='n', " +
                                                        "LOCAL_DT = '" + eLOCAL_DT.Text + "' " +
                                                  "WHERE (id_unidade = '" + Globais.Unidade + "') " +
                                                   " AND (id_modulo = '" + Globais.Modulo + "') " +
                                                   " AND (id_cpf = '" + itemRow.SubItems[1].Text + "');");
                        }
                        //-------------------------------------
                        //SAIR DO MÓDULO - TRANSFERENCIA
                        else if (eAcao.Text == "27")
                        {
                            Consulta.Executar("DELETE FROM tb_unidade_servidor WHERE (id_unidade = '" + Globais.Unidade + "') " +
                                                                               " AND (id_modulo = '" + Globais.Modulo + "') " +
                                                                               " AND (id_cpf = '" + itemRow.SubItems[1].Text + "');");
                        }
                        //-------------------------------------
                        //ENTRADA NO MÓDULO - TRANSFERENCIA
                        else if (eAcao.Text == "26")
                        {
                            RecordSet1 = Consulta.Consultar("SELECT id_cpf FROM tb_unidade_servidor WHERE ((id_unidade = '" + Globais.Unidade + "') " +
                                                                                                    " AND (id_modulo = '" + Globais.Modulo + "') " +
                                                                                                    " AND (id_cpf = '" + itemRow.SubItems[1].Text + "')) " +
                                                                                                  " OR ((id_unidade = '0') " +
                                                                                                    " AND (id_unidade_prov = '" + Globais.Unidade + "') " +
                                                                                                    " AND (id_modulo_prov = '" + Globais.Modulo + "') " +
                                                                                                    " AND (id_cpf = '" + itemRow.SubItems[1].Text + "'));");
                            if (RecordSet1.Tables[0].Rows.Count > 0) Exite_Serv_Unidade = true;
                            if (Exite_Serv_Unidade)
                                Consulta.Executar("UPDATE tb_unidade_servidor SET id_unidade = '" + Globais.Unidade + "', " +
                                                                                "id_modulo = '" + Globais.Modulo + "', " +
                                                                                "id_unidade_prov = '', " +
                                                                                "id_modulo_prov = '', " +
                                                                                "n_dias_prov = '', " +
                                                                                "esta_modulo='s', " +
                                                                                "LOCAL_DT = '" + eLOCAL_DT.Text + "' " +
                                                  "WHERE ((id_unidade = '" + Globais.Unidade + "') " +
                                                    " AND (id_modulo = '" + Globais.Modulo + "') " +
                                                    " AND (id_cpf = '" + itemRow.SubItems[1].Text + "')) " +
                                                  " OR ((id_unidade = '0') " +
                                                    " AND (id_unidade_prov = '" + Globais.Unidade + "') " +
                                                    " AND (id_modulo_prov = '" + Globais.Modulo + "') " +
                                                    " AND (id_cpf = '" + itemRow.SubItems[1].Text + "'));");
                            else
                                Consulta.Executar("INSERT INTO tb_unidade_servidor(id_unidade, id_modulo, id_cpf, esta_modulo, LOCAL_DT) " +
                                                      "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + itemRow.SubItems[1].Text + "', 's' , '" + eLOCAL_DT.Text + "');");


                        }
                        else
                        {
                            RecordSet1 = Consulta.Consultar("SELECT id_cpf FROM tb_unidade_servidor WHERE ((id_unidade = '" + Globais.Unidade + "') " +
                                                                                                    " AND (id_modulo = '" + Globais.Modulo + "') " +
                                                                                                    " AND (id_cpf = '" + itemRow.SubItems[1].Text + "')) " +
                                                                                                  " OR ((id_unidade = '0') " +
                                                                                                    " AND (id_unidade_prov = '" + Globais.Unidade + "') " +
                                                                                                    " AND (id_modulo_prov = '" + Globais.Modulo + "') " +
                                                                                                    " AND (id_cpf = '" + itemRow.SubItems[1].Text + "'));");

                            if (RecordSet1.Tables[0].Rows.Count > 0) Exite_Serv_Unidade = true;
                            if (Exite_Serv_Unidade)
                                Consulta.Executar("UPDATE tb_unidade_servidor SET id_unidade_prov = '" + Globais.Unidade + "', " +
                                                                                "id_modulo_prov = '" + Globais.Modulo + "', " +
                                                                                "n_dias_prov = '1', " +
                                                                                "dt_entrada_prov = Format('" + eDTRegistro.Text + "', 'yyyy-mm-dd hh:nn:ss'), esta_modulo='s', " +
                                                                                "LOCAL_DT = '" + eLOCAL_DT.Text + "' " +
                                                  "WHERE (id_unidade = '" + Globais.Unidade + "') " +
                                                   " AND (id_modulo = '" + Globais.Modulo + "') " +
                                                   " AND (id_cpf = '" + itemRow.SubItems[1].Text + "');");
                            else
                                Consulta.Executar("INSERT INTO tb_unidade_servidor(id_unidade, id_modulo, id_cpf, id_unidade_prov,id_modulo_prov,n_dias_prov,dt_entrada_prov, esta_modulo, LOCAL_DT) " +
                                                  "VALUES( '0', '" + Globais.Modulo + "', '" + itemRow.SubItems[1].Text + "', '" + Globais.Unidade + "', '" + Globais.Modulo + "', '1', Format('" + eDTRegistro.Text + "', 'yyyy-mm-dd hh:nn:ss'), 's' , '" + eLOCAL_DT.Text + "');");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao Inserir o Registro no Livro.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Consulta.Executar("DELETE FROM tb_plantao_registro " +
                                      "WHERE (id_unidade = '" + Globais.Unidade          + "') " +
                                       " AND (id_modulo = '"  + Globais.Modulo           + "') " +
                                       " AND (id_plantao = '" + Globais.Plantao          + "') " +
                                       " AND (id_registro = " + iNovoRegistro.ToString() + ");");
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
        }
        
    }
}

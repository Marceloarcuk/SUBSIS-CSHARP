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
    public partial class frm_registra_livro_entrada_jovem : Form
    {
        public frm_registra_livro_entrada_jovem()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem itemSel in eJovens.Items)
                {
                    if ((itemSel.SubItems[1].Text == "") || (itemSel.SubItems[2].Text == "") || (itemSel.SubItems[2].Text == "0"))
                    {
                        MessageBox.Show("Preencha o quarto e a ala dos jovens selecionados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.None;
                        return;
                    }
                }

                DialogResult result = MessageBox.Show("Você deseja confirmar este registro no Livro?", "Confirmar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.None;
                    return;
                }

                //-------------------------------------
                //CONECTAR BANCO DE DADOS
                //-------------------------------------
                //NOVO ID_REGISTRO
                DataSet RecordSet = new DataSet();
                RecordSet = Consulta.Consultar("SELECT Max(id_registro) + 1 AS newcod FROM tb_plantao_registro " +
                                               "WHERE(id_unidade = '" + Globais.Unidade + "') " +
                                                " AND(id_modulo = '" + Globais.Modulo + "') " +
                                                " AND (id_plantao = '" + Globais.Plantao + "');");
                int iNovoRegistro = 1;
                try { iNovoRegistro = RecordSet.Tables[0].Rows[0].Field<int>("newcod"); } catch { iNovoRegistro = 1; }
                //-------------------------------------
                //INSERT NA TABELA tb_plantao_registro
                string vSQL = "INSERT INTO tb_plantao_registro(id_unidade, id_modulo, id_plantao, id_registro, id_acao, txt_registro_livro, txt_retorno, data_registro, LOCAL_DT) " +
                              "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                            iNovoRegistro.ToString() + ", " + eAcao.Text + ", '" + eFrase.Text + "', '" + eRetorno.Text + "', " +
                                            "Format('" + eDTRegistro.Text + "', 'yyyy-mm-dd hh:nn:ss'),'" + eLOCAL_DT.Text + "');";
                int iInsertResult = Consulta.Executar(vSQL, "", null, "", null);
                if (iInsertResult > 0)
                {
                    //-------------------------------------
                    //INSERT NA TABELA tb_plantao_registro_servidor
                    foreach (ListViewItem itemRow in eServidores.Items)
                        Consulta.Executar("INSERT INTO tb_plantao_registro_servidor(id_unidade, id_modulo, id_plantao, id_registro, cpf_servidor, LOCAL_DT) " +
                                          "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                                   iNovoRegistro.ToString() + ", '" + itemRow.SubItems[1].Text + "', '" + eLOCAL_DT.Text + "');", "", null, "", null);
                    //-------------------------------------
                    //INSERT NA TABELA tb_plantao_registro_internos
                    foreach (ListViewItem itemRow in eJovens.Items)
                        Consulta.Executar("INSERT INTO tb_plantao_registro_internos(id_unidade, id_modulo, id_plantao, id_registro, id_interno, LOCAL_DT) " +
                                          "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                                    iNovoRegistro.ToString() + ", '" + itemRow.SubItems[1].Text + "', '" + eLOCAL_DT.Text + "');", "", null, "", null);
                    //-------------------------------------
                    //UPDATE NA TABELA tb_unidade_interno
                    foreach (ListViewItem itemRow in eJovens.Items)
                        Consulta.Executar("UPDATE tb_unidade_interno SET status_interno = " + eAcao.Text + ", " +
                                                                        "id_unidade = '" + Globais.Unidade + "', " +
                                                                        "id_modulo = '" + Globais.Modulo + "', " +
                                                                        "n_ala = '" + itemRow.SubItems[1].Text + "', " +
                                                                        "n_quarto = '" + itemRow.SubItems[2].Text + "', " +
                                                                        "LOCAL_DT = '" + eLOCAL_DT.Text + "' " +
                                          "WHERE(id_interno = '" + itemRow.SubItems[3].Text + "');", "", null, "", null);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao Inserir o Registro no Livro.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Consulta.Executar("DELETE FROM tb_plantao_registro " +
                                      "WHERE (id_unidade = '" + Globais.Unidade          + "') " +
                                       " AND (id_modulo = '"  + Globais.Modulo           + "') " +
                                       " AND (id_plantao = '" + Globais.Plantao          + "') " +
                                       " AND (id_registro = " + iNovoRegistro.ToString() + ");", "", null, "", null);
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

        private void eJovens_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                int i = 0;
                Int32.TryParse(eJovens.SelectedItems[0].SubItems[2].Text, out i);
                eAla.Enabled = true;
                eAla.Text = eJovens.SelectedItems[0].SubItems[1].Text;
                eQuarto.Enabled = true;
                eQuarto.Value = i;
            }
            catch (Exception) { }

        }

        private void eQuarto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                eJovens.SelectedItems[0].SubItems[2].Text = eQuarto.Value.ToString();
                eJovens.SelectedItems[0].SubItems[1].Text = eAla.Text;
            }
            catch (Exception) { }
        }


    }
}

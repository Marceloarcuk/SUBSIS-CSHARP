using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;



namespace DITI_LIVROM
{
    partial class frm_sobre_jovem : Form
    {
        public frm_sobre_jovem()
        {
            InitializeComponent();
        }

        private void frm_sobre_jovem_Load(object sender, EventArgs e)
        {
            try
            {
                //----------------------------------------------------------------
                //CARREGAR DADOS DO JOVEM
                //----------------------------------------------------------------
                #region carregar_campos

                
                //PREENCHE DADOS DOS JOVENS
                Text = "Jovem: " + cJovemSelect.Nome;
                nome.Text = cJovemSelect.Nome;
                Foto.Image = cJovemSelect.Foto;
                codigo.Text = cJovemSelect.Codigo;
                ala.Text = cJovemSelect.Ala_Corredor;
                quarto.Text = cJovemSelect.Quarto;
                int idiasMedida = cJovemSelect.MedidaDisciplinarRestante();
                diasMedida.Text = idiasMedida.ToString();

                diasMedida.Visible = false;
                diasMedida_Label.Visible = false;
                LsvOcorrencia.Size = new Size(330, LsvHistorico.Size.Height);
                if (idiasMedida > 0)
                {
                    diasMedida.Visible = true;
                    diasMedida_Label.Visible = true;
                    LsvOcorrencia.Size = new Size(330, 260);
                }


                #endregion carregar_campos
                //----------------------------------------------------------------
                //CARREGAR HISTORICO DO JOVEM
                //----------------------------------------------------------------
                #region carregar_historico
                //PREENCHER LISTVIEW DE HISTORICOS
                //CONECTAR BANCO DE DADOS
                DataSet RecordSet = new DataSet();
                RecordSet = Consulta.Consultar("SELECT tb_acao.desc_acao, tb_plantao_registro.txt_retorno, tb_plantao_registro.data_registro, Format([data_registro],'dd /mm/yyyy') AS data_registro_data, Format([data_registro], 'hh:nn:ss') AS data_registro_hora " +
                                         "FROM tb_acao INNER JOIN (tb_plantao_registro INNER JOIN(tb_interno INNER JOIN tb_plantao_registro_internos ON tb_interno.id_interno = tb_plantao_registro_internos.id_interno)  " +
                                               "ON (tb_plantao_registro.id_registro = tb_plantao_registro_internos.id_registro) AND (tb_plantao_registro.id_modulo = tb_plantao_registro_internos.id_modulo)  " +
                                               "AND (tb_plantao_registro.id_unidade = tb_plantao_registro_internos.id_unidade)) ON tb_acao.id_acao = tb_plantao_registro.id_acao " +
                                         "WHERE((tb_interno.id_interno = '" + codigo.Text + "')  " +
                                         "  AND (tb_plantao_registro.id_plantao = '" + Globais.Plantao + "'))  " +
                                         "ORDER BY tb_plantao_registro.id_plantao DESC, tb_plantao_registro.id_registro DESC;  ");

                //PREENCHER LISTVIEW
                LsvHistorico.Items.Clear();
                ListViewItem item1;
                string vDescricao = "";
                foreach (DataRow pRow in RecordSet.Tables[0].Rows)
                {
                    vDescricao = pRow.Field<string>("desc_acao");
                    if (vDescricao == "Retorno") vDescricao = vDescricao + " - " + pRow.Field<string>("txt_retorno");
                    item1 = new ListViewItem(new[] { pRow.Field<string>("data_registro_hora"),
                                                 vDescricao});
                    LsvHistorico.Items.Add(item1);
                }
                #endregion carregar_historico
                //----------------------------------------------------------------
                //CARREGAR OCORRÊNCIAS DO JOVEM
                //----------------------------------------------------------------
                #region carregar_ocorrencia
                //PREENCHER LISTVIEW DE HISTORICOS
                //CONECTAR BANCO DE DADOS
                RecordSet = Consulta.Consultar("SELECT tb_plantao_ocorrencia.id_acao, tb_acao.desc_acao, tb_oco_disc.desc_ocorrencia AS oco_disc_ocorrencia , tb_oco_fisica.desc_ocorrencia AS oco_fisica_ocorrencia , tb_oco_adm.desc_ocorrencia AS oco_adm_ocorrencia, "+
                                                      "tb_plantao_ocorrencia.tp_id_ocorrencia, tb_plantao_ocorrencia.data_ocorrencia, Format([data_ocorrencia],'dd/mm/yyyy') AS data_registro_data, Format([data_ocorrencia], 'hh:nn:ss') AS data_registro_hora, tb_plantao_ocorrencia.id_ocorrencia,  tb_plantao_ocorrencia.id_plantao " +
                                               "FROM tb_oco_adm RIGHT JOIN(tb_oco_fisica RIGHT JOIN(tb_oco_disc RIGHT JOIN((tb_acao RIGHT JOIN tb_plantao_ocorrencia ON tb_acao.id_acao = tb_plantao_ocorrencia.id_acao) "+
                                                     "INNER JOIN(tb_interno INNER JOIN tb_plantao_ocorrencia_internos ON tb_interno.id_interno = tb_plantao_ocorrencia_internos.id_interno) ON(tb_plantao_ocorrencia.id_ocorrencia = tb_plantao_ocorrencia_internos.id_ocorrencia) AND(tb_plantao_ocorrencia.id_plantao = tb_plantao_ocorrencia_internos.id_plantao) " +
                                                     "AND(tb_plantao_ocorrencia.id_modulo = tb_plantao_ocorrencia_internos.id_modulo) AND(tb_plantao_ocorrencia.id_unidade = tb_plantao_ocorrencia_internos.id_unidade)) ON tb_oco_disc.id_ocorrencia = tb_plantao_ocorrencia.tp_id_ocorrencia) ON tb_oco_fisica.id_ocorrencia = tb_plantao_ocorrencia.tp_id_ocorrencia) ON tb_oco_adm.id_ocorrencia = tb_plantao_ocorrencia.tp_id_ocorrencia " +
                                               "WHERE(tb_interno.id_interno = '" + codigo.Text + "') " +
                                                 //"AND (tb_plantao_ocorrencia.id_plantao = '" + Globais.Plantao + "') " +
                                               "ORDER BY tb_plantao_ocorrencia.id_plantao DESC, tb_plantao_ocorrencia.id_ocorrencia DESC; ");

                //PREENCHER LISTVIEW
                LsvOcorrencia.Items.Clear();
                foreach (DataRow pRow in RecordSet.Tables[0].Rows)
                {
                    vDescricao = "";
                    if (pRow.Field<int>("tp_id_ocorrencia") == 100) vDescricao = pRow.Field<string>("desc_acao").Substring(11, pRow.Field<string>("desc_acao").Length - 11) + " - ";

                    
                    if (pRow.Field<int>("id_acao") == 33) vDescricao = vDescricao + pRow.Field<string>("oco_adm_ocorrencia");
                    else if (pRow.Field<int>("id_acao") == 34) vDescricao = vDescricao + pRow.Field<string>("oco_fisica_ocorrencia");
                    else vDescricao = vDescricao + pRow.Field<string>("oco_disc_ocorrencia");

                    item1 = new ListViewItem(new[] { pRow.Field<string>("data_registro_data"),
                                                     vDescricao,
                                                     pRow.Field<int>("id_acao").ToString(),
                                                     pRow.Field<string>("desc_acao"),
                                                     pRow.Field<int>("id_ocorrencia").ToString(),
                                                     pRow.Field<string>("id_plantao")});
                    LsvOcorrencia.Items.Add(item1);
                }
                #endregion carregar_ocorrencia
                //----------------------------------------------------------------
                LsvOcorrencia.Focus();
                if (LsvOcorrencia.Items.Count > 0) LsvOcorrencia.Items[0].Selected = true;
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
        // REFERENCIA - FOTO DOUBLE CLICK
        //---------------------------------------------------------
        private void LsvOcorrencia_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frm_sobre_jovem_ocorrencia frm_sobre_jovem_ocorrencia = new frm_sobre_jovem_ocorrencia();
                frm_sobre_jovem_ocorrencia.lbIDOcorrencia.Text = LsvOcorrencia.SelectedItems[0].SubItems[4].Text;
                frm_sobre_jovem_ocorrencia.lbQuarto.Text = quarto.Text;
                frm_sobre_jovem_ocorrencia.lbAla.Text = ala.Text;
                frm_sobre_jovem_ocorrencia.lbNomeJovem.Text = nome.Text;
                frm_sobre_jovem_ocorrencia.lbCodJovem.Text = codigo.Text;
                frm_sobre_jovem_ocorrencia.lbOcorrenciaDesc.Text = lbOocrrencia.Text;
                frm_sobre_jovem_ocorrencia.lbPlantao.Text = LsvOcorrencia.SelectedItems[0].SubItems[5].Text;
                frm_sobre_jovem_ocorrencia.ShowDialog();
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LsvHistorico_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(LsvHistorico.SelectedItems[0].Text + " - " +LsvHistorico.SelectedItems[0].SubItems[1].Text);
        }

        private void LsvOcorrencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbOocrrencia.Text = LsvOcorrencia.SelectedItems[0].SubItems[3].Text;
            }
            catch { }
        }
    }

    //---------------------------------------------------------





}

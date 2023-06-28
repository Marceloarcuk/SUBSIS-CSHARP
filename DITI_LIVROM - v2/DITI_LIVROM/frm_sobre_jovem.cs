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

        public int QuantosDiasFaltamParaProximoNatal()
        {
            DateTime dtMedida;
            DateTime dtHoje = DateTime.Today;
            if (DateTime.TryParse(cJovemSelect.MedidaDisciplinar_Data, out dtMedida))
            {
                dtMedida = dtMedida.AddDays(Convert.ToDouble(cJovemSelect.MedidaDisciplinar_Dia));

                MessageBox.Show(dtMedida.ToString("dd/MM/yyyy"));

                return (int)dtMedida.Subtract(dtHoje).TotalDays;
            }
            else
            {
                return 0;
            }
        }//int32
         //int i = 0;
         //string scodigo = f_Jovem_Number_Sel(sender);
         //        Int32.TryParse(scodigo, out i);

        private void frm_sobre_jovem_Load(object sender, EventArgs e)
        {
            try
            {
                //-----------------------------
                //INICIALIZAR JOVENS
                //-----------------------------
                //DECLARAR VARIAVEIS
                //int iCont = 0;
                //MemoryStream stmBLOBData;
                //ImageConverter imgConv;

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

                //PREENCHER LISTVIEW DE HISTORICOS
                //CONECTAR BANCO DE DADOS
                DataSet RecordSet = new DataSet();
                RecordSet = Consulta.Consultar("SELECT tb_acao.desc_acao, tb_plantao_registro.txt_retorno, tb_plantao_registro.data_registro, Format([data_registro],'dd /mm/yyyy') AS data_registro_data, Format([data_registro], 'hh:nn:ss') AS data_registro_hora " +
                                         "FROM tb_acao INNER JOIN (tb_plantao_registro INNER JOIN(tb_interno INNER JOIN tb_plantao_registro_internos ON tb_interno.id_interno = tb_plantao_registro_internos.id_interno)  " +
                                               "ON (tb_plantao_registro.id_registro = tb_plantao_registro_internos.id_registro) AND (tb_plantao_registro.id_modulo = tb_plantao_registro_internos.id_modulo)  " +
                                               "AND (tb_plantao_registro.id_unidade = tb_plantao_registro_internos.id_unidade)) ON tb_acao.id_acao = tb_plantao_registro.id_acao " +
                                         "WHERE((tb_interno.id_interno = '" + codigo.Text + "')  " +
                                         "  AND (Format([data_registro], 'dd/mm/yyyy') = Format(Now(), 'dd/mm/yyyy')))  " +
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
    }

    //---------------------------------------------------------





}

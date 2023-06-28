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
    partial class frm_sobre_jovem_ocorrencia : Form
    {
        public frm_sobre_jovem_ocorrencia()
        {
            InitializeComponent();
        }

        private void frm_sobre_jovem_Load(object sender, EventArgs e)
        {
            Text = "Jovem: " + cJovemSelect.Nome;
            lbNomeJovem.Text = cJovemSelect.Nome;
            Foto.Image = cJovemSelect.Foto;
            lbCodJovem.Text = cJovemSelect.Codigo;
            try
            {
                DataSet vRecordSet = new DataSet();
                string vSQL = "SELECT id_acao, tp_id_ocorrencia, txt_ocorrencia, data_ocorrencia, " +
                                     "Format([data_ocorrencia], 'dd/mm/yyyy') AS data_registro_data, " +
                                     "Format([data_ocorrencia], 'hh:nn:ss') AS data_registro_hora " +
                              "FROM tb_plantao_ocorrencia " +
                              "WHERE(id_plantao = '" + lbPlantao.Text + "') AND (tb_plantao_ocorrencia.id_ocorrencia = " + lbIDOcorrencia.Text + ") " +
                              "ORDER BY id_plantao DESC, id_ocorrencia DESC; ";
                vRecordSet = Consulta.Consultar(vSQL);
                foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                {
                    try { eFrase.Rtf = Globais.ByteArrayToString((Byte[])pRow["txt_ocorrencia"]); } catch { }
                    lbData.Text = pRow.Field<string>("data_registro_data");
                    lbHora.Text = pRow.Field<string>("data_registro_hora");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Globais.DB_Database.Close();
            }
        }
    }
}

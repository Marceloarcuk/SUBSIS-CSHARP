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
        OleDbConnection DB_CONNECT = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LIVROM.mdb");
        OleDbCommand DB_COMMAND = new OleDbCommand();
        OleDbDataAdapter DB_ADAPTER = new OleDbDataAdapter();

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

            Globais.DB_Adapter = new OleDbDataAdapter();
            try
            {
                string queryString = "SELECT id_acao, tp_id_ocorrencia, txt_ocorrencia, data_ocorrencia, " +
                                            "Format([data_ocorrencia], 'dd/mm/yyyy') AS data_registro_data, " +
                                            "Format([data_ocorrencia], 'hh:nn:ss') AS data_registro_hora " +
                                     "FROM tb_plantao_ocorrencia " +
                                     "WHERE(id_plantao = '" + lbPlantao.Text + "') AND (tb_plantao_ocorrencia.id_ocorrencia = " + lbIDOcorrencia.Text + ") " +
                                     "ORDER BY id_plantao DESC, id_ocorrencia DESC; ";
                OleDbCommand vCommand = new OleDbCommand(queryString, Globais.DB_Database);
                Globais.DB_Database.Open();
                OleDbDataReader reader = vCommand.ExecuteReader();
                //READER DO SELECT PARA RTF EM BYTE[] 
                while (reader.Read())
                {
                    var bytes = (byte[])reader.GetValue(2); // campo da tabela 2 - txt_ocorrencia
                    byte[] documento = new byte[0];
                    documento = bytes;
                    string originalRtf = System.Text.Encoding.UTF8.GetString(documento);
                    eFrase.Rtf = originalRtf;
                    lbData.Text = reader.GetString(4) ;
                    lbHora.Text = reader.GetString(5) ;
                }
                reader.Close();
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

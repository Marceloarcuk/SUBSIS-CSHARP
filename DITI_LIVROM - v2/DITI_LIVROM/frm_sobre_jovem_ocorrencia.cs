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
            nome.Text = cJovemSelect.Nome;
            Foto.Image = cJovemSelect.Foto;
            codigo.Text = cJovemSelect.Codigo;

            /*
            DataSet RecordSet = new DataSet();
            //CONECTAR BANCO DE DADOS
            RecordSet = Consulta.Consultar("SELECT tb_unidade_interno.id_unidade, tb_unidade_interno.id_modulo, tb_unidade_interno.id_interno, tb_unidade_interno.n_quarto, " +
                                                        "tb_unidade_interno.n_ala, tb_unidade_interno.status_interno, tb_interno.nome_interno, tb_interno.foto " +
                                                 "FROM tb_interno INNER JOIN tb_unidade_interno ON tb_interno.id_interno = tb_unidade_interno.id_interno " +
                                                 "WHERE((tb_unidade_interno.id_unidade = '" + cUnidade.Unidade + "') AND (tb_unidade_interno.id_modulo = '" + cUnidade.Modulo + "')) " +
                                                 "ORDER BY tb_interno.nome_interno;");
                                                

                        //PREENCHER CABEÇALHO VERDE
                        foreach (DataRow pRow in RecordSet.Tables[0].Rows)
                        {
                            //ARMAZENA OS VALORES DA CONSULTA
                            Text = "Jovem: " + pRow.Field<string>("nome_interno");
                            nome.Text = pRow.Field<string>("nome_interno");
                            stmBLOBData = new MemoryStream((Byte[])(RecordSet.Tables[0].Rows[0]["foto"]));
                            imgConv = new ImageConverter();
                            Foto.Image = (Image)imgConv.ConvertFrom((Byte[])RecordSet.Tables[0].Rows[0]["foto"]);
                        }
            */

        }
    }
}

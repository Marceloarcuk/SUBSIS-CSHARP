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
    partial class frm_sel_jovem_todos : Form
    {
        public frm_sel_jovem_todos()
        {
            InitializeComponent();
        }

        private void buscar_jovens(int _tipo)
        {

            DataSet RecordSet = new DataSet();
            ListViewItem item1;

            eJovens.ShowGroups = true;
            eJovens.View = View.Details;

            string vSQL = "SELECT id_unidade, desc_unidade FROM tb_unidade ORDER BY id_unidade;";
            string vKey = "id_unidade";
            string vDesc = "desc_unidade";
            string vSQL_UNID = "AND (tb_unidade_interno.id_unidade <> '" + Globais.Unidade + "') ";
            if (_tipo == 1)
            {
                vSQL = "SELECT id_modulo, desc_modulo FROM tb_unidade_modulo WHERE (id_unidade = '" + Globais.Unidade + "') ORDER BY id_modulo;";
                vKey = "id_modulo";
                vDesc = "desc_modulo";
                vSQL_UNID = "AND (tb_unidade_interno.id_unidade = '" + Globais.Unidade + "') " +
                            "AND (tb_unidade_interno.id_modulo <> '" + Globais.Modulo + "') ";
            }
            else if (_tipo == 2)
            {
                vSQL = "SELECT id_modulo, desc_modulo FROM tb_unidade_modulo WHERE (id_unidade = '" + Globais.Unidade + "') ORDER BY id_modulo;";
                vKey = "id_modulo";
                vDesc = "desc_modulo";
                vSQL_UNID = "AND (tb_unidade_interno.id_unidade = '" + Globais.Unidade + "') ";
            }
            //ADICIONAR GRUPOS
            eJovens.Groups.Clear();
            RecordSet = Consulta.Consultar(vSQL);
            foreach (DataRow pRow in RecordSet.Tables[0].Rows)
                eJovens.Groups.Add(new ListViewGroup(pRow.Field<string>(vKey), pRow.Field<string>(vDesc)));



            eJovens.Items.Clear();
            try
            {
                RecordSet = Consulta.Consultar("SELECT tb_unidade_interno.id_unidade, tb_unidade_interno.id_modulo, tb_interno.id_interno, tb_interno.nome_interno " +
                                                "FROM tb_interno INNER JOIN tb_unidade_interno ON tb_interno.id_interno = tb_unidade_interno.id_interno " +
                                                "WHERE (tb_interno.nome_interno Like '%' + '" + buscar_servidor.Text + "' + '%') " +
                                                 vSQL_UNID + " ORDER BY tb_unidade_interno.id_unidade, tb_unidade_interno.id_modulo, tb_interno.nome_interno; ");

                eJovens.Columns[0].Text = "Jovens: 0";
                string itxt = "";
                foreach (DataRow pRow in RecordSet.Tables[0].Rows) 
                {
                    itxt = pRow.Field<string>(vKey);
                    item1 = new ListViewItem(new[] { pRow.Field<string>("nome_interno"), pRow.Field<string>("id_interno") }, eJovens.Groups[itxt]);
                    item1.ImageIndex = 0;
                    eJovens.Items.Add(item1);
                }
                eJovens.Columns[0].Text = "Jovens: " + eJovens.Items.Count.ToString();
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frm_sobre_jovem_Load(object sender, EventArgs e)
        {
            if (lbAcao.Text == "20") buscar_jovens(0);
            else if (lbAcao.Text == "18") buscar_jovens(1);
            else buscar_jovens(2);
        }

        private void buscar_servidor_TextChanged(object sender, EventArgs e)
        {
            int asdf = buscar_servidor.Text.Length / 3;
            lbCharA.Text = buscar_servidor.Text.Length.ToString();
            lbChar.Text = asdf.ToString();

            if ((lbCharA.Text == "0") && (lbChar.Text == "0")) lbChar_TextChanged(sender, e);
        }

        private void lbChar_TextChanged(object sender, EventArgs e)
        {
            if (lbAcao.Text == "20") buscar_jovens(0);
            else if (lbAcao.Text == "18") buscar_jovens(1);
            else buscar_jovens(2);
        }
    }
}

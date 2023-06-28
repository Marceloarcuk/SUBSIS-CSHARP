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
    partial class frm_sel_servidor_todos : Form
    {
        public frm_sel_servidor_todos()
        {
            InitializeComponent();
        }

        private void buscar_servidores(object sender, EventArgs e)
        {
            DataSet RecordSet = new DataSet();
            ListViewItem item1;
            eServidores.Items.Clear();
            try
            {

                /*
                                string vSQL = "SELECT corporativo_tb_servidor.id_cpf, corporativo_tb_servidor.nome_serv, coorporativo_tb_cargo.id_sys " +
                                              "FROM coorporativo_tb_lotacao INNER JOIN(coorporativo_tb_cargo INNER JOIN corporativo_tb_servidor ON coorporativo_tb_cargo.id_cargo = corporativo_tb_servidor.id_cargo) ON coorporativo_tb_lotacao.id_lotacao = corporativo_tb_servidor.id_lotacao " +
                                              "WHERE (corporativo_tb_servidor.nome_serv Like '%' + '" + buscar_servidor.Text + "' + '%') " +
                                              "ORDER BY corporativo_tb_servidor.nome_serv; ";
                                if (buscar_unidades.SelectedIndex == 0)
                                    vSQL = "SELECT corporativo_tb_servidor.id_cpf, corporativo_tb_servidor.nome_serv, coorporativo_tb_cargo.id_sys " +
                                           "FROM coorporativo_tb_lotacao INNER JOIN(coorporativo_tb_cargo INNER JOIN corporativo_tb_servidor ON coorporativo_tb_cargo.id_cargo = corporativo_tb_servidor.id_cargo) ON coorporativo_tb_lotacao.id_lotacao = corporativo_tb_servidor.id_lotacao " +
                                           "WHERE (corporativo_tb_servidor.nome_serv Like '%' + '" + buscar_servidor.Text + "' + '%') " +
                                             "AND (coorporativo_tb_lotacao.id_unidade = '" + Globais.Unidade + "')  ORDER BY corporativo_tb_servidor.nome_serv; ";
                                else if (buscar_unidades.SelectedIndex == 2)
                                    vSQL = "SELECT corporativo_tb_servidor.id_cpf, corporativo_tb_servidor.nome_serv, coorporativo_tb_cargo.id_sys  " +
                                           "FROM(coorporativo_tb_lotacao INNER JOIN(coorporativo_tb_cargo INNER JOIN corporativo_tb_servidor ON coorporativo_tb_cargo.id_cargo = corporativo_tb_servidor.id_cargo) ON coorporativo_tb_lotacao.id_lotacao = corporativo_tb_servidor.id_lotacao) INNER JOIN tb_unidade_servidor ON corporativo_tb_servidor.id_cpf = tb_unidade_servidor.ID_CPF " +
                                           "WHERE (corporativo_tb_servidor.nome_serv Like '%' + '" + buscar_servidor.Text + "' + '%') " +
                                             "AND (coorporativo_tb_lotacao.id_unidade = '" + Globais.Unidade + "') " +
                                             "AND (tb_unidade_servidor.id_modulo = '" + Globais.Modulo + "') " +
                                           "ORDER BY corporativo_tb_servidor.nome_serv; ";

                */
                string vSQL = "SELECT corporativo_tb_servidor.id_cpf, corporativo_tb_servidor.nome_serv, coorporativo_tb_cargo.id_sys " +
                              "FROM coorporativo_tb_lotacao INNER JOIN(coorporativo_tb_cargo INNER JOIN corporativo_tb_servidor ON coorporativo_tb_cargo.id_cargo = corporativo_tb_servidor.id_cargo) ON coorporativo_tb_lotacao.id_lotacao = corporativo_tb_servidor.id_lotacao " +
                              "WHERE (corporativo_tb_servidor.nome_serv Like '%" + buscar_servidor.Text + "%') " +
                              "ORDER BY corporativo_tb_servidor.nome_serv; ";
                if (buscar_unidades.SelectedIndex == 0)
                    vSQL = "SELECT corporativo_tb_servidor.id_cpf, corporativo_tb_servidor.nome_serv, coorporativo_tb_cargo.id_sys " +
                           "FROM coorporativo_tb_lotacao INNER JOIN(coorporativo_tb_cargo INNER JOIN corporativo_tb_servidor ON coorporativo_tb_cargo.id_cargo = corporativo_tb_servidor.id_cargo) ON coorporativo_tb_lotacao.id_lotacao = corporativo_tb_servidor.id_lotacao " +
                           "WHERE (corporativo_tb_servidor.nome_serv Like '%" + buscar_servidor.Text + "%') " +
                             "AND (coorporativo_tb_lotacao.id_unidade = '" + Globais.Unidade + "')  ORDER BY corporativo_tb_servidor.nome_serv; ";
                else if (buscar_unidades.SelectedIndex == 2)
                    vSQL = "SELECT corporativo_tb_servidor.id_cpf, corporativo_tb_servidor.nome_serv, coorporativo_tb_cargo.id_sys  " +
                           "FROM(coorporativo_tb_lotacao INNER JOIN(coorporativo_tb_cargo INNER JOIN corporativo_tb_servidor ON coorporativo_tb_cargo.id_cargo = corporativo_tb_servidor.id_cargo) ON coorporativo_tb_lotacao.id_lotacao = corporativo_tb_servidor.id_lotacao) INNER JOIN tb_unidade_servidor ON corporativo_tb_servidor.id_cpf = tb_unidade_servidor.ID_CPF " +
                           "WHERE (corporativo_tb_servidor.nome_serv Like '%" + buscar_servidor.Text + "%') " +
                             "AND (coorporativo_tb_lotacao.id_unidade = '" + Globais.Unidade + "') " +
                             "AND (tb_unidade_servidor.id_modulo = '" + Globais.Modulo + "') " +
                           "ORDER BY corporativo_tb_servidor.nome_serv; ";
                RecordSet = Consulta.Consultar(vSQL);
                eServidores.Columns[0].Text = "Servidores: 0";
                int i = 0;
                foreach (DataRow pRow in RecordSet.Tables[0].Rows)
                {
                    i = pRow.Field<int>("id_sys");
                    item1 = new ListViewItem(new[] { pRow.Field<string>("nome_serv"), pRow.Field<string>("id_cpf") }, eServidores.Groups[i]);
                    item1.ImageIndex = 0;
                    eServidores.Items.Add(item1);
                }
                eServidores.Columns[0].Text = "Servidores: " + eServidores.Items.Count.ToString();
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
            DataSet RecordSet = new DataSet();
            eServidores.ShowGroups = true;
            eServidores.View = View.Details;

            eServidores.Groups.Clear();
            RecordSet = Consulta.Consultar("SELECT desc_cargo FROM coorporativo_tb_cargo ORDER BY id_sys;");
            foreach (DataRow pRow in RecordSet.Tables[0].Rows)
                eServidores.Groups.Add(new ListViewGroup(pRow.Field<string>("desc_cargo")));


            //35 entrada no modulo
            //28 29 apoi e reforso
            //26 transf entraqda
            int i;
            string scodigo = lbAcao.Text;
            Int32.TryParse(scodigo, out i);

            if (i > 2) i = 0;
            buscar_unidades.SelectedIndex = i;
        }

        private void buscar_servidor_TextChanged(object sender, EventArgs e)
        {
            int asdf = buscar_servidor.Text.Length / 3;
            lbCharA.Text = buscar_servidor.Text.Length.ToString();
            lbChar.Text = asdf.ToString();
            if ((lbCharA.Text == "0") && (lbChar.Text == "0")) buscar_servidores(sender, e);
        }

    }
}

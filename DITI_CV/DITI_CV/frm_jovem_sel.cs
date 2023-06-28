using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITI_CV
{
    public partial class frm_jovem_sel : Form
    {
        public frm_jovem_sel()
        {
            InitializeComponent();
        }

        private void frm_jovem_sel_Load(object sender, EventArgs e)
        {
            try
            {
                btn_Pesquisar_Click(sender, e);

            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                //-------------------------------------
                //CARREGA O JOVENS DO NAI
                try
                {
                    DataSet dtJovem = ConexaoSQL.Jovens_nai("", ed_localizar.Text);
                    ListViewJovens.Items.Clear();
                    foreach (DataRow pRowJovem in dtJovem.Tables[0].Rows)
                    {
                        string[] row = { pRowJovem.Field<string>("nome_interno"),
                                         pRowJovem.Field<string>("id_interno"),
                                         pRowJovem.Field<string>("cod_sipia"),
                                         pRowJovem.Field<string>("cpf_interno"),
                                         pRowJovem.Field<string>("ident_interno"),
                                         pRowJovem.Field<string>("id_plantao")};
                        var listViewItem = new ListViewItem(row);
                        listViewItem.Group = ListViewJovens.Groups["gNAI"];
                        ListViewJovens.Items.Add(listViewItem);
                    }
                }
                catch { }
                //-------------------------------------




                /*
                if (DOC_TIPO.Text == "0")
                {
                    //-------------------------------------
                    //CARREGA O JOVENS DO NAI
                    try
                    {
                        DataSet dtJovem = ConexaoSQL.Jovens_nai("", ed_localizar.Text);
                        ListViewJovens.Items.Clear();
                        foreach (DataRow pRowJovem in dtJovem.Tables[0].Rows)
                        {
                            string[] row = { pRowJovem.Field<string>("nome_interno"),
                                         pRowJovem.Field<string>("id_interno"),
                                         pRowJovem.Field<string>("cod_sipia"),
                                         pRowJovem.Field<string>("cpf_interno"),
                                         pRowJovem.Field<string>("ident_interno"),
                                         pRowJovem.Field<string>("id_plantao")};
                            var listViewItem = new ListViewItem(row);
                            listViewItem.Group = ListViewJovens.Groups["gNAI"];
                            ListViewJovens.Items.Add(listViewItem);
                        }
                    }
                    catch { }
                    //-------------------------------------
                    //CARREGA O TODOS JOVENS
                    try
                    {
                        DataSet dtJovem = ConexaoSQL.Jovens("", ed_localizar.Text);
                        foreach (DataRow pRowJovem in dtJovem.Tables[0].Rows)
                        {
                            string[] row = { pRowJovem.Field<string>("nome_jovem"),
                                         pRowJovem.Field<string>("id_jovem"),
                                         pRowJovem.Field<string>("cod_sipia"),
                                         pRowJovem.Field<string>("cpf_jovem"),
                                         pRowJovem.Field<string>("ident_jovem"),""};
                            var listViewItem = new ListViewItem(row);
                            listViewItem.Group = ListViewJovens.Groups["gTOT"];
                            ListViewJovens.Items.Add(listViewItem);
                        }
                    }
                    catch { };
                }
                else
                {
                    //-------------------------------------
                    //CARREGA O JOVENS DO NAI
                    try
                    {
                        DataSet dtJovem = ConexaoSQL.Jovens_nai("", ed_localizar.Text);
                        ListViewJovens.Items.Clear();
                        foreach (DataRow pRowJovem in dtJovem.Tables[0].Rows)
                        {
                            string[] row = { pRowJovem.Field<string>("nome_interno"),
                                         pRowJovem.Field<string>("id_interno"),
                                         pRowJovem.Field<string>("cod_sipia"),
                                         pRowJovem.Field<string>("cpf_interno"),
                                         pRowJovem.Field<string>("ident_interno"),
                                         pRowJovem.Field<string>("id_plantao")};
                            var listViewItem = new ListViewItem(row);
                            listViewItem.Group = ListViewJovens.Groups["gNAI"];
                            ListViewJovens.Items.Add(listViewItem);
                        }
                    }
                    catch { }
                    //-------------------------------------
                    //CARREGA O TODOS JOVENS
                    try
                    {
                        DataSet dtJovem = ConexaoSQL.Jovens("", ed_localizar.Text);
                        foreach (DataRow pRowJovem in dtJovem.Tables[0].Rows)
                        {
                            string[] row = { pRowJovem.Field<string>("nome_jovem"),
                                         pRowJovem.Field<string>("id_jovem"),
                                         pRowJovem.Field<string>("cod_sipia"),
                                         pRowJovem.Field<string>("cpf_jovem"),
                                         pRowJovem.Field<string>("ident_jovem"),""};
                            var listViewItem = new ListViewItem(row);
                            listViewItem.Group = ListViewJovens.Groups["gTOT"];
                            ListViewJovens.Items.Add(listViewItem);
                        }
                    }
                    catch { };

                }
                */
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }
    }
}

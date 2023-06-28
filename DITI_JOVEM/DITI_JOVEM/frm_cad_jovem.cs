using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace DITI_JOVEM
{
    public partial class frm_cad_jovem : Form
    {
        //CLICAR NA COLUNA LISTVIEW
        class ListViewItemComparer : IComparer
        {
            private int col = 0;
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }

        public frm_cad_jovem()
        {
            InitializeComponent();
        }

        private frm_main frm_main = null;
        public frm_cad_jovem(Form callingForm)
        {
            frm_main = callingForm as frm_main;
            InitializeComponent();
        }


        private void frm_cad_jovem_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet vRecordSet = new DataSet();
                // CONFIGURAR APLICAÇÃO ATRAVÉS DO ARQUIVO .INI
                IniFile DITI_JOVEM_IniFile = new IniFile("DITI_JOVEM.ini");
                pnlcontainer.Size = new Size(DITI_JOVEM_IniFile.IniReadInt("LAYOUT", "pnlcontainer", 1), 200);

                //****************************************************************************************
                //*** FUNÇÕES - JOVENS - SERVIDORES - AÇÕES **********************************************
                //****************************************************************************************
                #region FORM_CARREGAR_COMBOS
                //COMBOBOX COR
                try
                {
                    vRecordSet = Consulta.Consultar("SELECT id_cor, desc_cor FROM tb_cor ORDER BY id_cor;");
                    eCor.Items.Clear();
                    foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                        eCor.Items.Add(pRow.Field<string>("desc_cor"));
                    eCor.SelectedIndex = 0;
                }
                catch { }
                try
                {
                    vRecordSet = Consulta.Consultar("SELECT id_sexo, desc_sexo FROM tb_sexo ORDER BY id_sexo;");
                    eSexo.Items.Clear();
                    foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                        eSexo.Items.Add(pRow.Field<string>("desc_sexo"));
                    eSexo.SelectedIndex = 0;
                }
                catch { }
                eDTNascimentoEst.SelectedIndex = 1;
                eUF.SelectedIndex = 6;
                eCidade.Text = "BRASÍLIA";

                #endregion FORM_CARREGAR_COMBOS
                //****************************************************************************************
                CarregarJovens();
                btn_can_Click(sender, e);
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eJovens_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                eJovens.ListViewItemSorter = new ListViewItemComparer(e.Column);
                eJovens.Sort();
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void eJovens_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                eEDIT_ADD.Text = "";
                pnlDadosJovem.Enabled = false;
                DataSet vRecordSet = new DataSet();
                if (eJovens.SelectedItems.Count > 0)
                {
                    vRecordSet = Consulta.Consultar("SELECT * FROM tb_interno WHERE(tb_interno.id_interno = '" + eJovens.SelectedItems[0].SubItems[1].Text + "') " +
                                                    "ORDER BY tb_interno.nome_interno;");
                    if (vRecordSet.Tables[0].Rows.Count > 0)
                    {
                        DataRow pRow = vRecordSet.Tables[0].Rows[0];
                        try { Foto.Image = Globais.ByteArrayToImage((Byte[])pRow["foto"]); } catch { Foto.Image.Dispose(); Foto.Image = null; }
                        eCod.Text = pRow.Field<string>("id_interno");
                        eNome.Text = pRow.Field<string>("nome_interno");
                        eCPF.Text = pRow.Field<string>("cpf_interno");
                        try { eSexo.SelectedIndex = pRow.Field<int>("id_sexo"); } catch { eSexo.SelectedIndex = 0; }
                        eIdentidade.Text = pRow.Field<string>("ident_interno");
                        try { eDTNascimento.Value = pRow.Field<DateTime>("dt_nasc_interno"); } catch { }
                        try { eDTNascimentoEst.SelectedIndex = pRow.Field<int>("dt_nasc_est_interno"); } catch { eDTNascimentoEst.SelectedIndex = 0; }
                        eSIPIA.Text = pRow.Field<string>("cod_sipia");
                        try { eCor.SelectedIndex = pRow.Field<int>("id_cor"); } catch { eCor.SelectedIndex = 0; }
                        eEnd.Text = pRow.Field<string>("end_interno");
                        eBairro.Text = pRow.Field<string>("bairro_interno");
                        eCidade.Text = pRow.Field<string>("cidade_interno");
                        eCEP.Text = pRow.Field<string>("cep_interno");
                        try { eUF.SelectedItem = pRow.Field<string>("uf_interno").ToUpper(); } catch { eUF.SelectedItem = "DF"; }
                        ePaiIdentidade.Text = pRow.Field<string>("ident_pai_interno");
                        ePaiNome.Text = pRow.Field<string>("nome_pai_interno");
                        ePaiCPF.Text = pRow.Field<string>("cpf_pai_interno");
                        eMaeNome.Text = pRow.Field<string>("nome_mae_interno");
                        eMaeIdentidade.Text = pRow.Field<string>("ident_mae_interno");
                        eMaeCPF.Text = pRow.Field<string>("cpf_mae_interno");
                        eRespIdentidade.Text = pRow.Field<string>("ident_resp_interno");
                        eRespNome.Text = pRow.Field<string>("nome_resp_interno");
                        eRespCPF.Text = pRow.Field<string>("cpf_resp_interno");
                        eParentesco.Text = pRow.Field<string>("parentesco_resp_interno");
                        eFone1.Text = pRow.Field<string>("fone1_interno");
                        eFone2.Text = pRow.Field<string>("fone2_interno");
                        eFone3.Text = pRow.Field<string>("fone3_interno");
                        eContato.Text = pRow.Field<string>("contato_interno");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }


        }

        private void bookmark()
        {
            string vNomeBusca = eNome.Text;
            CarregarJovens();
            foreach (ListViewItem itemRow in eJovens.Items)
                if (itemRow.Text == vNomeBusca)
                {
                    itemRow.Selected = true;
                    return;
                }
            eJovens.Items[0].Selected = true;
        }

        private void CarregarJovens()
        {
            ListViewItem item1;
            DataSet vRecordSet = new DataSet();
            vRecordSet = Consulta.Consultar("SELECT tb_interno.id_interno, tb_interno.nome_interno, tb_unidade_interno.id_unidade, tb_unidade.sigla_unidade " +
                                            "FROM tb_unidade RIGHT JOIN(tb_interno LEFT JOIN tb_unidade_interno ON tb_interno.id_interno = tb_unidade_interno.id_interno) ON tb_unidade.id_unidade = tb_unidade_interno.id_unidade " +
                                            "ORDER BY tb_interno.nome_interno;");
            eJovens.Items.Clear();
            foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
            {
                item1 = new ListViewItem(new[] { pRow.Field<string>("nome_interno"), pRow.Field<string>("id_interno"), pRow.Field<string>("id_unidade"), pRow.Field<string>("sigla_unidade") });
                item1.ImageIndex = 0;
                eJovens.Items.Add(item1);
            }
        }

        private void btn_carregar_foto_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                    Foto.Image = Image.FromFile(dlg.FileName); 
                dlg.Dispose();
            }
        }

        private void eCPF_Validated(object sender, EventArgs e)
        {
            bool bValido = false;
            if ((sender as MaskedTextBox).Text.Length == 0) bValido = true;
            else if ((sender as MaskedTextBox).Text.Length == 11) 
            {
                string valor = (sender as MaskedTextBox).Text;
                bValido = Regex.IsMatch(valor, @"^\d{11}$");
            }
            else bValido = false;

            if (!bValido)
            {
                MessageBox.Show("erro");
                (sender as MaskedTextBox).Focus();
            }

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            eEDIT_ADD.Text = "ADD";
            pnlDadosJovem.Enabled = true;

            Foto.Image.Dispose();
            Foto.Image = null;
            eCod.Text = "";
            eNome.Text = "";
            eCPF.Text = "";
            eSexo.SelectedIndex = 0; 
            eIdentidade.Text = "";
            try { eDTNascimento.Value = DateTime.Now; } catch { }
            eDTNascimentoEst.SelectedIndex = 0; 
            eSIPIA.Text = "";
            eCor.SelectedIndex = 0;
            eEnd.Text = "";
            eBairro.Text = "";
            eCidade.Text = "BRASÍLIA";
            eCEP.Text = "";
            eUF.SelectedItem = "DF"; 
            ePaiIdentidade.Text = "";
            ePaiNome.Text = "";
            ePaiCPF.Text = "";
            eMaeNome.Text = "";
            eMaeIdentidade.Text = "";
            eMaeCPF.Text = "";
            eRespIdentidade.Text = "";
            eRespNome.Text = "";
            eRespCPF.Text = "";
            eParentesco.Text = "";
            eFone1.Text = "";
            eFone2.Text = "";
            eFone3.Text = "";
            eContato.Text = "";
            eNome.Focus();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            eEDIT_ADD.Text = "EDIT";
            pnlDadosJovem.Enabled = true;
            eNome.Focus();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            eEDIT_ADD.Text = "";
            pnlDadosJovem.Enabled = false;
            bookmark();
            eJovens.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //NOVO ID_REGISTRO
            DataSet RecordSet = new DataSet();
            try
            {
                string vSQL = "";
                string vData = "Format('" + eDTNascimento.Text + "', 'yyyy-mm-dd')";
                //MYSQL
                if (Globais.MYSQL)
                    vData = "STR_TO_DATE('" + eDTNascimento.Text + "', '%d/%m/%Y')";

                if (eEDIT_ADD.Text == "ADD")
                {
                    string sNovoCod = eCPF.Text;
                    string sMensErr = "";
                    RecordSet = Consulta.Consultar("SELECT id_interno FROM tb_interno WHERE(id_interno = '" + eCPF.Text + "') OR (cpf_interno = '" + eCPF.Text + "');");
                    if (RecordSet.Tables[0].Rows.Count > 0)
                    {
                        sMensErr = "CPF";
                        RecordSet = Consulta.Consultar("SELECT id_interno FROM tb_interno WHERE(id_interno = '" + eSIPIA.Text + "') OR (cpf_interno = '" + eSIPIA.Text + "');");
                        if (RecordSet.Tables[0].Rows.Count == 0) sNovoCod = eSIPIA.Text;
                        else sNovoCod = "";
                    }
                    if (sNovoCod == "")
                    {
                        if (sMensErr != "") sMensErr = "O " + sMensErr + " e o código SIPIA já estão cadastrados.";
                        else sMensErr = "O código SIPIA já está cadastrado.";
                        MessageBox.Show(sMensErr, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    vSQL = "insert into tb_interno (id_interno, " +
                                                   "nome_interno, " +
                                                   "foto, " +
                                                   "cpf_interno, " +
                                                   "id_sexo, " +
                                                   "ident_interno, " +
                                                   "dt_nasc_interno, " +
                                                   "dt_nasc_est_interno, " +
                                                   "cod_sipia, " +
                                                   "id_cor, " +
                                                   "end_interno, " +
                                                   "bairro_interno, " +
                                                   "cidade_interno, " +
                                                   "cep_interno, " +
                                                   "uf_interno, " +
                                                   "ident_pai_interno, " +
                                                   "nome_pai_interno, " +
                                                   "cpf_pai_interno, " +
                                                   "nome_mae_interno, " +
                                                   "ident_mae_interno, " +
                                                   "cpf_mae_interno, " +
                                                   "ident_resp_interno, " +
                                                   "nome_resp_interno, " +
                                                   "cpf_resp_interno, " +
                                                   "parentesco_resp_interno, " +
                                                   "fone1_interno, " +
                                                   "fone2_interno, " +
                                                   "fone3_interno, " +
                                                   "contato_interno) " +
                           "values ('" + sNovoCod + "'," +
                                   "'" + eNome.Text + "'," +
                                   "@texto_binary," +
                                   "'" + eCPF.Text + "'," +
                                         eSexo.SelectedIndex + "," +
                                   "'" + eIdentidade.Text + "'," +
                                         vData + "," +
                                         eDTNascimentoEst.SelectedIndex + "," +
                                   "'" + eSIPIA.Text + "'," +
                                         eCor.SelectedIndex + "," +
                                   "'" + eEnd.Text + "'," +
                                   "'" + eBairro.Text + "'," +
                                   "'" + eCidade.Text + "'," +
                                   "'" + eCEP.Text + "'," +
                                   "'" + eUF.Text + "'," +
                                   "'" + ePaiIdentidade.Text + "'," +
                                   "'" + ePaiNome.Text + "'," +
                                   "'" + ePaiCPF.Text + "'," +
                                   "'" + eMaeNome.Text + "'," +
                                   "'" + eMaeIdentidade.Text + "'," +
                                   "'" + eMaeCPF.Text + "'," +
                                   "'" + eRespIdentidade.Text + "'," +
                                   "'" + eRespNome.Text + "'," +
                                   "'" + eRespCPF.Text + "'," +
                                   "'" + eParentesco.Text + "'," +
                                   "'" + eFone1.Text + "'," +
                                   "'" + eFone2.Text + "'," +
                                   "'" + eFone3.Text + "'," +
                                   "'" + eContato.Text + "' )";
                    eCod.Text = sNovoCod;
                }
                else if (eEDIT_ADD.Text == "EDIT")
                    vSQL = "UPDATE tb_interno SET nome_interno = '" + eNome.Text + "'," +
                                                  "foto = @texto_binary," +
                                                  "cpf_interno = '" + eCPF.Text + "'," +
                                                  "id_sexo = " + eSexo.SelectedIndex + "," +
                                                  "ident_interno = '" + eIdentidade.Text + "'," +
                                                  "dt_nasc_interno = " + vData + "," +
                                                  "dt_nasc_est_interno = " + eDTNascimentoEst.SelectedIndex + "," +
                                                  "cod_sipia = '" + eSIPIA.Text + "'," +
                                                  "id_cor = " + eCor.SelectedIndex + "," +
                                                  "end_interno = '" + eEnd.Text + "'," +
                                                  "bairro_interno = '" + eBairro.Text + "'," +
                                                  "cidade_interno = '" + eCidade.Text + "'," +
                                                  "cep_interno = '" + eCEP.Text + "'," +
                                                  "uf_interno = '" + eUF.Text + "'," +
                                                  "ident_pai_interno = '" + ePaiIdentidade.Text + "'," +
                                                  "nome_pai_interno = '" + ePaiNome.Text + "'," +
                                                  "cpf_pai_interno = '" + ePaiCPF.Text + "'," +
                                                  "nome_mae_interno = '" + eMaeNome.Text + "'," +
                                                  "ident_mae_interno = '" + eMaeIdentidade.Text + "'," +
                                                  "cpf_mae_interno = '" + eMaeCPF.Text + "'," +
                                                  "ident_resp_interno = '" + eRespIdentidade.Text + "'," +
                                                  "nome_resp_interno = '" + eRespNome.Text + "'," +
                                                  "cpf_resp_interno = '" + eRespCPF.Text + "'," +
                                                  "parentesco_resp_interno = '" + eParentesco.Text + "'," +
                                                  "fone1_interno = '" + eFone1.Text + "'," +
                                                  "fone2_interno = '" + eFone2.Text + "'," +
                                                  "fone3_interno = '" + eFone3.Text + "'," +
                                                  "contato_interno = '" + eContato.Text + "' " +
                           "WHERE (id_interno = '" + eCod.Text + "');";
                if (vSQL != "")
                {
                    var pic = Globais.ImageToByteArray(Foto.Image);
                    //MYSQL
                    if (Globais.MYSQL)
                    {
                        try { Globais.DB_DatabaseMySql.Close(); } catch { }
                        MySqlCommand vCommand1 = new MySqlCommand(vSQL, Globais.DB_DatabaseMySql);
                        Globais.DB_DatabaseMySql.Open();
                        vCommand1.Parameters.AddWithValue("@texto_binary", pic);
                        vCommand1.ExecuteNonQuery();
                    }
                    //ACCESS
                    else
                    {
                        OleDbCommand vCommand = new OleDbCommand();
                        Globais.DB_Database.Open();
                        vCommand.Connection = Globais.DB_Database;
                        vCommand.CommandText = vSQL;
                        vCommand.Parameters.AddWithValue("@texto_binary", pic);
                        vCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Registro salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bookmark();
                }
                else MessageBox.Show("Erro ao salvar o Registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o registro atual?", "Confirmação", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                if (Consulta.Executar("DELETE FROM tb_interno WHERE (id_interno = '" + eCod.Text + "');") > 0)
                {
                    MessageBox.Show("Registro excluido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bookmark();
                }
        }

    }
}

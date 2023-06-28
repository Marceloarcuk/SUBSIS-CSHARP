using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;





namespace DITI_LIVROM
{
    
    public partial class frm_registra_livro_ocorrencia : Form
    {
        

        public frm_registra_livro_ocorrencia()
        {
            InitializeComponent();
        }

        //------------------------------------------
        //SALVAR OCORRENCIA
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DataSet vRecordSet = new DataSet();
            try
            {
                //-------------------------------------
                //VALIDA SE O FORMULÁRIO ESTA PREENCHIDO
                #region ADD_EDIT_VALIDAENTRADAS
                if (eTPOcorrencia.SelectedIndex == -1)
                {
                    tcOco.SelectedIndex = 0;
                    DialogResult = DialogResult.None;
                    MessageBox.Show("Selecione o tipo de ocorrência.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eTPOcorrencia.Focus();
                    return;
                }
                string vTPOcorrencia = eTPOcorrencia.SelectedIndex.ToString();
                if (eTPOcorrencia.Text.ToUpper() == "OUTROS") vTPOcorrencia = "100";

                int iServ = 0;
                int iJov = 0;

                vRecordSet = Consulta.Consultar("SELECT p_serv, p_interno FROM tb_acao WHERE(id_acao = " + eAcao.Text + ");");
                try
                {
                    iServ = vRecordSet.Tables[0].Rows[0].Field<int>("p_serv");
                    iJov = vRecordSet.Tables[0].Rows[0].Field<int>("p_interno");
                } catch { }
                if (eJovens.Items.Count < iJov)
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("É necessario haver um jovem na ocorrência.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_add_jovem_Click(sender, e);
                    return;
                }
                if (eServidores.Items.Count < iServ)
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("É necessario haver um servidor na ocorrência.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_add_servidor_Click(sender, e);
                    return;
                }

                DialogResult result = MessageBox.Show("Você deseja confirmar este registro no Livro?", "Confirmar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.None;
                    return;
                }


                #endregion ADD_EDIT_VALIDAENTRADAS
                //----------------------------------------------------------------
                //ADICIONAR OCORRENCIA - ADD   ou   EDITAR OCORRENCIA - EDIT
                //----------------------------------------------------------------
                //ID_OCORRENCIA
                #region ADD_EDIT_ID_OCORRENCIA
                int iNovoRegistro = 1;
                //-------------------------------------
                //ADICIONAR OCORRENCIA - ADD
                if (e_EDIT_ADD.Text == "ADD")
                {
                    vRecordSet = Consulta.Consultar("SELECT Max(id_ocorrencia) + 1 AS newcod FROM tb_plantao_ocorrencia " +
                                                   "WHERE(id_unidade = '" + Globais.Unidade + "') " +
                                                    " AND(id_modulo = '" + Globais.Modulo + "') " +
                                                    " AND (id_plantao = '" + Globais.Plantao + "');");
                    try { iNovoRegistro = vRecordSet.Tables[0].Rows[0].Field<int>("newcod"); } catch { iNovoRegistro = 1; }
                }
                //-------------------------------------
                //EDITAR OCORRENCIA - EDIT
                else
                {

                }
                #endregion ADD_EDIT_ID_OCORRENCIA

                //-------------------------------------
                //INSERT NA TABELA TB_PLANTAO_OCORRENCIA
                #region ADD_EDIT_TB_PLANTAO_OCORRENCIA
                int iInsertResult = 0;
                string vSQL = "";
                //-------------------------------------
                //ADICIONAR OCORRENCIA - ADD
                if (e_EDIT_ADD.Text == "ADD")
                {
                    vSQL = "INSERT INTO tb_plantao_ocorrencia(id_unidade, id_modulo, id_plantao, id_ocorrencia, tp_id_ocorrencia, id_acao, txt_ocorrencia, data_ocorrencia, LOCAL_DT) " +
                           "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                    iNovoRegistro.ToString() + ", " + vTPOcorrencia + ", " + eAcao.Text + ", @texto_binary, " +
                                    "Format('" + eDTOcorrencia.Text + "', 'yyyy-mm-dd hh:nn:ss'),'" + eLOCAL_DT.Text + "');";
                }
                //-------------------------------------
                //EDITAR OCORRENCIA - EDIT
                else
                {

                }
                iInsertResult = Consulta.Executar(vSQL, " @texto_binary", Globais.StringToByteArray(eFrase.Rtf), "", null);
                #endregion ADD_EDIT_TB_PLANTAO_OCORRENCIA

                if (iInsertResult > 0)
                {
                    //-------------------------------------
                    //INSERT NA TABELA TB_PLANTAO_OCORRENCIA_SERVIDOR
                    #region ADD_EDIT_TB_PLANTAO_OCORRENCIA_SERVIDOR
                    try
                    {
                        //-------------------------------------
                        //EDITAR - EDIT
                        if (e_EDIT_ADD.Text == "EDIT")
                        {
                            //DELETA ARQUIVOS
                        }
                        //-------------------------------------
                        //ADD E EDIT
                        foreach (ListViewItem itemRow in eServidores.Items)
                            Consulta.Executar("INSERT INTO tb_plantao_ocorrencia_servidor(id_unidade, id_modulo, id_plantao, id_ocorrencia, cpf_servidor, LOCAL_DT) " +
                                              "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                                       iNovoRegistro.ToString() + ", '" + itemRow.SubItems[1].Text + "', '" + eLOCAL_DT.Text + "');", "", null, "", null);
                    }
                    catch {  }
                    #endregion ADD_EDIT_TB_PLANTAO_OCORRENCIA_SERVIDOR

                    //-------------------------------------
                    //INSERT NA TABELA TB_PLANTAO_OCORRENCIA_INTERNOS  E  UPDATE NA TABELA TB_UNIDADE_INTERNO
                    #region ADD_EDIT_TB_PLANTAO_OCORRENCIA_INTERNOS
                    try
                    {
                        //-------------------------------------
                        //EDITAR - EDIT
                        if (e_EDIT_ADD.Text == "EDIT")
                        {
                            //DELETA ARQUIVOS
                        }
                        //-------------------------------------
                        //ADD E EDIT
                        if (eAcao.Text == "32")
                        {
                            string vmedida_disc_txt_interno = "";
                            string vmedida_disc_data_interno = "";
                            string vmedida_disc_dia_interno = "";
                            foreach (ListViewItem itemRow in eJovensMD.Items)
                            {
                                vmedida_disc_txt_interno = "";
                                vmedida_disc_dia_interno = "";
                                vmedida_disc_data_interno = "";
                                vmedida_disc_txt_interno = itemRow.SubItems[1].Text;
                                vmedida_disc_dia_interno = itemRow.SubItems[2].Text;
                                if (vmedida_disc_dia_interno != "") vmedida_disc_data_interno = "Format('" + eDTOcorrencia.Text + "', 'yyyy-mm-dd hh:nn:ss')";
                                if (vmedida_disc_data_interno == "") vmedida_disc_data_interno = "NULL";
                                

                                //INSERT NA TABELA TB_PLANTAO_OCORRENCIA_INTERNOS
                                Consulta.Executar("INSERT INTO tb_plantao_ocorrencia_internos(id_unidade, id_modulo, id_plantao, id_ocorrencia, id_interno, " +
                                                               "medida_disc_txt_interno, medida_disc_data_interno, medida_disc_dia_interno, LOCAL_DT) " +
                                                  "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " + iNovoRegistro.ToString() + ", '" + itemRow.SubItems[3].Text + "', '" + 
                                                                vmedida_disc_txt_interno + "', " + vmedida_disc_data_interno + ", '" + vmedida_disc_dia_interno + "', '" + eLOCAL_DT.Text + "');", "", null, "", null);
                                //UPDATE NA TABELA TB_UNIDADE_INTERNO
                                Consulta.Executar("UPDATE tb_unidade_interno SET medida_disc_data_interno = " + vmedida_disc_data_interno + ", " +
                                                                                "medida_disc_dia_interno = '" + vmedida_disc_dia_interno + "' " +
                                                   "WHERE(id_unidade = '" + Globais.Unidade + "') " +
                                                   " AND(id_modulo = '" + Globais.Modulo + "') " +
                                                   " AND (id_interno = '" + itemRow.SubItems[3].Text + "');", "", null, "", null);
                            }


                        }
                        else
                        {
                            foreach (ListViewItem itemRow in eJovens.Items)
                                Consulta.Executar("INSERT INTO tb_plantao_ocorrencia_internos(id_unidade, id_modulo, id_plantao, id_ocorrencia, id_interno, LOCAL_DT) " +
                                                  "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                                            iNovoRegistro.ToString() + ", '" + itemRow.SubItems[1].Text + "', '" + eLOCAL_DT.Text + "');", "", null, "", null);
                        }
                    }
                    catch { }
                    #endregion ADD_EDIT_TB_PLANTAO_OCORRENCIA_INTERNOS
                    //-------------------------------------
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao Inserir a Ocorrencia no Livro.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Consulta.Executar("DELETE FROM tb_plantao_ocorrencia " +
                                      "WHERE (id_unidade = '" + Globais.Unidade          + "') " +
                                       " AND (id_modulo = '"  + Globais.Modulo           + "') " +
                                       " AND (id_plantao = '" + Globais.Plantao          + "') " +
                                       " AND (id_ocorrencia = " + iNovoRegistro.ToString() + ");", "", null, "", null);
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
            Globais.DB_Database.Close();
        }
        //------------------------------------------

        //------------------------------------------
        //CARREGAR FORM
        private void frm_registra_livro_ocorrencia_Load(object sender, EventArgs e)
        {
            DataSet vRecordSet = new DataSet();
            
            try
            {
                eTPOcorrencia.Font = eDTOcorrencia.Font;
                eTPOcorrencia.Items.Clear();

                if (eAcao.Text == "32")
                    vRecordSet = Consulta.Consultar("SELECT id_ocorrencia, desc_ocorrencia FROM tb_oco_disc ORDER BY id_ocorrencia;");
                else if (eAcao.Text == "33")
                {
                    tcOco.TabPages.Remove(tabPage3);
                    vRecordSet = Consulta.Consultar("SELECT id_ocorrencia, desc_ocorrencia FROM tb_oco_adm ORDER BY id_ocorrencia;");
                }
                else if (eAcao.Text == "34")
                {
                    tcOco.TabPages.Remove(tabPage3);
                    vRecordSet = Consulta.Consultar("SELECT id_ocorrencia, desc_ocorrencia FROM tb_oco_fisica ORDER BY id_ocorrencia;");
                }

                foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                    eTPOcorrencia.Items.Add(pRow.Field<string>("desc_ocorrencia"));
                eTPOcorrencia.SelectedIndex = -1;

                eDTMD.Text = eDTOcorrencia.Text;

                cHint.Exibir(btn_add_jovem, "Adicionar jovem à ocorrência.");
                cHint.Exibir(btn_del_jovem, "Retirar jovem selecionado da ocorrência.");
                cHint.Exibir(btn_add_servidor, "Adicionar servidor à ocorrência.");
                cHint.Exibir(btn_del_servidor, "Retirar servidor selecionado da ocorrência.");
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //------------------------------------------

        //------------------------------------------
        //TOOLBAR
        #region FORM_toolbar

        //NEGRITO
        private void tbar_negrito_Click(object sender, EventArgs e)
        {
            if ((eFrase.SelectionFont.Style & FontStyle.Bold) == FontStyle.Bold)
                eFrase.SelectionFont = new Font(eFrase.SelectionFont, FontStyle.Regular);
            else
                eFrase.SelectionFont = new Font(eFrase.SelectionFont, FontStyle.Bold);
            eFrase_SelectionChanged(sender, e);
            eFrase.Focus();
        }

        //ITALICO
        private void tbar_italico_Click(object sender, EventArgs e)
        {
            if ((eFrase.SelectionFont.Style & FontStyle.Italic) == FontStyle.Italic)
                eFrase.SelectionFont = new Font(eFrase.SelectionFont, FontStyle.Regular);
            else
                eFrase.SelectionFont = new Font(eFrase.SelectionFont, FontStyle.Italic);
            eFrase_SelectionChanged(sender, e);
            eFrase.Focus();
        }

        //SOBRESCRITO
        private void tbar_sobrescrito_Click(object sender, EventArgs e)
        {
            if ((eFrase.SelectionFont.Style & FontStyle.Underline) == FontStyle.Underline)
                eFrase.SelectionFont = new Font(eFrase.SelectionFont, FontStyle.Regular);
            else
                eFrase.SelectionFont = new Font(eFrase.SelectionFont, FontStyle.Underline);
            eFrase_SelectionChanged(sender, e);
            eFrase.Focus();
        }

        //FONTE
        private void tbar_fonte_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = eFrase.SelectionFont;
            if (fd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                eFrase.SelectionFont = fd.Font;
                eFrase_SelectionChanged(sender, e);
            }
        }

        //COLOR
        private void tbar_color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = eFrase.SelectionColor;
            if (cd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                eFrase.SelectionColor = cd.Color;
            }
        }

        //INSERIR IMAGEM
        private void tbar_picture_Click(object sender, EventArgs e)
        {
            PictureBox fig = new PictureBox();
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                // Show the Open File dialog. If the user clicks OK, load the 
                // picture that the user chose.   
                fig.Load(fd.FileName);
                Clipboard.SetImage(fig.Image);
                fig.Image = null;
                this.eFrase.Paste();
            }

        }

        //CORTAR
        private void tbar_cortar_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            eFrase.Cut();
        }

        //COPIAR
        private void tbar_copiar_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetData(DataFormats.Rtf, eFrase.SelectedRtf);
            
        }

        //COLAR
        private void tbar_colar_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                eFrase.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        //ALINHAMENTO A ESQUERDA
        private void tbar_aling_esquerda_Click(object sender, EventArgs e)
        {
            eFrase.SelectionAlignment = HorizontalAlignment.Left;
            eFrase_SelectionChanged(sender, e);
            eFrase.Focus();
        }

        //ALINHAMENTO CENTRALIZADO
        private void tbar_aling_centro_Click(object sender, EventArgs e)
        {
            eFrase.SelectionAlignment = HorizontalAlignment.Center;
            eFrase_SelectionChanged(sender, e);
            eFrase.Focus();
        }

        //ALINHAMENTO A DIREITA
        private void tbar_aling_direita_Click(object sender, EventArgs e)
        {
            eFrase.SelectionAlignment = HorizontalAlignment.Right;
            eFrase_SelectionChanged(sender, e);
            eFrase.Focus();
        }

        //MARCADORES
        private void tbar_bullet_Click(object sender, EventArgs e)
        {
            eFrase.SelectionBullet = true;
            eFrase.SelectedText = "" + "\n";
            eFrase.SelectionBullet = false;
        }

        //EFRASE CHANGE
        private void eFrase_SelectionChanged(object sender, EventArgs e)
        {
            //FONTE
            if (eFrase.SelectionFont == null)
            {
                tbar_negrito.CheckState = CheckState.Indeterminate;
                tbar_italico.CheckState = CheckState.Indeterminate;
                tbar_sobrescrito.CheckState = CheckState.Indeterminate;
                return;
            }
            tbar_negrito.Checked = (eFrase.SelectionFont.Style & FontStyle.Bold) == FontStyle.Bold;
            tbar_italico.Checked = (eFrase.SelectionFont.Style & FontStyle.Italic) == FontStyle.Italic;
            tbar_sobrescrito.Checked = (eFrase.SelectionFont.Style & FontStyle.Underline) == FontStyle.Underline;
            
            //ALINHAMENTO
            if ((eFrase.SelectionAlignment & HorizontalAlignment.Left) == HorizontalAlignment.Left)
            {
                tbar_aling_centro.Checked = false;
                tbar_aling_esquerda.Checked = true;
                tbar_aling_direita.Checked = false;
            }
            if ((eFrase.SelectionAlignment & HorizontalAlignment.Center) == HorizontalAlignment.Center)
            {
                tbar_aling_centro.Checked = true;
                tbar_aling_esquerda.Checked = false;
                tbar_aling_direita.Checked = false;
            }
            if ((eFrase.SelectionAlignment & HorizontalAlignment.Right) == HorizontalAlignment.Right)
            {
                tbar_aling_centro.Checked = false;
                tbar_aling_esquerda.Checked = false;
                tbar_aling_direita.Checked = true;
            }
        }

        #endregion FORM_toolbar
        //------------------------------------------

        //------------------------------------------
        //MEDIDA DISCIPLINAR
        #region FORM_MedidaDisciplinar
        private void eJovensMD_txt_TextChanged(object sender, EventArgs e)
        {
            try { eJovensMD.SelectedItems[0].SubItems[1].Text = eJovensMD_txt.Text; }
            catch (Exception) { }
        }

        private void eJovensMD_dia_ValueChanged(object sender, EventArgs e)
        {
            try { eJovensMD.SelectedItems[0].SubItems[2].Text = eJovensMD_dia.Value.ToString(); }
            catch (Exception) { }
        }

        private void eDTOcorrencia_ValueChanged(object sender, EventArgs e)
        {
            eDTMD.Text = eDTOcorrencia.Text;
        }

        private void eJovensMD_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                eJovensMD_txt.Enabled = true;
                eJovensMD_txt.Text = eJovensMD.SelectedItems[0].SubItems[1].Text;

                eJovensMD_dia.Enabled = true;
                int i = 0;
                Int32.TryParse(eJovensMD.SelectedItems[0].SubItems[2].Text, out i);
                eJovensMD_dia.Value = i;
            }
            catch (Exception) { }
        }

        #endregion FORM_MedidaDisciplinar
        //------------------------------------------

        //------------------------------------------
        //BOTOES DE ADICIONAR E EXCLUIR JOVENS E SERVIDORES
        #region FORM_ADD_DEL_JOVENS_SERVIDORES

        //------------------------------------------
        //ADD JOVENS
        private void btn_add_jovem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_sel_jovem_todos frm_sel_jovem_todos = new frm_sel_jovem_todos();
                if (frm_sel_jovem_todos.ShowDialog(this) == DialogResult.OK)
                {
                    Boolean JaExite = false;
                    ListViewItem item1, item2;
                    foreach (ListViewItem itemRow in frm_sel_jovem_todos.eJovens.SelectedItems)
                    {
                        JaExite = false;
                        foreach (ListViewItem itemRow1 in eJovens.Items)
                            if (itemRow.SubItems[0].Text == itemRow1.SubItems[0].Text)
                            {
                                JaExite = true;
                                break;
                            }
                        if (JaExite) continue;

                        item1 = new ListViewItem(new[] { itemRow.SubItems[0].Text, itemRow.SubItems[1].Text });
                        item1.ImageIndex = 0;
                        eJovens.Items.Add(item1);

                        item2 = new ListViewItem(new[] { itemRow.SubItems[0].Text, "", "", itemRow.SubItems[1].Text });
                        item2.ImageIndex = 0;
                        eJovensMD.Items.Add(item2);
                    }
                }
            }
            catch { }
            eJovens.Columns[0].Text = "Jovens envolvidos: " + eJovens.Items.Count;
        }
        //------------------------------------------
        //DEL JOVENS
        private void btn_del_jovem_Click(object sender, EventArgs e)
        {
            try
            {
                int iDelJovem = -1;


                foreach (ListViewItem itemRow in eJovens.SelectedItems)
                {
                    iDelJovem = itemRow.Index;
                    eJovens.Items.Remove(itemRow);
                    break;
                }
                foreach (ListViewItem itemRow in eJovensMD.Items)
                {
                    if (iDelJovem == itemRow.Index)
                    {
                        eJovensMD.Items.Remove(itemRow);
                        break;
                    }
                }
            }
            catch { }
            eJovens.Columns[0].Text = "Jovens envolvidos: " + eJovens.Items.Count;
        }
        //------------------------------------------
        //ADD SERVIDOR
        private void btn_add_servidor_Click(object sender, EventArgs e)
        {
            try
            {
                frm_sel_servidor_todos frm_sel_servidor_todos = new frm_sel_servidor_todos();
                if (frm_sel_servidor_todos.ShowDialog(this) == DialogResult.OK)
                {
                    Boolean JaExite = false;
                    ListViewItem item1;
                    foreach (ListViewItem itemRow in frm_sel_servidor_todos.eServidores.SelectedItems)
                    {
                        JaExite = false;
                        foreach (ListViewItem itemRow1 in eServidores.Items)
                            if (itemRow.SubItems[0].Text == itemRow1.SubItems[0].Text)
                            {
                                JaExite = true;
                                break;
                            }
                        if (JaExite) continue;

                        item1 = new ListViewItem(new[] { itemRow.SubItems[0].Text, itemRow.SubItems[1].Text });
                        item1.ImageIndex = 0;
                        eServidores.Items.Add(item1);
                    }
                }
            }
            catch { }
            eServidores.Columns[0].Text = "Servidores envolvidos: " + eServidores.Items.Count;
        }
        //------------------------------------------
        //DEL SERVIDOR
        private void btn_del_servidor_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem itemRow in eServidores.SelectedItems)
                    eServidores.Items.Remove(itemRow);
            }
            catch { }
            eServidores.Columns[0].Text = "Servidores envolvidos: " + eServidores.Items.Count;
        }

        #endregion FORM_ADD_DEL_JOVENS_SERVIDORES
        //------------------------------------------
    }
}

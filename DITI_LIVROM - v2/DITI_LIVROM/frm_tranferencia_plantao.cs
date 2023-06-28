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

namespace DITI_LIVROM
{
    public partial class frm_tranferencia_plantao : Form
    {
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

        public frm_tranferencia_plantao()
        {
            InitializeComponent();
        }

        //------------------------------------------
        //TOOLBAR
        #region FORM_toolbar

        //NEGRITO - ITALICO - SOBRESCRITO
        private void FonteEstilo(object sender, EventArgs e, FontStyle _fonte)
        {
            try
            {
                string vControlNameSub = "";
                if (sender is ToolStripButton) vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6); else return;
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                {
                                    if ((((RichTextBox)_Controles).SelectionFont.Style & _fonte) == _fonte)
                                        ((RichTextBox)_Controles).SelectionFont = new Font(ePatrim.SelectionFont, FontStyle.Regular);
                                    else
                                    {
                                        ((RichTextBox)_Controles).SelectionFont = new Font(ePatrim.SelectionFont, _fonte);
                                    }
                                    ((RichTextBox)_Controles).Focus();
                                    ePatrim_SelectionChanged(sender, e);
                                }
            }
            catch { }
        }
        private void ePatrim_negrito_Click(object sender, EventArgs e)
        {
            FonteEstilo(sender, e,  FontStyle.Bold);
        }       //NEGRITO
        private void ePatrim_italico_Click(object sender, EventArgs e)
        {
            FonteEstilo(sender, e, FontStyle.Italic);
        }       //ITALICO
        private void ePatrim_sobrescrito_Click(object sender, EventArgs e)
        {
            FonteEstilo(sender, e, FontStyle.Underline);
        }   //SOBRESCRITO

        //FONTE
        private void ePatrim_fonte_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            try
            {
                string vControlNameSub = "";
                if (sender is ToolStripButton) vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6); else return;
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                {
                                    fd.Font = ((RichTextBox)_Controles).SelectionFont;
                                    if (fd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                                    {
                                        ((RichTextBox)_Controles).SelectionFont = fd.Font;
                                        ePatrim_SelectionChanged(sender, e);
                                    }
                                    ((RichTextBox)_Controles).Focus();
                                }
            }
            catch { }
        }

        //COLOR
        private void ePatrim_color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            try
            {
                string vControlNameSub = "";
                if (sender is ToolStripButton) vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6); else return;
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                {
                                    cd.Color = ((RichTextBox)_Controles).SelectionColor;
                                    if (cd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                                        ((RichTextBox)_Controles).SelectionColor = cd.Color;
                                    ((RichTextBox)_Controles).Focus();
                                }
            }
            catch { }
        }

        //INSERIR IMAGEM
        private void ePatrim_picture_Click(object sender, EventArgs e)
        {
            PictureBox fig = new PictureBox();
            OpenFileDialog fd = new OpenFileDialog();
            try
            {
                string vControlNameSub = "";
                if (sender is ToolStripButton) vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6); else return;
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                    if (fd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                                    {
                                        fig.Load(fd.FileName);
                                        Clipboard.SetImage(fig.Image);
                                        fig.Image = null;
                                        ((RichTextBox)_Controles).Paste();
                                        ((RichTextBox)_Controles).Focus();
                                    }
            }
            catch { }
        }

        //CORTAR
        private void ePatrim_cortar_Click(object sender, EventArgs e)
        {
            try
            {
                string vControlNameSub = "";
                if (sender is ToolStripButton) vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6); else return;
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                {
                                    Clipboard.Clear();
                                    ((RichTextBox)_Controles).Cut();
                                    ((RichTextBox)_Controles).Focus();
                                }
            }
            catch { }
        }

        //COPIAR     
        private void ePatrim_copiar_Click(object sender, EventArgs e)
        {
            try
            {
                string vControlNameSub = "";
                if (sender is ToolStripButton) vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6); else return;
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                {
                                    Clipboard.Clear();
                                    Clipboard.SetData(DataFormats.Rtf, ((RichTextBox)_Controles).SelectedRtf);
                                    ((RichTextBox)_Controles).Focus();
                                }
            }
            catch { }
        }

        //COLAR
        private void ePatrim_colar_Click(object sender, EventArgs e)
        {
            try
            {
                string vControlNameSub = "";
                if (sender is ToolStripButton) vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6); else return;
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                    if (Clipboard.ContainsText(TextDataFormat.Rtf))
                                    {
                                        ((RichTextBox)_Controles).SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
                                        ((RichTextBox)_Controles).Focus();
                                    }
            }
            catch { }

        }

        //ALINHAMENTO A ESQUERDA - CENTRALIZADO - A DIREITA
        private void Alinhamento(object sender, EventArgs e, HorizontalAlignment _Alinhamento)
        {
            try
            {
                string vControlNameSub = "";
                if (sender is ToolStripButton) vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6); else return;
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                {
                                    ((RichTextBox)_Controles).SelectionAlignment = _Alinhamento;
                                    ((RichTextBox)_Controles).Focus();
                                    ePatrim_SelectionChanged(sender, e);
                                }
            }
            catch { }
        }
        private void ePatrim_aling_esquerda_Click(object sender, EventArgs e)
        {
            Alinhamento(sender, e, HorizontalAlignment.Left);
        }   //ALINHAMENTO A ESQUERDA
        private void ePatrim_aling_centro_Click(object sender, EventArgs e)
        {
            Alinhamento(sender, e, HorizontalAlignment.Center);
        }     //ALINHAMENTO CENTRALIZADO
        private void ePatrim_aling_direita_Click(object sender, EventArgs e)
        {
            Alinhamento(sender, e, HorizontalAlignment.Right);
        }    //ALINHAMENTO A DIREITA

        //MARCADORES
        private void ePatrim_bullet_Click(object sender, EventArgs e)
        {
            try
            {
                string vControlNameSub = "";
                if (sender is ToolStripButton) vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6); else return;
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                    if (Clipboard.ContainsText(TextDataFormat.Rtf))
                                    {
                                        ((RichTextBox)_Controles).SelectionBullet = true;
                                        ((RichTextBox)_Controles).SelectedText = "" + "\n";
                                        ((RichTextBox)_Controles).SelectionBullet = false;
                                        ((RichTextBox)_Controles).Focus();
                                    }
            }
            catch { }
        }
        
        //EFRASE CHANGE
        private void ePatrim_SelectionChanged(object sender, EventArgs e)
        {
            string vRichText = "";
            string vControlNameSub = "";
            if (sender is ToolStripButton)
            {
                vControlNameSub = ((ToolStripButton)sender).Name.Substring(1, 6);
                foreach (Control _Pg in tcPlantao.Controls)                   //pgInstFi ou pgPatrim
                    if (_Pg.Name.Substring(2, 6) == vControlNameSub)
                        foreach (Control _Controles in _Pg.Controls)          //tbar_InstFi ou eInstFi
                            if (_Controles.Name == "e" + vControlNameSub)     //eInstFi
                                if (_Controles is RichTextBox)
                                    vRichText = _Controles.Name;
            }
            else if (sender is RichTextBox) vRichText = ((RichTextBox)sender).Name;
            if (vRichText == "ePatrim")
            {
                //FONTE
                if (ePatrim.SelectionFont == null)
                {
                    ePatrim_negrito.CheckState = CheckState.Indeterminate;
                    ePatrim_italico.CheckState = CheckState.Indeterminate;
                    ePatrim_sobrescrito.CheckState = CheckState.Indeterminate;
                    return;
                }
                ePatrim_negrito.Checked = (ePatrim.SelectionFont.Style & FontStyle.Bold) == FontStyle.Bold;
                ePatrim_italico.Checked = (ePatrim.SelectionFont.Style & FontStyle.Italic) == FontStyle.Italic;
                ePatrim_sobrescrito.Checked = (ePatrim.SelectionFont.Style & FontStyle.Underline) == FontStyle.Underline;

                //ALINHAMENTO
                if ((ePatrim.SelectionAlignment & HorizontalAlignment.Left) == HorizontalAlignment.Left)
                {
                    ePatrim_aling_centro.Checked = false;
                    ePatrim_aling_esquerda.Checked = true;
                    ePatrim_aling_direita.Checked = false;
                }
                if ((ePatrim.SelectionAlignment & HorizontalAlignment.Center) == HorizontalAlignment.Center)
                {
                    ePatrim_aling_centro.Checked = true;
                    ePatrim_aling_esquerda.Checked = false;
                    ePatrim_aling_direita.Checked = false;
                }
                if ((ePatrim.SelectionAlignment & HorizontalAlignment.Right) == HorizontalAlignment.Right)
                {
                    ePatrim_aling_centro.Checked = false;
                    ePatrim_aling_esquerda.Checked = false;
                    ePatrim_aling_direita.Checked = true;
                }
            }
            else if (vRichText == "eInstFi")
            {
                //FONTE
                if (eInstFi.SelectionFont == null)
                {
                    eInstFi_negrito.CheckState = CheckState.Indeterminate;
                    eInstFi_italico.CheckState = CheckState.Indeterminate;
                    eInstFi_sobrescrito.CheckState = CheckState.Indeterminate;
                    return;
                }
                eInstFi_negrito.Checked = (eInstFi.SelectionFont.Style & FontStyle.Bold) == FontStyle.Bold;
                eInstFi_italico.Checked = (eInstFi.SelectionFont.Style & FontStyle.Italic) == FontStyle.Italic;
                eInstFi_sobrescrito.Checked = (eInstFi.SelectionFont.Style & FontStyle.Underline) == FontStyle.Underline;

                //ALINHAMENTO
                if ((eInstFi.SelectionAlignment & HorizontalAlignment.Left) == HorizontalAlignment.Left)
                {
                    eInstFi_aling_centro.Checked = false;
                    eInstFi_aling_esquerda.Checked = true;
                    eInstFi_aling_direita.Checked = false;
                }
                if ((eInstFi.SelectionAlignment & HorizontalAlignment.Center) == HorizontalAlignment.Center)
                {
                    eInstFi_aling_centro.Checked = true;
                    eInstFi_aling_esquerda.Checked = false;
                    eInstFi_aling_direita.Checked = false;
                }
                if ((eInstFi.SelectionAlignment & HorizontalAlignment.Right) == HorizontalAlignment.Right)
                {
                    eInstFi_aling_centro.Checked = false;
                    eInstFi_aling_esquerda.Checked = false;
                    eInstFi_aling_direita.Checked = true;
                }
            }

        }

        #endregion FORM_toolbar
        //------------------------------------------

        //********************************************************************************************************


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                foreach (ListViewItem itemSel in eJovens.Items)
                {
                    if ((itemSel.SubItems[1].Text == "") || (itemSel.SubItems[2].Text == "") || (itemSel.SubItems[2].Text == "0"))
                    {
                        MessageBox.Show("Preencha o quarto e a ala dos jovens selecionados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.None;
                        return;
                    }
                }

                DialogResult result = MessageBox.Show("Você deseja confirmar este registro no Livro?", "Confirmar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.None;
                    return;
                }

                //-------------------------------------
                //CONECTAR BANCO DE DADOS
                //-------------------------------------
                //NOVO ID_REGISTRO
                DataSet RecordSet = new DataSet();
                RecordSet = Consulta.Consultar("SELECT Max(id_registro) + 1 AS newcod FROM tb_plantao_registro " +
                                               "WHERE(id_unidade = '" + Globais.Unidade + "') " +
                                                " AND(id_modulo = '" + Globais.Modulo + "') " +
                                                " AND (id_plantao = '" + Globais.Plantao + "');");
                int iNovoRegistro = 1;
                try { iNovoRegistro = RecordSet.Tables[0].Rows[0].Field<int>("newcod"); } catch { iNovoRegistro = 1; }
                //-------------------------------------
                //INSERT NA TABELA tb_plantao_registro
                string vSQL = "INSERT INTO tb_plantao_registro(id_unidade, id_modulo, id_plantao, id_registro, id_acao, txt_registro_livro, txt_retorno, data_registro, LOCAL_DT) " +
                              "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                            iNovoRegistro.ToString() + ", " + eAcao.Text + ", '" + eFrase.Text + "', '" + eRetorno.Text + "', " +
                                            "Format('" + eDTRegistro.Text + "', 'yyyy-mm-dd hh:nn:ss'),'" + eLOCAL_DT.Text + "');";
                int iInsertResult = Consulta.Executar(vSQL);
                if (iInsertResult > 0)
                {
                    //-------------------------------------
                    //INSERT NA TABELA tb_plantao_registro_servidor
                    foreach (ListViewItem itemRow in eServidores.Items)
                        Consulta.Executar("INSERT INTO tb_plantao_registro_servidor(id_unidade, id_modulo, id_plantao, id_registro, cpf_servidor, LOCAL_DT) " +
                                          "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                                   iNovoRegistro.ToString() + ", '" + itemRow.SubItems[1].Text + "', '" + eLOCAL_DT.Text + "');");
                    //-------------------------------------
                    //INSERT NA TABELA tb_plantao_registro_internos
                    foreach (ListViewItem itemRow in eJovens.Items)
                        Consulta.Executar("INSERT INTO tb_plantao_registro_internos(id_unidade, id_modulo, id_plantao, id_registro, id_interno, LOCAL_DT) " +
                                          "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + Globais.Plantao + "', " +
                                                    iNovoRegistro.ToString() + ", '" + itemRow.SubItems[1].Text + "', '" + eLOCAL_DT.Text + "');");
                    //-------------------------------------
                    //UPDATE NA TABELA tb_unidade_interno
                    foreach (ListViewItem itemRow in eJovens.Items)
                        Consulta.Executar("UPDATE tb_unidade_interno SET status_interno = " + eAcao.Text + ", " +
                                                                        "id_unidade = '" + Globais.Unidade + "', " +
                                                                        "id_modulo = '" + Globais.Modulo + "', " +
                                                                        "n_ala = '" + itemRow.SubItems[1].Text + "', " +
                                                                        "n_quarto = '" + itemRow.SubItems[2].Text + "' " +
                                          "WHERE(id_interno = '" + itemRow.SubItems[3].Text + "');");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao Inserir o Registro no Livro.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Consulta.Executar("DELETE FROM tb_plantao_registro " +
                                      "WHERE (id_unidade = '" + Globais.Unidade          + "') " +
                                       " AND (id_modulo = '"  + Globais.Modulo           + "') " +
                                       " AND (id_plantao = '" + Globais.Plantao          + "') " +
                                       " AND (id_registro = " + iNovoRegistro.ToString() + ");");
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
        */
        }

        private void eJovens_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            eJovens.ListViewItemSorter = new ListViewItemComparer(e.Column);
            eJovens.Sort();
        }

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
                    ListViewItem item1;
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

                        item1 = new ListViewItem(new[] { itemRow.SubItems[0].Text,"","","Entrando no Módulo", itemRow.SubItems[1].Text });
                        item1.ImageIndex = 0;
                        eJovens.Items.Add(item1);
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
                foreach (ListViewItem itemRow in eJovens.SelectedItems)
                    eJovens.Items.Remove(itemRow);
            }
            catch { }
        }

        private void eJovens_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btn_hab_jovem.Enabled = false;
                foreach (ListViewItem itemRow in eJovens.SelectedItems)
                    if (itemRow.ImageIndex == 2) btn_hab_jovem.Enabled = true;
            }
            catch { }
        }

        private void btn_hab_jovem_Click(object sender, EventArgs e)
        {
            btn_hab_jovem.Enabled = false;
            foreach (ListViewItem itemRow in eJovens.SelectedItems)
                itemRow.ImageIndex = 0;
        }

        private void btn_add_servidor_Click(object sender, EventArgs e)
        {

        }
    }
}

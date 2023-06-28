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
using System.Data.OleDb;
using System.Data.SqlClient;

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

        //------------------------------------------
        //TOOLBAR

        //------------------------------------------

        //********************************************************************************************************


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //----------------------------------------------------------------
            //VALIDAR ANTES DA TRANFERENCIA DE PLANTAO
            //----------------------------------------------------------------
            #region VALIDACAO_PARA_ATUALIZAR_TB_PLANTAO

            // VERIFICA SERVIDOR ENTREGANDO PLANTÃO
            if (ePlantaoFimResponsavelCod.Text == "")
            {
                MessageBox.Show("Selecione o servidor que está entregando o Plantão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
                btn_add_serv_pass_Click(sender, e);
                return;
            }
            // VERIFICA SERVIDOR RECEBENDO PLANTÃO
            if ((ePlantaoIniResponsavelCod.Text == "") || (eServidores.Items.Count == 0))
            {
                MessageBox.Show("Selecione o servidor que está entregando o Plantão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
                btn_add_serv_receb_Click(sender, e);
                return;
            }
            // COMPARA O NUMERO DE JOVENS COM A LISTA
            if ((eNJovens.Text != eNJovensEfetivo.Text) || (eNJovens.Value < 1))
            {
                MessageBox.Show("Informe o número correto de Jovens alocados no módulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
                eNJovens.Focus();
                return;
            }
            // VERIFICA SE OS JOVENS ESTÃO NAS ALAS E QUARTOS
            foreach (ListViewItem itemRow in eJovens.Items)
                if ((itemRow.SubItems[1].Text == "") || (itemRow.SubItems[2].Text == "") || (itemRow.SubItems[2].Text == "0"))
                {
                    if (itemRow.ImageIndex != 2)
                    {
                        MessageBox.Show("Informe a Ala e o Quarto dos jovens alocados no módulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.None;
                        tcPlantao.SelectedIndex = 3;
                        eJovens.Focus();
                        itemRow.Selected = true;
                        return;
                    }
                }





            DialogResult result = MessageBox.Show("Plantão encerrado: " + ePlantaoFim.Text + "\n" +
                                                  "Plantão Iniciando: " + ePlantaoIni.Text + "\n\n" +
                                                  "Você deseja confirmar a mudança de Plantão?", "Confirmar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                DialogResult = DialogResult.None;
                return;
            }


            #endregion VALIDACAO_PARA_ATUALIZAR_TB_PLANTAO
            //----------------------------------------------------------------
            //ADICIONAR TB_PLANTAO - ADD   ou   EDITAR TB_PLANTAO - EDIT
            //----------------------------------------------------------------
            int iInsertResult = 0;
            DataSet vRecordSet = new DataSet();
            string vSQL = "";
            try
            {
                //----------------------------------------------------------------
                //INSERT NA TABELA TB_PLANTAO
                #region ADD_EDIT_TB_PLANTAO
                //-------------------------------------
                //ADICIONAR PLANTAO - ADD
                if (e_EDIT_ADD.Text == "ADD")
                    iInsertResult = Consulta.Executar("INSERT INTO tb_plantao(id_unidade, id_modulo, id_plantao, data_plantao_ini,LOCAL_DT) " +
                                                      "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + ePlantaoIni.Text + "', " +
                                                      "Format('" + eDTPlantaoIni.Text + "', 'yyyy-mm-dd hh:nn:ss'), '" + eLOCAL_DT.Text + "'); ", "", null, "", null);
                //-------------------------------------
                //EDITAR PLANTAO - EDIT
                else { }
                //-------------------------------------
                //ATUALIZAR FINALIZAÇÃO DO PLANTAO
                if (iInsertResult > 0)
                {
                    iInsertResult = Consulta.Executar("UPDATE tb_plantao SET txt_inst_fisic =  @texto_binary, " +
                                                                            "txt_patrimo = @texto_binary1, " +
                                                                            "cpf_servidor_passagem = '" + ePlantaoFimResponsavelCod.Text + "', " +
                                                                            "cpf_servidor_recebime = '" + ePlantaoIniResponsavelCod.Text + "', " +
                                                                            "data_plantao_fim = Format('" + eDTPlantaoIni.Text + "', 'yyyy-mm-dd hh:nn:ss'), " +
                                                                            "LOCAL_DT = '" + eLOCAL_DT.Text + "' " +
                                                      "WHERE (id_unidade = '" + Globais.Unidade + "') " +
                                                      " AND  (id_modulo = '" + Globais.Modulo + "') " +
                                                      " AND  (id_plantao = '" + Globais.Plantao + "');", " @texto_binary", Globais.StringToByteArray(eInstFi.Rtf), " @texto_binary1", Globais.StringToByteArray(ePatrim.Rtf));
                }
                //-------------------------------------
                //ADICIONAR EQUIPE E JOVEMS NA TABELA DE TRANSFERENCIA
                if (iInsertResult > 0)
                {
                    foreach (ListViewItem itemRow in eJovens.Items)
                        if (itemRow.ImageIndex != 2)
                            Consulta.Executar("INSERT INTO tb_plantao_transf_internos(id_unidade, id_modulo, id_plantao, id_interno, LOCAL_DT) " +
                                              "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + ePlantaoIni.Text + "', '" +
                                              itemRow.SubItems[4].Text + "', '" + eLOCAL_DT.Text + "'); ", "", null, "", null);
                    foreach (ListViewItem itemRow in eServidores.Items)
                        Consulta.Executar("INSERT INTO tb_plantao_transf_servidor(id_unidade, id_modulo, id_plantao, cpf_servidor, LOCAL_DT) " +
                                          "VALUES( '" + Globais.Unidade + "', '" + Globais.Modulo + "', '" + ePlantaoIni.Text + "', '" +
                                          itemRow.SubItems[1].Text + "', '" + eLOCAL_DT.Text + "'); ", "", null, "", null);
                }
                #endregion ADD_EDIT_TB_PLANTAO
                //----------------------------------------------------------------
                //UPDATE TABELA DE INTERNOS E SERVIDORES
                if (iInsertResult > 0)
                {
                    //-------------------------------------
                    //UPDATE TB_UNIDADE_INTERNO
                    #region ATUALIZAR_TB_UNIDADE_INTERNO


                    //-------------------------------------
                    //UPDATE NA TABELA tb_unidade_interno
                    vRecordSet = Consulta.Consultar("SELECT id_interno, status_interno, medida_disc_data_interno, medida_disc_dia_interno FROM tb_unidade_interno " +
                                                    "WHERE ((id_unidade = '" + Globais.Unidade + "') AND (id_modulo = '" + Globais.Modulo + "')) ");
                    int iMDrestante = 0;
                    int iStatus = 0;
                    Boolean bEncontrou = false;
                    //-------------------------------------
                    //VALIDAR INTERNO QUE ESTÃO SAINDO E FICANDO
                    foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                    {
                        vSQL = "";
                        bEncontrou = false;
                        //verifica na ListView e compara com DB
                        foreach (ListViewItem itemRow in eJovens.Items)
                        {
                            vSQL = ", n_ala = '', n_quarto = '' ";
                            if (itemRow.SubItems[4].Text == pRow.Field<string>("id_interno"))
                            {
                                itemRow.SubItems[3].Text = "";
                                if (itemRow.ImageIndex != 2)
                                {
                                    vSQL = ", n_ala = '" + itemRow.SubItems[1].Text + "', n_quarto = '" + itemRow.SubItems[2].Text + "' ";
                                    bEncontrou = true;
                                    break;
                                }
                            }
                        }
                        cJovens.f_dados_jovem(pRow.Field<string>("id_interno"));
                        iMDrestante = 0;
                        iMDrestante = cJovemSelect.MedidaDisciplinarRestante();
                        iStatus = pRow.Field<int>("status_interno");
                        if (iMDrestante < 1)
                            vSQL = vSQL + ", medida_disc_data_interno = NULL, medida_disc_dia_interno = '' ";
                        //-------------------------------------
                        //UPDATE - INTERNO QUE ESTÃO FICANDO
                        if (bEncontrou)
                            vSQL = "UPDATE tb_unidade_interno SET status_interno = 0, " +
                                                "id_unidade = '" + Globais.Unidade + "', " +
                                                "id_modulo = '" + Globais.Modulo + "', LOCAL_DT = '" + eLOCAL_DT.Text + "' " + vSQL +
                                    "WHERE(id_interno = '" + pRow.Field<string>("id_interno") + "');";
                        //-------------------------------------
                        //UPDATE - INTERNO QUE ESTÃO SAINDO
                        else
                            vSQL = "UPDATE tb_unidade_interno SET id_modulo = '0', LOCAL_DT = '" + eLOCAL_DT.Text + "' " + vSQL +
                                    "WHERE(id_interno = '" + pRow.Field<string>("id_interno") + "');";
                        //vSQL = "DELETE tb_unidade_interno WHERE(id_interno = '" + pRow.Field<string>("id_interno") + "');";

                        Consulta.Executar(vSQL, "", null, "", null);
                    }
                    //-------------------------------------
                    //UPDATE - INTERNO QUE ESTÃO ENTRANDO
                    foreach (ListViewItem itemRow in eJovens.Items)
                        if (itemRow.SubItems[3].Text != "")
                        {
                            vSQL = "";
                            cJovens.f_dados_jovem(itemRow.SubItems[4].Text);
                            iMDrestante = 0;
                            iMDrestante = cJovemSelect.MedidaDisciplinarRestante();
                            if (iMDrestante < 1)
                                vSQL = "medida_disc_data_interno = NULL, medida_disc_dia_interno = '', ";
                            vSQL = "UPDATE tb_unidade_interno SET id_unidade = '" + Globais.Unidade + "', " +
                                                                 "id_modulo = '" + Globais.Modulo + "', " +
                                                                 "n_ala = '" + itemRow.SubItems[1].Text + "', " +
                                                                 "n_quarto = '" + itemRow.SubItems[2].Text + "', " +
                                                                 "status_interno = 0, " +
                                                                 vSQL +
                                                                 "LOCAL_DT = '" + eLOCAL_DT.Text + "' " +
                                                                 "WHERE(id_interno = '" + itemRow.SubItems[4].Text + "');";
                            Consulta.Executar(vSQL, "", null, "", null);
                        }
                    #endregion ATUALIZAR_TB_UNIDADE_INTERNO
                    //---------------------------------------------------------
                }
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
            
        //------------------------------------------
        //FUNÇÕES DE ATUALIZAÇÃO DOS SERVIDORES
        #region FORM_SERVIDORES
        //
        //ADD EQUIPE
        //
        private void btn_add_servidor_Click(object sender, EventArgs e)
        {
            try
            {
                frm_sel_servidor_todos frm_sel_servidor_todos = new frm_sel_servidor_todos();
                frm_sel_servidor_todos.lbAcao.Text = "2";
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
            eServidores.Columns[0].Text = "Servidores: " + eServidores.Items.Count;
        }
        //
        //DEL EQUIPE
        //
        private void btn_del_servidor_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem itemRow in eServidores.SelectedItems)
                {
                    //REMOVE DA RECEBIMENTO DO PLANTAO
                    if (ePlantaoIniResponsavelCod.Text == itemRow.SubItems[1].Text)
                    {
                        ePlantaoIniResponsavelCod.Text = "";
                        ePlantaoIniResponsavel.Text = "";
                    }
                    //REMOVE DA LISTVIEW
                    eServidores.Items.Remove(itemRow);
                }
            }
            catch { }
            eServidores.Columns[0].Text = "Servidores: " + eServidores.Items.Count;
        }
        //
        //ADD SERVIDOR RECEBE PLANTÃO
        //
        private void btn_add_serv_receb_Click(object sender, EventArgs e)
        {
            try
            {
                frm_sel_servidor_todos frm_sel_servidor_todos = new frm_sel_servidor_todos();
                frm_sel_servidor_todos.eServidores.MultiSelect = false;
                frm_sel_servidor_todos.lbAcao.Text = "2";
                if (frm_sel_servidor_todos.ShowDialog(this) == DialogResult.OK)
                {
                    //verifica se servidor ja esta na equipe e deleta
                    foreach (ListViewItem itemRow in frm_sel_servidor_todos.eServidores.SelectedItems)
                        foreach (ListViewItem itemRow1 in eServidores.Items)
                            if (itemRow.SubItems[1].Text == itemRow1.SubItems[1].Text)
                            {
                                eServidores.Items.Remove(itemRow1);
                                break;
                            }
                    //ADD SERVIDOR RECEBIMENTO DE PLANTAO
                    ListViewItem item1;
                    foreach (ListViewItem itemRow in frm_sel_servidor_todos.eServidores.SelectedItems)
                    {
                        //ADD SERVIDOR RECEBIMENTO DE PLANTAO
                        ePlantaoIniResponsavel.Text = itemRow.SubItems[0].Text;
                        ePlantaoIniResponsavelCod.Text = itemRow.SubItems[1].Text;
                        //ADD SERVIDOR NA LISTVIEW
                        item1 = new ListViewItem(new[] { itemRow.SubItems[0].Text, itemRow.SubItems[1].Text });
                        item1.ImageIndex = 0;
                        eServidores.Items.Add(item1);
                        break;
                    }
                }
            }
            catch { }

        }
        //
        //ADD SERVIDOR PASSAR PLANTÃO
        //
        private void btn_add_serv_pass_Click(object sender, EventArgs e)
        {
            try
            {
                frm_sel_servidor_todos frm_sel_servidor_todos = new frm_sel_servidor_todos();
                frm_sel_servidor_todos.eServidores.MultiSelect = false;
                frm_sel_servidor_todos.lbAcao.Text = "2";
                if (frm_sel_servidor_todos.ShowDialog(this) == DialogResult.OK)
                {
                    foreach (ListViewItem itemRow in frm_sel_servidor_todos.eServidores.SelectedItems)
                    {
                        ePlantaoFimResponsavel.Text = itemRow.SubItems[0].Text;
                        ePlantaoFimResponsavelCod.Text = itemRow.SubItems[1].Text;
                        break;
                    }
                }
            }
            catch { }
        }

        #endregion FORM_SERVIDORES
        //------------------------------------------

        //------------------------------------------
        //FUNÇÕES DE ATUALIZAÇÃO DOS JOVENS
        #region FORM_JOVENS

        //
        //ADD JOVENS
        //
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

                        item1 = new ListViewItem(new[] { itemRow.SubItems[0].Text, "", "", "Entrando no Módulo", itemRow.SubItems[1].Text });
                        item1.ImageIndex = 0;
                        eJovens.Items.Add(item1);
                    }
                    int iCountJov = 0;
                    foreach (ListViewItem itemRow in eJovens.Items)
                        if (itemRow.ImageIndex != 2) iCountJov++;
                    eNJovensEfetivo.Text = iCountJov.ToString();
                }
            }
            catch { }
        }
        //
        //DEL JOVENS
        //
        private void btn_del_jovem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem itemRow in eJovens.SelectedItems)
                    eJovens.Items.Remove(itemRow);
                int iCountJov = 0;
                foreach (ListViewItem itemRow in eJovens.Items)
                    if (itemRow.ImageIndex != 2) iCountJov++;
                eNJovensEfetivo.Text = iCountJov.ToString();
            }
            catch { }
        }
        //
        //HABILITA JOVENS
        //
        private void btn_hab_jovem_Click(object sender, EventArgs e)
        {
            btn_hab_jovem.Visible = false;
            foreach (ListViewItem itemRow in eJovens.SelectedItems)
                itemRow.ImageIndex = 0;
            int iCountJov = 0;
            foreach (ListViewItem itemRow in eJovens.Items)
                if (itemRow.ImageIndex != 2) iCountJov++;
            eNJovensEfetivo.Text = iCountJov.ToString();
        }
        //
        //ATIVAR BOTÃO HABILITAR JOVENS    -     ATIVAR ALTERÇÃO DE QUARTOS E ALAS
        //
        private void eJovens_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                //ATIVAR BOTÃO HABILITAR JOVENS
                btn_hab_jovem.Visible = false;
                foreach (ListViewItem itemRow in eJovens.SelectedItems)
                    if (itemRow.ImageIndex == 2) btn_hab_jovem.Visible = true;

                //ATIVAR ALTERÇÃO DE QUARTOS E ALAS
                int i = 0;
                Int32.TryParse(eJovens.SelectedItems[0].SubItems[2].Text, out i);
                eAla.Enabled = true;
                eAla.Text = eJovens.SelectedItems[0].SubItems[1].Text;
                eQuarto.Enabled = true;
                eQuarto.Value = i;
            }
            catch (Exception) { }
        }
        //
        //SALVAR ALTERÇÃO DE QUARTOS E ALAS
        //
        private void eQuarto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                eJovens.SelectedItems[0].SubItems[2].Text = eQuarto.Value.ToString();
                eJovens.SelectedItems[0].SubItems[1].Text = eAla.Text;
            }
            catch (Exception) { }

        }
        //
        //ORDENAR LISTVIEW JOVENS
        //
        private void eJovens_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            eJovens.ListViewItemSorter = new ListViewItemComparer(e.Column);
            eJovens.Sort();
        }
        //
        //LISTVIEW JOVENS SET FOCUS
        //
        private void tcPlantao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eJovens.Items.Count > 0)
                eJovens.Items[0].Selected = true;
        }
        //
        //JOVENS ATUALIZA TEXTOS DE QUANTITATIVOS
        //
        private void eNJovensEfetivo_TextChanged(object sender, EventArgs e)
        {
            eNJovensEfetivoDentro.Text = "Jovens no módulo: " + eNJovensEfetivo.Text;
            int i = 0;
            Int32.TryParse(eNJovensEfetivo.Text, out i);
            i = eJovens.Items.Count - i;
            eNJovensEfetivoDentro.Text = "Jovens no módulo: " + eNJovensEfetivo.Text;
            eNJovensEfetivoFora.Text = "Jovens saindo do módulo: " + i.ToString();
        }


        #endregion FORM_JOVENS




        private void carregar_plantao(string _plantao)
        {
            try
            {
                DataSet vRecordSet = new DataSet();
                string vSQL = "SELECT tb_plantao.id_plantao, tb_plantao.txt_inst_fisic, tb_plantao.txt_patrimo FROM tb_plantao " +
                              "WHERE(tb_plantao.id_unidade = '" + Globais.Unidade + "') AND (tb_plantao.id_modulo = '" + Globais.Modulo + "') AND (tb_plantao.id_plantao = '" + Globais.Plantao + "'); ";
                vRecordSet = Consulta.Consultar(vSQL);
                foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                {
                    try { eInstFi.Rtf = Globais.ByteArrayToString((Byte[])pRow["txt_inst_fisic"]); } catch { }
                    try { ePatrim.Rtf = Globais.ByteArrayToString((Byte[])pRow["txt_patrimo"]); } catch { }   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void frm_tranferencia_plantao_Load(object sender, EventArgs e)
        {
            cHint.Exibir(btn_add_serv_pass, "Selecionar o servidor responsável pela passagem do plantão.");
            cHint.Exibir(btn_add_serv_receb, "Selecionar o servidor responsável pelo recebimento do plantão.");
            cHint.Exibir(btn_add_servidor, "Adicionar servidor à equipe do novo plantão.");
            cHint.Exibir(btn_del_servidor, "Retirar servidor da equipe do novo plantão.");
            cHint.Exibir(btn_add_jovem, "Adicionar jovem à este módulo.");
            cHint.Exibir(btn_del_jovem, "Retirar jovem deste módulo.");

            int iCountJov = 0;
            foreach (ListViewItem itemRow in eJovens.Items)
                if (itemRow.ImageIndex != 2) iCountJov++;
            eNJovensEfetivo.Text = iCountJov.ToString();

            carregar_plantao(Globais.Plantao);
        }


    }
}

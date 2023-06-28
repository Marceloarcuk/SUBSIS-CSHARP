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
    public partial class frm_documento : Form
    {
        public frm_documento()
        {
            InitializeComponent();
        }

        public void btn_jovem_Click(object sender, EventArgs e)
        {
            frm_jovem_sel frm_jovem_sel = new frm_jovem_sel();
            try
            {
                //-------------------------------------
                //ABRE E RETORNA O JOVEM SELECIONADO
                string gGrupo = "";
                string gID = "";
                string gPlantao = "";

                frm_jovem_sel.DOC_TIPO.Text = DOC_TIPO_DOCUMENTO.Text;
                frm_jovem_sel.id_processo.Text = DOC_ID_PROCESSO.Text;

                if (frm_jovem_sel.ShowDialog(this) == DialogResult.OK)
                {
                    gGrupo = frm_jovem_sel.ListViewJovens.SelectedItems[0].Group.Name;
                    gID = frm_jovem_sel.ListViewJovens.SelectedItems[0].SubItems[1].Text;
                    gPlantao = frm_jovem_sel.ListViewJovens.SelectedItems[0].SubItems[5].Text;
                    if (gGrupo == "gNAI")
                    {
                        //---------------------------------------------------------
                        //INSERIR JOVEM
                        #region _JOVEM
                        DataSet dtJovem = ConexaoSQL.Jovens_nai(gID, "");
                        if (dtJovem.Tables[0].Rows.Count > 0)
                        {
                            JOV_COD_NAI.Text = dtJovem.Tables[0].Rows[0].Field<string>("id_interno");
                            JOV_COD.Text = "Sem Código";
                            DataSet dtJovem1 = ConexaoSQL.Jovens(JOV_COD_NAI.Text, "");
                            if (dtJovem1.Tables[0].Rows.Count == 1) JOV_COD.Text = dtJovem.Tables[0].Rows[0].Field<string>("id_interno");
                            JOV_NOME.Text = dtJovem.Tables[0].Rows[0].Field<string>("nome_interno");
                            JOV_CPF.Text = dtJovem.Tables[0].Rows[0].Field<string>("cpf_interno");
                            JOV_SIPIA.Text = dtJovem.Tables[0].Rows[0].Field<string>("cod_sipia");
                            JOV_IDENT.Text = dtJovem.Tables[0].Rows[0].Field<string>("ident_interno");
                            JOV_DTNASC.Text = "";
                            JOV_IDADE.Text = "0";
                            try
                            {
                                JOV_FOTO.Image = null;
                                JOV_FOTO.Image = Globais.ByteArrayToImage((Byte[])dtJovem.Tables[0].Rows[0]["foto"]);
                            }
                            catch { }
                            try
                            {
                                DateTime dt_aud = dtJovem.Tables[0].Rows[0].Field<DateTime>("dt_nasc_interno");
                                JOV_DTNASC.Text = dt_aud.ToShortDateString();
                                JOV_IDADE.Text = Globais.CalcularIdade(dtJovem.Tables[0].Rows[0].Field<DateTime>("dt_nasc_interno")).ToString();
                            }
                            catch { }
                            JOV_PAI.Text = dtJovem.Tables[0].Rows[0].Field<string>("nome_pai_interno");
                            JOV_MAE.Text = dtJovem.Tables[0].Rows[0].Field<string>("nome_mae_interno");
                            JOV_END.Text = dtJovem.Tables[0].Rows[0].Field<string>("end_interno");
                            JOV_BAIRRO.Text = dtJovem.Tables[0].Rows[0].Field<string>("bairro_interno");
                            JOV_CIDADE.Text = dtJovem.Tables[0].Rows[0].Field<string>("cidade_interno");
                            DOC_ID_PLANTAO_NAI.Text = gPlantao;
                        }
                        #endregion _JOVEM
                        //---------------------------------------------------------
                        //INSERIR DOC NAI
                        #region _DOC_NAI
                        DataSet dtDocNAI = ConexaoSQL.Documento_nai(gID, gPlantao);
                        if (dtDocNAI.Tables[0].Rows.Count > 0)
                        {
                            NAI_DESC.Text = dtDocNAI.Tables[0].Rows[0].Field<string>("documento_ent") + " " +
                                            dtDocNAI.Tables[0].Rows[0].Field<string>("n_documento_ent") + " - " +
                                            dtDocNAI.Tables[0].Rows[0].Field<string>("D_ORIGEM");
                            DT_APREENSAO.Text = dtDocNAI.Tables[0].Rows[0].Field<string>("id_plantao");
                            RA_ATO_INFRA.Text = dtDocNAI.Tables[0].Rows[0].Field<string>("desc_ra");
                            ID_RA_ATO_INFRA.Text = dtDocNAI.Tables[0].Rows[0]["id_ra_ato"].ToString();
                            try { MOT_ENT.SelectedIndex = dtDocNAI.Tables[0].Rows[0].Field<int>("id_motivo_entrada"); } catch { MOT_ENT.SelectedIndex = -1; }
                            try { ATO_INF.SelectedIndex = dtDocNAI.Tables[0].Rows[0].Field<int>("id_ato_inf"); } catch { ATO_INF.SelectedIndex = -1; }
                        }

                        #endregion _DOC_NAI
                        //---------------------------------------------------------
                    }
                    else
                    {
                        //---------------------------------------------------------
                        //INSERIR JOVEM
                        #region _JOVEM
                        DataSet dtJovem = ConexaoSQL.Jovens(gID, "");
                        if (dtJovem.Tables[0].Rows.Count > 0)
                        {
                            JOV_COD.Text = dtJovem.Tables[0].Rows[0].Field<string>("id_jovem");
                            JOV_COD_NAI.Text = "-1";
                            JOV_NOME.Text = dtJovem.Tables[0].Rows[0].Field<string>("nome_jovem");
                            JOV_CPF.Text = dtJovem.Tables[0].Rows[0].Field<string>("cpf_jovem");
                            JOV_SIPIA.Text = dtJovem.Tables[0].Rows[0].Field<string>("cod_sipia");
                            JOV_IDENT.Text = dtJovem.Tables[0].Rows[0].Field<string>("ident_jovem");
                            JOV_DTNASC.Text = "";
                            JOV_IDADE.Text = "0";
                            try
                            {
                                JOV_FOTO.Image = null;
                                JOV_FOTO.Image = Globais.ByteArrayToImage((Byte[])dtJovem.Tables[0].Rows[0]["foto"]);
                            }
                            catch { }
                            try
                            {
                                DateTime dt_aud = dtJovem.Tables[0].Rows[0].Field<DateTime>("dt_nasc_jovem");
                                JOV_DTNASC.Text = dt_aud.ToShortDateString();
                                JOV_IDADE.Text = Globais.CalcularIdade(dtJovem.Tables[0].Rows[0].Field<DateTime>("dt_nasc_jovem")).ToString();
                            }
                            catch { }
                            JOV_PAI.Text = dtJovem.Tables[0].Rows[0].Field<string>("nome_pai_jovem");
                            JOV_MAE.Text = dtJovem.Tables[0].Rows[0].Field<string>("nome_mae_jovem");
                            JOV_END.Text = dtJovem.Tables[0].Rows[0].Field<string>("end_jovem");
                            JOV_BAIRRO.Text = dtJovem.Tables[0].Rows[0].Field<string>("bairro_jovem");
                            JOV_CIDADE.Text = dtJovem.Tables[0].Rows[0].Field<string>("cidade_jovem");
                        }

                        #endregion _JOVEM
                        //---------------------------------------------------------
                        //INSERIR DOC NAI
                        #region _DOC_NAI
                        //PLANTAO
                        try
                        {
                            DataSet RecordSet = new DataSet();
                            RecordSet = Consulta.Consultar("SELECT Max(STR_TO_DATE(id_plantao, '%d/%m/%Y')) as plantao FROM tb_nai_interno WHERE id_interno = '" + gID + "';");
                            string sNovoRegistro = RecordSet.Tables[0].Rows[0]["plantao"].ToString();
                            DateTime dt_plantao = DateTime.Parse(sNovoRegistro);
                            gPlantao = String.Format("{0:dd/MM/yyyy}", dt_plantao);
                        }
                        catch { gPlantao = ""; }
                        DataSet dtDocNAI = ConexaoSQL.Documento_nai(gID, gPlantao);
                        if (dtDocNAI.Tables[0].Rows.Count > 0)
                        {
                            NAI_DESC.Text = dtDocNAI.Tables[0].Rows[0].Field<string>("documento_ent") + " " +
                                            dtDocNAI.Tables[0].Rows[0].Field<string>("n_documento_ent") + " - " +
                                            dtDocNAI.Tables[0].Rows[0].Field<string>("D_ORIGEM");
                            DT_APREENSAO.Text = dtDocNAI.Tables[0].Rows[0].Field<string>("id_plantao");
                            RA_ATO_INFRA.Text = dtDocNAI.Tables[0].Rows[0].Field<string>("desc_ra");
                            ID_RA_ATO_INFRA.Text = dtDocNAI.Tables[0].Rows[0].Field<string>("id_ra_ato");
                            try { MOT_ENT.SelectedIndex = dtDocNAI.Tables[0].Rows[0].Field<int>("id_motivo_entrada"); } catch { MOT_ENT.SelectedIndex = -1; }
                            //try { ATO_INF.SelectedIndex = dtDocNAI.Tables[0].Rows[0].Field<int>("id_ato_inf"); } catch { ATO_INF.SelectedIndex = -1; }
                        }
                        #endregion _DOC_NAI
                        //---------------------------------------------------------
                    }
                }

                //-------------------------------------
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            //NOVO ID_REGISTRO
            string sNovoRegistro = "1";
            DataSet RecordSet = new DataSet();
            RecordSet = Consulta.Consultar("SELECT max(CONVERT(SUBSTR(id_jovem,8,13),UNSIGNED INTEGER)) + 1 AS newcod  FROM tb_jovem");
            try { sNovoRegistro = RecordSet.Tables[0].Rows[0]["newcod"].ToString(); } catch { sNovoRegistro = "1"; }
            MessageBox.Show(sNovoRegistro);

    */


        }

        private void MOT_ENT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vMOT_ENT = MOT_ENT.SelectedIndex;
            if ((vMOT_ENT < 1) || (vMOT_ENT > 2)) vMOT_ENT = 0;
            DEC_A.Items.Clear();
            DEC_A.Items.AddRange(ConexaoSQL.Combo_Decisao(vMOT_ENT.ToString(), "", ""));
            DEC_A.SelectedIndex = 0;
            if (DEC_A.Items.Count > 1) DEC_A.Visible = true; else DEC_A.Visible = false;
        }

        private void DEC_A_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vMOT_ENT = MOT_ENT.SelectedIndex;
            if ((vMOT_ENT < 1) || (vMOT_ENT > 2)) vMOT_ENT = 0;
            DEC_B.Items.Clear();
            DEC_B.Items.AddRange(ConexaoSQL.Combo_Decisao(vMOT_ENT.ToString(), ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text).ToString(), ""));
            DEC_B.SelectedIndex = 0;
            if (DEC_B.Items.Count > 1) DEC_B.Visible = true; else DEC_B.Visible = false;

            DESTINO.Items.Clear();
            DESTINO.Items.AddRange(ConexaoSQL.Combo_Unidades(ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text).ToString()));
            DESTINO.SelectedIndex = 0;

            if ((DOC_TIPO_DOCUMENTO.Text == "0") || (DOC_TIPO_DOCUMENTO.Text == "1"))
            {
                int iTipoDescisaoA = ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text);
                DESTINO_SEM.Visible = true;
                DESTINO.Visible = false;
                PRAZO.Visible = false;
                PRAZO.SelectedIndex = -1;
                if ((iTipoDescisaoA == 2) || (iTipoDescisaoA == 3) || (iTipoDescisaoA == 4) || (iTipoDescisaoA == 5) || (iTipoDescisaoA == 6))
                {
                    DESTINO_SEM.Visible = false;
                    DESTINO.Visible = true;
                }
                else if (iTipoDescisaoA == 7)
                {
                    PRAZO.Visible = true;
                }
                PRAZO_LB.Visible = PRAZO.Visible;
            }


        }

        private void DEC_B_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vMOT_ENT = MOT_ENT.SelectedIndex;
            if ((vMOT_ENT < 1) || (vMOT_ENT > 2)) vMOT_ENT = 0;
            DEC_C.Items.Clear();
            DEC_C.Items.AddRange(ConexaoSQL.Combo_Decisao(vMOT_ENT.ToString(), ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text).ToString(), ConexaoSQL.SelItemCombo_Decisao("decisaob", DEC_B.Text).ToString()));
            DEC_C.SelectedIndex = 0;
            if (DEC_C.Items.Count > 1) DEC_C.Visible = true; else DEC_C.Visible = false;
        }

        private void EVENTO1_TextChanged(object sender, EventArgs e)
        {
            EVENTO.Text = EVENTO1.Text;
        }

        private void frm_documento_Load(object sender, EventArgs e)
        {
            EVENTO1.Text = EVENTO.Text;
        }

        private void frm_documento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                if (MessageBox.Show("Você deseja cancelar as alterações deste Documento?", "Confirmar Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    DialogResult = DialogResult.None;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (DOC_DESC.Text.Length == 0)
            {
                MessageBox.Show("Preencha o Documento corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                DOC_DESC.Focus();
                return;
            }

            if ((JOV_COD.Text == "Sem Código") && (JOV_COD_NAI.Text == "-1"))
            {
                MessageBox.Show("Selecione um Adolescente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                btn_jovem.Focus();
                return;
            }

            if ((DEC_A.SelectedIndex < 1) ||
                ((ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text) == 2) && ((DEC_B.SelectedIndex < 1) || (DEC_C.SelectedIndex < 1))) ||
                ((ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text) == 7) && (PRAZO.SelectedIndex < 0))
               )
            {
                MessageBox.Show("É necessário informar a Decisão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                if (DEC_A.SelectedIndex < 1) DEC_A.Focus();
                else if (DEC_B.SelectedIndex < 1) DEC_B.Focus();
                else if (DEC_C.SelectedIndex < 1) DEC_C.Focus();
                return;

            }

            if ((GP_DESTINO.Visible) && (DESTINO.Visible) &&
                (((ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text) > 1) && (ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text) < 7)) &&
                (DESTINO.SelectedIndex < 1)))
            {
                MessageBox.Show("É necessário informar uma Unidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                DESTINO.Focus();
                return;
            }

            if ((GP_ORIGEM.Visible) && (ORIGEM.Visible) &&
                (((ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text) > 1) && (ConexaoSQL.SelItemCombo_Decisao("decisaoa", DEC_A.Text) < 7)) &&
                (ORIGEM.SelectedIndex < 1)))
            {
                MessageBox.Show("É necessário informar uma Unidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                ORIGEM.Focus();
                return;
            }
        }

    }
}

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
using System.Globalization;


namespace DITI_LIVROM
{
    partial class frm_livro_visualizar : Form
    {
        OleDbConnection DB_CONNECT = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LIVROM.mdb");
        OleDbCommand DB_COMMAND = new OleDbCommand();
        OleDbDataAdapter DB_ADAPTER = new OleDbDataAdapter();

        public frm_livro_visualizar()
        {
            InitializeComponent();
        }

        private int VerificaTipodeAcao_retorno(string _busca)
        {
            DataSet vRecordSet = new DataSet();
            string v_texto_mov = "";
            int i_acao = -1;
            try
            {
                vRecordSet = Consulta.Consultar("SELECT id_acao, desc_acao FROM tb_acao WHERE ((tb_acao.id_acao <> 0) AND (tb_acao.desc_acao <> ''));");
                int first = -1;
                int last = -1;
                foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                {
                    i_acao = -1;
                    v_texto_mov = "";
                    i_acao = pRow.Field<int>("id_acao");
                    v_texto_mov = pRow.Field<string>("desc_acao");
                    first = _busca.IndexOf("(" + v_texto_mov + ")");
                    last = _busca.Length;
                    if (first > -1)
                        if (_busca.Substring(first + 1, last - first - 2) == pRow.Field<string>("desc_acao")) break;
                    i_acao = -1;
                }
            } catch { }
            return i_acao;
        }
        private void VisualizarRTF(string _NPlantao)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //DECLARAR VARIAVEIS
                //DataSet vRecordSetPlantao = new DataSet();
                DataSet vRecordSet = new DataSet();
                DataSet vRecordSetPlantaoServidor = new DataSet();
                string vSQL = "";
                string vPreencherSTR = "__________";
                string vServRecebeNome = "__________";
                string vServRecebeMatr = "__________";
                string vServTransfNome = "__________";
                string vServTransfMatr = "__________";
                Boolean bDataHoraRecebeVerif = false;
                DateTime vDataHoraRecebe = DateTime.Now;
                string vEfetivoRecebe = "__________";
                string vEfetivoRecebeTxt = "";
                string txtInstalacaoFisica = "Sem alterações.";
                string txtPatrimonio = "Sem alterações.";


                #region FORM_APP
                //---------------------------------------------------------
                #endregion FORM_APP
                //---------------------------------------------------------
                //****************************************************************************************

                //****************************************************************************************
                //*** CARREGAR DADOS DAS TABELAS *********************************************************
                //****************************************************************************************
                #region CARREGAR_DADOS

                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO
                Globais.DB_Adapter = new OleDbDataAdapter();
                try
                {
                    vSQL = "SELECT tb_plantao.id_unidade, tb_plantao.id_modulo, tb_plantao.id_plantao, tb_plantao.data_plantao_fim, tb_plantao.txt_inst_fisic, tb_plantao.txt_patrimo, " +
                                  "tb_plantao.cpf_servidor_passagem, corporativo_tb_servidor.nome_serv, corporativo_tb_servidor.matricula_serv, " +
                                  "tb_plantao.cpf_servidor_recebime, corporativo_tb_servidor_1.nome_serv, corporativo_tb_servidor_1.matricula_serv, tb_plantao.LOCAL_DT, tb_plantao.SERVER_DT " +
                           "FROM corporativo_tb_servidor AS corporativo_tb_servidor_1 INNER JOIN(corporativo_tb_servidor INNER JOIN tb_plantao " +
                             "ON corporativo_tb_servidor.id_cpf = tb_plantao.cpf_servidor_passagem) ON corporativo_tb_servidor_1.id_cpf = tb_plantao.cpf_servidor_recebime " +
                           "WHERE ((tb_plantao.id_unidade = '" + Globais.Unidade + "') AND (tb_plantao.id_modulo = '" + Globais.Modulo + "') AND (tb_plantao.id_plantao = '" + _NPlantao + "')) ";
                    OleDbCommand vCommand = new OleDbCommand(vSQL, Globais.DB_Database);
                    Globais.DB_Database.Open();
                    OleDbDataReader reader = vCommand.ExecuteReader();
                    //READER DO SELECT PARA RTF EM BYTE[] 
                    while (reader.Read())
                    {
                        vServRecebeNome = reader.GetString(10);
                        vServRecebeMatr = reader.GetString(11);
                        vServTransfNome = reader.GetString(7);
                        vServTransfMatr = reader.GetString(8);
                        try { vDataHoraRecebe = reader.GetDateTime(3); bDataHoraRecebeVerif = true; } catch { bDataHoraRecebeVerif = false; }
                        var bytes = (byte[])reader.GetValue(4); // campo da tabela 4 - txt_inst_fisic
                        byte[] documento = new byte[0];
                        documento = bytes;
                        txtInstalacaoFisica = System.Text.Encoding.UTF8.GetString(documento);

                        bytes = (byte[])reader.GetValue(5); // campo da tabela 5 - txt_patrimo
                        documento = new byte[0];
                        documento = bytes;
                        txtPatrimonio = System.Text.Encoding.UTF8.GetString(documento);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                    MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                    "Procedimento: " + ex.TargetSite.Name + "\n" +
                                    "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Globais.DB_Database.Close();
                }
                #endregion CARREGAR_DADOS_PLANTAO
                //---------------------------------------------------------



                //---------------------------------------------------------
                #region CARREGAR_DADOS_PLANTAO_JOVENS
                try
                {
                    DataSet vRecordSetPlantaoInternos = new DataSet();
                    vSQL = "SELECT tb_plantao.id_unidade, tb_plantao.id_modulo, tb_plantao.id_plantao, tb_plantao_transf_internos.id_interno, " +
                                  "tb_interno.nome_interno, tb_unidade_interno.n_ala, tb_unidade_interno.n_quarto " +
                           "FROM (tb_interno INNER JOIN(tb_plantao INNER JOIN tb_plantao_transf_internos ON (tb_plantao.id_plantao = tb_plantao_transf_internos.id_plantao) " +
                                 "AND (tb_plantao.id_modulo = tb_plantao_transf_internos.id_modulo) AND (tb_plantao.id_unidade = tb_plantao_transf_internos.id_unidade)) " +
                                 "ON tb_interno.id_interno = tb_plantao_transf_internos.id_interno) INNER JOIN tb_unidade_interno ON tb_interno.id_interno = tb_unidade_interno.id_interno " +
                           "WHERE ((tb_plantao.id_unidade = '" + Globais.Unidade + "') AND (tb_plantao.id_modulo = '" + Globais.Modulo + "') AND (tb_plantao.id_plantao = '" + _NPlantao + "')) " +
                           "ORDER BY tb_unidade_interno.n_ala, tb_unidade_interno.n_quarto, tb_interno.nome_interno; ";
                    vRecordSetPlantaoInternos = Consulta.Consultar(vSQL);

                    if (vRecordSetPlantaoInternos.Tables[0].Rows.Count > 0)
                        vEfetivoRecebe = vRecordSetPlantaoInternos.Tables[0].Rows.Count.ToString();

                    foreach (DataRow pRow in vRecordSetPlantaoInternos.Tables[0].Rows)
                    {
                        //ARMAZENA OS VALORES DA CONSULTA
                        // preenche o componente cJovemSelect
                        //cJovens.f_dados_jovem(pRow.Field<string>("id_interno"));
                        //cJovemSelect.Nome = pRow.Field<string>("nome_interno");
                        //cJovemSelect.Codigo = pRow.Field<string>("id_interno");
                        //cJovemSelect.Status = Convert.ToString(pRow.Field<int>("status_interno"));
                    }
                }
                catch (Exception ex)
                {
                    string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                    MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                    "Procedimento: " + ex.TargetSite.Name + "\n" +
                                    "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                #endregion CARREGAR_DADOS_PLANTAO_JOVENS
                //---------------------------------------------------------

                //---------------------------------------------------------
                #region CARREGAR_DADOS_PLANTAO_SERVIDORES

                #endregion CARREGAR_DADOS_PLANTAO_SERVIDORES
                //---------------------------------------------------------

                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_MOV_DIARIA_PERTENCES_MEDICAÇAO
                string vtxt_mov_diaria = "";
                string vtxt_pertences = "";
                string vtxt_medicacao = "";
                string vtxt_atendimento = "";
                DateTime hr_mov_diaria = DateTime.Now;
                string v_texto_mov = "";
                int i_acao = -1;
                try
                {
                    vSQL = "SELECT id_registro, id_acao, txt_registro_livro, txt_retorno, data_registro FROM tb_plantao_registro " +
                           "WHERE ((id_unidade = '" + Globais.Unidade + "') AND (id_modulo = '" + Globais.Modulo + "') AND (id_plantao = '" + _NPlantao + "')) " +
                           "ORDER BY id_registro; ";
                    vRecordSet = Consulta.Consultar(vSQL);
                    foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                    {
                        i_acao = pRow.Field<int>("id_acao");
                        v_texto_mov = pRow.Field<string>("txt_registro_livro");
                        hr_mov_diaria = pRow.Field<DateTime>("data_registro");
                        if (i_acao == 0) i_acao = VerificaTipodeAcao_retorno(v_texto_mov);
                        if (i_acao == 8) vtxt_medicacao = vtxt_medicacao + hr_mov_diaria.ToString("HH:mm") + " - " + v_texto_mov + " \r\n";
                        else if (i_acao == 9) vtxt_pertences = vtxt_pertences + hr_mov_diaria.ToString("HH:mm") + " - " + v_texto_mov + " \r\n";
                        else if ((i_acao > 13) && (i_acao < 18)) vtxt_atendimento = vtxt_atendimento + hr_mov_diaria.ToString("HH:mm") + " - " + v_texto_mov + " \r\n";
                        else vtxt_mov_diaria = vtxt_mov_diaria + hr_mov_diaria.ToString("HH:mm") + " - " + v_texto_mov + " \r\n";
                    }
                }
                catch (Exception ex)
                {
                    string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                    MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                    "Procedimento: " + ex.TargetSite.Name + "\n" +
                                    "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion CARREGAR_DADOS_MOV_DIARIA_PERTENCES_MEDICAÇAO
                //---------------------------------------------------------


                
                #endregion CARREGAR_DADOS
                //****************************************************************************************

                //****************************************************************************************
                //*** CARREGAR DADOS DAS TABELAS *********************************************************
                //****************************************************************************************
                #region CRIAR_RTF

                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO
                lbPlantao.Text = _NPlantao;
                eLivro.Text = "";

                System.Drawing.Image tempImage = DITI_LIVROM.Properties.Resources.logoDF;
                Clipboard.SetDataObject(tempImage);
                DataFormats.Format image = DataFormats.GetFormat(DataFormats.Bitmap);
                eLivro.Paste(image);
                eLivro.AppendText("\r\n");

                eLivro.SelectionAlignment = HorizontalAlignment.Center;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Bold);
                eLivro.AppendText("Registro Eletrônico do Plantão do Módulo " + Globais.Modulo + " - " + _NPlantao);
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;

                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("I - Recebimento do Plantão");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");

                if (bDataHoraRecebeVerif) vPreencherSTR = vDataHoraRecebe.ToString("HH:mm") + " do dia " + vDataHoraRecebe.ToString("dd/MM/yyyy");
                else vPreencherSTR = "__________";
                eLivro.AppendText("                     Eu " + vServRecebeNome + ", Matrícula nº: " + vServRecebeMatr +
                                  ", recebi o plantão do Módulo " + Globais.Modulo + ", às " + vPreencherSTR + ", com o efetivo de " +
                                  vEfetivoRecebe + " internos, com todas as normas em vigor, conforme Manual de Procedimentos Diários.");

                #endregion CARREGAR_DADOS_PLANTAO
                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO_INSTALACAO_FISICA
                try
                {
                    eLivro.AppendText("\r\n");
                    eLivro.AppendText("\r\n");
                    eLivro.AppendText("\r\n");
                    eLivro.SelectionAlignment = HorizontalAlignment.Left;
                    eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                    eLivro.AppendText("II - Instalações Físicas");
                    eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                    eLivro.AppendText("\r\n");
                    eLivro.AppendText("\r\n");
                    eLivro.SelectedRtf = txtInstalacaoFisica;
                }
                catch { }
                #endregion CARREGAR_DADOS_PLANTAO_INSTALACAO_FISICA
                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO_PATRIMONIO
                try
                {
                    eLivro.AppendText("\r\n");
                    eLivro.AppendText("\r\n");
                    eLivro.AppendText("\r\n");
                    eLivro.SelectionAlignment = HorizontalAlignment.Left;
                    eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                    eLivro.AppendText("III - Carga Patrimonial");
                    eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                    eLivro.AppendText("\r\n");
                    eLivro.AppendText("\r\n");
                    eLivro.SelectedRtf = txtPatrimonio;
                }
                catch { }


                #endregion CARREGAR_DADOS_PLANTAO_PATRIMONIO
                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO_MOVIMENTACAO_DIARIA
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("IV - Movimentação Diária");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText(vtxt_mov_diaria);

                #endregion CARREGAR_DADOS_PLANTAO_MOVIMENTACAO_DIARIA
                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO_ATENDIMENTOS
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("V - Atendimentos aos Adolescentes");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText(vtxt_atendimento);
                #endregion CARREGAR_DADOS_PLANTAO_ATENDIMENTOS
                //---------------------------------------------------------
                #region CARREGAR_DADOS_PLANTAO_CONFERENCIA_EFETIVO
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("VI - Conferência do Efetivo");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");



                #endregion CARREGAR_DADOS_PLANTAO_CONFERENCIA_EFETIVO
                //---------------------------------------------------------
                #region CARREGAR_DADOS_PLANTAO_OCORRENCIAS_ADM
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("VII - Ocorrências Administrativas");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");



                #endregion CARREGAR_DADOS_PLANTAO_OCORRENCIAS_ADM
                //---------------------------------------------------------            
                #region CARREGAR_DADOS_PLANTAO_OCORRENCIAS_FIS
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("VIII - Ocorrências Físicas");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");



                #endregion CARREGAR_DADOS_PLANTAO_OCORRENCIAS_FIS
                //---------------------------------------------------------
                #region CARREGAR_DADOS_PLANTAO_OCORRENCIAS_DISC
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("IX - Ocorrências Disciplinares");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");



                #endregion CARREGAR_DADOS_PLANTAO_OCORRENCIAS_DISC
                //---------------------------------------------------------
                #region CARREGAR_DADOS_PLANTAO_MED_DISC
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("X - Socioeducandos em Medida Disciplinar");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");



                #endregion CARREGAR_DADOS_PLANTAO_MED_DISC
                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO_PERTENCES
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("XI - Pertences");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText(vtxt_pertences);
                #endregion CARREGAR_DADOS_PLANTAO_PERTENCES
                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO_MEDICACAO
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("XII - Medicação");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText(vtxt_medicacao);
                #endregion CARREGAR_DADOS_PLANTAO_MEDICACAO
                //---------------------------------------------------------
                #region CARREGAR_DADOS_PLANTAO_EFETIVO
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("XIII - Efetivo do Módulo");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");



                #endregion CARREGAR_DADOS_PLANTAO_EFETIVO
                //---------------------------------------------------------
                #region CARREGAR_DADOS_PLANTAO_VISITAS
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("XIV - Visitas");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");



                #endregion CARREGAR_DADOS_PLANTAO_VISITAS
                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO_PASSAGEM
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Left;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Underline);
                eLivro.AppendText("XV - Passagem do Plantão");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("                     Eu " + vServTransfNome + ", Matrícula nº: " + vServTransfMatr +
                                  ", passo o plantão do Módulo " + Globais.Modulo + ", às " + vPreencherSTR + ", com o efetivo de " +
                                  vEfetivoRecebe + " internos, e todos os materiais relacionados no Item III deste documento.");
                #endregion CARREGAR_DADOS_PLANTAO_PASSAGEM
                //---------------------------------------------------------
                //---------------------------------------------------------OK
                #region CARREGAR_DADOS_PLANTAO_CABECALHO_FINAL
                lbPlantao.Text = _NPlantao;
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.SelectionAlignment = HorizontalAlignment.Right;
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);

                CultureInfo culture = new CultureInfo("pt-BR");
                DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                int dia = vDataHoraRecebe.Day;
                int ano = vDataHoraRecebe.Year;
                string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(vDataHoraRecebe.Month));
                string data = "Brasília, " + dia + " de " + mes + " de " + ano;
                eLivro.AppendText(data);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");

                eLivro.SelectionAlignment = HorizontalAlignment.Center;
                eLivro.AppendText("____________________________________");
                eLivro.AppendText("\r\n");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Bold);
                eLivro.AppendText("Responsável pela Passagem do Plantão");
                eLivro.AppendText("\r\n");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText(vServTransfNome + " - Matrícula: " + vServTransfMatr);
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("\r\n");
                eLivro.AppendText("_______________________________________");
                eLivro.AppendText("\r\n");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Bold);
                eLivro.AppendText("Responsável pelo Recebimento do Plantão");
                eLivro.AppendText("\r\n");
                eLivro.SelectionFont = new Font(eLivro.SelectionFont, FontStyle.Regular);
                eLivro.AppendText(vServRecebeNome + " - Matrícula: " + vServRecebeMatr);


                #endregion CARREGAR_DADOS_PLANTAO_CABECALHO_FINAL
                //---------------------------------------------------------

                #endregion CRIAR_RTF
                //****************************************************************************************
                
                eLivro.ScrollToCaret();
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        public void VisualizarLivroRTF(string _NPlantao)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //frm_livro_visualizar frm_livro_visualizar = new frm_livro_visualizar();
                VisualizarRTF(_NPlantao);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
            this.ShowDialog();
        }

        private void frm_sobre_jovem_Load(object sender, EventArgs e)
        {
            //VisualizarLivroRTF("17/11/2016");
            //VisualizarRTF("17/11/2016");
            //eLivro.LoadFile(@"C:\Desenvolvimento\SUBSIS\DITI_LIVROM\DITI_LIVROM\bin\Debug\LogoRel.rtf", RichTextBoxStreamType.RichText);


            /*
            Globais.DB_Adapter = new OleDbDataAdapter();
            try
            {
                string queryString = "SELECT id_acao, tp_id_ocorrencia, txt_ocorrencia, data_ocorrencia, " +
                                            "Format([data_ocorrencia], 'dd/mm/yyyy') AS data_registro_data, " +
                                            "Format([data_ocorrencia], 'hh:nn:ss') AS data_registro_hora " +
                                     "FROM tb_plantao_ocorrencia " +
                                     "WHERE(id_plantao = '" + Globais.Plantao + "') AND (tb_plantao_ocorrencia.id_ocorrencia = " + lbIDOcorrencia.Text + ") " +
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
            */
        }

    }
}

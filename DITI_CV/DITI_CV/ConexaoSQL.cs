using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;

namespace DITI_CV
{
    class ConexaoSQL
    {
        public static DataSet processos(string vidproc, string vnproc)
        {
            string vsqlWhere = "";
            if (vidproc != "") vsqlWhere = "WHERE (id_processo = " + vidproc + ") ";
            if (vnproc != "") vsqlWhere = "WHERE (n_processo Like '%" + vnproc + "%') ";

            //string mysql = "SELECT * FROM tb_cv_processo " + vsqlWhere + " order by id_processo;";
            string mysql = "SELECT tb_cv_processo.*, tb_cv_processo_tipo.desc_tp_processo " +
                           "FROM tb_cv_processo LEFT JOIN tb_cv_processo_tipo ON tb_cv_processo.tp_processo = tb_cv_processo_tipo.tp_processo " +
                            vsqlWhere + " order by id_processo;";
            return Consulta.Consultar(mysql);
            /*

            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
            */
        }

        public static DataSet processos_vinculados(string vidproc)
        {
            string vsqlWhere = "";
            if (vidproc != "") vsqlWhere = "WHERE (tb_cv_processo_vinculado.id_processo = " + vidproc + ") ";

            //string mysql = "SELECT * FROM tb_cv_processo " + vsqlWhere + " order by id_processo;";
            string mysql = "SELECT tb_cv_processo_vinculado.id_processo, tb_cv_processo_vinculado.id_processo_vinculado,tb_cv_processo.n_processo, tb_cv_processo.tp_processo, tb_cv_processo_tipo.desc_tp_processo " +
                           "FROM (tb_cv_processo LEFT JOIN tb_cv_processo_tipo ON tb_cv_processo.tp_processo = tb_cv_processo_tipo.tp_processo) " +
                                 "INNER JOIN tb_cv_processo_vinculado ON tb_cv_processo.id_processo = tb_cv_processo_vinculado.id_processo_vinculado " +
                           vsqlWhere + ";" ;
            return Consulta.Consultar(mysql);
            /*

            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
            */
        }

        public static DataSet processo_tipo()
        {
            string mysql = "SELECT * FROM tb_cv_processo_tipo order by tp_processo;";
            return Consulta.Consultar(mysql);
            /*
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
            */
        }

        public static DataSet audiencias(string vidproc, string vidaudi)
        {
            string vsqlWhere = "";
            if (vidproc != "") vsqlWhere = "WHERE (id_processo = " + vidproc + ") ";
            if (vidaudi != "") vsqlWhere = vsqlWhere + "AND (id_processo_audiencia = " + vidaudi + ") ";

            string mysql = "SELECT * FROM tb_cv_processo_audiencia " + vsqlWhere + " order by id_processo, id_processo_audiencia;";
            return Consulta.Consultar(mysql);
            /*
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
            */
        }

        public static DataSet documentos(string vidproc, string viddoc)
        {
            string vsqlWhere = "";
            if (vidproc != "") vsqlWhere = "WHERE (tb_cv_processo_documento.id_processo = " + vidproc + ") ";
            if (viddoc != "") vsqlWhere = vsqlWhere + "AND (tb_cv_processo_documento.id_processo_documento = " + viddoc + ") ";
            /*
            string mysql = "SELECT tb_cv_processo_documento.*, tb_cv_sys_tipo_entrada.desc_tipo_entrada, tb_cv_sys_decisaoA.desc_decisaoA, " +
                                  "tb_cv_sys_decisaoB.desc_decisaoB, tb_cv_sys_decisaoC.desc_decisaoC, tb_cv_sys_local.desc_local AS desc_local_documento,  " +
                                  "tb_cv_sys_local_1.desc_local AS desc_local_paai, tb_nai_ato_infracional.desc_ato_inf,  " +
                                  "tb_unidade.desc_unidade AS desc_unidade_atual, tb_unidade.sigla_unidade AS sigla_unidade_atual,  " +
                                  "tb_unidade_1.desc_unidade AS desc_unidade_destino, tb_unidade_1.sigla_unidade AS sigla_unidade_destino,  " +
                                  "tb_cv_processo_documento_tipo.desc_processo_documento_tipo, tb_ra.desc_ra, tb_jovem.*, tb_sexo.desc_sexo, tb_cor.desc_cor " +
                           "FROM(((((tb_cv_sys_local AS tb_cv_sys_local_1 RIGHT JOIN(tb_cv_sys_local RIGHT JOIN(((tb_cor RIGHT JOIN((((tb_cv_processo_documento " +
                                  "LEFT JOIN tb_cv_sys_decisaoA ON tb_cv_processo_documento.id_decisaoA = tb_cv_sys_decisaoA.id_decisaoA) " +
                                  "LEFT JOIN tb_cv_sys_decisaoB ON tb_cv_processo_documento.id_decisaoB = tb_cv_sys_decisaoB.id_decisaoB) " +
                                  "LEFT JOIN tb_cv_sys_tipo_entrada ON tb_cv_processo_documento.id_tipo_entrada = tb_cv_sys_tipo_entrada.id_tipo_entrada) " +
                                  "LEFT JOIN tb_jovem ON tb_cv_processo_documento.id_jovem = tb_jovem.id_jovem) ON tb_cor.id_cor = tb_jovem.id_cor) " +
                                  "LEFT JOIN tb_nai_ato_infracional ON tb_cv_processo_documento.id_ato_inf = tb_nai_ato_infracional.id_ato_inf) " +
                                  "LEFT JOIN tb_sexo ON tb_jovem.id_sexo = tb_sexo.id_sexo) ON tb_cv_sys_local.id_local = tb_cv_processo_documento.id_local_documento) " +
                                       "ON tb_cv_sys_local_1.id_local = tb_cv_processo_documento.id_local_paai) " +
                                  "LEFT JOIN tb_cv_sys_decisaoC ON tb_cv_processo_documento.id_decisaoC = tb_cv_sys_decisaoC.id_decisaoC) " +
                                  "LEFT JOIN tb_unidade ON tb_cv_processo_documento.id_unidade_atual = tb_unidade.id_unidade) " +
                                  "LEFT JOIN tb_unidade AS tb_unidade_1 ON tb_cv_processo_documento.id_unidade_destino = tb_unidade_1.id_unidade) " +
                                  "LEFT JOIN tb_cv_processo_documento_tipo ON tb_cv_processo_documento.id_processo_documento_tipo = tb_cv_processo_documento_tipo.id_processo_documento_tipo) " +
                                  "LEFT JOIN tb_ra ON tb_cv_processo_documento.id_ra_ato_inf = tb_ra.id_ra " +
                            vsqlWhere + " order by id_processo, id_processo_documento;";
            */
            string mysql = "SELECT tb_cv_processo_documento.*, tb_cv_sys_tipo_entrada.desc_tipo_entrada, tb_cv_sys_decisaoA.desc_decisaoA, " +
                                  "tb_cv_sys_decisaoB.desc_decisaoB, tb_cv_sys_decisaoC.desc_decisaoC, tb_cv_sys_local.desc_local AS desc_local_documento, " +
                                  "tb_cv_sys_local_1.desc_local AS desc_local_paai, tb_nai_ato_infracional.desc_ato_inf, " +
                                  "coorporativo_tb_lotacao.desc_lotacao AS desc_unidade_atual, coorporativo_tb_lotacao.sigla_lotacao AS sigla_unidade_atual, " +
                                  "coorporativo_tb_lotacao_1.desc_lotacao AS desc_unidade_destino, coorporativo_tb_lotacao_1.sigla_lotacao AS sigla_unidade_destino, " +
                                  "tb_cv_processo_documento_tipo.desc_processo_documento_tipo, tb_ra.desc_ra, tb_jovem.*, tb_sexo.desc_sexo, tb_cor.desc_cor " +
                           "FROM(((((tb_cv_sys_local AS tb_cv_sys_local_1 RIGHT JOIN(tb_cv_sys_local RIGHT JOIN(((tb_cor RIGHT JOIN((((tb_cv_processo_documento " +
                                  "LEFT JOIN tb_cv_sys_decisaoA ON tb_cv_processo_documento.id_decisaoA = tb_cv_sys_decisaoA.id_decisaoA) " +
                                  "LEFT JOIN tb_cv_sys_decisaoB ON tb_cv_processo_documento.id_decisaoB = tb_cv_sys_decisaoB.id_decisaoB) " +
                                  "LEFT JOIN tb_cv_sys_tipo_entrada ON tb_cv_processo_documento.id_tipo_entrada = tb_cv_sys_tipo_entrada.id_tipo_entrada) " +
                                  "LEFT JOIN tb_jovem ON tb_cv_processo_documento.id_jovem = tb_jovem.id_jovem) ON tb_cor.id_cor = tb_jovem.id_cor) " +
                                  "LEFT JOIN tb_nai_ato_infracional ON tb_cv_processo_documento.id_ato_inf = tb_nai_ato_infracional.id_ato_inf) " +
                                  "LEFT JOIN tb_sexo ON tb_jovem.id_sexo = tb_sexo.id_sexo) ON tb_cv_sys_local.id_local = tb_cv_processo_documento.id_local_documento) " +
                                       "ON tb_cv_sys_local_1.id_local = tb_cv_processo_documento.id_local_paai) " +
                                  "LEFT JOIN tb_cv_sys_decisaoC ON tb_cv_processo_documento.id_decisaoC = tb_cv_sys_decisaoC.id_decisaoC) " +
                                  "LEFT JOIN tb_cv_processo_documento_tipo ON tb_cv_processo_documento.id_processo_documento_tipo = tb_cv_processo_documento_tipo.id_processo_documento_tipo) " +
                                  "LEFT JOIN tb_ra ON tb_cv_processo_documento.id_ra_ato_inf = tb_ra.id_ra) LEFT JOIN coorporativo_tb_lotacao " +
                                       "ON tb_cv_processo_documento.id_unidade_atual = coorporativo_tb_lotacao.id_lotacao) " +
                                  "LEFT JOIN coorporativo_tb_lotacao AS coorporativo_tb_lotacao_1 ON tb_cv_processo_documento.id_unidade_destino = coorporativo_tb_lotacao_1.id_lotacao " +
                            vsqlWhere + " order by id_processo, id_processo_documento;";


            return Consulta.Consultar(mysql);
            /*
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
            */
        }

        public static DataSet documento_tipo()
        {
            string mysql = "SELECT * FROM tb_cv_processo_documento_tipo order by id_processo_documento_tipo; ";
            return Consulta.Consultar(mysql);
            /*
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
            */
        }

        public static DataSet Jovens(string vidjovem, string vBusca)
        {
            string vsqlWhere = "";
            if (vidjovem == "-1") vidjovem = "";
            if (vidjovem != "") vsqlWhere = "WHERE (tb_jovem.id_jovem = '" + vidjovem + "') ";
            if (vBusca != "") vsqlWhere = "WHERE (tb_jovem.nome_jovem Like '%" + vBusca + "%') " +
                                             "OR (tb_jovem.cpf_jovem Like '%" + vBusca + "%') " +
                                             "OR (tb_jovem.ident_jovem Like '%" + vBusca + "%') " +
                                             "OR (tb_jovem.cod_sipia Like '%" + vBusca + "%') ";
            string mysql = "SELECT tb_jovem.*, tb_sexo.desc_sexo, tb_cor.desc_cor " +
                           "FROM(tb_jovem LEFT JOIN tb_cor ON tb_jovem.id_cor = tb_cor.id_cor) LEFT JOIN tb_sexo ON tb_jovem.id_sexo = tb_sexo.id_sexo " +
                            vsqlWhere + " order by nome_jovem;";

            return Consulta.Consultar(mysql);
            /*
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
            */
        }

        public static DataSet Jovens_nai(string vidjovem, string vBusca)
        {
            string vsqlWhere = "WHERE (tb_nai_interno.status_unidade < 10) ";
            if (vidjovem != "") vsqlWhere = vsqlWhere +  "AND (tb_nai_interno.id_interno = '" + vidjovem + "') ";
            if (vBusca != "") vsqlWhere = vsqlWhere + "AND ( (tb_nai_interno.nome_interno Like '%" + vBusca + "%') " +
                                             "OR (tb_nai_interno.cpf_interno Like '%" + vBusca + "%') " +
                                             "OR (tb_nai_interno.ident_interno Like '%" + vBusca + "%') " +
                                             "OR (tb_nai_interno.cod_sipia Like '%" + vBusca + "%') )";
            string mysql = "SELECT tb_nai_interno.*, tb_sexo.desc_sexo, tb_cor.desc_cor " +
                           "FROM(tb_nai_interno LEFT JOIN tb_cor ON tb_nai_interno.id_cor = tb_cor.id_cor) LEFT JOIN tb_sexo ON tb_nai_interno.id_sexo = tb_sexo.id_sexo " +
                            vsqlWhere + " order by nome_interno;";
            return Consulta.Consultar(mysql);
            /*
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
            */
        }

        public static DataSet Documento_nai(string vidjovem, string vidplantaoNAI)
        {
            string mysql = "SELECT tb_nai_cadastro.*, tb_nai_estatistica.*, tb_nai_origem.desc_origem AS D_ORIGEM, tb_nai_origem_1.desc_origem AS D_DESTINO, tb_nai_motivo_entrada.desc_motivo, tb_nai_decisao.desc_decisao, tb_nai_ato_infracional.desc_ato_inf, tb_ra.desc_ra " +
                           "FROM ((((((tb_nai_cadastro LEFT JOIN tb_nai_origem ON tb_nai_cadastro.id_origem_doc_ent = tb_nai_origem.id_origem) LEFT JOIN tb_nai_origem AS tb_nai_origem_1 ON tb_nai_cadastro.id_destino_doc_sai = tb_nai_origem_1.id_origem) " +
                                    "LEFT JOIN tb_nai_motivo_entrada ON tb_nai_cadastro.id_motivo_entrada = tb_nai_motivo_entrada.id_motivo) LEFT JOIN tb_nai_decisao ON tb_nai_cadastro.id_decisao_cad = tb_nai_decisao.id_decisao) " +
                                    "LEFT JOIN tb_nai_estatistica ON (tb_nai_cadastro.id_plantao = tb_nai_estatistica.id_plantao) AND (tb_nai_cadastro.id_interno = tb_nai_estatistica.id_interno)) " +
                                    "LEFT JOIN tb_nai_ato_infracional ON tb_nai_estatistica.id_ato_inf = tb_nai_ato_infracional.id_ato_inf) LEFT JOIN tb_ra ON tb_nai_estatistica.id_ra_ato = tb_ra.id_ra " +
                           "WHERE tb_nai_cadastro.id_interno = '" + vidjovem + "' AND tb_nai_cadastro.id_plantao = '" + vidplantaoNAI + "';";
            return Consulta.Consultar(mysql);
            /*
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
            */
        }

        public static System.Object[] Combo_Alimentar(string vTipo)
        {

            try
            {
                string mysql = "SELECT * FROM " + vTipo + "; "; //" order by id_local; ";
                Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
                MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
                DataSet dados = new DataSet();
                adoleAdapter.Fill(dados);

                int iTot = dados.Tables[0].Rows.Count;
                System.Object[] ItemObject = new System.Object[iTot];

                int i = 0;
                foreach (DataRow pRow in dados.Tables[0].Rows)
                {
                    ItemObject[i] = pRow.Field<string>(1);
                    i++;
                }
                return ItemObject;
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static System.Object[] Combo_Decisao(string vTipo, string vTipoA, string vTipoB)
        {
            try
            {
                string mysql = "SELECT tb_cv_sys_decisao.id_decisaoA, tb_cv_sys_decisaoA.desc_decisaoA " +
                               "FROM tb_cv_sys_decisao LEFT JOIN tb_cv_sys_decisaoA ON tb_cv_sys_decisao.id_decisaoA = tb_cv_sys_decisaoA.id_decisaoA " +
                               "GROUP BY tb_cv_sys_decisao.id_decisaoA, tb_cv_sys_decisaoA.desc_decisaoA, tb_cv_sys_decisao.id_tipo_entrada " +
                               "HAVING tb_cv_sys_decisao.id_tipo_entrada =  " + vTipo + ";";
                if (vTipoA != "")
                    mysql = "SELECT tb_cv_sys_decisao.id_decisaoB, tb_cv_sys_decisaoB.desc_decisaoB " +
                            "FROM tb_cv_sys_decisao LEFT JOIN tb_cv_sys_decisaoB ON tb_cv_sys_decisao.id_decisaoB = tb_cv_sys_decisaoB.id_decisaoB " +
                            "GROUP BY tb_cv_sys_decisao.id_tipo_entrada, tb_cv_sys_decisao.id_decisaoA, tb_cv_sys_decisao.id_decisaoB, tb_cv_sys_decisaoB.desc_decisaoB " +
                            "HAVING (tb_cv_sys_decisao.id_tipo_entrada = " + vTipo + ") AND (tb_cv_sys_decisao.id_decisaoA = " + vTipoA + ") " +
                            "ORDER BY tb_cv_sys_decisao.id_tipo_entrada, tb_cv_sys_decisao.id_decisaoA, tb_cv_sys_decisao.id_decisaoB; ";
                if (vTipoB != "")
                    mysql = "SELECT tb_cv_sys_decisao.id_decisaoC, tb_cv_sys_decisaoC.desc_decisaoC " +
                            "FROM tb_cv_sys_decisao LEFT JOIN tb_cv_sys_decisaoC ON tb_cv_sys_decisao.id_decisaoC = tb_cv_sys_decisaoC.id_decisaoC " +
                            "GROUP BY tb_cv_sys_decisao.id_tipo_entrada, tb_cv_sys_decisao.id_decisaoA, tb_cv_sys_decisao.id_decisaoB, tb_cv_sys_decisao.id_decisaoC, tb_cv_sys_decisaoC.desc_decisaoC " +
                            "HAVING(tb_cv_sys_decisao.id_tipo_entrada = " + vTipo + ") AND (tb_cv_sys_decisao.id_decisaoA = " + vTipoA + ") AND (tb_cv_sys_decisao.id_decisaoB = " + vTipoB + ") " +
                            "ORDER BY tb_cv_sys_decisao.id_tipo_entrada, tb_cv_sys_decisao.id_decisaoA, tb_cv_sys_decisao.id_decisaoB, tb_cv_sys_decisao.id_decisaoC; ";

                Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
                MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
                DataSet dados = new DataSet();
                adoleAdapter.Fill(dados);

                int iTot = dados.Tables[0].Rows.Count;
                System.Object[] ItemObject = new System.Object[iTot];

                int i = 0;
                foreach (DataRow pRow in dados.Tables[0].Rows)
                {
                    ItemObject[i] = pRow.Field<string>(1);
                    i++;
                }
                return ItemObject;
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static System.Object[] Combo_Unidades(string vTipo)
        {
            try
            {
                int iTot;
                System.Object[] ItemObject;
                int i = 1;
                string mysql = "";
                if (vTipo == "2")
                    mysql = "SELECT id_lotacao, sigla_lotacao, desc_lotacao FROM db_subsis_modulo.coorporativo_tb_lotacao " +
                            "WHERE((CONVERT(id_lotacao, UNSIGNED INTEGER) > 60600000000) and(CONVERT(id_lotacao, UNSIGNED INTEGER) < 60620000000))";
                else if (vTipo == "3")
                    mysql = "SELECT id_lotacao, sigla_lotacao, desc_lotacao FROM db_subsis_modulo.coorporativo_tb_lotacao " +
                            "WHERE((CONVERT(id_lotacao, UNSIGNED INTEGER) > 60301000000) and(CONVERT(id_lotacao, UNSIGNED INTEGER) < 60301100000))";
                else if ((vTipo == "4") || (vTipo == "5") || (vTipo == "6"))
                    mysql = "SELECT id_lotacao, sigla_lotacao, desc_lotacao FROM db_subsis_modulo.coorporativo_tb_lotacao " +
                            "WHERE(concat(SUBSTR(id_lotacao, 1, 8), '0000') = id_lotacao) and((CONVERT(id_lotacao, UNSIGNED INTEGER) > 60302000000) and(CONVERT(id_lotacao, UNSIGNED INTEGER) < 60302090000))";
                else 
                    mysql = "SELECT id_lotacao, sigla_lotacao, desc_lotacao FROM db_subsis_modulo.coorporativo_tb_lotacao " +
                            "WHERE((CONVERT(id_lotacao, UNSIGNED INTEGER) > 60600000000) and(CONVERT(id_lotacao, UNSIGNED INTEGER) < 60620000000)) " +
                            "OR ((CONVERT(id_lotacao, UNSIGNED INTEGER) > 60301000000) and(CONVERT(id_lotacao, UNSIGNED INTEGER) < 60301100000)) " +
                            "OR (concat(SUBSTR(id_lotacao, 1, 8), '0000') = id_lotacao) and((CONVERT(id_lotacao, UNSIGNED INTEGER) > 60302000000) and(CONVERT(id_lotacao, UNSIGNED INTEGER) < 60302090000))";
                if (mysql == "")
                {
                    ItemObject = new System.Object[1];
                    ItemObject[0] = "";
                }
                else
                {
                    Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
                    MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
                    DataSet dados = new DataSet();
                    adoleAdapter.Fill(dados);
                    iTot = dados.Tables[0].Rows.Count + 1;
                    ItemObject = new System.Object[iTot];
                    ItemObject[0] = "";
                    foreach (DataRow pRow in dados.Tables[0].Rows)
                    {
                        ItemObject[i] = pRow.Field<string>(0) + " - " + pRow.Field<string>(1);
                        i++;
                    }
                }
                return ItemObject;
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static int SelItemCombo_Decisao(string vField, string vDesc)
        {
            string mysql = "SELECT * FROM tb_cv_sys_" + vField + " where desc_" + vField + " = '" + vDesc + "';";
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            int iID = 0;
            try
            {
                iID = dados.Tables[0].Rows[0].Field<int>(0);
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                iID = 0; 
            }
            return iID;
        }

        public static int SelItemCombo_DOC_ORIGEM(string vField, string vDesc)
        {
            string mysql = "SELECT * FROM tb_cv_sys_" + vField + " where desc_" + vField + " = '" + vDesc + "';";
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            int iID = 0;
            try
            {
                iID = dados.Tables[0].Rows[0].Field<int>(0);
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                iID = 0;
            }
            return iID;
        }
    }
}

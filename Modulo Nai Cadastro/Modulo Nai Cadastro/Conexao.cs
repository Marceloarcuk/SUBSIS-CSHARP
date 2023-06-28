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

namespace Modulo_Nai_Cadastro
{
    /***********************************************************************************************************/
    /****************************** CLASSE RELACIONADA A TODAS CONEXÕES  ***************************************/
    /***********************************************************************************************************/
    class Conexao
    {
        private static string strConexao = "Persist Security Info=False;server=localhost; database=db_subsis;uid=root;pwd=";
        private static string strConexaoCoorp = "Persist Security Info=False;server=localhost; database=db_coorporativo;uid=root;pwd=";
        
        public static MySqlConnection cConexao { get; set; }

        public static void Conecta()
        {
            try
            {
                cConexao = new MySqlConnection(strConexao);
                cConexao.Open();


            }
            catch (MySqlException ex)
            {
                string error = ex.Message;
                MessageBox.Show("Erro ao conectar! - " + error);

            }
        }

        public static void Desconecta()
        {
            cConexao.Close();
            //MessageBox.Show("Desconectado com sucesso!");
        }
        /***********************************************************************************************************/
        /****************************** AUTENTICA USUÁRIO NO DB_COORPORATIVO ***************************************/
        /***********************************************************************************************************/
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static DataSet AutenticaUsu( string usuario, string senha)
        {
            string usu = usuario;
            string pass ="uhofdjfoiahdfuHU"+ senha;
            MD5 md5Hash = MD5.Create();
            string passWd = GetMd5Hash(md5Hash, pass);
           
            string mysql = "select * from tb_usuario inner join tb_sistemas_usuario on tb_usuario.id_cpf=tb_sistemas_usuario.id_cpf where  id_sis=8 and s_login='"+ usu + "' and s_pass='"+ passWd + "'  ; ";
            cConexao = new MySqlConnection(strConexaoCoorp);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
        }
        public static void AlteraSenha(string idUsu, string pass)
        {
            string IDusu = idUsu;
            string word = pass;
            string senha = "uhofdjfoiahdfuHU" + word;
            MD5 md5Hash = MD5.Create();
            string passWd = GetMd5Hash(md5Hash, senha);

            string mysql = "update tb_usuario set s_pass='"+ passWd +"' where id_cpf='"+ idUsu +"'  ; ";
            cConexao = new MySqlConnection(strConexaoCoorp);
           
            MySqlCommand cmdCommand = new MySqlCommand(mysql, cConexao);

            try
            {
                cConexao.Open();

                int x = cmdCommand.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Senha alterada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();



        }
        /***********************************************************************************************************/
        /****************************** SELECT TB_NAI_DECISAO comboBoxDecisao  *************************************/
        /***********************************************************************************************************/
        public static DataSet SelectDecisao()
        {
            string mysql = "select * from  tb_nai_decisao ; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
        }
        public static DataSet SelectOrigem()
        {
            string mysql = "select * from  tb_nai_origem ; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
        }
        public static DataSet SelectOrgaoDecisorio()
        {
            string mysql = "select * from  tb_nai_orgao_decisorio; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
        }
        public static DataSet SelectDestino()
        {
            string mysql = "select * from  tb_nai_destino ; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
        }

        /***********************************************************************************************************/
        /****************************** INSERE O  O ID_PLANTAO NA TB_NAI_ID_PLANTAO ********************************/
        /***********************************************************************************************************/
        public static void Insere_idPlantao()
        {
            Plantao plt = new Plantao();
            string idPlantao = plt.GetPlantaoForm();
            string dataNai = plt.GetPlantaoSysPt();

            string mysql = "insert into tb_nai_id_plantao(id_nai_plantao, data_nai_plantao, data_plantao_ini) values('"+ idPlantao + "', '"+ dataNai + "', '"+ dataNai + "') ;";
            cConexao = new MySqlConnection(strConexao);

            MySqlCommand cmdCommand = new MySqlCommand(mysql, cConexao);
           
            try
            {
                cConexao.Open();

                int x = cmdCommand.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /***********************************************************************************************************/
        /****************************** BUSCA SE EXISTE PLANTAO ATUAL  *****************************************************/
        /***********************************************************************************************************/
        public static string buscaPlantao_Atual()
        {
            Plantao plt = new Plantao();
            string idPlantao = plt.GetPlantaoForm();
            string mysql = "select * from  tb_nai_id_plantao where id_plantao='"+ idPlantao + "' ; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            foreach(DataRow pRow in dados.Tables[0].Rows)
            {
                string pAtual = pRow.Field<string>("id_plantao");
                if(pAtual == idPlantao)
                {
                   
                }
                else
                {
                    idPlantao = null;
                   
                }
            }
            return idPlantao;


        }
        /***********************************************************************************************************/
        /****************************** Localiza tb_jovens  *****************************************************/
        /***********************************************************************************************************/
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
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
        }
        /***********************************************************************************************************/
        /****************************** Localiza tb_jovens UM JOVEM ESPECÌFICO *****************************************************/
        /***********************************************************************************************************/
        public static DataSet JovensEsp(string nomeJ, string idJ)
        {
            string idJovem = idJ;
            string nome = nomeJ;
            string vsqlWhere = "where tb_jovem.id_jovem = '" + idJovem + "' and tb_jovem.nome_jovem='" + nome + "' ;";
           
            string mysql = "SELECT tb_jovem.*, tb_sexo.desc_sexo, tb_cor.desc_cor " +
                           "FROM(tb_jovem LEFT JOIN tb_cor ON tb_jovem.id_cor = tb_cor.id_cor) LEFT JOIN tb_sexo ON tb_jovem.id_sexo = tb_sexo.id_sexo " +
                            vsqlWhere + " ";
            cConexao = new MySqlConnection(strConexao);
            //MessageBox.Show(mysql);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
        }
        /***********************************************************************************************************/
        /****************************** Localiza tb_jovens do nai *****************************************************/
        /***********************************************************************************************************/
        public static DataSet Jovens_nai(string vidjovem, string vBusca)
        {
            string vsqlWhere = "WHERE (tb_nai_interno.status_unidade = 8 and tb_nai_interno.ativo_sys=1) ";
            if (vidjovem != "") vsqlWhere = vsqlWhere + "AND (tb_nai_interno.id_interno = '" + vidjovem + "') ";
            if (vBusca != "") vsqlWhere = vsqlWhere + "AND ( (tb_nai_interno.nome_interno Like '%" + vBusca + "%') " +
                                             "OR (tb_nai_interno.cpf_interno Like '%" + vBusca + "%') " +
                                             "OR (tb_nai_interno.ident_interno Like '%" + vBusca + "%') " +
                                             "OR (tb_nai_interno.cod_sipia Like '%" + vBusca + "%') )";
            string mysql = "SELECT tb_nai_interno.*, tb_sexo.desc_sexo, tb_cor.desc_cor " +
                           "FROM(tb_nai_interno LEFT JOIN tb_cor ON tb_nai_interno.id_cor = tb_cor.id_cor) LEFT JOIN tb_sexo ON tb_nai_interno.id_sexo = tb_sexo.id_sexo " +
                            vsqlWhere + " order by nome_interno;";
            Conexao.cConexao = new MySqlConnection(Conexao.strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, Conexao.cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
        }
        /***********************************************************************************************************/
        /****************************** VERIFICA SE O ADOLESCENTE JÁ EXISTE    *************************************/
        /***********************************************************************************************************/
        public static DataSet verificaAdolescente_Existe(string nomeJ, string idJ, string sipia, string cpf)
        {
            string sipiaA = "";
            string nomeA = "";
            string idSecriA = "";
            string cpfA = "";
            sipiaA = sipia; 
            nomeA = nomeJ;
            idSecriA = idJ;
             cpfA = cpf; 
            string mysql = "select * from tb_nai_interno where nome_interno='" + nomeA + "' and (cod_sipia='" + sipiaA + "' or cpf_interno='"+ cpfA + "' or tb_nai_interno.id_interno='"+ idSecriA + "' ) and ativo_sys=1 ;";
            cConexao = new MySqlConnection(strConexao);
            //MessageBox.Show(mysql);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;

        }


        /***********************************************************************************************************/
        /****************************** INSERE O ADOLESCENTE NO BANCO DE DADOS *************************************/
        /***********************************************************************************************************/
        public static void InsereAdolescente(string nome, string cpf, string sipia, string idUsuU, string iDSecria, Image img)
        { 
            Auxiliar aux = new Auxiliar();
            string name = nome;
            string nCpf = cpf;
            string nSipia = sipia;
            string idSecri = iDSecria;
            Image imag = img;
            string idUsu = idUsuU;
            byte[] photp = ImageConvert.ImageToByteArray(img);
            Plantao pltd = new Plantao();
            string plantao = pltd.GetPlantaoSys();
            string plantaoMod = pltd.GetPlantaoForm();
           
            
            //TB_INTERNO
            string mysql = "";
            if (String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
            {
                mysql = "insert into tb_nai_interno(id_interno, id_plantao , nome_interno , LOCAL_DT , SERVER_DT, foto) values ('" + name + "','"+ plantaoMod + "' ,  '" + name + "', '" + plantao + "', '" + plantao + "', @foto )";
            }
            else
            {
                if (!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && !String.IsNullOrEmpty(idSecri))
                {
                    mysql = "insert into tb_nai_interno(id_interno, id_plantao ,nome_interno , cpf_interno, cod_sipia, LOCAL_DT , SERVER_DT, foto) values ('" + idSecri + "', '" + plantaoMod + "', '" + name + "','" + nCpf + "', '" + nSipia + "' ,'" + plantao + "', '" + plantao + "', @foto )";
                }
                else if (!String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql = "insert into tb_nai_interno(id_interno,  id_plantao , nome_interno , cod_sipia, LOCAL_DT , SERVER_DT, foto) values ('" + nSipia + "', '" + plantaoMod + "', '" + name + "','" + nSipia + "' ,'" + plantao + "', '" + plantao + "', @foto )";
                }
                else if (String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql = "insert into tb_nai_interno(id_interno,  id_plantao , nome_interno , cpf_interno, LOCAL_DT , SERVER_DT, foto) values ('" + nCpf + "', '" + plantaoMod + "', '" + name + "','" + nCpf + "' ,'" + plantao + "', '" + plantao + "', @foto )";
                }
                else if (!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql = "insert into tb_nai_interno(id_interno,  id_plantao , nome_interno , cpf_interno, cod_sipia, LOCAL_DT , SERVER_DT, foto) values ('" + nCpf + "', '" + plantaoMod + "', '" + name + "','" + nCpf + "' ,'"+ nSipia+"' ,'" + plantao + "', '" + plantao + "', @foto )";
                }
                else if (String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql = "insert into tb_nai_interno(id_interno,  id_plantao , nome_interno , cpf_interno, LOCAL_DT , SERVER_DT, foto) values ('" + nCpf + "', '" + plantaoMod + "', '" + name + "','" + nCpf + "' ,'" + plantao + "', '" + plantao + "', @foto)";
                }
                else
                {
                    mysql = "insert into tb_nai_interno(id_interno, id_plantao ,nome_interno , cpf_interno, cod_sipia, LOCAL_DT , SERVER_DT, foto) values ('" + idSecri + "', '" + plantaoMod + "', '" + name + "','" + nCpf + "', '" + nSipia + "' ,'" + plantao + "', '" + plantao + "', @foto )";
                }
            }

            cConexao = new MySqlConnection(strConexao);

            MySqlCommand cmdCommand = new MySqlCommand(mysql, cConexao);
            cmdCommand.Parameters.AddWithValue("@foto", photp);
            cConexao.Open();
            try
            {
               

                int x = cmdCommand.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //TB_NAI_PLANTAO_INTERNO
            string mysqlPlant = "";
            if (String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
            {
                mysqlPlant = "insert into tb_nai_plantao_interno(id_plantao, id_interno) values ('" + plantaoMod + "' ,  '" + name + "' )";
            }
            else
            {
                if (!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && !String.IsNullOrEmpty(idSecri))
                {
                    mysqlPlant = "insert into tb_nai_plantao_interno(id_plantao, id_interno) values ('" + plantaoMod + "' ,  '" + idSecri + "' )";
                    
                }
                else if (!String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysqlPlant = "insert into tb_nai_plantao_interno(id_plantao, id_interno) values ('" + plantaoMod + "' ,  '" + nSipia + "' )";
                    
                }
                else if (!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysqlPlant = "insert into tb_nai_plantao_interno(id_plantao, id_interno) values ('" + plantaoMod + "' ,  '" + nCpf + "' )";
                    
                }
                else if (String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysqlPlant = "insert into tb_nai_plantao_interno(id_plantao, id_interno) values ('" + plantaoMod + "' ,  '" + nCpf + "' )";
                }
                else
                {
                    mysqlPlant = "insert into tb_nai_plantao_interno(id_plantao, id_interno) values ('" + plantaoMod + "' ,  '" + idSecri + "' )";
                }
            }

            cConexao = new MySqlConnection(strConexao);

            MySqlCommand cmdCommandPlant = new MySqlCommand(mysqlPlant, cConexao);
            try
            {
                cConexao.Open();

                int x = cmdCommandPlant.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //TB_NAI_CADASTRO

            string mysql_cad = "";
            if (String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
            {
                mysql_cad = "insert into tb_nai_cadastro(id_interno, id_plantao, LOCAL_DT_NAI  , SERVER_DT_NAI , sys_id_insert_cad, status_unidade_cad) values ( '" + name + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "' ,  '"+ idUsu + "', 8)";
            }
            else
            {
                if (!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && !String.IsNullOrEmpty(idSecri))
                {
                    mysql_cad = "insert into tb_nai_cadastro(id_interno, id_plantao, LOCAL_DT_NAI  , SERVER_DT_NAI ,  sys_id_insert_cad, status_unidade_cad) values ( '" + idSecri + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "',  '" + idUsu + "', 8 )";
                }
                else if (!String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql_cad = "insert into tb_nai_cadastro(id_interno, id_plantao, LOCAL_DT_NAI  , SERVER_DT_NAI, sys_id_insert_cad, status_unidade_cad) values ( '" + nSipia + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "', 8)";
                }
                else if(!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql_cad = "insert into tb_nai_cadastro(id_interno, id_plantao, LOCAL_DT_NAI  , SERVER_DT_NAI , sys_id_insert_cad, status_unidade_cad ) values ( '" + nCpf + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "',  '" + idUsu + "', 8 )";
                }
                else if (String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql_cad = "insert into tb_nai_cadastro(id_interno, id_plantao, LOCAL_DT_NAI  , SERVER_DT_NAI ,  sys_id_insert_cad, status_unidade_cad ) values ( '" + nCpf + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "',  '" + idUsu + "', 8 )";
                }
                else
                {
                    mysql_cad = "insert into tb_nai_cadastro(id_interno, id_plantao, LOCAL_DT_NAI  , SERVER_DT_NAI ,  sys_id_insert_cad, status_unidade_cad ) values ( '" + idSecri + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "',  '" + idUsu + "', 8 )";
                }



            }
            MySqlCommand cmdCommand_nai = new MySqlCommand(mysql_cad, cConexao);

            try
            {


                int x = cmdCommand_nai.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();

            //TB_NAI_MODULO
            string idAdolescente = "";
            string mysql_mod = "";
            if (String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
            {

                mysql_mod = "insert into tb_nai_modulo(id_interno, id_plantao,  sis_user_insert, LOCAL_DT_NAI, SERVER_DT_NAI) values ( '" + name + "',  '" + plantaoMod + "', '" + idUsu + "', '" + plantao + "', '" + plantao + "')";
                idAdolescente = name;
            }
            else
            {
                if (!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && !String.IsNullOrEmpty(idSecri))
                {
                    mysql_mod = "insert into tb_nai_modulo(id_interno, id_plantao,  sis_user_insert, LOCAL_DT_NAI, SERVER_DT_NAI) values ( '" + idSecri + "',  '" + plantaoMod + "', '" + idUsu + "', '" + plantao + "', '" + plantao + "')";
                    idAdolescente = idSecri;
                }
                else if (!String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql_mod = "insert into tb_nai_modulo(id_interno, id_plantao, sis_user_insert, LOCAL_DT_NAI, SERVER_DT_NAI) values ( '" + nSipia + "', '" + plantaoMod + "', '" + idUsu + "', '" + plantao + "', '" + plantao + "')";
                    idAdolescente = nSipia;
                }
                else if (!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql_mod = "insert into tb_nai_modulo(id_interno, id_plantao, sis_user_insert, LOCAL_DT_NAI, SERVER_DT_NAI) values ( '" + nCpf + "', '" + plantaoMod + "', '" + idUsu + "', '" + plantao + "', '" + plantao + "')";
                    idAdolescente = nCpf;
                }
                else if (String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql_mod = "insert into tb_nai_modulo(id_interno, id_plantao,  sis_user_insert, LOCAL_DT_NAI, SERVER_DT_NAI) values ( '" + nCpf + "',  '" + plantaoMod + "', '" + idUsu + "', '" + plantao + "', '" + plantao + "')";
                    idAdolescente = nCpf;
                }
                else
                {
                    mysql_mod = "insert into tb_nai_modulo(id_interno, id_plantao,  sis_user_insert, LOCAL_DT_NAI, SERVER_DT_NAI) values ( '" + idSecri + "',  '" + plantaoMod + "', '" + idUsu + "', '" + plantao + "', '" + plantao + "')";
                    idAdolescente = idSecri;
                }
            }
            cConexao.Open();
            MySqlCommand cmdCommand_mod = new MySqlCommand(mysql_mod, cConexao);

            try
            {


                int x = cmdCommand_mod.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            cConexao.Close();

            //TB_NAI_ESTATISTICA
            cConexao.Open();


            string mysql_est = "";
                if (String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                {
                    mysql_est = "insert into tb_nai_estatistica(id_interno, id_plantao, LOCAL_DT, SERVER_DT , sys_id_insert) values ( '" + name + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "', '" + idUsu + "')";
                }
                else
                {
                    if (!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && !String.IsNullOrEmpty(idSecri))
                    {
                        mysql_est = "insert into tb_nai_estatistica(id_interno, id_plantao,  LOCAL_DT, SERVER_DT , sys_id_insert) values ( '" + idSecri + "', '" + plantaoMod + "',  '" + plantao + "', '" + plantao + "', '" + idUsu + "')";

                    }
                    else if (!String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                    {
                        mysql_est = "insert into tb_nai_estatistica(id_interno, id_plantao, LOCAL_DT, SERVER_DT , sys_id_insert ) values ( '" + nSipia + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "', '" + idUsu + "')";

                    }
                    else if (!String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                    {
                        mysql_est = "insert into tb_nai_estatistica(id_interno, id_plantao,  LOCAL_DT, SERVER_DT , sys_id_insert ) values ( '" + nCpf + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "', '" + idUsu + "')";

                    }
                    else if (String.IsNullOrEmpty(nSipia) && !String.IsNullOrEmpty(nCpf) && String.IsNullOrEmpty(idSecri))
                    {
                        mysql_est = "insert into tb_nai_estatistica(id_interno, id_plantao,  LOCAL_DT, SERVER_DT , sys_id_insert ) values ( '" + nCpf + "', '" + plantaoMod + "', '" + plantao + "', '" + plantao + "', '" + idUsu + "')";
                    }
                    else
                    {
                        mysql_est = "insert into tb_nai_estatistica(id_interno, id_plantao,  LOCAL_DT, SERVER_DT , sys_id_insert ) values ( '" + idSecri + "', '" + plantaoMod + "',  '" + plantao + "', '" + plantao + "', '" + idUsu + "')";
                    }
                }
            MySqlCommand cmdCommand_est = new MySqlCommand(mysql_est, cConexao);

            try
            {


                int x = cmdCommand_est.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();




        }
        /*********************************************************************************************************************************************/
        /****************************** INSERE O ADOLESCENTE NA TB FLAGRANTE E dá update na tb_nai_cadastro  ***************************************************************/
        /*********************************************************************************************************************************************/
        public static void insereAdolescente_flagrante(string idAdole, string plantaoAdole, string plantaoForm, int idFlag)
        {
            string id = idAdole;
            string plantao = plantaoAdole;
            string plantaoF = plantaoForm;
            int idMax = 0;
            int idFla = idFlag;
            
            string mysql = "";
            DataSet dt = SelecionaAdolescenteId_flagrante(id, plantaoF);
            foreach(DataRow pRow in dt.Tables[0].Rows)
            {
                try { idFla = pRow.Field<int>("id_flagrante"); } catch { }
            }
            if (idFla == 0)
            {

                string sqlId = "select max(id_flagrante) as maxId from tb_nai_flagrante; ";
                cConexao = new MySqlConnection(strConexao);


                MySqlDataAdapter oledbAdapt = new MySqlDataAdapter(sqlId, cConexao);
                DataSet dados = new DataSet();
                oledbAdapt.Fill(dados);
                foreach (DataRow pRow in dados.Tables[0].Rows)
                {
                    try { idMax = pRow.Field<int>("maxId"); } catch {  }
                        

                }
                idMax++;
                mysql = "INSERT INTO tb_nai_flagrante( id_flagrante, id_plantao, id_interno, LOCAL_DT_NAI, SERVER_DT_NAI) values(" + idMax + ", '"+ plantaoF + "', '" + idAdole + "', '" + plantaoAdole + "', '" + plantaoAdole + "') ;";

                dados.Clear();
            }
            else
            {
                if(idFla > 0)
                {
                    mysql = "INSERT INTO tb_nai_flagrante( id_flagrante, id_plantao, id_interno, LOCAL_DT_NAI, SERVER_DT_NAI) values(" + idFla + ", '" + plantaoF + "', '" + idAdole + "', '" + plantaoAdole + "', '" + plantaoAdole + "') ;";
                }
            }
            
            
            cConexao = new MySqlConnection(strConexao);
           
            
            cConexao.Open();

            MySqlCommand cmdCommandNai = new MySqlCommand(mysql, cConexao);
            
            try
            {


                int x = cmdCommandNai.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Inseriu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
           
        }
        public static void insereAdolescente_flagrante_0(string idAdole, string plantaoAdole, string plantaoForm)
        {
            string id = idAdole;
            string plantao = plantaoAdole;
            string plantaoF = plantaoForm;
            int idMax = 0;
           

            cConexao = new MySqlConnection(strConexao);
            string mysql = "INSERT INTO tb_nai_flagrante( id_flagrante, id_plantao, id_interno, LOCAL_DT_NAI, SERVER_DT_NAI) values(" + idMax + ", '"+ plantaoF + "', '" + idAdole + "', '" + plantaoAdole + "', '" + plantaoAdole + "') ;";
            cConexao.Open();

            MySqlCommand cmdCommandNai = new MySqlCommand(mysql, cConexao);

            try
            {


                int x = cmdCommandNai.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Inseriu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();

        }

        /*********************************************************************************************************************************************/
        /******************************ATUALIZA ADOLESCENTE EFETIVO  ***************************************************************/
        /*********************************************************************************************************************************************/
        public static void updateAdolescente_Efetivo(string idInterno, string plantaoI, string alaI, int quartoI, string idUsua, string plantaoF)
        {
            string id = idInterno;
            string plantao = plantaoI;
            string ala = alaI;
            string plantaoForm = plantaoF;
            int quarto = quartoI;
            string idUsu = idUsua;
            
            cConexao = new MySqlConnection(strConexao);
            string mysql = "update tb_nai_efetivos set ala_efetivo='"+ ala +"', quarto_efetivo=" + quarto+", no_quarto=1 where id_interno='"+ id + "' and id_plantao='"+ plantaoForm + "' ;";
            cConexao.Open();

            MySqlCommand cmdCommandNai = new MySqlCommand(mysql, cConexao);

            try
            {


                int x = cmdCommandNai.ExecuteNonQuery();
                if (x == 1)
                {
                   // MessageBox.Show("Inseriu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();

        }
        /*********************************************************************************************************************************************/
        /****************************** NÃO DELETA SÓ MUDA O STATUS PRA INVISÍVEL  **************************************************************************/
        /*********************************************************************************************************************************************/
        public static int deletaAdolescente(string idInterno, string plantaoI, string idUsu)
        {
            string id = idInterno;
            string plantao = plantaoI;
            string user = idUsu;
            Plantao plt = new Plantao();
            string sysDt = plt.GetPlantaoSys();

            int x = 0;
            //TB_NAI_INTERNO
            cConexao = new MySqlConnection(strConexao);
            string mysql = "update tb_nai_interno set SERVER_DT='" + sysDt + "', LOCAL_DT='" + sysDt + "', ativo_sys=0 where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            cConexao.Open();
            //MessageBox.Show(mysql);
            MySqlCommand cmdCommandNai = new MySqlCommand(mysql, cConexao);

            try
            {


                x = cmdCommandNai.ExecuteNonQuery();
                if (x == 1)
                {
                   // MessageBox.Show("Excluiu tb_interno!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
           
            //TB_NAI_FLAGRANTE
            cConexao = new MySqlConnection(strConexao);
            string mysql_fla = "update tb_nai_flagrante set SERVER_DT_NAI='" + sysDt + "', LOCAL_DT_NAI='" + sysDt + "', ativo_sys=0 where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            //MessageBox.Show(mysql_fla);
            cConexao.Open();

            MySqlCommand cmdCommandNai_fla = new MySqlCommand(mysql_fla, cConexao);

            try
            {


                x = cmdCommandNai_fla.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Excluiu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
            //TB_NAI_EFETIVOS
            cConexao = new MySqlConnection(strConexao);
            string mysql_ef = "update tb_nai_efetivos set SEVER_DT_NAI='" + sysDt + "', LOCAL_DT='" + sysDt + "', ativo_sys=0 where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            cConexao.Open();
            //MessageBox.Show(mysql_ef);
            MySqlCommand cmdCommandNai_efe = new MySqlCommand(mysql_ef, cConexao);

            try
            {


                x = cmdCommandNai_efe.ExecuteNonQuery();
                if (x == 1)
                {
                     //MessageBox.Show("excluiu efetivos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
            //TB_NAI_CADASTRO
            cConexao = new MySqlConnection(strConexao);
            string mysql_cad = "update tb_nai_cadastro set SERVER_DT_NAI='" + sysDt + "', LOCAL_DT_NAI='" + sysDt + "', ativo_sys=0 where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            cConexao.Open();
            //MessageBox.Show(mysql_cad);
            MySqlCommand cmdCommandNai_cad = new MySqlCommand(mysql_cad, cConexao);

            try
            {


                x = cmdCommandNai_cad.ExecuteNonQuery();
                if (x == 1)
                {
                     //MessageBox.Show("excluiu tb cadastro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
            //TB_NAI_ESTATISTICA
            cConexao = new MySqlConnection(strConexao);
            string mysql_est = "update tb_nai_estatistica set SERVER_DT='" + sysDt + "', LOCAL_DT='" + sysDt + "', ativo_sys=0 where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            cConexao.Open();
            //MessageBox.Show(mysql_est);
            MySqlCommand cmdCommandNai_est = new MySqlCommand(mysql_est, cConexao);

            try
            {


                x = cmdCommandNai_est.ExecuteNonQuery();
                if (x == 1)
                {
                    // MessageBox.Show("Inseriu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
            //TB_NAI_MODULO
            cConexao = new MySqlConnection(strConexao);
            string mysql_mod = "update tb_nai_modulo set SERVER_DT_NAI='" + sysDt + "', LOCAL_DT_NAI='" + sysDt + "', ativo_sys=0 where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            cConexao.Open();
            //MessageBox.Show(mysql_mod);
            MySqlCommand cmdCommandNai_mod = new MySqlCommand(mysql_mod, cConexao);

            try
            {


                x = cmdCommandNai_mod.ExecuteNonQuery();
                if (x == 1)
                {
                    // MessageBox.Show("Inseriu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
            //documenta tb_trigger
            int idMax = 0;
            string sqlId = "select max(id_update) as id_max from tb_nai_trigger; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(sqlId, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            foreach (DataRow pRow in dados.Tables[0].Rows)
            {
                try { idMax = pRow.Field<int>("id_max"); } catch { }
                idMax++;

            }
            cConexao = new MySqlConnection(strConexao);
            string mysql_trigger = "insert into tb_nai_trigger(id_update, id_user, id_interno, plantao_interno, id_plantao) values(" + idMax + ", '" + idUsu + "', '" + id + "', '" + plantao + "', '" + plantao + "')";
            cConexao.Open();

            MySqlCommand cmdCommandNai_trig = new MySqlCommand(mysql_trigger, cConexao);

            try
            {


                x = cmdCommandNai_trig.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
            return x;




        }
        /*********************************************************************************************************************************************/
        /****************************** UPDATE OUTRAS ENTRADAS  ***************************************************************/
        /*********************************************************************************************************************************************/
        public static int update_OutrasEntradas(string idInterno, string plantaoI, string nomeInt, string idUsua, string OutEntr)
        {
            string id = idInterno;
            string plantao = plantaoI;
            string nomeI = nomeInt;
            string outraEntrada = OutEntr;
            string idUsu = idUsua;
            Plantao plt = new Plantao();
            string sysDt = plt.GetPlantaoSys();
            int x = 0;

            cConexao = new MySqlConnection(strConexao);
            string mysql = "update tb_nai_interno set SERVER_DT='"+ sysDt +"', LOCAL_DT='"+ sysDt + "', outros_ent='" + outraEntrada + "' where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            cConexao.Open();

            MySqlCommand cmdCommandNai = new MySqlCommand(mysql, cConexao);

            try
            {


                 x = cmdCommandNai.ExecuteNonQuery();
                if (x == 1)
                {
                    // MessageBox.Show("Inseriu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();

            cConexao = new MySqlConnection(strConexao);
            string mysql_cad = "update tb_nai_cadastro set SERVER_DT_NAI='" + sysDt + "', LOCAL_DT_NAI='" + sysDt + "', outros_ent='" + outraEntrada + "' where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            cConexao.Open();

            MySqlCommand cmdCommandNai_cad = new MySqlCommand(mysql_cad, cConexao);

            try
            {


                 x = cmdCommandNai_cad.ExecuteNonQuery();
                if (x == 1)
                {
                    // MessageBox.Show("Inseriu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
            cConexao = new MySqlConnection(strConexao);
            string mysql_est = "update tb_nai_estatistica set SERVER_DT='" + sysDt + "', LOCAL_DT='" + sysDt + "', outros_ent='" + outraEntrada + "' where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            cConexao.Open();

            MySqlCommand cmdCommandNai_est = new MySqlCommand(mysql_est, cConexao);

            try
            {


                x = cmdCommandNai_est.ExecuteNonQuery();
                if (x == 1)
                {
                    // MessageBox.Show("Inseriu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
            cConexao = new MySqlConnection(strConexao);
            string mysql_mod = "update tb_nai_modulo set SERVER_DT_NAI='" + sysDt + "', LOCAL_DT_NAI='" + sysDt + "', outros_ent='" + outraEntrada + "' where id_interno='" + id + "' and id_plantao='" + plantaoI + "' ;";
            cConexao.Open();

            MySqlCommand cmdCommandNai_mod = new MySqlCommand(mysql_mod, cConexao);

            try
            {


                x = cmdCommandNai_mod.ExecuteNonQuery();
                if (x == 1)
                {
                    // MessageBox.Show("Inseriu tb_flagrante!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();

            int idMax = 0;
            string sqlId = "select max(id_update) as id_max from tb_nai_trigger; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(sqlId, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            foreach (DataRow pRow in dados.Tables[0].Rows)
            {
                try { idMax = pRow.Field<int>("id_max"); } catch { }
                idMax++;

            }
            cConexao = new MySqlConnection(strConexao);
            string mysql_trigger = "insert into tb_nai_trigger(id_update, id_user, id_interno, plantao_interno, id_plantao) values(" + idMax + ", '" + idUsu + "', '" + id + "', '" + plantao + "', '"+plantao+"')";
                cConexao.Open();

            MySqlCommand cmdCommandNai_trig = new MySqlCommand(mysql_trigger, cConexao);

            try
            {


                 x = cmdCommandNai_trig.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
            return x;

        }
        /***********************************************************************************************************/
        /****************************** SELECIONA TODOS OS ADOLESCENTES DO PLANTÃO *********************************/
        /***********************************************************************************************************/
        public static DataSet SelecionaAdolescente_plantao_docs()
        {
            Plantao pltd = new Plantao();
            string plantao = pltd.GetPlantaoForm();
            string mysql = "select * from tb_nai_interno left join( tb_nai_cadastro left join tb_nai_documento_adolescente on tb_nai_cadastro.id_interno=tb_nai_documento_adolescente.id_interno) on tb_nai_interno.id_interno=tb_nai_cadastro.id_interno where (tb_nai_cadastro.id_plantao='" + plantao + "' or status_unidade_cad=8) and tb_nai_interno.ativo_sys=1 order by tb_nai_interno.SERVER_DT  ; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;


        }
        /***********************************************************************************************************/
        /****************************** SELECIONA TODOS OS ADOLESCENTES DO PLANTÃO *********************************/
        /***********************************************************************************************************/
        public static DataSet SelecionaAdolescente_plantao()
        {
            Plantao pltd = new Plantao();
            string plantao = pltd.GetPlantaoForm();
            string mysql = "select * from tb_nai_interno left join tb_nai_cadastro on tb_nai_interno.id_interno=tb_nai_cadastro.id_interno where (tb_nai_cadastro.id_plantao='" + plantao + "' or status_unidade_cad=8) and tb_nai_interno.ativo_sys=1 order by tb_nai_interno.SERVER_DT  ; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;


        }
        /***********************************************************************************************************/
        /****************************** SELECIONA OS ADOLESCENTES COM FLAGRANTE ************************************/
        /***********************************************************************************************************/
        public static DataSet SelecionaAdolescente_flagrante()
        {
            Plantao pltd = new Plantao();
            string plantao = pltd.GetPlantaoForm();
            string mysql = "select * from tb_nai_interno right join( tb_nai_cadastro right join tb_nai_flagrante on tb_nai_cadastro.id_interno=tb_nai_flagrante.id_interno) on tb_nai_interno.id_interno=tb_nai_flagrante.id_interno where (tb_nai_flagrante.id_plantao= '" + plantao + "' or status_unidade_cad=8) and tb_nai_flagrante.id_flagrante <> 0 and tb_nai_interno.ativo_sys=1  ; ";
            //MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;


        }
        /***********************************************************************************************************/
        /****************************** SELECIONA ADOLESCENTE ESPECÍFICO POR FLAGRANTE *****************************/
        /***********************************************************************************************************/
        public static DataSet SelecionaAdolescenteId_flagrante(string idAdole, string plantaoAdole)
        {
            
            string id = idAdole;
            string plantao = plantaoAdole;
            string mysql = "select * from tb_nai_interno right join( tb_nai_cadastro right join tb_nai_flagrante on tb_nai_cadastro.id_interno=tb_nai_flagrante.id_interno) on tb_nai_interno.id_interno=tb_nai_flagrante.id_interno where ((tb_nai_flagrante.id_plantao = '" + plantao + "') or status_unidade_cad=8) and tb_nai_flagrante.id_interno = '" + id + "'  and tb_nai_interno.ativo_sys=1 ; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;


        }
        /***********************************************************************************************************/
        /****************************** SELECIONA O ADOLESCENTE REFERENTE AO ID*******************************/
        /***********************************************************************************************************/
        public static DataSet SelecionaAdolescente_ID(string idAdole, string plantao)
        {
            string plantaoI = plantao;
            string id = idAdole;
            string mysql = "select * from tb_nai_interno inner join ((tb_nai_cadastro inner join  tb_nai_modulo on tb_nai_cadastro.id_interno =tb_nai_modulo.id_interno  ) left join tb_nai_efetivos on tb_nai_cadastro.id_interno=tb_nai_efetivos.id_interno ) on tb_nai_interno.id_interno=tb_nai_modulo.id_interno where tb_nai_interno.id_interno = '" + id + "' and (tb_nai_interno.id_plantao='" + plantaoI + "' or status_unidade_cad=8 ) and tb_nai_interno.ativo_sys=1; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            return dados;


        }
        /***********************************************************************************************************/
        /****************************** SELECIONA O ADOLESCENTE REFERENTE AO PLANTÃO *******************************/
        /***********************************************************************************************************/
        public static DataSet SelecionaAdolescente(string nome, string plantao)
        {
            string plantaoI = plantao;
            string bNome = nome;
            string mysql = "select * from tb_nai_interno inner join ((tb_nai_cadastro inner join tb_nai_modulo on tb_nai_cadastro.id_interno=tb_nai_modulo.id_interno) left join tb_nai_flagrante on tb_nai_cadastro.id_interno=tb_nai_flagrante.id_interno )  on tb_nai_interno.id_interno=tb_nai_modulo.id_interno where nome_interno = '" + bNome + "' and( tb_nai_interno.id_plantao='" + plantaoI + "' or status_unidade_cad=8 ) and tb_nai_interno.ativo_sys=1 ; ";
            //MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            return dados;


        }
        /***********************************************************************************************************/
        /****************************** SELECIONA O ADOLESCENTE ANTES DE INSERIR NO BANCO **************************/
        /***********************************************************************************************************/
       /* public static DataSet SelecionaAdolescente_bofore(string nomeI, string sipiaI, string cpfI)
        {
            string nome = plantao;
            string sipia = nome;
            string cpf = "select * from tb_nai_interno inner join ((tb_nai_cadastro inner join tb_nai_modulo on tb_nai_cadastro.id_interno=tb_nai_modulo.id_interno) inner join tb_nai_flagrante on tb_nai_cadastro.id_interno=tb_nai_flagrante.id_interno )  on tb_nai_interno.id_interno=tb_nai_modulo.id_interno where nome_interno = '" + bNome + "' and( SERVER_DT='" + plantaoI + "' or status_unidade_cad=8 )  ; ";
            // MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            return dados;


        }*/
        /***********************************************************************************************************/
        /****************************** SELECIONA O ADOLESCENTE ESPECÍFICO  ****************************************/
        /***********************************************************************************************************/
        public static DataSet SelecionaAdolescente_Especifico(string nome, string plantao, string idAdo)
        {
            string plantaoI = plantao;
            string bNome = nome;
            string id = idAdo;
            string mysql = "select * from tb_nai_interno inner join (tb_nai_modulo inner join tb_nai_cadastro on tb_nai_modulo.id_interno=tb_nai_cadastro.id_interno) on tb_nai_interno.id_interno=tb_nai_modulo.id_interno where nome_interno = '" + bNome + "' and (SERVER_DT='" + plantaoI + "' or status_unidade_cad=8 ) and tb_nai_modulo.id_interno='" + id + "' and tb_nai_interno.ativo_sys=1   ; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            return dados;


        }
        /***********************************************************************************************************/
        /****************************** SELECIONA OS DADOS DA TB_NAI_CADASTRO  *************************************/
        /***********************************************************************************************************/
        public static DataSet selecionaAdolescente_NAI_entrada(string nome, string sipia, string cpf, string plantao)
        {
            //MessageBox.Show(sipia);
            string cpfIn = cpf;
            string nSipia = sipia;
            string name = nome;
            string plantaoI = plantao;
            string mysql = "";
            //MessageBox.Show(name);
            //MessageBox.Show(cpfIn);
            //MessageBox.Show(nSipia);

            if (String.IsNullOrEmpty(nSipia) && String.IsNullOrEmpty(cpfIn))
            {
               // MessageBox.Show(name + "- sipia e cpf vazio");
                mysql = "select * from tb_nai_cadastro where id_interno = '" + name + "' and (id_plantao='" + plantaoI + "' or status_unidade_cad=8) and ativo_sys=1   ;";
            }
            else
            {
                if (!String.IsNullOrEmpty(cpfIn) && !String.IsNullOrEmpty(nSipia))
                {
                    //MessageBox.Show("TEM CPF E tem sipia");
                    mysql = "select * from tb_nai_cadastro where id_interno = '" + cpfIn + "' and (id_plantao='" + plantaoI + "' or status_unidade_cad=8) and ativo_sys=1  ;";
                }
                else if (String.IsNullOrEmpty(cpfIn) && !String.IsNullOrEmpty(nSipia))
                {
                    //MessageBox.Show("tem  sipia");
                    mysql = "select * from tb_nai_cadastro where id_interno = '" + nSipia + "' and (id_plantao='" + plantaoI + "' or status_unidade_cad=8) and ativo_sys=1   ;";
                }
                else
                {
                    //MessageBox.Show("tem cpf ");
                    mysql = "select * from tb_nai_cadastro where id_interno = '" + cpfIn + "' and (id_plantao='" + plantaoI + "' or status_unidade_cad=8) and ativo_sys=1  ;";
                }
            }

            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            return dados;

        }
        /*********************************************************************************************************************************************/
        /****************************** INSERE A IMAGEM DO ADOLESCEENTE EM BLOOB NO BANCO DE DADOS  **************************************************/
        /*********************************************************************************************************************************************/
        public static void insereFotoAdolescente(string idAdole, string plantaoAdole, byte[] img)
        {
            string id = idAdole;
            string plantao = plantaoAdole;
            byte[] foto = img;
            cConexao = new MySqlConnection(strConexao);
            string mysql = "update tb_nai_interno set foto = @img_binary where id_plantao='" + plantao+"' and id_interno='"+idAdole +"' ;";
            cConexao.Open();

            MySqlCommand cmdCommandNai = new MySqlCommand(mysql, cConexao);
            cmdCommandNai.Parameters.AddWithValue("@img_binary", img);
            try
            {


                int x = cmdCommandNai.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Imagem inserida com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /*********************************************************************************************************************************************/
        /****************************** ATUALIZA DADOS DA tb_nai_interno E TB_ADOLESCENTE PLANTÃO DE UM ADOLESCENTE  *************************************/
        /*********************************************************************************************************************************************/

        public static void UpdateAdolescente_plantao(string idInt, string nome, string sipiaN, string cpf, string plantaoI, Image imag, string idUsuU, string idSe)
        {
            Auxiliar aux = new Auxiliar();
            Plantao plt = new Plantao();
            string cpfIn = cpf;
            string sipia = sipiaN;
            string name = nome;
            string idSecri = idSe;
            string plantaoInt = plantaoI;
           
            Image img = imag;
            string idUsu = idUsuU;
          
            string id = idInt;
            string nameP = "";
            string plantaoIntP ="";
            string idIntP = "";
            string slDT = plt.GetPlantaoSys();
            string plantaoSys = "";
           
           
            DataSet dt = SelecionaAdolescente_ID(idInt, plantaoInt);
            foreach(DataRow pRow in dt.Tables[0].Rows)
            {
                try
                {
                    idIntP = pRow.Field<string>("id_interno");
                    nameP = pRow.Field<string>("nome_interno");
                    plantaoIntP = pRow.Field<string>("id_plantao");

                    plantaoSys = pRow.Field<string>("SERVER_DT");
                    //MessageBox.Show(idIntP);
                }
                catch
                {

                }
            }
           
               


            byte[] photp = ImageConvert.ImageToByteArray(img);
            //UPDATE TB_NAI_INTERNO
            cConexao = new MySqlConnection(strConexao);
            string mysql = "";
            if (!String.IsNullOrEmpty(idSecri))
            {
                mysql = "update  tb_nai_interno SET  nome_interno='" + name + "',  cpf_interno = '" + cpfIn + "' , cod_sipia='" + sipia + "', SERVER_DT='"+ slDT +"', LOCAL_DT='"+ slDT+"',  foto=@foto  WHERE `id_interno`='" + idIntP + "' and id_plantao='" + plantaoInt + "' ;";
            }
            else
            {
                if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysql = "update tb_nai_interno set   nome_interno='" + name + "', foto=@foto, id_interno='" + name + "' where  id_plantao='" + plantaoInt + "' and id_interno='" + idIntP + "' ";
                    //MessageBox.Show(mysql);

                }
                else
                {
                    if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                    {
                        mysql = "update  tb_nai_interno SET  nome_interno='" + name + "',  id_interno='" + cpfIn + "',  cpf_interno = '" + cpfIn + "' , cod_sipia='" + sipia + "',  foto=@foto  WHERE `id_interno`='" + idIntP + "' and id_plantao='" + plantaoInt + "' ;";

                    }
                    else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                    {
                        mysql = "update tb_nai_interno set  id_interno='" + sipia + "', nome_interno ='" + name + "', cod_sipia='" + sipia + "', foto=@foto where nome_interno='" + nameP + "' and id_plantao='" + plantaoInt + "' and id_interno='" + idIntP + "'; ";

                    }
                    else
                    {
                        mysql = "update tb_nai_interno set  id_interno='" + cpfIn + "', nome_interno ='" + name + "', cpf_interno = '" + cpfIn + "' , cod_sipia='" + sipia + "', foto=@foto where nome_interno='" + nameP + "' and id_plantao='" + plantaoInt + "' and id_interno='" + idIntP + "'; ";

                    }
                }
            }

           
            cConexao.Open();
            MySqlCommand cmdCommand = new MySqlCommand(mysql, cConexao);
            cmdCommand.Parameters.AddWithValue("@foto", photp);
            try
            {

                int x = cmdCommand.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados alterados com sucesso! Tipo nome");
                }
                else
                {
                    //MessageBox.Show("Que isso?");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //cConexao.Close();
            //UPDATE TB_NAI_CADASTRO
            string mysqlNai = "";
            if (!String.IsNullOrEmpty(idSecri))
            {
                mysqlNai = "update tb_nai_cadastro set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='"+ slDT+"', sys_id_update_cad='" + idUsu + "' where id_interno = '" + idIntP + "' and id_plantao='" + plantaoInt + "' ;";
            }
            else
            {
                if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysqlNai = "update tb_nai_cadastro set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='" + slDT + "', id_interno='" + name + "',  sys_id_update_cad='" + idUsu + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";

                }
                else
                {
                    if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                    {
                        mysqlNai = "update tb_nai_cadastro set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='" + slDT + "', id_interno = '" + cpfIn + "',  sys_id_update_cad='" + idUsu + "' where (id_interno = '" + idIntP + "' or id_interno='" + cpfIn + "' or id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "' ;";
                    }
                    else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                    {
                        mysqlNai = "update tb_nai_cadastro set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='" + slDT + "', id_interno = '" + sipia + "',  sys_id_update_cad='" + idUsu + "' where (id_interno = '" + idIntP + "' or  id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "' ;";
                    }
                    else
                    {
                        mysqlNai = "update tb_nai_cadastro set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='" + slDT + "', id_interno = '" + cpfIn + "',  sys_id_update_cad='" + idUsu + "' where (id_interno = '" + idIntP + "' or  id_interno = '" + sipia + "' or id_interno='" + cpfIn + "') and id_plantao='" + plantaoInt + "' ;";
                    }

                }

            }

            //cConexao.Open();

            MySqlCommand cmdCommandNai = new MySqlCommand(mysqlNai, cConexao);
            //MessageBox.Show(mysqlNai);
            try
            {


                int x = cmdCommandNai.ExecuteNonQuery();
                if (x == 1)
                {
                   // MessageBox.Show("Dados alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        

           //cConexao.Close();
            //UPDATE TB_NAI_MODULO
           
            
            string mysqlCad = "";
            if (!String.IsNullOrEmpty(idSecri))
            {
                mysqlCad = "update tb_nai_modulo set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='" + slDT + "',  sis_user_update='" + idUsu + "' where id_interno='" + idIntP + "' and id_plantao='" + plantaoInt + "';";
            }
            else
            {
                if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysqlCad = "update tb_nai_modulo set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='" + slDT + "', id_interno='" + name + "', sis_user_update='" + idUsu + "' where id_interno='" + idIntP + "' and id_plantao='" + plantaoInt + "'  ;";

                }
                else
                {
                    if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                    {
                        mysqlCad = "update tb_nai_modulo set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='" + slDT + "', id_interno = '" + cpfIn + "', sis_user_update='" + idUsu + "' where (id_interno='" + idIntP + "' or id_interno='" + cpfIn + "' or id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "' ;";
                    }
                    else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                    {
                        mysqlCad = "update tb_nai_modulo set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='" + slDT + "', id_interno = '" + sipia + "',  sis_user_update='" + idUsu + "' where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "';";
                    }
                    else
                    {
                        mysqlCad = "update tb_nai_modulo set  LOCAL_DT_NAI='" + slDT + "', SERVER_DT_NAI='" + slDT + "', id_interno = '" + cpfIn + "',  sis_user_update='" + idUsu + "' where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "' or id_interno='" + cpfIn + "') and id_plantao='" + plantaoInt + "';";
                    }

                }
            }

           

            //cConexao.Open();

            MySqlCommand cmdCommandCad = new MySqlCommand(mysqlCad, cConexao);
            try
            {


                int x = cmdCommandCad.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //cConexao.Close();
            
            
            int idMax = 0;
            string sqlId = "select max(id_update) as id_max from tb_nai_trigger; ";
            cConexao = new MySqlConnection(strConexao);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(sqlId, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            foreach (DataRow pRow in dados.Tables[0].Rows)
            {
                try { idMax = pRow.Field<int>("id_max"); } catch { }
                idMax++;

            }

            dados.Clear();
            //INSERT TB_NAI_TRIGGER
            string mysql_trigger = "";
            if (!String.IsNullOrEmpty(idSecri))
            {
                mysql_trigger = "insert into tb_nai_trigger(id_update, id_user, id_interno, plantao_interno, id_plantao ) values ( " + idMax + ", '" + idUsu + "', '" + idSecri + "', '" + plantaoSys + "','" + plantaoInt + "')";
            }
            else
            {
                if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysql_trigger = "insert into tb_nai_trigger(id_update, id_user, id_interno, plantao_interno, id_plantao ) values ( " + idMax + ", '" + idUsu + "', '" + nome + "','" + plantaoSys + "' ,  '" + plantaoInt + "')";
                }
                else
                {
                    if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                    {
                        mysql_trigger = "insert into tb_nai_trigger(id_update, id_user, id_interno, plantao_interno, id_plantao ) values ( " + idMax + ", '" + idUsu + "', '" + cpfIn + "', '" + plantaoSys + "' ,'" + plantaoInt + "')";
                    }
                    else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                    {
                        mysql_trigger = "insert into tb_nai_trigger(id_update, id_user, id_interno, plantao_interno, id_plantao ) values ( " + idMax + ", '" + idUsu + "', '" + sipia + "','" + plantaoSys + "' ,'" + plantaoInt + "')";
                    }
                    else
                    {
                        mysql_trigger = "insert into tb_nai_trigger(id_update, id_user, id_interno, plantao_interno, id_plantao ) values ( " + idMax + ", '" + idUsu + "', '" + cpfIn + "', '" + plantaoSys + "','" + plantaoInt + "')";
                    }
                }
            }
           
            cConexao.Open();
            MySqlCommand cmdCommand_trigger = new MySqlCommand(mysql_trigger, cConexao);

            try
            {


                int x = cmdCommand_trigger.ExecuteNonQuery();
                if (x == 1)
                {
                   // MessageBox.Show("Dados alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            

            string mysqlPort = "";
            //UPDATE TB_NAI_VISITANTES
            if (!String.IsNullOrEmpty(idSecri))
            {
                mysqlPort = "update tb_nai_visitantes_entrada set LOCAL_DT='"+ slDT + "', SERVER_DT='"+ slDT + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";
            }
            else
            {
                if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysqlPort = "update tb_nai_visitantes_entrada set LOCAL_DT='" + slDT + "', SERVER_DT='" + slDT + "', id_interno= '" + name + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";

                }
                else
                {
                    if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                    {
                        mysqlPort = "update tb_nai_visitantes_entrada set LOCAL_DT='" + slDT + "', SERVER_DT='" + slDT + "', id_interno= '" + cpfIn + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";
                    }
                    else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                    {
                        mysqlPort = "update tb_nai_visitantes_entrada set LOCAL_DT='" + slDT + "', SERVER_DT='" + slDT + "', id_interno= '" + sipia + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";
                    }
                    else
                    {
                        mysqlPort = "update tb_nai_visitantes_entrada set LOCAL_DT='" + slDT + "', SERVER_DT='" + slDT + "', id_interno= '" + cpfIn + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";
                    }

                }
            }
            

            
            //cConexao = new MySqlConnection(strConexao);
            //cConexao.Open();

            MySqlCommand cmdCommandPort = new MySqlCommand(mysqlPort, cConexao);
            //MessageBox.Show(mysqlNai);
            try
            {


                int x = cmdCommandPort.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            //cConexao.Close();
            //UPDATE TB_NAI_ESTATISTICA
            //cConexao = new MySqlConnection(strConexao);
            string mysql_est = "";
            if (!String.IsNullOrEmpty(idSecri))
            {
                mysql_est = "update tb_nai_estatistica set  SERVER_DT='" + slDT + "', LOCAL_DT='"+ slDT + "'  where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "' or id_interno='" + cpfIn + "') and id_plantao='" + plantaoInt + "';";
            }
            else
            {
                if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysql_est = "update tb_nai_estatistica set SERVER_DT='" + slDT + "', LOCAL_DT='" + slDT + "', id_interno='" + name + "' where id_interno='" + idIntP + "' and id_plantao='" + plantaoInt + "'  ;";

                }
                else
                {
                    if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                    {
                        mysql_est = "update tb_nai_estatistica set  SERVER_DT='" + slDT + "', LOCAL_DT='" + slDT + "', id_interno = '" + cpfIn + "' where (id_interno='" + idIntP + "' or id_interno='" + cpfIn + "' or id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "' ;";
                    }
                    else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                    {
                        mysql_est = "update tb_nai_estatistica set  SERVER_DT='" + slDT + "', LOCAL_DT='" + slDT + "', id_interno = '" + sipia + "'  where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "';";
                    }
                    else
                    {
                        mysql_est = "update tb_nai_estatistica set  SERVER_DT='" + slDT + "', LOCAL_DT='" + slDT + "', id_interno = '" + cpfIn + "'  where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "' or id_interno='" + cpfIn + "') and id_plantao='" + plantaoInt + "';";
                    }

                }
            }
          

           
            
            //cConexao.Open();

            MySqlCommand cmdCommandEst = new MySqlCommand(mysql_est, cConexao);
            try
            {


                int x = cmdCommandEst.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //cConexao.Close();
            //UPDATE TB_NAI_TRIGGER
            string mysql_uptrig = "";

            if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
            {
                mysql_uptrig = "update tb_nai_trigger set id_interno='" + name + "' where id_interno='" + idIntP + "' and id_plantao='" + plantaoInt + "'  ;";

            }
            else
            {
                if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                {
                    mysql_uptrig = "update tb_nai_trigger set id_interno = '" + cpfIn + "' where (id_interno='" + idIntP + "' or id_interno='" + cpfIn + "' or id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "' ;";
                }
                else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysql_uptrig = "update tb_nai_trigger set id_interno = '" + sipia + "' where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "';";
                }
                else
                {
                    mysql_uptrig = "update tb_nai_trigger set id_interno = '" + cpfIn + "' where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "' or id_interno='" + cpfIn + "') and id_plantao='" + plantaoInt + "';";
                }

            }

            //cConexao.Open();

            MySqlCommand cmdCommandUptrig = new MySqlCommand(mysql_uptrig, cConexao);
            try
            {


                int x = cmdCommandUptrig.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //cConexao.Close();
            //UPDATE TB_NAI_EFETIVOS
            string mysql_upfetivos = "";
            if (!String.IsNullOrEmpty(idSecri))
            {
                mysql_upfetivos = "update tb_nai_efetivos set LOCAL_DT='"+ slDT + "', SEVER_DT_NAI='"+ slDT + "' where id_interno='" + idIntP + "'  and id_plantao='" + plantaoInt + "';";
            }

            if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
            {
                mysql_upfetivos = "update tb_nai_efetivos set LOCAL_DT='" + slDT + "', SEVER_DT_NAI='" + slDT + "', id_interno='" + name + "' where id_interno='" + idIntP + "' and id_plantao='" + plantaoInt + "'  ;";

            }
            else
            {
                if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                {
                    mysql_upfetivos = "update tb_nai_efetivos set LOCAL_DT='" + slDT + "', SEVER_DT_NAI='" + slDT + "', id_interno = '" + cpfIn + "' where (id_interno='" + idIntP + "' or id_interno='" + cpfIn + "' or id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "' ;";
                }
                else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysql_upfetivos = "update tb_nai_efetivos set LOCAL_DT='" + slDT + "', SEVER_DT_NAI='" + slDT + "', id_interno = '" + sipia + "' where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "';";
                }
                else
                {
                    mysql_upfetivos = "update tb_nai_efetivos set LOCAL_DT='" + slDT + "', SEVER_DT_NAI='" + slDT + "', id_interno = '" + cpfIn + "' where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "' or id_interno='" + cpfIn + "') and id_plantao='" + plantaoInt + "';";
                }

            }

            //cConexao.Open();

            MySqlCommand cmdCommandUpEfetivo = new MySqlCommand(mysql_upfetivos, cConexao);
            try
            {


                int x = cmdCommandUpEfetivo.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Dados TB_NAI_EFETIVOS alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //cConexao.Close();

            //UPDATE TB_NAI_PLANTAO_INTERNO
            string mysql_upPlantaoInt = "";
            if (!String.IsNullOrEmpty(idSecri))
            {
                
            }
            else
            {
                if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysql_upPlantaoInt = "update tb_nai_plantao_interno set id_interno='" + name + "' where id_interno='" + idIntP + "' and id_plantao='" + plantaoInt + "'  ;";

                }
                else
                {
                    if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                    {
                        mysql_upPlantaoInt = "update tb_nai_plantao_interno set id_interno = '" + cpfIn + "' where (id_interno='" + idIntP + "' or id_interno='" + cpfIn + "' or id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "' ;";
                    }
                    else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                    {
                        mysql_upPlantaoInt = "update tb_nai_plantao_interno set id_interno = '" + sipia + "' where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "') and id_plantao='" + plantaoInt + "';";
                    }
                    else
                    {
                        mysql_upPlantaoInt = "update tb_nai_efetivos set id_interno = '" + cpfIn + "' where (id_interno='" + idIntP + "' or  id_interno = '" + sipia + "' or id_interno='" + cpfIn + "') and id_plantao='" + plantaoInt + "';";
                    }

                }
                //cConexao.Open();

                MySqlCommand cmdCommandUpPlantaoInt = new MySqlCommand(mysql_upPlantaoInt, cConexao);
                try
                {


                    int x = cmdCommandUpPlantaoInt.ExecuteNonQuery();
                    if (x == 1)
                    {
                        //MessageBox.Show("Dados TB_NAI_EFETIVOS alterados com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

               

            }
            //cConexao.Close();
            //UPDATE TB_NAI_documento_ADOLESCENTE
            string mysqlDoc = "";
            if (!String.IsNullOrEmpty(idSecri))
            {
                mysqlDoc = "update tb_nai_documento_adolescente set LOCAL_DT='" + slDT + "', SERVER_DT='" + slDT + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";
            }
            else
            {
                if (String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                {
                    mysqlDoc = "update tb_nai_documento_adolescente set LOCAL_DT='" + slDT + "', SERVER_DT='" + slDT + "', id_interno= '" + name + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";

                }
                else
                {
                    if (!String.IsNullOrEmpty(sipia) && !String.IsNullOrEmpty(cpfIn))
                    {
                        mysqlDoc = "update tb_nai_documento_adolescente set LOCAL_DT='" + slDT + "', SERVER_DT='" + slDT + "', id_interno= '" + cpfIn + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";
                    }
                    else if (!String.IsNullOrEmpty(sipia) && String.IsNullOrEmpty(cpfIn))
                    {
                        mysqlDoc = "update tb_nai_documento_adolescente set LOCAL_DT='" + slDT + "', SERVER_DT='" + slDT + "', id_interno= '" + sipia + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";
                    }
                    else
                    {
                        mysqlDoc = "update tb_nai_documento_adolescente set LOCAL_DT='" + slDT + "', SERVER_DT='" + slDT + "', id_interno= '" + cpfIn + "' where id_interno = '" + idIntP + "'  and id_plantao='" + plantaoInt + "' ;";
                    }

                }
            }



            //cConexao = new MySqlConnection(strConexao);
            //cConexao.Open();

            MySqlCommand cmdCommandDoc = new MySqlCommand(mysqlDoc, cConexao);
            MessageBox.Show(mysqlDoc);
            //MessageBox.Show(mysqlNai);
            try
            {


                int x = cmdCommandDoc.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Documentos alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();

        }

        /*********************************************************************************************************************************************/
        /****************************** SELECIONA ALTERAÇÕES POR ADOLESCENTE  ***************************************************************************/
        /*********************************************************************************************************************************************/
        public static DataSet SelectAlteracoes( string idInterno, string plantaoA, string nomeInt)
        {
           
            string idInt = idInterno;
            string plantao = plantaoA;
            string nome = nomeInt;
            string mysql = "select * from tb_nai_trigger inner join tb_nai_interno on tb_nai_interno.id_plantao=tb_nai_trigger.id_plantao where (tb_nai_interno.id_interno = '" + idInt + "' or nome_interno='"+ nome + "' ) and plantao_interno='" + plantao + "' and ativo_sys=1 ";
            
            cConexao = new MySqlConnection(strConexao);
            cConexao.Open();
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            cConexao.Close();
            return dados;

        }
        public static DataSet SelectServidor(string idServ)
        {

            string id = idServ;
          
            string mysql = "select * from tb_usuario inner join (tb_servidores inner join tb_cargos on tb_servidores.id_cargo=tb_cargos.id_cargo) on tb_servidores.nome_serv=tb_usuario.s_nome where tb_usuario.id_cpf='"+id+"' ";

            cConexao = new MySqlConnection(strConexaoCoorp);
            cConexao.Open();
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            cConexao.Close();
            return dados;

        }
        /*********************************************************************************************************************************************/
        /****************************** SELECIONA ADOLESCENTES EFETIVOS NO MÓDULO  ************************************************************************/
        /*********************************************************************************************************************************************/
        public static DataSet SelectAdolescenteEfetivo()
        {
            Plantao plt = new Plantao();
            //string plantao = plt.GetPlantaoSysDay();
            string mysql = "select * from tb_nai_efetivos inner join ((tb_nai_interno inner join tb_nai_cadastro on tb_nai_interno.id_interno=tb_nai_cadastro.id_interno ) inner join tb_nai_motivo_entrada on tb_nai_motivo_entrada.id_motivo=tb_nai_cadastro.id_motivo_entrada ) on tb_nai_efetivos.id_interno=tb_nai_interno.id_interno where  no_quarto=1 and tb_nai_interno.ativo_sys=1 order by quarto_efetivo ; ";
            //MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            cConexao.Open();
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            cConexao.Close();
            return dados;

        }
        /*********************************************************************************************************************************************/
        /****************************** SELECT PARA O COMBOBOX EFETVOS  ************************************************************************/
        /*********************************************************************************************************************************************/
        public static DataSet SelectAdolescenteCombo_Efetivo()
        {
            Plantao plt = new Plantao();
            string plantao = plt.GetPlantaoForm();
            string mysql = "SELECT * FROM  db_subsis.tb_nai_interno left join (tb_nai_cadastro left join tb_nai_efetivos on tb_nai_cadastro.id_interno=tb_nai_efetivos.id_interno) on  tb_nai_efetivos.id_interno=tb_nai_interno.id_interno where (tb_nai_interno.id_plantao='" + plantao+ "' or status_unidade_cad=8) and tb_nai_interno.ativo_sys=1 ;";
            //MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            cConexao.Open();
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            cConexao.Close();
            return dados;

        }


        /*********************************************************************************************************************************************/
        /****************************** INSERE ADOLESCENTES EFETIVOS NO MÓDULO  ************************************************************************/
        /*********************************************************************************************************************************************/
        public static void InsertAdolescenteEfetivo(string idInterno, string plantaoInt, string alaInt, int quartoInt, string idUser, string plantaoF)
        {
            Plantao plt = new Plantao();
            string pltSys = plt.GetPlantaoSys();
            string idInt = idInterno;
            string plantao = plantaoInt;
            string ala = alaInt;
            int quarto = quartoInt;
            string idUsu = idUser;
            string plantaoFrm = plantaoF;
            string mysql = "INSERT INTO tb_nai_efetivos (id_interno, id_plantao, LOCAL_DT, SEVER_DT_NAI, ala_efetivo, quarto_efetivo, no_quarto ,sys_user_insert ) values('" + idInt + "','"+ plantaoF + "' , '"+ pltSys + "', '"+ pltSys + "', '"+ alaInt + "','"+ quarto + "',  1, '" + idUsu + "')";
            //MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            cConexao.Open();
            MySqlCommand cmdCommandNai = new MySqlCommand(mysql, cConexao);
           
            try
            {
                int x = cmdCommandNai.ExecuteNonQuery();
                if (x == 1)
                {
                    //MessageBox.Show("Interno inserido no quarto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            cConexao.Close();
            

        }
        /***********************************************************************************************************/
        /****************************** REMOVE O ADOLESCENTE DO QUARTO  ********************************************/
        /***********************************************************************************************************/
        public static int removeAdolescenteQuarto( string idAdole, string plantAdole, string idUser, string plantaoF)
        {
            string idInt = idAdole;
            string plantao = plantaoF; 
            string idPlantao = plantAdole; 
            

            string idUsu = idUser;
            string mysql = "update tb_nai_cadastro set status_unidade_cad=9 where id_interno='" + idAdole + "' and id_plantao='" + idPlantao + "'";

            cConexao = new MySqlConnection(strConexao);
            cConexao.Open();
            MySqlCommand cmdCommandNai = new MySqlCommand(mysql, cConexao);
            int x = 0;
           
            try
            {
                x = cmdCommandNai.ExecuteNonQuery();
                if (x == 1)
                {
                    x = 0;
                    cConexao.Close();
                    string mysql1 = "update tb_nai_efetivos set no_quarto=0 where id_interno='" + idAdole + "' and id_plantao='" + idPlantao + "'";

                    cConexao = new MySqlConnection(strConexao);
                    cConexao.Open();
                    MySqlCommand cmdCommandNai1 = new MySqlCommand(mysql1, cConexao);
                   
                    try
                    {
                       
                        x = cmdCommandNai1.ExecuteNonQuery();
                        if (x == 1)
                        {
                            cConexao.Close();
                            int idMax = 0;
                            string sqlId = "select max(id_update) as id_max from tb_nai_trigger; ";
                            cConexao = new MySqlConnection(strConexao);
                            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(sqlId, cConexao);
                            DataSet dados = new DataSet();
                            adoleAdapter.Fill(dados);
                           
                            foreach (DataRow pRow in dados.Tables[0].Rows)
                            {
                                try { idMax = pRow.Field<int>("id_max"); }catch { };

                                idMax++;

                            }

                            dados.Clear();
                            x = 0;
                            cConexao.Close();
                            string mysql2 = "insert into tb_nai_trigger(id_update, id_user, id_interno, plantao_interno, id_plantao ) values ( " + idMax + ", '" + idUsu + "', '" + idInt + "','"+ plantao + "' , '" + idPlantao + "')";

                            cConexao = new MySqlConnection(strConexao);
                            cConexao.Open();
                            MySqlCommand cmdCommandNai2 = new MySqlCommand(mysql2, cConexao);

                            try
                            {
                                x = cmdCommandNai2.ExecuteNonQuery();
                                if (x == 1)
                                {
                                    //MessageBox.Show("Adolescente removido no quarto!");
                                }
                            }
                            catch (Exception ex)
                            {
                               // MessageBox.Show(ex.ToString());
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                    }


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

           
           

           
          
            cConexao.Close();

            return x;

        }
        /*********************************************************************************************************************************************/
        /****************************** SELECIONA ADOLESCENTES EFETIVOS POR QUARTO E NOME  ************************************************************************/
        /*********************************************************************************************************************************************/
        public static DataSet SelectAdolescenteEfetivo_QuartoNome(string nomeA, int quartoA)
        {
            string nome = nomeA;
            int quarto = quartoA;
            
            string mysql = "select * from tb_nai_efetivos inner join tb_nai_interno  on tb_nai_efetivos.id_interno=tb_nai_interno.id_interno where quarto_efetivo="+quarto+" and nome_interno='"+nome+ "' and tb_nai_interno.ativo_sys=1 ;";
            //MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            cConexao.Open();
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            cConexao.Close();
            return dados;

        }
        /***********************************************************************************************************/
        /****************************** INSERE O DOCUMENTO DO ADOLESCENTE ******************************************/
        /***********************************************************************************************************/
        public static void insere_Doc_Adole(int idDoc, string plantaoDoc, string idIntDoc, string tipoDocEnt, string tipoDocSai, string motivo_ent, string numOrigemDoc, string numDestinoDoc, int apresentacaoDoc, int origem_doc_ent, string outraOriDoc, int destino_doc_sai, int org_dec_doc, int decisaoDoc, string n_processo_doc, string n_paai_doc, string outros_doc, string idUsuDoc)
        {
            Plantao plt = new Plantao();
            int idD = idDoc;
            string idPlantao = plantaoDoc;
            string idInt = idIntDoc;
            string tipoEnt = tipoDocEnt;
            string tipoSai = tipoDocSai;
            string sl_DT = plt.GetPlantaoSys();
            string motivo = motivo_ent;
            string numOrigem = numOrigemDoc;
            string numDestino = numDestinoDoc;
            int apresentacao = apresentacaoDoc;
            int origem = origem_doc_ent;
            string outraOri = outraOriDoc;
            int destino = destino_doc_sai;
            int orgaoDec = org_dec_doc;
            int decisao = decisaoDoc;
            string n_processo = n_processo_doc;
            string n_paai = n_paai_doc;
            string outrosDoc = outros_doc;
            string idUsu = idUsuDoc;
            string mysqlID = "select MAX(idC_doc) as maxIdC from tb_nai_documento_adolescente ;";
            int idC = 1;
            //MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            cConexao.Open();
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysqlID, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            foreach(DataRow pRow in dados.Tables[0].Rows)
            {
                try { idC = pRow.Field<int>("maxIdC"); } catch { }
                idC++;
            }

            string mysql = "insert into tb_nai_documento_adolescente(idC_doc, id_doc , id_plantao , id_interno , tipo_doc_ent, tipo_doc_sai, SERVER_DT , LOCAL_DT, motivo_ent, num_doc_origem , num_doc_destino , apresentacao , origem_doc_ent , destino_doc_sai , org_decisorio_doc , n_processo , n_paai , outros_doc , sys_id_insert, outra_origem_doc, decisao_doc ) values("+ idC + ", " + idD + ", '" + idPlantao + "', '" + idInt + "', '"+ tipoEnt + "', '"+ tipoSai + "', '"+ sl_DT + "', '"+ sl_DT + "', '"+ motivo +"', '"+ numOrigem + "', '"+ numDestino + "', "+ apresentacao + ", "+ origem +", "+ destino + ", "+ orgaoDec + ", '"+ n_processo + "', '"+ n_paai + "', '"+ outrosDoc + "', '"+ idUsu + "', '"+ outraOri + "', " + decisao + " ) ;";
            cConexao = new MySqlConnection(strConexao);
            //MessageBox.Show(mysql);

            MySqlCommand cmdCommand = new MySqlCommand(mysql, cConexao);

            try
            {
                cConexao.Open();

                int x = cmdCommand.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Documento inserido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
        }
        /***********************************************************************************************************/
        /****************************** ATUALIZA O DOCUMENTO DO ADOLESCENTE ******************************************/
        /***********************************************************************************************************/
        public static void UPDATE_Doc_Adole(int idC, int idDoc, string plantaoDoc, string idIntDoc, string tipoDocEnt, string tipoDocSai, string motivo_ent, string numOrigemDoc, string numDestinoDoc, int apresentacaoDoc, int origem_doc_ent, string outraOriDoc, int destino_doc_sai, int org_dec_doc, int decisaoDoc, string n_processo_doc, string n_paai_doc, string outros_doc, string idUsuDoc)
        {
            Plantao plt = new Plantao();
            int idD = idDoc;
            string idPlantao = plantaoDoc;
            string idInt = idIntDoc;
            string tipoEnt = tipoDocEnt;
            string tipoSai = tipoDocSai;
            string sl_DT = plt.GetPlantaoSys();
            string motivo = motivo_ent;
            string numOrigem = numOrigemDoc;
            string numDestino = numDestinoDoc;
            int apresentacao = apresentacaoDoc;
            int origem = origem_doc_ent;
            string outraOrigem = outraOriDoc;
            int destino = destino_doc_sai;
            int orgaoDec = org_dec_doc;
            int decisao = decisaoDoc;
            string n_processo = n_processo_doc;
            string n_paai = n_paai_doc;
            string outrosDoc = outros_doc;
            string idUsu = idUsuDoc;
            int idC_doc = idC;

            string mysql = "UPDATE tb_nai_documento_adolescente set tipo_doc_ent='"+ tipoEnt + "',  tipo_doc_sai='"+ tipoSai + "', SERVER_DT='"+ sl_DT + "' , LOCAL_DT='" + sl_DT + "', motivo_ent='"+ motivo + "' , num_doc_origem='"+ numOrigem + "' , outra_origem_doc='"+ outraOrigem + "', num_doc_destino='" + numDestino + "' , apresentacao="+apresentacao+" , origem_doc_ent="+ origem + " , destino_doc_sai="+ destino + " , org_decisorio_doc="+ orgaoDec + " , decisao_doc="+decisao+" ,n_processo='" + n_processo + "' , n_paai='"+ n_paai + "' , outros_doc='"+ outrosDoc + "'  where id_plantao='"+ idPlantao + "' and idC_doc=" + idC_doc + " and id_interno='"+ idInt + "';";
            //MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            cConexao.Open();
            MySqlCommand cmdCommand = new MySqlCommand(mysql, cConexao);

            try
            {
                int x = cmdCommand.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Documento atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro de SQL!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cConexao.Close();
        }
        /***********************************************************************************************************/
        /****************************** SELECIONA OS DOCUMENTOS POR ADOLESCENTE ************************************/
        /***********************************************************************************************************/
        public static DataSet selectDoc_Adolescente(string idInternoDoc, string idPlantaoDoc)
        {
            Plantao plt = new Plantao();
            string plantao = plt.GetPlantaoForm();
            string mysql = "SELECT * FROM  db_subsis.tb_nai_documento_adolescente where id_plantao='"+ idPlantaoDoc + "' and id_interno='"+ idInternoDoc +"' ;";
            //MessageBox.Show(mysql);
            cConexao = new MySqlConnection(strConexao);
            cConexao.Open();
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);
            cConexao.Close();
            return dados;

        }
    }

}

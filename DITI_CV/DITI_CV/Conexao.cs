using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Collections;

namespace DITI_CV
{
    public static class Conexao
    {
        private static OleDbConnection _gDatabase = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LIVROM.mdb");
        public static OleDbConnection DB_Database
        {
            get { return _gDatabase; }
            set { _gDatabase = value; }
        }
        private static OleDbDataAdapter _gAdapter = new OleDbDataAdapter();
        public static OleDbDataAdapter DB_Adapter
        {
            get { return _gAdapter; }
            set { _gAdapter = value; }
        }


        private static MySqlConnection _gDatabaseMySql = new MySqlConnection(" Persist Security Info=False;server=localhost; database=db_subsis_modulo;uid=root;pwd=");
        public static MySqlConnection DB_DatabaseMySql
        {
            get { return _gDatabaseMySql; }
            set { _gDatabaseMySql = value; }
        }
        private static MySqlDataAdapter _gAdapterMySql = new MySqlDataAdapter();
        public static MySqlDataAdapter DB_AdapterMySql
        {
            get { return _gAdapterMySql; }
            set { _gAdapterMySql = value; }
        }

        private static Boolean _vMYSQL = false;
        public static Boolean MYSQL
        {
            get { return _vMYSQL; }
            set { _vMYSQL = value; }
        }


        private static string _strConexao = "Persist Security Info=False;server=localhost; database=db_subsis_modulo;uid=root;pwd=";
        public static string strConexao
        {
            get { return _strConexao; }
            set { _strConexao = value; }
        }

        private static string _vMYSQL_SERVER = "localhost";
        public static string MYSQL_SERVER
        {
            get { return _vMYSQL_SERVER; }
            set { _vMYSQL_SERVER = value; }
        }
        private static string _vMYSQL_DB = "db_subsis_modulo";
        public static string MYSQL_DB
        {
            get { return _vMYSQL_DB; }
            set { _vMYSQL_DB = value; }
        }
        private static string _vMYSQL_USER = "root";
        public static string MYSQL_USER
        {
            get { return _vMYSQL_USER; }
            set { _vMYSQL_USER = value; }
        }
        private static string _vMYSQL_PASS = "";
        public static string MYSQL_PASS
        {
            get { return _vMYSQL_PASS; }
            set { _vMYSQL_PASS = value; }
        }


        //private static string strConexaoCoorp = "Persist Security Info=False;server=localhost; database=db_coorporativo;uid=root;pwd=";

        public static MySqlConnection cConexao { get; set; }

        public static void Conecta()
        {
            try
            {
                IniFile DITI_CV_IniFile = new IniFile("DITI_CV.ini");
                MYSQL_SERVER = DITI_CV_IniFile.IniReadString("LOCALDATABASE", "mysqlSERVER", "localhost1");
                MYSQL_DB = DITI_CV_IniFile.IniReadString("LOCALDATABASE", "mysqlDB", "db_subsis_modulo1");
                MYSQL_USER = DITI_CV_IniFile.IniReadString("LOCALDATABASE", "mysqlUSER", "mysqlUSER1");
                MYSQL_PASS = DITI_CV_IniFile.IniReadString("LOCALDATABASE", "mysqlPASS", "localhost1");
                strConexao = "Persist Security Info=False;server=" + MYSQL_SERVER + "; database=" + MYSQL_DB + ";uid=" + MYSQL_USER + ";pwd=" + MYSQL_PASS;
                cConexao = new MySqlConnection(strConexao);
                cConexao.Open();
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Desconecta()
        {
            try
            {
                cConexao.Close();
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public static class Consulta
    {
        public static DataSet Consultar(string sSQL)
        {
            try
            {
                DataSet vRecordSet = new DataSet();
                //MYSQL
                if (Conexao.MYSQL)
                {
                    try { Conexao.DB_DatabaseMySql.Close(); } catch { }
                    Conexao.DB_AdapterMySql = new MySqlDataAdapter(sSQL, Conexao.DB_DatabaseMySql);
                    //CONECTAR BANCO DE DADOS
                    Conexao.DB_DatabaseMySql.Open();
                    vRecordSet.Clear();
                    //preenche o dataset via adapter
                    Conexao.DB_AdapterMySql.Fill(vRecordSet);
                    Conexao.DB_DatabaseMySql.Close();
                }
                //ACCESS
                else
                {
                    try { Conexao.DB_Database.Close(); } catch { }
                    OleDbCommand vCommand = new OleDbCommand();
                    Conexao.DB_Adapter = new OleDbDataAdapter();
                    //CONECTAR BANCO DE DADOS
                    Conexao.DB_Database.Open();
                    vCommand.Connection = Conexao.DB_Database;
                    vCommand.CommandText = sSQL;
                    Conexao.DB_Adapter.SelectCommand = vCommand;
                    vRecordSet.Clear();
                    Conexao.DB_Adapter.Fill(vRecordSet);
                    Conexao.DB_Database.Close();
                }
                return vRecordSet;
            }
            catch { return null; }
            /*
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            */
        }

        public static int Executar(string sSQL, string sByteNome1, byte[] ByteArray1, string sByteNome2, byte[] ByteArray2)
        {
            int Resultado = 0;
            try
            {
                //MYSQL
                if (Conexao.MYSQL)
                {
                    try { Conexao.DB_DatabaseMySql.Close(); } catch { }
                    MySqlCommand vCommand1 = new MySqlCommand(sSQL, Conexao.DB_DatabaseMySql);
                    Conexao.DB_DatabaseMySql.Open();
                    Resultado = vCommand1.ExecuteNonQuery();
                    Conexao.DB_DatabaseMySql.Close();
                }
                //ACCESS
                else
                {
                    try { Conexao.DB_Database.Close(); } catch { }
                    OleDbCommand vCommand = new OleDbCommand();
                    //CONECTAR BANCO DE DADOS
                    Conexao.DB_Database.Open();
                    vCommand.Connection = Conexao.DB_Database;
                    vCommand.CommandText = sSQL;
                    if (sByteNome1 != "")
                        vCommand.Parameters.AddWithValue(sByteNome1, ByteArray1);
                    if (sByteNome2 != "")
                        vCommand.Parameters.AddWithValue(sByteNome2, ByteArray2);
                    Resultado = vCommand.ExecuteNonQuery();
                    Conexao.DB_Database.Close();
                }
            }
            catch { }
            /*
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            return Resultado;
        }

    }


}

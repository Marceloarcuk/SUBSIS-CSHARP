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

namespace DITI_LIVROM
{

    public class Usuario
    {
        private static string _nome = "";
        public static string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private static string _login = "";
        public static string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        private static string _id = "";
        public static string CPF
        {
            get { return _id; }
            set { _id = value; }
        }
    }

    public class Globais
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

        private static string _vDTSYS = "";
        public static string DataSistema
        {
            get { return _vDTSYS; }
            set { _vDTSYS = value; }
        }

        private static Boolean _vFotoClicada = false;
        public static Boolean FotoClicada
        {
            get { return _vFotoClicada; }
            set { _vFotoClicada = value; }
        }

        private static string _vUnidade = "01";
        public static string Unidade
        {
            get { return _vUnidade; }
            set { _vUnidade = value; }
        }

        private static string _vUnidade_Modulo = "01";
        public static string Modulo
        {
            get { return _vUnidade_Modulo; }
            set { _vUnidade_Modulo = value; }
        }

        private static string _vUnidade_Modulo_Plantao = "01";
        public static string Plantao
        {
            get { return _vUnidade_Modulo_Plantao; }
            set { _vUnidade_Modulo_Plantao = value; }
        }

        private static int _vTamanho = 1;
        public static int Tamanho
        {
            get { return _vTamanho; }
            set { _vTamanho = value; }
        }

        private static int _vTamanhoEx = 1;
        public static int TamanhoEx
        {
            get { return _vTamanhoEx; }
            set { _vTamanhoEx = value; }
        }

        //---------------------------------------------------------
        // CONVERTE BINARIO PARA IMAGEM 
        //---------------------------------------------------------
        public static byte[] ImageToByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        //---------------------------------------------------------
        // CONVERTE A IMAGEM PARA BINARIO
        //---------------------------------------------------------
        public static Image ByteArrayToImage(byte[] arrImg)
        {
            MemoryStream stmBLOBData;
            ImageConverter imgConv;
            Image result;
            try
            {
                stmBLOBData = new MemoryStream(arrImg);
                imgConv = new ImageConverter();
                result = (Image)imgConv.ConvertFrom(arrImg);
            }
            catch { result = null; }
            return result;
        }

        //---------------------------------------------------------
        // CONVERTE STRING PARA BINARIO
        //---------------------------------------------------------
        public static byte[] StringToByteArray(string x)
        {
            byte[] xByte = new byte[x.Length];
            xByte = System.Text.Encoding.UTF8.GetBytes(x);
            return xByte;
        }

        //---------------------------------------------------------
        // CONVERTE BINARIO PARA STRING 
        //---------------------------------------------------------
        public static string ByteArrayToString(byte[] x)
        {
            //RichTextBox RTFBox = new RichTextBox();
            var bytes = x;
            byte[] documento = new byte[0];
            documento = bytes;
            string originalRtf = System.Text.Encoding.UTF8.GetString(documento);
            return originalRtf;
        }


    }

    public static class cHint
    {
        public static void Exibir(Control _controle, string _texto)
        {
            // CRIAR HINT DA APLICAÇÃO
            ToolTip appHint = new ToolTip();
            appHint.AutoPopDelay = 4000;
            appHint.InitialDelay = 1000;
            appHint.ReshowDelay = 500;
            //appHint.IsBalloon = true;
            appHint.ShowAlways = true;
            appHint.SetToolTip(_controle, _texto);
        }

        private static Boolean _vJovens = true;
        public static Boolean Jovens
        {
            get { return _vJovens; }
            set { _vJovens = value; }
        }

        private static Boolean _vAcao = true;
        public static Boolean Acao
        {
            get { return _vAcao; }
            set { _vAcao = value; }
        }

        private static Boolean _vServidores = true;
        public static Boolean Servidores
        {
            get { return _vServidores; }
            set { _vServidores = value; }
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
                if (Globais.MYSQL)
                {
                    try { Globais.DB_DatabaseMySql.Close(); } catch { }
                    Globais.DB_AdapterMySql = new MySqlDataAdapter(sSQL, Globais.DB_DatabaseMySql);
                    //CONECTAR BANCO DE DADOS
                    Globais.DB_DatabaseMySql.Open();
                    vRecordSet.Clear();
                    //preenche o dataset via adapter
                    Globais.DB_AdapterMySql.Fill(vRecordSet);
                    Globais.DB_DatabaseMySql.Close();
                }
                //ACCESS
                else
                {
                    try { Globais.DB_Database.Close(); } catch { }
                    OleDbCommand vCommand = new OleDbCommand();
                    Globais.DB_Adapter = new OleDbDataAdapter();
                    //CONECTAR BANCO DE DADOS
                    Globais.DB_Database.Open();
                    vCommand.Connection = Globais.DB_Database;
                    vCommand.CommandText = sSQL;
                    Globais.DB_Adapter.SelectCommand = vCommand;
                    vRecordSet.Clear();
                    Globais.DB_Adapter.Fill(vRecordSet);
                    Globais.DB_Database.Close();
                }
                return vRecordSet;
            }
            catch (Exception ex)
            {
                //string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                //MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                //                "Procedimento: " + ex.TargetSite.Name + "\n" +
                //                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static int Executar(string sSQL, string sByteNome1, byte[] ByteArray1, string sByteNome2, byte[] ByteArray2)
        {
            int Resultado = 0;
            try
            {
                //MYSQL
                if (Globais.MYSQL)
                {
                    try { Globais.DB_DatabaseMySql.Close(); } catch { }
                    MySqlCommand vCommand1 = new MySqlCommand(sSQL, Globais.DB_DatabaseMySql);
                    Globais.DB_DatabaseMySql.Open();
                    Resultado = vCommand1.ExecuteNonQuery();
                    Globais.DB_DatabaseMySql.Close();
                }
                //ACCESS
                else
                {
                    try { Globais.DB_Database.Close(); } catch { }
                    OleDbCommand vCommand = new OleDbCommand();
                    //CONECTAR BANCO DE DADOS
                    Globais.DB_Database.Open();
                    vCommand.Connection = Globais.DB_Database;
                    vCommand.CommandText = sSQL;
                    if (sByteNome1 != "")
                        vCommand.Parameters.AddWithValue(sByteNome1, ByteArray1);
                    if (sByteNome2 != "")
                        vCommand.Parameters.AddWithValue(sByteNome2, ByteArray2);
                    Resultado = vCommand.ExecuteNonQuery();
                    Globais.DB_Database.Close();
                }
            }
            catch (Exception ex)
            {
                //string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                //MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                //                "Procedimento: " + ex.TargetSite.Name + "\n" +
                //                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Resultado;
        }

    }




}





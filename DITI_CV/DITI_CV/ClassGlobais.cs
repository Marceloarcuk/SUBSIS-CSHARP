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

namespace DITI_CV
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

        private static string _CPFUSER = "";
        public static string CPFUSER
        {
            get { return _CPFUSER; }
            set { _CPFUSER = value; }
        }


        private static TreeNode _BookMark = null;
        public static TreeNode BookMark
        {
            get { return _BookMark; }
            set { _BookMark = value; }
        }

        public static int CalcularIdade(DateTime DataNascimento)
        {
            int anos = DateTime.Now.Year - DataNascimento.Year;
            if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
                anos--;
            return anos;
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
    }




}





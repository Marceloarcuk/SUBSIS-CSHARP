using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Nai_Cadastro
{
    class StringConverter
    {

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
}

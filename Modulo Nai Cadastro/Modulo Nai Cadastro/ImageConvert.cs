using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;



namespace Modulo_Nai_Cadastro
{
    class ImageConvert
    { //---------------------------------------------------------
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
    }
}

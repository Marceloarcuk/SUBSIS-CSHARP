using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;
using Modulo_Nai_Cadastro;

namespace Modulo_Nai_Cadastro
{
    //Design by Pongsakorn Poosankam
    class Helper
    {

        public static Image SaveImageCapture(System.Drawing.Image image)
        {
            Image ima = image;
            MessageBox.Show("Imagem salva com sucesso!");
            return ima;

            /*SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Image";// Default file name
            s.DefaultExt = ".Jpg";// Default file extension
            s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

            // Show save file dialog box
            // Process save file dialog box results
            if (s.ShowDialog()==DialogResult.OK)
            {
                // Save Image
                string filename = s.FileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();

            }*/

        }
    }
}

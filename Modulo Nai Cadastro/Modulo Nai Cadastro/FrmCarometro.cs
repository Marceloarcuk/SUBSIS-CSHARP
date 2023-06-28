using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace Modulo_Nai_Cadastro
{
    public partial class FrmCarometro : Form
    {
        public FrmCarometro()
        {
            InitializeComponent();
        }
        [Flags]
        enum EmfToWmfBitsFlags
        {
            EmfToWmfBitsFlagsDefault = 0x00000000,
            EmfToWmfBitsFlagsEmbedEmf = 0x00000001,
            EmfToWmfBitsFlagsIncludePlaceable = 0x00000002,
            EmfToWmfBitsFlagsNoXORClip = 0x00000004
        }
        const int MM_ISOTROPIC = 7;
        const int MM_ANISOTROPIC = 8;
        [DllImport("gdiplus.dll")]
        private static extern uint GdipEmfToWmfBits(IntPtr _hEmf, uint _bufferSize,
        byte[] _buffer, int _mappingMode, EmfToWmfBitsFlags _flags);
        [DllImport("gdi32.dll")]
        private static extern IntPtr SetMetaFileBitsEx(uint _bufferSize,
            byte[] _buffer);
        [DllImport("gdi32.dll")]
        private static extern IntPtr CopyMetaFile(IntPtr hWmf,
            string filename);
        [DllImport("gdi32.dll")]
        private static extern bool DeleteMetaFile(IntPtr hWmf);
        [DllImport("gdi32.dll")]
        private static extern bool DeleteEnhMetaFile(IntPtr hEmf);

        private void FrmCarometro_Load(object sender, EventArgs e)
        {
            DataSet dt = Conexao.SelectAdolescenteEfetivo();
            
            int i = 0;
            int y = 0;
            RichTextBox rtb = new RichTextBox();
            Image imagens;
            foreach (DataRow pRow in dt.Tables[0].Rows)
            {
                byte[] img = pRow.Field<byte[]>("foto");
                imagens = ImageConvert.ByteArrayToImage(img);
                Metafile metafile = null;
               
                float dpiX; float dpiY;
                using (Graphics g = Graphics.FromImage(imagens)) 
                {
                    IntPtr hDC = g.GetHdc();
                    metafile = new Metafile(hDC, EmfType.EmfOnly);
                    g.ReleaseHdc (hDC);
                }

                using (Graphics g = Graphics.FromImage(metafile)) 
                {
                    g.DrawImage (imagens, 0, 0);
                    dpiX = g.DpiX;
                    dpiY = g.DpiY;
                }

                IntPtr _hEmf = metafile.GetHenhmetafile();
                uint _bufferSize = GdipEmfToWmfBits(_hEmf, 0, null, MM_ANISOTROPIC,
                EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);
                byte[] _buffer = new byte[_bufferSize];
                GdipEmfToWmfBits(_hEmf, _bufferSize, _buffer, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);
                IntPtr hmf = SetMetaFileBitsEx(_bufferSize, _buffer);
                string tempfile = Path.GetTempFileName();
                CopyMetaFile(hmf, tempfile);
                DeleteMetaFile(hmf);
                DeleteEnhMetaFile(_hEmf);

                var stream = new MemoryStream();
                byte[] data = File.ReadAllBytes(tempfile);

                int count = data.Length;
                stream.Write(data, 0, count);

                string proto = @"{\rtf1{\pict\wmetafile8\picw" + (int)(((float)imagens.Width / dpiX) * 2540)+ @"\pich" + (int)(((float)imagens.Height / dpiY) * 2540)+ @"\picwgoal" + (int)(((float)imagens.Width / dpiX) * 1440)+ @"\pichgoal" + (int)(((float)imagens.Height / dpiY) * 1440)+ " "+ BitConverter.ToString(stream.ToArray()).Replace("-", "")+ "}}";             
               
                try { rtb.Rtf =proto; } catch(Exception exc) { MessageBox.Show(exc.ToString()); }
                rtb.Rtf = rtb.Rtf+"                                                        ";
                

            }
            richTextBox1.Rtf = rtb.Rtf;


        }
            
    }
}
    


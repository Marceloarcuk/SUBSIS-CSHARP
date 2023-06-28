using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITI_CV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // CONFIGURAR APLICAÇÃO ATRAVÉS DO ARQUIVO .INI
            IniFile LIVROM_IniFile = new IniFile("DITI_CV.ini");
            //Globais.Unidade = LIVROM_IniFile.IniReadString("UNIDADE", "unidade", "01");
            //Globais.Modulo = LIVROM_IniFile.IniReadString("UNIDADE", "modulo", "01");

            Conexao.MYSQL = true;

            Application.Run(new sys_splash());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Modulo_Nai_Cadastro
{
    static class Program
    {
        public static string nomeUsu = "Claressa Dantas da Silva";
        public static string idusu = "00302861157";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Modulo_Nai_Cadastro.Form1(nomeUsu, idusu));
            //Application.Run(new mainWinForm(nomeAdole, PlantaoAdole));
            Application.Run(new Modulo_Nai_Cadastro.FormLogin());
        }
    }
}

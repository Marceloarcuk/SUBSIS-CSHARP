using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Nai_Cadastro
{
    class Plantao
    {
        private string plantao;
        private string plantSys;
        private string plantSysDay;
        private string plantaoSysPT;

        public Plantao()
        {
            
            plantao = DateTime.Now.ToString("dd/MM/yyyy");
            plantSys = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            plantaoSysPT = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            plantSysDay = DateTime.Now.ToString("yyyy-MM-dd");
            //MessageBox.Show(plantSys);
            //MessageBox.Show(plantSysDay);


        }
        public string GetPlantaoForm()
        {
            return plantao;
        }
        public string GetPlantaoSysPt()
        {
            return plantSysDay;
        }

        public string GetPlantaoSys()
        {
            return plantSys;
        }

        public string GetPlantaoSysDay()
        {
            return plantSysDay;
        }
    }
}

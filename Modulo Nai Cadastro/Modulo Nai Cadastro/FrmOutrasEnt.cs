using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Nai_Cadastro
{
    public partial class FrmOutrasEnt : Form
    {
        public FrmOutrasEnt(string idInt, string plantaoInt, string nomeInt, string idUser)
        {
            InitializeComponent();
            labelNomeAdo.Text = nomeInt;
            labelIdUsu.Text = idUser;
            labelIDPlantao.Text = plantaoInt;
            labelIdAdo.Text = idInt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int y = 0;
            y=Conexao.update_OutrasEntradas(labelIdAdo.Text, labelIDPlantao.Text, labelNomeAdo.Text, labelIdUsu.Text, txtOutros.Text);
            if (y == 1) { MessageBox.Show("Alteração feita com sucesso!"); }
            this.Close();
        }
    }
}

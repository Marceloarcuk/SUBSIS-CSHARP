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
    public partial class FrmAlteraSenha : Form
    {
        public FrmAlteraSenha(string idUsu, string nomeUsu)
        {
            InitializeComponent();
            usuName.Text = nomeUsu;
            labelIdUsu.Text = idUsu;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(txtNovaSenha.Text==txtSenhaN.Text && txtSenhaN.Text != "" && txtNovaSenha.Text != "")
            {
                Conexao.AlteraSenha(labelIdUsu.Text, txtNovaSenha.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite a senha e a confirmação corretamente!");
            }
            
        }
    }
}

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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            dt = Conexao.AutenticaUsu(txtUsu.Text, txtSenha.Text);
            if (dt.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Senha e/ou usuário incorretos.");
            }
            else
            {
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    string idUsu = pRow.Field<string>("id_cpf");
                    string nome = pRow.Field<string>("s_nome");
                    if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(idUsu))
                    {
                        this.Visible = false;
                        Form1 frm1 = new Form1(nome, idUsu);
                        frm1.Show();
                    }
                   
                }
            }
           
            
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

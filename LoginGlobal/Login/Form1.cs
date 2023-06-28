using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            verificaLogin();
        }
        
        private void verificaLogin()
        {
            if (txtUsuario.Text.Equals("Macoratti") || txtSenha.Text.Equals("numsey"))
            {
                //verifica se o login e senha e atribuir o 
                //nome do usuário e perfil ás variáveis globais
                Usuario.Perfil = cboPerfil.Text;
                Usuario.Login = txtUsuario.Text;

                Form2 frmAcesso = new Form2();
                frmAcesso.Show();

            }else{
                MessageBox.Show("Usuário/Senha Inválido(s).");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPerfil.SelectedIndex = 0;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

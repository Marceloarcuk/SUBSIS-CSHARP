using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;



namespace DITI_CV
{
    public partial class sys_login : Form
    {
        public sys_login()
        {
            InitializeComponent();
        }

        private static string strConexaoCoorp = "Persist Security Info=False;server=localhost; database=db_coorporativo;uid=root;pwd=";
        //private static string strConexaoCoorp = "Persist Security Info=False;server=localhost; database=db_coorporativo;uid=root;pwd=alanis00";
        public static MySqlConnection cConexao { get; set; }

        /***********************************************************************************************************/
        /****************************** AUTENTICA USUÁRIO NO DB_COORPORATIVO ***************************************/
        /***********************************************************************************************************/
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static DataSet AutenticaUsu(string usuario, string senha)
        {
            string usu = usuario;
            string pass = "uhofdjfoiahdfuHU" + senha;
            MD5 md5Hash = MD5.Create();
            string passWd = GetMd5Hash(md5Hash, pass);

            string mysql = "select * from tb_usuario inner join tb_sistemas_usuario on tb_usuario.id_cpf=tb_sistemas_usuario.id_cpf where  id_sis=8 and s_login='" + usu + "' and s_pass='" + passWd + "'  ; ";
            cConexao = new MySqlConnection(strConexaoCoorp);
            MySqlDataAdapter adoleAdapter = new MySqlDataAdapter(mysql, cConexao);
            DataSet dados = new DataSet();
            adoleAdapter.Fill(dados);

            return dados;
        }
        private void sys_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuArio = txtUsu.Text;
            string passw = txtSenha.Text;
            DataSet dt = new DataSet();
            dt = AutenticaUsu(usuArio, passw);
            foreach (DataRow pRow in dt.Tables[0].Rows)
            {
                string nome = pRow.Field<string>("s_nome");
                if (!String.IsNullOrEmpty(nome))
                {
                    Globais.CPFUSER = pRow.Field<string>("id_cpf");
                    this.Visible = false;
                    frm_main frmP = new frm_main();
                    frmP.Show();

                }
                else
                {
                    MessageBox.Show("Senha e/ou usuário incorretos.");
                }
            }
        }
    }
}

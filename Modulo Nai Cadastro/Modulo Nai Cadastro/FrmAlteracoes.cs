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
    public partial class FrmAlteracoes : Form
    {
        public FrmAlteracoes(string nomeAdolescente, string plantao, string idInterno, string idServ)
        {
            
            InitializeComponent();
            string nomeAdole = nomeAdolescente;
            string plantaoA = plantao;
            string idInt = idInterno;
            string idServidor = getAdolescenteDados_Idinsert(plantaoA, nomeAdole);
            string[] dadoServ = getServidor(idServidor);
            lblNomeAdolescente.Text = nomeAdole;
            lblDataUpdateD.Text = plantaoA;
            lblIdServ.Text = idServidor;
            lblNomeServ.Text = dadoServ[0];
            lblDescCargo.Text = dadoServ[1];
            lblIdInterno.Text = idInt;
            Load_Datagridview();


        }

        public string[] getServidor(string idServ)
        {
            DataSet dt = Conexao.SelectServidor(idServ);
            string[] dadosServ = new string[2];
            foreach (DataRow pRow in dt.Tables[0].Rows)
            {
                dadosServ[0]= pRow.Field<string>("nome_serv");
                dadosServ[1]= pRow.Field<string>("desc_cargo");
            }
            return dadosServ;
        }
        public string getAdolescenteDados_Idinsert( string plantaoInt, string nomeInt)
        {
           
            string plantao = plantaoInt;
            string nome = nomeInt;
            string idInsert="";
            DataSet dt = Conexao.SelecionaAdolescente(nome, plantao);
            foreach (DataRow pRow in dt.Tables[0].Rows)
            {
                idInsert = pRow.Field<string>("sis_user_insert");
            }


            return idInsert;
        }

        private void Load_Datagridview()
        {
            string idInsert = "";
            string[] dadosServ = new string[2];
            string nomeServ = "";
            string cargoServ = "";
            string dataUpdate ="";
            DataSet dtAlter = Conexao.SelectAlteracoes(lblIdInterno.Text, lblDataUpdateD.Text, lblNomeAdolescente.Text);
            foreach (DataRow pRow in dtAlter.Tables[0].Rows)
            {
                idInsert = pRow.Field<string>("id_user");
                dadosServ = getServidor(idInsert);
                nomeServ = dadosServ[0];
                cargoServ = dadosServ[1];
                dataUpdate = pRow.Field<DateTime>("sys_dt_update").ToString(); ;


                dataGridViewAlter.Rows.Add(nomeServ, dataUpdate, cargoServ);
            }



        }
    }
}

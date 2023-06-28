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
    public partial class FrmFoto_excluir : Form
    {
        FrmEfetivos frmP;
        public FrmFoto_excluir(string idAdole, string plantao, string plantaoS, string quarto, string ala, string idUsu, FrmEfetivos instP)
        {
            InitializeComponent();
            lblId_Adolescente.Text = idAdole;
            lblPlantaoAdolescente.Text = plantao;
            lblQuarto.Text = quarto;
            lblNQuarto.Text = ala;
            lblIdUsu.Text = idUsu;
            lblPlantaoSys.Text = plantaoS;
            frmP = instP;
            FrmFoto_excluir_Load();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmFoto_excluir_Load()
        {
            DataSet dt = Conexao.SelecionaAdolescente_ID(lblId_Adolescente.Text, lblPlantaoAdolescente.Text );
            Auxiliar aux = new Auxiliar();
            string nome = "";
            string sipia = "";
            int motivoEnt = 0;
            
            foreach(DataRow pRow in dt.Tables[0].Rows)
            {
                nome = pRow.Field<string>("nome_interno");
                motivoEnt = pRow.Field<int>("id_motivo_entrada");
                sipia = pRow.Field<string>("cod_sipia");
                byte[] img = pRow.Field<byte[]>("foto");
                Image photo = ImageConvert.ByteArrayToImage(img);
                pictureBoxAdolescente.Image = photo;
            }
            string motEnt = aux.SetMotivo_Ent(motivoEnt);
            lblNome.Text = nome;
            if(motivoEnt > 0)
            {
                lbl_FlagranMba.Text = motEnt;
                lbl_FlagranMba.Visible = true;
            }
            lbl_N_Sipia.Text = sipia;
            
        }

        private void btnSaiQuarto_Click(object sender, EventArgs e)
        {
            string titulo = "Inserir adolescente";
            string msg = "Deseja remover o adolescente do quarto?";
            int x = 0;
           
           
            DialogResult result = new DialogResult();
            result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                x = Conexao.removeAdolescenteQuarto(lblId_Adolescente.Text, lblPlantaoAdolescente.Text, lblIdUsu.Text, lblPlantaoSys.Text);
                frmP.Form_Clear();
                frmP.Form_Load();
                this.Close();
            }
        }
    }
}

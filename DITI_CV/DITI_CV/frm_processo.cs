using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITI_CV
{
    public partial class frm_processo : Form
    {
        public frm_processo()
        {
            InitializeComponent();
        }

        private void frm_processo_Load(object sender, EventArgs e)
        {
            Conexao.Conecta();
            DataSet dt = ConexaoSQL.processo_tipo();
            proc_tipo.Items.Clear();
            foreach (DataRow pRow in dt.Tables[0].Rows)
            {
                int id = pRow.Field<int>("tp_processo");
                string desc = pRow.Field<string>("desc_tp_processo");
                proc_tipo.Items.Add(desc);
            }
            int i = -1;
            Int32.TryParse(proc_tipo_index.Text, out i);
            if (i == 100) i = proc_tipo.Items.Count - 1;
            proc_tipo.SelectedIndex = i;
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            string vNProc = proc_num.Text;
            if (vNProc.Length != 12)
            {
                MessageBox.Show("Preencha o Nº do Processo corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                proc_num.Focus();
                return;
            }
        }


    }
}

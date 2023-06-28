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
    public partial class frm_processo_vinculado : Form
    {
        public frm_processo_vinculado()
        {
            InitializeComponent();
        }

        private void frm_processo_vinculado_Load(object sender, EventArgs e)
        {

            try
            {
                ListViewProc.Items.Clear();
                DataSet dtProcesso = ConexaoSQL.processos("", ed_localizar.Text);
                ListViewItem item1;
                foreach (DataRow pRow in dtProcesso.Tables[0].Rows)
                {
                    //-------------------------------------------------
                    //INSERIR PROCESSO
                    int vid_processo = pRow.Field<int>("id_processo");
                    if (proc_id.Text == vid_processo.ToString()) continue;
                    string vn_processo = pRow.Field<string>("n_processo").Substring(0, 4) + "." +
                                         pRow.Field<string>("n_processo").Substring(4, 4) + "-" +
                                         pRow.Field<string>("n_processo").Substring(8, 4);
                    int vtp_processo = pRow.Field<int>("tp_processo");


                    item1 = new ListViewItem(new[] { vn_processo });
                    item1.Tag = vid_processo;
                    item1.ImageIndex = 0;
                    if (pRow.Field<int>("tp_processo") == 1) item1.ImageIndex = 1;
                    ListViewProc.Items.Add(item1);
                    //-------------------------------------------------
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

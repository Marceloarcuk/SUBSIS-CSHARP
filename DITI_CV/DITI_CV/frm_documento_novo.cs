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
    public partial class frm_documento_novo : Form
    {
        public frm_documento_novo()
        {
            InitializeComponent();
        }

        private void frm_documento_novo_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conecta();
                DataSet dt = ConexaoSQL.documento_tipo();
                doc_tipo.Items.Clear();
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    string desc = pRow.Field<string>("desc_processo_documento_tipo");
                    doc_tipo.Items.Add(desc);
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

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (doc_tipo.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione um tipo de documento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    doc_tipo.Focus();
                    return;
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

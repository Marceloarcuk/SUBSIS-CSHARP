using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Collections;

namespace DITI_JOVEM
{
    public partial class frm_main : Form
    {
        class ListViewItemComparer : IComparer
        {
            private int col = 0;

            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }

        public frm_main()
        {
            InitializeComponent();
        }

        //****************************************************************************************
        //*** FUNÇÕES DE LAYOUT ******************************************************************
        //****************************************************************************************
        #region LAYOUT
       
        #endregion LAYOUT
        //****************************************************************************************

        //****************************************************************************************
        //*** FUNÇÕES - BARRA DE FERRAMENTAS *****************************************************
        //****************************************************************************************
        #region FORM_BARRA_FERRAMENTAS

        //
        // SAIR DO SISTEMA
        //
        private void bMenu_arquivo_sair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //
        // VISUALIZAR LIVRO
        //
        private void bMenu_plantao_visualizar_livro_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }
        //
        // TRANSFERENCIA DE PLANTÃO
        //
        private void bMenu_plantao_transf_Click(object sender, EventArgs e)
        {

        }
        //
        // CONTAGEM DE EFETIVOS
        //
        private void bMenu_plantao_contagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contagem de Efetivos");
        }

        #endregion FORM_BARRA_FERRAMENTAS
        //****************************************************************************************

        //****************************************************************************************
        //*** FUNÇÕES - FORM *********************************************************************
        //****************************************************************************************
        #region FORM_APP
        //---------------------------------------------------------
        // ABRIR APLICAÇÃO
        //---------------------------------------------------------
        private void frm_main_Load(object sender, EventArgs e)
        {
            try
            {
                // CONFIGURAR APLICAÇÃO ATRAVÉS DO ARQUIVO .INI
                IniFile DITI_JOVEM_IniFile = new IniFile("DITI_JOVEM.ini");
                Globais.Unidade = DITI_JOVEM_IniFile.IniReadString("UNIDADE", "unidade", "01");
                Globais.Modulo = DITI_JOVEM_IniFile.IniReadString("UNIDADE", "modulo", "01");
                Globais.Tamanho = DITI_JOVEM_IniFile.IniReadInt("LAYOUT", "tamanho", 1);
                Globais.TamanhoEx = DITI_JOVEM_IniFile.IniReadInt("LAYOUT", "tamanhoex", 1);
                cHint.Acao = DITI_JOVEM_IniFile.IniReadBool("HINT", "acoes", true);
                cHint.Jovens = DITI_JOVEM_IniFile.IniReadBool("HINT", "jovens", true);
                cHint.Servidores = DITI_JOVEM_IniFile.IniReadBool("HINT", "servidores", true);


                Usuario.Nome = "Marcelo Carvalho";
                Usuario.Login = "marcelo.carvalho";
                Usuario.CPF = "66654955153";
                string sBancoDados = DITI_JOVEM_IniFile.IniReadString("LOCALDATABASE", "mdb", "LIVROM.mdb");
                Globais.MYSQL = DITI_JOVEM_IniFile.IniReadBool("LOCALDATABASE", "mysql", false);
                Globais.MYSQL_SERVER = DITI_JOVEM_IniFile.IniReadString("LOCALDATABASE", "mysqlSERVER", "localhost");
                Globais.MYSQL_DB = DITI_JOVEM_IniFile.IniReadString("LOCALDATABASE", "mysqlDB", "db_subsis_modulo");
                Globais.MYSQL_USER = DITI_JOVEM_IniFile.IniReadString("LOCALDATABASE", "mysqlUSER", "root");
                Globais.MYSQL_PASS = DITI_JOVEM_IniFile.IniReadString("LOCALDATABASE", "mysqlPASS", "");

                Globais.DB_Database = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sBancoDados);
                Globais.DB_DatabaseMySql = new MySqlConnection(" Persist Security Info=False;server="+ Globais.MYSQL_SERVER+ ";"+
                                                                                            "database=" + Globais.MYSQL_DB + ";" +
                                                                                            "uid=" + Globais.MYSQL_USER + ";" +
                                                                                            "pwd=" + Globais.MYSQL_PASS);
            }
            catch (Exception ex)
            {
                //string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                //MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                //                "Procedimento: " + ex.TargetSite.Name + "\n" +
                //                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //-----------------------------
            //INICIALIZAR MENU BAR
            //-----------------------------
            
            //bMenu_configuracao_layout_maior.Checked = false;
            //bMenu_configuracao_layout_menor.Checked = false;
            //-----------------------------
            //REDIMENSIONAR STATUS BAR
            //-----------------------------
            stUsu.Text = " Usuário: " + Usuario.Login;

        }
        //---------------------------------------------------------
        // FECHAR APLICAÇÃO
        //---------------------------------------------------------
        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SalvaIniTamanho_Tela();
        }
        //---------------------------------------------------------
        // TIMER
        //---------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                stDT.Text = now.ToString();
            }
            catch { }
        }
        //---------------------------------------------------------
        #endregion FORM_APP
        //****************************************************************************************

        //****************************************************************************************
        //*** FUNÇÕES - JOVENS - SERVIDORES - AÇÕES **********************************************
        //****************************************************************************************
        #region FORM_JOVENS_SERVIDORES_ACOES


        #endregion FORM_JOVENS_SERVIDORES_ACOES
        //****************************************************************************************




        //---------------------------------------------------------

        //---------------------------------------------------------
        // SELECIONAR O CÓDIGO DO  JOVEM
        //---------------------------------------------------------

        //---------------------------------------------------------

        //****************************************************************************************


        //****************************************************************************************
        //*** FUNÇÕES SERVIDORES - AUXILIARES ****************************************************
        //****************************************************************************************


        //****************************************************************************************


        //****************************************************************************************
        //*** FUNÇÕES SERVIDORES - FORM **********************************************************
        //****************************************************************************************
        //---------------------------------------------------------
        // SELECIONAR O CÓDIGO DO  JOVEM
        //---------------------------------------------------------

        //---------------------------------------------------------





        //****************************************************************************************







        //---------------------------------------------------------




        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            MessageBox.Show(appPath);
        }


        private void jovensToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frm_cad_jovem frm_cad_jovem = new frm_cad_jovem();
            try
            {
                frm_cad_jovem.pnlcontainerGeral.Visible = false;
                frm_cad_jovem.MdiParent = this;
                frm_cad_jovem.Show();
            }
            finally
            {
                frm_cad_jovem.pnlcontainerGeral.Visible = true;
                this.Cursor = Cursors.Arrow;
            }
        }
        

    }

}

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

namespace DITI_LIVROM
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
        //---------------------------------------------------------
        // REDIMENSIONAR TAMANHO DA FOTO DOS JOVENS
        //---------------------------------------------------------
        private void Tamanho_Fotos_Jovem(int _tamanho)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                int tam_bor_width = 146;
                int tam_bor_height = 186;
                int tam_flw_width = 140;
                int tam_flw_height = 180;
                int tam_pic = 135;
                int tam_txt_width = 130;
                int tam_txt_height = 20;
                int tam_txt_posL = 5;
                int tam_txt_posT = 143;
                float tam_txt_fonte = 10.8F;
                int tam_icon_acao = 35;

                if (_tamanho == 0)
                {
                    tam_bor_width = 76;
                    tam_bor_height = 96;
                    tam_flw_width = 70;
                    tam_flw_height = 90;
                    tam_pic = 65;
                    tam_txt_width = 60;
                    tam_txt_height = 10;
                    tam_txt_posL = 1;
                    tam_txt_posT = 72;
                    tam_txt_fonte = 6;
                    tam_icon_acao = 20;
                }

                foreach (Control Bor in pnlJovens.Controls)
                {
                    if (Bor.Name.Substring(0, 3) == "Bor")
                    {
                        Bor.Size = new Size(tam_bor_width, tam_bor_height);
                        foreach (Control BorControls in Bor.Controls)
                        {
                            //PAINEL COM FOTO E NOME
                            if (BorControls.Name.Substring(0, 3) == "flw")
                            {
                                BorControls.Size = new Size(tam_flw_width, tam_flw_height);
                                foreach (Control flwControls in BorControls.Controls)
                                {
                                    //FOTO
                                    if (flwControls.Name.Substring(0, 3) == "pic") flwControls.Size = new Size(tam_pic, tam_pic);
                                    //NOME
                                    if (flwControls.Name.Substring(0, 3) == "txt")
                                    {
                                        flwControls.Size = new Size(tam_txt_width, tam_txt_height);
                                        flwControls.Location = new Point(tam_txt_posL, tam_txt_posT);
                                        flwControls.Font = new System.Drawing.Font("Microsoft Sans Serif", tam_txt_fonte, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                                    }
                                    //ALA QUARTO
                                    if (flwControls.Name.Substring(0, 3) == "ala")
                                    {
                                        flwControls.Size = new Size(tam_txt_height*2, tam_txt_height);
                                        flwControls.Location = new Point(0, tam_txt_posT+ tam_txt_height);
                                        flwControls.Font = new System.Drawing.Font("Microsoft Sans Serif", tam_txt_fonte, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                                    }
                                }
                            }
                            //CHECK BOX
                            else if (BorControls.Name.Substring(0, 3) == "ckj")
                                BorControls.Location = new Point(Bor.Size.Width - 17, Bor.Size.Height - 17);
                            //ICONE AÇÃO
                            else if (BorControls.Name.Substring(0, 3) == "pnl")
                            {
                                BorControls.Size = new Size(tam_icon_acao, tam_icon_acao);
                                foreach (Control pnlControls in BorControls.Controls)
                                    if (pnlControls.Name.Substring(0, 3) == "ico") pnlControls.Size = new Size(tam_icon_acao, tam_icon_acao);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }
        //---------------------------------------------------------
        // REDIMENSIONAR FOTO DOS JOVENS
        //---------------------------------------------------------
        private void Redimensionar_Fotos_Jovem(int _tamanho)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                int vCol = 0;
                int vColTotal = 0;

                int vLinT = 210;
                int vColT = 150;
                int vLin = 20;
                if (_tamanho == 0)
                {
                    vLinT = 105;
                    vColT = 80;
                    vLin = 10;
                }

                vColTotal = pnlJovens.Size.Width / vColT;
                foreach (Control c in pnlJovens.Controls)
                {
                    if (c.Name.Substring(0, 3) == "Bor")
                    {
                        //Calcula Linha
                        vCol++;
                        if (vCol > vColTotal) { vLin += vLinT; vCol = 1; }
                        //Redimencionar
                        c.Location = new Point((10 + (vCol * vColT) - vColT), vLin);
                    }
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }
        //---------------------------------------------------------
        // CARREGA LAYOUT (800x600 OU 1024x1000)
        //---------------------------------------------------------
        private void Tamanho_TelaConfig(int _tamanho)
        {
            try
            {
                //-----------------------------------
                // CONFIGURAR APLICAÇÃO ATRAVÉS DO ARQUIVO .INI
                //IniFile LIVROM_IniFile = new IniFile("LIVROM.ini");

                //-----------------------------------
                //INICIALIZA MAINFORM LAYOYT
                int iPnlContainer = 400;
                float fLabel_font = 12;
                //BARRA AÇÃO 
                int iBarVerde_container = 50;
                float fAcaoList_font = 11;
                //SERVIDOR
                int iServ_container = 150;
                int iServ_bar = 25;
                int iServ_icons = 4;
                int iServ_border = 1;
                float fServList_font = 11;
                //BOTÃO EXECUTAR
                int iExec_container = 60;
                int iBtn_border = 5;
                int iBtn_width_bor = 10;
                int iBtn_heigth = 50;
                float fBtn_font = 14;

                if (_tamanho == 0)
                {
                    iPnlContainer = 300;
                    fLabel_font = 10;
                    //BARRA AÇÃO 
                    iBarVerde_container = 40;
                    fAcaoList_font = 8;
                    //SERVIDOR
                    iServ_container = 120;
                    iServ_bar = 20;
                    iServ_icons = 2;
                    iServ_border = 1;
                    fServList_font = 7;
                    //BOTÃO EXECUTAR
                    iExec_container = 40;
                    iBtn_border = 5;
                    iBtn_width_bor = 10;
                    iBtn_heigth = 30;
                    fBtn_font = 11;
                }  

                //--------------------------
                //LAYOUT VERDE
                pnl_Cont.Size = new Size(iPnlContainer, 40);
                //--------------------------
                //BARRA AÇÃO 
                lb_total_jovens.Font = new System.Drawing.Font("Microsoft Sans Serif", fLabel_font, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_total_jovens.Location = new Point(1, 21 + (_tamanho * 5));
                lb_plantao.Font = lb_total_jovens.Font;
                lb_plantao.Location = new Point(1, 1);
                pnlAcao_bar.Size = new Size(iPnlContainer, iBarVerde_container);
                LsvAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", fAcaoList_font, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                //--------------------------
                //SERVIDOR
                pnlServidor_Cont.Size = new Size(iPnlContainer, iServ_container);
                pnlServidor_bar.Size = new Size(iPnlContainer, iServ_bar);
                lb_servidores.Location = new Point(iServ_border, iServ_border);
                lb_servidores.Font = new System.Drawing.Font("Microsoft Sans Serif", fLabel_font, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (iServ_icons == 0) { LsvServidor.View = View.List; }
                else if (iServ_icons == 1) { LsvServidor.View = View.SmallIcon; }
                else if (iServ_icons == 2) { LsvServidor.View = View.Details; }
                else { LsvServidor.View = View.LargeIcon; }
                LsvServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", fServList_font, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //--------------------------
                //BOTÃO EXECUTAR
                pnlExecutar_Cont.Size = new Size(iPnlContainer, iExec_container);
                btnRegistraAcao.Size = new Size(iPnlContainer - iBtn_width_bor, iBtn_heigth);
                btnRegistraAcao.Location = new Point(iBtn_border, iBtn_border);
                btnRegistraAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", fBtn_font, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                //--------------------------

            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //---------------------------------------------------------
        // CARREGA LAYOUT (800x600 OU 1024x1000)
        //---------------------------------------------------------
        private void Tamanho_TelaIni(int _tamanho)
        {
            try
            {
                //-----------------------------------
                // CONFIGURAR APLICAÇÃO ATRAVÉS DO ARQUIVO .INI
                IniFile LIVROM_IniFile = new IniFile("LIVROM.ini");

                //-----------------------------------
                //INICIALIZA MAINFORM LAYOYT
                int iPnlContainer = LIVROM_IniFile.IniReadInt("LAYOUT", "pnlcontainer", 400);
                float fLabel_font = LIVROM_IniFile.IniReadInt("LAYOUT", "label_font", 12);
                //BARRA AÇÃO 
                int iBarVerde_container = LIVROM_IniFile.IniReadInt("LAYOUT", "barverde_container", 50);
                float fAcaoList_font = LIVROM_IniFile.IniReadInt("LAYOUT", "acaolist_font", 11);
                //SERVIDOR
                int iServ_container = LIVROM_IniFile.IniReadInt("LAYOUT", "serv_container", 150);
                int iServ_bar = LIVROM_IniFile.IniReadInt("LAYOUT", "serv_bar", 25);
                int iServ_icons = LIVROM_IniFile.IniReadInt("LAYOUT", "serv_icons", 4);
                int iServ_border = LIVROM_IniFile.IniReadInt("LAYOUT", "serv_border", 1);
                float fServList_font = LIVROM_IniFile.IniReadInt("LAYOUT", "servlist_font", 11);
                //BOTÃO EXECUTAR
                int iExec_container = LIVROM_IniFile.IniReadInt("LAYOUT", "exec_container", 60);
                int iBtn_border = LIVROM_IniFile.IniReadInt("LAYOUT", "btn_border", 5);
                int iBtn_width_bor = LIVROM_IniFile.IniReadInt("LAYOUT", "btn_width_bor", 10);
                int iBtn_heigth = LIVROM_IniFile.IniReadInt("LAYOUT", "btn_heigth", 50);
                float fBtn_font = LIVROM_IniFile.IniReadInt("LAYOUT", "btn_font", 14);

                if (_tamanho == 0)
                {
                    iPnlContainer = LIVROM_IniFile.IniReadInt("LAYOUT", "pnlcontainer", 300);
                    fLabel_font = LIVROM_IniFile.IniReadInt("LAYOUT", "label_font", 10);
                    //BARRA AÇÃO 
                    iBarVerde_container = LIVROM_IniFile.IniReadInt("LAYOUT", "barverde_container", 40);
                    fAcaoList_font = LIVROM_IniFile.IniReadInt("LAYOUT", "acaolist_font", 8);
                    //SERVIDOR
                    iServ_container = LIVROM_IniFile.IniReadInt("LAYOUT", "serv_container", 120);
                    iServ_bar = LIVROM_IniFile.IniReadInt("LAYOUT", "serv_bar", 20);
                    iServ_icons = LIVROM_IniFile.IniReadInt("LAYOUT", "serv_icons", 2);
                    iServ_border = LIVROM_IniFile.IniReadInt("LAYOUT", "serv_border", 1);
                    fServList_font = LIVROM_IniFile.IniReadInt("LAYOUT", "servlist_font", 7);
                    //BOTÃO EXECUTAR
                    iExec_container = LIVROM_IniFile.IniReadInt("LAYOUT", "exec_container", 40);
                    iBtn_border = LIVROM_IniFile.IniReadInt("LAYOUT", "btn_border", 5);
                    iBtn_width_bor = LIVROM_IniFile.IniReadInt("LAYOUT", "btn_width_bor", 10);
                    iBtn_heigth = LIVROM_IniFile.IniReadInt("LAYOUT", "btn_heigth", 30);
                    fBtn_font = LIVROM_IniFile.IniReadInt("LAYOUT", "btn_font", 11);
                }

                //--------------------------
                //LAYOUT VERDE
                pnl_Cont.Size = new Size(iPnlContainer, 40);
                //--------------------------
                //BARRA AÇÃO 
                lb_total_jovens.Font = new System.Drawing.Font("Microsoft Sans Serif", fLabel_font, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_total_jovens.Location = new Point(1, 21 + (Globais.Tamanho * 5));
                lb_plantao.Font = lb_total_jovens.Font;
                lb_plantao.Location = new Point(1, 1);
                pnlAcao_bar.Size = new Size(iPnlContainer, iBarVerde_container);
                LsvAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", fAcaoList_font, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //--------------------------
                //SERVIDOR
                pnlServidor_Cont.Size = new Size(iPnlContainer, iServ_container);
                pnlServidor_bar.Size = new Size(iPnlContainer, iServ_bar);
                lb_servidores.Location = new Point(iServ_border, iServ_border);
                lb_servidores.Font = new System.Drawing.Font("Microsoft Sans Serif", fLabel_font, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (iServ_icons == 0) { LsvServidor.View = View.List; }
                else if (iServ_icons == 1) { LsvServidor.View = View.SmallIcon; }
                else if (iServ_icons == 2) { LsvServidor.View = View.Details; }
                else { LsvServidor.View = View.LargeIcon; }
                LsvServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", fServList_font, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //--------------------------
                //BOTÃO EXECUTAR
                pnlExecutar_Cont.Size = new Size(iPnlContainer, iExec_container);
                btnRegistraAcao.Size = new Size(iPnlContainer - iBtn_width_bor, iBtn_heigth);
                btnRegistraAcao.Location = new Point(iBtn_border, iBtn_border);
                btnRegistraAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", fBtn_font, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                //--------------------------

            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //---------------------------------------------------------
        // SALVA LAYOUT (800x600 OU 1024x1000)
        //---------------------------------------------------------
        private void SalvaIniTamanho_Tela()
        {
            try
            {
                //-----------------------------------
                // CONFIGURAR APLICAÇÃO ATRAVÉS DO ARQUIVO .INI
                IniFile LIVROM_IniFile = new IniFile("LIVROM.ini");

                /*
                pnlcontainer = 642              pnlcontainer = 300
                label_font = 12                 label_font = 10
                barverde_container = 50         barverde_container = 40
                acaolist_font = 11              acaolist_font = 8
                serv_container = 150            serv_container = 120
                serv_bar = 25                   serv_bar = 20
                serv_icons = 4                  serv_icons = 1
                serv_border = 1                 serv_border = 1
                servlist_font = 11              servlist_font = 7
                exec_container = 60             exec_container = 40
                btn_border = 5                  btn_border = 5
                                                btn_width_bor = 10
                btn_heigth = 50                 btn_heigth = 30
                btn_font = 14                   btn_font = 11
                */

                //-----------------------------------
                //SALVA MAINFORM LAYOYT
                LIVROM_IniFile.IniWriteInt("LAYOUT", "tamanho", Globais.Tamanho);
                LIVROM_IniFile.IniWriteInt("LAYOUT", "pnlcontainer", pnl_Cont.Size.Width);
                LIVROM_IniFile.IniWriteString("LAYOUT", "label_font", lb_total_jovens.Font.Size.ToString());
                //--------------------------
                //BARRA AÇÃO 
                LIVROM_IniFile.IniWriteInt("LAYOUT", "barverde_container", pnlAcao_bar.Size.Height);
                LIVROM_IniFile.IniWriteString("LAYOUT", "acaolist_font", LsvAcoes.Font.Size.ToString());
                //--------------------------
                //SERVIDOR
                LIVROM_IniFile.IniWriteInt("LAYOUT", "serv_container", pnlServidor_Cont.Size.Height);
                LIVROM_IniFile.IniWriteInt("LAYOUT", "serv_bar", pnlServidor_bar.Size.Height);
                int iServ_icons = 4;
                if (LsvServidor.View == View.List) iServ_icons = 0;
                else if (LsvServidor.View == View.SmallIcon) iServ_icons = 1;
                else if (LsvServidor.View == View.Details) iServ_icons = 2;
                LIVROM_IniFile.IniWriteInt("LAYOUT", "serv_icons", iServ_icons);
                LIVROM_IniFile.IniWriteInt("LAYOUT", "serv_border", lb_servidores.Location.X);
                LIVROM_IniFile.IniWriteString("LAYOUT", "servlist_font", LsvServidor.Font.Size.ToString());
                //--------------------------
                //BOTÃO EXECUTAR
                LIVROM_IniFile.IniWriteInt("LAYOUT", "exec_container", pnlExecutar_Cont.Size.Height);
                LIVROM_IniFile.IniWriteInt("LAYOUT", "btn_border", btnRegistraAcao.Location.X);
                LIVROM_IniFile.IniWriteInt("LAYOUT", "btn_heigth", btnRegistraAcao.Size.Height);
                LIVROM_IniFile.IniWriteInt("LAYOUT", "btn_width_bor", pnl_Cont.Size.Width - btnRegistraAcao.Size.Width);
                LIVROM_IniFile.IniWriteString("LAYOUT", "btn_font", btnRegistraAcao.Font.Size.ToString());
                //--------------------------
                //EXIBIÇÃO DOS JOVENS ORDER BY - QUARTO OU NOME
                LIVROM_IniFile.IniWriteString("LAYOUT", "viewjovens", cJovens.ViewOrderBy);

                //--------------------------
                //BOTÃO EXECUTAR
                //LIVROM_IniFile.IniWriteInt("LAYOUT", "btn_width_bor", 10);
                //btnRegistraAcao.Size = new Size(iPnlContainer - iBtn_width_bor, iBtn_heigth);
                //pnl_Cont.Size.Width
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //---------------------------------------------------------
        // CARREGA PANEL JOVENS ORDER BY
        //---------------------------------------------------------
        private void carregarjovensOrderBy(string _OrderBy)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                pnlJovens.Visible = false;
                pnlJovens.BackColor = Color.White;
                Boolean DelTodosBor = true;
                while (DelTodosBor == true)
                {
                    DelTodosBor = false;
                    foreach (Control Bor in pnlJovens.Controls)
                        if (Bor.Name.Substring(0, 3) == "Bor")
                        {
                            DelTodosBor = true;
                            pnlJovens.Controls.Remove(Bor);
                            Bor.Dispose();
                        }
                }
                f_carregar_panel_jovens(_OrderBy);  //frm_main_Load(sender, e);
                Tamanho_Fotos_Jovem(Globais.Tamanho);
                Redimensionar_Fotos_Jovem(Globais.Tamanho);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
                pnlJovens.Visible = true;
            }
        }
        //---------------------------------------------------------


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
        // CHECK TODOS OS JOVENS
        //
        private void bMenu_Jovens_Check_Todos_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            pnlJovens.Visible = false;
            try
            {

                Boolean TemCheck = false;
                foreach (Control Bor in pnlJovens.Controls)
                    if (Bor.Name.Substring(0, 3) == "Bor")
                        foreach (Control cIcon in Bor.Controls)
                            if (cIcon.Name.Substring(0, 3) == "ckj")
                                if ((cIcon as CheckBox).Checked)
                                {
                                    TemCheck = true;
                                    break;
                                }
                foreach (Control Bor in pnlJovens.Controls)
                    if (Bor.Name.Substring(0, 3) == "Bor")
                    {
                        Bor.Enabled = true;
                        Bor.Cursor = Cursors.Arrow;
                        foreach (Control cIcon in Bor.Controls)
                            if (cIcon.Name.Substring(0, 3) == "ckj")
                                if ((cIcon as CheckBox).Checked) (cIcon as CheckBox).Checked = false;
                    }

                if (!TemCheck)
                {
                    Boolean temicon = false;
                    foreach (Control Bor in pnlJovens.Controls)
                        if (Bor.Name.Substring(0, 3) == "Bor")
                            if (Bor.Enabled)
                            {
                                temicon = false;
                                foreach (Control cPnl in Bor.Controls)
                                    if (cPnl.Name.Substring(0, 3) == "pnl")
                                    {
                                        temicon = true;
                                        break;
                                    }
                                if (!temicon) cJovens.Foto_Click(Bor, e);
                            }
                }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
                pnlJovens.Visible = true;
            }
        }
        //
        // ORDENAR JOVENS POR QUARTO
        //
        private void bMenu_Jovens_ordenar_Quarto_Click(object sender, EventArgs e)
        {
            cJovens.ViewOrderBy = "quarto";
            carregarjovensOrderBy(cJovens.ViewOrderBy);
        }
        //
        // ORDENAR JOVENS POR NOME
        //
        private void bMenu_Jovens_ordenar_Nome_Click(object sender, EventArgs e)
        {
            cJovens.ViewOrderBy = "nome";
            carregarjovensOrderBy(cJovens.ViewOrderBy);
        }
        //
        // ALTERAR TAMANHO DOS ICONES DOS JOVENS
        //
        private void bMenu_Jovens_View_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            pnlJovens.Visible = false;
            try
            {
                if (Globais.Tamanho == 0) Globais.Tamanho = 1;
                else Globais.Tamanho = 0;
                Tamanho_Fotos_Jovem(Globais.Tamanho);
                Redimensionar_Fotos_Jovem(Globais.Tamanho);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
                pnlJovens.Visible = true;
            }
        }
        //
        // ALTERAR TAMANHO DOS ICONES DOS SERVIDORES
        //
        private void bMenu_Servidor_View_Click(object sender, EventArgs e)
        {
            if (LsvServidor.View == View.LargeIcon) { LsvServidor.View = View.List; }
            else if (LsvServidor.View == View.List) { LsvServidor.View = View.SmallIcon; }
            else if (LsvServidor.View == View.SmallIcon) { LsvServidor.View = View.Details; }
            else { LsvServidor.View = View.LargeIcon; }
        }
        //
        // VISUALIZAR LIVRO
        //
        private void bMenu_plantao_visualizar_livro_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                frm_livro_visualizar frm_livro_visualizar = new frm_livro_visualizar();
                //frm_livro_visualizar.VisualizarLivroRTF("17/11/2016");
                frm_livro_visualizar.VisualizarLivroRTF(Globais.Plantao);
                //frm_livro_visualizar.ShowDialog();
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
            //------------------------------------------------------------------------------
            //CARREGA O FORMULÁRIO DE TRANFERENCIA DE PLANTÃO
            //------------------------------------------------------------------------------
            frm_tranferencia_plantao frm_tranferencia_plantao = new frm_tranferencia_plantao();
            #region CarregaForm_transf_plantao
            //---------------------------------------------------------
            DataSet vRecordSet = new DataSet();
            ListViewItem item1;
            try
            {
                //--------------------------------------------------
                //INDICES E DATAS DO SYSTEMA
                frm_tranferencia_plantao.eAcao.Text = "80";
                frm_tranferencia_plantao.eDTPlantaoIni.Text = stDT.Text;
                frm_tranferencia_plantao.eLOCAL_DT.Text = String.Format("{0:yyyy-MM-dd HH:mm}", DateTime.ParseExact(stDT.Text,
                                                                                                               "dd/MM/yyyy HH:mm:ss",
                                                                                     System.Globalization.CultureInfo.InvariantCulture));
                frm_tranferencia_plantao.ePlantaoIni.Text = stDT.Text.Substring(0, 10);
                frm_tranferencia_plantao.ePlantaoFim.Text = Globais.Plantao;
                frm_tranferencia_plantao.eServidores.Columns[0].Text = "Servidores: " + frm_tranferencia_plantao.eServidores.Items.Count.ToString();
                //--------------------------------------------------
                //LISTVIEW JOVENS
                int iStatus, iMDrestante = 0;
                string vStatus = "0";
                string vStatustxt = "0";
                frm_tranferencia_plantao.eJovens.Items.Clear();
                try
                {
                    vRecordSet = Consulta.Consultar("SELECT tb_unidade_interno.id_interno, tb_interno.nome_interno, tb_unidade_interno.n_quarto, tb_unidade_interno.n_ala, tb_unidade_interno.status_interno " +
                                                    "FROM tb_interno INNER JOIN tb_unidade_interno ON tb_interno.id_interno = tb_unidade_interno.id_interno " +
                                                    "WHERE ((tb_unidade_interno.id_unidade = '" + Globais.Unidade + "') AND (tb_unidade_interno.id_modulo = '" + Globais.Modulo + "')) ");
                    int iIndice = 0;
                    foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
                    {
                        iMDrestante = 0;
                        cJovens.f_dados_jovem(pRow.Field<string>("id_interno"));
                        iMDrestante = cJovemSelect.MedidaDisciplinarRestante();
                        iStatus = 0;
                        vStatus = pRow.Field<int>("status_interno").ToString();
                        vStatustxt = "No Módulo";
                        if (iMDrestante > 0)
                        {
                            vStatustxt = "Em Medida Disciplinar";
                            iStatus = 1;
                        }

                        if ((vStatus == "19") || (vStatus == "21") || (vStatus == "22") || (vStatus == "24") || (vStatus == "25"))
                        {
                            vStatustxt = "Fora do Módulo";
                            iStatus = 2;
                        }
                        item1 = new ListViewItem(new[] { pRow.Field<string>("nome_interno"),
                                                             pRow.Field<string>("n_ala"),
                                                             pRow.Field<string>("n_quarto"),
                                                             vStatustxt,
                                                             pRow.Field<string>("id_interno").ToString() });
                        item1.ImageIndex = iStatus;
                        frm_tranferencia_plantao.eJovens.Items.Add(item1);
                        iIndice++;
                    }
                }
                catch { }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao carregar dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //---------------------------------------------------------
            #endregion CarregaForm_transf_plantao
            //---------------------------------------------------------
            #region CarregaForm_transf_plantao_AcoesResposta
            if (frm_tranferencia_plantao.ShowDialog(this) == DialogResult.OK)
            {
                frm_main_Load(sender, e);
                MessageBox.Show("Plantão " + Globais.Plantao + " está aberto.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            #endregion CarregaForm_transf_plantao_AcoesResposta

        }
        //
        // CONTAGEM DE EFETIVOS
        //
        private void bMenu_plantao_contagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contagem de Efetivos");
        }
        //
        // LAYOUT DA APLICAÇÃO PARA RESOLUÇÕES ACIMA DE 1024x780
        //
        private void bMenu_configuracao_layout_maior_Click(object sender, EventArgs e)
        {
            Tamanho_TelaConfig(1);
            bMenu_configuracao_layout_maior.Checked = true;
            bMenu_configuracao_layout_menor.Checked = false;
            Globais.Tamanho = 1;
            Globais.TamanhoEx = 1;
            Tamanho_Fotos_Jovem(Globais.Tamanho);
            Redimensionar_Fotos_Jovem(Globais.Tamanho);
            SalvaIniTamanho_Tela();
        }
        //
        // LAYOUT DA APLICAÇÃO PARA RESOLUÇÕES 800x600
        //
        private void bMenu_configuracao_layout_menor_Click(object sender, EventArgs e)
        {
            Tamanho_TelaConfig(0);
            bMenu_configuracao_layout_maior.Checked = false;
            bMenu_configuracao_layout_menor.Checked = true;
            Globais.Tamanho = 0;
            Globais.TamanhoEx = 0;
            Tamanho_Fotos_Jovem(Globais.Tamanho);
            Redimensionar_Fotos_Jovem(Globais.Tamanho);
            SalvaIniTamanho_Tela();
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
            // CONFIGURAR APLICAÇÃO ATRAVÉS DO ARQUIVO .INI
            IniFile LIVROM_IniFile = new IniFile("LIVROM.ini");
            Globais.Unidade = LIVROM_IniFile.IniReadString("UNIDADE", "unidade", "01");
            Globais.Modulo = LIVROM_IniFile.IniReadString("UNIDADE", "modulo", "01");
            Globais.Tamanho = LIVROM_IniFile.IniReadInt("LAYOUT", "tamanho", 1);
            Globais.TamanhoEx = LIVROM_IniFile.IniReadInt("LAYOUT", "tamanhoex", 1);
            cHint.Acao = LIVROM_IniFile.IniReadBool("HINT", "acoes", true);
            cHint.Jovens = LIVROM_IniFile.IniReadBool("HINT", "jovens", true);
            cHint.Servidores = LIVROM_IniFile.IniReadBool("HINT", "servidores", true);
            Usuario.Nome = "Marcelo Carvalho";
            Usuario.Login = "marcelo.carvalho";
            Usuario.CPF = "66654955153";
            cJovens.ViewOrderBy = LIVROM_IniFile.IniReadString("LAYOUT", "viewjovens", "quarto");

            Globais.MYSQL = LIVROM_IniFile.IniReadBool("LOCALDATABASE", "mysql", false);
            Globais.MYSQL_SERVER = LIVROM_IniFile.IniReadString("LOCALDATABASE", "mysqlSERVER", "localhost");
            Globais.MYSQL_DB = LIVROM_IniFile.IniReadString("LOCALDATABASE", "mysqlDB", "db_subsis_modulo");
            Globais.MYSQL_USER = LIVROM_IniFile.IniReadString("LOCALDATABASE", "mysqlUSER", "root");
            Globais.MYSQL_PASS = LIVROM_IniFile.IniReadString("LOCALDATABASE", "mysqlPASS", "");


            string sBancoDados = LIVROM_IniFile.IniReadString("LOCALDATABASE", "mdb", "LIVROM.mdb");
            Globais.DB_Database = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sBancoDados);
            Globais.DB_DatabaseMySql = new MySqlConnection(" Persist Security Info=False;server=" + Globais.MYSQL_SERVER + ";" +
                                                                                        "database=" + Globais.MYSQL_DB + ";" +
                                                                                        "uid=" + Globais.MYSQL_USER + ";" +
                                                                                        "pwd=" + Globais.MYSQL_PASS);




            //DECLARAR VARIAVEIS
            DataSet vRecordSet = new DataSet();


            //-----------------------------
            //CONECTAR BANCO DE DADOS - ARMAZENA ID PLANTAO NAS GLOBAIS
            vRecordSet = Consulta.Consultar("SELECT id_plantao FROM tb_plantao " +
                                           "  WHERE ((id_unidade = '" + Globais.Unidade + "') AND (tb_plantao.id_modulo = '" + Globais.Modulo + "')) " +
                                           "  ORDER BY CDate([id_plantao]) DESC;");
            try
            {
                Globais.Plantao = "";
                if (vRecordSet !=null)
                    if (vRecordSet.Tables[0].Rows.Count > 0)
                    {
                        DataRow pRowPlantao = vRecordSet.Tables[0].Rows[0];
                        Globais.Plantao = pRowPlantao["id_plantao"].ToString();
                    }
                lb_plantao.Text = "Plantão - " + Globais.Plantao;
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("ABRIR FORM PARA CRIAR PLANTÃO");
                Globais.Plantao = "0";
            }
            //-----------------------------
            //INICIALIZAR SERVIDORES
            //-----------------------------
            cServidor.f_carregar_servidores(LsvServidor,-1,"");
            //-----------------------------
            //INICIALIZAR LsvAcoes
            //-----------------------------
            LsvAcoes.ShowNodeToolTips = cHint.Acao;
            if (cHint.Acao)
            {
                cHint.Exibir(btn_plantao_transf, "Efetuar transferência de Plantão");
                cHint.Exibir(btn_plantao_contagem, "Efetuar contagem de efetivos no Plantão");
                cHint.Exibir(btn_plantao_visualizar, "Visualizar Livro");

            }

            cAcoes.f_carregar_acoes(LsvAcoes);
            //-----------------------------
            //INICIALIZAR JOVENS
            //-----------------------------
            carregarjovensOrderBy(cJovens.ViewOrderBy);
            //-----------------------------
            //INICIALIZAR MENU BAR
            //-----------------------------
            Tamanho_TelaIni(Globais.TamanhoEx);
            bMenu_configuracao_layout_maior.Checked = false;
            bMenu_configuracao_layout_menor.Checked = false;
            if (Globais.Tamanho == 1) bMenu_configuracao_layout_maior.Checked = true;
            else  bMenu_configuracao_layout_menor.Checked = true;
            //-----------------------------
            //REDIMENSIONAR STATUS BAR
            //-----------------------------
            stUsu.Text = " Usuário: " + Usuario.Login;
            statusStrip1_Resize(sender, e);
            //-----------------------------
            //TOTAL DE JOVENSNO MÓDULO
            //-----------------------------
            int iCountJovens = 0;
            foreach (Control Bor in pnlJovens.Controls)
                if (Bor.Name.Substring(0, 3) == "Bor")
                    if (Bor.BackColor != cJovens._Desabilitado()) iCountJovens++;
            lb_total_jovens.Text = "Total de Jovens: " + iCountJovens.ToString();
            cJovens.TotalJovens = iCountJovens;

        }
        //---------------------------------------------------------
        // FECHAR APLICAÇÃO
        //---------------------------------------------------------
        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvaIniTamanho_Tela();
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


        //---------------------------------------------------------
        // CARREGAR PANEL JOVEM
        //---------------------------------------------------------
        private void f_carregar_panel_jovens(string _orderby)
        {
            //-----------------------------
            //INICIALIZAR JOVENS
            //-----------------------------
            //DECLARAR VARIAVEIS
            DataSet vRecordSet = new DataSet();
            DataSet vRecordSet1 = new DataSet();
            Panel[] flws = new Panel[50];
            Panel[] Bor = new Panel[50];
            PictureBox[] pics = new PictureBox[50];
            Label[] txts = new Label[50];
            Label[] Ala = new Label[50];
            CheckBox[] ckj = new CheckBox[50];
            Label[] Codigo = new Label[50];
            int vLin = 20;

            cJovemSelect.Nome = "";
            cJovemSelect.Codigo = "";
            cJovemSelect.Status = "0";

            string vOrderBy = "ORDER BY tb_unidade_interno.n_ala, tb_unidade_interno.n_quarto, tb_interno.nome_interno";
            if (_orderby == "nome")
                vOrderBy = "ORDER BY tb_interno.nome_interno";

            //-----------------------------
            //CONECTAR BANCO DE DADOS - CRIAR JOVENS
            vRecordSet = Consulta.Consultar("SELECT tb_unidade_interno.id_unidade, tb_unidade_interno.id_modulo, tb_unidade_interno.id_interno, tb_unidade_interno.n_quarto, " +
                                                  "tb_unidade_interno.n_ala, tb_unidade_interno.status_interno, tb_interno.nome_interno, tb_interno.foto " +
                                           "FROM tb_interno INNER JOIN tb_unidade_interno ON tb_interno.id_interno = tb_unidade_interno.id_interno " +
                                           "WHERE((tb_unidade_interno.id_unidade = '" + Globais.Unidade + "') AND (tb_unidade_interno.id_modulo = '" + Globais.Modulo + "')) " +
                                           vOrderBy + ";");
            //PREENCHER CABEÇALHO VERDE
            this.Text = "Livro Módulo ( Módulo nº " + Globais.Modulo + ")";

            //CRIAR COMPONENTES
            int iCont = 0;
            foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
            {
                //ARMAZENA OS VALORES DA CONSULTA
                // preenche o componente cJovemSelect
                cJovens.f_dados_jovem(pRow.Field<string>("id_interno"));
                int vTemIcon = -1;
                string vTemIconHint = "";
                //EXECUTA CONSULTA
                vRecordSet1 = Consulta.Consultar("SELECT tb_unidade_interno.status_interno, tb_acao.desc_acao FROM tb_acao INNER JOIN tb_unidade_interno ON tb_acao.id_acao = tb_unidade_interno.status_interno " +
                                                 "WHERE((tb_unidade_interno.id_unidade = '" + Globais.Unidade + "') " +
                                                 " AND(tb_unidade_interno.id_modulo = '" + Globais.Modulo + "') " +
                                                 " AND(tb_unidade_interno.id_interno = '" + cJovemSelect.Codigo + "') " +
                                                 " AND ((tb_acao.p_icon = 1) OR (tb_acao.p_icon = 3)));");
                foreach (DataRow pRow_1 in vRecordSet1.Tables[0].Rows)
                {
                    vTemIcon = pRow_1.Field<int>("status_interno");
                    if (vTemIcon > 0)
                        vTemIconHint = pRow_1.Field<string>("desc_acao");
                }

                //CRIAR BORDA
                Bor[iCont] = new Panel();
                Bor[iCont].Name = "Bor" + iCont;
                Bor[iCont].Location = new Point(10, vLin);
                Bor[iCont].Size = new Size(146, 186);

                if (cJovemSelect.Status == "0") { Bor[iCont].BackColor = pnlJovens.BackColor; }
                else { if (vTemIcon != -1) { Bor[iCont].BackColor = cJovens._Atividade(); } }

                if (cJovemSelect.AlertaRestante() > 0)
                {
                    //vTemIcon = 1000;
                    if (cJovemSelect.Alerta_Status == "Preventivo") Bor[iCont].BackColor = cJovens._Preventivo();
                    else if (cJovemSelect.Alerta_Status == "PIF") Bor[iCont].BackColor = cJovens._PIF();
                    else Bor[iCont].BackColor = cJovens._PrepSaida();
                }

                if (cJovemSelect.MedidaDisciplinarRestante() > 0)
                    Bor[iCont].BackColor = cJovens._MedidaDisciplinar();


                Bor[iCont].BorderStyle = BorderStyle.None;

                //CRIAR PANEL
                flws[iCont] = new Panel();
                flws[iCont].Name = "flw" + iCont;
                flws[iCont].Location = new Point(3, 3);
                flws[iCont].Size = new Size(140, 180);
                flws[iCont].BackColor = pnlJovens.BackColor;
                flws[iCont].BorderStyle = BorderStyle.None;
                if (cHint.Jovens) { cHint.Exibir(flws[iCont], cJovemSelect.Nome); }

                //CRIAR FOTO DO JOVEM
                pics[iCont] = new PictureBox();
                pics[iCont].Location = new Point(3, 3);
                pics[iCont].Name = "pic" + iCont;
                pics[iCont].Size = new Size(135, 135);
                pics[iCont].Image = Globais.ByteArrayToImage((Byte[])vRecordSet.Tables[0].Rows[iCont]["foto"]);
                pics[iCont].SizeMode = PictureBoxSizeMode.StretchImage;// CenterImage;
                pics[iCont].BackColor = pnlJovens.BackColor;
                pics[iCont].Click += new EventHandler(cJovens.Foto_Click);
                pics[iCont].DoubleClick += new EventHandler(cJovens.Foto_DoubleClick);
                if (cHint.Jovens) { cHint.Exibir(pics[iCont], cJovemSelect.Nome); }
                flws[iCont].Controls.Add(pics[iCont]);

                //CRIAR TEXTO COM O NOME DO JOVEM
                txts[iCont] = new Label();
                txts[iCont].Name = "txt" + iCont;
                txts[iCont].Text = cJovemSelect.Nome;
                txts[iCont].Location = new Point(5, 143);
                txts[iCont].Size = new Size(130, 30);
                txts[iCont].BackColor = pnlJovens.BackColor;
                txts[iCont].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                txts[iCont].TextAlign = ContentAlignment.TopCenter;
                txts[iCont].Click += new EventHandler(cJovens.Foto_Click);
                txts[iCont].DoubleClick += new EventHandler(cJovens.Foto_DoubleClick);
                if (cHint.Jovens) { cHint.Exibir(txts[iCont], cJovemSelect.Nome); }
                flws[iCont].Controls.Add(txts[iCont]);

                //CRIAR TEXTO COM ALA E QUARTO
                Ala[iCont] = new Label();
                Ala[iCont].Name = "ala" + iCont;
                Ala[iCont].Text = cJovemSelect.Ala_Corredor + cJovemSelect.Quarto;
                Ala[iCont].Location = new Point(1, 160);
                Ala[iCont].Size = new Size(30, 20);
                Ala[iCont].BackColor = pnlJovens.BackColor;
                Ala[iCont].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                Ala[iCont].TextAlign = ContentAlignment.TopLeft;
                Ala[iCont].Click += new EventHandler(cJovens.Foto_Click);
                Ala[iCont].DoubleClick += new EventHandler(cJovens.Foto_DoubleClick);
                flws[iCont].Controls.Add(Ala[iCont]);
                Ala[iCont].BringToFront();

                Bor[iCont].Controls.Add(flws[iCont]);

                //CRIAR CHECK BOX
                if ((cJovemSelect.MedidaDisciplinarRestante() > 0) || (vTemIcon > -1) || (cJovemSelect.AlertaRestante() > 0))
                {
                    ckj[iCont] = new CheckBox();
                    ckj[iCont].Name = "ckj" + iCont;
                    ckj[iCont].Text = "";
                    ckj[iCont].Location = new Point(Bor[iCont].Size.Width - 17, Bor[iCont].Size.Height - 17);
                    ckj[iCont].Size = new Size(18, 17);
                    ckj[iCont].Checked = false;
                    ckj[iCont].Click += new EventHandler(cJovens.Foto_Click);
                    Bor[iCont].Controls.Add(ckj[iCont]);
                    ckj[iCont].BringToFront();
                }

                //CRIAR CODIGO DO JOVEM
                Codigo[iCont] = new Label();
                Codigo[iCont].Name = "Cod" + iCont;
                Codigo[iCont].Text = Convert.ToString(cJovemSelect.Codigo);
                Codigo[iCont].Visible = false;
                Bor[iCont].Controls.Add(Codigo[iCont]);

                this.Controls.Add(Bor[iCont]);
                pnlJovens.Controls.Add(Bor[iCont]);
                //this.Controls.Add(Codigo[iCont]);
                //pnlJovens.Controls.Add(Codigo[iCont]);
                vLin += 210;

                if (vTemIcon != -1) { cJovens.f_icon_create(Bor[iCont], vTemIcon, vTemIconHint); }
                if ((vTemIcon == 19) || (vTemIcon == 21) || (vTemIcon == 22) || (vTemIcon == 24) || (vTemIcon == 25)) cJovens.f_jovem_desabilita_vem(Bor[iCont], true);
                iCont++;
            }

        }
        //---------------------------------------------------------
        // REDIMENSIONAR PANEL JOVEM
        //---------------------------------------------------------
        private void pnlJovens_Resize(object sender, EventArgs e)
        {
            Redimensionar_Fotos_Jovem(Globais.Tamanho);
        }
        private void statusStrip1_Resize(object sender, EventArgs e)
        {
            stSpace1.Text = "";
            stSpace1.Padding = new Padding((statusStrip1.Width - stUsu.Width - stDT.Width) - 20, 0, 0, 0);
        }
        //---------------------------------------------------------
        // CHECK SERVIDOR AO SELECIONAR
        //---------------------------------------------------------
        private void LsvServidor_MouseClick(object sender, MouseEventArgs e)
        {
            if (LsvServidor.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = LsvServidor.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                if (LsvServidor.Items[intselectedindex].Checked) { LsvServidor.Items[intselectedindex].Checked = false; }
                else { LsvServidor.Items[intselectedindex].Checked = true; }
            }
            LsvServidor.SelectedItems[0].Selected = false;
        }
        //---------------------------------------------------------
        // EXPANDIR AUTOMATICAMENTE A LISTVIEW AÇÕES
        //---------------------------------------------------------
        private void LsvAcoes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Parent == null)
                {
                    foreach (TreeNode node in LsvAcoes.Nodes)
                        node.Collapse();
                    if (e.Node.Nodes.Count > 0)
                        LsvAcoes.SelectedNode = e.Node.FirstNode;
                }
            }
            catch { }

            DataSet vRecordSet = new DataSet();
            vRecordSet = Consulta.Consultar("SELECT p_serv, p_interno FROM tb_acao WHERE (id_acao = " + LsvAcoes.SelectedNode.ImageIndex.ToString() + ");");
            try
            {
                int ip_serv = vRecordSet.Tables[0].Rows[0].Field<int>("p_serv");
                int ip_interno = vRecordSet.Tables[0].Rows[0].Field<int>("p_interno");
                pnlJovens.Enabled = true;
                pnlJovens.BackColor = Color.White;
                if (ip_interno == 0)
                {
                    pnlJovens.Enabled = false;
                    pnlJovens.BackColor = SystemColors.Control;
                }

                LsvServidor.Enabled = true;
                if (ip_serv == 1) cServidor.f_carregar_servidores(LsvServidor, LsvAcoes.SelectedNode.ImageIndex, buscar_servidor.Text);
                else LsvServidor.Enabled = false;

            }
            catch
            {
                pnlJovens.Enabled = true;
                pnlJovens.BackColor = Color.White;
                LsvServidor.Enabled = true;
                cServidor.f_carregar_servidores(LsvServidor, LsvAcoes.SelectedNode.ImageIndex, buscar_servidor.Text);
            }
        }
        //---------------------------------------------------------
        // ORDENAR LISTVIEW SERVIDOR - COLUMN CLICK
        //---------------------------------------------------------
        private void LsvServidor_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            LsvServidor.ListViewItemSorter = new ListViewItemComparer(e.Column);
            LsvServidor.Sort();
        }
        //---------------------------------------------------------
        // BUSCAR SERVIDOR LISTVIEW SERVIDOR
        //---------------------------------------------------------
        private void buscar_servidor_TextChanged(object sender, EventArgs e)
        {
            int asdf = buscar_servidor.Text.Length / 3;
            lbCharA.Text = buscar_servidor.Text.Length.ToString();
            lbChar.Text = asdf.ToString();

            if ((lbCharA.Text == "0") && (lbChar.Text == "0")) lbChar_TextChanged(sender, e);
        }
        private void lbChar_TextChanged(object sender, EventArgs e)
        {
            int parametro = -1;
            try { parametro = LsvAcoes.SelectedNode.ImageIndex; } catch { }
            cServidor.f_carregar_servidores(LsvServidor, parametro, buscar_servidor.Text);
        }
        //---------------------------------------------------------

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



        //---------------------------------------------------------
        // BOTÃO REGISTRAR AÇÃO
        //---------------------------------------------------------
        private void btnRegistraAcao_Click(object sender, EventArgs e)
        {
            /*          MessageBox.Show("       Plantao: "        + Globais.Plantao +
                                        "\n" + "Unidade: "        + Globais.Unidade +
                                        "\n" + "Módulo: "         + Globais.Modulo +
                                        "\n" + "id_acao: "        + v_id_acao.ToString() +
                                        "\n" + "desc_acao: "      + v_desc_acao +
                                        "\n" + "p_serv: "         + v_p_serv.ToString() +
                                        "\n" + "p_interno: "      + v_p_interno.ToString() +
                                        "\n" + "p_icon: "         + v_p_icon.ToString() +
                                        "\n" + "p_form: "         + v_p_form' +
                                        "\n" + "p_movimentacao: " + v_p_movimentacao +
                                        "\n" + "desc_frase: "     + sFrase);
                                                        
                                            JOVENS CODIGO =         ArrayServidoresSelecionados_Codigo
                                            JOVENS NOME =           ArrayServidoresSelecionados_Nome
                                            SERVIDORES CODIGO =     ArrayServidoresSelecionados_Codigo
                                            SERVIDORES NOME =       ArrayServidoresSelecionados_Nome

                                            vRetorno   RETORNA O TP_AÇÃO OU "" OU err   
            //----------------------------------------------------------------------------- */


            DataSet vRecordSet = new DataSet();

            //------------------------------------------------------------------------------
            //VERIFICA SERVIDOR, AÇÕES E JOVENS SE ESTÃO SELECIONADOS E INICIALIZA VARIAVEIS
            //------------------------------------------------------------------------------
            #region VerificaSelecao
            //---------------------------------------------------------

            int iAcaoSelecionada = -1;
            //---------------------------------------------------------------------------------
            //VERIFICAR SE É RETORNO
            string vRetorno = cJovens.f_icon_Selecionados();
            if ((vRetorno != "") && (vRetorno != "err"))
            {
                //CONECTAR BANCO DE DADOS
                vRecordSet = Consulta.Consultar("SELECT * FROM tb_acao WHERE(tb_acao.tp_acao = '" + vRetorno.ToString() + "');");
                if (vRecordSet.Tables[0].Rows.Count > 0)
                {
                    vRetorno = vRecordSet.Tables[0].Rows[0].Field<string>("desc_acao");
                    if ((vRetorno == "") || (vRetorno == null))
                        vRetorno = vRecordSet.Tables[0].Rows[0].Field<string>("desc_tp_acao");
                    iAcaoSelecionada = 0;
                }
            }
            //---------------------------------------------------------------------------------
            //VERIFICA SE TEM AÇÃO SELECIONADA
            if (iAcaoSelecionada == -1)
            {
                iAcaoSelecionada = cAcoes.f_acao_selecionada(LsvAcoes);
                if (iAcaoSelecionada == -1)
                {
                    MessageBox.Show("Selecione uma Ação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            //VERIFICA SE TEM AÇÃO ONDE É PRIORITARIO DO QUE O RETORNO DO SELECIONADO
            int iAcaoSelecionadaOcorrencia = 0;
            iAcaoSelecionadaOcorrencia = cAcoes.f_acao_selecionada(LsvAcoes);
            if (
                ((iAcaoSelecionadaOcorrencia > 31) && (iAcaoSelecionadaOcorrencia < 35)) ||   //OCORRENCIA
                ((iAcaoSelecionadaOcorrencia > 25) && (iAcaoSelecionadaOcorrencia < 32)) ||   //MOV SERVIDOR
                ((iAcaoSelecionadaOcorrencia == 10) || (iAcaoSelecionadaOcorrencia == 60)) || //TRANF PLANTAO - CONT MODULO
                ((iAcaoSelecionadaOcorrencia == 18) || (iAcaoSelecionadaOcorrencia == 20) || (iAcaoSelecionadaOcorrencia == 23))
                                                                                              //ENTRADA DE JOVENS
               )
            {
                iAcaoSelecionada = iAcaoSelecionadaOcorrencia;
                vRetorno = "";
            }
                

            //ALIMENTA VARIAVEIS ATRAVÉS DO BANCO DE DADOS
            int v_id_acao = -1;
            string v_desc_acao = "";
            int v_p_serv = -1;
            int v_p_interno = -1;
            int v_p_icon = -1;
            string v_p_form = "";
            string v_p_movimentacao = "";
            string v_desc_frase = "";
            //CONECTAR BANCO DE DADOS
            vRecordSet = Consulta.Consultar("SELECT * FROM tb_acao WHERE(tb_acao.id_acao = " + iAcaoSelecionada.ToString() + ");");
            foreach (DataRow pRow in vRecordSet.Tables[0].Rows)
            {
                //ARMAZENA OS VALORES DA CONSULTA
                v_id_acao = pRow.Field<int>("id_acao");
                v_desc_acao = pRow.Field<string>("desc_acao");
                if ((v_desc_acao == "") || (v_desc_acao == null)) v_desc_acao = pRow.Field<string>("desc_tp_acao");
                v_p_serv = pRow.Field<int>("p_serv");
                v_p_interno = pRow.Field<int>("p_interno");
                v_p_icon = pRow.Field<int>("p_icon");
                v_p_form = pRow.Field<string>("p_form");
                v_p_movimentacao = pRow.Field<string>("p_movimentacao");
                v_desc_frase = pRow.Field<string>("desc_frase");
            }
            //VERIFICA SE O ID ACAO ESTA CORRETO
            if (iAcaoSelecionada != v_id_acao)
            {
                MessageBox.Show("Falha de sistema na escolha da Ação !!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //---------------------------------------------------------------------------------
            //VERIFICA SE TEM SERVIDOR SELECIONADO
            string sServidoresSelecionados = cServidor.f_servidor_selecionado(LsvServidor);
            if ((vRetorno == "") || (vRetorno == "err"))
            {
                if ((sServidoresSelecionados == "") && (v_p_serv == 1))
                {
                    MessageBox.Show("Selecione pelo menos um servidor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            //---------------------------------------------------------------------------------
            //VERIFICA SE TEM JOVENS SELECIONADA
            string sJovensSelecionados = cJovens.f_jovens_selecionado();
            if ((sJovensSelecionados == "") && (v_p_interno == 1))
            {
                MessageBox.Show("Selecione pelo menos um jovem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //----------------------------
            //ID E NOME DOS JOVENS SELECIONADOS - E TEXTO DA FRASE DA ACAO
            string[] ArrayJovensSelecionados, ArrayJovensSelecionados_Codigo, ArrayJovensSelecionados_Nome;
            string sNomeJovensSelecionados = "";
            int iLengthJovensSelecionados = 0, iCountJovensSelecionados = 0;
            ArrayJovensSelecionados = null;
            ArrayJovensSelecionados_Codigo = null;
            ArrayJovensSelecionados_Nome = null;
            try
            {
                ArrayJovensSelecionados = sJovensSelecionados.Split('_');
                ArrayJovensSelecionados_Codigo = ArrayJovensSelecionados[0].Split(',');
                ArrayJovensSelecionados_Nome = ArrayJovensSelecionados[1].Split(',');
                iLengthJovensSelecionados = ArrayJovensSelecionados_Codigo.Length;
                foreach (string sCadaJovemSelecionado in ArrayJovensSelecionados_Nome)
                {
                    iCountJovensSelecionados++;
                    if (iCountJovensSelecionados == iLengthJovensSelecionados) sNomeJovensSelecionados = sNomeJovensSelecionados + sCadaJovemSelecionado;
                    else if (iCountJovensSelecionados == iLengthJovensSelecionados - 1) sNomeJovensSelecionados = sNomeJovensSelecionados + sCadaJovemSelecionado + " e ";
                    else sNomeJovensSelecionados = sNomeJovensSelecionados + sCadaJovemSelecionado + ", ";
                }
            }
            catch { }
            //----------------------------
            //ID E NOME DOS SERVIDORES SELECIONADOS - E TEXTO DA FRASE DA ACAO
            string[] ArrayServidoresSelecionados, ArrayServidoresSelecionados_Codigo, ArrayServidoresSelecionados_Nome;
            string sNomeServidoresSelecionados = "";
            int iLengthServidoresSelecionados = 0, iCountServidoresSelecionados = 0;
            ArrayServidoresSelecionados = null;
            ArrayServidoresSelecionados_Codigo = null;
            ArrayServidoresSelecionados_Nome = null;
            try
            {
                ArrayServidoresSelecionados = sServidoresSelecionados.Split('_');
                ArrayServidoresSelecionados_Codigo = ArrayServidoresSelecionados[0].Split(',');
                ArrayServidoresSelecionados_Nome = ArrayServidoresSelecionados[1].Split(',');
                iLengthServidoresSelecionados = ArrayServidoresSelecionados_Codigo.Length;
                foreach (string sCadaServidorSelecionado in ArrayServidoresSelecionados_Nome)
                {
                    iCountServidoresSelecionados++;
                    if (iCountServidoresSelecionados == iLengthServidoresSelecionados) sNomeServidoresSelecionados = sNomeServidoresSelecionados + sCadaServidorSelecionado;
                    else if (iCountServidoresSelecionados == iLengthServidoresSelecionados - 1) sNomeServidoresSelecionados = sNomeServidoresSelecionados + sCadaServidorSelecionado + " e ";
                    else sNomeServidoresSelecionados = sNomeServidoresSelecionados + sCadaServidorSelecionado + ", ";
                }
            }
            catch { }
            //----------------------------
            //TEXTO DA FRASE DA ACAO
            string sFrase = "";
            try
            {
                sFrase = v_desc_frase.Replace("_interno_", sNomeJovensSelecionados);
                sFrase = sFrase.Replace("_servidor_", sNomeServidoresSelecionados);
                sFrase = sFrase.Replace("_atividade_", vRetorno);
            }
            catch { }
            //---------------------------------------------------------
            #endregion VerificaSelecao
            //------------------------------------------------------------------------------
            //CARREGA O FORMULÁRIO DE REGISTRO DE MOVIMENTAÇÃO
            //------------------------------------------------------------------------------
            #region FORM_registro_livro
            if (v_p_form == "registro_livro")
            {
                //---------------------------------------------------------
                //ABRE O FORM REGISTRA NO LIVRO
                frm_registra_livro frm_registra_livro = new frm_registra_livro();
                //---------------------------------------------------------
                #region CarregaForm_registro_livro
                //---------------------------------------------------------
                try
                {
                    //--------------------------------------------------
                    //INDICES E DATAS DO SYSTEMA
                    frm_registra_livro.eAcao.Text = v_id_acao.ToString();
                    frm_registra_livro.eDTRegistro.Text = stDT.Text;
                    frm_registra_livro.eLOCAL_DT.Text = String.Format("{0:yyyy-MM-dd HH:mm}", DateTime.ParseExact(stDT.Text,
                                                                                                                   "dd/MM/yyyy HH:mm:ss",
                                                                                         System.Globalization.CultureInfo.InvariantCulture));
                    //--------------------------------------------------
                    //FRASE DO LIVRO
                    frm_registra_livro.eFrase.Text = sFrase;
                    //--------------------------------------------------
                    //DESCRIÇÃO DO RETORNO
                    frm_registra_livro.eRetorno.Text = vRetorno;
                    frm_registra_livro.lbRetorno.Visible = false;
                    if (vRetorno != "")
                        frm_registra_livro.lbRetorno.Visible = true;
                    //--------------------------------------------------
                    //LISTVIEW SERVIDORES
                    ListViewItem item1;
                    int iIndice = 0;
                    frm_registra_livro.eServidores.Items.Clear();
                    if (v_p_serv == 1)
                    {
                        foreach (string sCadaServidorSelecionado in ArrayServidoresSelecionados_Nome)
                        {
                            item1 = new ListViewItem(new[] { sCadaServidorSelecionado,
                                                 ArrayServidoresSelecionados_Codigo[iIndice] });
                            item1.ImageIndex = 0;
                            frm_registra_livro.eServidores.Items.Add(item1);
                            iIndice++;
                        }
                        frm_registra_livro.eServidores.Columns[0].Text = "Servidores selecionados: " + frm_registra_livro.eServidores.Items.Count.ToString();
                    }
                    //--------------------------------------------------
                    //LISTVIEW JOVENS
                    iIndice = 0;
                    frm_registra_livro.eJovens.Items.Clear();
                    if (v_p_interno == 1)
                    {
                        foreach (string sCadaJovemSelecionado in ArrayJovensSelecionados_Nome)
                        {
                            item1 = new ListViewItem(new[] { sCadaJovemSelecionado, ArrayJovensSelecionados_Codigo[iIndice] });
                            item1.ImageIndex = 0;
                            frm_registra_livro.eJovens.Items.Add(item1);
                            iIndice++;
                        }
                        frm_registra_livro.eJovens.Columns[0].Text = "Jovens selecionados: " + frm_registra_livro.eJovens.Items.Count.ToString();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_registro_livro
                //---------------------------------------------------------
                #region CarregaForm_registro_livro_AcoesResposta
                //---------------------------------------------------------
                try
                {
                    if (frm_registra_livro.ShowDialog(this) == DialogResult.OK)
                    {
                        // --------------------------------------------------------
                        // REGISTRA A AÇÃO
                        // --------------------------------------------------------
                        //CRIA ICONE E COLOCA A COR EM AZUL
                        int icorrigeerro_MedidaDisciplinar = 0;
                        if (v_p_icon == 1)
                        {
                            foreach (Control Bor in pnlJovens.Controls)
                            {
                                icorrigeerro_MedidaDisciplinar = 0;
                                if (Bor.BackColor == cJovens._Selecionado())
                                {
                                    Bor.BackColor = cJovens._Atividade();
                                    cJovens.f_icon_create(Bor, LsvAcoes.SelectedNode.ImageIndex, LsvAcoes.SelectedNode.Text);
                                }
                                else if (Bor.BackColor == cJovens._MedidaDisciplinar())
                                    foreach (Control cIcon in Bor.Controls)
                                        if (cIcon is CheckBox)
                                            if ((cIcon as CheckBox).Checked)
                                                if (icorrigeerro_MedidaDisciplinar == 0)
                                                {
                                                    cJovens.f_icon_create(Bor, LsvAcoes.SelectedNode.ImageIndex, LsvAcoes.SelectedNode.Text);
                                                    icorrigeerro_MedidaDisciplinar++;
                                                }
                            }
                        }
                        //------------------------------------------
                        //CRIA ICONE E COLOCA A COR EM VERMELHO
                        else if (v_p_icon == 3)
                        {
                            foreach (Control Bor in pnlJovens.Controls)
                            {
                                icorrigeerro_MedidaDisciplinar = 0;
                                if (Bor.BackColor == cJovens._Selecionado())
                                {
                                    cJovens.f_icon_create(Bor, LsvAcoes.SelectedNode.ImageIndex, LsvAcoes.SelectedNode.Text);
                                    cJovens.f_jovem_desabilita_vem(Bor, true);
                                }
                                else if (Bor.BackColor == cJovens._MedidaDisciplinar())
                                    foreach (Control cIcon in Bor.Controls)
                                        if (cIcon is CheckBox)
                                            if ((cIcon as CheckBox).Checked)
                                            {
                                                if (icorrigeerro_MedidaDisciplinar == 0)
                                                {
                                                    cJovens.f_icon_create(Bor, LsvAcoes.SelectedNode.ImageIndex, LsvAcoes.SelectedNode.Text);
                                                    cJovens.f_jovem_desabilita_vem(Bor, true);
                                                }
                                                icorrigeerro_MedidaDisciplinar++;
                                            }
                            }
                        }
                        //------------------------------------------
                        //EXCLUI ICONE E TIRA BORDA
                        else if (v_p_icon == 2)
                        {
                            string scodigo;
                            //TRANSIÇÃO PARA EXCLUIR O ICONE
                            foreach (Control Bor in pnlJovens.Controls)
                                if (Bor.Name.Substring(0, 3) == "Bor")
                                    foreach (Control cIcon in Bor.Controls)
                                        if (cIcon is CheckBox)
                                            if ((cIcon as CheckBox).Checked)
                                                Bor.BackColor = cJovens._Transicao();
                            //EXCLUIR O ICONE e CHECKBOX
                            foreach (Control Bor in pnlJovens.Controls)
                                if (Bor.Name.Substring(0, 3) == "Bor")
                                    if (Bor.BackColor == cJovens._Transicao())
                                    {
                                        scodigo = cJovens.f_Jovem_Codigo(Bor);
                                        cJovens.f_dados_jovem(scodigo);
                                        scodigo = cJovens.f_Jovem_Number_Sel(Bor);
                                        cJovens.f_jovem_desabilita_vem(Bor, false);
                                        //f_icon_destroy(Bor);

                                        //DELETA PAINEL
                                        foreach (Control cIcon in Bor.Controls)
                                        {
                                            if (cIcon.Name.Substring(0, 4) == "pnl_")
                                            {
                                                Bor.Controls.Remove(cIcon);
                                                cIcon.Dispose();
                                                break;
                                            }
                                        }
                                        if ((cJovemSelect.MedidaDisciplinarRestante() == 0) || (cJovemSelect.AlertaRestante() == 0))
                                        {
                                            Bor.BackColor = pnlJovens.BackColor;
                                            foreach (Control cIcon in Bor.Controls)
                                                if (cIcon.Name == "ckj" + scodigo)
                                                {
                                                    Bor.Controls.Remove(cIcon);
                                                    cIcon.Dispose();
                                                    break;
                                                }
                                        }
                                        else
                                            Bor.BackColor = cJovens._MedidaDisciplinar();
                                    }
                        }
                        //CHECKBOX = FALSO   e   ENABLED = TRUE
                        foreach (Control Bor in pnlJovens.Controls)
                        {
                            //CHECKBOX = FALSO
                            foreach (Control cIcon in Bor.Controls)
                            {
                                if (cIcon is CheckBox)
                                {
                                    (cIcon as CheckBox).Checked = false;
                                    Bor.Enabled = true;
                                    Bor.Cursor = Cursors.Arrow;
                                }
                                cIcon.Enabled = true;
                                cIcon.Cursor = Cursors.Arrow;
                            }
                            //ENABLED = TRUE
                            Bor.Enabled = true;
                            Bor.Cursor = Cursors.Arrow;
                        }
                    }
                    else MessageBox.Show("Registro Cancelado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar Layout.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_registro_livro_AcoesResposta
                //---------------------------------------------------------
                frm_registra_livro.Dispose();
            }
            #endregion FORM_registro_livro
            //------------------------------------------------------------------------------
            //CARREGA O FORMULÁRIO DE OCORRENCIA DISCIPLINAR
            //------------------------------------------------------------------------------
            #region FORM_ocorrencia
            else if (v_p_form == "ocorrencia")
            {
                //---------------------------------------------------------
                //ABRE O FORM REGISTRA NO LIVRO
                frm_registra_livro_ocorrencia frm_registra_livro_ocorrencia = new frm_registra_livro_ocorrencia();
                //---------------------------------------------------------
                #region CarregaForm_ocorrencia
                //---------------------------------------------------------
                try
                {
                    //--------------------------------------------------
                    //INDICES E DATAS DO SYSTEMA
                    frm_registra_livro_ocorrencia.eAcao.Text = v_id_acao.ToString();
                    frm_registra_livro_ocorrencia.eDTOcorrencia.Text = stDT.Text;
                    frm_registra_livro_ocorrencia.eLOCAL_DT.Text = String.Format("{0:yyyy-MM-dd HH:mm}", DateTime.ParseExact(stDT.Text,
                                                                                                                   "dd/MM/yyyy HH:mm:ss",
                                                                                         System.Globalization.CultureInfo.InvariantCulture));
                    //--------------------------------------------------
                    //FRASE DO LIVRO
                    frm_registra_livro_ocorrencia.eFrase.Text = sFrase;
                    //--------------------------------------------------
                    //DESCRIÇÃO DO RETORNO
                    frm_registra_livro_ocorrencia.eRetorno.Text = vRetorno;
                    //--------------------------------------------------
                    //LISTVIEW SERVIDORES
                    ListViewItem item1, item2;
                    int iIndice = 0;
                    frm_registra_livro_ocorrencia.eServidores.Items.Clear();
                    try
                    {
                        frm_registra_livro_ocorrencia.eServidores.Columns[0].Text = "Servidores envolvidos: 0";
                        //if (v_p_serv == 1)
                        //{
                        foreach (string sCadaServidorSelecionado in ArrayServidoresSelecionados_Nome)
                        {
                            item1 = new ListViewItem(new[] { sCadaServidorSelecionado,
                                                 ArrayServidoresSelecionados_Codigo[iIndice] });
                            item1.ImageIndex = 0;
                            frm_registra_livro_ocorrencia.eServidores.Items.Add(item1);
                            iIndice++;
                        }
                        frm_registra_livro_ocorrencia.eServidores.Columns[0].Text = "Servidores envolvidos: " + frm_registra_livro_ocorrencia.eServidores.Items.Count.ToString();
                        //}
                    }
                    catch { }

                    //--------------------------------------------------
                    //LISTVIEW JOVENS
                    iIndice = 0;
                    frm_registra_livro_ocorrencia.eJovens.Items.Clear();
                    try
                    {
                        frm_registra_livro_ocorrencia.eJovens.Columns[0].Text = "Jovens envolvidos: 0";
                        //if (v_p_interno == 1)
                        //{
                        foreach (string sCadaJovemSelecionado in ArrayJovensSelecionados_Nome)
                        {
                            item1 = new ListViewItem(new[] { sCadaJovemSelecionado, ArrayJovensSelecionados_Codigo[iIndice] });
                            item1.ImageIndex = 0;
                            frm_registra_livro_ocorrencia.eJovens.Items.Add(item1);

                            item2 = new ListViewItem(new[] { sCadaJovemSelecionado, "", "", ArrayJovensSelecionados_Codigo[iIndice] });
                            item2.ImageIndex = 0;
                            frm_registra_livro_ocorrencia.eJovensMD.Items.Add(item2);

                            iIndice++;
                        }
                        frm_registra_livro_ocorrencia.eJovens.Columns[0].Text = "Jovens envolvidos: " + frm_registra_livro_ocorrencia.eJovens.Items.Count.ToString();
                        //}
                    }
                    catch { }
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_ocorrencia
                //---------------------------------------------------------
                #region CarregaForm_ocorrencia_AcoesResposta
                //---------------------------------------------------------
                try
                {
                    if (frm_registra_livro_ocorrencia.ShowDialog(this) == DialogResult.OK)
                    {
                        // --------------------------------------------------------
                        // REGISTRA A AÇÃO
                        // --------------------------------------------------------
                        if (v_id_acao == 32)
                        {
                            Boolean TemCK = false;
                            CheckBox[] ckj = new CheckBox[50];
                            int i = 0;
                            string scodigo = "-1";
                            foreach (Control Bor in pnlJovens.Controls)
                                if (Bor.Name.Substring(0, 3) == "Bor")
                                {
                                    if (Bor.BackColor == cJovens._Desabilitado()) { continue; }
                                    TemCK = false;
                                    cJovens.f_dados_jovem(cJovens.f_Jovem_Codigo(Bor));
                                    if (cJovemSelect.MedidaDisciplinarRestante() > 0)
                                    {
                                        if (Bor.BackColor != cJovens._Desabilitado())
                                        {
                                            Bor.BackColor = cJovens._MedidaDisciplinar();
                                            foreach (Control cIcon in Bor.Controls)
                                            {
                                                if (cIcon.Name.Substring(0, 3) == "pnl")
                                                {
                                                    foreach (Control cPict in cIcon.Controls)
                                                        cPict.BackColor = cJovens._MedidaDisciplinar();
                                                    cIcon.BackColor = cJovens._MedidaDisciplinar();
                                                }
                                                if (cIcon is CheckBox) TemCK = true;
                                            }
                                            if (!TemCK)
                                            {
                                                scodigo = cJovens.f_Jovem_Number_Sel(Bor);
                                                Int32.TryParse(scodigo, out i);
                                                Bor.BackColor = cJovens._MedidaDisciplinar();
                                                ckj[i] = new CheckBox();
                                                ckj[i].Name = "ckj" + i;
                                                ckj[i].Text = "";
                                                ckj[i].Location = new Point(Bor.Size.Width - 17, Bor.Size.Height - 17);
                                                ckj[i].Size = new Size(18, 17);
                                                ckj[i].Checked = true;
                                                ckj[i].CheckedChanged += new EventHandler(cJovens.Foto_Click);
                                                Bor.Controls.Add(ckj[i]);
                                                ckj[i].BringToFront();
                                            }
                                            Bor.BackColor = cJovens._MedidaDisciplinar();
                                        }

                                    }
                                    else
                                    {
                                        vRecordSet = Consulta.Consultar("SELECT id_acao FROM tb_acao WHERE(tb_acao.id_acao = " + cJovemSelect.Status + ") AND (tb_acao.p_icon = 1);");
                                        if ((cJovemSelect.Status != "0") && (vRecordSet.Tables[0].Rows.Count > 0))
                                        {
                                            Bor.BackColor = cJovens._Atividade();
                                            foreach (Control cIcon in Bor.Controls)
                                                if (cIcon.Name.Substring(0, 3) == "pnl")
                                                {
                                                    foreach (Control cPict in cIcon.Controls)
                                                        cPict.BackColor = cJovens._Atividade();
                                                    cIcon.BackColor = cJovens._Atividade();
                                                }
                                        }
                                        else
                                        {
                                            Bor.BackColor = pnlJovens.BackColor;
                                            foreach (Control cIcon in Bor.Controls)
                                                if (cIcon.Name.Substring(0, 3) == "ckj")
                                                {
                                                    Bor.Controls.Remove(cIcon);
                                                    cIcon.Dispose();
                                                    break;
                                                }

                                        }
                                    }
                                }
                        }
                        //CHECKBOX = FALSO   e   ENABLED = TRUE
                        foreach (Control Bor in pnlJovens.Controls)
                        {
                            //CHECKBOX = FALSO
                            foreach (Control cIcon in Bor.Controls)
                            {
                                if (cIcon is CheckBox)
                                {
                                    (cIcon as CheckBox).Checked = false;
                                    Bor.Enabled = true;
                                    Bor.Cursor = Cursors.Arrow;
                                }
                                cIcon.Enabled = true;
                                cIcon.Cursor = Cursors.Arrow;
                            }
                            //ENABLED = TRUE
                            Bor.Enabled = true;
                            Bor.Cursor = Cursors.Arrow;
                        }
                    }
                    else MessageBox.Show("Registro Cancelado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar Layout.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_ocorrencia_AcoesResposta
                //---------------------------------------------------------
                frm_registra_livro_ocorrencia.Dispose();
            }
            #endregion FORM_ocorrencia





            //------------------------------------------------------------------------------
            //CARREGA O FORMULÁRIO DE ALERTA
            //------------------------------------------------------------------------------
            #region FORM_alerta
            else if (v_p_form == "alerta")
            {
                //---------------------------------------------------------
                //ABRE O FORM REGISTRA NO LIVRO
                frm_registra_livro_alerta frm_registra_livro_alerta = new frm_registra_livro_alerta();
                //---------------------------------------------------------
                #region CarregaForm_alerta
                //---------------------------------------------------------
                try
                {
                    //--------------------------------------------------
                    //INDICES E DATAS DO SYSTEMA
                    frm_registra_livro_alerta.eAcao.Text = v_id_acao.ToString();
                    frm_registra_livro_alerta.eDTAlerta.Text = stDT.Text;
                    frm_registra_livro_alerta.eLOCAL_DT.Text = String.Format("{0:yyyy-MM-dd HH:mm}", DateTime.ParseExact(stDT.Text,
                                                                                                                   "dd/MM/yyyy HH:mm:ss",
                                                                                         System.Globalization.CultureInfo.InvariantCulture));
                    //--------------------------------------------------
                    //DESCRIÇÃO DO ALERTA
                    if (v_id_acao == 37)
                    {
                        frm_registra_livro_alerta.eTipo.Text = "PIF";
                        frm_registra_livro_alerta.eTipo.ForeColor = cJovens._PIF();
                    }
                    else if (v_id_acao == 38)
                    {
                        frm_registra_livro_alerta.eTipo.Text = "Preventivo";
                        frm_registra_livro_alerta.eTipo.ForeColor = cJovens._Preventivo();
                    }
                    else if (v_id_acao == 39)
                    {
                        frm_registra_livro_alerta.eTipo.Text = "Preparação de Saída";
                        frm_registra_livro_alerta.eTipo.ForeColor = cJovens._PrepSaida();
                    }
                    //--------------------------------------------------
                    //DESCRIÇÃO DO RETORNO
                    frm_registra_livro_alerta.eRetorno.Text = vRetorno;

                    //--------------------------------------------------
                    //LISTVIEW JOVENS
                    ListViewItem item1;
                    int iIndice = 0;
                    frm_registra_livro_alerta.eJovens.Items.Clear();
                    try
                    {
                        frm_registra_livro_alerta.eJovens.Columns[0].Text = "Jovens envolvidos: 0";
                        foreach (string sCadaJovemSelecionado in ArrayJovensSelecionados_Nome)
                        {
                            item1 = new ListViewItem(new[] { sCadaJovemSelecionado, "100", ArrayJovensSelecionados_Codigo[iIndice] });
                            item1.ImageIndex = 0;
                            frm_registra_livro_alerta.eJovens.Items.Add(item1);
                            iIndice++;
                        }
                        frm_registra_livro_alerta.eJovens.Columns[0].Text = "Jovens envolvidos: " + frm_registra_livro_alerta.eJovens.Items.Count.ToString();
                    }
                    catch { }
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_alerta
                //---------------------------------------------------------
                #region CarregaForm_alerta_AcoesResposta
                //---------------------------------------------------------
                try
                {
                    if (frm_registra_livro_alerta.ShowDialog(this) == DialogResult.OK)
                    {
                        MessageBox.Show(v_id_acao.ToString());
                    }
                    
                    if (frm_registra_livro_alerta.ShowDialog(this) == DialogResult.OK)
                    {
                        // --------------------------------------------------------
                        // REGISTRA A AÇÃO
                        // --------------------------------------------------------
                        if (v_id_acao == 32)
                        {
                            Boolean TemCK = false;
                            CheckBox[] ckj = new CheckBox[50];
                            int i = 0;
                            string scodigo = "-1";
                            foreach (Control Bor in pnlJovens.Controls)
                                if (Bor.Name.Substring(0, 3) == "Bor")
                                {
                                    if (Bor.BackColor == cJovens._Desabilitado()) { continue; }
                                    TemCK = false;
                                    cJovens.f_dados_jovem(cJovens.f_Jovem_Codigo(Bor));
                                    if (cJovemSelect.MedidaDisciplinarRestante() > 0)
                                    {
                                        if (Bor.BackColor != cJovens._Desabilitado())
                                        {
                                            Bor.BackColor = cJovens._MedidaDisciplinar();
                                            foreach (Control cIcon in Bor.Controls)
                                            {
                                                if (cIcon.Name.Substring(0, 3) == "pnl")
                                                {
                                                    foreach (Control cPict in cIcon.Controls)
                                                        cPict.BackColor = cJovens._MedidaDisciplinar();
                                                    cIcon.BackColor = cJovens._MedidaDisciplinar();
                                                }
                                                if (cIcon is CheckBox) TemCK = true;
                                            }
                                            if (!TemCK)
                                            {
                                                scodigo = cJovens.f_Jovem_Number_Sel(Bor);
                                                Int32.TryParse(scodigo, out i);
                                                Bor.BackColor = cJovens._MedidaDisciplinar();
                                                ckj[i] = new CheckBox();
                                                ckj[i].Name = "ckj" + i;
                                                ckj[i].Text = "";
                                                ckj[i].Location = new Point(Bor.Size.Width - 17, Bor.Size.Height - 17);
                                                ckj[i].Size = new Size(18, 17);
                                                ckj[i].Checked = true;
                                                ckj[i].CheckedChanged += new EventHandler(cJovens.Foto_Click);
                                                Bor.Controls.Add(ckj[i]);
                                                ckj[i].BringToFront();
                                            }
                                            Bor.BackColor = cJovens._MedidaDisciplinar();
                                        }

                                    }
                                    else
                                    {
                                        vRecordSet = Consulta.Consultar("SELECT id_acao FROM tb_acao WHERE(tb_acao.id_acao = " + cJovemSelect.Status + ") AND (tb_acao.p_icon = 1);");
                                        if ((cJovemSelect.Status != "0") && (vRecordSet.Tables[0].Rows.Count > 0))
                                        {
                                            Bor.BackColor = cJovens._Atividade();
                                            foreach (Control cIcon in Bor.Controls)
                                                if (cIcon.Name.Substring(0, 3) == "pnl")
                                                {
                                                    foreach (Control cPict in cIcon.Controls)
                                                        cPict.BackColor = cJovens._Atividade();
                                                    cIcon.BackColor = cJovens._Atividade();
                                                }
                                        }
                                        else
                                        {
                                            Bor.BackColor = pnlJovens.BackColor;
                                            foreach (Control cIcon in Bor.Controls)
                                                if (cIcon.Name.Substring(0, 3) == "ckj")
                                                {
                                                    Bor.Controls.Remove(cIcon);
                                                    cIcon.Dispose();
                                                    break;
                                                }

                                        }
                                    }
                                }
                        }
                        //CHECKBOX = FALSO   e   ENABLED = TRUE
                        foreach (Control Bor in pnlJovens.Controls)
                        {
                            //CHECKBOX = FALSO
                            foreach (Control cIcon in Bor.Controls)
                            {
                                if (cIcon is CheckBox)
                                {
                                    (cIcon as CheckBox).Checked = false;
                                    Bor.Enabled = true;
                                    Bor.Cursor = Cursors.Arrow;
                                }
                                cIcon.Enabled = true;
                                cIcon.Cursor = Cursors.Arrow;
                            }
                            //ENABLED = TRUE
                            Bor.Enabled = true;
                            Bor.Cursor = Cursors.Arrow;
                        }
                    }
                    else MessageBox.Show("Registro Cancelado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar Layout.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_alerta_AcoesResposta
                //---------------------------------------------------------
                frm_registra_livro_alerta.Dispose();
            }
            #endregion FORM_alerta








            //------------------------------------------------------------------------------
            //CARREGA O FORMULÁRIO DE ENTRADA DO JOVEM
            //------------------------------------------------------------------------------
            #region FORM_entrada_jovem
            if (v_p_form == "entrada_jovem")
            {
                frm_sel_jovem_todos frm_sel_jovem_todos = new frm_sel_jovem_todos();
                frm_registra_livro_entrada_jovem frm_registra_livro_entrada_jovem = new frm_registra_livro_entrada_jovem();
                //---------------------------------------------------------
                //ABRE O FORM REGISTRA NO LIVRO
                //---------------------------------------------------------
                #region CarregaForm_entrada_jovem
                //---------------------------------------------------------
                try
                {                //DIFERENTE DE MUDANCA DE QUARTO
                    if (iAcaoSelecionada != 23)
                    {
                        frm_sel_jovem_todos.lbAcao.Text = v_id_acao.ToString();
                        if (frm_sel_jovem_todos.ShowDialog(this) == DialogResult.Cancel)
                        {
                            MessageBox.Show("Registro Cancelado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (frm_sel_jovem_todos.eJovens.SelectedItems.Count == 0)
                        {
                            MessageBox.Show("Nenhum Jovem foi selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    //--------------------------------------------------
                    //INDICES E DATAS DO SYSTEMA
                    frm_registra_livro_entrada_jovem.eAcao.Text = v_id_acao.ToString();
                    frm_registra_livro_entrada_jovem.eDTRegistro.Text = stDT.Text;
                    frm_registra_livro_entrada_jovem.eLOCAL_DT.Text = String.Format("{0:yyyy-MM-dd HH:mm}", DateTime.ParseExact(stDT.Text,
                                                                                                                   "dd/MM/yyyy HH:mm:ss",
                                                                                         System.Globalization.CultureInfo.InvariantCulture));
                    frm_registra_livro_entrada_jovem.eRetorno.Text = "";
                    //--------------------------------------------------
                    //LISTVIEW SERVIDORES
                    ListViewItem item1;
                    int iIndice = 0;
                    frm_registra_livro_entrada_jovem.eServidores.Items.Clear();
                    foreach (string sCadaServidorSelecionado in ArrayServidoresSelecionados_Nome)
                    {
                        item1 = new ListViewItem(new[] { sCadaServidorSelecionado, ArrayServidoresSelecionados_Codigo[iIndice] });
                        item1.ImageIndex = 0;
                        frm_registra_livro_entrada_jovem.eServidores.Items.Add(item1);
                        iIndice++;
                    }
                    //--------------------------------------------------
                    //LISTVIEW JOVENS
                    frm_registra_livro_entrada_jovem.eJovens.Items.Clear();
                    if (iAcaoSelecionada == 23)
                    {
                        iIndice = 0;
                        foreach (string sCadaJovemSelecionado in ArrayJovensSelecionados_Nome)
                        {
                            cJovens.f_dados_jovem(ArrayJovensSelecionados_Codigo[iIndice]);
                            item1 = new ListViewItem(new[] { sCadaJovemSelecionado, cJovemSelect.Ala_Corredor, cJovemSelect.Quarto, ArrayJovensSelecionados_Codigo[iIndice] });
                            item1.ImageIndex = 0;
                            frm_registra_livro_entrada_jovem.eJovens.Items.Add(item1);
                            iIndice++;
                        }
                    }
                    else
                    {
                        sNomeJovensSelecionados = "";
                        foreach (ListViewItem itemSel in frm_sel_jovem_todos.eJovens.SelectedItems)
                        {
                            sNomeJovensSelecionados = sNomeJovensSelecionados + ", " + itemSel.Text;
                            item1 = new ListViewItem(new[] { itemSel.Text, "", "", itemSel.SubItems[1].Text });
                            item1.ImageIndex = 0;
                            frm_registra_livro_entrada_jovem.eJovens.Items.Add(item1);
                        }
                    }
                    frm_registra_livro_entrada_jovem.lbJovens.Text = "Jovens selecionados: " + frm_registra_livro_entrada_jovem.eJovens.Items.Count.ToString();
                    //--------------------------------------------------
                    //FRASE DO LIVRO
                    sNomeJovensSelecionados = sNomeJovensSelecionados.Substring(2, sNomeJovensSelecionados.Length - 2);
                    sFrase = sFrase.Replace("_internonovo_", sNomeJovensSelecionados);
                    frm_registra_livro_entrada_jovem.eFrase.Text = sFrase;
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_entrada_jovem
                //---------------------------------------------------------
                #region CarregaForm_entrada_jovem_AcoesResposta
                //---------------------------------------------------------
                try
                {
                    if (frm_registra_livro_entrada_jovem.ShowDialog(this) == DialogResult.OK)
                    {
                        //LISTVIEW JOVENS
                        pnlJovens.BackColor = Color.White;
                        if ((iAcaoSelecionada == 18) || (iAcaoSelecionada == 20)) // <> (iAcaoSelecionada == 23)
                        {
                            carregarjovensOrderBy(cJovens.ViewOrderBy);
                        }
                        else
                        {
                            //CHECKBOX = FALSO   e   ENABLED = TRUE
                            foreach (Control Bor in pnlJovens.Controls)
                            {
                                //CHECKBOX = FALSO
                                foreach (Control cIcon in Bor.Controls)
                                {
                                    if (cIcon is CheckBox) (cIcon as CheckBox).Checked = false;
                                    cIcon.Enabled = true;
                                    cIcon.Cursor = Cursors.Arrow;
                                }
                                //ENABLED = TRUE
                                Bor.Enabled = true;
                                Bor.Cursor = Cursors.Arrow;
                            }
                        }


                    }
                    else MessageBox.Show("Registro Cancelado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar Layout.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_entrada_jovem_AcoesResposta
                //---------------------------------------------------------
                frm_registra_livro_entrada_jovem.Dispose();
                frm_sel_jovem_todos.Dispose();
            }
            #endregion FORM_entrada_jovem
            //------------------------------------------------------------------------------
            //CARREGA O FORMULÁRIO DE MOVIMENTAÇÃO DO SERVIDOR_ENTRADA
            //------------------------------------------------------------------------------
            #region FORM_movim_servidor_ent

            else if (v_p_form == "movim_servidor_ent")
            {
                frm_sel_servidor_todos frm_sel_servidor_todos = new frm_sel_servidor_todos();
                frm_registra_livro_mov_servidor frm_registra_livro_mov_servidor = new frm_registra_livro_mov_servidor();
                //---------------------------------------------------------
                //ABRE O FORM REGISTRA NO LIVRO
                //---------------------------------------------------------
                #region CarregaForm_frm_mov_servidor_ent
                //---------------------------------------------------------
                try
                {                //DIFERENTE DE MUDANCA DE QUARTO
                    frm_sel_servidor_todos.lbAcao.Text = v_id_acao.ToString();
                    if (frm_sel_servidor_todos.ShowDialog(this) == DialogResult.Cancel)
                    {
                        MessageBox.Show("Registro Cancelado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (frm_sel_servidor_todos.eServidores.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Nenhum Servidor foi selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //--------------------------------------------------
                    //INDICES E DATAS DO SYSTEMA
                    frm_registra_livro_mov_servidor.eAcao.Text = v_id_acao.ToString();
                    frm_registra_livro_mov_servidor.eDTRegistro.Text = stDT.Text;
                    frm_registra_livro_mov_servidor.eLOCAL_DT.Text = String.Format("{0:yyyy-MM-dd HH:mm}", DateTime.ParseExact(stDT.Text,
                                                                                                                   "dd/MM/yyyy HH:mm:ss",
                                                                                         System.Globalization.CultureInfo.InvariantCulture));
                    frm_registra_livro_mov_servidor.eRetorno.Text = "";
                    //--------------------------------------------------
                    //LISTVIEW SERVIDORES
                    ListViewItem item1;
                    frm_registra_livro_mov_servidor.eServidores.Items.Clear();
                    sNomeServidoresSelecionados = "";
                    foreach (ListViewItem itemSel in frm_sel_servidor_todos.eServidores.SelectedItems)
                    {
                        sNomeServidoresSelecionados = sNomeServidoresSelecionados + ", " + itemSel.Text;
                        item1 = new ListViewItem(new[] { itemSel.Text, itemSel.SubItems[1].Text });
                        item1.ImageIndex = 0;
                        frm_registra_livro_mov_servidor.eServidores.Items.Add(item1);
                    }
                    frm_registra_livro_mov_servidor.lbServidores.Text = "Servidores selecionados: " + frm_registra_livro_mov_servidor.eServidores.Items.Count.ToString();
                    //--------------------------------------------------
                    //FRASE DO LIVRO
                    sNomeServidoresSelecionados = sNomeServidoresSelecionados.Substring(2, sNomeServidoresSelecionados.Length - 2);
                    sFrase = sFrase.Replace("_servidornovo_", sNomeServidoresSelecionados);
                    frm_registra_livro_mov_servidor.eFrase.Text = sFrase;
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_frm_mov_servidor_ent
                //---------------------------------------------------------
                #region CarregaForm_frm_mov_servidor_ent_AcoesResposta
                //---------------------------------------------------------
                try
                {
                    int i = -1;
                    Int32.TryParse(frm_registra_livro_mov_servidor.eAcao.Text, out i);
                    if (frm_registra_livro_mov_servidor.ShowDialog(this) == DialogResult.OK)
                        cServidor.f_carregar_servidores(LsvServidor,i, buscar_servidor.Text);
                    else
                        MessageBox.Show("Registro Cancelado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar Layout.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_frm_mov_servidor_ent_AcoesResposta
                //---------------------------------------------------------
                frm_registra_livro_mov_servidor.Dispose();
                frm_sel_servidor_todos.Dispose();
            }
            #endregion FORM_movim_servidor_ent
            //------------------------------------------------------------------------------
            //CARREGA O FORMULÁRIO DE MOVIMENTAÇÃO DO SERVIDOR
            //------------------------------------------------------------------------------
            #region FORM_movim_servidor

            else if (v_p_form == "movim_servidor")
            {
                frm_registra_livro_mov_servidor frm_registra_livro_mov_servidor = new frm_registra_livro_mov_servidor();
                //DIFERENTE DE MUDANCA DE QUARTO
                //---------------------------------------------------------
                //ABRE O FORM REGISTRA NO LIVRO
                //---------------------------------------------------------
                #region CarregaForm_frm_mov_servidor
                //---------------------------------------------------------
                try
                {
                    //--------------------------------------------------
                    //INDICES E DATAS DO SYSTEMA
                    frm_registra_livro_mov_servidor.eAcao.Text = v_id_acao.ToString();
                    frm_registra_livro_mov_servidor.eDTRegistro.Text = stDT.Text;
                    frm_registra_livro_mov_servidor.eLOCAL_DT.Text = String.Format("{0:yyyy-MM-dd HH:mm}", DateTime.ParseExact(stDT.Text,
                                                                                                                   "dd/MM/yyyy HH:mm:ss",
                                                                                         System.Globalization.CultureInfo.InvariantCulture));
                    frm_registra_livro_mov_servidor.eRetorno.Text = "";
                    //--------------------------------------------------
                    //LISTVIEW SERVIDORES
                    ListViewItem item1;
                    int iIndice = 0;
                    frm_registra_livro_mov_servidor.eServidores.Items.Clear();
                    if (v_p_serv == 1)
                    {
                        foreach (string sCadaServidorSelecionado in ArrayServidoresSelecionados_Nome)
                        {
                            item1 = new ListViewItem(new[] { sCadaServidorSelecionado,
                                                 ArrayServidoresSelecionados_Codigo[iIndice] });
                            item1.ImageIndex = 0;
                            frm_registra_livro_mov_servidor.eServidores.Items.Add(item1);
                            iIndice++;
                        }
                        frm_registra_livro_mov_servidor.eServidores.Columns[0].Text = "Servidores selecionados: " + frm_registra_livro_mov_servidor.eServidores.Items.Count.ToString();
                    }
                    //--------------------------------------------------
                    //FRASE DO LIVRO
                    sNomeServidoresSelecionados = sNomeServidoresSelecionados.Substring(0, sNomeServidoresSelecionados.Length);
                    sFrase = sFrase.Replace("_servidornovo_", sNomeServidoresSelecionados);
                    frm_registra_livro_mov_servidor.eFrase.Text = sFrase;
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_frm_mov_servidor
                //---------------------------------------------------------
                #region CarregaForm_frm_mov_servidor_AcoesResposta
                //---------------------------------------------------------
                try
                {
                    int i = -1;
                    Int32.TryParse(frm_registra_livro_mov_servidor.eAcao.Text, out i);
                    if (frm_registra_livro_mov_servidor.ShowDialog(this) == DialogResult.OK)
                        cServidor.f_carregar_servidores(LsvServidor, i, buscar_servidor.Text);
                    else
                        MessageBox.Show("Registro Cancelado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar Layout.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------------------------------------------
                #endregion CarregaForm_frm_mov_servidor_AcoesResposta
                //---------------------------------------------------------
                frm_registra_livro_mov_servidor.Dispose();
            }

            #endregion FORM_movim_servidor
            //------------------------------------------------------------------------------
            //CARREGA O FORMULÁRIO DE CONFERENCIA DO MODULO
            //------------------------------------------------------------------------------
            #region FORM_conferencia

            else if (v_p_form == "conferencia")
            {
                MessageBox.Show("CONFERENCIA DO MODULO");
            }

            #endregion FORM_conferencia


            //------------------------------------------------------------------------------
            //AO FINALIZAR SELECIONA O NODE "Atividade com Socioeducandos"
            //LsvAcoes.Focus();
            //TreeNode treeNode = LsvAcoes.Nodes[3];
            //LsvAcoes.SelectedNode = treeNode;

            //------------------------------------------------------------------------------
            //TOTAL DE JOVENSNO MÓDULO
            int iCountJovens = 0;
            foreach (Control Bor in pnlJovens.Controls)
                if (Bor.Name.Substring(0, 3) == "Bor")
                    if (Bor.BackColor != cJovens._Desabilitado()) iCountJovens++;
            lb_total_jovens.Text = "Total de Jovens: " + iCountJovens.ToString();
            cJovens.TotalJovens = iCountJovens;
        }
        //---------------------------------------------------------


        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            MessageBox.Show(appPath);
        }

        private void LsvAcoes_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(LsvAcoes.SelectedNode.ImageIndex.ToString() + " - " + LsvAcoes.SelectedNode.Text);
            cServidor.f_carregar_servidores(LsvServidor, LsvAcoes.SelectedNode.ImageIndex, buscar_servidor.Text);
            this.Cursor = Cursors.WaitCursor;
            pnlJovens.Visible = false;
            try
            {

            }
            finally
            {
                this.Cursor = Cursors.Arrow;
                pnlJovens.Visible = true;
            }

        }
        
    }

}

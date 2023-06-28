using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DITI_LIVROM
{
    
    public static class cJovens
    {
        
        public static Color _Transicao() { return Color.LavenderBlush; }
        public static Color _Atividade() { return Color.Blue; }
        public static Color _MedidaDisciplinar() { return Color.Magenta; }
        public static Color _Desabilitado() { return Color.Red; }
        public static Color _DesabilitadoSub() { return Color.LightCoral; }
        
        public static Color _Selecionado() { return Color.LightBlue; }
        public static Color _Quarto() { return Color.Black; }
        
        //---------------------------------------------------------
        // TOTAL DE JOVENS
        //---------------------------------------------------------
        private static int _vTotalJovens = 0;
        public static int TotalJovens
        {
            get { return _vTotalJovens; }
            set { _vTotalJovens = value; }
        }
        //---------------------------------------------------------
        // RETORNAR O NUMERO DO COMPONENTE DO  JOVEM
        //---------------------------------------------------------
        public static string f_Jovem_Number_Sel(object sender)
        {
            string result = "-1";
            try
            {
                int i = 0;
                string scodigo = "";
                scodigo = (sender as Control).Name;
                i = scodigo.Length;
                if (i > 1) { result = scodigo.Substring(3, i - 3); }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = "-1";
            }
            return result;
        }
        //---------------------------------------------------------
        //---------------------------------------------------------
        // RETORNAR O CÓDIGO DO  JOVEM
        //---------------------------------------------------------
        public static string f_Jovem_Codigo(object sender)
        {
            string result = "-1";
            try
            {
                string scodigo = f_Jovem_Number_Sel(sender);
                foreach (Form _Forms in Application.OpenForms)
                    foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                        if (_Controles.Name == "pnlJovens")
                            foreach (Control c in _Controles.Controls)
                            {
                                if (c.Name == "Cod" + scodigo)
                                {
                                    result = c.Text;
                                    break;
                                }
                            }
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = "-1";
            }
            return result;
        }
        //---------------------------------------------------------
        //---------------------------------------------------------
        // RETORNAR O NOME DO  JOVEM
        //---------------------------------------------------------
        public static string f_Jovem_Nome(Control BorControl)
        {
            string result = "";
            try
            {
                string scodigo = f_Jovem_Number_Sel(BorControl);
                foreach (Control cflw in BorControl.Controls)
                    if (cflw.Name == "flw" + scodigo)
                        foreach (Control clabel in cflw.Controls)
                            if (clabel.Name == "txt" + scodigo) result = clabel.Text;
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        //---------------------------------------------------------
        //---------------------------------------------------------
        // SELECIONAR JOVEM
        //---------------------------------------------------------
        public static void f_Jovem_Sel(object sender)
        {
            try
            {
                //Verifica se o CheckBox foi selecionado
                Boolean is_ckb = false;
                if (sender is CheckBox) { is_ckb = true; }
                //DECLARA E INICIALIZA VARIAVEIS
                CheckBox[] ckj = new CheckBox[50];
                int i = 0;
                string scodigo = cJovens.f_Jovem_Number_Sel(sender);
                Int32.TryParse(scodigo, out i);
                //PROCURA JOVEM SELECIONADO
                foreach (Form _Forms in Application.OpenForms)
                    foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                        if (_Controles.Name == "pnlJovens")
                            foreach (Control c in _Controles.Controls)
                                if (c.Name == "Bor" + scodigo)
                                {
                                    //TIRAR SELEÇÃO DO JOVEM
                                    if (c.BackColor == _Selecionado())
                                    {
                                        c.BackColor = _Controles.BackColor;
                                        foreach (Control cIcon in c.Controls)
                                        {
                                            if (cIcon.Name == "ckj" + i)
                                            {
                                                c.Controls.Remove(cIcon);
                                                cIcon.Dispose();
                                                break;
                                            }
                                        }
                                    }
                                    //SELECIONA O JOVEM
                                    else if (c.BackColor == _Controles.BackColor)
                                    {
                                        c.BackColor = _Selecionado();
                                        ckj[i] = new CheckBox();
                                        ckj[i].Name = "ckj" + i;
                                        ckj[i].Text = "";
                                        ckj[i].Location = new Point(c.Size.Width - 17, c.Size.Height - 17);
                                        ckj[i].Size = new Size(18, 17);
                                        ckj[i].Checked = true;
                                        ckj[i].CheckedChanged += new EventHandler(Foto_Click);
                                        c.Controls.Add(ckj[i]);
                                        ckj[i].BringToFront();
                                    }
                                    //SELECIONA O JOVEM EM ATIVIDADE
                                    else if ((c.BackColor == _Atividade()) || (c.BackColor == _MedidaDisciplinar()) || (c.BackColor == _Desabilitado()))
                                    {
                                        //Se o CheckBox foi selecionado SAI
                                        if (is_ckb) { break; }
                                        //Se o CheckBox foi selecionado CONTINUA
                                        foreach (Control cIcon in c.Controls)
                                        {
                                            if (cIcon.Name == "ckj" + i)
                                            {
                                                if ((cIcon as CheckBox).Checked) { (cIcon as CheckBox).Checked = false; }
                                                else { (cIcon as CheckBox).Checked = true; }
                                                break;
                                            }
                                        }
                                    }
                                    break;
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
        //---------------------------------------------------------
        //---------------------------------------------------------
        // CONVERTE A IMAGEM DO JOVEM DE BINARIO PARA IMAGEM
        //---------------------------------------------------------
        public static Image f_foto_jovem(byte[] arrImg)
        {
            MemoryStream stmBLOBData;
            ImageConverter imgConv;
            Image result;
            try
            {
                stmBLOBData = new MemoryStream(arrImg);
                imgConv = new ImageConverter();
                result = (Image)imgConv.ConvertFrom(arrImg);
            }
            catch   { result = null; }
            return result; 
        }
        //---------------------------------------------------------
        //---------------------------------------------------------
        // TRAZ OS DADOS DO JOVEM
        //---------------------------------------------------------
        public static void f_dados_jovem(string nJov)
        {
            try
            {
                //-----------------------------
                //INICIALIZAR JOVENS
                //-----------------------------
                //DECLARAR VARIAVEIS
                DataSet RecordSet = new DataSet();
                cJovemSelect.Codigo = "0";
                cJovemSelect.Nome = "";
                cJovemSelect.Ala_Corredor = "";
                cJovemSelect.Quarto = "";
                cJovemSelect.Status = "-1"; 
                cJovemSelect.MedidaDisciplinar_Data = "0";
                cJovemSelect.MedidaDisciplinar_Dia = "0";
                //CONECTAR BANCO DE DADOS
                RecordSet = Consulta.Consultar("SELECT tb_unidade_interno.id_unidade, tb_unidade_interno.id_modulo, tb_interno.id_interno, " +
                                                  "tb_interno.nome_interno, tb_interno.foto, tb_unidade_interno.n_quarto, tb_unidade_interno.n_ala,  " +
                                                  "tb_unidade_interno.status_interno, Format([medida_disc_data_interno],'dd/mm/yyyy') AS data_medida, tb_unidade_interno.medida_disc_dia_interno " +
                                           "FROM tb_interno INNER JOIN tb_unidade_interno ON tb_interno.id_interno = tb_unidade_interno.id_interno  " +
                                           "WHERE((tb_unidade_interno.id_unidade = '" + Globais.Unidade + "')  " +
                                           " AND(tb_unidade_interno.id_modulo = '" + Globais.Modulo + "')  " +
                                           " AND(tb_interno.id_interno = '" + nJov + "')); ");
                //PREENCHER DADOS
                foreach (DataRow pRow in RecordSet.Tables[0].Rows)
                {
                    cJovemSelect.Codigo = pRow.Field<string>("id_interno");
                    cJovemSelect.Nome = pRow.Field<string>("nome_interno");
                    cJovemSelect.Foto = f_foto_jovem((Byte[])RecordSet.Tables[0].Rows[0]["foto"]);
                    cJovemSelect.Ala_Corredor = pRow.Field<string>("n_ala");
                    cJovemSelect.Quarto = pRow.Field<string>("n_quarto");
                    cJovemSelect.Status = Convert.ToString(pRow.Field<int>("status_interno"));
                    cJovemSelect.MedidaDisciplinar_Data = pRow.Field<string>("data_medida");
                    cJovemSelect.MedidaDisciplinar_Dia = pRow.Field<string>("medida_disc_dia_interno");
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
        //---------------------------------------------------------
        //---------------------------------------------------------
        // CARREGAR ICONES AÇÃO
        //---------------------------------------------------------
        public static Image f_icon_carregar(string channel)
        {
            try
            {
                object o = Properties.Resources.ResourceManager.GetObject("_" + channel);
                if (o is Image)
                    return o as Image;
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        //---------------------------------------------------------
        //---------------------------------------------------------
        // VERIFICAR O TIPO DE AÇÃO NO ICONE AÇÕES SELECIONADOS
        //---------------------------------------------------------
        public static string f_icon_Selecionados()
        {
            string vTipoIcon = "";

            try
            {
                foreach (Form _Forms in Application.OpenForms)
                    foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                        if (_Controles.Name == "pnlJovens")
                        {
                            //TODOS CHECKBOX DA AÇÃO SELECIONADA = TRUE
                            foreach (Control Bor in _Controles.Controls)
                            {
                                if (Bor.Name.Substring(0, 3) == "Bor")
                                {
                                    if (Bor.Enabled)
                                        foreach (Control cPnl in Bor.Controls)
                                        {
                                            //MessageBox.Show(cPnl.Name);
                                            foreach (Control cIcon in cPnl.Controls)
                                                if (cIcon is PictureBox)
                                                    if ((cIcon as PictureBox).Name.Substring(0, 3) == "ico")
                                                        if (vTipoIcon == "") vTipoIcon = cIcon.Name.Substring(4, 8);
                                            if (cPnl is CheckBox)
                                                if ((cPnl as CheckBox).Checked)
                                                    return vTipoIcon;
                                        }
                                }
                            }
                            return "err";
                        }
                return vTipoIcon;
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "err";
            }
        }
        //---------------------------------------------------------            
        //---------------------------------------------------------
        //  REFERENCIA - FOTO CLICK : FOTO ENABLED
        //---------------------------------------------------------
        public static void f_jovem_desabilita_vem(object sender,Boolean bRealiza)
        {
            try
            {
                if (bRealiza)
                {
                    (sender as Control).BackColor = _Desabilitado();
                    foreach (Control Flw in (sender as Control).Controls)
                    {
                        Flw.BackColor = Color.LightCoral;
                        foreach (Control FlwControl in Flw.Controls)
                            FlwControl.BackColor = Color.LightCoral;
                    }
                }
                else
                {
                    (sender as Control).BackColor = (sender as Control).Parent.BackColor;
                    foreach (Control Flw in (sender as Control).Controls)
                    {
                        if (Flw.Name.Substring(0, 3) != "ckj")
                            Flw.BackColor = Color.White;
                        else Flw.BackColor = _MedidaDisciplinar();
                        foreach (Control FlwControl in Flw.Controls)
                            FlwControl.BackColor = Color.White;
                    }
                }
                //----------------------------
                //DECLARAÇÃO DE VARIAVEIS
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
        //---------------------------------------------------------
        // CRIAR ICONES AÇÃO
        //---------------------------------------------------------
        public static void f_icon_create(object sender, int tipo, string gHint)
        {
            try
            {
                //DECLARAR E INICIALIZAR VARIAVEIS
                DataSet RecordSet = new DataSet();
                PictureBox[] ico_geral = new PictureBox[50];
                Panel[] pnl_geral = new Panel[50];
                int icodigo = 0;
                string scodigo = cJovens.f_Jovem_Number_Sel(sender);
                Int32.TryParse(scodigo, out icodigo);
                string stipo = tipo.ToString();

                //CONECTAR BANCO DE DADOS E NOMEAR ICONE DE AÇÃO
                RecordSet = Consulta.Consultar("SELECT tb_acao.tp_acao FROM tb_acao WHERE (tb_acao.id_acao=" + stipo + ");");
                string sNome_pnl = "aaa_";
                string sNome_ico = "bbb_";
                foreach (DataRow pRow in RecordSet.Tables[0].Rows)
                {
                    sNome_pnl = "pnl_" + pRow.Field<string>("tp_acao") + scodigo;
                    sNome_ico = "ico_" + pRow.Field<string>("tp_acao") + scodigo;
                }
                if (sNome_pnl == "aaa_") return;

                int vTamanhoIcon = 35;
                if (Globais.Tamanho==0) vTamanhoIcon = 20;
                //CRIAR ICONE DE AÇÃO
                foreach (Form _Forms in Application.OpenForms)
                    foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                        if (_Controles.Name == "pnlJovens")
                            foreach (Control c in _Controles.Controls)
                                if (c.Name == "Bor" + scodigo)
                                {
                                    //PAINEL
                                    pnl_geral[icodigo] = new Panel();
                                    pnl_geral[icodigo].Name = sNome_pnl;
                                    pnl_geral[icodigo].Location = new Point(0, 0);
                                    pnl_geral[icodigo].Size = new Size(vTamanhoIcon, vTamanhoIcon);
                                    pnl_geral[icodigo].BackColor = c.BackColor; //Color.Blue;
                                    pnl_geral[icodigo].BorderStyle = BorderStyle.None;// FixedSingle;
                                    //PICTURE ICONE
                                    ico_geral[icodigo] = new PictureBox();
                                    ico_geral[icodigo].Image = f_icon_carregar(stipo);
                                    ico_geral[icodigo].Name = sNome_ico;
                                    ico_geral[icodigo].Location = new Point(0, 0);
                                    ico_geral[icodigo].Size = new Size(vTamanhoIcon, vTamanhoIcon);
                                    ico_geral[icodigo].BackColor = c.BackColor; //Color.Blue;
                                    ico_geral[icodigo].BorderStyle = BorderStyle.None;
                                    ico_geral[icodigo].SizeMode = PictureBoxSizeMode.StretchImage;
                                    ico_geral[icodigo].Click += new EventHandler(f_icon_Click);
                                    if (gHint != "") { if (cHint.Jovens) { cHint.Exibir(ico_geral[icodigo], gHint); } }
                                    pnl_geral[icodigo].Controls.Add(ico_geral[icodigo]);
                                    c.Controls.Add(pnl_geral[icodigo]);
                                    pnl_geral[icodigo].BringToFront();
                                    break;
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
        //---------------------------------------------------------
        //---------------------------------------------------------
        // REFERENCIA - ICONES AÇÃO CLICK  -  SELECIONAR TODOS DA MESMA AÇÃO NO ICONE AÇÕES
        //---------------------------------------------------------
        public static void f_icon_Click(object sender, EventArgs e)
        {
            try
            {
                //VERIFICA O TIPO DE AÇÃO SELECIONADA
                string vTipoIcon = (sender as PictureBox).Name.Substring(0, 12);
                //SE FOR RED - AÇÃO MEDIDA DISCIPLINAR
                //if ((sender as Control).BackColor == _MedidaDisciplinar()) return;
                Boolean UmChecked = false;
                Boolean vEnabled = false;
                //TODOS CHECKBOX = FALSO                
                foreach (Form _Forms in Application.OpenForms)
                {
                    //VERIFICA SE HÁ UMA CHECKBOX SELECIONADA
                    foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                        if (_Controles.Name == "pnlJovens")
                        {
                            _Controles.Cursor = Cursors.No;
                            foreach (Control c in _Controles.Controls)
                                foreach (Control cPnl in c.Controls)
                                    if (cPnl is CheckBox)
                                        if ((cPnl as CheckBox).Checked) UmChecked = true;
                        }

                    //TODOS CHECKBOX SELECIONADA = TRUE
                    if (!UmChecked)
                    {
                        foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                            if (_Controles.Name == "pnlJovens")
                                foreach (Control c in _Controles.Controls)
                                    //SE FOR AZUL - AÇÃO NORMAL
                                    //if (c.BackColor == _Atividade())
                                    if ((c.BackColor == _Atividade()) || (c.BackColor == _MedidaDisciplinar()))
                                        foreach (Control cPnl in c.Controls)
                                            foreach (Control cIcon in cPnl.Controls)
                                                if (cIcon is PictureBox)
                                                    if ((cIcon as PictureBox).Name.Substring(0, 3) == "ico")
                                                        if ((cIcon as PictureBox).Name.Substring(0, 12) == vTipoIcon)
                                                            Foto_Click(c, e);
                    }
                    //TODOS CHECKBOX SELECIONADA = FALSE
                    else
                    {
                        vEnabled = true;
                        foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                            if (_Controles.Name == "pnlJovens")
                                foreach (Control c in _Controles.Controls)
                                    foreach (Control cPnlsel in c.Controls)
                                        if (cPnlsel is CheckBox)
                                        {
                                            (cPnlsel as CheckBox).Checked = false;
                                        }
                    }
                    //SE TODOS CHECKBOX SELECIONADA = FALSE ==>> TODOS ENABLED
                    if (vEnabled)
                        foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                            if (_Controles.Name == "pnlJovens")
                                foreach (Control c in _Controles.Controls)
                                    if (c.Name.Substring(0, 3) == "Bor")
                                    {
                                        c.Enabled = true;
                                        c.Cursor = Cursors.Arrow;
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
        }
        //---------------------------------------------------------
        //---------------------------------------------------------
        // REFERENCIA - FOTO DOUBLE CLICK
        //---------------------------------------------------------
        public static void Foto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frm_sobre_jovem frm_sobre_jovem = new frm_sobre_jovem();
                string scodigo = f_Jovem_Codigo(sender);
                f_dados_jovem(scodigo);
                frm_sobre_jovem.ShowDialog();
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
        //---------------------------------------------------------
        // REFERENCIA - FOTO CLICK
        //---------------------------------------------------------
        public static void Foto_Click(object sender, EventArgs e)
        {
            try
            {
                string scodigo = f_Jovem_Number_Sel(sender);
                if (Globais.FotoClicada == false)
                {
                    Globais.FotoClicada = true;
                    //SELECIONA O JOVEM CLICADO
                    f_Jovem_Sel(sender);
                    Globais.FotoClicada = false;
                    //VERIFICA SE CLICOU EM UM JOVEM NOVO
                    f_fotos_enabled(sender);
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
        //---------------------------------------------------------
        //---------------------------------------------------------
        //  REFERENCIA - FOTO CLICK : FOTO ENABLED
        //---------------------------------------------------------
        public static void f_fotos_enabled(object sender)
        {
            try
            {
                //DECLARA E INICIALIZA VARIAVEIS
                CheckBox[] ckj = new CheckBox[50];

                string sIconSelTP = "";
                string sIconSelTPCompara = "";

                Boolean sIconSelCK = false;
                Boolean sIconSelCheck = false;
                string sCodigo = cJovens.f_Jovem_Number_Sel(sender);
                int i = 0;
                Int32.TryParse(sCodigo, out i);
                int iCkjCount = 0;

                foreach (Form _Forms in Application.OpenForms)
                    foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                        if (_Controles.Name == "pnlJovens")
                        {
                            _Controles.Cursor = Cursors.No;
                            //ALIMENTA VARIAVEIS DE COMPARAÇÃO PARA SABER O TIPO DE ICON AÇÃO E CHECADO
                            foreach (Control Bor in _Controles.Controls)
                            {
                                if (Bor.Name == "Bor" + sCodigo)
                                    foreach (Control flws in Bor.Controls)
                                    {
                                        if (flws.Name.Substring(0, 3) == "pnl") sIconSelTP = flws.Name.Substring(4, 8);
                                        if (flws.Name.Substring(0, 3) == "ckj")
                                        {
                                            if ((sender as Control).Name.Substring(0, 3) == "ckj") sIconSelCK = (!(flws as CheckBox).Checked);
                                            else sIconSelCK = ((flws as CheckBox).Checked);
                                            sIconSelCheck = (flws as CheckBox).Checked;
                                        }
                                    }
                                Bor.Enabled = true;
                                Bor.Cursor = Cursors.Arrow;

                            }
                            //----------------------------
                            // COMPARA O TIPO SELECIONADO COM TODOS DISPONIVEIS
                            foreach (Control Bor in _Controles.Controls)
                            {
                                sIconSelTPCompara = "";
                                foreach (Control Bor_controls in Bor.Controls)
                                    if (Bor_controls.Name.Substring(0, 3) == "pnl")
                                        sIconSelTPCompara = Bor_controls.Name.Substring(4, 8);
                                if (sIconSelTPCompara != sIconSelTP)
                                {
                                    Bor.Enabled = false;
                                    Bor.Cursor = Cursors.No;
                                }
                            }

                            //----------------------------
                            //VERIFICA SELECIONADOS
                            foreach (Control Bor in _Controles.Controls)
                                foreach (Control Bor_controls in Bor.Controls)
                                    if (Bor_controls.Name.Substring(0, 3) == "ckj")
                                        if ((Bor_controls as CheckBox).Checked) iCkjCount++;
                            //----------------------------
                            //VERIFICA SELECIONADOS
                            if (iCkjCount == 0)
                            {
                                _Controles.Cursor = Cursors.Arrow;
                                foreach (Control Bor in _Controles.Controls)
                                {
                                    Bor.Enabled = true;
                                    Bor.Cursor = Cursors.Arrow;
                                }
                            }

                            //----------------------------
                            //HALIBITA TODOS COMANDOS DO MODO DESIGN
                            foreach (Control Bor in _Controles.Controls)
                                if (Bor.Name.Substring(0, 3) == "btn")
                                {
                                    Bor.Cursor = Cursors.Arrow;
                                    Bor.Enabled = true;
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
        }
        //---------------------------------------------------------
        //---------------------------------------------------------
        // VERIFICAR SE EXISTE JOVEM SELECIONADO NA PANEL VIEW
        //---------------------------------------------------------
        public static string f_jovens_selecionado()
        {
            string bJovemSel = "";
            string bJovemSelCod = "";
            try
            {
                int i = 0;
                //PROCURA JOVEM SELECIONADO
                foreach (Form _Forms in Application.OpenForms)
                    foreach (System.Windows.Forms.Control _Controles in _Forms.Controls)
                        if (_Controles.Name == "pnlJovens")
                            foreach (Control c in _Controles.Controls)
                                if (c.Name.Substring(0, 3) == "Bor")
                                {
                                    foreach (Control cIcon in c.Controls)
                                        if (cIcon.Name.Substring(0, 3) == "ckj")
                                            if ((cIcon as CheckBox).Checked)
                                            {
                                                bJovemSel = bJovemSel + f_Jovem_Nome(c) + ",";
                                                bJovemSelCod = bJovemSelCod + f_Jovem_Codigo(c) + ",";
                                            }
                                }
                i = 0;
                i = bJovemSel.Length;
                if (i > 1) { bJovemSel = bJovemSel.Substring(0, i - 1); }
                i = 0;
                i = bJovemSelCod.Length;
                if (i > 1) { bJovemSelCod = bJovemSelCod.Substring(0, i - 1); }
                bJovemSel = bJovemSelCod + "_" + bJovemSel;
                if (bJovemSel == "_") bJovemSel = "";
            }
            catch (Exception ex)
            {
                string sLine = ex.StackTrace.Substring(ex.StackTrace.IndexOf("linha"));
                MessageBox.Show("Form: " + ex.TargetSite.ReflectedType.Name + "\n" +
                                "Procedimento: " + ex.TargetSite.Name + "\n" +
                                "Linha: " + sLine + "\n\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bJovemSel;
        }
        //---------------------------------------------------------
        //---------------------------------------------------------
        // CALCULAR MEDIDA DISCIPLINAR RESTANTE
        //---------------------------------------------------------
        public static int CalcularMedidaDisciplinarRestante(string vDTOcorrencia, string vNDias)
        {
            int vResultado = 0;
            try
            {
                DateTime dtMedida;
                DateTime dtHoje = DateTime.Today;
                if (DateTime.TryParse(vDTOcorrencia, out dtMedida))
                {
                    dtMedida = dtMedida.AddDays(Convert.ToDouble(vNDias));
                    vResultado = (int)dtMedida.Subtract(dtHoje).TotalDays;
                    if (vResultado < 1) { vResultado = 0; }
                }
                return vResultado;
            }
            catch (Exception)
            {
                return 0;
            }
        }



    }

    public static class cJovemSelect
    {
        private static string _vCodigo = "01";
        public static string Codigo
        {
            get { return _vCodigo; }
            set { _vCodigo = value; }
        }
        //---------------------------------------------------------
        private static string _vNome = "01";
        public static string Nome
        {
            get { return _vNome; }
            set { _vNome = value; }
        }
        //---------------------------------------------------------
        private static Image _vFoto = null;
        public static Image Foto
        {
            get { return _vFoto; }
            set { _vFoto = value; }
        }
        //---------------------------------------------------------
        private static string _vAla = "01";
        public static string Ala_Corredor
        {
            get { return _vAla; }
            set { _vAla = value; }
        }
        //---------------------------------------------------------
        private static string _vQuarto = "01";
        public static string Quarto
        {
            get { return _vQuarto; }
            set { _vQuarto = value; }
        }
        //---------------------------------------------------------
        private static string _vStatus = "0";
        public static string Status
        {
            get { return _vStatus; }
            set { _vStatus = value; }
        }
        //---------------------------------------------------------
        private static string _vMD = "0";
        public static string MedidaDisciplinar_Status
        {
            get { return _vMD; }
            set { _vMD = value; }
        }
        //---------------------------------------------------------
        private static string _vMDData = "0";
        public static string MedidaDisciplinar_Data
        {
            get { return _vMDData; }
            set { _vMDData = value; }
        }
        //---------------------------------------------------------
        private static string _vMDDia = "0";
        public static string MedidaDisciplinar_Dia
        {
            get { return _vMDDia; }
            set { _vMDDia = value; }
        }
        //---------------------------------------------------------
        public static int MedidaDisciplinarRestante()
        {
            int vResultado = 0;
            try { vResultado = cJovens.CalcularMedidaDisciplinarRestante(cJovemSelect.MedidaDisciplinar_Data, cJovemSelect.MedidaDisciplinar_Dia); }
            catch { vResultado = 0;}
            return vResultado;
        }
    }

}

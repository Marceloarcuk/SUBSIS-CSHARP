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
    public partial class Frm_Documentos : Form
    {
        Form1 instanciaF1;
        public int ind = 0;
        public int VlinPanel = 88;
        public int VlinButton = 375;
        public Panel[] panelDoc = new Panel[10];
        public TextBox[] txtOutrosDoc = new TextBox[10];
        public Label[] lblOutros_doc = new Label[10];
        public Button[] btnExcluiDoc = new Button[10];
        public Button[] btnAtualizaDoc = new Button[10];
        public Button[] btnSalvaDoc = new Button[10];
        public Button[] btnEditarDoc = new Button[10];
        public ComboBox[] comboBoxOrgDec = new ComboBox[10];
        public ComboBox[] comboBoxDecisao = new ComboBox[10];
        public MaskedTextBox[] txt_processo = new MaskedTextBox[10];
        public MaskedTextBox[] txt_N_PAAI = new MaskedTextBox[10];
        public Label[] labelOrgaoDec = new Label[10];
        public Label[] lblDecisao = new Label[10];
        public Label[] labelProcesso = new Label[10];
        public Label[] labelPAAI = new Label[10];
        public ComboBox[] comboBoxApresent = new ComboBox[10];
        public Label[] labelApresenta = new Label[10];
        public ComboBox[] comboBoxMotivo = new ComboBox[10];
        public Label[] lblMotivo = new Label[10];
        public TextBox[] txtOutraOrigem = new TextBox[10];
        public Label[] labelOrigemO = new Label[10];
        public MaskedTextBox[] txtNumero_sai = new MaskedTextBox[10];
        public MaskedTextBox[] txtNumero_ent = new MaskedTextBox[10];
        public ComboBox[] comboBoxDestino = new ComboBox[10];
        public ComboBox[] comboBoxOrigem = new ComboBox[10];
        public Label[] lblDestino = new Label[10];
        public Label[] lblNumero_sai = new Label[10];
        public ComboBox[] cmbDoc_sai = new ComboBox[10];
        public Label[] lblSaida = new Label[10];
        public Label[] lblOrigem_Ent = new Label[10];
        public Label[] labelNEnt = new Label[10];
        public ComboBox[] cmbDoc_ent = new ComboBox[10];
        public Label[] lblEntradaDoc = new Label[10];
        public Label[] lblIdDoc = new Label[10];
        public Label[] lblIdCount = new Label[10];
        public Button[] btnNovoDoc = new Button[10];


        public Frm_Documentos(Form1 frm)
        {
            InitializeComponent();
            instanciaF1 = frm;
            lblNomeAdole.Text = instanciaF1.txtNome_int.Text;
            pictureBoxAdoleDoc.Image = instanciaF1.pictureBox1.Image;
            Frm_Documentos_Load();
        }
        public void Frm_Documentos_Load_Empty()
        {
            // 
            // txtOutrosDoc
            // 
            txtOutrosDoc[ind] = new TextBox();
            txtOutrosDoc[ind].CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtOutrosDoc[ind].Location = new System.Drawing.Point(148, 118);
            txtOutrosDoc[ind].Name = "txtOutrosDoc" + ind;
            txtOutrosDoc[ind].Size = new System.Drawing.Size(375, 20);
            txtOutrosDoc[ind].TabIndex = 86;
            // 
            // lblOutros_doc
            // 
            lblOutros_doc[ind] = new Label();
            lblOutros_doc[ind].AutoSize = true;
            lblOutros_doc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOutros_doc[ind].Location = new System.Drawing.Point(12, 119);
            lblOutros_doc[ind].Name = "lblOutros_doc" + ind;
            lblOutros_doc[ind].Size = new System.Drawing.Size(131, 15);
            lblOutros_doc[ind].TabIndex = 85;
            lblOutros_doc[ind].Text = "Outros documentos";
            // 
            // btnExcluiDoc
            // 
            btnExcluiDoc[ind] = new Button();
            btnExcluiDoc[ind].BackColor = System.Drawing.Color.Red;
            btnExcluiDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnExcluiDoc[ind].ForeColor = System.Drawing.Color.Snow;
            btnExcluiDoc[ind].Location = new System.Drawing.Point(393, 245);
            btnExcluiDoc[ind].Name = "btnExcluiDoc" + ind;
            btnExcluiDoc[ind].Size = new System.Drawing.Size(115, 29);
            btnExcluiDoc[ind].TabIndex = 84;
            btnExcluiDoc[ind].Text = "Excluir";
            btnExcluiDoc[ind].UseVisualStyleBackColor = false;
            btnExcluiDoc[ind].Visible = false;
            btnExcluiDoc[ind].Click += new EventHandler(btnExcluiDoc_Click);
            // 
            // btnAtualizaDoc
            // 
            btnAtualizaDoc[ind] = new Button();
            btnAtualizaDoc[ind].BackColor = System.Drawing.Color.ForestGreen;
            btnAtualizaDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAtualizaDoc[ind].ForeColor = System.Drawing.Color.Snow;
            btnAtualizaDoc[ind].Location = new System.Drawing.Point(515, 245);
            btnAtualizaDoc[ind].Name = "btnAtualizaDoc" + ind;
            btnAtualizaDoc[ind].Size = new System.Drawing.Size(115, 29);
            btnAtualizaDoc[ind].TabIndex = 83;
            btnAtualizaDoc[ind].Text = "Atualizar";
            btnAtualizaDoc[ind].UseVisualStyleBackColor = false;
            btnAtualizaDoc[ind].Visible = false;
            // 
            // btnSalvaDoc
            // 
            btnSalvaDoc[ind] = new Button();
            btnSalvaDoc[ind].BackColor = System.Drawing.Color.ForestGreen;
            btnSalvaDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSalvaDoc[ind].ForeColor = System.Drawing.Color.Snow;
            btnSalvaDoc[ind].Location = new System.Drawing.Point(515, 245);
            btnSalvaDoc[ind].Name = "btnSalvaDoc" + ind;
            btnSalvaDoc[ind].Size = new System.Drawing.Size(115, 29);
            btnSalvaDoc[ind].TabIndex = 82;
            btnSalvaDoc[ind].Text = "Salvar";
            btnSalvaDoc[ind].UseVisualStyleBackColor = false;
            btnSalvaDoc[ind].Visible = true;
            btnSalvaDoc[ind].Click += new System.EventHandler(btnSalvaDoc_Click);
            // 
            // btnEditarDoc
            // 
            btnEditarDoc[ind] = new Button();
            btnEditarDoc[ind].BackColor = System.Drawing.Color.ForestGreen;
            btnEditarDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEditarDoc[ind].ForeColor = System.Drawing.Color.Snow;
            btnEditarDoc[ind].Location = new System.Drawing.Point(650, 245);
            btnEditarDoc[ind].Name = "btnEditarDoc" + ind;
            btnEditarDoc[ind].Size = new System.Drawing.Size(115, 29);
            btnEditarDoc[ind].TabIndex = 82;
            btnEditarDoc[ind].Text = "Editar";
            btnEditarDoc[ind].UseVisualStyleBackColor = false;
            btnEditarDoc[ind].Visible = false;
            btnEditarDoc[ind].Click += new System.EventHandler(btnEditarDoc_Click);
            // 
            // comboBoxOrgDec
            // 
            comboBoxOrgDec[ind] = new ComboBox();
            comboBoxOrgDec[ind].FormattingEnabled = true;
            comboBoxOrgDec[ind].Location = new System.Drawing.Point(148, 147);
            comboBoxOrgDec[ind].Name = "comboBoxOrgDec" + ind;
            comboBoxOrgDec[ind].Size = new System.Drawing.Size(155, 21);
            comboBoxOrgDec[ind].TabIndex = 81;
            // 
            // comboBoxDecisao
            // 
            comboBoxDecisao[ind] = new ComboBox();
            comboBoxDecisao[ind].FormattingEnabled = true;
            comboBoxDecisao[ind].Location = new System.Drawing.Point(78, 177);
            comboBoxDecisao[ind].Name = "comboBoxDecisao" + ind;
            comboBoxDecisao[ind].Size = new System.Drawing.Size(292, 21);
            comboBoxDecisao[ind].TabIndex = 66;
            // 
            // lblIdDoc
            //
            lblIdDoc[ind] = new Label();
            lblIdDoc[ind].AutoSize = true;
            lblIdDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdDoc[ind].Location = new System.Drawing.Point(13, 82);
            lblIdDoc[ind].Name = "lblIdDoc" + ind;
            lblIdDoc[ind].Size = new System.Drawing.Size(44, 15);
            lblIdDoc[ind].TabIndex = 66;
            lblIdDoc[ind].Text = "";
            lblIdDoc[ind].Visible = false;
            // 
            // lblIdCount
            //
            lblIdCount[ind] = new Label();
            lblIdCount[ind].AutoSize = true;
            lblIdCount[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdCount[ind].Location = new System.Drawing.Point(30, 82);
            lblIdCount[ind].Name = "lblIdDoc" + ind;
            lblIdCount[ind].Size = new System.Drawing.Size(44, 15);
            lblIdCount[ind].TabIndex = 66;
            lblIdCount[ind].Text = "";
            lblIdCount[ind].Visible = false;
            // 
            // lblDecisao
            //
            lblDecisao[ind] = new Label();
            lblDecisao[ind].AutoSize = true;
            lblDecisao[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDecisao[ind].Location = new System.Drawing.Point(13, 177);
            lblDecisao[ind].Name = "lblDecisao" + ind;
            lblDecisao[ind].Size = new System.Drawing.Size(109, 15);
            lblDecisao[ind].TabIndex = 80;
            lblDecisao[ind].Text = "Decisão";
            lblDecisao[ind].TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelProcesso
            // 
            labelProcesso[ind] = new Label();
            labelProcesso[ind].AutoSize = true;
            labelProcesso[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelProcesso[ind].Location = new System.Drawing.Point(13, 207);
            labelProcesso[ind].Name = "labelProcesso" + ind;
            labelProcesso[ind].Size = new System.Drawing.Size(85, 15);
            labelProcesso[ind].TabIndex = 80;
            labelProcesso[ind].Text = "Nº Processo";
            // 
            // txt_processo
            // 
            txt_processo[ind] = new MaskedTextBox();
            txt_processo[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt_processo[ind].Location = new System.Drawing.Point(102, 207);
            txt_processo[ind].Mask = "0000.00.0.000000-0";
            txt_processo[ind].Name = "txt_processo" + ind;
            txt_processo[ind].Size = new System.Drawing.Size(123, 21);
            txt_processo[ind].TabIndex = 96;
            txt_processo[ind].TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;

            // 
            // labelPAAI
            // 
            labelPAAI[ind] = new Label();
            labelPAAI[ind].AutoSize = true;
            labelPAAI[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPAAI[ind].Location = new System.Drawing.Point(13, 237);
            labelPAAI[ind].Name = "labelPAAI" + ind;
            labelPAAI[ind].Size = new System.Drawing.Size(85, 15);
            labelPAAI[ind].TabIndex = 80;
            labelPAAI[ind].Text = "Nº PAAI";
            // 
            // txt_N_PAAI
            // 
            txt_N_PAAI[ind] = new MaskedTextBox();
            txt_N_PAAI[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt_N_PAAI[ind].Location = new System.Drawing.Point(82, 237);
            txt_N_PAAI[ind].Mask = "0000.00.0.000000-0";
            txt_N_PAAI[ind].Name = "txt_N_PAAI" + ind;
            txt_N_PAAI[ind].Size = new System.Drawing.Size(123, 21);
            txt_N_PAAI[ind].TabIndex = 96;
            txt_N_PAAI[ind].TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;

            // 
            // labelOrgaoDec
            //
            labelOrgaoDec[ind] = new Label();
            labelOrgaoDec[ind].AutoSize = true;
            labelOrgaoDec[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelOrgaoDec[ind].Location = new System.Drawing.Point(13, 148);
            labelOrgaoDec[ind].Name = "labelOrgaoDec" + ind;
            labelOrgaoDec[ind].Size = new System.Drawing.Size(109, 15);
            labelOrgaoDec[ind].TabIndex = 80;
            labelOrgaoDec[ind].Text = "Orgão decisório";
            labelOrgaoDec[ind].TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxApresent
            // 
            comboBoxApresent[ind] = new ComboBox();
            comboBoxApresent[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxApresent[ind].FormattingEnabled = true;
            comboBoxApresent[ind].Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            comboBoxApresent[ind].Location = new System.Drawing.Point(433, 8);
            comboBoxApresent[ind].Name = "comboBoxApresent" + ind;
            comboBoxApresent[ind].Size = new System.Drawing.Size(69, 23);
            comboBoxApresent[ind].TabIndex = 79;
            // 
            // labelApresenta
            // 
            labelApresenta[ind] = new Label();
            labelApresenta[ind].AutoSize = true;
            labelApresenta[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelApresenta[ind].Location = new System.Drawing.Point(333, 11);
            labelApresenta[ind].Name = "labelApresenta" + ind;
            labelApresenta[ind].Size = new System.Drawing.Size(94, 15);
            labelApresenta[ind].TabIndex = 78;
            labelApresenta[ind].Text = "Apresentação";
            // 
            // comboBoxMotivo
            // 
            comboBoxMotivo[ind] = new ComboBox();
            comboBoxMotivo[ind].AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBoxMotivo[ind].AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            comboBoxMotivo[ind].Items.AddRange(new object[] {
            "",
            "FLAGRANTE",
            "MBA"});
            comboBoxMotivo[ind].Location = new System.Drawing.Point(140, 10);
            comboBoxMotivo[ind].Name = "comboBoxMotivo" + ind;
            comboBoxMotivo[ind].Size = new System.Drawing.Size(168, 21);
            comboBoxMotivo[ind].TabIndex = 77;
            // 
            // lblMotivo
            // 
            lblMotivo[ind] = new Label();
            lblMotivo[ind].AutoSize = true;
            lblMotivo[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMotivo[ind].Location = new System.Drawing.Point(12, 11);
            lblMotivo[ind].Name = "lblMotivo" + ind;
            lblMotivo[ind].Size = new System.Drawing.Size(122, 15);
            lblMotivo[ind].TabIndex = 76;
            lblMotivo[ind].Text = "Motivo da entrada";
            // 
            // txtOutraOrigem
            // 
            txtOutraOrigem[ind] = new TextBox();
            txtOutraOrigem[ind].CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtOutraOrigem[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtOutraOrigem[ind].Location = new System.Drawing.Point(678, 42);
            txtOutraOrigem[ind].Name = "txtOutraOrigem" + ind;
            txtOutraOrigem[ind].Size = new System.Drawing.Size(125, 21);
            txtOutraOrigem[ind].TabIndex = 75;
            txtOutraOrigem[ind].Visible = false;
            // 
            // labelOrigemO
            // 
            labelOrigemO[ind] = new Label();
            labelOrigemO[ind].AutoSize = true;
            labelOrigemO[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelOrigemO[ind].Location = new System.Drawing.Point(581, 43);
            labelOrigemO[ind].Name = "labelOrigemO" + ind;
            labelOrigemO[ind].Size = new System.Drawing.Size(91, 15);
            labelOrigemO[ind].TabIndex = 74;
            labelOrigemO[ind].Text = "Outra origem";
            labelOrigemO[ind].Visible = false;
            // 
            // txtNumero_sai
            // 
            txtNumero_sai[ind] = new MaskedTextBox();
            txtNumero_sai[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNumero_sai[ind].ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            txtNumero_sai[ind].Location = new System.Drawing.Point(246, 81);
            txtNumero_sai[ind].Mask = "000000/0000";
            txtNumero_sai[ind].Name = "txtNumero_sai" + ind;
            txtNumero_sai[ind].Size = new System.Drawing.Size(81, 21);
            txtNumero_sai[ind].TabIndex = 73;
            txtNumero_sai[ind].TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNumero_ent
            // 
            txtNumero_ent[ind] = new MaskedTextBox();
            txtNumero_ent[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNumero_ent[ind].Location = new System.Drawing.Point(244, 42);
            txtNumero_ent[ind].Mask = "000000/0000";
            txtNumero_ent[ind].Name = "txtNumero_ent" + ind;
            txtNumero_ent[ind].Size = new System.Drawing.Size(83, 21);
            txtNumero_ent[ind].TabIndex = 72;
            txtNumero_ent[ind].TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino[ind] = new ComboBox();
            comboBoxDestino[ind].FormattingEnabled = true;
            comboBoxDestino[ind].Location = new System.Drawing.Point(393, 81);
            comboBoxDestino[ind].Name = "comboBoxDestino" + ind;
            comboBoxDestino[ind].Size = new System.Drawing.Size(180, 21);
            comboBoxDestino[ind].TabIndex = 71;
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem[ind] = new ComboBox();
            comboBoxOrigem[ind].FormattingEnabled = true;
            comboBoxOrigem[ind].Location = new System.Drawing.Point(393, 42);
            comboBoxOrigem[ind].Name = "comboBoxOrigem" + ind;
            comboBoxOrigem[ind].Size = new System.Drawing.Size(180, 21);
            comboBoxOrigem[ind].TabIndex = 70;
            comboBoxOrigem[ind].SelectedIndexChanged += new System.EventHandler(comboBoxOrigem_SelectedIndexChanged);
            // 
            // lblDestino
            // 
            lblDestino[ind] = new Label();
            lblDestino[ind].AutoSize = true;
            lblDestino[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDestino[ind].Location = new System.Drawing.Point(333, 83);
            lblDestino[ind].Name = "lblDestino" + ind;
            lblDestino[ind].Size = new System.Drawing.Size(56, 15);
            lblDestino[ind].TabIndex = 69;
            lblDestino[ind].Text = "Destino";
            lblDestino[ind].TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumero_sai
            //
            lblNumero_sai[ind] = new Label();
            lblNumero_sai[ind].AutoSize = true;
            lblNumero_sai[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNumero_sai[ind].Location = new System.Drawing.Point(214, 82);
            lblNumero_sai[ind].Name = "lblNumero_sai" + ind;
            lblNumero_sai[ind].Size = new System.Drawing.Size(26, 15);
            lblNumero_sai[ind].TabIndex = 68;
            lblNumero_sai[ind].Text = "Nº ";
            // 
            // cmbDoc_sai
            // 
            cmbDoc_sai[ind] = new ComboBox();
            cmbDoc_sai[ind].FormattingEnabled = true;
            cmbDoc_sai[ind].Items.AddRange(new object[] {
            "OFÍCIO",
            "MEMORANDO"});
            cmbDoc_sai[ind].Location = new System.Drawing.Point(76, 81);
            cmbDoc_sai[ind].Name = "cmbDoc_sai" + ind;
            cmbDoc_sai[ind].Size = new System.Drawing.Size(121, 21);
            cmbDoc_sai[ind].TabIndex = 67;
            // 
            // lblSaida
            //
            lblSaida[ind] = new Label();
            lblSaida[ind].AutoSize = true;
            lblSaida[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSaida[ind].Location = new System.Drawing.Point(13, 82);
            lblSaida[ind].Name = "lblSaida" + ind;
            lblSaida[ind].Size = new System.Drawing.Size(44, 15);
            lblSaida[ind].TabIndex = 66;
            lblSaida[ind].Text = "Saída";
            // 
            // lblOrigem_Ent
            // 
            lblOrigem_Ent[ind] = new Label();
            lblOrigem_Ent[ind].AutoSize = true;
            lblOrigem_Ent[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOrigem_Ent[ind].Location = new System.Drawing.Point(333, 43);
            lblOrigem_Ent[ind].Name = "lblOrigem_Ent" + ind;
            lblOrigem_Ent[ind].Size = new System.Drawing.Size(54, 15);
            lblOrigem_Ent[ind].TabIndex = 65;
            lblOrigem_Ent[ind].Text = "Origem";
            lblOrigem_Ent[ind].TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelNEnt
            // 
            labelNEnt[ind] = new Label();
            labelNEnt[ind].AutoSize = true;
            labelNEnt[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNEnt[ind].Location = new System.Drawing.Point(214, 43);
            labelNEnt[ind].Name = "labelNEnt" + ind;
            labelNEnt[ind].Size = new System.Drawing.Size(26, 15);
            labelNEnt[ind].TabIndex = 64;
            labelNEnt[ind].Text = "Nº ";
            // 
            // cmbDoc_ent
            // 
            cmbDoc_ent[ind] = new ComboBox();
            cmbDoc_ent[ind].FormattingEnabled = true;
            cmbDoc_ent[ind].Items.AddRange(new object[] {
            "OFÍCIO",
            "MEMORANDO"});
            cmbDoc_ent[ind].Location = new System.Drawing.Point(76, 42);
            cmbDoc_ent[ind].Name = "cmbDoc_ent" + ind;
            cmbDoc_ent[ind].Size = new System.Drawing.Size(121, 21);
            cmbDoc_ent[ind].TabIndex = 63;
            // 
            // lblEntradaDoc
            // 
            lblEntradaDoc[ind] = new Label();
            lblEntradaDoc[ind].AutoSize = true;
            lblEntradaDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEntradaDoc[ind].Location = new System.Drawing.Point(13, 43);
            lblEntradaDoc[ind].Name = "lblEntradaDoc" + ind;
            lblEntradaDoc[ind].Size = new System.Drawing.Size(57, 15);
            lblEntradaDoc[ind].TabIndex = 62;
            lblEntradaDoc[ind].Text = "Entrada";
            // 
            // btnNovoDoc
            // 
            btnNovoDoc[ind] = new Button();
            btnNovoDoc[ind].BackColor = System.Drawing.Color.ForestGreen;
            btnNovoDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnNovoDoc[ind].ForeColor = System.Drawing.Color.Snow;
            btnNovoDoc[ind].Location = new System.Drawing.Point(154, VlinButton);
            btnNovoDoc[ind].Name = "btnNovoDoc" + ind;
            btnNovoDoc[ind].Size = new System.Drawing.Size(151, 22);
            btnNovoDoc[ind].TabIndex = 84;
            btnNovoDoc[ind].Text = "+ Adicionar documento";
            btnNovoDoc[ind].UseVisualStyleBackColor = false;
            btnNovoDoc[ind].Click += new EventHandler(btnNovoDoc_Click);
            // 
            // panelDoc
            // 
            panelDoc[ind] = new Panel();
            panelDoc[ind].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDoc[ind].Controls.Add(txtOutrosDoc[ind]);
            panelDoc[ind].Controls.Add(lblOutros_doc[ind]);
            panelDoc[ind].Controls.Add(btnExcluiDoc[ind]);
            panelDoc[ind].Controls.Add(btnAtualizaDoc[ind]);
            panelDoc[ind].Controls.Add(btnSalvaDoc[ind]);
            panelDoc[ind].Controls.Add(btnEditarDoc[ind]);
            panelDoc[ind].Controls.Add(comboBoxOrgDec[ind]);
            panelDoc[ind].Controls.Add(labelOrgaoDec[ind]);
            panelDoc[ind].Controls.Add(lblDecisao[ind]);
            panelDoc[ind].Controls.Add(txt_processo[ind]);
            panelDoc[ind].Controls.Add(labelProcesso[ind]);
            panelDoc[ind].Controls.Add(lblIdCount[ind]);
            panelDoc[ind].Controls.Add(lblIdDoc[ind]);
            panelDoc[ind].Controls.Add(labelPAAI[ind]);
            panelDoc[ind].Controls.Add(txt_N_PAAI[ind]);
            panelDoc[ind].Controls.Add(comboBoxApresent[ind]);
            panelDoc[ind].Controls.Add(labelApresenta[ind]);
            panelDoc[ind].Controls.Add(comboBoxMotivo[ind]);
            panelDoc[ind].Controls.Add(lblMotivo[ind]);
            panelDoc[ind].Controls.Add(txtOutraOrigem[ind]);
            panelDoc[ind].Controls.Add(labelOrigemO[ind]);
            panelDoc[ind].Controls.Add(txtNumero_sai[ind]);
            panelDoc[ind].Controls.Add(txtNumero_ent[ind]);
            panelDoc[ind].Controls.Add(comboBoxDestino[ind]);
            panelDoc[ind].Controls.Add(comboBoxOrigem[ind]);
            panelDoc[ind].Controls.Add(comboBoxDecisao[ind]);
            panelDoc[ind].Controls.Add(lblDestino[ind]);
            panelDoc[ind].Controls.Add(lblNumero_sai[ind]);
            panelDoc[ind].Controls.Add(cmbDoc_sai[ind]);
            panelDoc[ind].Controls.Add(lblSaida[ind]);
            panelDoc[ind].Controls.Add(lblOrigem_Ent[ind]);
            panelDoc[ind].Controls.Add(labelNEnt[ind]);
            panelDoc[ind].Controls.Add(cmbDoc_ent[ind]);
            panelDoc[ind].Controls.Add(lblEntradaDoc[ind]);
            panelDoc[ind].Location = new System.Drawing.Point(155, VlinPanel);
            panelDoc[ind].Name = "panelDoc" + ind;
            panelDoc[ind].Size = new System.Drawing.Size(818, 283);
            panelDoc[ind].TabIndex = 62;

            //
            //Frm_Documentos
            //
            this.Controls.Add(panelDoc[ind]);
            this.Controls.Add(btnNovoDoc[ind]);
            //
            //FILL COMBO comboBoxOrigem
            //
            DataSet dtO = Conexao.SelectOrigem();
            foreach (DataRow pRow in dtO.Tables[0].Rows)
            {
                int id = pRow.Field<int>("id_origem");
                string desc = pRow.Field<string>("desc_origem");
                comboBoxOrigem[ind].Items.Add(desc);
            }
            //
            //FILL COMBO comboBoxDestino
            //
            DataSet dtD = Conexao.SelectDestino();
            foreach (DataRow pRow in dtD.Tables[0].Rows)
            {
                int id = pRow.Field<int>("id_destino");
                string desc = pRow.Field<string>("desc_destino");
                comboBoxDestino[ind].Items.Add(desc);
            }
            //
            //FILL COMBO comboBoxDecisao
            //
            DataSet dtDec = Conexao.SelectDecisao();
            foreach (DataRow pRow in dtDec.Tables[0].Rows)
            {
                int id = pRow.Field<int>("id_decisao");
                string desc = pRow.Field<string>("desc_decisao");
                comboBoxDecisao[ind].Items.Add(desc);
            }
            DataSet dtOrgDec = Conexao.SelectOrgaoDecisorio();
            foreach (DataRow pRow in dtOrgDec.Tables[0].Rows)
            {
                int id = pRow.Field<int>("id_org_decisorio");
                string desc = pRow.Field<string>("desc_orgao_decisorio");
                comboBoxOrgDec[ind].Items.Add(desc);
            }


        }

        public void Frm_Documentos_Load()
        {
            DataSet docs = Conexao.selectDoc_Adolescente(instanciaF1.txtIdAdolescente.Text, instanciaF1.txtPlantao.Text);
            if(docs.Tables[0].Rows.Count > 0)
            {
                //ind = docs.Tables[0].Rows.Count;
                //MessageBox.Show(ind + "indices, contou!");
                Frm_Documentos_Load_Fill();
                //btnAtualizaDoc[ind].Visible = true;
                //btnSalvaDoc[ind].Visible = false;
                //btnExcluiDoc[ind].Visible = true;
            }
            else
            {
                Frm_Documentos_Load_Empty();
            }

            

        }
        public void Frm_Documentos_Load_Fill()
        {
            
            Auxiliar aux = new Auxiliar();
            DataSet dtDoc = Conexao.selectDoc_Adolescente(instanciaF1.txtIdAdolescente.Text, instanciaF1.txtPlantao.Text);
            foreach(DataRow pRow in dtDoc.Tables[0].Rows)
            {
                // 
                // txtOutrosDoc
                // 
                txtOutrosDoc[ind] = new TextBox();
                txtOutrosDoc[ind].CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                txtOutrosDoc[ind].Location = new System.Drawing.Point(148, 118);
                txtOutrosDoc[ind].Name = "txtOutrosDoc" + ind;
                txtOutrosDoc[ind].Size = new System.Drawing.Size(375, 20);
                txtOutrosDoc[ind].TabIndex = 86;
                // 
                // lblOutros_doc
                // 
                lblOutros_doc[ind] = new Label();
                lblOutros_doc[ind].AutoSize = true;
                lblOutros_doc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblOutros_doc[ind].Location = new System.Drawing.Point(12, 119);
                lblOutros_doc[ind].Name = "lblOutros_doc" + ind;
                lblOutros_doc[ind].Size = new System.Drawing.Size(131, 15);
                lblOutros_doc[ind].TabIndex = 85;
                lblOutros_doc[ind].Text = "Outros documentos";
                // 
                // btnExcluiDoc
                // 
                btnExcluiDoc[ind] = new Button();
                btnExcluiDoc[ind].BackColor = System.Drawing.Color.Red;
                btnExcluiDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnExcluiDoc[ind].ForeColor = System.Drawing.Color.Snow;
                btnExcluiDoc[ind].Location = new System.Drawing.Point(393, 245);
                btnExcluiDoc[ind].Name = "btnExcluiDoc" + ind;
                btnExcluiDoc[ind].Size = new System.Drawing.Size(115, 29);
                btnExcluiDoc[ind].TabIndex = 84;
                btnExcluiDoc[ind].Text = "Excluir";
                btnExcluiDoc[ind].UseVisualStyleBackColor = false;
                btnExcluiDoc[ind].Visible = false;
                btnExcluiDoc[ind].Click += new EventHandler(btnExcluiDoc_Click);
                // 
                // btnAtualizaDoc
                // 
                btnAtualizaDoc[ind] = new Button();
                btnAtualizaDoc[ind].BackColor = System.Drawing.Color.ForestGreen;
                btnAtualizaDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnAtualizaDoc[ind].ForeColor = System.Drawing.Color.Snow;
                btnAtualizaDoc[ind].Location = new System.Drawing.Point(515, 245);
                btnAtualizaDoc[ind].Name = "btnAtualizaDoc" + ind;
                btnAtualizaDoc[ind].Size = new System.Drawing.Size(115, 29);
                btnAtualizaDoc[ind].TabIndex = 83;
                btnAtualizaDoc[ind].Text = "Atualizar";
                btnAtualizaDoc[ind].UseVisualStyleBackColor = false;
                btnAtualizaDoc[ind].Visible = false;
                btnAtualizaDoc[ind].Click += new System.EventHandler(btnAtualizaDoc_Click);
                // 
                // btnSalvaDoc
                // 
                btnSalvaDoc[ind] = new Button();
                btnSalvaDoc[ind].BackColor = System.Drawing.Color.ForestGreen;
                btnSalvaDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnSalvaDoc[ind].ForeColor = System.Drawing.Color.Snow;
                btnSalvaDoc[ind].Location = new System.Drawing.Point(515, 245);
                btnSalvaDoc[ind].Name = "btnSalvaDoc" + ind;
                btnSalvaDoc[ind].Size = new System.Drawing.Size(115, 29);
                btnSalvaDoc[ind].TabIndex = 82;
                btnSalvaDoc[ind].Text = "Salvar";
                btnSalvaDoc[ind].UseVisualStyleBackColor = false;
                btnSalvaDoc[ind].Visible = true;
                btnSalvaDoc[ind].Click += new System.EventHandler(btnSalvaDoc_Click);
                // 
                // btnEditarDoc
                // 
                btnEditarDoc[ind] = new Button();
                btnEditarDoc[ind].BackColor = System.Drawing.Color.ForestGreen;
                btnEditarDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnEditarDoc[ind].ForeColor = System.Drawing.Color.Snow;
                btnEditarDoc[ind].Location = new System.Drawing.Point(650, 245);
                btnEditarDoc[ind].Name = "btnEditarDoc" + ind;
                btnEditarDoc[ind].Size = new System.Drawing.Size(115, 29);
                btnEditarDoc[ind].TabIndex = 82;
                btnEditarDoc[ind].Text = "Editar";
                btnEditarDoc[ind].UseVisualStyleBackColor = false;
                btnEditarDoc[ind].Visible = true;
                btnEditarDoc[ind].Click += new System.EventHandler(btnEditarDoc_Click);
                // 
                // comboBoxOrgDec
                // 
                comboBoxOrgDec[ind] = new ComboBox();
                comboBoxOrgDec[ind].FormattingEnabled = true;
                comboBoxOrgDec[ind].Location = new System.Drawing.Point(148, 147);
                comboBoxOrgDec[ind].Name = "comboBoxOrgDec" + ind;
                comboBoxOrgDec[ind].Size = new System.Drawing.Size(155, 21);
                comboBoxOrgDec[ind].TabIndex = 81;
                // 
                // comboBoxDecisao
                // 
                comboBoxDecisao[ind] = new ComboBox();
                comboBoxDecisao[ind].FormattingEnabled = true;
                comboBoxDecisao[ind].Location = new System.Drawing.Point(78, 177);
                comboBoxDecisao[ind].Name = "comboBoxDecisao" + ind;
                comboBoxDecisao[ind].Size = new System.Drawing.Size(292, 21);
                comboBoxDecisao[ind].TabIndex = 66;

                // 
                // lblDecisao
                //
                lblDecisao[ind] = new Label();
                lblDecisao[ind].AutoSize = true;
                lblDecisao[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblDecisao[ind].Location = new System.Drawing.Point(13, 177);
                lblDecisao[ind].Name = "lblDecisao" + ind;
                lblDecisao[ind].Size = new System.Drawing.Size(109, 15);
                lblDecisao[ind].TabIndex = 80;
                lblDecisao[ind].Text = "Decisão";
                lblDecisao[ind].TextAlign = System.Drawing.ContentAlignment.TopRight;
                // 
                // labelProcesso
                // 
                labelProcesso[ind] = new Label();
                labelProcesso[ind].AutoSize = true;
                labelProcesso[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelProcesso[ind].Location = new System.Drawing.Point(13, 207);
                labelProcesso[ind].Name = "labelProcesso" + ind;
                labelProcesso[ind].Size = new System.Drawing.Size(85, 15);
                labelProcesso[ind].TabIndex = 80;
                labelProcesso[ind].Text = "Nº Processo";
                // 
                // txt_processo
                // 
                txt_processo[ind] = new MaskedTextBox();
                txt_processo[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txt_processo[ind].Location = new System.Drawing.Point(102, 207);
                txt_processo[ind].Mask = "0000.00.0.000000-0";
                txt_processo[ind].Name = "txt_processo" + ind;
                txt_processo[ind].Size = new System.Drawing.Size(123, 21);
                txt_processo[ind].TabIndex = 96;
                txt_processo[ind].TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;

                // 
                // labelPAAI
                // 
                labelPAAI[ind] = new Label();
                labelPAAI[ind].AutoSize = true;
                labelPAAI[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelPAAI[ind].Location = new System.Drawing.Point(13, 237);
                labelPAAI[ind].Name = "labelPAAI" + ind;
                labelPAAI[ind].Size = new System.Drawing.Size(85, 15);
                labelPAAI[ind].TabIndex = 80;
                labelPAAI[ind].Text = "Nº PAAI";
                // 
                // txt_N_PAAI
                // 
                txt_N_PAAI[ind] = new MaskedTextBox();
                txt_N_PAAI[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txt_N_PAAI[ind].Location = new System.Drawing.Point(82, 237);
                txt_N_PAAI[ind].Mask = "00000/0000-CCCCCCCC";
                txt_N_PAAI[ind].Name = "txt_N_PAAI" + ind;
                txt_N_PAAI[ind].Size = new System.Drawing.Size(123, 21);
                txt_N_PAAI[ind].TabIndex = 96;
                txt_N_PAAI[ind].TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;




                // 
                // labelOrgaoDec
                //
                labelOrgaoDec[ind] = new Label();
                labelOrgaoDec[ind].AutoSize = true;
                labelOrgaoDec[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelOrgaoDec[ind].Location = new System.Drawing.Point(13, 148);
                labelOrgaoDec[ind].Name = "labelOrgaoDec" + ind;
                labelOrgaoDec[ind].Size = new System.Drawing.Size(109, 15);
                labelOrgaoDec[ind].TabIndex = 80;
                labelOrgaoDec[ind].Text = "Orgão decisório";
                labelOrgaoDec[ind].TextAlign = System.Drawing.ContentAlignment.TopRight;
                // 
                // comboBoxApresent
                // 
                comboBoxApresent[ind] = new ComboBox();
                comboBoxApresent[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                comboBoxApresent[ind].FormattingEnabled = true;
                comboBoxApresent[ind].Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
                comboBoxApresent[ind].Location = new System.Drawing.Point(433, 8);
                comboBoxApresent[ind].Name = "comboBoxApresent" + ind;
                comboBoxApresent[ind].Size = new System.Drawing.Size(69, 23);
                comboBoxApresent[ind].TabIndex = 79;
                // 
                // labelApresenta
                // 
                labelApresenta[ind] = new Label();
                labelApresenta[ind].AutoSize = true;
                labelApresenta[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelApresenta[ind].Location = new System.Drawing.Point(333, 11);
                labelApresenta[ind].Name = "labelApresenta" + ind;
                labelApresenta[ind].Size = new System.Drawing.Size(94, 15);
                labelApresenta[ind].TabIndex = 78;
                labelApresenta[ind].Text = "Apresentação";
                // 
                // comboBoxMotivo
                // 
                comboBoxMotivo[ind] = new ComboBox();
                comboBoxMotivo[ind].AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
                comboBoxMotivo[ind].AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
                comboBoxMotivo[ind].Items.AddRange(new object[] {
            "",
            "FLAGRANTE",
            "MBA"});
                comboBoxMotivo[ind].Location = new System.Drawing.Point(140, 10);
                comboBoxMotivo[ind].Name = "comboBoxMotivo" + ind;
                comboBoxMotivo[ind].Size = new System.Drawing.Size(168, 21);
                comboBoxMotivo[ind].TabIndex = 77;
                // 
                // lblMotivo
                // 
                lblMotivo[ind] = new Label();
                lblMotivo[ind].AutoSize = true;
                lblMotivo[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblMotivo[ind].Location = new System.Drawing.Point(12, 11);
                lblMotivo[ind].Name = "lblMotivo" + ind;
                lblMotivo[ind].Size = new System.Drawing.Size(122, 15);
                lblMotivo[ind].TabIndex = 76;
                lblMotivo[ind].Text = "Motivo da entrada";
                // 
                // txtOutraOrigem
                // 
                txtOutraOrigem[ind] = new TextBox();
                txtOutraOrigem[ind].CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                txtOutraOrigem[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtOutraOrigem[ind].Location = new System.Drawing.Point(678, 42);
                txtOutraOrigem[ind].Name = "txtOutraOrigem" + ind;
                txtOutraOrigem[ind].Size = new System.Drawing.Size(125, 21);
                txtOutraOrigem[ind].TabIndex = 75;
                txtOutraOrigem[ind].Visible = false;
                // 
                // labelOrigemO
                // 
                labelOrigemO[ind] = new Label();
                labelOrigemO[ind].AutoSize = true;
                labelOrigemO[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelOrigemO[ind].Location = new System.Drawing.Point(581, 43);
                labelOrigemO[ind].Name = "labelOrigemO" + ind;
                labelOrigemO[ind].Size = new System.Drawing.Size(91, 15);
                labelOrigemO[ind].TabIndex = 74;
                labelOrigemO[ind].Text = "Outra origem";
                labelOrigemO[ind].Visible = false;
                // 
                // txtNumero_sai
                // 
                txtNumero_sai[ind] = new MaskedTextBox();
                txtNumero_sai[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtNumero_sai[ind].ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                txtNumero_sai[ind].Location = new System.Drawing.Point(246, 81);
                txtNumero_sai[ind].Mask = "000000/0000";
                txtNumero_sai[ind].Name = "txtNumero_sai" + ind;
                txtNumero_sai[ind].Size = new System.Drawing.Size(81, 21);
                txtNumero_sai[ind].TabIndex = 73;
                txtNumero_sai[ind].TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
                // 
                // txtNumero_ent
                // 
                txtNumero_ent[ind] = new MaskedTextBox();
                txtNumero_ent[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtNumero_ent[ind].Location = new System.Drawing.Point(244, 42);
                txtNumero_ent[ind].Mask = "000000/0000";
                txtNumero_ent[ind].Name = "txtNumero_ent" + ind;
                txtNumero_ent[ind].Size = new System.Drawing.Size(83, 21);
                txtNumero_ent[ind].TabIndex = 72;
                txtNumero_ent[ind].TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
                // 
                // comboBoxDestino
                // 
                comboBoxDestino[ind] = new ComboBox();
                comboBoxDestino[ind].FormattingEnabled = true;
                comboBoxDestino[ind].Location = new System.Drawing.Point(393, 81);
                comboBoxDestino[ind].Name = "comboBoxDestino" + ind;
                comboBoxDestino[ind].Size = new System.Drawing.Size(180, 21);
                comboBoxDestino[ind].TabIndex = 71;
                // 
                // comboBoxOrigem
                // 
                comboBoxOrigem[ind] = new ComboBox();
                comboBoxOrigem[ind].FormattingEnabled = true;
                comboBoxOrigem[ind].Location = new System.Drawing.Point(393, 42);
                comboBoxOrigem[ind].Name = "comboBoxOrigem" + ind;
                comboBoxOrigem[ind].Size = new System.Drawing.Size(180, 21);
                comboBoxOrigem[ind].TabIndex = 70;
                comboBoxOrigem[ind].SelectedIndexChanged += new System.EventHandler(comboBoxOrigem_SelectedIndexChanged);
                // 
                // lblDestino
                // 
                lblDestino[ind] = new Label();
                lblDestino[ind].AutoSize = true;
                lblDestino[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblDestino[ind].Location = new System.Drawing.Point(333, 83);
                lblDestino[ind].Name = "lblDestino" + ind;
                lblDestino[ind].Size = new System.Drawing.Size(56, 15);
                lblDestino[ind].TabIndex = 69;
                lblDestino[ind].Text = "Destino";
                lblDestino[ind].TextAlign = System.Drawing.ContentAlignment.TopRight;
                // 
                // lblNumero_sai
                //
                lblNumero_sai[ind] = new Label();
                lblNumero_sai[ind].AutoSize = true;
                lblNumero_sai[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNumero_sai[ind].Location = new System.Drawing.Point(214, 82);
                lblNumero_sai[ind].Name = "lblNumero_sai" + ind;
                lblNumero_sai[ind].Size = new System.Drawing.Size(26, 15);
                lblNumero_sai[ind].TabIndex = 68;
                lblNumero_sai[ind].Text = "Nº ";
                // 
                // cmbDoc_sai
                // 
                cmbDoc_sai[ind] = new ComboBox();
                cmbDoc_sai[ind].FormattingEnabled = true;
                cmbDoc_sai[ind].Items.AddRange(new object[] {
            "OFÍCIO",
            "MEMORANDO"});
                cmbDoc_sai[ind].Location = new System.Drawing.Point(76, 81);
                cmbDoc_sai[ind].Name = "cmbDoc_sai" + ind;
                cmbDoc_sai[ind].Size = new System.Drawing.Size(121, 21);
                cmbDoc_sai[ind].TabIndex = 67;
                // 
                // lblSaida
                //
                lblSaida[ind] = new Label();
                lblSaida[ind].AutoSize = true;
                lblSaida[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblSaida[ind].Location = new System.Drawing.Point(13, 82);
                lblSaida[ind].Name = "lblSaida" + ind;
                lblSaida[ind].Size = new System.Drawing.Size(44, 15);
                lblSaida[ind].TabIndex = 66;
                lblSaida[ind].Text = "Saída";
                // 
                // lblIdDoc
                //
                lblIdDoc[ind] = new Label();
                lblIdDoc[ind].AutoSize = true;
                lblIdDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblIdDoc[ind].Location = new System.Drawing.Point(13, 82);
                lblIdDoc[ind].Name = "lblIdDoc" + ind;
                lblIdDoc[ind].Size = new System.Drawing.Size(44, 15);
                lblIdDoc[ind].TabIndex = 66;
                lblIdDoc[ind].Text = "";
                lblIdDoc[ind].Visible =false;
                // 
                // lblIdCount
                //
                lblIdCount[ind] = new Label();
                lblIdCount[ind].AutoSize = true;
                lblIdCount[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblIdCount[ind].Location = new System.Drawing.Point(30, 82);
                lblIdCount[ind].Name = "lblIdDoc" + ind;
                lblIdCount[ind].Size = new System.Drawing.Size(44, 15);
                lblIdCount[ind].TabIndex = 66;
                lblIdCount[ind].Text = "";
                lblIdCount[ind].Visible = false;
                // 
                // lblOrigem_Ent
                // 
                lblOrigem_Ent[ind] = new Label();
                lblOrigem_Ent[ind].AutoSize = true;
                lblOrigem_Ent[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblOrigem_Ent[ind].Location = new System.Drawing.Point(333, 43);
                lblOrigem_Ent[ind].Name = "lblOrigem_Ent" + ind;
                lblOrigem_Ent[ind].Size = new System.Drawing.Size(54, 15);
                lblOrigem_Ent[ind].TabIndex = 65;
                lblOrigem_Ent[ind].Text = "Origem";
                lblOrigem_Ent[ind].TextAlign = System.Drawing.ContentAlignment.TopRight;
                // 
                // labelNEnt
                // 
                labelNEnt[ind] = new Label();
                labelNEnt[ind].AutoSize = true;
                labelNEnt[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelNEnt[ind].Location = new System.Drawing.Point(214, 43);
                labelNEnt[ind].Name = "labelNEnt" + ind;
                labelNEnt[ind].Size = new System.Drawing.Size(26, 15);
                labelNEnt[ind].TabIndex = 64;
                labelNEnt[ind].Text = "Nº ";
                // 
                // cmbDoc_ent
                // 
                cmbDoc_ent[ind] = new ComboBox();
                cmbDoc_ent[ind].FormattingEnabled = true;
                cmbDoc_ent[ind].Items.AddRange(new object[] {
            "OFÍCIO",
            "MEMORANDO"});
                cmbDoc_ent[ind].Location = new System.Drawing.Point(76, 42);
                cmbDoc_ent[ind].Name = "cmbDoc_ent" + ind;
                cmbDoc_ent[ind].Size = new System.Drawing.Size(121, 21);
                cmbDoc_ent[ind].TabIndex = 63;
                // 
                // lblEntradaDoc
                // 
                lblEntradaDoc[ind] = new Label();
                lblEntradaDoc[ind].AutoSize = true;
                lblEntradaDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblEntradaDoc[ind].Location = new System.Drawing.Point(13, 43);
                lblEntradaDoc[ind].Name = "lblEntradaDoc" + ind;
                lblEntradaDoc[ind].Size = new System.Drawing.Size(57, 15);
                lblEntradaDoc[ind].TabIndex = 62;
                lblEntradaDoc[ind].Text = "Entrada";
                // 
                // btnNovoDoc
                // 
                btnNovoDoc[ind] = new Button();
                btnNovoDoc[ind].BackColor = System.Drawing.Color.ForestGreen;
                btnNovoDoc[ind].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnNovoDoc[ind].ForeColor = System.Drawing.Color.Snow;
                btnNovoDoc[ind].Location = new System.Drawing.Point(154, VlinButton);
                btnNovoDoc[ind].Name = "btnNovoDoc" + ind;
                btnNovoDoc[ind].Size = new System.Drawing.Size(151, 22);
                btnNovoDoc[ind].TabIndex = 84;
                btnNovoDoc[ind].Text = "+ Adicionar documento";
                btnNovoDoc[ind].UseVisualStyleBackColor = false;
                btnNovoDoc[ind].Click += new EventHandler(btnNovoDoc_Click);
                // 
                // panelDoc
                // 
                panelDoc[ind] = new Panel();
                panelDoc[ind].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panelDoc[ind].Controls.Add(txtOutrosDoc[ind]);
                panelDoc[ind].Controls.Add(lblOutros_doc[ind]);
                panelDoc[ind].Controls.Add(btnExcluiDoc[ind]);
                panelDoc[ind].Controls.Add(btnAtualizaDoc[ind]);
                panelDoc[ind].Controls.Add(btnSalvaDoc[ind]);
                panelDoc[ind].Controls.Add(btnEditarDoc[ind]);
                panelDoc[ind].Controls.Add(comboBoxOrgDec[ind]);
                panelDoc[ind].Controls.Add(labelOrgaoDec[ind]);
                panelDoc[ind].Controls.Add(lblDecisao[ind]);
                panelDoc[ind].Controls.Add(txt_processo[ind]);
                panelDoc[ind].Controls.Add(labelProcesso[ind]);
                panelDoc[ind].Controls.Add(labelPAAI[ind]);
                panelDoc[ind].Controls.Add(txt_N_PAAI[ind]);
                panelDoc[ind].Controls.Add(comboBoxApresent[ind]);
                panelDoc[ind].Controls.Add(labelApresenta[ind]);
                panelDoc[ind].Controls.Add(comboBoxMotivo[ind]);
                panelDoc[ind].Controls.Add(lblMotivo[ind]);
                panelDoc[ind].Controls.Add(lblIdCount[ind]);
                panelDoc[ind].Controls.Add(lblIdDoc[ind]);
                panelDoc[ind].Controls.Add(txtOutraOrigem[ind]);
                panelDoc[ind].Controls.Add(labelOrigemO[ind]);
                panelDoc[ind].Controls.Add(txtNumero_sai[ind]);
                panelDoc[ind].Controls.Add(txtNumero_ent[ind]);
                panelDoc[ind].Controls.Add(comboBoxDestino[ind]);
                panelDoc[ind].Controls.Add(comboBoxOrigem[ind]);
                panelDoc[ind].Controls.Add(comboBoxDecisao[ind]);
                panelDoc[ind].Controls.Add(lblDestino[ind]);
                panelDoc[ind].Controls.Add(lblNumero_sai[ind]);
                panelDoc[ind].Controls.Add(cmbDoc_sai[ind]);
                panelDoc[ind].Controls.Add(lblSaida[ind]);
                panelDoc[ind].Controls.Add(lblOrigem_Ent[ind]);
                panelDoc[ind].Controls.Add(labelNEnt[ind]);
                panelDoc[ind].Controls.Add(cmbDoc_ent[ind]);
                panelDoc[ind].Controls.Add(lblEntradaDoc[ind]);
                panelDoc[ind].Location = new System.Drawing.Point(155, VlinPanel);
                panelDoc[ind].Name = "panelDoc" + ind;
                panelDoc[ind].Size = new System.Drawing.Size(818, 283);
                panelDoc[ind].TabIndex = 62;

                //
                //Frm_Documentos
                //
                this.Controls.Add(panelDoc[ind]);
                this.Controls.Add(btnNovoDoc[ind]);
                //
                //FILL COMBO comboBoxOrigem
                //
                DataSet dtO = Conexao.SelectOrigem();
                foreach (DataRow oRow in dtO.Tables[0].Rows)
                {
                    int id = oRow.Field<int>("id_origem");
                    string desc = oRow.Field<string>("desc_origem");
                    comboBoxOrigem[ind].Items.Add(desc);
                }
                //
                //FILL COMBO comboBoxDestino
                //
                DataSet dtD = Conexao.SelectDestino();
                foreach (DataRow dRow in dtD.Tables[0].Rows)
                {
                    int id = dRow.Field<int>("id_destino");
                    string desc = dRow.Field<string>("desc_destino");
                    comboBoxDestino[ind].Items.Add(desc);
                }
                //
                //FILL COMBO comboBoxDecisao
                //
                DataSet dtDec = Conexao.SelectDecisao();
                foreach (DataRow decRow in dtDec.Tables[0].Rows)
                {
                    int id = decRow.Field<int>("id_decisao");
                    string desc = decRow.Field<string>("desc_decisao");
                    comboBoxDecisao[ind].Items.Add(desc);
                }
                DataSet dtOrgDec = Conexao.SelectOrgaoDecisorio();
                foreach (DataRow oRow in dtOrgDec.Tables[0].Rows)
                {
                    int id = oRow.Field<int>("id_org_decisorio");
                    string desc = oRow.Field<string>("desc_orgao_decisorio");
                    comboBoxOrgDec[ind].Items.Add(desc);
                }
                //
                //CARREGAMENTO DO FORM
                //
                disable_itens(ind);
                int idDoc = 0;
                try { idDoc = pRow.Field<int>("id_doc"); } catch { }
                lblIdDoc[ind].Text = idDoc.ToString();
                txtOutrosDoc[ind].Text = pRow.Field<string>("outros_doc");
                int orgDec = 0;
                try { orgDec = pRow.Field<int>("org_decisorio_doc"); }catch { }
                comboBoxOrgDec[ind].Text = aux.SetOrgao_decisorio(orgDec);
                txt_processo[ind].Text= pRow.Field<string>("n_processo");
                txt_N_PAAI[ind].Text= pRow.Field<string>("n_paai");
                int apres = 0;
                try { apres = pRow.Field<int>("apresentacao"); } catch { }
                comboBoxApresent[ind].Text = aux.Get_Apresent(apres);
                comboBoxMotivo[ind].Text= pRow.Field<string>("motivo_ent");
                int orig = 0;
                try { orig = pRow.Field<int>("origem_doc_ent"); } catch { }
                comboBoxOrigem[ind].Text = aux.GetOrigem(orig);
                if (comboBoxOrigem[ind].Text == "OUTROS")
                {
                    labelOrigemO[ind].Visible = true;
                    txtOutraOrigem[ind].Visible = true;
                    txtOutraOrigem[ind].Text = pRow.Field<string>("outra_origem_doc");
                    //MessageBox.Show(txtOutraOrigem.Text);
                }
                txtNumero_sai[ind].Text= pRow.Field<string>("num_doc_destino");
                txtNumero_ent[ind].Text= pRow.Field<string>("num_doc_origem");
                int destino = 0;
                try { destino = pRow.Field<int>("destino_doc_sai"); } catch { }
                comboBoxDestino[ind].Text = aux.GetDestino(destino);
                int decisao = 0;
                try { decisao = pRow.Field<int>("decisao_doc"); } catch { }
                comboBoxDecisao[ind].Text = aux.GetDecisao(decisao);
                cmbDoc_sai[ind].Text= pRow.Field<string>("tipo_doc_sai");
                cmbDoc_ent[ind].Text= pRow.Field<string>("tipo_doc_ent");
                int idC = 0;
                try { idC= pRow.Field<int>("idC_doc"); } catch { }
                lblIdCount[ind].Text = idC.ToString();
                btnAtualizaDoc[ind].Visible = true;
                btnSalvaDoc[ind].Visible = false;
                btnExcluiDoc[ind].Visible = true;

                if (dtDoc.Tables[0].Rows.Count > 1)
                {
                    //MessageBox.Show(dtDoc.Tables[0].Rows.Count.ToString());
                    if (ind == 0)
                    {
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        ind++;

                    }
                    else if (ind == 1 && dtDoc.Tables[0].Rows.Count >2)
                    {
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        btnNovoDoc[ind - 1].Visible = false;
                        btnNovoDoc[ind - 1].Enabled = false;
                        ind++;

                    }
                    else if (ind == 2 && dtDoc.Tables[0].Rows.Count > 3)
                    {
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        btnNovoDoc[ind - 1].Visible = false;
                        btnNovoDoc[ind - 1].Enabled = false;
                        ind++;

                    }
                    else if (ind == 3 && dtDoc.Tables[0].Rows.Count > 4)
                    {
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        btnNovoDoc[ind - 1].Visible = false;
                        btnNovoDoc[ind - 1].Enabled = false;
                        ind++;

                    }
                    else if (ind == 4 && dtDoc.Tables[0].Rows.Count > 5)
                    {
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        btnNovoDoc[ind - 1].Visible = false;
                        btnNovoDoc[ind - 1].Enabled = false;
                        ind++;

                    }
                    else if (ind == 5 && dtDoc.Tables[0].Rows.Count > 6)
                    {
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        btnNovoDoc[ind - 1].Visible = false;
                        btnNovoDoc[ind - 1].Enabled = false;
                        ind++;

                    }
                    else if (ind == 6 && dtDoc.Tables[0].Rows.Count > 7)
                    {
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        btnNovoDoc[ind - 1].Visible = false;
                        btnNovoDoc[ind - 1].Enabled = false;
                        ind++;

                    }
                    else if (ind == 7 && dtDoc.Tables[0].Rows.Count > 8)
                    {
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        btnNovoDoc[ind - 1].Visible = false;
                        btnNovoDoc[ind - 1].Enabled = false;
                        ind++;

                    }
                    else if (ind == 8 && dtDoc.Tables[0].Rows.Count > 9)
                    {
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        btnNovoDoc[ind - 1].Visible = false;
                        btnNovoDoc[ind - 1].Enabled = false;
                        ind++;

                    }
                    else
                    {
                        //MessageBox.Show("Entrou aqui");
                        VlinPanel = VlinPanel + 290;
                        VlinButton = VlinButton + 290;
                        btnNovoDoc[ind - 1].Visible = false;
                        btnNovoDoc[ind - 1].Enabled = false;
                    };
                   
                   
                }
               
            }
            //MessageBox.Show(ind.ToString());
        }
        //
        //Quando a origem é outra carrega um textbox txtOutraOrigem
        //
        private void comboBoxOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            string name = cmb.Name;
            string indice = name.Remove(0, 14);
            int i = Int32.Parse(indice);
            if (cmb.Text == "OUTROS")
            {
                try
                {
                    labelOrigemO[i].Visible = true;
                    txtOutraOrigem[i].Visible = true;
                }
                catch { }
                
            }
            else
            {
                try
                {
                    labelOrigemO[i].Visible = false;
                    txtOutraOrigem[i].Visible = false;
                    txtOutraOrigem[i].Text = "";
                }
                catch { }
                

            }
        }

        private void btnSalvaDoc_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string name = btn.Name;
            string indice = name.Remove(0, 11);
            int i = Int32.Parse(indice);
            Auxiliar aux = new Auxiliar();
            int idDoc = 0;
            try { idDoc = aux.Get_IdDoc(comboBoxMotivo[i].Text); } catch { };
            string plantaoDoc = instanciaF1.txtPlantao.Text;
            string idIntDoc = instanciaF1.txtIdAdolescente.Text;
            string tipoDocEnt = cmbDoc_ent[i].Text;
            string tipoDocSai = cmbDoc_sai[i].Text;
            string motivo_ent = comboBoxMotivo[i].Text;
            string numOrigemDoc = txtNumero_ent[i].Text;
            string numDestinoDoc = txtNumero_sai[i].Text;
            int apresentacaoDoc = aux.Get_Apresent(comboBoxApresent[i].Text);
            int origem_doc_ent = 0;
            try { origem_doc_ent = aux.SetOrigem_ent(comboBoxOrigem[i].Text); }catch { }
            string outraOriDoc = txtOutraOrigem[i].Text;
            int destino_doc_sai = 0;
            destino_doc_sai = aux.SetDestino(comboBoxDestino[i].Text);
            int org_dec_doc = 0;
            org_dec_doc = aux.GetOrgao_decisorio(comboBoxOrgDec[i].Text);
            int decisao = 0;
            decisao = aux.SetDecisao(comboBoxDecisao[i].Text);
            string n_processo_doc=txt_processo[i].Text;
            string n_paai_doc = txt_N_PAAI[i].Text;
            string outros_doc = txtOutrosDoc[i].Text;
            string idUsuDoc = instanciaF1.lblIdUsu.Text;
            Conexao.insere_Doc_Adole(idDoc, plantaoDoc, idIntDoc, tipoDocEnt, tipoDocSai, motivo_ent, numOrigemDoc, numDestinoDoc, apresentacaoDoc, origem_doc_ent, outraOriDoc, destino_doc_sai, org_dec_doc, decisao, n_processo_doc, n_paai_doc, outros_doc, idUsuDoc);
            btnAtualizaDoc[i].Visible = true;
            btnSalvaDoc[i].Visible = false;


        }
        private void btnAtualizaDoc_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string name = btn.Name;
            string indice = name.Remove(0, 14);
            int i = Int32.Parse(indice);
            Auxiliar aux = new Auxiliar();
            int idDoc =Int32.Parse(lblIdDoc[i].Text);
            string plantaoDoc = instanciaF1.txtPlantao.Text;
            string idIntDoc = instanciaF1.txtIdAdolescente.Text;
            string tipoDocEnt = cmbDoc_ent[i].Text;
            string tipoDocSai = cmbDoc_sai[i].Text;
            string motivo_ent = comboBoxMotivo[i].Text;
            string numOrigemDoc = txtNumero_ent[i].Text;
            string numDestinoDoc = txtNumero_sai[i].Text;
            int apresentacaoDoc = aux.Get_Apresent(comboBoxApresent[i].Text);
            int origem_doc_ent = 0;
            try { origem_doc_ent = aux.SetOrigem_ent(comboBoxOrigem[i].Text); } catch { }
            string outraOriDoc = txtOutraOrigem[i].Text;
            int destino_doc_sai = 0;
            destino_doc_sai = aux.SetDestino(comboBoxDestino[i].Text);
            int org_dec_doc = 0;
            org_dec_doc = aux.GetOrgao_decisorio(comboBoxOrgDec[i].Text);
            int decisao = 0;
            decisao = aux.SetDecisao(comboBoxDecisao[i].Text);
            string n_processo_doc = txt_processo[i].Text;
            string n_paai_doc = txt_N_PAAI[i].Text;
            string outros_doc = txtOutrosDoc[i].Text;
            string idUsuDoc = instanciaF1.lblIdUsu.Text;
            string idCount = lblIdCount[i].Text;
            int idC = Int32.Parse(idCount);

            Conexao.UPDATE_Doc_Adole(idC, idDoc, plantaoDoc, idIntDoc, tipoDocEnt, tipoDocSai, motivo_ent,  numOrigemDoc,  numDestinoDoc, apresentacaoDoc, origem_doc_ent, outraOriDoc, destino_doc_sai, org_dec_doc, decisao, n_processo_doc, n_paai_doc, outros_doc,  idUsuDoc);

        }
        
        private void btnNovoDoc_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            string name = btn.Name;
            string indice = name.Remove(0, 10);
            MessageBox.Show(indice);
            int i = Int32.Parse(indice);
            DataSet dtc= Conexao.selectDoc_Adolescente(instanciaF1.txtIdAdolescente.Text, instanciaF1.txtPlantao.Text);
            int count = dtc.Tables[0].Rows.Count;
            if(i > count-1)
            {
                MessageBox.Show("Preencha e salve o documento atual antes de criar outro.");
            }
            else
            {
                //MessageBox.Show(indice);
                btnNovoDoc[i].Visible = false;
                btnNovoDoc[i].Enabled = false;
                disable_itens(i);
                if (i > 0)
                {
                    if (i == 1) { i++; }
                    if (i == 2)
                    {
                        VlinPanel = 280 * (i);
                        VlinButton = 425 * (i);
                    }
                    else
                    {
                        VlinPanel = 305 * (i);
                        VlinButton = 400 * (i);
                    }
                        
                   
                }
                else
                {
                    MessageBox.Show("Entrou 290!");
                    VlinPanel = VlinPanel + 290;
                    VlinButton = VlinButton + 350;
                    
                }

                ind++;
                Frm_Documentos_Load_Empty();
                btnExcluiDoc[ind].Visible = true;
            }

        }
        //
        //DESABILITA OS ITENS DO FORM POR INDICE INT ITEM
        private void disable_itens(int item)
        {
            int i = item;
            txtOutrosDoc[i].Enabled = false;
            comboBoxOrgDec[i].Enabled = false;
            txt_processo[i].Enabled = false;
            txt_N_PAAI[i].Enabled = false;
            comboBoxApresent[i].Enabled = false;
            comboBoxMotivo[i].Enabled = false;
            comboBoxOrigem[i].Enabled = false;
            txtOutraOrigem[i].Enabled = false;
            txtNumero_sai[i].Enabled = false;
            txtNumero_ent[i].Enabled = false;
            comboBoxDestino[i].Enabled = false;
            comboBoxDecisao[i].Enabled = false;
            cmbDoc_sai[i].Enabled = false;
            cmbDoc_ent[i].Enabled = false;
            btnExcluiDoc[i].Enabled = false;
            btnAtualizaDoc[i].Enabled=false;
            btnSalvaDoc[i].Enabled=false;
        }
        private void enable_itens(int item)
        {
            int i = item;
            txtOutrosDoc[i].Enabled = true;
            comboBoxOrgDec[i].Enabled = true;
            txt_processo[i].Enabled = true;
            txt_N_PAAI[i].Enabled = true;
            comboBoxApresent[i].Enabled = true;
            comboBoxMotivo[i].Enabled = true;
            comboBoxOrigem[i].Enabled = true;
            txtOutraOrigem[i].Enabled = true;
            txtNumero_sai[i].Enabled = true;
            txtNumero_ent[i].Enabled = true;
            comboBoxDestino[i].Enabled = true;
            comboBoxDecisao[i].Enabled = true;
            cmbDoc_sai[i].Enabled = true;
            cmbDoc_ent[i].Enabled = true;
            btnExcluiDoc[i].Enabled = true;
            btnAtualizaDoc[i].Enabled = true;
            btnSalvaDoc[i].Enabled = true;
        }
        private void btnEditarDoc_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string name = btn.Name;
            string indice = name.Remove(0, 12);
            int i = Int32.Parse(indice);
            enable_itens(i);
            for(int y=0; y <= ind; y++)
            {
                if (y != i)
                {
                    disable_itens(y);
                }
            }

        }
        
        private void btnExcluiDoc_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string name = btn.Name;
            string indice = name.Remove(0, 12);
            int i = Int32.Parse(indice);
            if (i == 0)
            {
                MessageBox.Show("primeiro doc");
            }
            else
            {
                remove_panel(i);
            }


        }
        private void remove_panel(int i)
        {
            int y = i;
            this.Controls.Remove(panelDoc[y]);
            this.Controls.Remove(btnNovoDoc[y]);
            btnNovoDoc[y-1].Visible = true;
            btnNovoDoc[y-1].Enabled = true;
            enable_itens(y - 1);


        }
        


        private void btnSair_Click(object sender, EventArgs e)
        {
            Conexao.Desconecta();

        }
    }
}

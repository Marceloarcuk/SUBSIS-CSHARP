using System;
using System.Data;
using System.Windows.Forms;
using Modulo_Nai_Cadastro;
using WebCam_Capture;
using System.Drawing;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;



namespace Modulo_Nai_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1(string nomeUsu, string idUsu)
        {
            InitializeComponent();
            Plantao plt = new Plantao();
            lblData.Text=plt.GetPlantaoForm();
            lblUsuIdentic.Text = nomeUsu;
            lblIdUsu.Text = idUsu;
            //FillComboDecisao();
            //FillComboOrigem();
            //FillComboDestino();
            defineBtn_Atualizar_Salvar();
            string idPlant=Conexao.buscaPlantao_Atual();
            if (String.IsNullOrEmpty(idPlant))
            {
                Conexao.Insere_idPlantao();
            }
            btnOutros.Visible = false;
            btnAlteracoes.Visible = false;
            btbExcluir.Visible = false;
            btnSaida.Visible = false;


        }
        
        
        /***********************************************************************************************************/
        /************************************* BTN SALVAR DADOS DO ADOLESCENTE  *************************************/
        /***********************************************************************************************************/
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
            btnSalvar.Visible = false;
            btnAtualizar.Visible = true;
            //defineBtn_Atualizar_Salvar();

        }
        /***********************************************************************************************************/
        /************************************* LOAD COMBO comboBoxDecisao  *****************************************/
        /***********************************************************************************************************/
        private void FillComboDecisao()
        {
            DataSet dt = Conexao.SelectDecisao();
            foreach (DataRow pRow in dt.Tables[0].Rows)
            {
                int id = pRow.Field<int>("id_decisao");
                string desc = pRow.Field<string>("desc_decisao");
                //comboBoxDecisao.Items.Add(desc);
                
               
               

            }

        }
        /***********************************************************************************************************/
        /************************************* LOAD COMBO comboBoxOrigem  *****************************************/
        /***********************************************************************************************************/
        private void FillComboOrigem()
        {
            DataSet dt = Conexao.SelectOrigem();
            foreach (DataRow pRow in dt.Tables[0].Rows)
            {
                int id = pRow.Field<int>("id_origem");
                string desc = pRow.Field<string>("desc_origem");
                //comboBoxOrigem.Items.Add(desc);
                

            }
        }
        /***********************************************************************************************************/
        /************************************* LOAD COMBO comboBoxOrigem  *****************************************/
        /***********************************************************************************************************/
        private void FillComboDestino()
        {
            DataSet dt = Conexao.SelectDestino();
            foreach (DataRow pRow in dt.Tables[0].Rows)
            {
                int id = pRow.Field<int>("id_destino");
                string desc = pRow.Field<string>("desc_destino");
                //comboBoxDestino.Items.Add(desc);
                

            }
        }

        /***********************************************************************************************************/
        /******************************************** LOAD DO FORM  ************************************************/
        /***********************************************************************************************************/

        public void Form1_Load(object sender, EventArgs e)
        {
            //Splitter spl = new Splitter();
            
            Load_Datagrid();
            dataGridView4.ClearSelection();

            defineBtn_Atualizar_Salvar();
            //btnSalvar.Visible = true;
            //btnAtualizar.Visible = false;

        }
        /***********************************************************************************************************/
        /******************************************** FORM DA BUSCA JOVEM  *****************************************/
        /***********************************************************************************************************/
        public void load_FormJovem(string[] jovem)
        {
            int i = 0;
            string[] jVem = new string [4];
            try {  jVem = jovem; } catch {  }
            string nomeJ = "";
            string id_J = "";
            string cod_sipia = "";
            string ident_jovem = "";
            int x = 0;
           for(int y=0; y < 4; y++)
            {
                try { nomeJ = jVem[0]; } catch { }
                 try { id_J = jVem[1]; } catch { }
            }
            
            if (!String.IsNullOrEmpty(nomeJ) && !String.IsNullOrEmpty(id_J))
            {
                string cpf = "";
                string sipia = "";
                txtNome_int.Text = "";
                txtCpf.Text = "";
                txtSipia.Text = "";
                /*comboBoxDecisao.Text = "";
                cmbDoc_ent.Text = "";
                txtNumero_ent.Text = "";
                cmbDoc_sai.Text = "";
                txtNumero_sai.Text = "";
                comboBoxOrigem.Text = "";
                comboBoxDestino.Text = "";
                txtOutrosDoc.Text = "";
                txtPlantao.Text = "";
                comboBoxMotivo.Text = "";
                pictureBox1.Image = null;
                comboBoxVinculo_Ado.Text = "";*/
                string idFla = "";
                DataSet dtJ = Conexao.JovensEsp(nomeJ, id_J);
                foreach(DataRow pRow in dtJ.Tables[0].Rows)
                {
                    labelIDJovem.Text=pRow.Field<string>("id_jovem");
                    try { txtNome_int.Text = pRow.Field<string>("nome_jovem"); }catch { }
                    try { txtCpf.Text = pRow.Field<string>("cpf_jovem"); }catch { }

                    try { txtSipia.Text = pRow.Field<string>("cod_sipia"); } catch { }
                    byte[] img = pRow.Field<byte[]>("foto");
                    if(img != null)
                    {
                        //MessageBox.Show("Existe o byte!");
                    }
                    Image photo_ = ImageConvert.ByteArrayToImage(img);
                    pictureBox1.Image = photo_;
                    if (photo_ != null)
                    {
                        MessageBox.Show("Existe a imagem!");
                    }
                    if(pictureBox1.Image == null)
                    {
                        MessageBox.Show("Não converteu!");
                    }
                   
                }

            }

        }

        /***********************************************************************************************************/
        /******************************************** LOAD DO DATAGRID  ********************************************/
        /***********************************************************************************************************/
        public void Load_Datagrid()
        {
            dataGridView4.Rows.Clear();
            try
            {
                DataSet dadosInternos = Conexao.SelecionaAdolescente_plantao();
                int i = 0;
                string[]  docE = new string[2];
                string[] oriE = new string[2];
               
                string[] docD = new string[2];
                string dest = "";
                string dec = "";
                string[] outro = new string[2];
                string plantao = "";
                foreach(DataRow nRow in dadosInternos.Tables[0].Rows)
                {
                    if (!String.IsNullOrEmpty(nRow.Field<string>("outros_ent")))
                    {
                        string outros = nRow.Field<string>("outros_ent");


                        dataGridView4.Rows.Add((nRow.Field<string>("nome_interno")));
                    }
                    else
                    {
                        dataGridView4.Rows.Add((nRow.Field<string>("nome_interno")));
                    }
                    i++;
                }
                dataGridView4.ClearSelection();


                /* Auxiliar aux = new Auxiliar();
                 defineBtn_Atualizar_Salvar();
                 //comboboxFill_Vinculo();
                 foreach (DataRow pRow in dadosInternos.Tables[0].Rows)
                 {


                     if (pRow.Field<string>("tipo_doc_ent") == "OFÍCIO")
                     {
                         doc1E ="OF. "+pRow.Field<string>("num_doc_origem");
                     }
                     else
                     {
                         doc1E = "MEMO. "+ pRow.Field<string>("num_doc_origem");
                     }

                     if(pRow.Field<string>("documento_sai") == "MEMORANDO")
                     {
                         memorandoSai= pRow.Field<string>("n_documento_sai");
                     }
                     else
                     {
                         oficioSai= pRow.Field<string>("n_documento_sai");
                     }
                     int origem = 0;
                     int destino = 0;
                     int decisao = 0;
                     try {  origem = pRow.Field<int>("id_origem_doc_ent"); }catch { }
                     string sOrigem = aux.GetOrigem(origem);
                     try { destino = pRow.Field<int>("id_destino_doc_sai"); }catch { }
                     string sDestino = aux.GetDestino(destino);
                     try { decisao = pRow.Field<int>("id_decisao_cad"); }catch { }
                     string sDecisao = aux.GetDecisao(decisao);
                     if (oficioEnt == "    /")
                     {

                         oficioEnt = "";

                     }
                     if (memorandoEnt== "    /")
                     {

                         memorandoEnt = "";
                     }
                     if (memorandoSai== "    /")
                     {

                         memorandoSai = "";

                     }
                     if (oficioSai== "    /")
                     {

                         oficioSai = "";

                     }

                     if (!String.IsNullOrEmpty(pRow.Field<string>("outros_ent")))
                     {
                         string outros = pRow.Field<string>("outros_ent");


                         dataGridView4.Rows.Add((pRow.Field<string>("nome_interno")+"  ("+ outros + ")"), oficioEnt, memorandoEnt, sOrigem, oficioSai, memorandoSai, sDestino, (pRow.Field<string>("outros_doc")), sDecisao, pRow.Field<string>("id_plantao"));
                     }
                     else
                     {
                         dataGridView4.Rows.Add((pRow.Field<string>("nome_interno")), oficioEnt, memorandoEnt, sOrigem, oficioSai, memorandoSai, sDestino, (pRow.Field<string>("outros_doc")), sDecisao, pRow.Field<string>("id_plantao"));
                     }

                     //MessageBox.Show(i.ToString());
                     //i++;
                 }*/


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            
            
            
        }
        /***********************************************************************************************************/
        /******************************************** UPDATE ADOLESCENTE *******************************************/
        /***********************************************************************************************************/
        private void updateAdolescente(string idAdole, string nome, string cpf, string sipia, string plantao, Image photo)
        {
            Auxiliar aux = new Auxiliar();
            string cpfIn = cpf;
            string nsipia = sipia;
            string name = nome;
            string plantaoInt = plantao;
            /*string decisaoI = decisao;
            string docEntI = docEnt;
            string nDocEntI = nDocEnt;
            string docSaiI = docSai;
            string nDocSaiI = nDocSai;
            string origemEntI = origemEnt;*/
            string outraOrigem = "";
            /*if (origemEntI == "OUTROS")
            {
                outraOrigem = txtOutraOrigem.Text;
            }*/
            /*string destinoSaiI = destinoSai;
            string outrosDocI = outrosDoc;
            string motivoE = motivo;*/
            string idA = idAdole;
            //string vinculo = comboBoxVinculo_Ado.Text;
            string idSecri = labelIDJovem.Text;
            
            //int motivoEnt = aux.GetMotivo_Ent(motivoE);
            Image phot = photo;
            string IdUsuU = lblIdUsu.Text;
            Conexao.UpdateAdolescente_plantao(idA,name, nsipia, cpfIn, plantaoInt,  phot,  IdUsuU,  idSecri);
            Conexao.Desconecta();
            dataGridView4.Rows.Clear();
            //comboboxFill_Vinculo();
            string[] jovem = null;
            Load_Datagrid();
            dataGridView4.ClearSelection();

            //defineBtn_Atualizar_Salvar();
            btnSalvar.Visible = false;
            btnAtualizar.Visible = true;


        }
        /***********************************************************************************************************/
        /************************************************ SALVAR DADOS  ********************************************/
        /***********************************************************************************************************/

        private void salvar()
        {
            string nome = txtNome_int.Text;
            string cpf = txtCpf.Text;
            string sipia = txtSipia.Text;
            /*string docEntrada = cmbDoc_ent.Text;
            string docSaida = cmbDoc_sai.Text;
            string ndocEnt = txtNumero_ent.Text;
            string ndocSai = txtNumero_sai.Text;
            string origemEnt = comboBoxOrigem.Text;
            string outraOrigem = "";
            if (origemEnt == "OUTROS")
            {
                outraOrigem = txtOutraOrigem.Text;
            }
            string destinoSai = comboBoxDestino.Text;
            string outrosDoc = txtOutrosDoc.Text;
            string decisaoInt = comboBoxDecisao.Text;*/
            string idUsu = lblIdUsu.Text;
            string idSecri = labelIDJovem.Text;


            Auxiliar aux = new Auxiliar();
            //int motivoEnt = aux.GetMotivo_Ent(comboBoxMotivo.Text);
            int idFlagrante = 0;
            Image photo = pictureBox1.Image;
            int resp = 0;
            DataSet dtVerif = Conexao.verificaAdolescente_Existe(nome, idSecri, sipia, cpf);
            foreach (DataRow veRow in dtVerif.Tables[0].Rows)
            {

                string nomeVer = "";
                string idSecriVer = "";
                string sipiaVer = "";
                string cpfVer = "";

                nomeVer = veRow.Field<string>("nome_interno");
                idSecriVer = veRow.Field<string>("id_interno");
                sipiaVer = veRow.Field<string>("cod_sipia");
                cpfVer = veRow.Field<string>("cpf_interno");
                if ((!String.IsNullOrEmpty(nomeVer) && !String.IsNullOrEmpty(idSecriVer)) || (!String.IsNullOrEmpty(sipiaVer) && !String.IsNullOrEmpty(nomeVer)))
                {
                    labelAdoCadastrado.Visible = true;
                    txtNome_int.Text = veRow.Field<string>("nome_interno");
                    txtCpf.Text = veRow.Field<string>("cpf_interno");
                    txtSipia.Text = veRow.Field<string>("cod_sipia");
                    cpf = veRow.Field<string>("cpf_interno");
                    sipia = veRow.Field<string>("cod_sipia");
                    byte[] img = veRow.Field<byte[]>("foto");


                    pictureBox1.Image = ImageConvert.ByteArrayToImage(img);
                    resp = 1;

                }

            }
            if (resp == 0)
            {
                //MessageBox.Show("resp = 0");

                Conexao.InsereAdolescente(nome, cpf, sipia, idUsu, idSecri, photo);
                dataGridView4.Rows.Clear();
                
                string[] jovem = null;
                Load_Datagrid();
                btnSalvar.Visible = false;
                btnAtualizar.Visible = true;
            }

            btnSalvar.Visible = false;
            dataGridView4.ClearSelection();
            defineBtn_Atualizar_Salvar();
        }
        
        private void dataGridView4_CellValueChanged( object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ToString());
            //salvar();
            
        }
        /****************************************************************************************************************************************/
        /******************************************** EXIBIR DADOS DO FORM AO CLICAR NO CELLCONTENT  ********************************************/
        /****************************************************************************************************************************************/

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dtgw = sender as DataGridView;
            //MessageBox.Show(dtgw.ToString());
            labelAdoCadastrado.Visible = false;
            string datagrig = "";
            string nomeIntF = "";
            try { nomeIntF = Convert.ToString(dataGridView4["clnAdolescente4", e.RowIndex].Value); } catch { }

                if (!String.IsNullOrEmpty(nomeIntF))
                {
                    
                    //MessageBox.Show(datagrig);
                   
                    int i = nomeIntF.IndexOf('(');
                    string nomeInt = "";


                    if (i > 0)
                    {
                        string[] nome = nomeIntF.Split('(');
                        nomeInt = nome[0];
                        //MessageBox.Show(nomeInt);
                    }
                    else
                    {
                        nomeInt = nomeIntF;
                    }
                    //MessageBox.Show(nomeInt);


                    string plantaoI = Convert.ToString(dataGridView4["clnPlantao", e.RowIndex].Value);
                    //MessageBox.Show(plantaoI);
                    DataSet dadosInt = new DataSet();
                    string cpf = "";
                    string sipia = "";
                    txtNome_int.Text = "";
                    txtCpf.Text = "";
                    txtSipia.Text = "";
                    /*comboBoxDecisao.Text = "";
                    cmbDoc_ent.Text = "";
                    txtNumero_ent.Text = "";
                    cmbDoc_sai.Text = "";
                    txtNumero_sai.Text = "";
                    comboBoxOrigem.Text = "";
                    comboBoxDestino.Text = "";
                    txtOutrosDoc.Text = "";
                    txtPlantao.Text = "";
                    comboBoxMotivo.Text = "";
                    pictureBox1.Image = null;
                    comboBoxVinculo_Ado.Text = "";
                    labelOrigemO.Visible = false;
                    txtOutraOrigem.Visible = false;
               
                txtOutraOrigem.Text = "";*/

                 




                    if (nomeInt == "")
                    {
                        //MessageBox.Show("Entrou aqui");
                        //comboBoxVinculo_Ado.Text = "";
                        txtNome_int.Text = "";
                        txtCpf.Text = "";
                        txtSipia.Text = "";
                        /*comboBoxDecisao.Text = "";
                        cmbDoc_ent.Text = "";
                        txtNumero_ent.Text = "";
                        cmbDoc_sai.Text = "";
                        txtNumero_sai.Text = "";
                        comboBoxOrigem.Text = "";
                        comboBoxDestino.Text = "";
                        txtOutrosDoc.Text = "";
                        txtPlantao.Text = "";
                        comboBoxMotivo.Text = "";
                        pictureBox1.Image = null;
                        comboBoxVinculo_Ado.Text = "";
                        labelOrigemO.Visible = false;
                        txtOutraOrigem.Visible = false;
                        txtOutraOrigem.Text = "";*/



                        btnAtualizar.Visible = false;
                        btnSalvar.Visible = true;
                        btnOutros.Visible = false;
                        btnAlteracoes.Visible = false;
                        btbExcluir.Visible = false;
                        btnSaida.Visible = false;

                }
                    else
                    {
                        dadosInt = Conexao.SelecionaAdolescente(nomeInt, plantaoI);
                        //MessageBox.Show("Entrou aqui");
                        foreach (DataRow pRow in dadosInt.Tables[0].Rows)
                        {
                            txtNome_int.Text = pRow.Field<string>("nome_interno");
                       

                            txtCpf.Text = pRow.Field<string>("cpf_interno");
                            txtSipia.Text = pRow.Field<string>("cod_sipia");
                            cpf = pRow.Field<string>("cpf_interno");
                            sipia = pRow.Field<string>("cod_sipia");
                            byte[] img = pRow.Field<byte[]>("foto");
                           /* if (pRow.Field<int>("id_flagrante") != 0)
                            {
                                idFla = (pRow.Field<int>("id_flagrante")).ToString();
                            }*/
                            //comboBoxVinculo_Ado.Text = idFla;

                            pictureBox1.Image = ImageConvert.ByteArrayToImage(img);

                        }
                        btnAtualizar.Visible = true;
                        btnSalvar.Visible = false;
                        btnOutros.Visible = true;
                        btnAlteracoes.Visible = true;
                        btbExcluir.Visible = true;
                    btnSaida.Visible = true;


                    }
                    DataSet dadosNaiCad = new DataSet();

                    dadosNaiCad = Conexao.selecionaAdolescente_NAI_entrada(nomeInt, sipia, cpf, plantaoI);
                    foreach (DataRow pRow in dadosNaiCad.Tables[0].Rows)
                    {

                        //após limpar
                        Auxiliar aux = new Auxiliar();
                        //int decisao = pRow.Field<int>("id_decisao_cad");
                        /*comboBoxDecisao.Text = aux.GetDecisao(decisao);
                        cmbDoc_ent.Text = pRow.Field<string>("documento_ent");
                        txtNumero_ent.Text = pRow.Field<string>("n_documento_ent");
                        cmbDoc_sai.Text = pRow.Field<string>("documento_sai");
                        //MessageBox.Show(cmbDoc_ent.Text+"nada consta");
                        txtNumero_sai.Text = pRow.Field<string>("n_documento_sai");
                        int origem = pRow.Field<int>("id_origem_doc_ent");
                        comboBoxOrigem.Text = aux.GetOrigem(origem);
                        int destino = pRow.Field<int>("id_destino_doc_sai");
                        comboBoxDestino.Text = aux.GetDestino(destino);
                        if (comboBoxOrigem.Text == "OUTROS")
                        {
                            labelOrigemO.Visible = true;
                            txtOutraOrigem.Visible = true;
                            txtOutraOrigem.Text = pRow.Field<string>("outra_origem");
                            //MessageBox.Show(txtOutraOrigem.Text);
                        }*/
                        //txtOutrosDoc.Text = pRow.Field<string>("outros_doc");
                        txtPlantao.Text = pRow.Field<string>("id_plantao");
                        txtIdAdolescente.Text = pRow.Field<string>("id_interno");
                        //int motivo = pRow.Field<int>("id_motivo_entrada");
                        //comboBoxMotivo.Text = aux.SetMotivo_Ent(motivo);
                        int modEntre = 0;
                    }
                }
                else
                {
                    //MessageBox.Show("É nulo!");
                }
            

           
            //defineBtn_Atualizar_Salvar();


        }
        /***********************************************************************************************************/
        /********************************************** BTN ATUALIZAR  *********************************************/
        /***********************************************************************************************************/

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome_int.Text;
            string cpf = txtCpf.Text;
            string sipia = txtSipia.Text;
            string plantao = txtPlantao.Text;
            /*string decisao = comboBoxDecisao.Text;
            string docEnt = cmbDoc_ent.Text;
            string nDocEnt = txtNumero_ent.Text;
            string docSai = cmbDoc_sai.Text;
            string nDocSai = txtNumero_sai.Text;
            string origemEnt = comboBoxOrigem.Text;
            string outraOrigem = "";
            
            string destinoSai = comboBoxDestino.Text;
            string outrosDoc = txtOutrosDoc.Text;*/
            //string motivoEnt = comboBoxMotivo.Text;
            string idAdole = txtIdAdolescente.Text;
            Image photo = pictureBox1.Image;
            updateAdolescente(idAdole ,nome, cpf, sipia, plantao, photo);
            dataGridView4.Rows.Clear();
           
            Load_Datagrid();
            //comboboxFill_Vinculo();
           
            dataGridView4.ClearSelection();
            btnAtualizar.Visible = true;
            btnSalvar.Visible = false;

        }

        private void btnNovaImagem_Click(object sender, EventArgs e)
        {
            mainWinForm cm = new mainWinForm(this);
            cm.Show();
        }

        private string get_nome()
        {
             string nomeAdol = txtNome_int.Text;
            return nomeAdol;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        /******************** CARREGA A IMAGEM DO COMPUTRADOR ***************************/
        /********************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                openFile.Filter = "jpg|*.jpg | png|*.png";
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void plantõesAnterioresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void extrairPlanilhaPlantãoAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView4.AllowUserToAddRows = false;
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Salvar documento Excel";
            string plantao = lblData.Text;
            plantao = plantao.Replace('/', '-'); 
            saveFileDialog1.FileName ="Plantão  " + plantao;
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls| Excel Files(2007)|*.xlsx";
            if(saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelArq = new Microsoft.Office.Interop.Excel.Application();
                ExcelArq.Application.Workbooks.Add(Type.Missing);
                ExcelArq.Application.Columns.ColumnWidth = 20;
                for (int i = 1; i < dataGridView4.Columns.Count + 1; i++)
                {
                    ExcelArq.Cells[1, i] = dataGridView4.Columns[i - 1].HeaderText;
                }
                for( int i = 0; i < dataGridView4.Rows.Count; i++)
                {
                    for( int j = 0; j < dataGridView4.Columns.Count; j++)
                    {
                        ExcelArq.Cells[i + 2, j + 1] = dataGridView4.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelArq.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelArq.ActiveWorkbook.Saved = true;
                ExcelArq.Quit();
                dataGridView4.AllowUserToAddRows = true;
            }
        }

        private void btnAlteracoes_Click(object sender, EventArgs e)
        {
            FrmAlteracoes frmAlt = new FrmAlteracoes(txtNome_int.Text, txtPlantao.Text, txtIdAdolescente.Text, lblIdUsu.Text);
            frmAlt.Show();
        }

        private void btnAbrirEfetivo_Click(object sender, EventArgs e)
        {
            FrmEfetivos frmEfet = new FrmEfetivos(lblIdUsu.Text, lblUsuIdentic.Text);
            frmEfet.Show();
        }
        /***********************************************************************************************************/
        /************************************ COMBOBOX VINCULO  ****************************************************/
        /***********************************************************************************************************/

        /*private void comboboxFill_Vinculo()
        {
            comboBoxVinculo_Ado.Items.Clear();
            DataSet dtflagrante = new DataSet();
            dtflagrante = Conexao.SelecionaAdolescente_flagrante();
            string nome = "";
            int idFlagrante ;
            foreach (DataRow pRow in dtflagrante.Tables[0].Rows)
            {
                nome = pRow.Field<string>("nome_interno");
                if(pRow.Field<int>("id_flagrante") != 0)
                {
                    idFlagrante = pRow.Field<int>("id_flagrante");
                    comboBoxVinculo_Ado.Items.Add(nome + ", ID Flagrante:" + idFlagrante);
                }
               
                
            }



        }*/
        

       
        
        private void  defineBtn_Atualizar_Salvar()
        {
            string nome = txtNome_int.Text ;
            string plantao = txtPlantao.Text;
            string id = txtIdAdolescente.Text;
            string idInsert = "";
            DataSet dt = Conexao.SelecionaAdolescente_Especifico(nome, plantao, id);
            foreach (DataRow pRow in dt.Tables[0].Rows)
            {
                idInsert = pRow.Field<string>("id_interno");
            }
            if (String.IsNullOrEmpty(idInsert))
            {
                btnAtualizar.Visible = false;
                //btnAtualizar.Enabled = false;
                btnSalvar.Visible = true;
                //btnAtualizar.Enabled = true;
            }
            else
            {
                btnSalvar.Visible = false;
                //btnSalvar.Enabled = false;
                btnAtualizar.Visible = true;
                //btnAtualizar.Enabled = true;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome_int.Text = "";
            txtCpf.Text = "";
            txtSipia.Text = "";
            /*comboBoxDecisao.Text = "";
            cmbDoc_ent.Text = "";
            txtNumero_ent.Text = "";
            cmbDoc_sai.Text = "";
            txtNumero_sai.Text = "";
            comboBoxOrigem.Text = "";
            comboBoxDestino.Text = "";
            txtOutrosDoc.Text = "";*/
            txtPlantao.Text = "";
            //comboBoxMotivo.Text = "";
            //comboBoxVinculo_Ado.Text = "";
            pictureBox1.Image = null;
            labelIDJovem.Visible = false;
            dataGridView4.Rows.Clear();
            Load_Datagrid();
            
            //comboboxFill_Vinculo();

            defineBtn_Atualizar_Salvar();
            /*labelOrigemO.Visible = false;
            txtOutraOrigem.Visible = false;
            txtOutraOrigem.Text = "";*/
            btnOutros.Visible = false;
            btnAlteracoes.Visible = false;
            btbExcluir.Visible = false;
            btnSaida.Visible = false;
            dataGridView4.ClearSelection();


        }

        private void btbAtualizar_Click(object sender, EventArgs e)
        {
            txtNome_int.Text = "";
            txtCpf.Text = "";
            txtSipia.Text = "";
            /*comboBoxDecisao.Text="";
            comboBoxDestino.Text="";
            comboBoxMotivo.Text="";
            comboBoxOrigem.Text="";
            comboBoxDecisao.Text = "";
            cmbDoc_ent.Text = "";
            txtNumero_ent.Text = "";
            cmbDoc_sai.Text = "";
            txtNumero_sai.Text = "";
            comboBoxOrigem.Text = "";
            comboBoxDestino.Text = "";
            txtOutrosDoc.Text = "";*/
            txtPlantao.Text = "";
            //comboBoxMotivo.Text = "";
            //comboBoxVinculo_Ado.Text = "";
            pictureBox1.Image = null;
           

            Load_Datagrid();
            
            //comboboxFill_Vinculo();
            defineBtn_Atualizar_Salvar();
            /*labelOrigemO.Visible = false;
            txtOutraOrigem.Visible = false;
            txtOutraOrigem.Text = "";*/
            btnOutros.Visible = false;
            btnAlteracoes.Visible = false;
            btbExcluir.Visible = false;
            btnSaida.Visible = false;
            dataGridView4.ClearSelection();


        }

      
        private void buscarJovensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_jovem_sel frm = new frm_jovem_sel(this);
            frm.Show();
        }

        private void btnBuscaJovem_Click(object sender, EventArgs e)
        {
            frm_jovem_sel frm = new frm_jovem_sel(this);
            frm.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlteraSenha frm = new FrmAlteraSenha(lblIdUsu.Text, lblUsuIdentic.Text);
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOutros_Click(object sender, EventArgs e)
        {
            FrmOutrasEnt frm = new FrmOutrasEnt(txtIdAdolescente.Text, txtPlantao.Text, txtNome_int.Text, lblIdUsu.Text);
            frm.Show();
        }

        private void btbExcluir_Click(object sender, EventArgs e)
        {
            string titulo = "Excluir Adolescente";
            string msg = "Deseja excluir o adolescente " + txtNome_int.Text+"?";
            DialogResult resul = new DialogResult();
            resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(resul == DialogResult.Yes)
            {
                int x = 0;
                x=Conexao.deletaAdolescente(txtIdAdolescente.Text, txtPlantao.Text, lblIdUsu.Text);
                if (x == 1)
                {
                    MessageBox.Show("Adolescente excluído com sucesso!");
                    txtNome_int.Text = "";
                    txtCpf.Text = "";
                    txtSipia.Text = "";
                    /*comboBoxDecisao.Text = "";
                    comboBoxDestino.Text = "";
                    comboBoxMotivo.Text = "";
                    comboBoxOrigem.Text = "";
                    comboBoxDecisao.Text = "";
                    cmbDoc_ent.Text = "";
                    txtNumero_ent.Text = "";
                    cmbDoc_sai.Text = "";
                    txtNumero_sai.Text = "";
                    comboBoxOrigem.Text = "";
                    comboBoxDestino.Text = "";
                    txtOutrosDoc.Text = "";*/
                    txtPlantao.Text = "";
                    /*comboBoxMotivo.Text = "";
                    comboBoxVinculo_Ado.Text = "";*/
                    pictureBox1.Image = null;
                    dataGridView4.ClearSelection();
                    btnSaida.Visible = false;

                    Load_Datagrid();

                    //comboboxFill_Vinculo();
                    defineBtn_Atualizar_Salvar();

                }
            }
           
        }

       /* private void comboBoxOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb.Text == "OUTROS")
            {
                labelOrigemO.Visible = true;
                txtOutraOrigem.Visible = true;
            }
            else
            {
                labelOrigemO.Visible = false;
                txtOutraOrigem.Visible = false;
                txtOutraOrigem.Text = "";

            }
        }*/

        private void btnSaida_Click(object sender, EventArgs e)
        {
            string titulo = "Remover adolescente do NAI";
            string msg = "Deseja remover o adolescente " + txtNome_int.Text + "?";
            DialogResult resul = new DialogResult();
            resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resul == DialogResult.Yes)
            {
                int x = 0;
                x = Conexao.removeAdolescenteQuarto(txtIdAdolescente.Text, txtPlantao.Text, lblIdUsu.Text, txtPlantao.Text);
                if (x == 1)
                {
                    MessageBox.Show("Adolescente removido com sucesso!");
                    txtNome_int.Text = "";
                    txtCpf.Text = "";
                    txtSipia.Text = "";
                   
                    txtPlantao.Text = "";
                    /*comboBoxMotivo.Text = "";
                    comboBoxVinculo_Ado.Text = "";*/
                    pictureBox1.Image = null;
                    btnSaida.Visible = false;
                    dataGridView4.ClearSelection();
                    btnAtualizar.Visible = false;
                    btnSalvar.Visible = true;
                    btnOutros.Visible = false;
                    btnAlteracoes.Visible = false;
                    btbExcluir.Visible = false;
                    btnSaida.Visible = false;

                    Load_Datagrid();

                    //comboboxFill_Vinculo();
                    defineBtn_Atualizar_Salvar();

                }
            }
            
           
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome_int.Text))
            {
                MessageBox.Show("Primeiro insira e salve os 'DADOS DO ADOLESCENTE', como nome, SIPIA ou CPF.");
            }
            else
            {
                Frm_Documentos frm = new Frm_Documentos(this);
                frm.Show();
            }

        }
    }
}


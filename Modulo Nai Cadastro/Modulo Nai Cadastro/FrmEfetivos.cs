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
    public partial class FrmEfetivos : Form
    {
        public FrmEfetivos(string idUsu, string nomeUsu)
        {
            InitializeComponent();
            labelIdusu.Text = idUsu;
            Form_Load();
        }
        public int lb = 0;
        public int lbs = 0;
        public Label[] lblFlagrante_Mba = new Label[50];
        public Label[] lblSiPiaForm = new Label[50];
        
        public void Limpa_labelAdo()
        {
            for(int i=0; i< lb; i++)
            {
                try
                {
                    panelQuaroA1.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuartoA3.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuartoA5.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuartoA7.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuartoA9.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuartoA11.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuartoA13.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuaroB2.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuaroB4.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuaroB6.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuaroB8.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuaroB10.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuaroB12.Controls.Remove(lblFlagrante_Mba[i]);
                    panelQuaroB14.Controls.Remove(lblFlagrante_Mba[i]);
                   
                }
                catch { };
                lblFlagrante_Mba[i].Controls.Clear();
                
            }
            for(int y=0; y < lb; y++)
            {
                try
                {
                    //SIPIA
                    panelQuaroA1.Controls.Remove(lblSiPiaForm[y]);
                    panelQuartoA3.Controls.Remove(lblSiPiaForm[y]);
                    panelQuartoA5.Controls.Remove(lblSiPiaForm[y]);
                    panelQuartoA7.Controls.Remove(lblSiPiaForm[y]);
                    panelQuartoA9.Controls.Remove(lblSiPiaForm[y]);
                    panelQuartoA11.Controls.Remove(lblSiPiaForm[y]);
                    panelQuartoA13.Controls.Remove(lblSiPiaForm[y]);
                    panelQuaroB2.Controls.Remove(lblSiPiaForm[y]);
                    panelQuaroB4.Controls.Remove(lblSiPiaForm[y]);
                    panelQuaroB6.Controls.Remove(lblSiPiaForm[y]);
                    panelQuaroB8.Controls.Remove(lblSiPiaForm[y]);
                    panelQuaroB10.Controls.Remove(lblSiPiaForm[y]);
                    panelQuaroB12.Controls.Remove(lblSiPiaForm[y]);
                    panelQuaroB14.Controls.Remove(lblSiPiaForm[y]);
                }
                catch { }
                try { lblSiPiaForm[y].Controls.Clear(); }catch { }

            }
            //lado A
            labelAdo_LA_Q1_1.Text = "";
            labelAdo_LA_Q1_2.Text = "";
            labelAdo_LA_Q1_3.Text = "";
            labelAdo_LA_Q1_4.Text = "";
            labelAdo_LA_Q3_1.Text = "";
            labelAdo_LA_Q3_2.Text = "";
            labelAdo_LA_Q3_3.Text = "";
            labelAdo_LA_Q3_4.Text = "";
            labelAdo_LA_Q5_1.Text = "";
            labelAdo_LA_Q5_2.Text = "";
            labelAdo_LA_Q5_3.Text = "";
            labelAdo_LA_Q5_4.Text = "";
            labelAdo_LA_Q7_1.Text = "";
            labelAdo_LA_Q7_2.Text = "";
            labelAdo_LA_Q7_3.Text = "";
            labelAdo_LA_Q7_4.Text = "";
            labelAdo_LA_Q9_1.Text = "";
            labelAdo_LA_Q9_2.Text = "";
            labelAdo_LA_Q9_3.Text = "";
            labelAdo_LA_Q9_4.Text = "";
            labelAdo_LA_Q11_1.Text = "";
            labelAdo_LA_Q11_2.Text = "";
            labelAdo_LA_Q11_3.Text = "";
            labelAdo_LA_Q11_4.Text = "";
            labelAdo_LA_Q13_1.Text = "";
            labelAdo_LA_Q13_2.Text = "";
            labelAdo_LA_Q13_3.Text = "";
            labelAdo_LA_Q13_4.Text = "";
            //lado b
            labelAdo_LB_Q2_1.Text = "";
            labelAdo_LB_Q2_2.Text = "";
            labelAdo_LB_Q2_3.Text = "";
            labelAdo_LB_Q2_4.Text = "";
            labelAdo_LB_Q4_1.Text = "";
            labelAdo_LB_Q4_2.Text = "";
            labelAdo_LB_Q4_3.Text = "";
            labelAdo_LB_Q4_4.Text = "";
            labelAdo_LB_Q6_1.Text = "";
            labelAdo_LB_Q6_2.Text = "";
            labelAdo_LB_Q6_3.Text = "";
            labelAdo_LB_Q6_4.Text = "";
            labelAdo_LB_Q8_1.Text = "";
            labelAdo_LB_Q8_2.Text = "";
            labelAdo_LB_Q8_3.Text = "";
            labelAdo_LB_Q8_4.Text = "";
            labelAdo_LB_Q10_1.Text = "";
            labelAdo_LB_Q10_2.Text = "";
            labelAdo_LB_Q10_3.Text = "";
            labelAdo_LB_Q10_4.Text = "";
            labelAdo_LB_Q12_1.Text = "";
            labelAdo_LB_Q12_2.Text = "";
            labelAdo_LB_Q12_3.Text = "";
            labelAdo_LB_Q12_4.Text = "";
            labelAdo_LB_Q14_1.Text = "";
            labelAdo_LB_Q14_2.Text = "";
            labelAdo_LB_Q14_3.Text = "";
            labelAdo_LB_Q14_4.Text = "";

           

        }


        public void Form_Load()
        {
            Limpa_labelAdo();
            DataSet dtEfetivo = Conexao.SelectAdolescenteEfetivo();
            DataSet dtInternos = Conexao.SelecionaAdolescente_plantao();
            // INDICES
            int q1 = 1; int q2 = 1; int q3 = 1; int q4 = 1; int q5 = 1; int q6 = 1; int q7 = 1;
            int q8 = 1; int q9 = 1; int q10 = 1; int q11 = 1; int q12 = 1; int q13 = 1; int q14 = 1;
            int vLin = 22;
            int vLin1 = 22;
            int vLin2 = 22;
            int vLin3 = 22;
            int vLin4 = 22;
            int vLin5 = 22;
            int vLin6 = 22;
            int vLin7 = 22;
            int vLin8 = 22;
            int vLin9 = 22;
            int vLin10 = 22;
            int vLin11 = 22;
            int vLin12 = 22;
            int vLin13 = 22;
            //sipia
            int vLins = 22;
            int vLins1 = 22;
            int vLins2 = 22;
            int vLins3 = 22;
            int vLins4 = 22;
            int vLins5 = 22;
            int vLins6 = 22;
            int vLins7 = 22;
            int vLins8 = 22;
            int vLins9 = 22;
            int vLins10 = 22;
            int vLins11 = 22;
            int vLins12 = 22;
            int vLins13 = 22;


            foreach (DataRow pRow in dtEfetivo.Tables[0].Rows)
            {
                string ala = pRow.Field<string>("ala_efetivo");
                int quarto = pRow.Field<int>("quarto_efetivo");
                string nome = pRow.Field<string>("nome_interno");
                string plantao = pRow.Field<string>("id_plantao");
                string idAdole = pRow.Field<string>("id_interno");
                string descFlaMba = pRow.Field<string>("desc_motivo");
                string sipiap= pRow.Field<string>("cod_sipia");

                if (!String.IsNullOrEmpty(nome))
                {
                    switch (ala)
                    {
                        case "A":
                            switch (quarto)
                            {
                                case 1:
                                    {
                                        if (q1 == 1)
                                        {
                                            labelAdo_LA_Q1_1.Text = nome;
                                            labelAdo_LA_Q1_1.Visible = true;
                                            idA_Q1_1.Text = idAdole;
                                            lblplantao1_1.Text = plantao;
                                            q1++;
                                        }
                                        else if (q1 == 2)
                                        {
                                            labelAdo_LA_Q1_2.Text = nome;
                                            labelAdo_LA_Q1_2.Visible = true;
                                            idA_Q1_2.Text = idAdole;
                                            lblplantao1_2.Text = plantao;
                                            q1++;
                                        }
                                        else if (q1 == 3)
                                        {
                                            labelAdo_LA_Q1_3.Text = nome;
                                            labelAdo_LA_Q1_3.Visible = true;
                                            idA_Q1_3.Text = idAdole;
                                            lblplantao1_3.Text = plantao;
                                            q1++;
                                        }
                                        else
                                        {
                                            labelAdo_LA_Q1_4.Text = nome;
                                            labelAdo_LA_Q1_4.Visible = true;
                                            idA_Q1_4.Text = idAdole;
                                            lblplantao1_4.Text = plantao;

                                        }

                                    }
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins = vLins + 22;
                                    }
                                    else 
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].ForeColor = System.Drawing.Color.Black;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text =sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuaroA1.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins = vLins + 22;
                                        lbs++;

                                    }
                                   
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin = vLin + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba"+lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        this.panelQuaroA1.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin = vLin + 22;
                                        lb++;
                                       
                                    }
                                    else
                                    {

                                    }

                                    break;

                                case 3:
                                    {
                                        if (q3 == 1)
                                        {
                                            labelAdo_LA_Q3_1.Text = nome;
                                            labelAdo_LA_Q3_1.Visible = true;
                                            idA_Q3_1.Text = idAdole;
                                            lblplantao3_1.Text = plantao;
                                            q3++;
                                        }
                                        else if (q3 == 2)
                                        {
                                            labelAdo_LA_Q3_2.Text = nome;
                                            labelAdo_LA_Q3_2.Visible = true;
                                            idA_Q3_2.Text = idAdole;
                                            lblplantao3_2.Text = plantao;
                                            q3++;
                                        }
                                        else if (q3 == 3)
                                        {
                                            labelAdo_LA_Q3_3.Text = nome;
                                            labelAdo_LA_Q3_3.Visible = true;
                                            idA_Q3_3.Text = idAdole;
                                            lblplantao3_3.Text = plantao;
                                            q3++;
                                        }
                                        else
                                        {
                                            labelAdo_LA_Q3_4.Text = nome;
                                            labelAdo_LA_Q3_4.Visible = true;
                                            idA_Q3_4.Text = idAdole;
                                            lblplantao3_4.Text = plantao;

                                        }
                                    }
                                   
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins1 = vLins1 + 22;
                                    }
                                    else 
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins1);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].ForeColor = System.Drawing.Color.Black;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuartoA3.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins1 = vLins1 + 22;
                                        lbs++;

                                    }
                                   
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin1 = vLin1 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin1);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba"+lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        this.panelQuartoA3.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin1 = vLin1 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    };
                                    break;
                                case 5:
                                    {
                                        if (q5 == 1)
                                        {
                                            labelAdo_LA_Q5_1.Text = nome;
                                            labelAdo_LA_Q5_1.Visible = true;
                                            idA_Q5_1.Text = idAdole;
                                            lblplantao5_1.Text = plantao;
                                            q5++;
                                        }
                                        else if (q5 == 2)
                                        {
                                            labelAdo_LA_Q5_2.Text = nome;
                                            labelAdo_LA_Q5_2.Visible = true;
                                            idA_Q5_2.Text = idAdole;
                                            lblplantao5_2.Text = plantao;
                                            q5++;
                                        }
                                        else if (q5 == 3)
                                        {
                                            labelAdo_LA_Q5_3.Text = nome;
                                            labelAdo_LA_Q5_3.Visible = true;
                                            idA_Q5_3.Text = idAdole;
                                            lblplantao5_3.Text = plantao;
                                            q5++;
                                        }
                                        else
                                        {
                                            labelAdo_LA_Q5_4.Text = nome;
                                            labelAdo_LA_Q5_4.Visible = true;
                                            idA_Q5_4.Text = idAdole;
                                            lblplantao5_4.Text = plantao;

                                        }
                                    }
                                   
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins2 = vLins2 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins2);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuartoA5.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins2 = vLins2 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin2 = vLin2 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin2);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba"+lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        this.panelQuartoA5.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin2 = vLin2 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }

                                    break;
                                case 7:
                                    {
                                        if (q7 == 1)
                                        {
                                            labelAdo_LA_Q7_1.Text = nome;
                                            labelAdo_LA_Q7_1.Visible = true;
                                            idA_Q7_1.Text = idAdole;
                                            lblplantao7_1.Text = plantao;
                                            q7++;
                                        }
                                        else if (q7 == 2)
                                        {
                                            labelAdo_LA_Q7_2.Text = nome;
                                            labelAdo_LA_Q7_2.Visible = true;
                                            idA_Q7_2.Text = idAdole;
                                            lblplantao7_2.Text = plantao;
                                            q7++;
                                        }
                                        else if (q7 == 3)
                                        {
                                            labelAdo_LA_Q7_3.Text = nome;
                                            labelAdo_LA_Q7_3.Visible = true;
                                            idA_Q7_3.Text = idAdole;
                                            lblplantao7_3.Text = plantao;
                                            q7++;
                                        }
                                        else
                                        {
                                            labelAdo_LA_Q7_4.Text = nome;
                                            labelAdo_LA_Q7_4.Visible = true;
                                            idA_Q7_4.Text = idAdole;
                                            lblplantao7_4.Text = plantao;

                                        }
                                    }
                                   
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins3 = vLins3 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins3);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex = 36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuartoA7.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins3 = vLins3 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin3 = vLin3 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin3);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        this.panelQuartoA7.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin3 = vLin3 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }
                                    break;
                                case 9:
                                    {
                                        if (q9 == 1)
                                        {
                                            labelAdo_LA_Q9_1.Text = nome;
                                            labelAdo_LA_Q9_1.Visible = true;
                                            idA_Q9_1.Text = idAdole;
                                            lblplantao9_1.Text = plantao;
                                            q9++;
                                        }
                                        else if (q9 == 2)
                                        {
                                            labelAdo_LA_Q9_2.Text = nome;
                                            labelAdo_LA_Q9_2.Visible = true;
                                            idA_Q9_2.Text = idAdole;
                                            lblplantao9_2.Text = plantao;
                                            q9++;
                                        }
                                        else if (q9 == 3)
                                        {
                                            labelAdo_LA_Q9_3.Text = nome;
                                            labelAdo_LA_Q9_3.Visible = true;
                                            idA_Q9_3.Text = idAdole;
                                            lblplantao9_3.Text = plantao;
                                            q9++;
                                        }
                                        else
                                        {
                                            labelAdo_LA_Q9_4.Text = nome;
                                            labelAdo_LA_Q9_4.Visible = true;
                                            idA_Q9_4.Text = idAdole;
                                            lblplantao9_4.Text = plantao;

                                        }
                                    }
                                    
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins4 = vLins4 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins4);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex = 36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuartoA9.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins4 = vLins4 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin4 = vLin4 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin4);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        this.panelQuartoA9.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin4 = vLin4 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }
                                    break;
                                case 11:
                                    {
                                        if (q11 == 1)
                                        {
                                            labelAdo_LA_Q11_1.Text = nome;
                                            labelAdo_LA_Q11_1.Visible = true;
                                            idA_Q11_1.Text = idAdole;
                                            lblplantao11_1.Text = plantao;
                                            q11++;
                                        }
                                        else if (q11 == 2)
                                        {
                                            labelAdo_LA_Q11_2.Text = nome;
                                            labelAdo_LA_Q11_2.Visible = true;
                                            idA_Q11_2.Text = idAdole;
                                            lblplantao11_2.Text = plantao;
                                            q11++;
                                        }
                                        else if (q11 == 3)
                                        {
                                            labelAdo_LA_Q11_3.Text = nome;
                                            labelAdo_LA_Q11_3.Visible = true;
                                            idA_Q11_3.Text = idAdole;
                                            lblplantao11_3.Text = plantao;
                                            q11++;
                                        }
                                        else
                                        {
                                            labelAdo_LA_Q11_4.Text = nome;
                                            labelAdo_LA_Q11_4.Visible = true;
                                            idA_Q11_4.Text = idAdole;
                                            lblplantao11_4.Text = plantao;

                                        }
                                    }
                                   
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins5 = vLins5 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins5);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex = 36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuartoA11.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins5 = vLins5 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin5 = vLin5 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin5);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        this.panelQuartoA11.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin5 = vLin5 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }
                                    break;
                                case 13:
                                    {
                                        if (q13 == 1)
                                        {
                                            labelAdo_LA_Q13_1.Text = nome;
                                            labelAdo_LA_Q13_1.Visible = true;
                                            idA_Q13_1.Text = idAdole;
                                            lblplantao13_1.Text = plantao;
                                            q13++;
                                        }
                                        else if (q13 == 2)
                                        {
                                            labelAdo_LA_Q13_2.Text = nome;
                                            labelAdo_LA_Q13_2.Visible = true;
                                            idA_Q13_2.Text = idAdole;
                                            lblplantao13_2.Text = plantao;
                                            q13++;
                                        }
                                        else if (q13 == 3)
                                        {
                                            labelAdo_LA_Q13_3.Text = nome;
                                            labelAdo_LA_Q13_3.Visible = true;
                                            idA_Q13_3.Text = idAdole;
                                            lblplantao13_3.Text = plantao;
                                            q13++;
                                        }
                                        else
                                        {
                                            labelAdo_LA_Q13_4.Text = nome;
                                            labelAdo_LA_Q13_4.Visible = true;
                                            idA_Q13_4.Text = idAdole;
                                            lblplantao13_4.Text = plantao;

                                        }
                                    }
                                    
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins6 = vLins6 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins6);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuartoA13.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins6 = vLins6 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin6 = vLin6 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin6);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        this.panelQuartoA13.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin6 = vLin6 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }
                                    break;
                            }
                            break;

                        case "B":
                            switch (quarto)
                            {
                                case 2:
                                    {
                                        if (q2 == 1)
                                        {
                                            labelAdo_LB_Q2_1.Text = nome;
                                            labelAdo_LB_Q2_1.Visible = true;
                                            idB_Q2_1.Text = idAdole;
                                            lblplantao2_1.Text = plantao;
                                            q2++;
                                        }
                                        else if (q2 == 2)
                                        {
                                            labelAdo_LB_Q2_2.Text = nome;
                                            labelAdo_LB_Q2_2.Visible = true;
                                            idB_Q2_2.Text = idAdole;
                                            lblplantao2_2.Text = plantao;
                                            q2++;
                                        }
                                        else if (q2 == 3)
                                        {
                                            labelAdo_LB_Q2_3.Text = nome;
                                            labelAdo_LB_Q2_3.Visible = true;
                                            idB_Q2_3.Text = idAdole;
                                            lblplantao2_3.Text = plantao;
                                            q2++;
                                        }
                                        else
                                        {
                                            labelAdo_LB_Q2_4.Text = nome;
                                            labelAdo_LB_Q2_4.Visible = true;
                                            idB_Q2_4.Text = idAdole;
                                            lblplantao2_4.Text = plantao;
                                           

                                        }
                                        if (String.IsNullOrEmpty(sipiap))
                                        {
                                            vLins7 = vLins7 + 22;
                                        }
                                        else if (!String.IsNullOrEmpty(sipiap))
                                        {
                                            lblSiPiaForm[lbs] = new Label();
                                            this.lblSiPiaForm[lbs].AutoSize = true;
                                            this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                            this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins7);
                                            this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                            this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                            this.lblSiPiaForm[lbs].TabIndex =36;
                                            this.lblSiPiaForm[lbs].Text = sipiap;

                                            this.lblSiPiaForm[lbs].Visible = true;
                                            this.panelQuaroB2.Controls.Add(this.lblSiPiaForm[lbs]);
                                            vLins7 = vLins7 + 22;
                                            lbs++;

                                        }
                                        else
                                        {

                                        }
                                        if (String.IsNullOrEmpty(descFlaMba))
                                        {
                                            vLin7 = vLin7 + 22;

                                        }
                                        else if (!String.IsNullOrEmpty(descFlaMba))
                                        {
                                            lblFlagrante_Mba[lb] = new Label();
                                            this.lblFlagrante_Mba[lb].AutoSize = true;
                                            this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                            this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin7);
                                            this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                            this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                            this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                            this.lblFlagrante_Mba[lb].TabIndex = 44;
                                            this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                            this.lblFlagrante_Mba[lb].Visible = true;
                                            panelQuaroB2.Controls.Add(this.lblFlagrante_Mba[lb]);
                                            vLin7 = vLin7 + 22;
                                            lb++;

                                        }
                                        else
                                        {

                                        }

                                    }

                                    break;

                                case 4:
                                    {
                                        if (q4 == 1)
                                        {
                                            labelAdo_LB_Q4_1.Text = nome;
                                            labelAdo_LB_Q4_1.Visible = true;
                                            idB_Q4_1.Text = idAdole;
                                            lblplantao4_1.Text = plantao;
                                            q4++;
                                        }
                                        else if (q4 == 2)
                                        {
                                            labelAdo_LB_Q4_2.Text = nome;
                                            labelAdo_LB_Q4_2.Visible = true;
                                            idB_Q4_2.Text = idAdole;
                                            lblplantao4_2.Text = plantao;
                                            q4++;
                                        }
                                        else if (q4 == 3)
                                        {
                                            labelAdo_LB_Q4_3.Text = nome;
                                            labelAdo_LB_Q4_3.Visible = true;
                                            idB_Q4_3.Text = idAdole;
                                            lblplantao4_3.Text = plantao;
                                            q4++;
                                        }
                                        else
                                        {
                                            labelAdo_LB_Q4_4.Text = nome;
                                            labelAdo_LB_Q4_4.Visible = true;
                                            idB_Q4_4.Text = idAdole;
                                            lblplantao4_4.Text = plantao;

                                        }
                                    }
                                    
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins8 = vLins8 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins8);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuaroB4.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins8 = vLins8 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin8 = vLin8 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin8);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        panelQuaroB4.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin8 = vLin8 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }
                                    break;
                                case 6:
                                    if (q6 == 1)
                                    {
                                        labelAdo_LB_Q6_1.Text = nome;
                                        labelAdo_LB_Q6_1.Visible = true;
                                        idB_Q6_1.Text = idAdole;
                                        lblplantao6_1.Text = plantao;
                                        q6++;
                                    }
                                    else if (q6 == 2)
                                    {
                                        labelAdo_LB_Q6_2.Text = nome;
                                        labelAdo_LB_Q6_2.Visible = true;
                                        idB_Q6_2.Text = idAdole;
                                        lblplantao6_2.Text = plantao;
                                        q6++;
                                    }
                                    else if (q6 == 3)
                                    {
                                        labelAdo_LB_Q6_3.Text = nome;
                                        labelAdo_LB_Q6_3.Visible = true;
                                        idB_Q6_3.Text = idAdole;
                                        lblplantao6_3.Text = plantao;
                                        q6++;
                                    }
                                    else
                                    {
                                        labelAdo_LB_Q6_4.Text = nome;
                                        labelAdo_LB_Q6_4.Visible = true;
                                        idB_Q6_4.Text = idAdole;
                                        lblplantao6_4.Text = plantao;
                                    }
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins9 = vLins9 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins9);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuaroB6.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins9 = vLins9 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin9 = vLin9 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin9);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        panelQuaroB6.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin9 = vLin9 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }

                                    break;
                                case 8:
                                    if (q8 == 1)
                                    {
                                        labelAdo_LB_Q8_1.Text = nome;
                                        labelAdo_LB_Q8_1.Visible = true;
                                        idB_Q8_1.Text = idAdole;
                                        lblplantao8_1.Text = plantao;
                                        q8++;
                                    }
                                    else if (q8 == 2)
                                    {
                                        labelAdo_LB_Q8_2.Text = nome;
                                        labelAdo_LB_Q8_2.Visible = true;
                                        idB_Q8_2.Text = idAdole;
                                        lblplantao8_2.Text = plantao;
                                        q8++;
                                    }
                                    else if (q8 == 3)
                                    {
                                        labelAdo_LB_Q8_3.Text = nome;
                                        labelAdo_LB_Q8_3.Visible = true;
                                        idB_Q8_3.Text = idAdole;
                                        lblplantao8_3.Text = plantao;
                                        q8++;
                                    }
                                    else
                                    {
                                        labelAdo_LB_Q8_4.Text = nome;
                                        labelAdo_LB_Q8_4.Visible = true;
                                        idB_Q8_4.Text = idAdole;
                                        lblplantao8_4.Text = plantao;
                                       
                                    }
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins10 = vLins10 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins10);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuaroB8.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins10 = vLins10 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin10 = vLin10 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin10);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        panelQuaroB8.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin10 = vLin10 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }
                                    break;
                                case 10:

                                    if (q10 == 1)
                                    {
                                        labelAdo_LB_Q10_1.Text = nome;
                                        labelAdo_LB_Q10_1.Visible = true;
                                        idB_Q10_1.Text = idAdole;
                                        lblplantao10_1.Text = plantao;
                                        q10++;
                                    }
                                    else if (q10 == 2)
                                    {
                                        labelAdo_LB_Q10_2.Text = nome;
                                        labelAdo_LB_Q10_2.Visible = true;
                                        idB_Q10_2.Text = idAdole;
                                        lblplantao10_2.Text = plantao;
                                        q10++;
                                    }
                                    else if (q10 == 3)
                                    {
                                        labelAdo_LB_Q10_3.Text = nome;
                                        labelAdo_LB_Q10_3.Visible = true;
                                        idB_Q10_3.Text = idAdole;
                                        lblplantao10_3.Text = plantao;
                                        q10++;
                                    }
                                    else
                                    {
                                        labelAdo_LB_Q10_4.Text = nome;
                                        labelAdo_LB_Q10_4.Visible = true;
                                        idB_Q10_4.Text = idAdole;
                                        lblplantao10_4.Text = plantao;
                                    }
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins11 = vLins11 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins11);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuaroB10.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins11 = vLins11 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin11 = vLin11 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin11);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        panelQuaroB10.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin11 = vLin11 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }
                                    break;
                                case 12:
                                    if (q12 == 1)
                                    {
                                        labelAdo_LB_Q12_1.Text = nome;
                                        labelAdo_LB_Q12_1.Visible = true;
                                        idB_Q12_1.Text = idAdole;
                                        lblplantao12_1.Text = plantao;
                                        q12++;
                                    }
                                    else if (q12 == 2)
                                    {
                                        labelAdo_LB_Q12_2.Text = nome;
                                        labelAdo_LB_Q12_2.Visible = true;
                                        idB_Q12_2.Text = idAdole;
                                        lblplantao12_2.Text = plantao;
                                        q12++;
                                    }
                                    else if (q12 == 3)
                                    {
                                        labelAdo_LB_Q12_3.Text = nome;
                                        labelAdo_LB_Q12_3.Visible = true;
                                        idB_Q12_3.Text = idAdole;
                                        lblplantao12_3.Text = plantao;
                                        q12++;
                                    }
                                    else
                                    {
                                        labelAdo_LB_Q12_4.Text = nome;
                                        labelAdo_LB_Q12_4.Visible = true;
                                        idB_Q12_4.Text = idAdole;
                                        lblplantao12_4.Text = plantao;
                                        
                                    }
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins12 = vLins12 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins12);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuaroB12.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins12 = vLins12 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin12 = vLin12 + 22;

                                    }

                                    else if(!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin12);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        panelQuaroB12.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin12 = vLin12 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }
                                    break;
                                case 14:
                                    if (q14 == 1)
                                    {
                                        labelAdo_LB_Q14_1.Text = nome;
                                        labelAdo_LB_Q14_1.Visible = true;
                                        idB_Q14_1.Text = idAdole;
                                        lblplantao14_1.Text = plantao;
                                        q14++;
                                    }
                                    else if (q14 == 2)
                                    {
                                        labelAdo_LB_Q14_2.Text = nome;
                                        labelAdo_LB_Q14_2.Visible = true;
                                        idB_Q14_2.Text = idAdole;
                                        lblplantao14_2.Text = plantao;
                                        q14++;
                                    }
                                    else if (q14 == 3)
                                    {
                                        labelAdo_LB_Q14_3.Text = nome;
                                        labelAdo_LB_Q14_3.Visible = true;
                                        idB_Q14_3.Text = idAdole;
                                        lblplantao14_3.Text = plantao;
                                        q14++;
                                    }
                                    else
                                    {
                                        labelAdo_LB_Q14_4.Text = nome;
                                        labelAdo_LB_Q14_4.Visible = true;
                                        idB_Q14_4.Text = idAdole;
                                        lblplantao14_4.Text = plantao;
                                        
                                    }
                                    if (String.IsNullOrEmpty(sipiap))
                                    {
                                        vLins13 = vLins13 + 22;
                                    }
                                    else if (!String.IsNullOrEmpty(sipiap))
                                    {
                                        lblSiPiaForm[lbs] = new Label();
                                        this.lblSiPiaForm[lbs].AutoSize = true;
                                        this.lblSiPiaForm[lbs].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblSiPiaForm[lbs].Location = new System.Drawing.Point(380, vLins13);
                                        this.lblSiPiaForm[lbs].Name = "lblSiPiaForm" + lbs;
                                        this.lblSiPiaForm[lbs].Size = new System.Drawing.Size(100, 15);
                                        this.lblSiPiaForm[lbs].TabIndex =36;
                                        this.lblSiPiaForm[lbs].Text = sipiap;

                                        this.lblSiPiaForm[lbs].Visible = true;
                                        this.panelQuaroB14.Controls.Add(this.lblSiPiaForm[lbs]);
                                        vLins13 = vLins13 + 22;
                                        lbs++;

                                    }
                                    else
                                    {

                                    }
                                    if (String.IsNullOrEmpty(descFlaMba))
                                    {
                                        vLin13 = vLin13 + 22;

                                    }
                                    else if (!String.IsNullOrEmpty(descFlaMba))
                                    {
                                        lblFlagrante_Mba[lb] = new Label();
                                        this.lblFlagrante_Mba[lb].AutoSize = true;
                                        this.lblFlagrante_Mba[lb].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                        this.lblFlagrante_Mba[lb].Location = new System.Drawing.Point(450, vLin13);
                                        this.lblFlagrante_Mba[lb].Name = "lblFlagrante_Mba" + lb;
                                        this.lblFlagrante_Mba[lb].ForeColor = System.Drawing.Color.Red;
                                        this.lblFlagrante_Mba[lb].Size = new System.Drawing.Size(100, 15);
                                        this.lblFlagrante_Mba[lb].TabIndex = 44;
                                        this.lblFlagrante_Mba[lb].Text = descFlaMba;

                                        this.lblFlagrante_Mba[lb].Visible = true;
                                        panelQuaroB14.Controls.Add(this.lblFlagrante_Mba[lb]);
                                        vLin13 = vLin13 + 22;
                                        lb++;

                                    }
                                    else
                                    {

                                    }
                                    break;
                            }
                            break;
                    }

                }
               
            }
            //LABEL LOTAL LADO A E B
            int totalA = (q1 - 1) + (q3 - 1) + (q5 - 1) + (q7 - 1) + (q9 - 1) + (q11 - 1) + (q13 - 1);
            int totalB = (q2 - 1) + (q4 - 1) + (q6 - 1) + (q8 - 1) + (q10 - 1) + (q12 - 1) + (q14 - 1);
            //LABEL TOTAL DE POR QUARTOS A
            labelTotalA_N_1.Text = (q1 - 1).ToString();
            labelTotalA_N_3.Text = (q3 - 1).ToString();
            labelTotalA_N_5.Text = (q5 - 1).ToString();
            labelTotalA_N_7.Text = (q7 - 1).ToString();
            labelTotalA_N_9.Text = (q9 - 1).ToString();
            labelTotalA_N_11.Text = (q11 - 1).ToString();
            labelTotalA_N_13.Text = (q12 - 1).ToString();

            //LABEL TOTAL DE POR QUARTOS B
            labelTotalB_N_2.Text = (q2 - 1).ToString();
            labelTotalB_N_4.Text = (q4 - 1).ToString();
            labelTotalB_N_6.Text = (q6 - 1).ToString();
            labelTotalB_N_8.Text = (q8 - 1).ToString();
            labelTotalB_N_10.Text = (q10 - 1).ToString();
            labelTotalB_N_12.Text = (q12 - 1).ToString();
            labelTotalB_N_14.Text = (q14 - 1).ToString();

            labelTotalN_A.Text = totalA.ToString();
            labelTotalN_B.Text = totalB.ToString();
            ComboBox_Load();
        }

        private void ComboBox_Load()
        {
            DataSet dtInternos = Conexao.SelectAdolescenteCombo_Efetivo();
            ComboBox_Clear();
            foreach (DataRow pRow in dtInternos.Tables[0].Rows)
            {
                string ala = pRow.Field<string>("ala_efetivo");
                int noQuart = 0;
                try { noQuart = pRow.Field<int>("no_quarto"); }
                catch { noQuart = 0; }
                string outrasEntr= pRow.Field<string>("outros_ent");


                int noQuartoo = 0;
                if (noQuart == 0)
                {
                    noQuartoo = 0;
                    if ((String.IsNullOrEmpty(ala) || noQuartoo == 0) && (String.IsNullOrEmpty(outrasEntr)))
                    {
                        string nome = pRow.Field<string>("nome_interno");
                        string id = pRow.Field<string>("id_interno");
                        //MessageBox.Show(id);
                        string plantaoI = pRow.Field<string>("id_plantao");
                        //comboBox lado A
                        comboBoxAQ_1.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxAQ_3.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxAQ_5.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxAQ_7.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxAQ_9.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxAQ_11.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxAQ_13.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        //comboBox lado B
                        comboBoxBQ_2.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxBQ_4.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxBQ_6.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxBQ_8.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxBQ_10.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxBQ_12.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                        comboBoxBQ_14.Items.Add(nome + "  ,  ID:" + id + "  ,  Plantão|" + plantaoI);
                    }
                }
                
               
               
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxAQ_1.Text;
           
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 1?";
                string ala = "A";
                int quarto = 1;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach(DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                     idPlantao = pRow.Field<string>("id_plantao"); ;
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxAQ_3.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 3?";
                string ala = "A";
                int quarto = 3;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxAQ_5.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 5?";
                string ala = "A";
                int quarto = 5;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxAQ_7.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 7?";
                string ala = "A";
                int quarto = 7;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxAQ_9.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 9?";
                string ala = "A";
                int quarto = 9;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxAQ_11.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 11?";
                string ala = "A";
                int quarto = 11;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxAQ_13.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 13?";
                string ala = "A";
                int quarto = 13;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }
        }
       
        private void ComboBox_Clear()
        {
            //comboBox lado A
            comboBoxAQ_1.Items.Clear();
            comboBoxAQ_3.Items.Clear();
            comboBoxAQ_5.Items.Clear();
            comboBoxAQ_7.Items.Clear();
            comboBoxAQ_9.Items.Clear();
            comboBoxAQ_11.Items.Clear();
            comboBoxAQ_13.Items.Clear();
            //comboBox lado B
            comboBoxBQ_2.Items.Clear();
            comboBoxBQ_4.Items.Clear();
            comboBoxBQ_6.Items.Clear();
            comboBoxBQ_8.Items.Clear();
            comboBoxBQ_10.Items.Clear();
            comboBoxBQ_12.Items.Clear();
            comboBoxBQ_14.Items.Clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxBQ_2.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 2?";
                string ala = "B";
                int quarto = 2;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxBQ_4.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 4?";
                string ala = "B";
                int quarto = 4;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxBQ_6.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 6?";
                string ala = "B";
                int quarto = 6;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxBQ_8.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 8?";
                string ala = "B";
                int quarto = 8;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string cbtext = comboBoxBQ_10.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 10?";
                string ala = "B";
                int quarto = 10;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }

        }

        private void btn12_Click(object sender, EventArgs e)
        {

            string cbtext = comboBoxBQ_12.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 12?";
                string ala = "B";
                int quarto = 12;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            string cbtext = comboBoxBQ_14.Text;
            if (!String.IsNullOrEmpty(cbtext))
            {
                string[] separa = cbtext.Split(',');
                string nome = separa[0];
                string idInt = separa[1];
                string[] idIntS = idInt.Split(':');
                string idInterno = idIntS[1];
                string plaInt = separa[2];
                string[] plantaoInt = plaInt.Split('|');
                string plantao = plantaoInt[1];
                string titulo = "Inserir adolescente";
                string msg = "Deseja inserir o(a) adolescente no Quarto 14?";
                string ala = "B";
                int quarto = 14;
                string alaTest = "";
                string idPlantao = "";
                DataSet dt = Conexao.SelecionaAdolescente_ID(idInterno, plantao);
                foreach (DataRow pRow in dt.Tables[0].Rows)
                {
                    alaTest = pRow.Field<string>("ala_efetivo");
                    idPlantao = pRow.Field<string>("id_plantao");
                }
                if (String.IsNullOrEmpty(alaTest))
                {
                    DialogResult resul = new DialogResult();
                    resul = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resul == DialogResult.Yes)
                    {
                        Conexao.InsertAdolescenteEfetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Conexao.updateAdolescente_Efetivo(idInterno, plantao, ala, quarto, labelIdusu.Text, idPlantao);
                        comboBoxAQ_1.Text = "";
                        Form_Clear();
                        Form_Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o adolescente!");
            }

        }
        public void Form_Clear()
        {
           
            ComboBox_Clear();

        }

        private void labelAdo_LA_Q1_1_DoubleClick(object sender, EventArgs e)
        {
            Auxiliar aux = new Auxiliar();
            Label lbl = sender as Label;
            string ala = "";
            string quarto = "";
            string labelAdole = "";
            string plantao = "";
            string[] dadosQuarto = aux.Get_DadosQuarto(lbl.Name);
            string lbidAdole = "";
            string lbPlantao = "";
            ala = dadosQuarto[0];
            quarto = dadosQuarto[1];
            labelAdole = dadosQuarto[2];
            int quartoA = Int32.Parse(dadosQuarto[3]);
            string [] dadosLabel = aux.Get_labelID_labelPlantao(ala, quarto, labelAdole);
            lbidAdole = dadosLabel[0];
            lbPlantao = dadosLabel[1];
            string nomeAdolescente = lbl.Text;
            string idAdolescente = "";
            string plantaoAdolescente = "";
            string plantaoSys = "";
            DataSet dt = Conexao.SelectAdolescenteEfetivo_QuartoNome(nomeAdolescente, quartoA);
            foreach(DataRow pRow in dt.Tables[0].Rows)
            {
                idAdolescente = pRow.Field<string>("id_interno");
                plantaoAdolescente = pRow.Field<string>("id_plantao");
                plantaoSys = pRow.Field<string>("SERVER_DT");
            }  
            FrmFoto_excluir frmFoto_ex = new FrmFoto_excluir(idAdolescente, plantaoAdolescente, plantaoSys, quarto, ala, labelIdusu.Text, this);
            frmFoto_ex.Show();
        }

      

        private void protocoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new  Form1(labelIdusu.Text, lblNomeUsu.Text);
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void carômetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarometro frm = new FrmCarometro();
            frm.Show();
        }
    }
}

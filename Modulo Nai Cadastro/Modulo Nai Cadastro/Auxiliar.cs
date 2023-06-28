using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Nai_Cadastro
{
    class Auxiliar
    {
        public string plantaoInt;
        public string idInterno;
        public string nomeInterno;

        public void SetNomeInt(string nome)
        {
            nomeInterno = nome;
        }
        public string GetNomeInt()
        {
            string nome = nomeInterno;
            return nome;
        }

        public void SetIdInt(string id)
        {
            idInterno = id;
        }
        public string GetIdInt()
        {
            string id = idInterno;
            return id;
        }

        public void SetPlantaoInt(string plantao)
        {
            plantaoInt = plantao;
        }
        public string GetPlantaoInt()
        {
            string plantao = plantaoInt;
            return plantao;
        }


        public string GetOrigem(int origem)
        {
            int origemEnt= origem;
            string sOrigem;
            switch (origemEnt)
            {
                case 1:
                    sOrigem = "DCA I";
                    break;
                case 2:
                    sOrigem = "DCA II";
                    break;
                case 3:
                    sOrigem = "VIJ";
                    break;
                case 4:
                    sOrigem = "VEMSE";
                    break;
                case 5:
                    sOrigem = "VARA REGIONAL";
                    break;
                case 6:
                    sOrigem = "OUTROS";
                    break;
                default:
                    sOrigem = "";

                    break;
            }
            return sOrigem;

        }

        public string GetDestino(int destino)
        {
            int destinoEnt = destino;
            string sDestino;
            switch (destinoEnt)
            {
                case 1:
                    sDestino = "LIBERADO OITIVA";
                    break;
                case 2:
                    sDestino = "LIBERADO UAI";
                    break;
                case 3:
                    sDestino = "LIBERADO MBA";
                    break;
                case 4:
                    sDestino = "UNAC";
                    break;
                case 5:
                    sDestino = "UIPSS";
                    break;
                case 6:
                    sDestino = "UISM";
                    break;
                case 7:
                    sDestino = "UIP";
                    break;
                case 8:
                    sDestino = "UISS";
                    break;
                case 9:
                    sDestino = "UIBRA";
                    break;

                case 10:
                    sDestino = "UNIRE";
                    break;
                case 11:
                    sDestino = "UNISS";
                    break;
                case 12:
                    sDestino = "UASG";
                    break;
                case 13:
                    sDestino = "UASGU";
                    break;

                case 14:
                    sDestino = "UAST";
                    break;
                case 15:
                    sDestino = "UASRE";
                    break;
                case 16:
                    sDestino = "UASSM";
                    break;
                case 17:
                    sDestino = "OUTRA COMARCA";
                    break;
                case 18:
                    sDestino = "EVADIDO";
                    break;

                case 19:
                    sDestino = "LIBERADO DCA";
                    break;
                case 20:
                    sDestino = "AGUARDANDO INT.PROVISÓRIA";
                    break;
                case 21:
                    sDestino = "REENCAMINHADO À DCA";
                    break;

                default:
                    sDestino = "";

                    break;

            }
            return sDestino;

        }

        public string GetDecisao(int decisao)
        {
            int decisaoInt = decisao;
            string sDecisao;
            switch (decisaoInt)
            {
                case 1:
                    sDecisao = "LIBERADO";
                    break;
                case 2:
                    sDecisao = "LA";
                    break;
                case 3:
                    sDecisao = "PSC";
                    break;
                case 4:
                    sDecisao = "LA+PSC";
                    break;
                case 5:
                    sDecisao = "INTERNAÇÃO PROVISÓRIA";
                    break;
                case 6:
                    sDecisao = "INTERNAÇÃO ESTRITA";
                    break;

                case 8:
                    sDecisao = "INTERNAÇÃO SANÇÃO";
                    break;
                case 9:
                    sDecisao = "SEMI";
                    break;
                case 10:
                    sDecisao = "RECAMBIAMENTO";
                    break;

                case 11:
                    sDecisao = "AGUARDANDO INT.PROVISÓRIA";
                    break;
              
                case 13:
                    sDecisao = "FALSIDADE IDEOLÓGICA - MAIOR DE IDADE";
                    break;

                default:
                    sDecisao = "";

                    break;

            }
            return sDecisao;

        }
        public int GetMotivo_Ent(string motivo)
        {
            int motEnt;
            switch (motivo)
            {
                case "FLAGRANTE":
                    motEnt = 1;
                    break;
                case "MBA":
                    motEnt = 2;
                    break;
                case "FLAGRANTE+MBA":
                    motEnt = 3;
                        break;
                default:
                    motEnt = 0;
                    break;


            }
            return motEnt;
        }
        public string SetMotivo_Ent(int motivo)
        {
            string motEnt;
            switch (motivo)
            {
                case 1:
                    motEnt = "FLAGRANTE";
                    break;
                case 2:
                    motEnt = "MBA";
                    break;
                case 3:
                    motEnt = "FLAGRANTE+MBA";
                    break;
                default:
                    motEnt = "";
                    break;


            }
            return motEnt;
        }
        public int SetDecisao(string decisao)
        {
            string decisaoInt = decisao;
            int decisaoI = 0;
            switch (decisaoInt)
            {
                case "LIBERADO":
                    decisaoI = 1;
                    break;
                case "LA":
                    decisaoI = 2;
                    break;
                case "PSC":
                    decisaoI = 3;
                    break;
                case "LA+PSC":
                    decisaoI = 4;
                    break;
                case "INTERNAÇÃO PROVISÓRIA":
                    decisaoI = 5;
                    break;
                case "INTERNAÇÃO ESTRITA":
                    decisaoI = 6;
                    break;

                case "INTERNAÇÃO SANÇÃO":
                    decisaoI = 8;
                    break;
                case "SEMI":
                    decisaoI = 9;
                    break;
                case "RECAMBIAMENTO":
                    decisaoI = 10;
                    break;

                case "AGUARDANDO INT.PROVISÓRIA":
                    decisaoI = 11;
                    break;
                
                case "FALSIDADE IDEOLÓGICA - MAIOR DE IDADE":
                    decisaoI = 13;
                    break;

                default:
                    decisaoI = 0;

                    break;
            }
            return decisaoI;
        }
        public int SetDestino(string destinoI)
        {
            int destino = 0;
            switch (destinoI)
            {
                case "LIBERADO OITIVA":
                    destino = 1;
                    break;
                case "LIBERADO UAI":
                    destino = 2;
                    break;
                case "LIBERADO MBA":
                    destino = 3;
                    break;
                case "UNAC":
                    destino = 4;
                    break;
                case "UIPSS":
                    destino = 5;
                    break;
                case "UISM":
                    destino = 6;
                    break;

                case "UIP":
                    destino = 7;
                    break;
                case "UISS":
                    destino = 8;
                    break;
                case "UIBRA":
                    destino = 9;
                    break;

                case "UNIRE":
                    destino = 10;
                    break;
                case "UNISS":
                    destino = 11;
                    break;
                case "UASG":
                    destino = 12;
                    break;
                case "UASGU":
                    destino = 13;
                    break;

                case "UAST":
                    destino = 14;
                    break;
                case "UASRE":
                    destino = 15;
                    break;
                case "UASSM":
                    destino = 16;
                    break;
                case "OUTRA COMARCA":
                    destino = 17;
                    break;
                case "EVADIDO":
                    destino = 18;
                    break;

                case "LIBERADO DCA":
                    destino = 19;
                    break;
                case "AGUARDANDO INT.PROVISÓRIA":
                    destino = 20;
                    break;
                case "REENCAMINHADO À DCA":
                    destino = 21;
                    break;

                default:
                    destino = 0;

                    break;
            }
            return destino;
        }
        public int SetOrigem_ent( string origemEnt)
        {
            int origem = 0;
            switch (origemEnt)
            {
                case "DCA I":
                    origem = 1;
                    break;
                case "DCA II":
                    origem = 2;
                    break;
                case "VIJ":
                    origem = 3;
                    break;
                case "VEMSE":
                    origem = 4;
                    break;
                case "VARA REGIONAL":
                    origem = 5;
                    break;
                case "OUTROS":
                    origem = 6;
                    break;
                default:
                    origem = 0;

                    break;
            }
            return origem;


        }

        public string[] Get_DadosQuarto(string dados)
        {
            string total = dados;
            int i;
            string ala = "";
            string quarto = "";
            int q = 0;
            string lblAdole = "";
            string[] partes = total.Split('_');
           
            if (partes[1] == "LA")
            {
                ala = "A";
            }
            else
            {
                ala = "B";
            }

            for (i = 0; i < 15; i++)
            {
              

                if (partes[2] == "Q" + i)
                {
                    quarto = "Quarto "+i ;
                    q = i;
                }
               
            }
            for(i=0; i < 5; i++)
            {
                if (partes[3] == i.ToString())
                {
                    lblAdole = i.ToString();
                }
            }


            string[] dadosQuarto = new string[4];
            dadosQuarto[0] = ala;
            dadosQuarto[1] = quarto;
            dadosQuarto[2] = lblAdole;
            dadosQuarto[3] = q.ToString();

            return dadosQuarto;

        }

        public string [] Get_labelID_labelPlantao(string alaA, string quartoA, string lblAdoleA)
        {
            string ala = alaA;
            string quarto = quartoA;
            string lblAdole = lblAdoleA;
            string labelId = "";
            string labelPlantao = "";
            string[] result = new string[2];
           
            if (ala == "A")
            {
                labelId = "idA_";
            }
            for (int i=1; i <15; i++)
            {
                if(quarto == ("Quarto "+ i.ToString()))
                {

                    string qu = "Q" + i;
                    labelId = labelId + qu;
                    labelPlantao = " lblplantao" + i;
                }
            }
            for(int y=1; y < 5; y++)
            {
                if (lblAdole == y.ToString())
                {
                    string lb = "_" + y;
                    labelId = labelId + lb;
                    string lp = "_" + y;
                    labelPlantao = labelPlantao + lp;
                }
            }
            result[0] = labelId;
            result[1] = labelPlantao;
            return result;
        }
        public string SetOrgao_decisorio(int orgao)
        {
            string orgDec;
            switch (orgao)
            {
                case 1:
                    orgDec = "NAIJUD";
                    break;
                case 2:
                    orgDec = "NUPLA";
                    break;
                case 3:
                    orgDec = "VARA REGIONAL";
                    break;
                case 4:
                    orgDec = "VEMSE";
                    break;
                case 5:
                    orgDec = "VIJ";
                    break;
                case 6:
                    orgDec = "LIBERADO VIA DCA";
                    break;
                default:
                    orgDec = "";
                    break;


            }
            return orgDec;
        }
        public int GetOrgao_decisorio(string orgao)
        {
            int orgDec;
            switch (orgao)
            {
                case "NAIJUD":
                    orgDec = 1;
                    break;
                case "NUPLA":
                    orgDec = 2;
                    break;
                case "VARA REGIONAL":
                    orgDec = 3;
                    break;
                case "VEMSE":
                    orgDec = 4 ;
                    break;
                case "VIJ":
                    orgDec = 5;
                    break;
                case "LIBERADO VIA DCA":
                    orgDec = 6 ;
                    break;
                default:
                    orgDec = 0;
                    break;


            }
            return orgDec;
        }
        public int Get_IdDoc(string entrada)
        {
            int idDoc;
            switch (entrada)
            {
                case "FLAGRANTE":
                    idDoc = 1;
                    break;
                case "MBA":
                    idDoc = 2;
                    break;
                default:
                    idDoc = 0;
                    break;


            }
            return idDoc;
        }
        public int Get_Apresent(string apresent)
        {
            int idAp;
            switch (apresent)
            {
                case "SIM":
                    idAp = 1;
                    break;
                case "NÃO":
                    idAp = 0;
                    break;
                default:
                    idAp = 0;
                    break;


            }
            return idAp;
        }

        public string Get_Apresent(int apresent)
        {
            string idAp;
            switch (apresent)
            {
                case 1:
                    idAp = "SIM";
                    break;
                case 0:
                    idAp = "NÃO";
                    break;
                default:
                    idAp ="";
                    break;


            }
            return idAp;
        }



    }
}

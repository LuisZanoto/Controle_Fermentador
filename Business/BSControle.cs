using DataAccess;
using System;
using System.Data;


namespace Business
{
    public class BSControle
    {
        //-----------------------------------------------
        //                  ATRIBUTOS
        //-----------------------------------------------
        private int cod;
        private string receita;       
        private string usuario;
        private string status;
        private int etapas;
        private int cod_etapa;
        private int n_etapa;
        private string estado;
        private int ref_temp;
        private int horas;
        private int temp_lida;
        private string alarme;
        private int contador;

        //-----------------------------------------------
        //                PROPRIEDADES 
        //-----------------------------------------------
        public int Cod { get => cod; set => cod = value; }
        public string Receita { get => receita; set => receita = value; }
       
        public string Usuario { get => usuario; set => usuario = value; }
        public string Status { get => status; set => status = value; }

        public int Etapas { get => etapas; set => etapas = value; }

        public int Cod_etapa { get => cod_etapa; set => cod_etapa = value; }

        public int N_etapa { get => n_etapa; set => n_etapa = value; }
        public string Estado { get => estado; set => estado = value; }

        public int Ref_temp { get => ref_temp; set => ref_temp = value; }

        public int Horas { get => horas; set => horas = value; }
        public int Temp_lida { get => temp_lida; set => temp_lida = value; }

        public string Alarme { get => alarme; set => alarme = value; }

        public int Contador { get => contador; set => contador = value; }

        //-----------------------------------------------
        //                   MÉTODOS 
        //----------------------------------------------- 

        public void inserir()
        {
            try
            {
                
                DAFerm o_ins = new DAFerm();

                o_ins.Receita = receita;
               
                o_ins.Usuario = usuario;
                o_ins.Status = status;
                o_ins.Etapas = etapas;

                Console.WriteLine("\n Passou variaveis");
                o_ins.inserir();
                Console.WriteLine("\n Inseriu");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nBSControle.inserir");
            }
        }


        public void inserirEtapas(string tb_nome)
        {
            try
            {

                DAFerm o_insE = new DAFerm();

                o_insE.Cod_etapa = cod_etapa;
                o_insE.N_etapa = n_etapa;
                o_insE.Estado = estado;
                o_insE.Ref_temp = ref_temp;
                o_insE.Horas = horas;
                o_insE.Temp_lida = temp_lida;
                o_insE.Alarme = alarme;
                o_insE.Contador = contador;
               
                o_insE.inserirEtapas(tb_nome);
               

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nBSControle.inserir_Etapas");
            }
        }

        public void alteraEtapas(string tb_nome)
        {
            try
            {

                DAFerm o_alt = new DAFerm();

                o_alt.Cod_etapa = cod_etapa;
                o_alt.N_etapa = n_etapa;
                o_alt.Estado = estado;
                o_alt.Ref_temp = ref_temp;
                o_alt.Horas = horas;
                o_alt.Temp_lida = temp_lida;
                o_alt.Alarme = alarme;
                o_alt.Contador = contador;

                o_alt.atualizar(tb_nome);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nBSControle.Altera_Etapas");
            }
        }

        public void CriarTBEtapa(string tb_nome)
        {          

            try
            {
                DAFerm a_et = new DAFerm();
                a_et.CriarTBEtapa(tb_nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nBSControle.CriarTBEtapa");
            }


        }

        public DataTable Verifica(string tb_nome)
        {

            try
            {
                DAFerm a_v = new DAFerm();                
                DataTable o_L;
                o_L = a_v.Verifica(tb_nome);
                return o_L;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nBSControle.CriarTBEtapa");
            }


        }



        public DataTable Listar()
        {
            try
            {
                DAFerm o_DAF = new DAFerm();
                DataTable o_L;
                o_L = o_DAF.Listar();
                return o_L;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nBSControle.Listar");
            }
        }

        public DataTable ListarTuplas(string tb_nome)
        {
            try
            {
                DAFerm o_DAF = new DAFerm();
                DataTable o_L;
                o_L = o_DAF.ListarTuplas(tb_nome);
                return o_L;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nBSControle.ListarTuplas");
            }
        }


    }
}

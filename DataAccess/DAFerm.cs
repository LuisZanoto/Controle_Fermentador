using Npgsql;
using System;
using System.Data;

namespace DataAccess
{
    public class DAFerm
    {
        //-----------------------------------------------
        //                  ATRIBUTOS
        //-----------------------------------------------(n_etapa, estado, ref_temp, horas, temp_lida, alarme, contador ) " +
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


        String strConexao = "Server=htecksolar.duckdns.org;User Id=luis; Port=5432; " +
                             "Password=Canela14; Database=Fermdb";



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

                // Prepara conexão com o Banco de dados
                NpgsqlConnection conBanco;

                conBanco = new NpgsqlConnection(strConexao);

                // Prepara comando INSERT
                String strComando;

                strComando = "INSERT INTO tb_receitas(receita,  usuario, status, etapas) " +
                             "VALUES(@receita, @usuario, @status, @etapas)";

                NpgsqlCommand cmdSQL;
                cmdSQL = new NpgsqlCommand(strComando, conBanco);

                // Criação de parametros
                NpgsqlParameter o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@receita";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                o_Parametro.Size = 100;
                o_Parametro.Value = receita;
                cmdSQL.Parameters.Add(o_Parametro);               

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@usuario";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                o_Parametro.Size = 50;
                o_Parametro.Value = usuario;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@status";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                o_Parametro.Size = 30;
                o_Parametro.Value = status;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@etapas";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = etapas;
                cmdSQL.Parameters.Add(o_Parametro);

               
                // Abre a conexão e executa Insert
                conBanco.Open();

                //Prepara
                cmdSQL.Prepare();
                cmdSQL.ExecuteNonQuery();

                conBanco.Close();

            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nDAFerm.inserir");
            }

        }

        //---------------------------------------------------------------
        //
        //---------------------------------------------------------------        
        public void atualizar(string tb_nome)
        {
            try
            {
                NpgsqlConnection conBanco;
                conBanco = new NpgsqlConnection(strConexao);

                //-------------------------------------------------
                // Preparando o comando UPDATE
                //-------------------------------------------------
                String strComando;

                strComando = "UPDATE " + tb_nome + " SET n_etapa = @n_etapa, estado = @estado, ref_temp = @ref_temp, " +
                             "horas = @horas, temp_lida = @temp_lida, alarme = @alarme, contador = @contador " +
                             "WHERE cod = @cod_etapa";

                NpgsqlCommand cmdSQL;
                cmdSQL = new NpgsqlCommand(strComando, conBanco);
 
                //-------------------------------------------------
                // Criação de parametros
                NpgsqlParameter o_Parametro = new NpgsqlParameter();

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@cod_etapa";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = cod_etapa;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@n_etapa";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = n_etapa;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@estado";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                o_Parametro.Size = 40;
                o_Parametro.Value = estado;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@ref_temp";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = ref_temp;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@horas";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = horas;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@temp_lida";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = temp_lida;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@alarme";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                o_Parametro.Size = 40;
                o_Parametro.Value = alarme;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@contador";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = contador;
                cmdSQL.Parameters.Add(o_Parametro);

                Console.WriteLine("\nComando = " + strComando);
                //-------------------------------------------------
                // Abre a conexão com o banco e executa o Update
                //-------------------------------------------------
                conBanco.Open();

                // Prepare() é obrigatório ser chamada para configurar
                // internamente o comando SQL e os parametros informados.                
                cmdSQL.Prepare();
                cmdSQL.ExecuteNonQuery();
                conBanco.Close();

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nDAFerm.atualizar");
            }
        }

        public void inserirEtapas(string tb_nome)
        {
            try
            {

                // Prepara conexão com o Banco de dados
                NpgsqlConnection conBanco;

                conBanco = new NpgsqlConnection(strConexao);

                // Prepara comando INSERT
                String strComando;

                strComando = "INSERT INTO " + tb_nome + "(n_etapa, estado, ref_temp, horas, temp_lida, alarme, contador ) " +
                             "VALUES(@n_etapa, @estado, @ref_temp, @horas, @temp_lida, @alarme, @contador)";

                NpgsqlCommand cmdSQL;
                cmdSQL = new NpgsqlCommand(strComando, conBanco);

                // Criação de parametros
                NpgsqlParameter o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@n_etapa";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;                
                o_Parametro.Value = n_etapa;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@estado";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                o_Parametro.Size = 40;
                o_Parametro.Value = estado;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@ref_temp";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = ref_temp;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@horas";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = horas;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@temp_lida";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = temp_lida;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@alarme";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                o_Parametro.Size = 40;
                o_Parametro.Value = alarme;
                cmdSQL.Parameters.Add(o_Parametro);

                o_Parametro = new NpgsqlParameter();
                o_Parametro.ParameterName = "@contador";
                o_Parametro.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                o_Parametro.Value = contador;
                cmdSQL.Parameters.Add(o_Parametro);


               
                // Abre a conexão e executa Insert
                conBanco.Open();

                //Prepara
                cmdSQL.Prepare();
                cmdSQL.ExecuteNonQuery();

                conBanco.Close();

            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nDAFerm.inserir");
            }

        }


        public DataTable Listar()
        {
            try
            {

                // Prepara conexão com o Banco de dados
                NpgsqlConnection conBanco;                

                conBanco = new NpgsqlConnection(strConexao);

                // Preparar o comando Select
                String strComando;
                strComando = "Select * From tb_receitas ";
                NpgsqlDataAdapter daPesquisa;
                daPesquisa = new NpgsqlDataAdapter(strComando, conBanco);

                // Abre conexao
                conBanco.Open();

                DataTable dtrec = new DataTable();
                daPesquisa.Fill(dtrec);
                conBanco.Close();

                return dtrec;
            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nDAFerm.Listar");
            }


        }

        public DataTable ListarTuplas(string tb_nome)
        {
            try
            {

                // Prepara conexão com o Banco de dados
                NpgsqlConnection conBanco;

                conBanco = new NpgsqlConnection(strConexao);

                // Preparar o comando Select
                String strComando;
                strComando = "Select * From " + tb_nome + " order by cod ";
                NpgsqlDataAdapter daPesquisa;
                daPesquisa = new NpgsqlDataAdapter(strComando, conBanco);

                // Abre conexao
                conBanco.Open();

                DataTable dtrec = new DataTable();
                daPesquisa.Fill(dtrec);
                conBanco.Close();

                return dtrec;
            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nDAFerm.Listar");
            }


        }

        public DataTable Verifica(string tb_nome)
        {
            try
            {
                // Prepara conexão com o Banco de dados
                NpgsqlConnection conBanco;

                conBanco = new NpgsqlConnection(strConexao);

                // Preparar o comando Select
                String strComando = "SELECT EXISTS ( " +
                                        "SELECT FROM information_schema.tables " +
                                        "WHERE table_name = '" + tb_nome + "' )";                                    
                
                NpgsqlDataAdapter daPesquisa;
                daPesquisa = new NpgsqlDataAdapter(strComando, conBanco);

                // Abre conexao
                conBanco.Open();

                DataTable dtrec = new DataTable();
                daPesquisa.Fill(dtrec);
                conBanco.Close();

                return dtrec;
            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nDAFerm.Listar");
            }


        }

        public void CriarTBEtapa(string tb_nome)
        {
            try
            {               
                // Prepara conexão com o Banco de dados
                NpgsqlConnection conBanco;

                conBanco = new NpgsqlConnection(strConexao);

                // Preparar o comando Select
               
                String strComando = "Create table " + tb_nome + " ( " +
                    "cod serial NOT NULL, " +
                    "n_etapa integer NOT NULL, " +
                    "estado character varying(40) NOT NULL, " +
                    "ref_temp integer NOT NULL, " +
                    "horas integer NOT NULL, " +
                    "temp_lida integer, " +
                    "alarme character varying(40), " +
                    "contador integer, " +
                    "PRIMARY KEY (cod) " +
                ")";

                //Console.WriteLine("\n Comando : {0}", strComando);
                NpgsqlCommand cmdSQL;
                cmdSQL = new NpgsqlCommand(strComando, conBanco);

                //-------------------------------------------------
                // Abre a conexão com o banco e executa o Update
                //-------------------------------------------------
                conBanco.Open();

                // Prepare() é obrigatório ser chamada para configurar
                // internamente o comando SQL e os parametros informados.                
                //cmdSQL.Prepare();
                cmdSQL.ExecuteNonQuery();
                conBanco.Close();

            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nDAFerm.Listar");
            }


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DCriptomoeda
    {
        private int _Idcriptomoeda;
        private string _Descricao;
        private string _Valor;
        private string _TextoBuscar2;

        public int Idcriptomoeda
        {
            get
            {
                return _Idcriptomoeda;
            }

            set
            {
                _Idcriptomoeda = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _Descricao;
            }

            set
            {
                _Descricao = value;
            }
        }

        public string Valor
        {
            get
            {
                return _Valor;
            }

            set
            {
                _Valor = value;
            }
        }
       

        public string TextoBuscar2
        {
            get
            {
                return _TextoBuscar2;
            }

            set
            {
                _TextoBuscar2 = value;
            }
        }

        //Construtor Vazio

        public DCriptomoeda()
        {

        }


        //Construtor com Parametros
        public DCriptomoeda(int idcriptomoeda, string descricao, string valor, string textobuscar2)
        {
            this.Idcriptomoeda = idcriptomoeda;
            this.Descricao = descricao;
            this.Valor = valor;


            this.TextoBuscar2 = textobuscar2;

        }


        //Método Inserir
        public string Inserir2(DCriptomoeda Criptomoedas)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();


                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "cpinserir_criptomoedas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcriptomoeda = new SqlParameter();
                ParIdcriptomoeda.ParameterName = "@idcriptomoeda";
                ParIdcriptomoeda.SqlDbType = SqlDbType.Int;
                ParIdcriptomoeda.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcriptomoeda);



                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 50;
                ParDescricao.Value = Criptomoedas.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);


                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 30;
                ParValor.Value = Criptomoedas.Valor;
                SqlCmd.Parameters.Add(ParValor);


               
                

                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Registro não foi Inserido";



            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;

        }


        //Método Editar
        public string Editar2(DCriptomoeda Criptomoedas)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "cpeditar_criptomoedas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcriptomoeda = new SqlParameter();
                ParIdcriptomoeda.ParameterName = "@idcriptomoeda";
                ParIdcriptomoeda.SqlDbType = SqlDbType.Int;
                ParIdcriptomoeda.Value = Criptomoedas.Idcriptomoeda;
                SqlCmd.Parameters.Add(ParIdcriptomoeda);


                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 50;
                ParDescricao.Value = Criptomoedas.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 30;
                ParValor.Value = Criptomoedas.Valor;
                SqlCmd.Parameters.Add(ParValor);




                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A edição não foi feita";


            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;

        }


        //Método Excluir
        public string Excluir2(DCriptomoeda Criptomoedas)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "cpdeletar_criptomoedas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcriptomoeda = new SqlParameter();
                ParIdcriptomoeda.ParameterName = "@idcriptomoeda";
                ParIdcriptomoeda.SqlDbType = SqlDbType.Int;
                ParIdcriptomoeda.Value = Criptomoedas.Idcriptomoeda;
                SqlCmd.Parameters.Add(ParIdcriptomoeda);



                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão não foi feita";


            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Método Mostrar
        public DataTable Mostrar2()
        {
            DataTable DtResultado = new DataTable("criptomoeda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "cpmostrar_criptomoedas";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método Buscar Nome
        public DataTable BuscarNome2(DCriptomoeda Criptomoedas)
        {
            DataTable DtResultado = new DataTable("criptomoeda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "cpbuscar_criptomoedas";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = Criptomoedas.TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

    }

}

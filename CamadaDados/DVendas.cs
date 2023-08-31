using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DVendas
    {
            private int _Idvenda;
            private int _Idcliente;
            private string _Moedas;
            private int _Quantidade;
            private string _Reais;
            private string _TextoBuscar3;

        public int Idvenda
        {
            get
            {
                return _Idvenda;
            }

            set
            {
                _Idvenda = value;
            }
        }

        public int Idcliente
            {
                get
                {
                    return _Idcliente;
                }

                set
                {
                    _Idcliente = value;
                }
            }

            public string Moedas
            {
                get
                {
                    return _Moedas;
                }

                set
                {
                    _Moedas = value;
                }
            }

            public int Quantidade
            {
                get
                {
                    return _Quantidade;
                }

                set
                {
                    _Quantidade = value;
                }
            }
            public string Reais
            {
                get
                {
                    return _Reais;
                }

                set
                {
                    _Reais = value;
                }

            }
        public string TextoBuscar3
        {
            get
            {
                return _TextoBuscar3;
            }

            set
            {
                _TextoBuscar3 = value;
            }

        }
        public DVendas()
        {

        }

        public DVendas(int idvenda,int idcliente, string moedas, int quantidade, string reais)
        {
            this.Idvenda = idvenda;
            this.Idcliente = idcliente;
            this.Moedas = moedas;
            this.Quantidade = quantidade;
            this.Reais = reais;
            

        }

        public string Inserir3(DVendas Venda)
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
                SqlCmd.CommandText = "vendinserir_vendas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdvenda = new SqlParameter();
                ParIdvenda.ParameterName = "@idvenda";
                ParIdvenda.SqlDbType = SqlDbType.Int;
                ParIdvenda.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdvenda);

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Venda.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);



                SqlParameter ParMoedas = new SqlParameter();
                ParMoedas.ParameterName = "@moedas";
                ParMoedas.SqlDbType = SqlDbType.VarChar;
                ParMoedas.Size = 50;
                ParMoedas.Value = Venda.Moedas;
                SqlCmd.Parameters.Add(ParMoedas);

                SqlParameter ParQuantidade = new SqlParameter();
                ParQuantidade.ParameterName = "@quantidade";
                ParQuantidade.SqlDbType = SqlDbType.Int;
                ParQuantidade.Value = Venda.Quantidade;
                SqlCmd.Parameters.Add(ParQuantidade);

                SqlParameter ParReais = new SqlParameter();
                ParReais.ParameterName = "@reais";
                ParReais.SqlDbType = SqlDbType.VarChar;
                ParReais.Size = 50;
                ParReais.Value = Venda.Reais;
                SqlCmd.Parameters.Add(ParReais);




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
        public string Editar3(DVendas Venda)
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
                SqlCmd.CommandText = "vendeditar_vendas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdvenda = new SqlParameter();
                ParIdvenda.ParameterName = "@idvenda";
                ParIdvenda.SqlDbType = SqlDbType.Int;
                ParIdvenda.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdvenda);

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Venda.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);



                SqlParameter ParMoedas = new SqlParameter();
                ParMoedas.ParameterName = "@moedas";
                ParMoedas.SqlDbType = SqlDbType.VarChar;
                ParMoedas.Size = 50;
                ParMoedas.Value = Venda.Moedas;
                SqlCmd.Parameters.Add(ParMoedas);

                SqlParameter ParQuantidade = new SqlParameter();
                ParQuantidade.ParameterName = "@quantidade";
                ParQuantidade.SqlDbType = SqlDbType.Int;
                ParQuantidade.Value = Venda.Quantidade;
                SqlCmd.Parameters.Add(ParQuantidade);

                SqlParameter ParReais = new SqlParameter();
                ParReais.ParameterName = "@reais";
                ParReais.SqlDbType = SqlDbType.VarChar;
                ParReais.Size = 50;
                ParReais.Value = Venda.Reais;
                SqlCmd.Parameters.Add(ParReais);



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


        //Método Mostrar
        public DataTable Mostrar3()
        {
            DataTable DtResultado = new DataTable("vendas1");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "vendmostrar_vendas";
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

        public DataTable BuscarNome3(DVendas Venda)
        {
            DataTable DtResultado = new DataTable("vendas1");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "vendbuscar_vendas";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTextoBuscar3 = new SqlParameter();
                ParTextoBuscar3.ParameterName = "@textobuscar3";
                ParTextoBuscar3.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar3.Size = 50;
                ParTextoBuscar3.Value = Venda.TextoBuscar3;
                SqlCmd.Parameters.Add(ParTextoBuscar3);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public string Excluir3(DVendas Venda)
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
                SqlCmd.CommandText = "venddeletar_vendas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdvenda = new SqlParameter();
                ParIdvenda.ParameterName = "@idvenda";
                ParIdvenda.SqlDbType = SqlDbType.Int;
                ParIdvenda.Value = Venda.Idvenda;
                SqlCmd.Parameters.Add(ParIdvenda);



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


    }

}

    
    



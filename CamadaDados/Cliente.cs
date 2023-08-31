using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class Cliente
    {
        private int _Idcliente;
        private string _Nome;
        private string _Razao_Social;
        private string _CPF;
        private string _CNPJ;
        private string _Endereco;
        private string _Cidade;
        private string _UF;
        private string _Telefone;
        private string _TextoBuscar;

        public int Idcliente
        {
            get
            {
                return _Idcliente;
            }

            set
            {
                _Idcliente= value;
            }
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public string Razao_Social
        {
            get
            {
                return _Razao_Social;
            }

            set
            {
                _Razao_Social = value;
            }
        }
        public string CPF
        {
            get
            {
                return _CPF;
            }

            set
            {
                _CPF = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return _CNPJ;
            }

            set
            {
                _CNPJ = value;
            }
        }
        public string Endereco
        {
            get
            {
                return _Endereco;
            }

            set
            {
                _Endereco = value;
            }
        }
        public string Cidade
        {
            get
            {
                return _Cidade;
            }

            set
            {
                _Cidade = value;
            }
        }

        public string UF
        {
            get
            {
                return _UF;
            }

            set
            {
                _UF = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }

            set
            {
                _Telefone = value;
            }
        }

       
        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }

        //Construtor Vazio

        public Cliente()
        {

        }


        //Construtor com Parametros
        public Cliente(int idcliente, string nome, string razao_social, string cpf, string cnpj, string endereco, string cidade, string uf, string telefone, string textobuscar)
        {
            this.Idcliente = idcliente;
            this.Nome = nome;
            this.Razao_Social = razao_social;
            this.CPF = cpf;
            this.CNPJ = cnpj;
            this.Endereco = endereco;
            this.Cidade = cidade;
            this.UF = uf;
            this.Telefone = telefone;

            this.TextoBuscar = textobuscar;

        }


        //Método Inserir
        public string Inserir(Cliente Clientes)
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
                SqlCmd.CommandText = "spinserir_clientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType=SqlDbType.Int;
                ParIdcliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcliente);



                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Clientes.Nome;
                SqlCmd.Parameters.Add(ParNome);


                SqlParameter ParRazao_Social = new SqlParameter();
                ParRazao_Social.ParameterName = "@razao_social";
                ParRazao_Social.SqlDbType = SqlDbType.VarChar;
                ParRazao_Social.Size = 50;
                ParRazao_Social.Value = Clientes.Razao_Social;
                SqlCmd.Parameters.Add(ParRazao_Social);


                SqlParameter ParCPF = new SqlParameter();
                ParCPF.ParameterName = "@cpf";
                ParCPF.SqlDbType = SqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Clientes.CPF;
                SqlCmd.Parameters.Add(ParCPF);

                SqlParameter ParCNPJ = new SqlParameter();
                ParCNPJ.ParameterName = "@cnpj";
                ParCNPJ.SqlDbType = SqlDbType.VarChar;
                ParCNPJ.Size = 14;
                ParCNPJ.Value = Clientes.CNPJ;
                SqlCmd.Parameters.Add(ParCNPJ);

                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 50;
                ParEndereco.Value = Clientes.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);



                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = Clientes.Cidade;
                SqlCmd.Parameters.Add(ParCidade);



                SqlParameter ParUF = new SqlParameter();
                ParUF.ParameterName = "@uf";
                ParUF.SqlDbType = SqlDbType.VarChar;
                ParUF.Size = 2;
                ParUF.Value = Clientes.UF;
                SqlCmd.Parameters.Add(ParUF);



                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 13;
                ParTelefone.Value = Clientes.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);



                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Registro não foi Inserido";



            }
            catch(Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if(SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;

        }


        //Método Editar
        public string Editar(Cliente Clientes)
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
                SqlCmd.CommandText = "speditar_clientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Clientes.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);


                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Clientes.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParRazao_Social = new SqlParameter();
                ParRazao_Social.ParameterName = "@razao_social";
                ParRazao_Social.SqlDbType = SqlDbType.VarChar;
                ParRazao_Social.Size = 50;
                ParRazao_Social.Value = Clientes.Razao_Social;
                SqlCmd.Parameters.Add(ParRazao_Social);

                SqlParameter ParCPF = new SqlParameter();
                ParCPF.ParameterName = "@cpf";
                ParCPF.SqlDbType = SqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Clientes.CPF;
                SqlCmd.Parameters.Add(ParCPF);

                SqlParameter ParCNPJ = new SqlParameter();
                ParCNPJ.ParameterName = "@cnpj";
                ParCNPJ.SqlDbType = SqlDbType.VarChar;
                ParCNPJ.Size = 14;
                ParCNPJ.Value = Clientes.CNPJ;
                SqlCmd.Parameters.Add(ParCNPJ);

                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 50;
                ParEndereco.Value = Clientes.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);



                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = Clientes.Cidade;
                SqlCmd.Parameters.Add(ParCidade);



                SqlParameter ParUF = new SqlParameter();
                ParUF.ParameterName = "@uf";
                ParUF.SqlDbType = SqlDbType.VarChar;
                ParUF.Size = 2;
                ParUF.Value = Clientes.UF;
                SqlCmd.Parameters.Add(ParUF);



                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 13;
                ParTelefone.Value = Clientes.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);





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
        public string Excluir(Cliente Clientes)
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
                SqlCmd.CommandText = "spdeletar_clientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Clientes.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);



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
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("clientes1");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_clientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

         }catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método Buscar Nome
        public DataTable BuscarNome(Cliente Clientes)
        {
            DataTable DtResultado = new DataTable("clientes1");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Clientes.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCategoria
    {

        //Método Inserir
        public static string Inserir(string nome, string razao_social, string cpf, string cnpj, string endereco, string cidade, string uf, string telefone)
        {
            Cliente Obj = new CamadaDados.Cliente();
            Obj.Nome = nome;
            Obj.Razao_Social = razao_social;
            Obj.CPF = cpf;
            Obj.CNPJ = cnpj;
            Obj.Endereco = endereco;
            Obj.Cidade = cidade;
            Obj.UF = uf;
            Obj.Telefone = telefone;






            return Obj.Inserir(Obj);
        }



        //Método Editar
        public static string Editar(int idcliente, string nome, string razao_social, string cpf, string cnpj, string endereco, string cidade, string uf, string telefone)
        {
            Cliente Obj = new CamadaDados.Cliente();
            Obj.Idcliente = idcliente;
            Obj.Nome = nome;
            Obj.Razao_Social = razao_social;
            Obj.CPF = cpf;
            Obj.CNPJ = cnpj;
            Obj.Endereco = endereco;
            Obj.Cidade = cidade;
            Obj.UF = uf;
            Obj.Telefone = telefone;

            return Obj.Editar(Obj);
        }



        //Método Deletar
        public static string Excluir(int idcliente)
        {
            Cliente Obj = new CamadaDados.Cliente();
            Obj.Idcliente = idcliente;
          
            return Obj.Excluir(Obj);
        }


        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new Cliente().Mostrar();
            

        }


        //Método Buscar Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            Cliente Obj = new Cliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }


    }
}

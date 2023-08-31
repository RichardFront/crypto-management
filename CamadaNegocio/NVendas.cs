using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
   public class NVendas
    {
        public static string Inserir3(int idcliente,string moedas, int quantidade, string reais)
        {
            DVendas Obj = new CamadaDados.DVendas();
            Obj.Idcliente = idcliente;
            Obj.Moedas = moedas;
            Obj.Quantidade = quantidade;
            Obj.Reais = reais;

                



            return Obj.Inserir3(Obj);
        }

        //Método Mostrar
        public static DataTable Mostrar3()
        {
            return new DVendas().Mostrar3();


        }

        public static string Editar3(int idvenda, int idcliente, string moedas, int quantidade, string reais)
        {
            DVendas Obj = new CamadaDados.DVendas();
            Obj.Idvenda = idvenda;
            Obj.Idcliente= idcliente;
            Obj.Moedas= moedas;
            Obj.Quantidade = quantidade;
            Obj.Reais = reais;


            return Obj.Editar3(Obj);
        }

        public static DataTable BuscarNome3(string textobuscar3)
        {
            DVendas Obj = new DVendas();
            Obj.TextoBuscar3 = textobuscar3;
            return Obj.BuscarNome3(Obj);
        }
        public static string Excluir3(int idvenda)
        {
            DVendas Obj = new CamadaDados.DVendas();
            Obj.Idvenda = idvenda;

            return Obj.Excluir3(Obj);
        }


    }
}

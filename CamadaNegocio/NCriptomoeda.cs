using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio

{

    public class NCriptomoeda
    {

        //Método Inserir
        public static string Inserir2(string descricao, string valor)
        {
            DCriptomoeda Obj = new CamadaDados.DCriptomoeda();
            Obj.Descricao = descricao;
            Obj.Valor = valor;
           





            return Obj.Inserir2(Obj);
        }



        //Método Editar
        public static string Editar2(int idcriptomoeda, string descricao, string valor)
        {
            DCriptomoeda Obj = new CamadaDados.DCriptomoeda();
            Obj.Idcriptomoeda = idcriptomoeda;
            Obj.Descricao = descricao;
            Obj.Valor = valor;
           

            return Obj.Editar2(Obj);
        }



        //Método Deletar
        public static string Excluir2(int idcriptomoeda)
        {
            DCriptomoeda Obj = new CamadaDados.DCriptomoeda();
            Obj.Idcriptomoeda = idcriptomoeda;

            return Obj.Excluir2(Obj);
        }


        //Método Mostrar
        public static DataTable Mostrar2()
        {
            return new DCriptomoeda().Mostrar2();


        }


        //Método Buscar Nome
        public static DataTable BuscarNome2(string textobuscar2)
        {
            DCriptomoeda Obj = new DCriptomoeda();
            Obj.TextoBuscar2 = textobuscar2;
            return Obj.BuscarNome2(Obj);
        }



    }
}
using System.Collections.Generic;

namespace dotnet.Linq.Lambda.List
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(this List<int> listaDeInteiros,params int[] itens)
        // this permite ser chamado por referencia na classe idades pode passar ela mesmo como o parametro
        //List<int> idades = new List<int>();
        //idades.AdicionarVarios();
        {
            foreach (int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}

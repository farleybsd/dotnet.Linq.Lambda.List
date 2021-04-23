using System.Collections.Generic;

namespace dotnet.Linq.Lambda.List
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(List<int> listaDeInteiros,params int[] itens)
        {
            foreach (int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet.Linq.Lambda.List.Extensoes
{
    // Lista Generica
    public static class ListExtensoes<T>
    {
        public static void AdicionarVarios(this List<T> lista , params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }
    }
}

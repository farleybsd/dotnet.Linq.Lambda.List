using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet.Linq.Lambda.List.Extensoes
{
    // Lista Generica
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista , params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void Teste<T2>(this string texto)
        {

        }
    }
}

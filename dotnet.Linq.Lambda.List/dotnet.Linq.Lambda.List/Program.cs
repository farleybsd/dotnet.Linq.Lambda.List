using dotnet.Linq.Lambda.List.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet.Linq.Lambda.List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            string nomes = "Farley";
            nomes.Teste<string>();
            
            //ListExtensoesOld.AdicionarVarios(idades, 1, 5687, 1987, 1567, 987);
            
            idades.AdicionarVarios(5,448,7898,564);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadKey();
        }
    }
}

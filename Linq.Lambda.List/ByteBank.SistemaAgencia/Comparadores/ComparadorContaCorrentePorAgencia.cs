using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            return x.Agencia.CompareTo(y.Agencia);
            /*
            if (x == y)
            {
                return 0;
            }

            if (x ==null)
            {
                return 1;
            }

            if (x == null)
            {
                return -1;
            }

            if (x.Agencia < y.Agencia)
            {
                return -1;
            }

            if (x.Agencia == y.Agencia)
            {
                return 0;
            }

            if (x.Agencia > y.Agencia)
            {
                return 1;
            }
            return 1;
            */
        }
    }
}

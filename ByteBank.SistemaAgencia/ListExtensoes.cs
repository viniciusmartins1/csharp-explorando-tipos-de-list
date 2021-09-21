using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(List<int> listaDeInteiros, params int[] itens)
        {
            foreach(int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
        
    }
}
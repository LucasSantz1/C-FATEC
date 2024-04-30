using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class itemNotaFiscal
    {
        public int Quantidade { get; set; }
        public itemNotaFiscal(int qtd)
        {
            Quantidade = qtd;
        }
    }
}
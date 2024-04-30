using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }

        
        public Endereco(string logradouro, string numero, string cidade)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cidade = cidade;
        }
        
            
        
    }
}
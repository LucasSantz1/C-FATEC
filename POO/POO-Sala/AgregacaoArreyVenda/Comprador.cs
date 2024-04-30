using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArreyVenda
{
    public class Comprador
    {
        public double Verba { get; set; }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Saldo do Comprador: {this.Verba:c}");
        }
    }
}
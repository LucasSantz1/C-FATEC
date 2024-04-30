using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set; }

        public ContaCorrente(double saldo, double chequeEspecial)
        {
            this.Saldo = saldo;
            this.ChequeEspecial = chequeEspecial;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

       public bool Sacar(double valor)
{
    if (this.Saldo + this.ChequeEspecial >= valor)
    {
        this.Saldo -= valor;
        return true;
    }
    Console.WriteLine("Saldo insuficiente");
    return false;
}

        public void GerarExtrato()
        {
            Console.WriteLine("Saldo: " + this.Saldo);
        }
    }
}

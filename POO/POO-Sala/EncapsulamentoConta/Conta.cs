using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;
        /* public void SetNumero(int numeroConta)//Alterar Numero
        {
            numero = numeroConta;
        }
        public int GetNumero()//Buscar Numero
        {
            return numero;
        }
    }
    */
        public int Numero//propriedade
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }


        private string titular;
        {
            get { return titular; }
            set { titular; = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
} 
}
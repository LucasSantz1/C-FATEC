using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta //Toda classe é um tipo de dado
    {
        //declaração de atributos
        public int numero;
        public string titular;
        public double saldo;
        //declaração de métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero + " Titular: " + titular + " Saldo: " + saldo);
            
        }

        public void sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
            //implementação do método
        }
        public void depositar(double valorDeposito)
        {
            saldo += valorDeposito;
            //implementação do método
        }
    
    }
}
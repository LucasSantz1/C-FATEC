using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public static int  Contador { get; set; }
    
        public Conta()//Construtor padrão
        {
            Contador ++;
        }
        public Conta(int numero)
        {
            Numero = numero;
            Contador++;
        }
        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
            Contador++;
        }

        public Conta(int numero, string titular , double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Contador++;
        }

        
    public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + Numero + " Titular: " + Titular + " Saldo: " + Saldo);
        }

        /* static Conta()
        {
            Contador = 157000; aqui basicamente ele vai começar a incrementar a partir desse valor de 157000.
        não importa aonde colocar o STATIC ele sempre vai prevalecer, ele sobrepõe qualquer valor que você coloque.
        } */
    }
}
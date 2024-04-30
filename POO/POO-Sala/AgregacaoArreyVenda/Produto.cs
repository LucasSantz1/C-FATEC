using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArreyVenda
{
    public class Produto
    {
        
        private static int codigoGeral;
        public static int CodigoGeral
        {
            get { return codigoGeral; }
            private set { codigoGeral= value; }
        }

        public int Codigo { get; set; }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set {
                if (string.IsNullOrEmpty(value))
                    System.Console.WriteLine("Nome inválido!");
                else
                    nome = value;  
            }

        }
        private double preco;
        public double Preco
        {
            get { return preco; }
            set {
                if(value <= 0)
                    System.Console.WriteLine("Preço inválido!");
                else
                    preco = value;
                
            }
        } 
        static Produto()
        {
            CodigoGeral = 500;
        }

        public Produto(string nome, double preco)
        {
            codigoGeral++;
            this.Codigo = codigoGeral;
            this.Nome = nome;
            this.Preco = preco;            
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"-> Produto: {Nome}\t Código: {Codigo}\t Preço: {Preco:c}");
        }
        
    }
}
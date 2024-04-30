using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public static int Contador { get; set; }

       
        public Produto()//Construtor padrão
        {
            Contador ++;
        }
        public Produto(int codigo)
        {
            Codigo = codigo;
            Contador++;
        }
        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
            Contador++;
        }

        public Produto(int codigo, string nome , double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Contador++;
        }


        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo + " Nome: " + Nome + " Preço: " + Preco);
        }

            
    }
}
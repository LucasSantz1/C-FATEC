using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        //métodos
        //crie uma função /método para apresentar os atributos
        //crie outra função para calcular o aumento do preço,por meio de uma porcentagem via parâmetro

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + " Nome: " + nome + " Preço: " + preco);
        }
        public void aumentarPreco(double porcentagem)
        {
            preco = preco + (preco * porcentagem / 100);
            

        }

    }
}
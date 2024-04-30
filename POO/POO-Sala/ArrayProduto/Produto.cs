using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int quantidade;
        //métodos
        //crie uma função /método para apresentar os atributos
        //crie outra função para calcular o aumento do preço,por meio de uma porcentagem via parâmetro

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + " Nome: " + nome + " Preço: " + preco + " Quantidade: " + quantidade);
        }
        public void AumentarPreco(double porcentagem)
        {
            preco = preco + (preco * porcentagem / 100);
        }
        double soma= 0;
        public void TotalEmEstoque()
        {
            double total = 0;
            total = preco * quantidade;
            Console.WriteLine("Valor total em estoque: " + total);
            soma = soma + total;
        }
        public void RemoverProdutos(int qtd)
        {
            quantidade = quantidade - qtd;
        }
    }
}
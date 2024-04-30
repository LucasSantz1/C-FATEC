using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Mensalista : Funcionario
    {
        protected double qtdeHorasTrabalhadas;

        public Mensalista(int codigo, string nome, double salario, double qtdeHorasTrabalhadas) : base(codigo, nome, salario)
        {
            QtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }

        public double QtdeHorasTrabalhadas
        {
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Mensalista");
            base.Mostrar();
            Console.WriteLine("Quantidade de horas trabalhadas no mês: " + qtdeHorasTrabalhadas + " horas");
        }

    }
}
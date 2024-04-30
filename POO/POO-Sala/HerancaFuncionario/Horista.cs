using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Horista : Funcionario
    {
        protected double qtdeHorasSemana;

        public Horista(int codigo, string nome, double salario, double qtdeHorasSemana) : base(codigo, nome, salario)
        {
            QtdeHorasSemana = qtdeHorasSemana;
        }

        public double QtdeHorasSemana
        {
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Horista");
            base.Mostrar();
            Console.WriteLine("Quantidade de horas semanais: " + qtdeHorasSemana + " horas");
        }
    }
}
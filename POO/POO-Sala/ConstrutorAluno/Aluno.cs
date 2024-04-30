using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media { get; set; }
        public static int ProximaMatricula { get; set; }

        public Aluno(string nome, double p1, double p2)
        {
            ProximaMatricula++;
            Nome = nome;
            Matricula = "15048222300" + ProximaMatricula.ToString();
            P1 = p1;
            P2 = p2;
            Media = CalcularMedia();
        }
        private double CalcularMedia()
        {
            return (P1 + P2) / 2;
        }

        
        public void MostrarAtributos()
        {
            Console.WriteLine("Nome: " + Nome + "\tMatricula: " + Matricula + "\tP1: " + P1 + "\tP2: " + P2 + "\tMedia: " + Media);
        }

    }
}
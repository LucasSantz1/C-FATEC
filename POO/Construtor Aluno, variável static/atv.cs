using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace atividade_poo
{
    public class Atividade
    {

        public double Media;
        public string RegistroMatricula { get; }
        public string? NomeAluno { get; set; }
        public double NotaP1 { get; set; }
        public double NotaP2 { get; set; }
        public static int _contador { get; set; }


        public Atividade(string nome, double p1, double p2)
        {
            _contador++;
            RegistroMatricula = "157048222300" + _contador;
            NomeAluno = nome;
            NotaP1 = p1;
            NotaP2 = p2;
            Media = CalcularMedia();
        }
        

        public double CalcularMedia(){
            return Media = (NotaP1 + NotaP2) / 2;
        }

        public void MostrarAtributos(){
            System.Console.Write($"Matricula: {RegistroMatricula} \tNome: {NomeAluno} \tP1: {NotaP1} \tP2: {NotaP2} \tMédia: {Media}\n");
        }

    }
}

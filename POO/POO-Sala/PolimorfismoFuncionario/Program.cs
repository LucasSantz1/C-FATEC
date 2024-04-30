// Método Main()
using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Funcionario", 1000);
Console.WriteLine("Bonificação do funcionário: " + f.CalcularBonificacao());

Secretario s = new Secretario(2, "Bel", 1000);
Console.WriteLine("Bonificação do secretário: " + s.CalcularBonificacao());

Gerente g = new Gerente(3,"Bia", 1000);
Console.WriteLine("Bonificação do gerente: " + g.CalcularBonificacao());

Diretor d = new Diretor(4, "Leo", 1000);
Console.WriteLine("Bonificação do diretor: " + d.CalcularBonificacao());



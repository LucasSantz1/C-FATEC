//função main() está em Program.cs escondido
using ClasseConta;

Conta objetoConta;//declarar variável
objetoConta = new Conta();//instanciar objeto
objetoConta.numero = 1;
objetoConta.titular = "Paul";
objetoConta.saldo = 100.57;
objetoConta.MostrarAtributos();
objetoConta.sacar(10);
objetoConta.MostrarAtributos();

//Outra forma de instanciar um objeto - mais usada
Conta objetoConta2 = new Conta();
Console.Write("Digite o número ");
objetoConta2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular ");
objetoConta2.titular = Console.ReadLine();
Console.Write("Digite o saldo ");
objetoConta2.saldo = Convert.ToDouble(Console.ReadLine());
objetoConta2.MostrarAtributos();
objetoConta2.depositar(100);
objetoConta2.MostrarAtributos();

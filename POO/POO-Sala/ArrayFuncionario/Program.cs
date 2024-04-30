using ArrayFuncionario;
// declaração do vetor
Funcionario[] vetF = new Funcionario[3];
for(int i = 0; i < vetF.Length; i++)
{
    vetF[i] = new Funcionario();//Instanciar cada posição do vetor
    Console.Write("Digite o código: ");
    vetF[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    vetF[i].nome = Console.ReadLine();
    Console.Write("Digite o salário: ");
    vetF[i].salario = Convert.ToDouble(Console.ReadLine());
}
/* for(int i = 0; i < vetF.Length; i++)
    vetF[i].MostrarAtributos(); */

foreach (Funcionario f in vetF)
f.MostrarAtributos();
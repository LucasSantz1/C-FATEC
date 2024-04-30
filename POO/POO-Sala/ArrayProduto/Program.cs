using ArrayProduto;



Produto[] vetP = new Produto[3];
for(int i = 0; i < vetP.Length; i++)
{
    vetP[i] = new Produto();//Instanciar cada posição do vetor
    Console.Write("Digite o código: ");
    vetP[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    vetP[i].nome = Console.ReadLine();
    Console.Write("Digite o preço: ");
    vetP[i].preco = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite a quantidade: ");
    vetP[i].quantidade = Convert.ToInt32(Console.ReadLine());
}
/* for(int i = 0; i < vetP.Length; i++)
    vetP[i].MostrarAtributos(); */

foreach (Produto p in vetP)
p.MostrarAtributos();

Console.WriteLine("Digite a porcentagem para aumentar o preço dos produtos: ");
double porcentagem = Convert.ToDouble(Console.ReadLine());
foreach (Produto p in vetP)
{
    p.AumentarPreco(porcentagem);
    p.MostrarAtributos();
}

Console.WriteLine("Digite o código do produto que deseja consultar o total em estoque: ");
int cod = Convert.ToInt32(Console.ReadLine());
foreach (Produto p in vetP)
{
    if (p.codigo == cod)
        p.TotalEmEstoque();
    
}

Console.WriteLine("Digite o código do produto que deseja remover do estoque: ");
cod = Convert.ToInt32(Console.ReadLine());
foreach (Produto p in vetP)
{
    if (p.codigo == cod)
    {
        Console.WriteLine("Digite a quantidade que deseja remover: ");
        int qtd = Convert.ToInt32(Console.ReadLine());
        p.RemoverProdutos(qtd);
        p.MostrarAtributos();
    }
}

Console.WriteLine("Digite o código do produto que deseja registrar a saída: ");
cod = Convert.ToInt32(Console.ReadLine());
foreach (Produto p in vetP)
{
    if (p.codigo == cod)
    {
        Console.WriteLine("Digite a quantidade que deseja registrar como saída: ");
        int qtd = Convert.ToInt32(Console.ReadLine());
        p.RegistrarSaida(qtd);
        p.MostrarAtributos();
    }
}






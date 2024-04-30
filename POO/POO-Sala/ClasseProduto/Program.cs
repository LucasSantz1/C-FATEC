using ClasseProduto;

Produto objetoProduto = new Produto();
Console.Write("Digite o código: ");
objetoProduto.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
objetoProduto.nome = Console.ReadLine();
Console.Write("Digite o preço: ");
objetoProduto.preco = Convert.ToDouble(Console.ReadLine());
objetoProduto.MostrarAtributos();
Console.Write("Digite a porcentagem de aumento: ");
double porcentagem = Convert.ToDouble(Console.ReadLine());
objetoProduto.aumentarPreco(porcentagem);
objetoProduto.MostrarAtributos();








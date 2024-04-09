tp_Pessoa lista = null;

while (true)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1: Para incluir");
    Console.WriteLine("2: Para alterar");
    Console.WriteLine("3: Para excluir");
    Console.WriteLine("4: Para exibir");
    Console.WriteLine("5: Para sair");
    string escolha = Console.ReadLine();

    if (escolha == "1")
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a idade: ");
        string idade = Console.ReadLine();
        Console.Write("Digite o whats: ");
        string whats = Console.ReadLine();

        tp_Pessoa novoElemento = new tp_Pessoa { nome = nome, idade = idade, whats = whats, prox = lista };
        lista = novoElemento;
    }
    else if (escolha == "2")
    {
        Console.Write("Digite o nome para consulta: ");
        string nomeBusca = Console.ReadLine();
        tp_Pessoa elementoAtual = lista;
        while (elementoAtual != null && elementoAtual.nome != nomeBusca)
        {
            elementoAtual = elementoAtual.prox;
        }

        if (elementoAtual != null)
        {
            Console.WriteLine("Dados atuais:");
            Console.WriteLine("O Nome: " + elementoAtual.nome);
            Console.WriteLine("A Idade: " + elementoAtual.idade);
            Console.WriteLine("O Whats: " + elementoAtual.whats);
            Console.WriteLine("Insira os novos dados:");
            Console.Write("Digite o nome: ");
            elementoAtual.nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            elementoAtual.idade = Console.ReadLine();
            Console.Write("Digite o whats: ");
            elementoAtual.whats = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Registro não encontrado.");
        }
    }
    else if (escolha == "3")
    {
        Console.Write("Digite o nome para exclusão: ");
        string nomeExclusao = Console.ReadLine();
        tp_Pessoa elementoAtual = lista, elementoAnterior = null;
        while (elementoAtual != null && elementoAtual.nome != nomeExclusao)
        {
            elementoAnterior = elementoAtual;
            elementoAtual = elementoAtual.prox;
        }

        if (elementoAtual == null)
        {
            Console.WriteLine("Não encontrado.");
            continue;
        }

        if (elementoAnterior == null)
        {
            lista = elementoAtual.prox;
        }
        else
        {
            elementoAnterior.prox = elementoAtual.prox;
        }

        Console.WriteLine("Excluído.");
    }
    else if (escolha == "4")
    {
        tp_Pessoa elementoAtual = lista;
        while (elementoAtual != null)
        {
            Console.WriteLine("Nome: " + elementoAtual.nome);
            Console.WriteLine("Idade: " + elementoAtual.idade);
            Console.WriteLine("Whats: " + elementoAtual.whats);
            elementoAtual = elementoAtual.prox;
        }
    }
    else if (escolha == "5")
    {
        Console.WriteLine("Encerrado.");
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida, digite de 1 a 5.");
    }
}
class tp_Pessoa
{
    public string nome, idade, whats;
    public tp_Pessoa prox;
}

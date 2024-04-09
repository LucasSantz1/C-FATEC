using System.Runtime.InteropServices;


const int TamanhoVetor = 5;
tp_no[] vetor = new tp_no[TamanhoVetor];

int FuncaoHash(int chave)
{
    return chave % TamanhoVetor;
}

void InserirSemTratamento(int chave, string nome, string numeroWhatsapp)
{
    int posicao = FuncaoHash(chave);
    vetor[posicao] = new tp_no();
    vetor[posicao].idade = chave;
    vetor[posicao].nome = nome;
    vetor[posicao].numeroWhatsapp = numeroWhatsapp;
}

void BuscarSemTratamento(int chave)
{
    int posicao = FuncaoHash(chave);

    if (vetor[posicao] == null)
        Console.WriteLine("Registro não encontrado");
    else
    {
        Console.WriteLine("Nome: " + vetor[posicao].nome);
        Console.WriteLine("Novo nome: ");
        vetor[posicao].nome = Console.ReadLine();
        Console.WriteLine("Novo número Whatsapp: ");
        vetor[posicao].numeroWhatsapp = Console.ReadLine();
    }
}

void RelatarSemTratamento()
{
    if (vetor == null)
        Console.WriteLine("Nenhum registro encontrado");
    else
    {
        for (int posicao = 0; posicao < vetor.Length; posicao++)
        {
            if (vetor[posicao] != null)
            {
                Console.WriteLine("Nome: " + vetor[posicao].nome);
                Console.WriteLine("Idade: " + vetor[posicao].idade);
                Console.WriteLine("Número Whatsapp: " + vetor[posicao].numeroWhatsapp);
            }
        }
    }
}

// Linear

tp_no[] vetorLinear = new tp_no[TamanhoVetor];
void InserirLinear(int chave, string nome, string numeroWhatsapp)
{
    int posicao = FuncaoHash(chave);
    while (vetorLinear[posicao] != null)
    {
        posicao++;
        posicao = posicao % TamanhoVetor;
    }
    vetorLinear[posicao] = new tp_no();
    vetorLinear[posicao].idade = chave;
    vetorLinear[posicao].nome = nome;
    vetorLinear[posicao].numeroWhatsapp = numeroWhatsapp;
}

void BuscarLinear(int chave)
{
    int posicao = FuncaoHash(chave);

    if (vetorLinear[posicao] == null)
        Console.WriteLine("Registro não encontrado");
    else
    {
        int contador = 0;
        while (contador < vetorLinear.Length)
        {
            if (chave == vetorLinear[posicao].idade)
            {
                Console.WriteLine("Nome: " + vetorLinear[posicao].nome);
                Console.WriteLine("Número Whatsapp: " + vetorLinear[posicao].numeroWhatsapp);
                Console.WriteLine("Novo nome: ");
                vetorLinear[posicao].nome = Console.ReadLine();
                Console.WriteLine("Novo número Whatsapp: ");
                vetorLinear[posicao].numeroWhatsapp = Console.ReadLine();
            }
            else
            {
                contador++;
                posicao++;
                posicao %= TamanhoVetor;
            }
        }
        Console.WriteLine("Registro não encontrado");
    }
}

void RelatarLinear()
{
    if (vetorLinear == null)
        Console.WriteLine("Nenhum registro encontrado");
    else
    {
        for (int posicao = 0; posicao < vetorLinear.Length; posicao++)
        {
            if (vetorLinear[posicao] != null)
            {
                Console.WriteLine("Nome: " + vetorLinear[posicao].nome);
                Console.WriteLine("Idade: " + vetorLinear[posicao].idade);
                Console.WriteLine("Número Whatsapp: " + vetorLinear[posicao].numeroWhatsapp);
            }
        }
    }
}


tp_no[] vetorEncadeado = new tp_no[TamanhoVetor];
void InserirEncadeado(int chave, string nome, string numeroWhatsapp)
{
    tp_no no = new tp_no();
    int posicao = FuncaoHash(chave);
    vetorEncadeado[posicao] = no;
    vetorEncadeado[posicao].idade = chave;
    vetorEncadeado[posicao].nome = nome;
    vetorEncadeado[posicao].numeroWhatsapp = numeroWhatsapp;
    if (vetorEncadeado[posicao] != null)
    {
        no.proximo = vetor[posicao];
        vetorEncadeado[posicao] = no;
    }
}

void BuscarEncadeado(int chave)
{
    int posicao = FuncaoHash(chave);
    if (vetorEncadeado[posicao] == null)
        Console.WriteLine("Registro não encontrado");
    else
    {
        int contador = 0;
        tp_no atual = vetorEncadeado[posicao];

        while (atual != null)
        {
            if (chave == atual.idade)
            {
                contador++;
                Console.WriteLine("Nome: " + atual.nome);
                Console.WriteLine("Número Whatsapp: " + atual.numeroWhatsapp);
                Console.WriteLine("Novo nome: ");
                atual.nome = Console.ReadLine();
                Console.WriteLine("Novo número Whatsapp: ");
                atual.numeroWhatsapp = Console.ReadLine();
            }
            atual = atual.proximo;
        }

        if (contador == 0)
        {
            Console.WriteLine("Registro não encontrado");
        }
        else
        {
            Console.WriteLine(contador + " alterado(s)");
        }
    }
}

void RelatarEncadeado()
{
    if (vetorEncadeado == null)
        Console.WriteLine("Nenhum registro encontrado");
    else
    {
        for (int i = 0; i < vetorEncadeado.Length; i++)
        {
            tp_no atual = vetorEncadeado[i];

            while (atual != null)
            {
                Console.WriteLine("Nome: " + atual.nome);
                Console.WriteLine("Idade: " + atual.idade);
                Console.WriteLine("Número Whatsapp: " + atual.numeroWhatsapp);
                atual = atual.proximo;
            }
        }
    }
}


string opcaoMenu = " ";
while (opcaoMenu != "4")
{
    Console.WriteLine("Menu");
    Console.WriteLine("1-Sem tratamento");
    Console.WriteLine("2-Tratamento Linear");
    Console.WriteLine("3-Tratamento Encadeado");
    Console.WriteLine("4-Sair");
    opcaoMenu = Console.ReadLine();

    
    if (opcaoMenu == "1")
    {
        string opcao = "";
        while (opcao != "4")
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1-Inserir");
            Console.WriteLine("2-Alterar");
            Console.WriteLine("3-Relatar");
            Console.WriteLine("4-Sair");
            opcao = Console.ReadLine();
            if (opcao == "1")
            {
                int idade;
                string nome;
                string numeroWhatsapp;
                Console.WriteLine("Insira a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Insira o número Whatsapp: ");
                numeroWhatsapp = Console.ReadLine();
                InserirSemTratamento(idade, nome, numeroWhatsapp);
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Escreva a idade desejada: ");
                int pesquisa = Convert.ToInt32(Console.ReadLine());
                BuscarSemTratamento(pesquisa);
            }
            else if (opcao == "3")
            {
                RelatarSemTratamento();
            }
        }
    }

    // Linear
    else if (opcaoMenu == "2")
    {
        string opcao = "";
        while (opcao != "4")
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1-Inserir");
            Console.WriteLine("2-Alterar");
            Console.WriteLine("3-Relatar");
            Console.WriteLine("4-Sair");
            opcao = Console.ReadLine();
            if (opcao == "1")
            {
                int idade;
                string nome;
                string numeroWhatsapp;
                Console.WriteLine("Insira a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Insira o número Whatsapp: ");
                numeroWhatsapp = Console.ReadLine();
                InserirLinear(idade, nome, numeroWhatsapp);
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Escreva a idade desejada: ");
                int pesquisa = Convert.ToInt32(Console.ReadLine());
                BuscarLinear(pesquisa);
            }
            else if (opcao == "3")
            {
                RelatarLinear();
            }
        }
    }

    // Encadeada
    else if (opcaoMenu == "3")
    {
        string opcao = "";
        while (opcao != "4")
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1-Inserir");
            Console.WriteLine("2-Alterar");
            Console.WriteLine("3-Relatar");
            Console.WriteLine("4-Sair");
            opcao = Console.ReadLine();
            if (opcao == "1")
            {
                int idade;
                string nome;
                string numeroWhatsapp;
                Console.WriteLine("Insira a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Insira o número Whatsapp: ");
                numeroWhatsapp = Console.ReadLine();
                InserirEncadeado(idade, nome, numeroWhatsapp);
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Escreva a idade desejada: ");
                int pesquisa = Convert.ToInt32(Console.ReadLine());
                BuscarEncadeado(pesquisa);
            }
            else if (opcao == "3")
            {
                RelatarEncadeado();
            }
        }
    }
}

// No fim
class tp_no
{
    public int idade = 0;
    public string nome = "";
    public string numeroWhatsapp = "";
    public tp_no proximo = null;
}

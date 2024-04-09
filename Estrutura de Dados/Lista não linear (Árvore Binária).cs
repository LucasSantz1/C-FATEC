using System.ComponentModel.Design;

tp_no raiz = null;

void Inserir(ref tp_no no, int valor)
{
   if (no == null)
   {
      no = new tp_no();
      no.dado = valor;
   }
   else if (valor < no.dado)
      Inserir(ref no.esq, valor);
   else
      Inserir(ref no.dir, valor);
}

tp_no Buscar(tp_no no, int valor)
{
   if (no == null)
      return null;
   else if (valor == no.dado)
      return no;
   else if (valor < no.dado)
      return Buscar(no.esq, valor);
   else
      return Buscar(no.dir, valor);
}

tp_no EncontrarMaior(ref tp_no no)
{
   if (no.dir == null)
   {
      tp_no temp = no;
      no = no.esq;
      return temp;
   }
   else
      return EncontrarMaior(ref no.dir);
}

tp_no Remover(ref tp_no no, int valor)
{
   if (no == null)
      return null;
   else if (valor == no.dado)
   {       
      tp_no temp = no;
      if (no.esq == null)
         no = no.dir;
      else if (no.dir == null)
         no = no.esq;
      else
      {
         temp = EncontrarMaior(ref no.esq);
         no.dado = temp.dado;
      }
      return temp;
   }
   else if (valor < no.dado)
      return Remover(ref no.esq, valor);
   else
      return Remover(ref no.dir, valor);
}

void EmOrdem(tp_no no)
{
   if (no != null)
   {
      EmOrdem(no.esq);
      Console.WriteLine(no.dado);
      EmOrdem(no.dir);
   }
}

void PreOrdem(tp_no no)
{
   if (no != null)
   {
      Console.WriteLine(no.dado);
      PreOrdem(no.esq);
      PreOrdem(no.dir);
   }
}

void PosOrdem(tp_no no)
{
   if (no != null)
   {
      PosOrdem(no.esq);
      PosOrdem(no.dir);
      Console.WriteLine(no.dado);
   }
}

string opcao = null;
while (opcao != "5")
{
    Console.WriteLine("Menu");
    Console.WriteLine("1 - Inserir um novo Número");
    Console.WriteLine("2 - Buscar um número");
    Console.WriteLine("3 - Remover um número especifico");
    Console.WriteLine("4 - Exibir todos valores");
    Console.WriteLine("5 - Sair");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.WriteLine("Escreva um número: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        Inserir(ref raiz, valor);
    }

    else if (opcao == "2")
    {
        Console.WriteLine("Digite o número a ser pesquisado: ");
        int numProc = Convert.ToInt32(Console.ReadLine());
        tp_no busca = Buscar(raiz, numProc);
        if (busca != null)
        {
            Console.WriteLine("O Valor foi encontrado");
        }
        else
        {
            Console.WriteLine("O Valor não foi encontrado");
        }
    }

    else if (opcao == "3")
    {
        Console.WriteLine("Digite o número a ser excluído: ");
        int numProc = Convert.ToInt32(Console.ReadLine());
        Remover(ref raiz, numProc);
    }

    else if (opcao == "4")
    {
        string op = null;
        
        while (op != "4")
        {
            Console.WriteLine("Exibir");
            Console.WriteLine("1 - Selecionar em ordem");
            Console.WriteLine("2 - Selecionar em Pré Ordem");
            Console.WriteLine("3 - Selecionar em Pós ordem");
            Console.WriteLine("4 - Selecionar em Sair");
            op = Console.ReadLine();
            if (op == "1")
            {
                EmOrdem(raiz);
            }
            else if (op == "2")
            {
                PreOrdem(raiz);
            }
            else if (op == "3")
            {
                PosOrdem(raiz);
            }
        }
    }
}


class tp_no
{
    public tp_no esq = null;
    public int dado = 0;
    public tp_no dir = null;
}

// No fim do programa

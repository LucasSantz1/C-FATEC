int[] fila = new int[20];
int inicio = 0, fim = 0;

void Insere(int valor)
{
    if (fim < fila.Length)
    {
        fila[fim] = valor;
        fim++;
    }
    else
    {
        Console.WriteLine("A fila está cheia, não é possível inserir mais elementos.");
    }
}

int Remove()
{
    if (inicio < fim)
    {
        int valorRemovido = fila[inicio];
        inicio++;
        return valorRemovido;
    }
    else
    {
        Console.WriteLine("A fila está vazia.");
        return -1;
    }
}

bool EstaVazia()
{
    return inicio == fim;
}

bool EstaCheia()
{
    return fim == fila.Length;
}

while (!EstaCheia())
{
    Console.WriteLine("Digite um valor para inserir na fila // digite 0 para sair: ");
    int valor = int.Parse(Console.ReadLine());

    if (valor == 0)
        break;

    Insere(valor);
}

int maior = int.MinValue;
int menor = int.MaxValue;
int soma = 0;
int qtde = fim - inicio; // Quantidade de elementos na fila

while (!EstaVazia())
{
    int atual = fila[inicio];

    if (atual > maior)
    {
        maior = atual;
    }
    if (atual < menor)
    {
        menor = atual;
    }

    soma += atual;

    Console.WriteLine(Remove());
}

if (inicio == 0)
{
    Console.WriteLine("A fila está vazia.");
}
else
{
    Console.WriteLine($"O maior valor é {maior} e o menor valor é {menor}");

    if (qtde > 0) // Verificar se há elementos antes de calcular a média
    {
        float media = (float)soma / qtde; // Converter a soma para float antes da divisão
        Console.WriteLine($"A média é {media}");
    }
    else
    {
        Console.WriteLine("A fila está vazia, não é possível calcular a média.");
    }
}



Console.Write("Digite uma frase: ");
string inputFrase = Console.ReadLine();
int[] stack = new int[inputFrase.Length];
int top = 0;

void Push(int value)
{
    stack[top] = value;
    top = top + 1;
}

int Pop()
{
    top = top - 1;
    return stack[top];
}

bool IsEmpty()
{
    return top == 0;
}

bool IsFull()
{
    return top == stack.Length;
}

int i = 0;
while (i < inputFrase.Length)
{
    // Insire cada caractere na pilha até encontrar um espaço em branco
    while (i < inputFrase.Length && inputFrase[i] != ' ')
    {
        Push(inputFrase[i]);
        i = i + 1;
    }

    // Remove os caracteres da pilha
    while (!IsEmpty())
    {
        Console.Write((char)Pop());
    }

    if (i < inputFrase.Length)
    {
        Console.Write(" ");
        i = i + 1;
    }
}

Console.WriteLine();

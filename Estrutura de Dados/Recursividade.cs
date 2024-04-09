
    string op = "0";
    while (op != "6")
    {
        Console.WriteLine("\n\rMENU DE EXERCÍCIOS");
        Console.WriteLine(" 1 Realizar a potência do número");
        Console.WriteLine(" 2 Transformar o número em cubo");
        Console.WriteLine(" 3 Calcula o MDC entre dois números");
        Console.WriteLine(" 4 Descobrir o n-ésimo termo da série fibonacci");
        Console.WriteLine(" 5 Transformar número em binário");
        Console.WriteLine("6 Sair");

        op = Console.ReadLine();
        if (op == "1")
        {
            Console.WriteLine("Digite o um número para calcula a sua potencia: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o seu expoente desejado: ");
            int e = Convert.ToInt32(Console.ReadLine());
            int resultado = CalculaP(n, e);
            Console.WriteLine("O número digitado " + n + " elevado ao numero digitado " + e + " é: " + resultado);
        }
        else if (op == "2")
        {
            Console.WriteLine("Digite o número desejado para realizar o calculo do cubo: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ExibirOCubo(n);
        }
        else if (op == "3")
        {
            Console.WriteLine("Digite o primeiro número desejado: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número desejado: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int resultado = CMDC(n1, n2);
            Console.WriteLine("O MDC de " + n1 + " e " + n2 + " é: " + resultado);
        }
        else if (op == "4")
        {
            Console.WriteLine("MENU (RECURSIVA, ITERATIVA)");
            Console.WriteLine("Digite 1 para a Função recursiva ");
            Console.WriteLine("Digite 2 para a Função iterativa ");
            string op2 = Console.ReadLine();
            Console.WriteLine("Digite um numero para realizar a série fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (op2 == "1")
            {
                int resultado = CFR(n);
                Console.WriteLine("O " + n + "º termo é igual a: " + resultado);
            }
            else if (op2 == "2")
            {
                int resultado = CFI(n);
                Console.WriteLine("O " + n + "º termo é igual a: " + resultado);
            }
        }
        else if (op == "5")
        {
            Console.WriteLine("Digite o número para realizar a conversao para a base binária ");
            int n = Convert.ToInt32(Console.ReadLine());
            CPB(n);
        }
        else if (op == "6")
        {
            Console.WriteLine("Fim.");
        }
        else
        {
            Console.WriteLine("Invalido, Digite os numeros do Menu!");
        }
        }


    int CalculaP(int x, int y)
{
    if (y == 0)
        return 1;
    else
        return x * CalculaP(x, y - 1);
}

void ExibirOCubo(int n)
{
    if (n > 0)
    {
        ExibirOCubo(n - 1);
        Console.WriteLine(n * n * n);
    }
}

int CMDC(int x, int y)
{
    if (x == y)
        return x;
    else if (x < y)
        return CMDC(y, x);
    else
        return CMDC(x - y, y);
    }

int CFR(int n)
{
    if (n == 0)
        return 0;
    else if (n == 1)
        return 1;
    else
        return CFR(n - 1) + CFR(n - 2);
}

int CFI(int n)
{
if (n == 0)
    return 0;
    int n1 = 0;
    int n2 = 1;
    int soma = 1;
    for (int i = 2; i <= n; i++)
    {
        soma = n1 + n2;
        n1 = n2;
        n2 = soma;
    }
    return soma;
}

void CPB(int n)
{
    if (n != 0)
    {
        CPB(n / 2);
        Console.Write(n % 2);
    }
}


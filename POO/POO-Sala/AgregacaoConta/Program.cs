using AgregacaoConta;

Endereco end = new Endereco("Rua Fatec", "75", "PP City");
Cliente cli = new Cliente("Ana", "1111,2222", "333.444.555-66");
cli.Ender = end;//Agregando o endereço ao cliente
Conta c1 = new Conta();
c1.Numero = 1;
c1.Titular = cli;//Agragando o cliente a conta c1
c1.Saldo = 1000.00;
Console.WriteLine("Número: " + c1.Numero);
Console.WriteLine("Saldo: " + c1.Saldo);
Console.WriteLine("Nome: " + c1.Titular.Nome);
Console.WriteLine("RG: " + c1.Titular.Rg);
Console.WriteLine("CPF: " + c1.Titular.Cpf);
Console.WriteLine("Endereço: " + c1.Titular.Ender.Logradouro);
Console.WriteLine("Número: " + c1.Titular.Ender.Numero);
Console.WriteLine("Cidade: " + c1.Titular.Ender.Cidade);

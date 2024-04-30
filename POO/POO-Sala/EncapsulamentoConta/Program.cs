using EncapsulamentoConta;
Conta c1 = new Conta();
//c1.AlterarNumero(1000);
//Console.WriteLine("Número: "+ c1.BuscarNumero());
//c1.SetNumero(1000);
//Console.WriteLine("Número: "+ c1.GetNumero());
//usando o padrão C# para o encapsulamento
c1.Numero = 1000;//set
Console.WriteLine("Número: "+ c1.Numero);//get
c1.titular = "Fatec";//set
c1.saldo = 1050;//set
Console.WriteLine("Titular: "+ c1.titular);//get
Console.WriteLine("Saldo: "+ c1.saldo);//get

using  EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();
f1.Codigo = 1;
f1.Nome = "Pedro";
f1.Salario = 1000;
Console.WriteLine("Código: " + f1.Codigo);//get
 if(f1.Salario > 999){   //get
    Console.WriteLine("Rico");
} 
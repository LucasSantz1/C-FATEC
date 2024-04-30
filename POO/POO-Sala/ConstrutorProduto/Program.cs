using ConstrutorProduto;

Produto p1 = new Produto();//construtor padrão (papel do contrutor é inicializar todos os atributos da classe com valores padrão)
p1.Codigo = 1;
p1.Nome = "Coca-Cola";
p1.Preco = 5.00;
p1.MostrarAtributos();

Produto p2 = new Produto(2);//construtor com 1 parâmetro
p2.Nome = "Pepsi";
p2.Preco = 4.50;
p2.MostrarAtributos();

Produto p3 = new Produto(3, 3.50);//construtor com 2 parâmetros
p3.Nome = "Fanta";
p3.MostrarAtributos();

Produto p4 = new Produto(4, "Guaraná", 3.00);//construtor com 3 parâmetros
p4.MostrarAtributos();




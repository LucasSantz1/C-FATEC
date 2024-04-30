using AgregacaoArreyVenda;
// main

System.Console.WriteLine("---- Iniciar Venda ----");

Vendedor vendedor = new Vendedor();
vendedor.MostrarAtributos();
Comprador comprador = new Comprador();
comprador.Verba = 3000;
comprador.MostrarAtributos();

// cadastrar alguns produtos
System.Console.WriteLine("- Produtos -");

Produto p1 = new Produto("Mouse", 250);
p1.MostrarAtributos();
Produto p2 = new Produto("Teclado", 400);
p2.MostrarAtributos();
Produto p3 = new Produto("Fone", 300);
p3.MostrarAtributos();
Produto p4 = new Produto("Monitor", 1000);
p4.MostrarAtributos();
Produto p5 = new Produto("Adaptador", 20);
p5.MostrarAtributos();

System.Console.WriteLine("---- Iniciar Primeira Venda ----");

Venda venda = new Venda();
venda.Comp = comprador;
venda.Vend = vendedor;
venda.VetProd.Add(p1);
venda.VetProd.Add(p2);
venda.VetProd.Add(p3);
venda.VetProd.Add(p4);
venda.VetProd.Add(p5);
venda.calcularComissao();
venda.registraCompra(); 
venda.MostrarAtributos();


Venda venda2 = new Venda();
venda2.Comp = comprador;
venda2.Vend = vendedor;
venda2.VetProd.Add(p1);
venda2.VetProd.Add(p3);
venda2.VetProd.Add(p5);
venda2.calcularComissao();
venda2.registraCompra(); 
venda2.MostrarAtributos();
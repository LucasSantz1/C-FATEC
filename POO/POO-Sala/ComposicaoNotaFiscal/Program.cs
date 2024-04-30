using ComposicaoNotaFiscal;

itemNotaFiscal item1 = new itemNotaFiscal(10);
itemNotaFiscal item2 = new itemNotaFiscal(5);

NotaFiscal nf = new NotaFiscal(1 ,"01/04/2024");
nf.AdicionarItens(item1);
nf.AdicionarItens(item2);

foreach(itemNotaFiscal itens in nf.VetItens)
{
    Console.WriteLine("Quantidade: " + itens.Quantidade);
}
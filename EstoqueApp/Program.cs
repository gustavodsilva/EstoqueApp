using EstoqueApp;
using EstoqueApp.Services;

var arquivoService = new ArquivoService();
var produtos = arquivoService.Carregar();
var service = new ProdutoService(produtos);

while (true)
{
    Console.WriteLine("\n=== SISTEMA DE ESTOQUE ===\n");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Listar produtos");
    Console.WriteLine("3 - Dar baixa no estoque");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite a opção desejada: ");
    if (!int.TryParse(Console.ReadLine(), out int opcao))
    {
        Console.Write("Opção inválida!");
        continue;
    }

    switch (opcao)
    {
        case 1:
            Console.Clear();
            Console.Write("NOME DO PRODUTO: ");
            var nomeProduto = Console.ReadLine();
            Console.Write("\nQUANTIDADE:  ");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            Console.Write("\nPREÇO: ");
            decimal precoProduto = decimal.Parse(Console.ReadLine());

            var produto = new Produto
            {
                Nome = nomeProduto,
                Quantidade = quantidadeProduto,
                Preco = precoProduto
            };
            service.Adicionar(produto);
            arquivoService.Salvar(service.Listar());
            Console.Clear();
            break;

        case 2:
            Console.Clear();
            foreach (var p in service.Listar())
            {
                Console.Write($"\nNome: {p.Nome}, Quantidade: {p.Quantidade}, Preço: {p.Preco}");
            }
            Thread.Sleep(3000);
            Console.Clear();
            break;

        case 3:
            Console.Write("\nQual produto deseja dar baixa: ");
            var produtoBaixa = Console.ReadLine();
            var produtoEncontrado = service.BuscarPorNome(produtoBaixa);

                if (produtoEncontrado != null)
                {
                    Console.Write("Quantidade a dar baixa: ");
                    int quantidadeBaixa = int.Parse(Console.ReadLine());
                    if (quantidadeBaixa > produtoEncontrado.Quantidade)
                    {

                        Console.Write("\nQuantidade insuficiente em estoque.\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                    break;
                    }

                produtoEncontrado.Quantidade -= quantidadeBaixa;
                arquivoService.Salvar(service.Listar());
                }
                
                else
                {
                    Console.Write("Produto não encontrado.");
                }
    
            Console.Write("\nProcessando Informação...");
            Thread.Sleep(2000);
            Console.Clear();
            break;

        case 0:
            return;
    }
}
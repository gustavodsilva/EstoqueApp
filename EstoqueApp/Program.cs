using EstoqueApp;

List<Produto> produtos = new List<Produto>();

while (true)
{
    Console.WriteLine("\n=== SISTEMA DE ESTOQUE ===\n");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Listar produtos");
    Console.WriteLine("3 - Dar baixa no estoque");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("NOME DO PRODUTO: ");
            var nomeProduto = Console.ReadLine();
            Console.WriteLine("\nQUANTIDADE:  ");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPREÇO: ");
            decimal precoProduto = decimal.Parse(Console.ReadLine());

            var produto = new Produto
            {
                Nome = nomeProduto,
                Quantidade = quantidadeProduto,
                Preco = precoProduto
            };
            produtos.Add(produto);
            Console.Clear();
            break;

        case 2:
            Console.Clear();
            foreach (var p in produtos)
            {
                Console.WriteLine($"\nNome: {p.Nome}, Quantidade: {p.Quantidade}, Preço: {p.Preco}");
            }
            Thread.Sleep(3000);
            Console.Clear();
            break;

        case 3:
            Console.WriteLine("Qual produto deseja dar baixa? ");
            var produtoBaixa = Console.ReadLine();
            foreach (var p in produtos)
            {
                if (p.Nome == produtoBaixa)
                {
                    Console.WriteLine("Quantidade a dar baixa: ");
                    int quantidadeBaixa = int.Parse(Console.ReadLine());
                    p.Quantidade -= quantidadeBaixa;
                } 
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
            Console.WriteLine("Pedido sendo processado...");
            Thread.Sleep(2000);
            Console.Clear();
            break;

        case 0:
            return;
    }
}
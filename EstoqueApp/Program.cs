using EstoqueApp;

List<Produto> produtos = new List<Produto>();

while (true)
{
    Console.WriteLine("\n=== SISTEMA DE ESTOQUE ===");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Listar produtos");
    Console.WriteLine("3 - Dar baixa no estoque");
    Console.WriteLine("0 - Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("NOME DO PRODUTO: ");
            var nomeProduto = Console.ReadLine();
            Console.WriteLine("QUANTIDADE:  ");
            var quantidadeProduto = int.Parse(Console.ReadLine());
            Console.WriteLine("PREÇO: ");
            var precoProduto = decimal.Parse(Console.ReadLine());

            var produto = new Produto
            {
                Nome = nomeProduto,
                Quantidade = quantidadeProduto,
                Preco = precoProduto
            };
            produtos.Add(produto);

            break;

        case "2":
            // listar
            break;

        case "3":
            // dar baixa
            break;

        case "0":
            return;
    }
}
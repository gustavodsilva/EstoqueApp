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
            // cadastrar
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
using System.Text;
using EstoqueApp;
namespace EstoqueApp;

public class ArquivoService
{
    private string caminhoArquivo = "produtos.csv";
    public void Salvar(List<Produto> produtos)
    {
        var linhas = new List<string>();

        foreach (var p in produtos)
        {
            linhas.Add($"{p.Nome};{p.Quantidade};{p.Preco}");
        }

        File.WriteAllLines(caminhoArquivo, linhas, Encoding.UTF8);
    }

    public List<Produto> Carregar()
    {
        var produtos = new List<Produto>();
        if (!File.Exists(caminhoArquivo))
            return produtos;

        var linhas = File.ReadAllLines(caminhoArquivo);

        foreach (var linha in linhas)
        {
            var dados = linha.Split(';');
            var produto = new Produto
            {
                Nome = dados[0],
                Quantidade = int.Parse(dados[1]),
                Preco = decimal.Parse(dados[2])
            };
            produtos.Add(produto);
        }
        return produtos;
    }
}

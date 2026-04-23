using System.Collections.Generic;
using System.Linq;
using EstoqueApp;

namespace EstoqueApp.Services;

public class ProdutoService
{
    private List<Produto> produtos = new List<Produto>();

    public void Adicionar(Produto produto)
    {
        produtos.Add(produto);
    }

    public List<Produto> Listar()
    {
        return produtos;
    }

    public Produto? BuscarPorNome(string nome)
    {
        return produtos.FirstOrDefault(p => p.Nome == nome);
    }
}
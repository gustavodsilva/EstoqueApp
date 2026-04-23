namespace EstoqueApp.Services;

using EstoqueApp;
using System.Collections.Generic;

public class ProdutoService
{
    private List<Produto> produtos;

    public ProdutoService(List<Produto> produtos)
    {
        this.produtos = produtos;
    }

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
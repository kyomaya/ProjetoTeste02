using ProjetoFortes.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoFortes.Domain.Interface.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        IEnumerable<Produto> BuscarPorDescricao(string nome);
        IEnumerable<Produto> BuscarPorCodigo(int codigo);
    }
}

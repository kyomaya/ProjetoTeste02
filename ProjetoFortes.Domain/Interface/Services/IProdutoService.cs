using ProjetoFortes.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoFortes.Domain.Interface.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorDescricao(string nome);
        IEnumerable<Produto> BuscarPorCodigo(int codigo);
    }
}

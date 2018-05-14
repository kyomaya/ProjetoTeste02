using System.Collections.Generic;
using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Repositories;
using System.Linq;

namespace ProjetoFortes.Infraestrutura.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorCodigo(int codigo)
        {
            return contexto.Produtos.Where(x => x.Codigo == codigo);
        }

        public IEnumerable<Produto> BuscarPorDescricao(string nome)
        {
            return contexto.Produtos.Where(x => x.Descricao.Contains(nome));
        }
    }
}

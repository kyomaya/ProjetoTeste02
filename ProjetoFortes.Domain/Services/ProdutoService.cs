using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Services;
using ProjetoFortes.Domain.Interface.Repositories;
using System.Collections.Generic;

namespace ProjetoFortes.Dominio.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorDescricao(string nome)
        {
            return _produtoRepository.BuscarPorDescricao(nome);
        }

        public IEnumerable<Produto> BuscarPorCodigo(int codigo)
        {
            return _produtoRepository.BuscarPorCodigo(codigo);
        }
    }
}

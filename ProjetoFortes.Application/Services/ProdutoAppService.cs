using ProjetoFortes.Aplicacao.Interface;
using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Services;

namespace ProjetoFortes.Aplicacao.Services
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

    }
}

using ProjetoFortes.Aplicacao.Interface;
using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Services;

namespace ProjetoFortes.Aplicacao.Services
{
    public class FornecedorAppService : AppServiceBase<Fornecedor>, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorAppService(IFornecedorService fornecedorService) : base(fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

    }
}

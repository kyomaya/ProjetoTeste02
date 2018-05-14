using ProjetoFortes.Aplicacao.Interface;
using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Services;

namespace ProjetoFortes.Aplicacao.Services
{
    public class ItensPedidoAppService : AppServiceBase<ItensPedido>, IItensPedidoAppService
    {
        private readonly IItensPedidoService _itensPedidoService;

        public ItensPedidoAppService(IItensPedidoService itensPedidoService) : base(itensPedidoService)
        {
            _itensPedidoService = itensPedidoService;
        }

    }
}

using ProjetoFortes.Aplicacao.Interface;
using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Services;

namespace ProjetoFortes.Aplicacao.Services
{
    public class PedidoAppService : AppServiceBase<Pedido>, IPedidoAppService
    {
        private readonly IPedidoService _pedidoService;

        public PedidoAppService(IPedidoService pedidoService) : base(pedidoService)
        {
            _pedidoService = pedidoService;
        }

    }
}

using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Services;
using ProjetoFortes.Domain.Interface.Repositories;

namespace ProjetoFortes.Dominio.Services
{
    public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository) : base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
    }
}

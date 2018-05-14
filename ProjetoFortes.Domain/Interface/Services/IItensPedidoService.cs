using ProjetoFortes.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoFortes.Domain.Interface.Services
{
    public interface IItensPedidoService : IServiceBase<ItensPedido>
    {
        ItensPedido BuscarPorProdutoEPedido(int produtoId, int pedidoId);
    }
}

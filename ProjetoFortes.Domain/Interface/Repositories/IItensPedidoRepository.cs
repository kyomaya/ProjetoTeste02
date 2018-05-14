using ProjetoFortes.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoFortes.Domain.Interface.Repositories
{
    public interface IItensPedidoRepository : IBaseRepository<ItensPedido>
    {
        ItensPedido BuscarPorProdutoEPedido(int produtoId,int pedidoId);
    }
}

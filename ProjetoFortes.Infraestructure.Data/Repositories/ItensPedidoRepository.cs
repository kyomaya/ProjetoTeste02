using System.Collections.Generic;
using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Repositories;
using System.Linq;
using System;

namespace ProjetoFortes.Infraestrutura.Data.Repositories
{
    public class ItensPedidoRepository : BaseRepository<ItensPedido>, IItensPedidoRepository
    {
        public ItensPedido BuscarPorProdutoEPedido(int produtoId, int pedidoId)
        {
            return contexto.ItensPedido.Where(x => x.ProdutoId == produtoId && x.PedidoId==pedidoId).FirstOrDefault();
        }
    }
}

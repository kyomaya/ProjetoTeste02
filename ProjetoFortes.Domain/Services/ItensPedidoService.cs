using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Services;
using ProjetoFortes.Domain.Interface.Repositories;
using System.Collections.Generic;
using System;

namespace ProjetoFortes.Dominio.Services
{
    public class ItensPedidoService : ServiceBase<ItensPedido>, IItensPedidoService
    {
        private readonly IItensPedidoRepository _ItensPedidoRepository;

        public ItensPedidoService(IItensPedidoRepository ItensPedidoRepository) : base(ItensPedidoRepository)
        {
            _ItensPedidoRepository = ItensPedidoRepository;
        }

        public ItensPedido BuscarPorProdutoEPedido(int produtoId, int pedidoId)
        {
            return _ItensPedidoRepository.BuscarPorProdutoEPedido(produtoId, pedidoId);
        }
    }
}

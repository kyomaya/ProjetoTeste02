using System;
using System.Collections.Generic;

namespace ProjetoFortes.Domain.Entities
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public virtual ICollection<ItensPedido> ItensPedido { get; set; }
        public int QuantidadeProdutos { get; set; }
        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public decimal ValorTotal { get; set; }

        public Pedido()
        {
            this.ItensPedido = new List<ItensPedido>();
        }
    }
}

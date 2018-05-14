using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFortes.Presentation.MVC.ViewModels
{
    public class PedidoViewModel
    {
        [Key]
        public int PedidoId { get; set; }

        [DisplayName("Fornecedor")]
        public int FornecedorId { get; set; }

        public virtual FornecedorViewModel Fornecedor { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Código do Pedido")]
        public long Codigo { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Quantidade de Produtos")]
        public int QuantidadeProdutos { get; set; }

        [DisplayName("Data do Pedido")]
        [ScaffoldColumn(false)]
        public DateTime Data{ get; set; }

        [DisplayName("Valor Total")]
        [ScaffoldColumn(false)]
        public decimal ValorTotal { get; set; }

        public int ProdutoId { get; set; }
        public int QuantidadeProduto { get; set; }

        public virtual IEnumerable<ItensPedidoViewModel> ItensPedido { get; set; }
    }
}
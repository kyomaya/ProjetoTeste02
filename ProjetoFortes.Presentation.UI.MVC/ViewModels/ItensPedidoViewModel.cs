using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFortes.Presentation.MVC.ViewModels
{
    public class ItensPedidoViewModel
    {
        [Key]
        public int ItensPedidoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Codigo")]
        [ScaffoldColumn(false)]
        public long Codigo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Quantidade de Produtos")]
        [Range(1, 9999)]
        [DisplayName("Quantidade de Produtos")]
        [ScaffoldColumn(false)]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Subtotal")]
        [DisplayName("Subtotal")]
        [ScaffoldColumn(false)]
        public decimal Subtotal { get; set; }

        public virtual int ProdutoId { get; set; }
        public virtual ProdutoViewModel Produto { get; set; }

        [ScaffoldColumn(false)]
        public virtual int PedidoId { get; set; }
    }
}
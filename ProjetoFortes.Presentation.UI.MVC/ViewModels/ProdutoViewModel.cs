using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFortes.Presentation.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage ="Preencha o campo Codigo")]
        [DisplayName("Código do Produto")]
        public long Codigo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descricao")]
        [MaxLength(100,ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Data de Cadastro")]
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Valor")]
        //[DataType(DataType.Currency,ErrorMessage ="Preencha o campo com um valor válido")]
        //[Range(0,99999)]
        [DisplayName("Valor (R$)")]
        public decimal Valor { get; set; }

        //public virtual IEnumerable<ItensPedidoViewModel> ItensPedido { get; set; }
    }
}
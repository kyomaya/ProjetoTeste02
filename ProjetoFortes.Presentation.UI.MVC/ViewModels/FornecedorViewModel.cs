using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFortes.Presentation.MVC.ViewModels
{
    public class FornecedorViewModel   
    {
        [Key]
        [DisplayName("Fornecedor")]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email de Contato")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo de {0} caracteres")]
        [EmailAddress(ErrorMessage ="Preencha com um e-mail válido")]
        [DisplayName("E-mail de contato")]
        public virtual string EmailContato { get; set; }

        [Required(ErrorMessage = "Preencha o campo Codigo")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Nome do contato")]
        public string NomeContato { get; set; }

        [Required(ErrorMessage ="Preencha o campo Razão Social")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(20, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ")]
        [MaxLength(15,ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(12, ErrorMessage = "Mínimo de {0} caracteres")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Preencha o campo UF")]
        [MaxLength(2, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string UF { get; set; }

        [DisplayName("Data de Cadastro")]
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}
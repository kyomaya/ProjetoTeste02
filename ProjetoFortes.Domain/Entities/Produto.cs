using System;
using System.Collections.Generic;

namespace ProjetoFortes.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public long Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Valor { get; set; }

        public virtual ICollection<ItensPedido> ItensPedido { get; set; }

        public Produto()
        {
            ItensPedido = new List<ItensPedido>();
        }
    }
}

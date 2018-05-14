using ProjetoFortes.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFortes.Infraestrutura.Dados.Configuration
{
    public class PedidoConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            this.HasKey(t => t.PedidoId);

            this.Property(t => t.Codigo)
                .IsRequired();

            this.Property(t => t.Data)
                .IsRequired();

            this.Property(t => t.QuantidadeProdutos)
                .IsRequired();

            this.Property(t => t.ValorTotal)
                .IsRequired();

            this.HasRequired(t => t.Fornecedor)
                .WithMany()
                .HasForeignKey(t => t.FornecedorId);

            this.ToTable("Pedidos", "dbo");
        }
    }
}

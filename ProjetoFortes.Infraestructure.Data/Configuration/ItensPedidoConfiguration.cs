using ProjetoFortes.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFortes.Infraestrutura.Dados.Configuration
{
    public class ItensPedidoConfiguration : EntityTypeConfiguration<ItensPedido>
    {
        public ItensPedidoConfiguration()
        {
            this.HasKey(t => t.ItensPedidoId);

            this.Property(t => t.Quantidade)
                .IsRequired();

            this.Property(t => t.Subtotal)
                .IsRequired();

            this.Property(t => t.PedidoId)
                .IsOptional();

            this.Property(t => t.ProdutoId)
                .IsOptional();

            this.ToTable("ItensPedido", "dbo");
        }
    }
}

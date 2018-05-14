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
                .IsRequired();

            this.Property(t => t.ProdutoId)
                .IsRequired();

            //this.HasRequired(t => t.Produto)
            //    .WithMany()
            //    .HasForeignKey(t => t.ProdutoId);

            //this.HasRequired(t => t.Pedido)
            //    .WithMany()
            //    .HasForeignKey(t => t.PedidoId);


            //this.HasMany(t => t.Produtos)
            //    .WithMany(t => t.Pedidos)
            //    .Map(
            //        m => m.ToTable("ProdutosPedido")
            //        .MapLeftKey("PedidoId")
            //        .MapRightKey("ProdutoId")

            //        );

            this.ToTable("ItensPedido", "dbo");
        }
    }
}

using ProjetoFortes.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFortes.Infraestrutura.Dados.Configuration
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            this.HasKey(t => t.ProdutoId);

            this.Property(t => t.Codigo)
                .IsRequired();

            this.Property(t => t.DataCadastro)
                .IsRequired();

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Valor)
                .IsRequired();

            this.ToTable("Produtos", "dbo");
        }
    }
}

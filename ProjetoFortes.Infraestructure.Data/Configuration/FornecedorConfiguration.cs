using ProjetoFortes.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFortes.Infraestrutura.Dados.Configuration
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            this.HasKey(t => t.FornecedorId);

            this.Property(t => t.CNPJ)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.EmailContato)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.NomeContato)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RazaoSocial)
                .IsRequired()
                .HasMaxLength(100);


            this.Property(t => t.DataCadastro)
                .IsRequired();

            this.Property(t => t.UF)
               .IsRequired()
               .HasMaxLength(2);

            this.ToTable("Fornecedores", "dbo");
        }
    }
}

namespace ProjetoFortes.Infraestructure.Data.Migrations
{
    using Initializer;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Infraestrutura.Data.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Infraestrutura.Data.Contexto context)
        {
            if (context.Produtos.Count() == 0)
                DbInitializer.GetProdutos().ForEach(c => context.Produtos.Add(c));

            if (context.Fornecedores.Count() == 0)
                DbInitializer.GetFornecedores().ForEach(c => context.Fornecedores.Add(c));

            if (context.Pedidos.Count() == 0)
                DbInitializer.GetPedidos().ForEach(c => context.Pedidos.AddOrUpdate(c));
        }
    }
}

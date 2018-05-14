using ProjetoFortes.Aplicacao.Services;
using ProjetoFortes.Aplicacao.Interface;
using ProjetoFortes.Domain.Interface.Repositories;
using ProjetoFortes.Domain.Interface.Services;
using ProjetoFortes.Dominio.Services;
using ProjetoFortes.Infraestrutura.Data.Repositories;
using SimpleInjector;

namespace ProjetoFortes.Infraestructure.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            container.Register<IProdutoAppService, ProdutoAppService>(Lifestyle.Scoped);
            container.Register<IProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);
            container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);

            container.Register<IFornecedorAppService, FornecedorAppService>(Lifestyle.Scoped);
            container.Register<IFornecedorRepository, FornecedorRepository>(Lifestyle.Scoped);
            container.Register<IFornecedorService, FornecedorService>(Lifestyle.Scoped);

            container.Register<IPedidoAppService, PedidoAppService>(Lifestyle.Scoped);
            container.Register<IPedidoRepository, PedidoRepository>(Lifestyle.Scoped);
            container.Register<IPedidoService, PedidoService>(Lifestyle.Scoped);

            container.Register<IItensPedidoAppService, ItensPedidoAppService>(Lifestyle.Scoped);
            container.Register<IItensPedidoRepository, ItensPedidoRepository>(Lifestyle.Scoped);
            container.Register<IItensPedidoService, ItensPedidoService>(Lifestyle.Scoped);
        }
    }
}

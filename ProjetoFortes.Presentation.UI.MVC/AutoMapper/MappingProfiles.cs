using AutoMapper;
using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Presentation.MVC.ViewModels;

namespace ProjetoFortes.Presentation.UI.MVC.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Produto, ProdutoViewModel>()
              .ForMember(vm => vm.Codigo, map => map.MapFrom(m => m.Codigo))
              .ForMember(vm => vm.DataCadastro, map => map.MapFrom(m => m.DataCadastro))
              .ForMember(vm => vm.Descricao, map => map.MapFrom(m => m.Descricao))
              .ForMember(vm => vm.ProdutoId, map => map.MapFrom(m => m.ProdutoId))
              .ForMember(vm => vm.Valor, map => map.MapFrom(m => m.Valor));

            CreateMap<ProdutoViewModel, Produto>()
               .ForMember(m => m.Codigo, map => map.MapFrom(vm => vm.Codigo))
               .ForMember(m => m.DataCadastro, map => map.MapFrom(vm => vm.DataCadastro))
               .ForMember(m => m.Descricao, map => map.MapFrom(vm => vm.Descricao))
               .ForMember(m => m.Descricao, map => map.MapFrom(vm => vm.Descricao))
               .ForMember(m => m.ProdutoId, map => map.MapFrom(vm => vm.ProdutoId))
               .ForMember(m => m.Valor, map => map.MapFrom(vm => vm.Valor))
               .ForMember(vm => vm.ItensPedido, map => map.Ignore());

            CreateMap<Pedido, PedidoViewModel>()
              .ForMember(vm => vm.Codigo, map => map.MapFrom(m => m.Codigo))
              .ForMember(vm => vm.FornecedorId, map => map.MapFrom(m => m.FornecedorId))
              .ForMember(vm => vm.Fornecedor, map => map.MapFrom(m => m.Fornecedor))
              .ForMember(vm => vm.ItensPedido, map => map.MapFrom(m => m.ItensPedido))
              .ForMember(vm => vm.ValorTotal, map => map.MapFrom(m => m.ValorTotal))
              .ForMember(vm => vm.Data, map => map.MapFrom(m => m.Data))
              .ForMember(m => m.ProdutoId, map => map.Ignore())
              .ForMember(m => m.QuantidadeProduto, map => map.Ignore());

            CreateMap<PedidoViewModel, Pedido>()
               .ForMember(m => m.Codigo, map => map.MapFrom(vm => vm.Codigo))
               .ForMember(m => m.FornecedorId, map => map.MapFrom(vm => vm.FornecedorId))
               .ForMember(m => m.Fornecedor, map => map.MapFrom(vm => vm.Fornecedor))
               .ForMember(m => m.ItensPedido, map => map.MapFrom(vm => vm.ItensPedido))
               .ForMember(m => m.ValorTotal, map => map.MapFrom(vm => vm.ValorTotal))
               .ForMember(m => m.Data, map => map.MapFrom(vm => vm.Data));



            CreateMap<Fornecedor, FornecedorViewModel>()
              .ForMember(vm => vm.CNPJ, map => map.MapFrom(m => m.CNPJ))
              .ForMember(vm => vm.FornecedorId, map => map.MapFrom(m => m.FornecedorId))
              .ForMember(vm => vm.DataCadastro, map => map.MapFrom(m => m.DataCadastro))
              .ForMember(vm => vm.EmailContato, map => map.MapFrom(m => m.EmailContato))
              .ForMember(vm => vm.NomeContato, map => map.MapFrom(m => m.NomeContato))
              .ForMember(vm => vm.RazaoSocial, map => map.MapFrom(m => m.RazaoSocial))
              .ForMember(vm => vm.UF, map => map.MapFrom(m => m.UF));

            CreateMap<FornecedorViewModel, Fornecedor>()
               .ForMember(m => m.CNPJ, map => map.MapFrom(vm => vm.CNPJ))
               .ForMember(m => m.FornecedorId, map => map.MapFrom(vm => vm.FornecedorId))
               .ForMember(m => m.DataCadastro, map => map.MapFrom(vm => vm.DataCadastro))
               .ForMember(m => m.EmailContato, map => map.MapFrom(vm => vm.EmailContato))
               .ForMember(m => m.NomeContato, map => map.MapFrom(vm => vm.NomeContato))
               .ForMember(m => m.RazaoSocial, map => map.MapFrom(vm => vm.RazaoSocial))
               .ForMember(m => m.UF, map => map.MapFrom(vm => vm.UF));
        }
    }
}
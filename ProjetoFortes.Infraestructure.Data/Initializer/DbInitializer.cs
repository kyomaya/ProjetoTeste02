using ProjetoFortes.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFortes.Infraestructure.Data.Initializer
{
    public class DbInitializer
    {
        public static List<Produto> GetProdutos()
        {
            var produtos = new List<Produto>
            {
                new Produto
                {
                    Codigo=1,
                    Descricao="Coca cola 2lts",
                    DataCadastro = new System.DateTime(2018,05,12),
                    ProdutoId=1,
                    Valor=new decimal(8.00)
                },
                new Produto
                {
                    Codigo=2,
                    Descricao="Coca cola 1lt",
                    DataCadastro = new System.DateTime(2018,05,12),
                    ProdutoId=2,
                    Valor=new decimal(4.00)
                },
                 new Produto
                {
                    Codigo=3,
                    Descricao="Coca cola 600ml",
                    DataCadastro = new System.DateTime(2018,05,12),
                    ProdutoId=3,
                    Valor=new decimal(3.00)
                }

            };
            return produtos;
        }

        public static List<Fornecedor> GetFornecedores()
        {
            var fornecedores = new List<Fornecedor>
            {
                new Fornecedor
                {
                    FornecedorId=1,
                    CNPJ="01.234.567/0001",
                    DataCadastro= new System.DateTime(2018,05,12),
                    EmailContato="Fulano@uol.com.br",
                    NomeContato="José Fulano",
                    RazaoSocial="Fulano Distribuidora de Bebidas ME",
                    UF="CE"
                },
                new Fornecedor
                {
                    FornecedorId=2,
                    CNPJ="98.765.432/0001",
                    DataCadastro= new System.DateTime(2018,05,12),
                    EmailContato="Sicrano@uol.com.br",
                    NomeContato="José Sicrano",
                    RazaoSocial="Sicrano Distribuidora de Bebidas ME",
                    UF="CE"
                }

            };
            return fornecedores;
        }

        public static List<Pedido> GetPedidos()
        {
            var pedidos = new List<Pedido>
            {
                new Pedido
                {
                    Codigo=1,
                    Data=new System.DateTime(2018,05,12),
                    FornecedorId=1,
                    PedidoId=1,
                    ItensPedido=GetItensPedido1(),
                    QuantidadeProdutos=GetItensPedido1().Count,
                    ValorTotal = GetItensPedido1().Sum(x=>x.Subtotal)
                }                 
            };
            return pedidos;
        }


        public static List<ItensPedido> GetItensPedido1()
        {
            var itensPedido = new List<ItensPedido>
            {
                new ItensPedido
                {
                    PedidoId=1,
                    ProdutoId=1,
                    Quantidade=1,
                    Subtotal= GetProdutos()[0].Valor
                },
                  new ItensPedido
                {
                    PedidoId=1,
                    ProdutoId=2,
                    Quantidade=1,
                    Subtotal= GetProdutos()[1].Valor
                }

            };
            return itensPedido;
        }

        public static List<ItensPedido> GetItensPedido2()
        {
            var itensPedido = new List<ItensPedido>
            {
                new ItensPedido
                {
                    PedidoId=2,
                    ProdutoId=1,
                    Quantidade=1,
                    Subtotal= GetProdutos()[0].Valor
                },
                  new ItensPedido
                {
                    PedidoId=2,
                    ProdutoId=2,
                    Quantidade=1,
                    Subtotal= GetProdutos()[2].Valor
                }

            };
            return itensPedido;
        }
    }
}

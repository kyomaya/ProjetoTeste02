using AutoMapper;
using ProjetoFortes.Presentation.MVC.ViewModels;
using ProjetoFortes.Aplicacao.Interface;
using ProjetoFortes.Domain.Entities;
using System.Collections.Generic;
using System.Web.Mvc;
using System;
using System.Linq;

namespace ProjetoFortes.Presentation.MVC.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoAppService _pedidoApp;
        private readonly IFornecedorAppService _fornecedorApp;
        private readonly IProdutoAppService _produtoApp;

        public PedidoController(IPedidoAppService pedidoApp, IFornecedorAppService fornecedorApp, IProdutoAppService produtoApp)
        {
            _pedidoApp = pedidoApp;
            _fornecedorApp = fornecedorApp;
            _produtoApp = produtoApp;
        }

        public ActionResult Index()
        {
            var pedidoViewModel = Mapper.Map<IEnumerable<PedidoViewModel>>(_pedidoApp.GetAll());
            return View(pedidoViewModel);
        }

        public ActionResult Details(int id)
        {
            var pedido = _pedidoApp.GetById(id);
            var pedidoViewModel = Mapper.Map<PedidoViewModel>(pedido);
            return View(pedidoViewModel);
        }

        public ActionResult Create()
        {
            ViewBag.Produtos = new SelectList(_produtoApp.GetAll(), "ProdutoId", "Descricao");
            ViewBag.Fornecedores = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "RazaoSocial");
            return View(new PedidoViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PedidoViewModel pedidoViewModel)
        {
            if (ModelState.IsValid)
            {
                var pedido = Mapper.Map<PedidoViewModel, Pedido>(pedidoViewModel);
                if (pedidoViewModel.ProdutoId != 0 && pedidoViewModel.QuantidadeProduto != 0)
                {
                    var produtoAdicionado = _produtoApp.GetById(pedidoViewModel.ProdutoId);

                    var itemPedidoNovo = new ItensPedido
                    {
                        ProdutoId = produtoAdicionado.ProdutoId,
                        Quantidade = pedidoViewModel.QuantidadeProduto,
                        Subtotal = produtoAdicionado.Valor * pedidoViewModel.QuantidadeProduto
                    };
                    if (pedido.ItensPedido == null)
                        pedido.ItensPedido = new List<ItensPedido>();

                    pedido.ItensPedido.Add(itemPedidoNovo);
                    pedido.ValorTotal = itemPedidoNovo.Subtotal * itemPedidoNovo.Quantidade;
                    pedido.QuantidadeProdutos = 1;
                    pedido.Codigo = _pedidoApp.GetAll().Count();
                    pedido.Data = DateTime.Today;
                    _pedidoApp.Add(pedido);
                    pedido.ItensPedido.ToList()[0].Produto = produtoAdicionado;
                    pedidoViewModel = Mapper.Map<Pedido, PedidoViewModel>(pedido);
                    pedidoViewModel.PedidoId = pedido.PedidoId;
                }

            }
            ViewBag.Produtos = new SelectList(_produtoApp.GetAll(), "ProdutoId", "Descricao");
            ViewBag.Fornecedores = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "RazaoSocial");
            return View(pedidoViewModel);
        }

        public ActionResult Edit(int id)
        {
            var pedido = _pedidoApp.GetById(id);
            var pedidoViewModel = Mapper.Map<Pedido, PedidoViewModel>(pedido);
            ViewBag.Produtos = new SelectList(_produtoApp.GetAll(), "ProdutoId", "Descricao");
            ViewBag.Fornecedores = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "RazaoSocial");
            return View(pedidoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PedidoViewModel pedidoViewModel, IEnumerable<ItensPedidoViewModel> itensPedido)
        {
            if (ModelState.IsValid)
            {
                var PedidoDomain = Mapper.Map<PedidoViewModel, Pedido>(pedidoViewModel);
                _pedidoApp.Update(PedidoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Produtos = new SelectList(_produtoApp.GetAll(), "ProdutoId", "Descricao");
            ViewBag.Fornecedores = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "RazaoSocial");
            var Pedido = _pedidoApp.GetById(pedidoViewModel.PedidoId);
            pedidoViewModel = Mapper.Map<Pedido, PedidoViewModel>(Pedido);
            return View(pedidoViewModel);
        }


        public ActionResult DeleteItemPedido(int idPedido, int idProduto)
        {
            var pedido = _pedidoApp.GetById(idPedido);
            var itemARemover = pedido.ItensPedido.Where(x => x.ProdutoId == idProduto).FirstOrDefault();
            if (itemARemover != null)
            {
                pedido.ItensPedido.Remove(itemARemover);
                _pedidoApp.Update(pedido);
            }
            var pedidoViewModel = Mapper.Map<Pedido, PedidoViewModel>(pedido);
            return RedirectToAction("Edit",new { id= pedido .PedidoId});
        }

        public ActionResult Delete(int id)
        {
            var pedido = _pedidoApp.GetById(id);
            var pedidoViewModel = Mapper.Map<Pedido, PedidoViewModel>(pedido);
            return View(pedidoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var Pedido = _pedidoApp.GetById(id);
                _pedidoApp.Remove(Pedido);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

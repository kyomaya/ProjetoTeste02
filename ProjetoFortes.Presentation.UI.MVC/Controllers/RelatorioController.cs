using AutoMapper;
using ProjetoFortes.Aplicacao.Interface;
using ProjetoFortes.Presentation.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoFortes.Presentation.UI.MVC.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly IPedidoAppService _pedidoApp;

        public RelatorioController(IPedidoAppService pedidoApp)
        {
            _pedidoApp = pedidoApp;
        }

        [HttpGet, ActionName("RelatorioPedidos")]
        public ActionResult RelatorioPedidos()
        {
            var pedidoViewModel = Mapper.Map<IEnumerable<PedidoViewModel>>(_pedidoApp.GetAll());
            return View(pedidoViewModel);
        }

        [HttpGet, ActionName("ExibirRelatorio")]
        public ActionResult ExibirRelatorio(int id)
        {
            var pedido = _pedidoApp.GetById(id);
            var pedidoViewModel = Mapper.Map<PedidoViewModel>(pedido);
            return View(pedidoViewModel);
        }
    }
}
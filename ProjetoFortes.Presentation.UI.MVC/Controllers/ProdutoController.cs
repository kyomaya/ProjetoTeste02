using AutoMapper;
using ProjetoFortes.Presentation.MVC.ViewModels;
using ProjetoFortes.Aplicacao.Interface;
using ProjetoFortes.Domain.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoFortes.Presentation.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoApp;

        public ProdutoController(IProdutoAppService produtoApp)
        {
            _produtoApp = produtoApp;
        }

        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(produtoViewModel);
        }

        public ActionResult Details(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
                _produtoApp.Add(produtoDomain);

                return RedirectToAction("Index");
            }
            return View(produtoViewModel);
        }

        public ActionResult Edit(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Update(produtoDomain);

                return RedirectToAction("Index");
            }
            return View(produto);
        }

        public ActionResult Delete(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var produto = _produtoApp.GetById(id);
                _produtoApp.Remove(produto);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

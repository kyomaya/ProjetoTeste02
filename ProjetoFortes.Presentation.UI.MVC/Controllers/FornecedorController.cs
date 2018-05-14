using AutoMapper;
using ProjetoFortes.Presentation.MVC.ViewModels;
using ProjetoFortes.Aplicacao.Interface;
using ProjetoFortes.Domain.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoFortes.Presentation.MVC.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorAppService _FornecedorApp;

        public FornecedorController(IFornecedorAppService FornecedorApp)
        {
            _FornecedorApp = FornecedorApp;
        }

        public ActionResult Index()
        {
            var FornecedorViewModel = Mapper.Map<IEnumerable<FornecedorViewModel>>(_FornecedorApp.GetAll());
            return View(FornecedorViewModel);
        }

        public ActionResult Details(int id)
        {
            var Fornecedor = _FornecedorApp.GetById(id);
            var FornecedorViewModel = Mapper.Map<FornecedorViewModel>(Fornecedor);
            return View(FornecedorViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedorViewModel Fornecedor)
        {
            if (ModelState.IsValid)
            {
                var FornecedorDomain = Mapper.Map<FornecedorViewModel, Fornecedor>(Fornecedor);
                _FornecedorApp.Add(FornecedorDomain);

                return RedirectToAction("Index");
            }
            return View(Fornecedor);
        }

        public ActionResult Edit(int id)
        {
            var Fornecedor = _FornecedorApp.GetById(id);
            var FornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(Fornecedor);
            return View(FornecedorViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FornecedorViewModel Fornecedor)
        {
            if (ModelState.IsValid)
            {
                var FornecedorDomain = Mapper.Map<FornecedorViewModel, Fornecedor>(Fornecedor);
                _FornecedorApp.Update(FornecedorDomain);

                return RedirectToAction("Index");
            }
            return View(Fornecedor);
        }

        public ActionResult Delete(int id)
        {
            var fornecedor = _FornecedorApp.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var Fornecedor = _FornecedorApp.GetById(id);
                _FornecedorApp.Remove(Fornecedor);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

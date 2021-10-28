using AcademyI.Week6.Amazon.CORE.BusinessLayer;
using AcademyI.Week6.Amazon.MVC.Helper;
using AcademyI.Week6.Amazon.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.MVC.Controllers
{
    public class ProdottoController : Controller
    {
        private readonly IBusinessLayer BL;

        public ProdottoController(IBusinessLayer bl)
        {
            BL = bl;
        }


        public IActionResult Index()
        {
            var prodotti = BL.GetAll();

            List<ProdottoViewModel> prodottiViewModel = new List<ProdottoViewModel>();

            foreach (var item in prodotti)
            {
                prodottiViewModel.Add(item.toProdottoViewModel());
            }
            return View(prodottiViewModel);
        }

        public IActionResult Details(string id)
        {
            var prodotto = BL.GetAll().FirstOrDefault(p => p.Codice == id);
            var prodottoViewModel = prodotto.toProdottoViewModel();

            return View(prodottoViewModel);
        }

        //add
        [Authorize(Policy = "Adm")] //non solo chiede il login/autenticazione ma richiede che il ruolo sia Administrator
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "Adm")] //non solo chiede il login/autenticazione ma richiede che il ruolo sia Administrator
        [HttpPost]
        public IActionResult Create(ProdottoViewModel prodottoViewModel)
        {
            if (ModelState.IsValid) //se la validazione è andata a buon fine, aggiungo alla lista e torno alla Index
            {
                BL.Create(prodottoViewModel.toProdotto());
                return RedirectToAction(nameof(Index)); //qui mi rimandi alla index
            }
            LoadViewBag();
            return View(prodottoViewModel); //se non va a buon fine, ritorno 
        }

        //Edit
        [Authorize(Policy = "Adm")] //non solo chiede il login/autenticazione ma richiede che il ruolo sia Administrator
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var prodotto = BL.GetAll().FirstOrDefault(p => p.Codice == id);
            var prodottoViewModel = prodotto.toProdottoViewModel();
            return View(prodottoViewModel);
        }

        [HttpPost]
        [Authorize(Policy = "Adm")] //non solo chiede il login/autenticazione ma richiede che il ruolo sia Administrator
        public IActionResult Edit(ProdottoViewModel prodottoViewModel)
        {
            var prodotto = prodottoViewModel.toProdotto();

            if (ModelState.IsValid) //se la validazione è andata a buon fine, aggiungo alla lista e torno alla Index
            {
                BL.Edit(prodotto);
                return RedirectToAction(nameof(Index)); //qui mi rimandi alla index
            }
            LoadViewBag();
            return View(prodottoViewModel); //se non va a buon fine, ritorno 
        }

        //Delete
        [Authorize(Policy = "Adm")] //non solo chiede il login/autenticazione ma richiede che il ruolo sia Administrator
        public IActionResult Delete(string id)
        {
            var prodotto = BL.GetAll().FirstOrDefault(p => p.Codice == id);
            var prodottoViewModel = prodotto.toProdottoViewModel();
            return View(prodottoViewModel);
        }

        [HttpPost]
        [Authorize(Policy = "Adm")] //non solo chiede il login/autenticazione ma richiede che il ruolo sia Administrator
        public IActionResult Delete(ProdottoViewModel prodottoViewModel)
        {
            var prodotto = prodottoViewModel.toProdotto();

            if (ModelState.IsValid)
            {
                BL.DeleteByCode(prodottoViewModel.Codice);
                return RedirectToAction(nameof(Index));
            }
            return View(prodottoViewModel);
        }


        private void LoadViewBag()
        {
            ViewBag.Tipologia = new SelectList(new[]{
                new { Value="1", Text="Elettronica"},
                new { Value="2", Text="Abbigliamento"},
                new { Value="3", Text="Casalinghi"} }.OrderBy(x => x.Text), "Value", "Text");
        }
    }
}

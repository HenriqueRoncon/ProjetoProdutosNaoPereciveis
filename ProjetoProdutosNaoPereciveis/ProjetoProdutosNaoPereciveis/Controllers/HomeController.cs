using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoProdutosNaoPereciveis.Models;

namespace ProjetoProdutosNaoPereciveis.Controllers
{
    public class HomeController : Controller
    {
            public ActionResult Index()
            {
                var naoPerecivel = new ProdutosNaoPereciveis();
                return View(naoPerecivel);
            }
            [HttpPost]
            public ActionResult Index(ProdutosNaoPereciveis naoPerecivel)
            {
                if (ModelState.IsValid)
                {
                    return View("Resultado", naoPerecivel);
                }
                return View(naoPerecivel);
            }
            public ActionResult Resultado(ProdutosNaoPereciveis naoPerecivel)
            {
                return View(naoPerecivel);
            }

            public ActionResult About()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }

            public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
        
    }
}
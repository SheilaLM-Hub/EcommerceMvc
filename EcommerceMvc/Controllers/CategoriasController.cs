using EcommerceMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EcommerceMvc.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Index()
        {
            List<Categoria> list = new List<Categoria>();
            list.Add(new Categoria { Id = 1, Nome = "Eletronico" });
            list.Add(new Categoria { Id = 2, Nome = "Vestuário" });

            return View(list);
        }
    }
}

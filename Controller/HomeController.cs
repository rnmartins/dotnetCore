using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVazio.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Vim da controller Home e action Index";
        }

        public IActionResult Index2(string nome, int id = 1)
        {   
            ViewData["nome"] = nome;
            ViewData["id"] = id;

            return View();
        }

        public IActionResult Index4(int id = 1)
        {   
            List<Models.Produto> produtos = new List<Models.Produto>();

            Models.Produto produto1 = new Models.Produto();
            produto1.Id = Guid.NewGuid();
            produto1.Nome = "Notebook";

            Models.Produto produto2 = new Models.Produto();
            produto2.Id = Guid.NewGuid();
            produto2.Nome = "GameBoy";

            Models.Produto produto3 = new Models.Produto();
            produto3.Id = Guid.NewGuid();
            produto3.Nome = "PlayStation";

            produtos.Add(produto1);
            produtos.Add(produto2);
            produtos.Add(produto3);

            ViewData["id"] = id;
            
            return View(produtos);
        }

        public IActionResult Index3()
        {
            // Fui na base de dados, peguei os dados
            Models.Produto produto = new Models.Produto();
            produto.Id = Guid.NewGuid();
            produto.Nome = "Notebook";

            return View(produto);
        }
    }
}
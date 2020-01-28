using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FS_Software.UI.AppModelo.Areas.Produtos.Controllers
{  

    [Area(nameof(Produtos))]  // CRM is the another-folder name inside Areas folder
    [Route("Produtos/[controller]/[action]")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
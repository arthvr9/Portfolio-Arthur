using Microsoft.AspNetCore.Mvc;
using Portfolio1.Models;
using System.Collections.Generic;

namespace Portfolio1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Projeto> projetos = new List<Projeto>
            {
                new Projeto { ID = 1, Titulo = "CQA", Descricao = "Projeto realizado para o Startup Weekend voltado para a indústria 4.0", Imagem = "cqa.png", Link = "https://github.com/arthvr9/CQA" },
                new Projeto { ID = 2, Titulo = "InvesteAI", Descricao = "Projeto extensionista da Faculdade da Serra Gaúcha para novos investidores", Imagem = "InvesteAi.png", Link = "https://github.com/arthvr9/projetoextensionista"},
                new Projeto { ID = 3, Titulo = "Histerese", Descricao = "Nada mais que uma demonstração de uma Histerese em um sistema embarcado", Imagem = "histerese.png", Link = "https://github.com/arthvr9/Hysteresis"}
            };
            return View(projetos);
        }
    }
}

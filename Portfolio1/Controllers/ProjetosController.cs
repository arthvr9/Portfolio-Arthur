using Microsoft.AspNetCore.Mvc;
using Portfolio1.Models;

namespace Portfolio1.Controllers
{
    public class ProjetosController : Controller
    {
        public IActionResult Index()
        {
            List<Projeto> projetos = new List<Projeto>()
            {
                new Projeto { ID = 1, Titulo = "CQA", Descricao = "Um projeto de uma startup para o Startup Weekend, onde a mesma trabalha com visão computacional e IoT, o projeto foi desenvolvido inteiramente em Python utilizando OpenCV e outras bibliotecas para visão computacional", Imagem = "cqa.png" },
                new Projeto { ID = 2, Titulo = "InvesteAI", Descricao = "Projeto extensionista para o curso de Ciência da Computação na faculdade da serra gaúcha, feito para auxiliar novos investidores à descobrir seu perfil de investidor, desenvolvido utilizando PHP, HTML e CSS com um banco de dados MYSQL", Imagem = "InvesteAi.png" }
            };
            return View(projetos);
        }
    }
}

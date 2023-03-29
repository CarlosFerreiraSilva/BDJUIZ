using CoderCarrer.DAL;
using CoderCarrer.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;


namespace CoderCarrer.Controllers
{
    public class VagasController : Controller
    {
        public IActionResult Index()
        {
    
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.trabalhabrasil.com.br/");
            HtmlDocument doc2 = web.Load("https://www.bne.com.br/");
            HtmlDocument doc3 = web.Load("https://www.infojobs.com.br/empregos-em-sao-paulo.aspx");

            var body1 = doc.DocumentNode.SelectSingleNode("/html/body");
            var titulo1 = body1.SelectNodes("//h2[contains(@class, 'job__name')]").Select(x => x.InnerText.Trim());
            var empresa1 = body1.SelectNodes("//h3[contains(@class, 'job__company')]").Select(x => x.InnerText.Trim());
            var descricao1 = body1.SelectNodes("//p[contains(@class, 'job__description')]").Select(x => x.InnerText.Trim());

            foreach (var item in titulo1)
            {
                ViewBag.listaTitulos += item.Trim();
            }

            foreach (var item in empresa1)
            {
                ViewBag.listaEmpresas += item.Trim();
            }

            foreach (var item in descricao1)
            {
                ViewBag.listaDescricao += item.Trim();
            }

            //var vaga2 = doc2.DocumentNode.SelectNodes("//div[contains(@class, 'descvaga_ultimas-vagas')]").Select(x => x.InnerText.Trim());
            // var vaga3 = doc3.DocumentNode.SelectNodes("//div[contains(@class, 'py-16 pl-24 pr-16 cursor-pointer js_vacancyLoad js_cardLink')]").Select(x => x.InnerText.Trim());

           // foreach (var item in vaga2)
           // {
             //   ViewBag.listaVagas += item.Trim();
           // }


           // foreach (var item in vaga3)
           // {
            //    ViewBag.listaVagas += item.Trim();
           // }


            //var titulo = doc.DocumentNode.SelectNodes("//*[@id=\"jobs-wrapper\"]").First().InnerText;
            //VagaDAO dados = new VagaDAO();
            //ViewBag.listatitulo = titulo.Trim();

            //foreach (var item in doc.DocumentNode.SelectNodes("//*[@id=\"jobs-wrapper\"]"))
            //{
            // string titulo = item.ChildNodes[i].InnerText.Trim();
            // vagas.Add(new Vaga());
            // {
            //  title.titulo = titulo;
            // }


            //  i++;
            //  }

            return View();
            
        }
    }
}

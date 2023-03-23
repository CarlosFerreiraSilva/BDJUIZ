using Microsoft.AspNetCore.Mvc;
using ProvaSQL_ASPNETMVC.DAL;

namespace ProvaSQL_ASPNETMVC.Controllers
{
    public class DocumentoJuizController : Controller
    {
        public IActionResult Index()
        {

            DocumentoJuizDAO dados = new DocumentoJuizDAO();
            ViewBag.listaDocumentoJuiz = dados.getTodosDocumentoJuiz();
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArquiteturaCamadas.Interfaces.Dtos;
using ArquiteturaCamadas.Interfaces.InterfacesFabricas.Servico;

namespace ArquiteturaCamadas.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Fazer uma validação de Usuário 
            return View();
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

        [HttpPost]
        public ActionResult SalvarUsuario( DtoUsuarios dto )
        {
            // Geralmente cria-se uma instância desta Interface de Serviço de Usuário para poder acessar os Serviços disponíveis
            // Mas precisa criar um método para trabalhar com a criação de interfaces

            try
            {
                // var servicoDeUsuario = FabricaGenerica.Crie<IServicoDeUsuario>(DadosUsuario.ConnectionString);
                // servicoDeUsuario.SalvaUsuario(dto)
                return Json(new { success = true, message = "Usuário criado com sucesso!" });

            }
            catch (Exception err)
            {
                return Json(new { success = false, message = err.Message });

            }
        }
    }
}
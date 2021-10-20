using Ingenico.Application.Interfaces;
using Ingenico.Application.Services;
using System;
using System.Web.Mvc;

namespace Ingenico.CalcularIdade.WebSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly IAppCalcularIdadeService _calcularIdadeService;

        public HomeController()
        {
            _calcularIdadeService = new AppCalcularIdadeService();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularIdade(string data)
        {
            bool is_action = false;
            string error = string.Empty;
            string success = string.Empty;
            DateTime dataNascimento;

            try
            {
                dataNascimento = Convert.ToDateTime(data);

                success = $"Sua Idade é : {_calcularIdadeService.CalcularIdade(dataNascimento)}";
                is_action = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Cadeia de caracteres não foi reconhecida como DateTime válido.")
                    error = "Data informada é invalida.";
                else
                    error = ex.Message;

                is_action = false;
            }

            return Json(new { is_action, error, success });
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
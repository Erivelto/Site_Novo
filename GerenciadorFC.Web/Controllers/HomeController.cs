using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GerenciadorFC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {

		
		//public async Task <HttpPostAttribute> HttpPost(FormularioViewModel formularioViewModel)
		//{
	    //	var _form = Mapper.Map<FormularioViewModel>(formularioViewModel);
		//	using (var formEmail = new HttpClient())
		//	{
		//		formEmail.BaseAddress = new Uri("http://localhost:49511/api/Email");
		//		var _retorno = await formEmail.PostAsync("", _form);
		//	}
				

		//}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

		public IActionResult FormularioDeAvalicao()
		{
			ViewData["Message"] = "Your contact page.";
			return View();
		}
        public IActionResult Services()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Portifolio()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

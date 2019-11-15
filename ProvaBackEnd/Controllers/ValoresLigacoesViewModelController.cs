using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ProvaBackEnd.Models;
using ProvaBackEnd.Models.ViewModel;

namespace ProvaBackEnd.Controllers
{
    public class ValoresLigacoesViewModelController : Controller
    {
        private FaleMaisContext db = new FaleMaisContext();

        // GET: ValoresLigacoesViewModel
        public ActionResult Index()
        {
            List<ValoresLigacoesViewModel> viewModel = new List<ValoresLigacoesViewModel>();
            
           

           
            return View(viewModel);
        }
    }
}
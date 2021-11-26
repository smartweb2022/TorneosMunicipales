using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages
{
    public class CreateCanchaModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioCancha _repoCancha;
        //Propiedad para transportar  al cshtml

        [BindProperty]
        public Cancha Cancha{get;set;}
        // Constructor
        
        public CreateCanchaModel(IRepositorioCancha repositorioCancha)
        {
            this._repoCancha = repositorioCancha;
        }
        
        public ActionResult OnGet()
        {
            return Page();
        }
        
        public ActionResult OnPost()
        {
            bool creado = _repoCancha.CrearCancha(Cancha);
            if (creado)
            {
                return RedirectToPage("./CanchaIndex");
            }
            else
            {
                ViewData["Mensaje"] = "La cancha ya se encuentra registrada";
                return Page();
            }
        }
       
    }
}

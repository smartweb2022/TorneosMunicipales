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
    public class CreateEscenarioModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioEscenario _repoEscenario;
        //Propiedad para transportar  al cshtml

        [BindProperty]
        public Escenario Escenario{get;set;}
        // Constructor
        
        public CreateEscenarioModel(IRepositorioEscenario repositorioEscenario)
        {
            this._repoEscenario = repositorioEscenario;
        }
        
        public ActionResult OnGet()
        {
            return Page();
        }
        
        public ActionResult OnPost()
        {
            bool creado = _repoEscenario.CrearEscenario(Escenario);
            if (creado)
            {
                return RedirectToPage("./EscenarioIndex");
            }
            else
            {
                ViewData["Mensaje"] = "El Escenario ya se encuentra registrado";
                return Page();
            }
        }

    }
}

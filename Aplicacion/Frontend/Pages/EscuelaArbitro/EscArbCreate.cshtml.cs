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
    public class EscArbCreateModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioEscuelaArbitro _repoEscuelaArbitro;
        //Propiedad para tarnsportar  al cshtml

        [BindProperty]
        public EscuelaArbitro EscuelaArbitro{get;set;}
        // Constructor
        public EscArbCreateModel(IRepositorioEscuelaArbitro repositorioEscuelaArbitro)
        {
            this._repoEscuelaArbitro = repositorioEscuelaArbitro;
        }
        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {
            bool creado = _repoEscuelaArbitro.CrearEscuelaArbitro(EscuelaArbitro);
            if (creado)
            {
                return RedirectToPage("./EscArbIndex");
            }
            else
            {
                //viewData["repoMunicipio"] = creado;
                ViewData["Mensaje"] = "El Entrenador ya se encuentra registrado";
                return Page();
            }
        }
    }
}

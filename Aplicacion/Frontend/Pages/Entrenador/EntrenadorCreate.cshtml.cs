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
    public class EntrenadorCreateModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioEntrenador _repoEntrenador;
        //Propiedad para tarnsportar  al cshtml

        [BindProperty]
        public Entrenador Entrenador{get;set;}
        // Constructor
        public EntrenadorCreateModel(IRepositorioEntrenador repositorioEntrenador)
        {
            this._repoEntrenador = repositorioEntrenador;
        }
        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {
            bool creado = _repoEntrenador.CrearEntrenador(Entrenador);
            if (creado)
            {
                return RedirectToPage("./EntrenadorIndex");
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

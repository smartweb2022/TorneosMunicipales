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
    public class CreateDeporModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioDeportista _repoDeportista;
        //Propiedad para tarnsportar  al cshtml

        [BindProperty]
        public Deportista Deportista{get;set;}
        // Constructor
        public CreateDeporModel(IRepositorioDeportista repositorioDeportista)
        {
            this._repoDeportista = repositorioDeportista;
        }
        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {
            bool creado = _repoDeportista.CrearDeportista(Deportista);
            if (creado)
            {
                return RedirectToPage("./IndexDepor");
            }
            else
            {
                //viewData["repoDeportista"] = creado;
                ViewData["Mensaje"] = "El deportista ya se encuentra registrado";
                return Page();
            }
        }
    }
}

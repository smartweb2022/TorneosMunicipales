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
    public class ArbCreateModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioArbitro _repoArbitro;
        //Propiedad para tarnsportar  al cshtml

        [BindProperty]
        public Arbitro Arbitro{get;set;}
        // Constructor
        public ArbCreateModel(IRepositorioArbitro repositorioArbitro)
        {
            this._repoArbitro = repositorioArbitro;
        }
        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {
            bool creado = _repoArbitro.CrearArbitro(Arbitro);
            if (creado)
            {
                return RedirectToPage("./ArbIndex");
            }
            else
            {
                //viewData["repoMunicipio"] = creado;
                ViewData["Mensaje"] = "El arbitro ya se encuentra registrado";
                return Page();
            }
        }
    }
}
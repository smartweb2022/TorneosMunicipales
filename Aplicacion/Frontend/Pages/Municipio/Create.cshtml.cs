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
    public class CreateModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioMunicipio _repoMunicipio;
        //Propiedad para tarnsportar  al cshtml

        [BindProperty]
        public Municipio Municipio{get;set;}
        // Constructor
        public CreateModel(IRepositorioMunicipio repositorioMunicipio)
        {
            this._repoMunicipio = repositorioMunicipio;
        }
        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {
            bool creado = _repoMunicipio.CrearMunicipio(Municipio);
            if (creado)
            {
                return RedirectToPage("./MiIndex");
            }
            else
            {
                //viewData["repoMunicipio"] = creado;
                return Page();
            }
        }
    }
}

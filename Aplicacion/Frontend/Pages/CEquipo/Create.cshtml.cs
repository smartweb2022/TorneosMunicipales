using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CEquipo
{
    public class CreateModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioPatrocinador _repoPatrocinador;
        //Propiedad para tarnsportar  al cshtml

        [BindProperty]
        public Equipo Equipo{get;set;}
        public IEnumerable<Patrocinador> Patrocinadores{get;set;}

         // Constructor
        public CreateModel(IRepositorioEquipo repoEquipo, IRepositorioPatrocinador repoPatrocinador)
        {
            this._repoPatrocinador = repoPatrocinador;
            this._repoEquipo = repoEquipo;
        }
        
        public ActionResult OnGet()
        {
            Patrocinadores=_repoPatrocinador.ListarPatrocinadores();
            return Page();
        }
        public ActionResult OnPost()
        {
            bool creado = _repoEquipo.CrearEquipo(Equipo);
            if (creado)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                //viewData["repoMunicipio"] = creado;
                Patrocinadores=_repoPatrocinador.ListarPatrocinadores();
                ViewData["Mensaje"] = "El Entrenador ya se encuentra registrado";
                return Page();
            }
        }
    }
}

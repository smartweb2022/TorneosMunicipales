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
        private readonly IRepositorioEquipo _repoEquipo;
        //Propiedad para tarnsportar  al cshtml

        [BindProperty]
        public Entrenador Entrenador{get;set;}
        public IEnumerable<Equipo> Equipos{get;set;}
        // Constructor
        public EntrenadorCreateModel(IRepositorioEntrenador repositorioEntrenador, IRepositorioEquipo repoEquipo)
        {
            this._repoEntrenador = repositorioEntrenador;
            this._repoEquipo = repoEquipo;
        }
        public ActionResult OnGet()
        {
            Equipos=_repoEquipo.ListarEquipos();
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
                Equipos=_repoEquipo.ListarEquipos();
                ViewData["Mensaje"] = "El Entrenador ya se encuentra registrado";
                return Page();
            }
        }
    }
}

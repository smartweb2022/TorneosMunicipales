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
    public class EntrenadorDetailsModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEntrenador _repoEntrenador;
        private readonly IRepositorioEquipo _repoEquipo;
        
        //Constructor
        public EntrenadorDetailsModel(IRepositorioEntrenador repoEntrenador, IRepositorioEquipo repoEquipo){
            this._repoEntrenador=repoEntrenador;
            this._repoEquipo = repoEquipo;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Entrenador Entrenador{get;set;}
        public Equipo Equipo{get;set;}

        public ActionResult OnGet(int id)
        {
            Entrenador=_repoEntrenador.BuscarEntrenador(id);
            Equipo=_repoEquipo.BuscarEquipo(Entrenador.EquipoId);
            if(Entrenador!=null){                
                return Page();
            }
            else
            {
                return RedirectToPage("./EntrenadorIndex");
            }
        }
    }
}

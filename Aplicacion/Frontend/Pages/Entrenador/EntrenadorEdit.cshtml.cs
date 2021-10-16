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
    public class EntrenadorEditModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEntrenador _repoEntrenador;
        private readonly IRepositorioEquipo _repoEquipo;

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Entrenador Entrenador{get;set;}
        public IEnumerable<Equipo> Equipos{get;set;}
        public Equipo Equipo{get;set;}
        
        //Constructor
        public EntrenadorEditModel(IRepositorioEntrenador repoEntrenador, IRepositorioEquipo repoEquipo){
            this._repoEntrenador=repoEntrenador;
            this._repoEquipo = repoEquipo;
        }


        public ActionResult OnGet(int id)
        {
            Entrenador=_repoEntrenador.BuscarEntrenador(id);
            if(Entrenador!=null){
                Equipos=_repoEquipo.ListarEquipos();
                return Page();
            }
            else
            {
                return RedirectToPage("./EntrenadorIndex");
            }
            
        }

        public ActionResult OnPost(){            
            bool funciono = _repoEntrenador.ActualizarEntrenador(Entrenador);
            Equipos= _repoEquipo.ListarEquipos();
            if(funciono){
                return RedirectToPage("./EntrenadorIndex");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
  
        }
    }
}

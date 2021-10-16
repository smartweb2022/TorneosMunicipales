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
    public class EditEscenarioModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEscenario _repoEscenario;
        //private readonly IRepositorioEquipo _repoEquipo;

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Escenario Escenario{get;set;}
        //public IEnumerable<Equipo> Equipos{get;set;}
        public Equipo Equipo{get;set;}
        
        //Constructor
        public EditEscenarioModel(IRepositorioEscenario repoEscenario, IRepositorioEquipo repoEquipo){
            this._repoEscenario=repoEscenario;
            //this._repoEquipo = repoEquipo;
        }


        public ActionResult OnGet(int id)
        {
            Escenario=_repoEscenario.BuscarEscenario(id);
            if(Escenario!=null){
                //Equipos=_repoEquipo.ListarEquipos();
                return Page();
            }
            else
            {
                return RedirectToPage("./EscenarioIndex");
            }
            
        }

        public ActionResult OnPost(){            
            bool funciono = _repoEscenario.ActualizarEscenario(Escenario);
            //Equipos= _repoEquipo.ListarEquipos();
            if(funciono){
                return RedirectToPage("./EscenarioIndex");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
  
        }

    }
}

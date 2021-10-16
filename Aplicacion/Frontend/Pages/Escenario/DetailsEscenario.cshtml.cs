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
    public class DetailsEscenarioModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEscenario _repoEscenario;
        //private readonly IRepositorioEquipo _repoEquipo;
        
        //Constructor
        public DetailsEscenarioModel(IRepositorioEscenario repoEscenario){
            this._repoEscenario=repoEscenario;
            //this._repoEquipo = repoEquipo;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Escenario Escenario{get;set;}
        //public Equipo Equipo{get;set;}

        public ActionResult OnGet(int id)
        {
            Escenario=_repoEscenario.BuscarEscenario(id);
            //Equipo=_repoEquipo.BuscarEquipo(Escenario.EquipoId);
            if(Escenario!=null){                
                return Page();
            }
            else
            {
                return RedirectToPage("./EscenarioIndex");
            }
        }

    }
}

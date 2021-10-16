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
    public class DeleteEscenarioModel : PageModel
    {

        //Referenciar el repositorio
        private readonly IRepositorioEscenario repoEscenario;
        
        //Constructor
        
        public DeleteEscenarioModel(IRepositorioEscenario _repoEscenario){
            this.repoEscenario=_repoEscenario;
        }
        

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Escenario Escenario{get;set;}

        public ActionResult OnGet(int id)
        {
            ViewData["Mensaje2"]="¿Está seguro de eliminar el registro?";
            Escenario=repoEscenario.BuscarEscenario(id);
            return Page();
        }

        public ActionResult OnPost(){            
            bool funciono = repoEscenario.EliminarEscenario(Escenario.Id);
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

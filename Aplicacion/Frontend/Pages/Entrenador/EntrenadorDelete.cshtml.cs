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
    public class EntrenadorDeleteModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEntrenador repoEntrenador;
        
        //Constructor
        public EntrenadorDeleteModel(IRepositorioEntrenador _repoEntrenador){
            this.repoEntrenador=_repoEntrenador;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Entrenador Entrenador{get;set;}

        public ActionResult OnGet(int id)
        {
            ViewData["Mensaje2"]="¿Está seguro de eliminar el registro?";
            Entrenador=repoEntrenador.BuscarEntrenador(id);
            return Page();
        }

        public ActionResult OnPost(){            
            bool funciono = repoEntrenador.EliminarEntrenador(Entrenador.Id);
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

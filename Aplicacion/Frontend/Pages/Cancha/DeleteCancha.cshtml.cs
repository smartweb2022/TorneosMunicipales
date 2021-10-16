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
    public class DeleteCanchaModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioCancha repoCancha;
        
        //Constructor
        
        public DeleteCanchaModel(IRepositorioCancha _repoCancha){
            this.repoCancha=_repoCancha;
        }
        

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Cancha Cancha{get;set;}

        public ActionResult OnGet(int id)
        {
            ViewData["Mensaje2"]="¿Está seguro de eliminar el registro?";
            Cancha=repoCancha.BuscarCancha(id);
            return Page();
        }

        public ActionResult OnPost(){            
            bool funciono = repoCancha.EliminarCancha(Cancha.Id);
            if(funciono){
                return RedirectToPage("./CanchaIndex");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
              
        }

    }
}

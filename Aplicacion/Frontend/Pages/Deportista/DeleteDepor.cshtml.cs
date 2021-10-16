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
    public class DeleteDeporModel : PageModel
    {
        //Referenciar el rpositorio 
        private readonly IRepositorioDeportista repoDeportista;
        //Constructor
        public DeleteDeporModel(IRepositorioDeportista _repoDeportista)
        {
            this.repoDeportista = _repoDeportista;
        }
        //Propiedad para la comunicación con el cshtml
        [BindProperty]
        public Deportista Deportista{get;set;}
        public ActionResult OnGet(int id)
        {
            ViewData["Mesage2"]= "¿Seguro que desea eliminar el registro?";
            Deportista = repoDeportista.BuscarDeportista(id);
            return Page();
        }
        public ActionResult OnPost(){            
            bool funciono = repoDeportista.EliminarDeportista(Deportista.Id);
            if(funciono){
                return RedirectToPage("./IndexDepor");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
              
        }
    }
}

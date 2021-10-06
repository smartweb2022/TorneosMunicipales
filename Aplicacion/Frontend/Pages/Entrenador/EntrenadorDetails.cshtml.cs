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
        private readonly IRepositorioEntrenador repoEntrenador;
        
        //Constructor
        public EntrenadorDetailsModel(IRepositorioEntrenador _repoEntrenador){
            this.repoEntrenador=_repoEntrenador;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Entrenador Entrenador{get;set;}

        public ActionResult OnGet(int id)
        {
            Entrenador=repoEntrenador.BuscarEntrenador(id);
            return Page();
        }
    }
}

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
    public class EscArbEditModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEscuelaArbitro repoEscuelaArbitro;
        
        //Constructor
        public EscArbEditModel(IRepositorioEscuelaArbitro _repoEscuelaArbitro){
            this.repoEscuelaArbitro=_repoEscuelaArbitro;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public EscuelaArbitro EscuelaArbitro{get;set;}


        public ActionResult OnGet(int id)
        {
            EscuelaArbitro=repoEscuelaArbitro.BuscarEscuelaArbitro(id);
            return Page();
        }

        public ActionResult OnPost(){            
            bool funciono = repoEscuelaArbitro.ActualizarEscuelaArbitro(EscuelaArbitro);
            if(funciono){
                return RedirectToPage("./EscArbIndex");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
  
        }
    }
}

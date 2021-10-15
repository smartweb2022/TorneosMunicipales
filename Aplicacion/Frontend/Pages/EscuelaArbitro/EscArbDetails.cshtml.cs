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
    public class EscArbDetailsModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEscuelaArbitro repoEscuelaArbitro;
        
        //Constructor
        public EscArbDetailsModel(IRepositorioEscuelaArbitro _repoEscuelaArbitro){
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
    }
}

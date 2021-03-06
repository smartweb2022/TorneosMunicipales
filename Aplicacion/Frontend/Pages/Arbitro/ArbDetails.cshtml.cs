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
    public class ArbDetailsModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioArbitro repoArbitro;
        
        //Constructor
        public ArbDetailsModel(IRepositorioArbitro _repoArbitro){
            this.repoArbitro=_repoArbitro;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Arbitro Arbitro{get;set;}

        public ActionResult OnGet(int id)
        {
            Arbitro=repoArbitro.BuscarArbitro(id);
            return Page();
        }
    }
}

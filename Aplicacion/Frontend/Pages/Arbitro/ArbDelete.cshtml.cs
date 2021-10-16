<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend.Pages
{
    public class ArbDeleteModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
=======
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
    public class ArbDeleteModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioArbitro repoArbitro;
        
        //Constructor
        public ArbDeleteModel(IRepositorioArbitro _repoArbitro){
            this.repoArbitro=_repoArbitro;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Arbitro Arbitro{get;set;}

        public ActionResult OnGet(int id)
        {
            ViewData["Mensaje2"]="¿Está seguro de eliminar el registro?";
            Arbitro=repoArbitro.BuscarArbitro(id);
            return Page();
        }

        public ActionResult OnPost(){            
            bool funciono = repoArbitro.EliminarArbitro(Arbitro.Id);
            if(funciono){
                return RedirectToPage("./ArbIndex");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
              
        }
    }
}
>>>>>>> 7bc6be9045b1734bdfca64fb388802360600aa9b

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
    public class EditMuniModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioMunicipio repoMunicipio;
        
        //Constructor
        public EditMuniModel(IRepositorioMunicipio _repoMunicipio){
            this.repoMunicipio=_repoMunicipio;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Municipio Municipio{get;set;}

        public ActionResult OnGet(int id)
        {
            Municipio=repoMunicipio.BuscarMunicipio(id);
            return Page();
        }

        public ActionResult OnPost(){            
            bool funciono = repoMunicipio.ActualizarMunicipio(Municipio);
            if(funciono){
                return RedirectToPage("./MiIndex");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
              
        }
    }
}

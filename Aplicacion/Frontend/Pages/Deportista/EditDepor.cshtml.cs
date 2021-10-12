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
    public class EditDeporModel : PageModel
    {
        //Referencia al repositorio
        private readonly IRepositorioDeportista _repoDeportista;

        //Constructor
        public EditDeporModel(IRepositorioDeportista repoDeportista)
        {
            this._repoDeportista = repoDeportista;
        }
        //Porpiedad para la comunicacion con el cshtml
        [BindProperty]
        public Deportista Deportista{get; set; }

        public ActionResult OnGet(int id)
        {
            Deportista = _repoDeportista.BuscarDeportista(id);
            return Page();
        }
        public ActionResult OnPost()
        {            
            bool funciono = _repoDeportista.ActualizarDeportista(Deportista);
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

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
    public class DetailsDeporModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioDeportista repoDeportista;
        
        //Constructor
        public DetailsDeporModel(IRepositorioDeportista _repoDeportista)
        {
            this.repoDeportista = _repoDeportista;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Deportista Deportista{get;set;}

        public ActionResult OnGet(int id)
        {
            Deportista = repoDeportista.BuscarDeportista(id);
            return Page();
        }
    }
}
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
    public class DetailsCanchaModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioCancha _repoCancha;
        //private readonly IRepositorioEquipo _repoEquipo;
        
        //Constructor
        public DetailsCanchaModel(IRepositorioCancha repoCancha){
            this._repoCancha=repoCancha;
            //this._repoEquipo = repoEquipo;
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Cancha Cancha{get;set;}
        //public Equipo Equipo{get;set;}

        public ActionResult OnGet(int id)
        {
            Cancha=_repoCancha.BuscarCancha(id);
            //Equipo=_repoEquipo.BuscarEquipo(Cancha.EquipoId);
            if(Cancha!=null){                
                return Page();
            }
            else
            {
                return RedirectToPage("./CanchaIndex");
            }
        }
    }
}

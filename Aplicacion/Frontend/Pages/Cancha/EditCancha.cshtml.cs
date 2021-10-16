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
    public class EditCanchaModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioCancha _repoCancha;
        //private readonly IRepositorioEquipo _repoEquipo;

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Cancha Cancha{get;set;}
        //public IEnumerable<Equipo> Equipos{get;set;}
        public Equipo Equipo{get;set;}
        
        //Constructor
        public EditCanchaModel(IRepositorioCancha repoCancha, IRepositorioEquipo repoEquipo){
            this._repoCancha=repoCancha;
            //this._repoEquipo = repoEquipo;
        }


        public ActionResult OnGet(int id)
        {
            Cancha=_repoCancha.BuscarCancha(id);
            if(Cancha!=null){
                //Equipos=_repoEquipo.ListarEquipos();
                return Page();
            }
            else
            {
                return RedirectToPage("./CanchaIndex");
            }
            
        }

        public ActionResult OnPost(){            
            bool funciono = _repoCancha.ActualizarCancha(Cancha);
            //Equipos= _repoEquipo.ListarEquipos();
            if(funciono){
                return RedirectToPage("./CanchaIndex");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
  
        }

    }
}

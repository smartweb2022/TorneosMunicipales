using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CEquipo
{
    public class EditModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioPatrocinador _repoPatrocinador;

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Equipo Equipo{get;set;}
        public IEnumerable<Patrocinador> Patrocinadores{get;set;}
        public IEnumerable<Equipo> Equipos{get;set;}
        public Patrocinador Patrocinador{get;set;}
        
        //Constructor
        public EditModel(IRepositorioEquipo repoEquipo, IRepositorioPatrocinador repoPatrocinador){
            this._repoPatrocinador=repoPatrocinador;
            this._repoEquipo = repoEquipo;
        }

       public ActionResult OnGet(int id)
        {
            Equipo=_repoEquipo.BuscarEquipo(id);
            if(Equipo!=null){
                Patrocinadores=_repoPatrocinador.ListarPatrocinadores();
                return Page();
            }
            else
            {
                return RedirectToPage("./Index");
            }
            
        }

        public ActionResult OnPost(){            
            bool funciono = _repoEquipo.ActualizarEquipo(Equipo);
            Equipos= _repoEquipo.ListarEquipos();
            if(funciono){
                return RedirectToPage("./Index");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
  
        }
    }
}

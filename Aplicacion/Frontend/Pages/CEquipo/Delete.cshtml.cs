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
    public class DeleteModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioPatrocinador _repoPatrocinador;

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Equipo Equipo{get;set;}
        public Patrocinador Patrocinador{get;set;}

        //Constructor
        public DeleteModel(IRepositorioEquipo repoEquipo, IRepositorioPatrocinador repoPatrocinador){
            this._repoPatrocinador=repoPatrocinador;
            this._repoEquipo = repoEquipo;
        }

        public ActionResult OnGet(int id)
        {
            Equipo=_repoEquipo.BuscarEquipo(id);
            Patrocinador=_repoPatrocinador.BuscarPatrocinador(Equipo.PatrocinadorId);

            if(Equipo!=null){
                ViewData["Mensaje2"]="¿Está seguro de eliminar el registro?";
                return Page();
            }
            else
            {
                return RedirectToPage("./Index");
            }
            
        }

        public ActionResult OnPost(){            
            bool funciono = _repoEquipo.EliminarEquipo(Equipo.Id);
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

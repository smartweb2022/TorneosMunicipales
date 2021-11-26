<<<<<<< HEAD
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
    public class EntrenadorDeleteModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEntrenador _repoEntrenador;
        private readonly IRepositorioEquipo _repoEquipo;
        
        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Entrenador Entrenador{get;set;}
        public Equipo Equipo{get;set;}

        //Constructor
        public EntrenadorDeleteModel(IRepositorioEntrenador repoEntrenador, IRepositorioEquipo repoEquipo){
            this._repoEntrenador=repoEntrenador;
            this._repoEquipo = repoEquipo;
        }

        public ActionResult OnGet(int id)
        {
            
            Entrenador=_repoEntrenador.BuscarEntrenador(id);
            Equipo=_repoEquipo.BuscarEquipo(Entrenador.EquipoId);

            if(Entrenador!=null){
                ViewData["Mensaje2"]="¿Está seguro de eliminar el registro?";
                return Page();
            }
            else
            {
                return RedirectToPage("./EntrenadorIndex");
            }
            
        }

        public ActionResult OnPost(){            
            bool funciono = _repoEntrenador.EliminarEntrenador(Entrenador.Id);
            if(funciono){
                return RedirectToPage("./EntrenadorIndex");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                
                return Page();
            }
              
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
    public class EntrenadorDeleteModel : PageModel
    {
        //Referenciar el repositorio
        private readonly IRepositorioEntrenador _repoEntrenador;
        private readonly IRepositorioEquipo _repoEquipo;
        
        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Entrenador Entrenador{get;set;}
        public Equipo Equipo{get;set;}

        //Constructor
        public EntrenadorDeleteModel(IRepositorioEntrenador repoEntrenador, IRepositorioEquipo repoEquipo){
            this._repoEntrenador=repoEntrenador;
            this._repoEquipo = repoEquipo;
        }

        public ActionResult OnGet(int id)
        {
            
            Entrenador=_repoEntrenador.BuscarEntrenador(id);
            Equipo=_repoEquipo.BuscarEquipo(Entrenador.EquipoId);

            if(Entrenador!=null){
                ViewData["Mensaje2"]="¿Está seguro de eliminar el registro?";
                return Page();
            }
            else
            {
                return RedirectToPage("./EntrenadorIndex");
            }
            
        }

        public ActionResult OnPost(){            
            bool funciono = _repoEntrenador.EliminarEntrenador(Entrenador.Id);
            if(funciono){
                return RedirectToPage("./EntrenadorIndex");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                
                return Page();
            }
              
        }
    }
}
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360

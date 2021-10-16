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
    public class EditPatroModel : PageModel
    {
        //Referencia al repositorio
        private readonly IRepositorioPatrocinador _repoPatrocinador;

        //Constructor
        public EditPatroModel(IRepositorioPatrocinador repoPatrocinador)
        {
            this._repoPatrocinador = repoPatrocinador;
        }
        //Porpiedad para la comunicacion con el cshtml
        [BindProperty]
        public Patrocinador Patrocinador{get; set; }

        public ActionResult OnGet(int id)
        {
            Patrocinador = _repoPatrocinador.BuscarPatrocinador(id);
            return Page();
        }
        public ActionResult OnPost()
        {            
            bool funciono = _repoPatrocinador.ActualizarPatrocinador(Patrocinador);
            if(funciono){
                return RedirectToPage("./IndexPatro");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
              
        }
    }
}

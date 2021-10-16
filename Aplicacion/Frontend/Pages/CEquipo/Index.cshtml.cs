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
    public class IndexModel : PageModel
    {
        //Crear un objeto para uso de los repositorios
        private readonly IRepositorioEquipo _repoEquipo;        

        //Modelo u objeto para transportar 
        public IEnumerable<Equipo> Equipos {get; set; }
        
        //Constructor
        public IndexModel(IRepositorioEquipo repoEquipo)
        {
            this._repoEquipo = repoEquipo;
            
        }

        public void OnGet()
        {
            Equipos = _repoEquipo.ListarEquipos();
        }
    }
}

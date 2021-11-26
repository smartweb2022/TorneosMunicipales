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
    public class EscenarioIndexModel : PageModel
    {
        private readonly IRepositorioEscenario _repoEscenario;

        //Modelo u objeto para transportar hacia EscenarioIndex 
        public IEnumerable<Escenario> Escenarios {get; set; }

        //Constructor
         public EscenarioIndexModel(IRepositorioEscenario repoEscenario)
        {
            this._repoEscenario = repoEscenario;
        }

        
        public void OnGet()
        {
            Escenarios = _repoEscenario.ListarEscenarios();
        }
    }
}

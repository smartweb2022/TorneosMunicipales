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
    public class EscArbIndexModel : PageModel
    {
        //Crear un objeto para uso de los repositorios
        private readonly IRepositorioEscuelaArbitro _repoEscuelaArbitro;

        //Modelo u objeto para transportar hacia EscuelaArbitroIndex 
        public IEnumerable<EscuelaArbitro> EscuelaArbitros {get; set; }

        //Constructor
        public EscArbIndexModel(IRepositorioEscuelaArbitro repoEscuelaArbitro)
        {
            this._repoEscuelaArbitro = repoEscuelaArbitro;
        }

        public void OnGet()
        {
            EscuelaArbitros = _repoEscuelaArbitro.ListarEscuelaArbitros();
        }
    }
}

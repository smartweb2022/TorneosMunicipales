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
    public class ArbIndexModel : PageModel
    {
        //Crear un objeto para uso de los repositorios
        private readonly IRepositorioArbitro _repoArbitro;

        //Modelo u objeto para transportar hacia ArbIndex 
        public IEnumerable<Arbitro> Arbitros {get; set; }

        //Constructor
        public ArbIndexModel(IRepositorioArbitro repoArbitro)
        {
            this._repoArbitro = repoArbitro;
        }

        public void OnGet()
        {
            Arbitros = _repoArbitro.ListarArbitros();
        }
    }
}

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
    public class TIndexModel : PageModel
    {
        //Crear un objeto para el uso de los repositorios
        private readonly IRepositorioTorneo _repoTorneo;
        //Modelo u objeto para transportar hacia TIndex
        public IEnumerable<Torneo> Torneos {get; set;}
        //Cosntructor
        public TIndexModel (IRepositorioTorneo repoTorneo)
        {
            this._repoTorneo= repoTorneo;
        }
        public void OnGet()
        {
            Torneos = _repoTorneo.ListarTorneos();
        }
    }
}

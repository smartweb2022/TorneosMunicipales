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
    public class EntrenadorIndexModel : PageModel
    {
        //Crear un objeto para uso de los repositorios
        private readonly IRepositorioEntrenador _repoEntrenador;

        //Modelo u objeto para transportar hacia EntrenadorIndex 
        public IEnumerable<Entrenador> Entrenadores {get; set; }

        //Constructor
        public EntrenadorIndexModel(IRepositorioEntrenador repoEntrenador)
        {
            this._repoEntrenador = repoEntrenador;
        }

        public void OnGet()
        {
            Entrenadores = _repoEntrenador.ListarEntrenadores();
        }
    }
}

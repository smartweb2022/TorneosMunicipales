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
    public class CanchaIndexModel : PageModel
    {
        //Crear un objeto para uso de los repositorios
        private readonly IRepositorioCancha _repoCancha;

        //Modelo u objeto para transportar hacia CanchaIndex 
        public IEnumerable<Cancha> Canchas {get; set; }

        //Constructor
         public CanchaIndexModel(IRepositorioCancha repoCancha)
        {
            this._repoCancha = repoCancha;
        }

        
        public void OnGet()
        {
            Canchas = _repoCancha.ListarCanchas();
        }
    }
}

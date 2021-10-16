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
    public class IndexPatroModel : PageModel
    {
        //Crear un objeto para uso de los repositorios
        private readonly IRepositorioPatrocinador _repoPatrocinador;

        //Modelo u objeto para transportar hacia Mindex 
        public IEnumerable<Patrocinador> Patrocinadores {get; set; }

        //Constructor
        public IndexPatroModel(IRepositorioPatrocinador repoPatrocinador)
        {
            this._repoPatrocinador = repoPatrocinador;
        }

        public void OnGet()
        {
            Patrocinadores = _repoPatrocinador.ListarPatrocinadores();
        }
    }
}

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
    public class IndexDeporModel : PageModel
    {
        //Crear un objeto para uso de los repositorios
        private readonly IRepositorioDeportista _repoDeportista;

        //Modelo u objeto para transportar hacia IndexDepor 
        public IEnumerable<Deportista> Deportistas {get; set;}

        //Constructor
        public IndexDeporModel(IRepositorioDeportista repoDeportista)
        {
            this._repoDeportista = repoDeportista;
        }

        public void OnGet()
        {
            Deportistas = _repoDeportista.ListarDeportistas();
        }
    }
}

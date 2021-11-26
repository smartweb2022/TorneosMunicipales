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
    public class MiIndexModel : PageModel
    {
        //Crear un objeto para uso de los repositorios
        private readonly IRepositorioMunicipio _repoMunicipio;

        //Modelo u objeto para transportar hacia Mindex 
        public IEnumerable<Municipio> Municipios {get; set; }

        //Constructor
        public MiIndexModel(IRepositorioMunicipio repoMunicipio)
        {
            this._repoMunicipio = repoMunicipio;
        }

        public void OnGet()
        {
            Municipios = _repoMunicipio.ListarMunicipios();
        }
    }
}

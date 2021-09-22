using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioMunicipio
    {
        //Metodos CRUD para clase Municipio
        IEnumerable<Municipio> ListarMunicipios();
        bool CrearMunicipio(Municipio municipio);
        bool ActualizarMunicipio (Municipio municipio);
        bool EliminarMunicipio (int idMunicipio);
        Municipio BuscarMunicipio(int idMunicipio);
    }

}
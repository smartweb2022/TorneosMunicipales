using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioDeportista
    {
        //Metodos CRUD para clase Deportista
        IEnumerable<Deportista> ListarDeportistas();
        bool CrearDeportista (Deportista deportista);
        bool ActualizarDeportista (Deportista deportista);
        bool EliminarDeportista (int idDeportista);
        Deportista BuscarDeportista(int idDeportista);
    }

}

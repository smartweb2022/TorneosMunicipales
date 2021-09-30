using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioTorneoEquipo
    {
        //Metodos CRUD para clase TorneoEquipo
        IEnumerable<TorneoEquipo> ListarTorneosEquipos();
        bool CrearTorneoEquipo (TorneoEquipo torneoequipo);
        bool ActualizarTorneoEquipo (TorneoEquipo torneoequipo);
        bool EliminarTorneoEquipo (int idTorneoEquipo);
        TorneoEquipo BuscarTorneoEquipo(int idTorneoEquipo);
    }

}

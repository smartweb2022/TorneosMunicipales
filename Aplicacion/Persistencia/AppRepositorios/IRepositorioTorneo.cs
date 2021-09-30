using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioTorneo
    {
        //Metodos CRUD para clase Torneo
        IEnumerable<Torneo> ListarTorneos();
        bool CrearTorneo (Torneo torneo);
        bool ActualizarTorneo (Escenario escenarios);
        bool EliminarTorneo (int idTorneo);
        Torneo BuscarTorneo(int idTorneo);
    }

}

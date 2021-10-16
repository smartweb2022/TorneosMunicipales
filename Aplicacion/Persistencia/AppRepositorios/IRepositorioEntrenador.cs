using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEntrenador
    {
        //Metodos CRUD para clase Entrenador
        IEnumerable<Entrenador> ListarEntrenadores();
        bool CrearEntrenador(Entrenador entrenador);
        bool ActualizarEntrenador (Entrenador entrenador);
        bool EliminarEntrenador (int idEntrenador);
        Entrenador BuscarEntrenador(int idEntrenador);
    }

}
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioPatrocinador
    {
        IEnumerable<Patrocinador> ListarEntrenador();
        bool CrearEntrenador(Entrenador entrenador);
        bool ActualizarEntrenador (Entrenador entrenador);
        bool EliminarEntrenador (int idEntrenador);
        Entrenador BuscarEntrenador(int idEntrenador);
    }

}
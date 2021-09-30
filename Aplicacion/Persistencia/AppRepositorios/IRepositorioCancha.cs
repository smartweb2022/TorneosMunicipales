using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioCancha
    {
        //Metodos CRUD para clase Cancha
        IEnumerable<Cancha> ListarCanchas();
        bool CrearCancha (Cancha cancha);
        bool ActualizarCancha (Cancha cancha);
        bool EliminarCancha (int idCancha);
        Arbitro BuscarCancha(int idCancha);
    }

}

using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEcuelaArbitro
    {
        
        //Metodos CRUD para clase EscuelaArbitro
        IEnumerable<EscuelaArbitro> ListarEscuelaArbitros();
        bool CrearEscuelaArbitro (EscuelaArbitro escuelaArbitro);
        bool ActualizarEscuelaArbitro (EscuelaArbitro escuelaArbitro);
        bool EliminarEscuelaArbitro (int idEscuelaArbitro);
        EscuelaArbitro BuscarEscuelaArbitro (int idEscuelaArbitro);
    }

}
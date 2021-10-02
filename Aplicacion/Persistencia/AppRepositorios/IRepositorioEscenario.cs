    using System.Collections.Generic;
    using Dominio;

    namespace Persistencia
    {
        public interface IRepositorioEscenario
        {
            //Metodos CRUD para clase Escenario
            IEnumerable<Escenario> ListarEscenarios();
            bool CrearEscenario (Escenario escenario);
            bool ActualizarEscenario (Escenario escenario);
            bool EliminarEscenario (int idEscenario);
            Escenario BuscarEscenario(int idEscenario);
        }

    }

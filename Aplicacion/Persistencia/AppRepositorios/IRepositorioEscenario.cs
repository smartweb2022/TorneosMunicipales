    using System.Collections.Generic;
    using Dominio;

    namespace Persistencia
    {
        public interface IRepositorioEscenario
        {
            //Metodos CRUD para clase Escenario
            IEnumerable<Escenario> ListarEscenarios();
            bool CrearEscenario (Escenario escenarios);
            bool ActualizarEscenario (Escenario escenarios);
            bool EliminarEscenario (int idEscenario);
            Escenario BuscarEscenario(int idEscenario);
        }

    }

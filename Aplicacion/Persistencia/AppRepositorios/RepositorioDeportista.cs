using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioDeportista:IRepositorioDeportista
    {
        // Deportistas
        private readonly AppContext _appContext;

        //Metodos
        //Constructor
        public RepositorioDeportista(AppContext appContext)
        {
            _appContext=appContext;
        }
        //implementar todos los metodos de la interfaz IRepositorioDeportista

        bool IRepositorioDeportista.CrearDeportista(Deportista deportista)
        {
           bool creado=false;
           try
           {
                _appContext.Deportistas.Add(deportista);
                _appContext.SaveChanges();
                creado=true;
           }
           catch (System.Exception)
           {
               return creado;
                //throw;
           }
           return creado;
        }
        bool IRepositorioDeportista.ActualizarDeportista(Deportista deportista)
        {
            bool actualizado = false;
            var deport = _appContext.Deportistas.Find(deportista.Id);
            if(deport != null)
            {
                try 
                {
                    deport.Documento = deportista.Documento;
                    deport.Nombre = deportista.Nombre;
                    deport.Apellidos = deportista.Apellidos;
                    deport.Genero = deportista.Genero;
                    deport.Rh = deportista.Rh;
                    deport.EPS = deportista.EPS;
                    deport.FechaNacimiento = deportista.FechaNacimiento;
                    deport.Disciplina = deportista.Disciplina;
                    deport.Direccion = deportista.Direccion;
                    deport.NumeroEmergencia = deportista.NumeroEmergencia;
                    deport.EquipoId = deportista.EquipoId;
                    _appContext.SaveChanges();
                    actualizado = true;
                }
                catch(System.Exception )
                {
                    return actualizado;
                }
            }
            return actualizado;
        }
        bool IRepositorioDeportista.EliminarDeportista(int idDeportista)
        {
            bool eliminado= false;
            var deportista =_appContext.Deportistas.Find(idDeportista);
            if(deportista != null)
            {
                try
                {
                     _appContext.Deportistas.Remove(deportista);
                     _appContext.SaveChanges();
                     eliminado=true;
                }
                catch (System.Exception)
                {                    
                    return eliminado;
                }
            }
            return eliminado;
        }
        Deportista IRepositorioDeportista.BuscarDeportista(int idDeportista)
        {
            Deportista deportista = _appContext.Deportistas.Find(idDeportista);
            return deportista;
        }

        IEnumerable<Deportista> IRepositorioDeportista.ListarDeportistas()
        {
            return _appContext.Deportistas;
        }

    }
}
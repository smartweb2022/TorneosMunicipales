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
        public RepositorioDepostista(AppContext appContext)
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
        bool IRepositorioDepostista.ActualizarDeportista(Deportista deportista)
        {
            bool actualizado = false;
            var deport = _appContext.Deportistas.Find(deportista.Id);
            if(deport != null)
            {
                try 
                {
                    deport.Nombre = deportista.Nombre;
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
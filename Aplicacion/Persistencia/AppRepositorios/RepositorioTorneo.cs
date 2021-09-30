using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioTorneo:IRepositorioTorneo
    {
        // Torneos
        private readonly AppContext _appContext;

        //Metodos
        //Constructor
        public RepositorioTorneo(AppContext appContext)
        {
            _appContext=appContext;
        }
        //implementar todos los metodos de la interfaz IRepositorioTorneo

        bool IRepositorioTorneo.CrearTorneo(Torneo torneo)
        {
           bool creado=false;
           try
           {
                _appContext.Torneos.Add(torneo);
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
        bool IRepositorioTorneo.ActualizarTorneo(Torneo torneo)
        {
            bool actualizado = false;
            var torn = _appContext.Torneos.Find(torneo.Id);
            if(torn != null)
            {
                try 
                {
                    torn.Nombre = torneo.Nombre;
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
        bool IRepositorioTorneo.EliminarTorneo(int idTorneo)
        {
            bool eliminado= false;
            var torneo =_appContext.Torneos.Find(idTorneo);
            if(torneo != null)
            {
                try
                {
                     _appContext.Torneos.Remove(torneo);
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
        Torneo IRepositorioTorneo.BuscarTorneo(int idTorneo)
        {
            Torneo torneo = _appContext.Torneos.Find(idTorneo);
            return torneo;
        }

        IEnumerable<Torneo> IRepositorioTorneo.ListarTorneos()
        {
            return _appContext.Torneos;
        }

    }
}
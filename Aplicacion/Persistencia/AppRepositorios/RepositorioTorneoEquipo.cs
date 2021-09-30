using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioTorneoEquipo:IRepositorioTorneoEquipo
    {
        // TorneoEquipo
        private readonly AppContext _appContext;

        //Metodos
        //Constructor
        public RepositorioTorneoEquipo(AppContext appContext)
        {
            _appContext=appContext;
        }
        //implementar todos los metodos de la interfaz IRepositorioTorneoEquipo

        bool IRepositorioTorneoEquipo.CrearTorneoEquipo(TorneoEquipo torneoequipo)
        {
           bool creado=false;
           try
           {
                _appContext.TorneosEquipos.Add(torneoequipo);
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
        bool IRepositorioTorneoEquipo.ActualizarTorneoEquipo(TorneoEquipo torneoequipo)
        {
            bool actualizado = false;
            var torequi = _appContext.TorneosEquipos.Find(torneoequipo.Id);
            if(torequi != null)
            {
                try 
                {
                    torequi.Nombre = torneoequipo.Nombre;
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
        bool IRepositorioTorneoEquipo.EliminarTorneoEquipo(int idTorneoEquipo)
        {
            bool eliminado= false;
            var torneoequipo =_appContext.TorneosEquipos.Find(idTorneoEquipo);
            if(torneoequipo != null)
            {
                try
                {
                     _appContext.TorneosEquipos.Remove(torneoequipo);
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
        TorneoEquipo IRepositorioTorneoEquipo.BuscarTorneoEquipo(int idTorneoEquipo)
        {
            TorneoEquipo torneoequipo = _appContext.TorneosEquipos.Find(idTorneoEquipo);
            return torneoequipo;
        }

        IEnumerable<TorneoEquipo> IRepositorioTorneoEquipo.ListarTorneosEquipos()
        {
            return _appContext.TorneosEquipos;
        }

    }
}
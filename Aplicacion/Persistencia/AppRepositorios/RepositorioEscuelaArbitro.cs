using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEscuelaArbitro:IRepositorioEscuelaArbitro
    {
        // Atributos
        private readonly AppContext _appContext;

        //Metodos
        //Constructor
        public RepositorioEscuelaArbitro (AppContext appContext)
        {
            _appContext=appContext;
        }
        //implementar todos los metodos de la interfaz IRepositorioEscuelaArbitro

        bool IRepositorioEscuelaArbitro.CrearEscuelaArbitro(EscuelaArbitro escuelaArbitro)
        {
           bool creado=false;
           try
           {
                _appContext.EscuelaArbitros.Add(escuelaArbitro);
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
        bool IRepositorioEscuelaArbitro.ActualizarEscuelaArbitro(EscuelaArbitro escuelaArbitro)
        {
            bool actualizado = false;
            var esAr = _appContext.EscuelaArbitros.Find(escuelaArbitro.Id);
            if(esAr != null)
            {
                try 
                {
                    esAr.Nombre = escuelaArbitro.Nombre;
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
        bool IRepositorioEscuelaArbitro.EliminarEscuelaArbitro(int idEscuelaArbitro)
        {
            bool eliminado = false;
            var escuelaArbitro = _appContext.EscuelaArbitros.Find(idEscuelaArbitro);
            if(escuelaArbitro != null)
            {
                try
                {
                     _appContext.EscuelaArbitros.Remove(escuelaArbitro);
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
        EscuelaArbitro IRepositorioEscuelaArbitro.BuscarEscuelaArbitro(int idEscuelaArbitro)
        {
            EscuelaArbitro escuelaArbitro = _appContext.EscuelaArbitros.Find(idEscuelaArbitro);
            return escuelaArbitro;
        }

        IEnumerable<EscuelaArbitro> IRepositorioEscuelaArbitro.ListarEscuelaArbitros()
        {
            return _appContext.EscuelaArbitros;
        }

    }
}
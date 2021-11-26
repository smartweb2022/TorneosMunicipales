using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioArbitro:IRepositorioArbitro
    {
        // Atributos
        private readonly AppContext _appContext;

        //Metodos
        //Constructor
        public RepositorioArbitro(AppContext appContext)
        {
            _appContext=appContext;
        }
        //implementar todos los metodos de la interfaz IRepositorioArbitro

        bool IRepositorioArbitro.CrearArbitro(Arbitro arbitro)
        {
           bool creado=false;
           try
           {
                _appContext.Arbitros.Add(arbitro);
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
        bool IRepositorioArbitro.ActualizarArbitro(Arbitro arbitro)
        {
            bool actualizado = false;
            var arbi = _appContext.Arbitros.Find(arbitro.Id);
            if(arbi != null)
            {
                try 
                {
                    arbi.Nombre = arbitro.Nombre;
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
        bool IRepositorioArbitro.EliminarArbitro(int idArbitro)
        {
            bool eliminado= false;
            var arbitro =_appContext.Arbitros.Find(idArbitro);
            if(arbitro != null)
            {
                try
                {
                     _appContext.Arbitros.Remove(arbitro);
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
        Arbitro IRepositorioArbitro.BuscarArbitro(int idArbitro)
        {
            Arbitro arbitro = _appContext.Arbitros.Find(idArbitro);
            return arbitro;
        }

        IEnumerable<Arbitro> IRepositorioArbitro.ListarArbitros()
        {
            return _appContext.Arbitros;
        }

    }
}
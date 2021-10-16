<<<<<<< HEAD
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioPatrocinador:IRepositorioPatrocinador
    {
        // Atributos
        private readonly AppContext _appContext;

        //Metodos
        //Constructor
        public RepositorioPatrocinador(AppContext appContext)
        {
            _appContext=appContext;
        }
        //implementar todos los metodos de la interfaz IRepositorioPatrocinador

        bool IRepositorioPatrocinador.CrearPatrocinador(Patrocinador patrocinador)
        {
           bool creado=false;
           try
           {
                _appContext.Patrocinadores.Add(patrocinador);
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
        bool IRepositorioPatrocinador.ActualizarPatrocinador(Patrocinador patrocinador)
        {
            bool actualizado = false;
            var patro = _appContext.Patrocinadores.Find(patrocinador.Id);
            if(patro != null)
            {
                try 
                {
                    patro.Nombre = patrocinador.Nombre;
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
        bool IRepositorioPatrocinador.EliminarPatrocinador(int idPatrocinador)
        {
            bool eliminado= false;
            var patrocinador =_appContext.Patrocinadores.Find(idPatrocinador);
            if(patrocinador != null)
            {
                try
                {
                     _appContext.Patrocinadores.Remove(patrocinador);
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
        Patrocinador IRepositorioPatrocinador.BuscarPatrocinador(int idPatrocinador)
        {
            Patrocinador patrocinador = _appContext.Patrocinadores.Find(idPatrocinador);
            return patrocinador;
        }

        IEnumerable<Patrocinador> IRepositorioPatrocinador.ListarPatrocinadores()
        {
            return _appContext.Patrocinadores;
        }

    }
=======
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioPatrocinador:IRepositorioPatrocinador
    {
        // Atributos
        private readonly AppContext _appContext;

        //Metodos
        //Constructor
        public RepositorioPatrocinador(AppContext appContext)
        {
            _appContext=appContext;
        }
        //implementar todos los metodos de la interfaz IRepositorioPatrocinador

        bool IRepositorioPatrocinador.CrearPatrocinador(Patrocinador patrocinador)
        {
           bool creado=false;
           try
           {
                _appContext.Patrocinadores.Add(patrocinador);
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
        bool IRepositorioPatrocinador.ActualizarPatrocinador(Patrocinador patrocinador)
        {
            bool actualizado = false;
            var patro = _appContext.Patrocinadores.Find(patrocinador.Id);
            if(patro != null)
            {
                try 
                {
                    patro.Identificacion = patrocinador.Identificacion;
                    patro.Nombre = patrocinador.Nombre;
                    patro.TipoPersona = patrocinador.TipoPersona;
                    patro.Direccion = patrocinador.Direccion;
                    patro.Telefono = patrocinador.Telefono;
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
        bool IRepositorioPatrocinador.EliminarPatrocinador(int idPatrocinador)
        {
            bool eliminado= false;
            var patrocinador =_appContext.Patrocinadores.Find(idPatrocinador);
            if(patrocinador != null)
            {
                try
                {
                     _appContext.Patrocinadores.Remove(patrocinador);
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
        Patrocinador IRepositorioPatrocinador.BuscarPatrocinador(int idPatrocinador)
        {
            Patrocinador patrocinador = _appContext.Patrocinadores.Find(idPatrocinador);
            return patrocinador;
        }

        IEnumerable<Patrocinador> IRepositorioPatrocinador.ListarPatrocinadores()
        {
            return _appContext.Patrocinadores;
        }

    }
>>>>>>> 7bc6be9045b1734bdfca64fb388802360600aa9b
}
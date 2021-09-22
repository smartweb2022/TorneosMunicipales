using System;
using Dominio;
using Persistencia;
using System.Collections.Generic;


namespace Consola
{
    class Program

    {
        private static IRepositorioMunicipio _repomunicipio = new RepositorioMunicipio(new Persistencia.AppContext());
        private static IRepositorioEntrenador _repoentrenador = new RepositorioEntrenador(new Persistencia.AppContext());
        private static IRepositorioEquipo _repoequipo = new RepositorioEquipo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            bool funciono1 = crearEquipo();
            if (funciono1)
            {
                 Console.WriteLine("Equipo adicionado con exito");
            }
            else
            {
                Console.WriteLine("Se presento una falla");   
            }
            /*bool funciono = crearEntrenador();
            if (funciono)
            {
                 Console.WriteLine("Entrenador adicionado con exito");
            }
            else
            {
                Console.WriteLine("Se presento una falla");   
            }
            bool funciono2 = crearMunicipio();
            if (funciono2)
            {
                 Console.WriteLine("Municipio adicionado con exito");
            }
            else
            {
                Console.WriteLine("Se presento una falla");   
            }
            bool f=eliminarMunicipio();
            if(f)
            {
                Console.WriteLine("Municipio eliminado con exito");
            }
            else
            {
                 Console.WriteLine("Se ha presentado una falla en el proceso...");
            }
            bool f= actualizarMunicipios();
            if(f)
            {
                Console.WriteLine("Lista actualizada");
            }
            else
            {
                Console.WriteLine("Error al intentar actualizar");
            }             
            Console.WriteLine("Lista actualizada");*/

            listarMunicipios();
            //buscarMunicipio();
        }
        //Metodo para crear un equipo
        private static bool crearEquipo()
        {
            var equipo = new Equipo
            {
               
                Nombre = "Santa Fe",
                CantidadDeportistas = 11,
                Disciplina = "Futbol"
            };
            bool funciono = _repoequipo.CrearEquipo(equipo);
            Console.WriteLine("Valor de la funcion equipo: "+funciono);
            return funciono;
        }
        //Metodo para crear un objeto de la clase entrenador
        private static bool crearEntrenador()
        {
            try
            {
                var entrenador = new Entrenador
            {
                Documento = "123",
                Nombres = "Juan ",
                Apellidos = "Galindo",
                Genero = "Masculino",
                DisciplinaDeportiva = "Futbol",
                EquipoId = 1
            };
                bool funciono = _repoentrenador.CrearEntrenador(entrenador);
                Console.WriteLine("Valor de funcion entrenador: "+funciono);
                return funciono;

            }catch(Exception e)
            {
                Console.WriteLine("Error: "+e);
            }
            return true;   
        }
        
        private static bool crearMunicipio()
        {
            var municipio= new Municipio
            {
               
                Nombre="Barranquilla"
            };
            bool funciono = _repomunicipio.CrearMunicipio(municipio);
            Console.WriteLine("Valor de funcion: "+funciono);
            return funciono;
        }
        private static void listarMunicipios()
        {
            IEnumerable<Municipio> municipios = _repomunicipio.ListarMunicipios();
            foreach (var num in municipios) 
            {
                Console.WriteLine(num.Id +" "+num.Nombre);
            }
        }
        private static bool eliminarMunicipio()
        {
            bool funciono = _repomunicipio.EliminarMunicipio(4);
            return funciono;
        }
        private static bool actualizarMunicipio()
        {
            var municipio = new Municipio()
            {
                Id = 1,
                Nombre = "Cali"
            };
            bool funciono= _repomunicipio.ActualizarMunicipio(municipio);
            return funciono;
        }
        private static void buscarMunicipio()
        {
            var mun = _repomunicipio.BuscarMunicipio(2);
            if(mun !=null)
            {
                Console.WriteLine(mun.Id);
                Console.WriteLine(mun.Nombre);
            }
            else
            {
                Console.WriteLine("Municipio no encontrado");
            }
        }
    }   
}

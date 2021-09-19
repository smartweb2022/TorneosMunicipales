//Importar las libreriar a ser usadadas
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class EscuelaArbitro
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Resolucion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        
        //Propiedad navegacional con la tabla Arbitro
        public List<Arbitro> Arbitros { get; set; }


    }
}
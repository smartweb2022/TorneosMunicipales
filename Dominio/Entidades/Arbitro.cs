//Importacion de las librerias a usar
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Arbitro
    {
        public int Id{ get; set; }
        public string Identificacion{ get; set; }
        public string Nombre{ get; set; }
        public string Apellidos{ get; set; }
        public string Telefono{ get; set; }
        public string Correo{ get; set; }
        public string Disiplina{ get; set; }

        //Llave foranea con referencia a la tabla Torneo
        public int TorneoId{ get; set; }
        //Llave foranea con referencia a la tabla EscuelaArbitro
        public int EscuelaArbitroId{ get; set; }
        

    }

}

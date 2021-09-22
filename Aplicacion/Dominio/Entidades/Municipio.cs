// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Municipio
    {
        
        //Atributos de la clase Municipio
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Capital{get;set;}
        // propiedad navigacional con la tabla Torneo
        public List<Torneo> Torneos {get;set;}

    }
}
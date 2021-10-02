// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class TorneoEquipo
    {
        public int Id{get;set;}
        // llave principa compuesta por los dos campos ID
        public int IdTorneo{get;set;}
        public int IdEquipo{get;set;}
        // propiedad navigacional a Torneo
        public Torneo Torneo {get;set;} 
        // propiedad navigacional a Equipo
        public Equipo Equipo {get;set;} 
    }
}
// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Escenario
    {
        
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Horario{get;set;}
        //llave forane para la relacion con Torneo
        public int TorneoId{get;set;}

    }
}
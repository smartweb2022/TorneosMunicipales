// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Cancha
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Diciplina{get;set;}
        public string Estado{get;set;}
        public int Capacidad{get;set;}
        public double Medidas{get;set;}

        //llave forane para la relacion con Escenario
        public int EscenarioId{get;set;}

    }
}
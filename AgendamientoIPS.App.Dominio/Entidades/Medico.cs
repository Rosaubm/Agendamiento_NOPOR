using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Medico : Persona
    {
        public string TarjetaProfesional {get;set;} // Número de tarjeta profesional (único), se trabaja en string
        public string Especialidad {get;set;} // Nombre de la especialidad medica del Médico 
    }
} 
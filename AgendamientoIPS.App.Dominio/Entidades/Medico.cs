using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Medico : Persona
    {
        public int IdSede {get;set;} // ID del Médico
        public string Especialidad {get;set;} // Nombre de la especialidad medica del Médico 
        public string TipodeAtencion {get;set;} // TipodeAtencion del Médico 
        public DateTime AgendaAsignada {get;set;} // Fecha de la cita asignada al Médico 
    }
} 
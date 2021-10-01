using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;} // Identificación de clase Persona 
        public string Nombre {get;set;} // Nombre de Persona
        public string PrimerApellido {get;set;} // Primer Apellido de Persona
        public string SegundoApellido {get;set;} // Segundo Apellido de Persona
        public string Direccion {get;set;} // Dirección de Persona
        public string Telefono {get;set;} // Teléfono de Persona
        public string Correo {get;set;} // Correo de Persona
        public EPS EPS {get;set;} // EPS de Persona
    }
} 
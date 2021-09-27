using System;

namespace AgendamientoIPS.App.Dominio
{
    public class IPSSaludIntegral
    {
        public string NIT {get;set;} // NIT de IPS
        public string NombreIPS {get;set;} // Nombre de IPS
        public string DireccionIPS {get;set;} // Dirección de IPS
        public string BasedePacientes {get;set;} // Base de Pacientes de IPS
        public string BasedeMedicos {get;set;} // Base de Médicos de IPS
        public int Tarifas {get;set;} // Tarifas de IPS
        public DateTime Horarios {get;set;} // Horarios de IPS
        public string Agendas {get;set;} // Agendas de IPS
    }
} 
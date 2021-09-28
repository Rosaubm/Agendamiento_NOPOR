using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Citas : Sedes
    {
        public Boolean Presencial {get;set;} // Cita Presencial si o no 
        public Boolean Virtual {get;set;} // Cita Virtual si o no 
        public DateTime HorarioCita {get;set;} // Horario de Cita
        public Boolean Programación {get;set;} // Cita Programada si o no 
        public Boolean Cancelacion {get;set;} // Cita Cancelada si o no 
        public Paciente Paciente {get;set;} // Información necesaria del paciente en la cita (Composición)
        public Medico Medico {get;set;} // Información necesaria del Médico que atiende al paciente (Composición)
        public FacturacionConsulta FacturacionConsulta {get;set;} // Información sobre la facturación por el tipo de atención al paciente (EPS o no EPS) (Composición)
    }
} 
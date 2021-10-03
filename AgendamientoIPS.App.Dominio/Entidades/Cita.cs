using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Cita
    {
        public int Id {get;set;} // Identificación de clase Cita
        public TipoCita TipoCita {get;set;} // Cita Presencial o Virtual
        public int NumCita {get;set;} // Número de Cita a nivel sistema
        public string Especialidad {get;set;} // Especialidad de la cita pedida por el paciente
        public TimeSpan Hora {get;set;} // Hora de la Cita
        public DateTime Fecha {get;set;} // Fecha de la Cita
        public Medico IdMedico {get;set;} // Id del médico asignado
        public Paciente IdPaciente {get;set;} // Id del paciente
        public int Ubicacion {get;set;} // Ubicación de la Cita
    }
} 
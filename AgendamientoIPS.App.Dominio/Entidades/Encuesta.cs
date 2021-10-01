using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Encuesta
    {
        public int Id {get;set;} // Identificación de clase Encuesta
        public string AntecedentesMedicos {get;set;} // Antecedentes médicos del Paciente 
        public MotivoConsulta MotivoConsulta {get;set;} // Motivo de consulta del Paciente
        public string Observaciones {get;set;} // Observaciones del Paciente
    }
}
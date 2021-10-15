using System;
using System.ComponentModel.DataAnnotations;


namespace AgendamientoIPS.App.Dominio
{
    public class Encuesta
    {
        public int Id {get;set;} // Identificación de clase Encuesta
        [Required(ErrorMessage = "Los Antededentes Médicos son obligatorios.")]
        [Display(Name = "Antecedentes Médicos")] 
        public string AntecedentesMedicos {get;set;} // Antecedentes médicos del Paciente 
        [Display(Name = "Motivo de la Consulta")] 
        public MotivoConsulta MotivoConsulta {get;set;} // Motivo de consulta del Paciente
        [Display(Name = "Observaciones (opcional)")]         
        public string Observaciones {get;set;} // Observaciones del Paciente
    }
}
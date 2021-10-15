using System;
using System.ComponentModel.DataAnnotations;

namespace AgendamientoIPS.App.Dominio
{
    public class Cita
    {
        public int Id {get;set;} // Identificación de clase Cita
        [Display(Name = "Tipo de Cita")]
        public TipoCita TipoCita {get;set;} // Cita Presencial o Virtual
        [Display(Name = "Número de Cita")]
        public int NumCita {get;set;} // Número de Cita a nivel sistema
        [Required(ErrorMessage = "La Especialidad es obligatoria.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Especialidad")]
        public string Especialidad {get;set;} // Especialidad de la cita pedida por el paciente
        [Display(Name = "Hora de la Cita")]
        public TimeSpan Hora {get;set;} // Hora de la Cita
        [Display(Name = "Fecha de la Cita")]
        public DateTime Fecha {get;set;} // Fecha de la Cita
        [Display(Name = "Nombre del Médico Asignado")]
        public Medico IdMedico {get;set;} // Id del médico asignado
        public Paciente IdPaciente {get;set;} // Id del paciente
        public Sede IdSede {get;set;} // Ubicación de la Cita
    }
} 
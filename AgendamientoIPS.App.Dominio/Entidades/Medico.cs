using System;
using System.ComponentModel.DataAnnotations;


namespace AgendamientoIPS.App.Dominio
{
    public class Medico : Persona
    {
        [Required(ErrorMessage = "La Tarjeta Profesional es obligatoria.")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres")]
        [Display(Name = "Tarjeta Profesional")] 
        public string TarjetaProfesional {get;set;} // Número de tarjeta profesional (único), se trabaja en string
        [Required(ErrorMessage = "La Especialidad es obligatoria.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Especialidad Médica")]         
        public string Especialidad {get;set;} // Nombre de la especialidad medica del Médico 
    }
}
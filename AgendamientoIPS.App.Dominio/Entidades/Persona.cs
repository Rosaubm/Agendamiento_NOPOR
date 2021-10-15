using System;
using System.ComponentModel.DataAnnotations;

namespace AgendamientoIPS.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;} // Identificación de clase Persona
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Nombre")] 
        public string Nombre {get;set;} // Nombre de Persona
        [Required(ErrorMessage = "El Primer Apellido es obligatorio.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido {get;set;} // Primer Apellido de Persona
        [Required(ErrorMessage = "El Segundo Apellido es obligatorio.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido {get;set;} // Segundo Apellido de Persona
        [Required(ErrorMessage = "La Dirección es obligatoria.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Dirección")]
        public string Direccion {get;set;} // Dirección de Persona
        [Required(ErrorMessage = "El Teléfono es obligatorio.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Teléfono")]
        public string Telefono {get;set;} // Teléfono de Persona
        [Required(ErrorMessage = "El Correo Electrónico es obligatorio.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Correo Electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Correo {get;set;} // Correo de Persona
        public EPS EPS {get;set;} // EPS de Persona
    }
} 
using System;
using System.ComponentModel.DataAnnotations;

namespace AgendamientoIPS.App.Dominio
{
    public class Sede
    {
        public int Id {get;set;} // Identificación de clase Sede 
        [Required(ErrorMessage = "El NIT es obligatorio.")]
        [StringLength(11, ErrorMessage = "Máximo 11 caracteres")]
        [Display(Name = "NIT")] 
        public string Nit {get;set;} // Nit de la Sede
        public Ciudad Ciudad {get;set;} // Ciudad de Sede
        [Required(ErrorMessage = "La Dirección es obligatoria.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Dirección")] 
        public string Direccion {get;set;} // Dirección de Sede
        [Required(ErrorMessage = "El Teléfono es obligatorio.")]
        [Display(Name = "Teléfono")] 
        public string Telefono {get;set;} // Teléfono de Sede
        public NombreSede NombreSede {get;set;} // Nombre de la Sede
        public HorarioAtencion HorarioAtencion {get;set;} // Horario de Atención 
        [Required(ErrorMessage = "La Ubicación es obligatorio.")]       
        [Display(Name = "Número de Ubicación")]         
        public int Ubicacion {get;set;} // Ubicación de Sede 
    }
}
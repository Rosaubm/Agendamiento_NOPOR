using System;
using System.ComponentModel.DataAnnotations;


namespace AgendamientoIPS.App.Dominio
{
    public class Convenio
    {
        public int Id {get;set;} // Identificación de clase Convenio
        [Required(ErrorMessage = "El Número del Convenio es obligatorio.")]
        [StringLength(8, ErrorMessage = "Máximo 8 caracteres")]
        [Display(Name = "Número del Convenio")] 
        public string NumConvenio {get;set;} // Número de Convenio
        public EPS EPS {get;set;} // EPS de Convenio
        [Required(ErrorMessage = "El Descuento es obligatorio.")]
        [Display(Name = "Descuento")]        
        public int Descuento {get;set;} // Descuento por convenio
    }
} 
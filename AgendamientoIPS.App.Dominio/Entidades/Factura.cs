using System;
using System.ComponentModel.DataAnnotations;

namespace AgendamientoIPS.App.Dominio
{
    public class Factura
    {
        public int Id {get;set;} // Identificación de clase Facturación
        [Display(Name = "Número de la Cita Asociada")] 
        public Cita Cita {get;set;} // Información del paciente en Cita
        [Display(Name = "Número de Factura")]         
        public int NumFactura {get;set;} // Número de la factura
        [Display(Name = "Fecha de la Factura")]         
        public DateTime FechaFactura {get;set;} //Fecha facturación
        [Required(ErrorMessage = "El Concepto es obligatorio.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Concepto")]         
        public string Concepto {get;set;} // Resumen
        [Required(ErrorMessage = "La Tarifa Aplicada es obligatoria.")]
        [Display(Name = "Tarifa Aplicada")] 
        [Range(1, int.MaxValue, ErrorMessage = "El valor no puede ser 0")]                
        public int TarifaAplicada {get;set;} // Tarifa de Consulta
        [Required(ErrorMessage = "El Valor Pagado es obligatorio.")]
        [Display(Name = "Valor Pagado")]  
        [Range(1, int.MaxValue, ErrorMessage = "El valor no puede ser 0")]                 
        public int ValorPagado {get;set;} // Valor pagado
        [Required(ErrorMessage = "La Forma de Pago es obligatoria.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Forma de Pago")]         
        public string FormadePago {get;set;} // Forma en que fue pagado
        [Display(Name = "Convenio Aplicado")] 
        public Convenio IdConvenio {get;set;} // Convenio aplicado a la factura
    }
} 
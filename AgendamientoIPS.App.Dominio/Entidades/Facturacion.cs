using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Facturacion
    {
        public int Id {get;set;} // Identificación de clase Facturación
        public Cita Cita {get;set;} // Información del paciente en Cita
        public int NumFactura {get;set;} // Número de la factura
        public DateTime FechaFactura {get;set;} //Fecha facturación
        public string Concepto {get;set;} // Resumen
        public int TarifaAplicada {get;set;} // Tarifa de Consulta
        public int ValorPagado {get;set;} // Valor pagado
        public string FormadePago {get;set;} // Forma en que fue pagado
    }
} 
using System;

namespace AgendamientoIPS.App.Dominio
{
    public class FacturacionConsulta
    {
        public Int IdPaciente {get;set;} 
        public String NumeroFactura {get;set;} 
        public DateTime HorarioCita {get;set;} 
        public String Concepto {get;set;}
        public Int TarigaAplicada {get;set;}
        public Int ValorPagado {get;set;}
        public String FormadePago {get;set;}
        public Convenios Convenios {get;set;} // Información que relaciona el convenio con el paciente
    }
} 
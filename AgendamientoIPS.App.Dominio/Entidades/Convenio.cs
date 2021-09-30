using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Convenio
    {
        public int Id {get;set;} // Identificación de clase Convenio
        public string NumConvenio {get;set;} // Número de Convenio
        public EPS EPS {get;set;} // EPS de Convenio
        public int Descuento {get;set;} // Descuento por convenio
    }
} 
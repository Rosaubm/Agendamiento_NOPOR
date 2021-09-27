using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Sedes : IPSSaludIntegral
    {
        public int IDSede {get;set;} // ID de Sede 
        public string CiudadSede {get;set;} // Ciudad de Sede
        public string DireccionSede {get;set;} // Dirección de Sede
        public string TelefonoSede {get;set;} // Teléfono de Sede
    }
} 
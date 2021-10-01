using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Sede
    {
        public int Id {get;set;} // Identificación de clase Sede 
        public string Nit {get;set;} // Nit de la Sede
        public Ciudad Ciudad {get;set;} // Ciudad de Sede
        public string Direccion {get;set;} // Dirección de Sede
        public string Telefono {get;set;} // Teléfono de Sede
        public NombreSede NombreSede {get;set;} // Nombre de la Sede
        public HorarioAtencion HorarioAtencion {get;set;} // Horario de Atención 
    }
} 
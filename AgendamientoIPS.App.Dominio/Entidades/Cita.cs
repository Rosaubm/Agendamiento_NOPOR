using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Cita : Sede
    {
        public Boolean Presencial {get;set;} // Cita Presencial si o no 
        public Boolean Virtual {get;set;} // Cita Virtual si o no 
        public DateTime HorarioCita {get;set;} // Horario de Cita
        public Boolean Programación {get;set;} // Cita Programada si o no 
        public Boolean Cancelacion {get;set;} // Cita Cancelada si o no 
    }
} 
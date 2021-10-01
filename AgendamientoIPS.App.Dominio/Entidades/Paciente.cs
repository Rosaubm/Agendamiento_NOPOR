using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Paciente : Persona
    {
        public Encuesta Encuesta {get;set;} // Encuesta realizada por el Paciente 
    }
}
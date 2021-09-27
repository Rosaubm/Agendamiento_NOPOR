using System;

namespace AgendamientoIPS.App.Dominio
{
    public class Paciente : Persona
    {
        public int EPS {get;set;} // EPS del Paciente
        public Genero Genero {get;set;} // Género del Paciente 
    }
}
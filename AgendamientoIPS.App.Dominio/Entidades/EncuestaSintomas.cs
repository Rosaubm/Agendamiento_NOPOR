using System;

namespace AgendamientoIPS.App.Dominio
{
    public class EncuestaSintomas : Paciente
    {
        public string AntecedentesMedicos {get;set;} // Antecedentes médicos del Paciente 
        public string MotivoConsulta {get;set;} // Motivo de consulta del Paciente
        public string CriteriosTipoConsulta {get;set;} // Criterios del tipo de consulta del Paciente
    }
}
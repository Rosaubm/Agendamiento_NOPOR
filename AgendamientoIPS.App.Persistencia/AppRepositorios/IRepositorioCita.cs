using System.Collections.Generic;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public interface IRepositorioCita 
    {
        IEnumerable<Cita> GetAllCitas();
        Cita AddCita(Cita cita);
        Cita UpdateCita(Cita cita);
        void DeleteCita(int idCita);
        Cita GetCita(int idCita);
        Paciente AsignarCitaPaciente(int idCita, int idPaciente);         
        Medico AsignarCitaMedico(int idCita, int idMedico); 
        Sede AsignarCitaSede(int idCita, int idSede);            
    }
}
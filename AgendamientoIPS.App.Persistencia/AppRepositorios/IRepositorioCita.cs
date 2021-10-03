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
        Paciente AsignarPaciente(int idCita, int idPaciente);         
        Medico AsignarMedico(int idCita, int idMedico);            
    }
}
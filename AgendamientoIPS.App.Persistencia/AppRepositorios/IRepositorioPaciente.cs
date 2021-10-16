using System.Collections.Generic;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public interface IRepositorioPaciente 
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        Encuesta AsignarEncuesta(int idPaciente, int idEncuesta);  
        IEnumerable<Paciente> GetPacientesEPS(int eps);                 
        IEnumerable<Paciente> SearchPacientes(string nombre);     
    }
}
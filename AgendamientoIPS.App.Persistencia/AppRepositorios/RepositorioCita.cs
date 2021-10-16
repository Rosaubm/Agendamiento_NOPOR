using System.Collections.Generic;
using System.Linq;
using AgendamientoIPS.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace AgendamientoIPS.App.Persistencia
{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly AppContext _appContext = new AppContext();

        
        Cita IRepositorioCita.AddCita(Cita cita)
        {
            var citaAdicionado = _appContext.Citas.Add(cita);
            _appContext.SaveChanges();
            return citaAdicionado.Entity;
        }

        void IRepositorioCita.DeleteCita(int idCita)
        {
            var citaEncontrado = _appContext.Citas.FirstOrDefault(c => c.Id == idCita);
            if (citaEncontrado == null)
                return;
            _appContext.Citas.Remove(citaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Cita> IRepositorioCita.GetAllCitas()
        {
            return _appContext.Citas;
        }

        Cita IRepositorioCita.GetCita(int idCita)
        {
            var cita = _appContext.Citas
            .Where(c => c.Id == idCita)
            .Include(c => c.IdPaciente)
            .Include(c => c.IdMedico)
            .Include(c => c.IdSede)
            .FirstOrDefault();
            return cita;
        }
        Cita IRepositorioCita.UpdateCita(Cita cita)
        {
            var citaEncontrado = _appContext.Citas.FirstOrDefault(c => c.Id == cita.Id);
            if (citaEncontrado != null)
            {
                citaEncontrado.TipoCita = cita.TipoCita;
                citaEncontrado.NumCita = cita.NumCita;
                citaEncontrado.Especialidad = cita.Especialidad;
                citaEncontrado.Hora = cita.Hora;
                citaEncontrado.Fecha = cita.Fecha;
                citaEncontrado.IdMedico = cita.IdMedico;
                citaEncontrado.IdPaciente = cita.IdPaciente;
                citaEncontrado.IdSede = cita.IdSede;
                
                _appContext.SaveChanges();
            }
            return citaEncontrado;
        }

        Paciente IRepositorioCita.AsignarCitaPaciente(int idCita, int idPaciente)
        { 
            var citaEncontrado = _appContext.Citas.Find(idCita);
            if (citaEncontrado != null)
            { 
                var pacienteEncontrado = _appContext.Pacientes.Find(idPaciente);
                if (pacienteEncontrado != null)
                { 
                    citaEncontrado.IdPaciente = pacienteEncontrado;
                    _appContext.SaveChanges();
                }
            return pacienteEncontrado;
            }
        return null;
        }

        Medico IRepositorioCita.AsignarCitaMedico(int idCita, int idMedico)
        { 
            var citaEncontrado = _appContext.Citas.Find(idCita);
            if (citaEncontrado != null)
            { 
                var medicoEncontrado = _appContext.Medicos.Find(idMedico);
                if (medicoEncontrado != null)
                { 
                    citaEncontrado.IdMedico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
            return medicoEncontrado;
            }
        return null;
        }

        Sede IRepositorioCita.AsignarCitaSede(int idCita, int idSede)
        { 
            var citaEncontrado = _appContext.Citas.Find(idCita);
            if (citaEncontrado != null)
            { 
                var sedeEncontrado = _appContext.Sedes.Find(idSede);
                if (sedeEncontrado != null)
                { 
                    citaEncontrado.IdSede = sedeEncontrado;
                    _appContext.SaveChanges();
                }
            return sedeEncontrado;
            }
        return null;
        }
    }
}
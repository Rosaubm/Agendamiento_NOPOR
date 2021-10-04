using System.Collections.Generic;
using System.Linq;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly AppContext _appContext;

        public RepositorioCita(AppContext appContext)
        {
            _appContext = appContext;
        }

        Cita IRepositorioCita.AddCita(Cita cita)
        {
            var citaAdicionado = _appContext.Citas.Add(cita);
            _appContext.SaveChanges();
            return citaAdicionado.Entity;
        }

        void IRepositorioCita.DeleteCita(int idCita)
        {
            var citaEncontrado = _appContext.Citas.FirstOrDefault(p => p.Id == idCita);
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
            return _appContext.Citas.FirstOrDefault(p => p.Id == idCita);
        }

        Cita IRepositorioCita.UpdateCita(Cita cita)
        {
            var citaEncontrado = _appContext.Citas.FirstOrDefault(p => p.Id == cita.Id);
            if (citaEncontrado != null)
            {
                citaEncontrado.TipoCita = cita.TipoCita;
                citaEncontrado.NumCita = cita.NumCita;
                citaEncontrado.Especialidad = cita.Especialidad;
                citaEncontrado.Hora = cita.Hora;
                citaEncontrado.Fecha = cita.Fecha;
                citaEncontrado.IdMedico = cita.IdMedico;
                citaEncontrado.IdPaciente = cita.IdPaciente;
                citaEncontrado.Ubicacion = cita.Ubicacion;
                
                _appContext.SaveChanges();
            }
            return citaEncontrado;
        }

        Paciente IRepositorioCita.AsignarCitaPaciente(int idCita, int idPaciente)
        { 
            var citaEncontrado = _appContext.Citas.FirstOrDefault(c => c.Id == idCita);
            if (citaEncontrado != null)
            { 
                var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
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
            var citaEncontrado = _appContext.Citas.FirstOrDefault(c => c.Id == idCita);
            if (citaEncontrado != null)
            { 
                var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
                if (medicoEncontrado != null)
                { 
                    citaEncontrado.IdMedico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
            return medicoEncontrado;
            }
        return null;
        }
    }
}
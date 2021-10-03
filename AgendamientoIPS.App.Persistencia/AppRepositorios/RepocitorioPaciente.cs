using System.Collections.Generic;
using System.Linq;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;

        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext;
        }

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }

        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.PrimerApellido = paciente.PrimerApellido;
                pacienteEncontrado.SegundoApellido = paciente.SegundoApellido;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Telefono = paciente.Telefono;
                pacienteEncontrado.Correo = paciente.Correo;
                pacienteEncontrado.EPS = paciente.EPS;

                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }

        Encuesta IRepositorioPaciente.AsignarEncuesta(int idPaciente, int idEncuesta)
        { 
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            { 
                var encuestaEncontrado = _appContext.Encuestas.FirstOrDefault(m => m.Id == idEncuesta);
                if (encuestaEncontrado != null)
                { 
                    pacienteEncontrado.Encuesta = encuestaEncontrado;
                    _appContext.SaveChanges();
                }
            return encuestaEncontrado;
            }
        return null;
        }
    }
}
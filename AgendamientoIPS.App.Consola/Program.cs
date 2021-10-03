using System;
using System.Collections.Generic;
using AgendamientoIPS.App.Dominio;
using AgendamientoIPS.App.Persistencia;

namespace AgendamientoIPS.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioMedico _repoMedico = new RepositorioMedico(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            AddMedico();
            BuscarPaciente(2);
            MostrarPacientes();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Ginger",
                PrimerApellido = "Morgan",
                SegundoApellido = "Chen",
                Direccion = "P.O. Box 554, 8161 Donec Avenue",
                Telefono = "(484) 513-4027",
                Correo = "ipsum.primis@justosit.org",
                EPS = EPS.Ninguna
            };
            _repoPaciente.AddPaciente(paciente);
        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + " " + paciente.PrimerApellido);
        }

        private static void MostrarPacientes()
        {
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine("Nombre paciente: " + paciente.Nombre + " " + paciente.PrimerApellido);
            }
        }

        private static void AddMedico()
        {
            var medico = new Medico
            {
                Nombre = "Tashya",
                PrimerApellido = "Pate",
                SegundoApellido = "Lucas",
                Direccion = "Ap #860-8492 Sapien, St.",
                Telefono = "(421) 925-4922",
                Correo = "facilisis.eget@eu.com",
                EPS = EPS.NuevaEPS,
                TarjetaProfesional = "TP-1417525",
                Especialidad = "Reumatología"
            };
            _repoMedico.AddMedico(medico);
        }
    }
}

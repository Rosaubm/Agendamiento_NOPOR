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
        private static IRepositorioEncuesta _repoEncuesta = new RepositorioEncuesta(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //AddMedico();
            //AddEncuesta();
            BuscarPaciente(2);
            MostrarPacientes();
            BuscarMedico(3);
            MostrarMedicos();
            AsignarEncuesta();
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

        private static void BuscarMedico(int idMedico)
        {
            var medico = _repoMedico.GetMedico(idMedico);
            Console.WriteLine(medico.Nombre + " " + medico.PrimerApellido + " " + medico.TarjetaProfesional);
        }

        private static void MostrarMedicos()
        {
            IEnumerable<Medico> medicos = _repoMedico.GetAllMedicos();
            foreach (var medico in medicos)
            {
                Console.WriteLine("Nombre médico: " + medico.Nombre + " " + medico.PrimerApellido + " " + medico.TarjetaProfesional);
            }
        }

        private static void AddEncuesta()
        {
            var encuesta = new Encuesta
            {
                AntecedentesMedicos = "cursus a, enim. Suspendisse aliquet, sem ut cursus luctus, ipsum leo elementum sem, vitae aliquam eros turpis non enim. Mauris quis turpis vitae purus gravida sagittis. Duis gravida. Praesent eu nulla at sem molestie sodales. Mauris blandit enim consequat purus. Maecenas libero est, congue a, aliquet vel, vulputate eu, odio.",
                MotivoConsulta = MotivoConsulta.Revisión,
                Observaciones = "a feugiat tellus lorem eu metus. In lorem. Donec elementum, lorem ut aliquam iaculis, lacus pede sagittis augue, eu tempor erat neque non quam. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aliquam fringilla cursus purus. Nullam scelerisque neque sed sem egestas blandit. Nam nulla"
            };
            _repoEncuesta.AddEncuesta(encuesta);
        }

        private static void AsignarEncuesta()
        {
            var encuesta = _repoPaciente.AsignarEncuesta(1,1);
            var paciente = _repoPaciente.GetPaciente(1);
            Console.WriteLine("Nombre paciente: " + paciente.Nombre + " " + paciente.PrimerApellido + " quedó asignado a la encuesta: " + encuesta.Id);
        }        
    }
}

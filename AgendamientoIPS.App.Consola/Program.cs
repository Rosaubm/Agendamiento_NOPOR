using System;
using AgendamientoIPS.App.Dominio;
using AgendamientoIPS.App.Persistencia;

namespace AgendamientoIPS.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            BuscarPaciente(1);
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Celeste",
                PrimerApellido = "Best",
                SegundoApellido = "Burks",
                Direccion = "4466 Laoreet Rd.",
                Telefono = "(238) 782-3612",
                Correo = "sed.eu@risus.org",
                EPS = EPS.CoomevaEPS
            };
            _repoPaciente.AddPaciente(paciente);
        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + " " + paciente.PrimerApellido);

        }
    }
}

using System;
using System.Collections.Generic;
using AgendamientoIPS.App.Dominio;
using AgendamientoIPS.App.Persistencia;

namespace AgendamientoIPS.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(); // HASTA ACÁ LLEGAMOS
        private static IRepositorioMedico _repoMedico = new RepositorioMedico(new Persistencia.AppContext());
        private static IRepositorioEncuesta _repoEncuesta = new RepositorioEncuesta(new Persistencia.AppContext());
        private static IRepositorioCita _repoCita = new RepositorioCita(new Persistencia.AppContext());
        private static IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());
        private static IRepositorioConvenio _repoConvenio = new RepositorioConvenio(new Persistencia.AppContext());
        private static IRepositorioFactura _repoFactura = new RepositorioFactura(new Persistencia.AppContext());        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //AddMedico();
            //AddEncuesta();
            //AddCita();
            //AddSede();
            //AddConvenio();
            //AddFactura();
            BuscarPaciente(2);
            MostrarPacientes();
            BuscarMedico(3);
            MostrarMedicos();
            //AsignarEncuesta();
            //AsignarCitaPaciente();            
            //AsignarCitaMedico();
            //AsignarCitaSede();
            AsignarConvenioFactura();
            AsignarCitaFactura();
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

        private static void AddCita()
        {
            var cita = new Cita
            {
                TipoCita = TipoCita.Virtual,
                NumCita = 1,
                Especialidad = "Dolor y cuidados paliativos",
                Hora = new TimeSpan(17,15,10),
                Fecha = new DateTime(2021,12,21),
                IdMedico = null,
                IdPaciente = null,
                IdSede = null
            };
            _repoCita.AddCita(cita);
        }

        private static void AddSede()
        {
            var sede = new Sede
            {
                Nit = "111111111-1",
                Ciudad = Ciudad.Medellín,
                Direccion = "Carrera 1, Calle 1 #1-1",
                Telefono = "(111) 111-1111",
                NombreSede = NombreSede.General,
                HorarioAtencion = HorarioAtencion.EPS,
                Ubicacion = 0,
            };
            _repoSede.AddSede(sede);
        }

        private static void AsignarCitaPaciente()
        {
            var citapaciente = _repoCita.AsignarCitaPaciente(1,1);
            var paciente = _repoPaciente.GetPaciente(1);
            var cita = _repoCita.GetCita(1);
            Console.WriteLine("Nombre paciente: " + paciente.Nombre + " " + paciente.PrimerApellido + " quedó asignado a la cita: " + cita.NumCita);
        }

        private static void AsignarCitaMedico()
        {
            var citamedico = _repoCita.AsignarCitaMedico(1,3);
            var medico = _repoMedico.GetMedico(3);
            var cita = _repoCita.GetCita(1);            
            Console.WriteLine("Nombre médico: " + medico.Nombre + " " + medico.PrimerApellido + " quedó asignado a la cita: " + cita.NumCita);
        }

        private static void AsignarCitaSede()
        {
            var citasede = _repoCita.AsignarCitaSede(1,1);
            var sede = _repoSede.GetSede(1);
            var cita = _repoCita.GetCita(1);            
            Console.WriteLine("La cita: " + cita.NumCita + " quedó asignada a la sede: " + sede.Id);
        }

        private static void AddConvenio()
        {
            var convenio = new Convenio
            {
                NumConvenio = "A-111111",
                EPS = EPS.Sanitas,
                Descuento = 20
            };
            _repoConvenio.AddConvenio(convenio);
        }    
        
        private static void AddFactura()
        {
            var factura = new Factura
            {
                Cita = null,
                NumFactura = 1,
                FechaFactura = new DateTime(2021,12,21),
                Concepto = "In tincidunt congue turpis. In condimentum. Donec at arcu. Vestibulum",
                TarifaAplicada = 91967,
                ValorPagado = 73574,
                FormadePago = "Tarjeta Débito",
                IdConvenio = null
            };
            _repoFactura.AddFactura(factura);
        }

        private static void AsignarConvenioFactura()
        {
            var conveniofactura = _repoFactura.AsignarConvenioFactura(1,1);
            var factura = _repoFactura.GetFactura(1);
            var convenio = _repoConvenio.GetConvenio(1);            
            Console.WriteLine("El convenio: " + convenio.Id + " quedó asignado a la factura: " + factura.Id);
        }

        private static void AsignarCitaFactura()
        {
            var citafactura = _repoFactura.AsignarCitaFactura(1,1);
            var factura = _repoFactura.GetFactura(1);
            var cita = _repoCita.GetCita(1);            
            Console.WriteLine("La cita: " + cita.Id + " quedó asignada a la factura: " + factura.Id);
        }    
    }
}

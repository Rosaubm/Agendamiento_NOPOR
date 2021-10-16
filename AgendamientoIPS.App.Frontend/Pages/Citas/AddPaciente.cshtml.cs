using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.FrontEnd.Pages.Citas
{
    public class AddPacienteModel : PageModel
    {
        private readonly IRepositorioCita _repoCita;
        private readonly IRepositorioPaciente _repoPaciente;
        public IEnumerable<Paciente> pacientes {get;set;}
        public Cita cita {get;set;}
        public AddPacienteModel(IRepositorioCita repoCita, IRepositorioPaciente repoPaciente)
        {
            _repoCita = repoCita;
            _repoPaciente = repoPaciente;
        }
        public void OnGet(int id)
        {
            cita = _repoCita.GetCita(id);
            pacientes = _repoPaciente.GetAllPacientes();
        }
        public IActionResult OnPost(int idCita, int idPaciente)
        {
            _repoCita.AsignarCitaPaciente(idCita, idPaciente);
            return RedirectToPage("Details", new{id = idCita});
        }
    }
}
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
    public class AddMedicoModel : PageModel
    {
        private readonly IRepositorioCita _repoCita;
        private readonly IRepositorioMedico _repoMedico;
        public IEnumerable<Medico> medicos {get;set;}
        public Cita cita {get;set;}
        public AddMedicoModel(IRepositorioCita repoCita, IRepositorioMedico repoMedico)
        {
            _repoCita = repoCita;
            _repoMedico = repoMedico;
        }
        public void OnGet(int id)
        {
            cita = _repoCita.GetCita(id);
            medicos = _repoMedico.GetAllMedicos();
        }
        public IActionResult OnPost(int idCita, int idMedico)
        {
            _repoCita.AsignarCitaMedico(idCita, idMedico);
            return RedirectToPage("Details", new{id = idCita});
        }
    }
}
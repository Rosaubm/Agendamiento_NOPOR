using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace AgendamientoIPS.App.FrontEnd.Pages.Citas
{
    [Authorize]     
    public class AddSedeModel : PageModel
    {
        private readonly IRepositorioCita _repoCita;
        private readonly IRepositorioSede _repoSede;
        public IEnumerable<Sede> sedes {get;set;}
        public Cita cita {get;set;}
        public AddSedeModel(IRepositorioCita repoCita, IRepositorioSede repoSede)
        {
            _repoCita = repoCita;
            _repoSede = repoSede;
        }
        public void OnGet(int id)
        {
            cita = _repoCita.GetCita(id);
            sedes = _repoSede.GetAllSedes();
        }
        public IActionResult OnPost(int idCita, int idSede)
        {
            _repoCita.AsignarCitaSede(idCita, idSede);
            return RedirectToPage("Details", new{id = idCita});
        }
    }
}
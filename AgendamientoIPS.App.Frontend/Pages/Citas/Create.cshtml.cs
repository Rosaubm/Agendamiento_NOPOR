using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Frontend.Pages.Citas
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioCita _repoCita;
        public Cita cita {get;set;}
        public CreateModel(IRepositorioCita repoCita)
        {
            _repoCita = repoCita;
        }
        public void OnGet()
        {
            cita = new Cita();
        }
        public IActionResult OnPost(Cita cita)
        {
            _repoCita.AddCita(cita);
            return RedirectToPage("Index");
        }
    }
}
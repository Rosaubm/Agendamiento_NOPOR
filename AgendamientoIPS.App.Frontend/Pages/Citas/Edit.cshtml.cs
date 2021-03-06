using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace AgendamientoIPS.App.Frontend.Pages.Citas
{
    [Authorize] 
    public class EditModel : PageModel
    {
        private readonly IRepositorioCita _repoCita;
        public Cita cita {get;set;} //propiedad tipo cita
        public EditModel(IRepositorioCita repoCita) //constructor
        {
            _repoCita = repoCita;
        }
        public IActionResult OnGet(int id)
        {
            cita = _repoCita.GetCita(id);
            if(cita == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Cita cita)
        {
            if (ModelState.IsValid)
            {
                _repoCita.UpdateCita(cita);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Frontend.Pages.Pacientes
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente {get;set;} //propiedad tipo paciente
        public CreateModel(IRepositorioPaciente repoPaciente) //constructor
        {
            _repoPaciente = repoPaciente;
        }
        public void OnGet()
        {
            paciente = new Paciente();
        }
        public IActionResult OnPost(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _repoPaciente.AddPaciente(paciente);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}

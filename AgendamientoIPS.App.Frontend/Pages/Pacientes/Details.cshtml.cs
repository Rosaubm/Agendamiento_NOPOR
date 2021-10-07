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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente {get;set;} //propiedad tipo paciente
        public DetailsModel(IRepositorioPaciente repoPaciente) //constructor
        {
            _repoPaciente = repoPaciente;
        }
        public IActionResult OnGet(int id)
        {
            paciente = _repoPaciente.GetPaciente(id);
            if(paciente == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}

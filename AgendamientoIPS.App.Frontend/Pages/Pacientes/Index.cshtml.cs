using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Dominio;
using AgendamientoIPS.App.Persistencia;

namespace AgendamientoIPS.App.Frontend.Pages.Pacientes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public IEnumerable<Paciente> pacientes {get;set;}
        public int gActual {get;set;}
        public IndexModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        }
        public void OnGet(int? g)
        {
            if (g.HasValue && g.Value !=-1)
            {
                gActual = g.Value;
                pacientes = repoPacientesGenero(g.Value);
            }

            else 
            {
                gActual = -1;
                pacientes = _repoPaciente.GetAllPacientes();

            }

            
        }
    }
}

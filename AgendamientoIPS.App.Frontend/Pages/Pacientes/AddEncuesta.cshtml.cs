using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.FrontEnd.Pages.Pacientes
{
    public class AddEncuestaModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioEncuesta _repoEncuesta;
        public IEnumerable<Encuesta> encuestas {get;set;}
        public Paciente paciente {get;set;}
        public AddEncuestaModel(IRepositorioEncuesta repoEncuesta, IRepositorioPaciente repoPaciente)
        {
            _repoEncuesta = repoEncuesta;
            _repoPaciente = repoPaciente;
        }
        public void OnGet(int id)
        {
            paciente = _repoPaciente.GetPaciente(id);
            encuestas = _repoEncuesta.GetAllEncuestas();
        }
        public IActionResult OnPost(int idPaciente, int idEncuesta)
        {
            _repoPaciente.AsignarEncuesta(idPaciente, idEncuesta);
            return RedirectToPage("Details", new{id = idPaciente});
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Frontend.Pages.Medicos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public Medico medico {get;set;}
        public CreateModel(IRepositorioMedico repoMedico)
        {
            _repoMedico = repoMedico;
        }
        public void OnGet()
        {
            medico = new Medico();
        }
        public IActionResult OnPost(Medico medico)
        {
            _repoMedico.AddMedico(medico);
            return RedirectToPage("Index");
        }
    }
}

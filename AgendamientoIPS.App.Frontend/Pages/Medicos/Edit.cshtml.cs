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
    public class EditModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public Medico medico {get;set;} //propiedad tipo médico
        public EditModel(IRepositorioMedico repoMedico) //constructor
        {
            _repoMedico = repoMedico;
        }
        public IActionResult OnGet(int id)
        {
            medico = _repoMedico.GetMedico(id);
            if(medico == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Medico medico)
        {
            _repoMedico.UpdateMedico(medico);
            return RedirectToPage("Index");
        }
    }
}

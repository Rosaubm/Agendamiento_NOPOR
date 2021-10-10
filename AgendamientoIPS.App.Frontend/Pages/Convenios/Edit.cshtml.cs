using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Frontend.Pages.Convenios
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioConvenio _repoConvenio;
        public Convenio convenio {get;set;} //propiedad tipo convenio
        public EditModel(IRepositorioConvenio repoConvenio) //constructor
        {
            _repoConvenio = repoConvenio;
        }
        public IActionResult OnGet(int id)
        {
            convenio = _repoConvenio.GetConvenio(id);
            if(convenio == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Convenio convenio)
        {
            _repoConvenio.UpdateConvenio(convenio);
            return RedirectToPage("Index");
        }
    }
}
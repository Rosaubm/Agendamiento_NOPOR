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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioConvenio _repoConvenio;
        public Convenio convenio {get;set;}
        public CreateModel(IRepositorioConvenio repoConvenio)
        {
            _repoConvenio = repoConvenio;
        }
        public void OnGet()
        {
            convenio = new Convenio();
        }
        public IActionResult OnPost(Convenio convenio)
        {
            _repoConvenio.AddConvenio(convenio);
            return RedirectToPage("Index");
        }
    }
}
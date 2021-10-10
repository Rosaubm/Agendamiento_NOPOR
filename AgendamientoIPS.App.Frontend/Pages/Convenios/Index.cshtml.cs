using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Dominio;
using AgendamientoIPS.App.Persistencia;

namespace AgendamientoIPS.App.Frontend.Pages.Convenios
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioConvenio _repoConvenio;
        public IEnumerable<Convenio> convenios {get;set;}
        public IndexModel(IRepositorioConvenio repoConvenio)
        {
            _repoConvenio = repoConvenio;
        }
        public void OnGet()
        {
            convenios = _repoConvenio.GetAllConvenios();
        }
    }
}
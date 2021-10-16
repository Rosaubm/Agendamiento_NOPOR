using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.FrontEnd.Pages.Facturas
{
    public class AddConvenioModel : PageModel
    {
        private readonly IRepositorioFactura _repoFactura;
        private readonly IRepositorioConvenio _repoConvenio;
        public IEnumerable<Convenio> convenios {get;set;}
        public Factura factura {get;set;}
        public AddConvenioModel(IRepositorioFactura repoFactura, IRepositorioConvenio repoConvenio)
        {
            _repoFactura = repoFactura;
            _repoConvenio = repoConvenio;
        }
        public void OnGet(int id)
        {
            factura = _repoFactura.GetFactura(id);
            convenios = _repoConvenio.GetAllConvenios();
        }
        public IActionResult OnPost(int idFactura, int idConvenio)
        {
            _repoFactura.AsignarConvenioFactura(idFactura, idConvenio);
            return RedirectToPage("Details", new{id = idFactura});
        }
    }
}
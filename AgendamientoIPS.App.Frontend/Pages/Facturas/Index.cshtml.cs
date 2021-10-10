using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Dominio;
using AgendamientoIPS.App.Persistencia;

namespace AgendamientoIPS.App.Frontend.Pages.Facturas
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioFactura _repoFactura;
        public IEnumerable<Factura> facturas {get;set;}
        public IndexModel(IRepositorioFactura repoFactura)
        {
            _repoFactura = repoFactura;
        }
        public void OnGet()
        {
            facturas = _repoFactura.GetAllFacturas();
        }
    }
}

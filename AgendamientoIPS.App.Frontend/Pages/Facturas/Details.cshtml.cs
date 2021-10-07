using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Frontend.Pages.Facturas
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioFactura _repoFactura;
        public Factura factura {get;set;}
        public DetailsModel(IRepositorioFactura repoFactura)
        {
            _repoFactura = repoFactura;
        }
        public IActionResult OnGet(int id)
        {
            factura = _repoFactura.GetFactura(id);
            if(factura == null)
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

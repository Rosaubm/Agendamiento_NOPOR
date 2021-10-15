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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioFactura _repoFactura;
        public Factura factura {get;set;}
        public CreateModel(IRepositorioFactura repoFactura)
        {
            _repoFactura = repoFactura;
        }
        public void OnGet()
        {
            factura = new Factura();
        }
        public IActionResult OnPost(Factura factura)
        {
            if (ModelState.IsValid)
            {
                _repoFactura.AddFactura(factura);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}

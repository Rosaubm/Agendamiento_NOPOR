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
    public class EditModel : PageModel
    {
        private readonly IRepositorioFactura _repoFactura;
        public Factura factura {get;set;} //propiedad tipo factura
        public EditModel(IRepositorioFactura repoFactura) //constructor
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
        public IActionResult OnPost(Factura factura)
        {
            if (ModelState.IsValid)
            {
                _repoFactura.UpdateFactura(factura);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}

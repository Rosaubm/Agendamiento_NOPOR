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
    public class AddCitaModel : PageModel
    {
        private readonly IRepositorioFactura _repoFactura;
        private readonly IRepositorioCita _repoCita;
        public IEnumerable<Cita> citas {get;set;}
        public Factura factura {get;set;}
        public AddCitaModel(IRepositorioFactura repoFactura, IRepositorioCita repoCita)
        {
            _repoFactura = repoFactura;
            _repoCita = repoCita;
        }
        public void OnGet(int id)
        {
            factura = _repoFactura.GetFactura(id);
            citas = _repoCita.GetAllCitas();
        }
        public IActionResult OnPost(int idFactura, int idCita)
        {
            _repoFactura.AsignarCitaFactura(idFactura, idCita);
            return RedirectToPage("Details", new{id = idFactura});
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoIPS.App.Persistencia;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Frontend.Pages.Encuestas
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioEncuesta _repoEncuesta;
        public Encuesta encuesta {get;set;} //propiedad tipo encuesta
        public EditModel(IRepositorioEncuesta repoEncuesta) //constructor
        {
            _repoEncuesta = repoEncuesta;
        }
        public IActionResult OnGet(int id)
        {
            encuesta = _repoEncuesta.GetEncuesta(id);
            if(encuesta == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Encuesta encuesta)
        {
            if (ModelState.IsValid)
            {
                _repoEncuesta.UpdateEncuesta(encuesta);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}


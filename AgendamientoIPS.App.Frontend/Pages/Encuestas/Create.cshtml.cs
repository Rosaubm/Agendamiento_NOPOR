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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioEncuesta _repoEncuesta;
        public Encuesta encuesta {get;set;}
        public CreateModel(IRepositorioEncuesta repoEncuesta)
        {
            _repoEncuesta = repoEncuesta;
        }
        public void OnGet()
        {
            encuesta = new Encuesta();
        }
        public IActionResult OnPost(Encuesta encuesta)
        {
            if (ModelState.IsValid)
            {
                _repoEncuesta.AddEncuesta(encuesta);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}


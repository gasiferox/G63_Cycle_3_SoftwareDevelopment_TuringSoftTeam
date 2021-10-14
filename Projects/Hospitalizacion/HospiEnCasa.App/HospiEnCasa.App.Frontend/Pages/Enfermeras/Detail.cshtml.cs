using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Frontend.Pages.Enfermeras
{
    public class DetailModel : PageModel
    {
        private readonly IRepositorioEnfermera _repositorioEnfermera;
        public IEnumerable<Enfermera> Enfermeras { get; set; }
        public Enfermera Enfermera { get; set; }
        public DetailModel()
        {
            this._repositorioEnfermera = new RepositorioEnfermera(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idEnfermera)
        {
            Enfermera = _repositorioEnfermera.GetEnfermera(idEnfermera);
            if (Enfermera == null)
            {
                return RedirectToPage("./NotFound");                
            }
            else
            {
                return Page();
            }
        }
    }
}

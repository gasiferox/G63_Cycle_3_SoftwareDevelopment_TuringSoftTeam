using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio.Entidades;
using HospiEnCasa.App.Persistencia.AppRepositorios;

namespace HospiEnCasa.App.Frontend.Pages.Medicos
{
    public class DetailModel : PageModel
    {
        private readonly IRepositorioMedico _repositorioMedico;
        public Medico Medico { get; set; }
        public DetailModel()
        {
            this._repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idMedico)
        {
            Medico = _repositorioMedico.GetMedico(idMedico);
            if (Medico == null)
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

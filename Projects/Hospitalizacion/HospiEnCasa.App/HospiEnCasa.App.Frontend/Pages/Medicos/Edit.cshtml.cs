using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Frontend.Pages.Medicos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioMedico _repositorioMedico;
        [BindProperty]
        public Medico Medico { get; set; }
        public EditModel()
        {
            this._repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? idMedico)
        {
            if (idMedico.HasValue)
            {
                Medico = _repositorioMedico.GetMedico(idMedico.Value);
            }
            else
            {
                Medico = new Medico();
            }
            if (Medico == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return Page();
            }
            if (Medico.Id > 0)
            {
                Medico = _repositorioMedico.UpdateMedico(Medico);
            }
            else
            {
                _repositorioMedico.AddMedico(Medico);
            }
            return Page();
        }
    }
}

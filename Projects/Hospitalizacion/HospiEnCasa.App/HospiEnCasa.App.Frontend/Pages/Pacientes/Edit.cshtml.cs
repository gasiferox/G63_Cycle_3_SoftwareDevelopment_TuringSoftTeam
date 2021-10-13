using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioPaciente _repositorioPaciente;
        [BindProperty]
        public Paciente Paciente { get; set; }
        public Genero Genero { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public EditModel()
        {
            this._repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? idPaciente)
        {
            if (idPaciente.HasValue)
            {
                Paciente = _repositorioPaciente.GetPaciente(idPaciente.Value);
            }
            else
            {
                Paciente = new Paciente();
            }
            if (Paciente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Paciente.Id > 0)
            {
                Paciente = _repositorioPaciente.UpdatePaciente(Paciente);
            }
            else
            {
                _repositorioPaciente.AddPaciente(Paciente);
            }
            return Page();
        }
    }
}

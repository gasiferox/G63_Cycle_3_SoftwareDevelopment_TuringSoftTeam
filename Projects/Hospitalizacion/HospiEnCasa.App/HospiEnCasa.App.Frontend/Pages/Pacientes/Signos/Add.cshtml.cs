using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Frontend.Pages.Pacientes.Signos
{
    public class AddModel : PageModel
    {
        private readonly IRepositorioPaciente _repositorioPaciente;
        [BindProperty]
        public SignoVital SignoVital { get; set; }
        public Paciente Paciente { get; set; }
        public AddModel()
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

        public IActionResult OnPost(int idPaciente)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            SignoVital = _repositorioPaciente.AddSignosPaciente(idPaciente, SignoVital);
            Console.WriteLine("Paciente agregado con éxito");
            return Page();
        }
    }
}

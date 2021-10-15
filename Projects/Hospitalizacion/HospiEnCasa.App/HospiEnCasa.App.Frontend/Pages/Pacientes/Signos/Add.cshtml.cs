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
        /* public IEnumerable<SignoVital> SignosVitales { get; set; } */
        public Paciente Paciente { get; set; }
        public AddModel()
        {
            this._repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idPaciente)
        {
            var paciente = _repositorioPaciente.GetSignosPaciente(idPaciente);
            return Page();
            /* if (idPaciente.HasValue)
            {
                paciente = _repositorioPaciente.GetSignosPaciente(idPaciente.Value);
                Console.WriteLine("signos de paciente encontrados");
            }
            else
            {
                paciente = new Paciente();
            }
            if (Paciente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page(); */
        }

        public IActionResult OnPost(int idPaciente)
        {
            /* var paciente = _repositorioPaciente.GetSignosPaciente(idPaciente); */
            if (!ModelState.IsValid)
            {
                return Page();
            }
            /* if (Paciente.Id > 0)
            {
                SignosVitales = _repositorioPaciente.UpdatePaciente(Paciente);
                Console.WriteLine("Paciente actualizado con éxito");
            }
            else
            {
                SignosVitales = _repositorioPaciente.AddPaciente(Paciente);
                Console.WriteLine("Paciente agregado con éxito");
            }
            return Page(); */
            if (Paciente != null)
            {
                _repositorioPaciente.AddPaciente(Paciente);
            }
            return Page();
        }
    }
}

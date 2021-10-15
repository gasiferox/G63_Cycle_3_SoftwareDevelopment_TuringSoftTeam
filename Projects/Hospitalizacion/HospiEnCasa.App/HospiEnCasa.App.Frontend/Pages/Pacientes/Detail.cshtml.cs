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
    public class DetailModel : PageModel
    {
        private readonly IRepositorioPaciente _repositorioPaciente;
        public Paciente Paciente { get; set; }
        public FamiliarDesignado FamiliarDesignado { get; set; }
        public DetailModel()
        {
            this._repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        }
        /* public IActionResult OnGet(int idPaciente)
        {
            Paciente = _repositorioPaciente.GetPaciente(idPaciente);
            if (Paciente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        } */

        public IActionResult OnGet(int idPaciente)
        {
            Paciente = _repositorioPaciente.GetPaciente(idPaciente);
            if (Paciente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                FamiliarDesignado = _repositorioPaciente.GetFamiliarDesignado(idPaciente);
                return Page();
        }

        /* public void OnGetFamiliar(int? idPaciente)
        {
            if (idPaciente.HasValue)
            {
                Paciente = _repositorioPaciente.GetPaciente(idPaciente.Value);
            }

            if (Paciente == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {
                FamiliarDesignado = _repositorioPaciente.GetFamiliarDesignado(idPaciente.Value);
            }
        } */
    }
}

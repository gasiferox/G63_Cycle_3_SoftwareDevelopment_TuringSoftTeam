using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio.Entidades;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.App.Frontend.Pages.Pacientes.Signos
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioPaciente _repositorioPaciente;
        [BindProperty]
        public Paciente Paciente { get; set; }
        public IEnumerable<SignoVital> SignosPaciente { get; set; }
        public ListModel()
        {
            this._repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public void OnGet(int? idPaciente)
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
                SignosPaciente = _repositorioPaciente.GetSignosPaciente(idPaciente.Value);
            }
        }
    }
}

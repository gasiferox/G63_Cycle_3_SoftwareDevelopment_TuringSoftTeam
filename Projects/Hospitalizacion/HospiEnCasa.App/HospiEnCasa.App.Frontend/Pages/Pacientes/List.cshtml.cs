using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio.Entidades;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.App.Frontend.Pages
{
    /* [Authorize] */
    public class ListModel : PageModel
    {
        private readonly IRepositorioPaciente _repositorioPaciente;
        public IEnumerable<Paciente> Pacientes { get; set; }
        public ListModel()
        {
            this._repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public void OnGet(string FiltroBusqueda)
        {
            Pacientes = _repositorioPaciente.GetAllPacientes();
        }
    }
}

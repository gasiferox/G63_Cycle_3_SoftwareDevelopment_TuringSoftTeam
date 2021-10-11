using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio.Entidades;
using HospiEnCasa.App.Persistencia.AppRepositorios;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        /* private static HospiEnCasa.App.Persistencia.AppRepositorios.IRepositorioPaciente _repoPaciente = new HospiEnCasa.App.Persistencia.AppRepositorios.RepositorioPaciente(new Persistencia.AppContext()); */
        private readonly IRepositorioPaciente repositorioPaciente;
        public IEnumerable<Paciente> Pacientes { get; set; }
        public ListModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }
        public void OnGet()
        {
            Pacientes = repositorioPaciente.GetAllPacientes();
        }
    }
}

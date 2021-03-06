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
    public class ListModel : PageModel
    {
        private readonly IRepositorioMedico _repositorioMedico;
        public IEnumerable<Medico> Medicos { get; set; }
        public Medico Medico { get; set; }
        public ListModel()
        {
            this._repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Medicos = _repositorioMedico.GetAllMedicos();
        }
    }
}

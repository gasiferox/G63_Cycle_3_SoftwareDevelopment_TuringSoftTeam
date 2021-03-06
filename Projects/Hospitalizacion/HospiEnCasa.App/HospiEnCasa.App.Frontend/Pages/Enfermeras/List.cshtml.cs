using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio.Entidades;
using HospiEnCasa.App.Persistencia.AppRepositorios;

namespace HospiEnCasa.App.Frontend.Pages.Enfermeras
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioEnfermera _repositorioEnfermera;
        public IEnumerable<Enfermera> Enfermeras { get; set; }
        public Enfermera Enfermera { get; set; }
        public ListModel()
        {
            this._repositorioEnfermera = new RepositorioEnfermera(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Enfermeras = _repositorioEnfermera.GetAllEnfermeras();
        }
    }
}

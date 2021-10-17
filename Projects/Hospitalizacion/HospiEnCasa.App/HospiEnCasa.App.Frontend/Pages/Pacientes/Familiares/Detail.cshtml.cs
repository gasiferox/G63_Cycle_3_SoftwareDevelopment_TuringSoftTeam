using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Frontend.Pages.Pacientes.Familiares
{
    public class DetailModel : PageModel
    {
        private readonly IRepositorioFamiliar _repositorioFamiliar;
        public FamiliarDesignado FamiliarDesignado { get; set; }
        public Paciente Paciente { get; set; }
        public DetailModel()
        {
            this._repositorioFamiliar = new RepositorioFamiliar(new HospiEnCasa.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idFamiliarDesignado)
        {
            FamiliarDesignado = _repositorioFamiliar.GetFamiliarDesignado(idFamiliarDesignado);
            if (FamiliarDesignado == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}

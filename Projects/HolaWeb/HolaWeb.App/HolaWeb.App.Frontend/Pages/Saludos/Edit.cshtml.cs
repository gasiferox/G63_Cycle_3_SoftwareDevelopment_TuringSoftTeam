using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolaWeb.App.Persistencia.AppRepositorios;
using HolaWeb.App.Dominio.Entity;

namespace HolaWeb.App.Frontend.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioSaludos repositorioSaludos;
        public Saludo Saludo { get; set; }

        public EditModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos = repositorioSaludos;
        }
        public IActionResult OnGet(int IdSaludo)
        {
            Saludo = repositorioSaludos.GetSaludoPorId(IdSaludo);
            if(Saludo == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}

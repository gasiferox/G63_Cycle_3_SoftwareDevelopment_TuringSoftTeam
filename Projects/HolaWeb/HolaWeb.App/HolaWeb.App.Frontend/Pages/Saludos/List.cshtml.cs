using System.Collections;
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
    public class ListModel : PageModel
    {
        /* 
        1. Creamos un atributo del tipo arreglo con un conjunto de saludos.
        2. Creamos una propiedad del tipo lista que maneja objetos.
        3. En el método OnGet instanciamos un objeto del tipo Lista y le adicionamos todos los saludos del arreglo inicial
         */
        /* private string[] saludos = {"Buenos días", "Buenas tardes", "Buenas noches", "Hasta mañana"};
        public List<string> ListaSaludos { get; set; }
        public void OnGet()
        {
            ListaSaludos = new List<string>();
            ListaSaludos.AddRange(saludos);
        } */

        private readonly IRepositorioSaludos repositorioSaludos;
        public IEnumerable<Saludo> Saludos { get; set; }

        public ListModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos = repositorioSaludos;
        }
        public void OnGet()
        {
            Saludos = repositorioSaludos.GetAll();
        }
    }
}

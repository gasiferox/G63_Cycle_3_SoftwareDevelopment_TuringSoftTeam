using System;

namespace ProyPeliculas.Shared.Entity
{
    public class Movie
    {
        public int IdMovie { get; set; }
        public string Name { get; set; }
        public string Sinopsis { get; set; }
        public string Image { get; set; }
        public DateTime Premier { get; set; }
        public Category Category { get; set; }
        public Casting Casting { get; set; }
    }

    /* public enum Category
    {
        Terror = 0,
        Suspenso = 1,
        Accion = 2,
        Drama = 3,
        Comedia =4,
        SiFi = 5
    } */
}
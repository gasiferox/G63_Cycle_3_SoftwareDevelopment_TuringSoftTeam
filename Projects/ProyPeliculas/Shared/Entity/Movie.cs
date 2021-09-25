using System;

namespace ProyPeliculas.Shared.Entity
{
    public class Movie
    {
        public string Name { get; set; }
        public string Sinopsis { get; set; }
        public string Image { get; set; }
        public DateTime Premier { get; set; }
        public string Category { get; set; }
        public string Casting { get; set; }
    }
}
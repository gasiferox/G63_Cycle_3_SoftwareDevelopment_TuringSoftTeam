/* using System.Reflection.Metadata.Ecma335; */
using System.ComponentModel.DataAnnotations;
using System;

namespace ProyPeliculas.Shared.Entity
{
    public class Movie
    {
        public int IdMovie { get; set; }
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }
        public string Sinopsis { get; set; }
        public string Image { get; set; }
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public DateTime Premier { get; set; }
        /* Sacamos category ya que va a estar en una relación de muchos a muchos */
        public Category Category { get; set; }
        public Casting Casting { get; set; }
        public string ShortName
        {
            get{
                if (string.IsNullOrWhiteSpace(Name))
                {
                    return null;
                }
                /* if (Name.Length > 60)
                {
                    return NamedArgumentsEncoder.Substring(0,60) + "...";
                } */
                else
                {
                    return Name;
                }
            }
        }
    }

    public enum Category
    {
        Terror = 0,
        Suspenso = 1,
        Accion = 2,
        Drama = 3,
        Comedia =4,
        SiFi = 5
    }
}
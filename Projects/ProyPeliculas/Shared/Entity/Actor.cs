using System;
namespace ProyPeliculas.Shared.Entity
{
    public class Actor : Person
    {
        public int IdActor { get; set; }
        public string ArtisticName { get; set; }
        public DateTime CareerTime { get; set; }
        public string Photo { get; set; }
    }
}